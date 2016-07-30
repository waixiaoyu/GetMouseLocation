Public Class GetWindowLocation

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function GetWindowRect Lib "user32" (ByVal hwnd As Integer, ByRef lpRect As RECT) As Integer
    Structure RECT
        Dim Left As Integer
        Dim Top As Integer
        Dim Right As Integer
        Dim Bottom As Integer
    End Structure
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Run.Click
        Dim MouseX As Integer = System.Windows.Forms.Cursor.Position.X
        TB_MouseX.Text = MouseX

        Dim MouseY As Integer = System.Windows.Forms.Cursor.Position.Y
        TB_MouseY.Text = MouseY


        Dim h As Integer, r As RECT, processName As String
        If TB_ProcessName.Text <> Nothing Then
            processName = TB_ProcessName.Text
            h = FindWindow(vbNullString, processName)
            If h Then
                GetWindowRect(h, r)
                TB_LU.Text = r.Left & "," & r.Top
                TB_RU.Text = r.Right & "," & r.Top
                TB_LB.Text = r.Left & "," & r.Bottom
                TB_RB.Text = r.Right & "," & r.Bottom
                TB_WinSizeHeight.Text = r.Bottom - r.Top
                TB_WinSizeWidth.Text = r.Right - r.Left

                TB_RadioX.Text = (MouseX - r.Left) / (r.Right - r.Left)
                TB_RadioY.Text = (MouseY - r.Top) / (r.Bottom - r.Top)

                If TB_RadioX.Text < 0 Or TB_RadioY.Text < 0 Or TB_RadioX.Text > 1 Or TB_RadioY.Text > 1 Then
                    LB_Warning.Text = "你的鼠标位置已经超出指定的窗口范围!"
                Else
                    LB_Warning.Text = ""
                End If

            Else
                MsgBox("未找到窗口")
            End If
        Else
            MsgBox("请输入程序名称")
        End If


    End Sub





    '全局快捷键
    '声明注册热键API函数  
    Public Declare Function RegisterHotKey Lib "user32" (ByVal hWnd As Integer, ByVal id As Integer,
                                                    ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    '声明注销热键API函数  
    Public Declare Function UnregisterHotKey Lib "user32" (ByVal hWnd As Integer, ByVal id As Integer) As Integer

    Public Const WM_HOTKEY As Short = &H312S '热键消息ID，此值固定，不能修改  
    Public Const MOD_ALT As Short = &H1S  'ALT按键ID  
    Public Const MOD_CONTROL As Short = &H2S  'Ctrl  
    Public Const MOD_SHIFT As Short = &H4S  'Shift  
    Public uVirtKey1, Modifiers, idHotKey As Integer


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        idHotKey = 1 '注册的热键的消息ID，这个值可以随便定义，只要与下面两个参数对应即可  
        Modifiers = MOD_SHIFT '辅助键为Shift  
        uVirtKey1 = Keys.Q   '注册的热键为Shift+Q  

        '注册热键  
        RegisterHotKey(Me.Handle.ToInt32, idHotKey, Modifiers, uVirtKey1) '注册的热键为Shift+Q  
        RegisterHotKey(Me.Handle.ToInt32, 2, MOD_CONTROL, Keys.D) '注册的热键为Ctrl+D。这里和上步一样，我把参数直接写了，没有先赋值，相信大家都明白  

    End Sub
    '窗体的消息处理函数  
    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg = WM_HOTKEY Then '判断是否为热键消息  
            Select Case m.WParam.ToInt32 '判断热键消息的注册ID  
                Case 2
                    Button2_Click(Nothing, Nothing) 'Ctrl+D  
            End Select
        End If

        MyBase.WndProc(m) '循环监听消息  
    End Sub
    '最后别忘记注销热键哦  
    Private Sub GetWindowLocation_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Me.Handle.ToInt32, uVirtKey1)
        UnregisterHotKey(Me.Handle.ToInt32, Keys.D)
    End Sub

End Class