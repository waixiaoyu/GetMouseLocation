<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetWindowLocation
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LB_LeftUp = New System.Windows.Forms.Label()
        Me.LB_RightUp = New System.Windows.Forms.Label()
        Me.BTN_Run = New System.Windows.Forms.Button()
        Me.LB_LeftBottom = New System.Windows.Forms.Label()
        Me.LB_RightBottom = New System.Windows.Forms.Label()
        Me.TB_LU = New System.Windows.Forms.TextBox()
        Me.TB_RU = New System.Windows.Forms.TextBox()
        Me.TB_LB = New System.Windows.Forms.TextBox()
        Me.TB_RB = New System.Windows.Forms.TextBox()
        Me.TB_MouseY = New System.Windows.Forms.TextBox()
        Me.TB_MouseX = New System.Windows.Forms.TextBox()
        Me.LB_Mouse = New System.Windows.Forms.Label()
        Me.LB_InputName = New System.Windows.Forms.Label()
        Me.TB_ProcessName = New System.Windows.Forms.TextBox()
        Me.TB_RadioX = New System.Windows.Forms.TextBox()
        Me.TB_RadioY = New System.Windows.Forms.TextBox()
        Me.LB_Radio = New System.Windows.Forms.Label()
        Me.LB_WinSizeWidth = New System.Windows.Forms.Label()
        Me.TB_WinSizeWidth = New System.Windows.Forms.TextBox()
        Me.LB_WinSizeHeight = New System.Windows.Forms.Label()
        Me.TB_WinSizeHeight = New System.Windows.Forms.TextBox()
        Me.LB_Warning = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LB_LeftUp
        '
        Me.LB_LeftUp.AutoSize = True
        Me.LB_LeftUp.Location = New System.Drawing.Point(12, 9)
        Me.LB_LeftUp.Name = "LB_LeftUp"
        Me.LB_LeftUp.Size = New System.Drawing.Size(41, 12)
        Me.LB_LeftUp.TabIndex = 1
        Me.LB_LeftUp.Text = "左上："
        '
        'LB_RightUp
        '
        Me.LB_RightUp.AutoSize = True
        Me.LB_RightUp.Location = New System.Drawing.Point(136, 9)
        Me.LB_RightUp.Name = "LB_RightUp"
        Me.LB_RightUp.Size = New System.Drawing.Size(41, 12)
        Me.LB_RightUp.TabIndex = 2
        Me.LB_RightUp.Text = "右上："
        '
        'BTN_Run
        '
        Me.BTN_Run.Location = New System.Drawing.Point(102, 234)
        Me.BTN_Run.Name = "BTN_Run"
        Me.BTN_Run.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Run.TabIndex = 3
        Me.BTN_Run.Text = "获取位置"
        Me.BTN_Run.UseVisualStyleBackColor = True
        '
        'LB_LeftBottom
        '
        Me.LB_LeftBottom.AutoSize = True
        Me.LB_LeftBottom.Location = New System.Drawing.Point(12, 36)
        Me.LB_LeftBottom.Name = "LB_LeftBottom"
        Me.LB_LeftBottom.Size = New System.Drawing.Size(41, 12)
        Me.LB_LeftBottom.TabIndex = 4
        Me.LB_LeftBottom.Text = "左下："
        '
        'LB_RightBottom
        '
        Me.LB_RightBottom.AutoSize = True
        Me.LB_RightBottom.Location = New System.Drawing.Point(136, 36)
        Me.LB_RightBottom.Name = "LB_RightBottom"
        Me.LB_RightBottom.Size = New System.Drawing.Size(41, 12)
        Me.LB_RightBottom.TabIndex = 5
        Me.LB_RightBottom.Text = "右下："
        '
        'TB_LU
        '
        Me.TB_LU.Enabled = False
        Me.TB_LU.Location = New System.Drawing.Point(59, 6)
        Me.TB_LU.Name = "TB_LU"
        Me.TB_LU.Size = New System.Drawing.Size(70, 21)
        Me.TB_LU.TabIndex = 6
        '
        'TB_RU
        '
        Me.TB_RU.Enabled = False
        Me.TB_RU.Location = New System.Drawing.Point(183, 6)
        Me.TB_RU.Name = "TB_RU"
        Me.TB_RU.Size = New System.Drawing.Size(70, 21)
        Me.TB_RU.TabIndex = 7
        '
        'TB_LB
        '
        Me.TB_LB.Enabled = False
        Me.TB_LB.Location = New System.Drawing.Point(59, 33)
        Me.TB_LB.Name = "TB_LB"
        Me.TB_LB.Size = New System.Drawing.Size(70, 21)
        Me.TB_LB.TabIndex = 8
        '
        'TB_RB
        '
        Me.TB_RB.Enabled = False
        Me.TB_RB.Location = New System.Drawing.Point(183, 33)
        Me.TB_RB.Name = "TB_RB"
        Me.TB_RB.Size = New System.Drawing.Size(70, 21)
        Me.TB_RB.TabIndex = 9
        '
        'TB_MouseY
        '
        Me.TB_MouseY.Enabled = False
        Me.TB_MouseY.Location = New System.Drawing.Point(152, 60)
        Me.TB_MouseY.Name = "TB_MouseY"
        Me.TB_MouseY.Size = New System.Drawing.Size(70, 21)
        Me.TB_MouseY.TabIndex = 17
        '
        'TB_MouseX
        '
        Me.TB_MouseX.Enabled = False
        Me.TB_MouseX.Location = New System.Drawing.Point(70, 60)
        Me.TB_MouseX.Name = "TB_MouseX"
        Me.TB_MouseX.Size = New System.Drawing.Size(70, 21)
        Me.TB_MouseX.TabIndex = 16
        '
        'LB_Mouse
        '
        Me.LB_Mouse.AutoSize = True
        Me.LB_Mouse.Location = New System.Drawing.Point(11, 63)
        Me.LB_Mouse.Name = "LB_Mouse"
        Me.LB_Mouse.Size = New System.Drawing.Size(53, 12)
        Me.LB_Mouse.TabIndex = 15
        Me.LB_Mouse.Text = "鼠标位置"
        '
        'LB_InputName
        '
        Me.LB_InputName.AutoSize = True
        Me.LB_InputName.Location = New System.Drawing.Point(11, 90)
        Me.LB_InputName.Name = "LB_InputName"
        Me.LB_InputName.Size = New System.Drawing.Size(53, 12)
        Me.LB_InputName.TabIndex = 19
        Me.LB_InputName.Text = "进程名称"
        '
        'TB_ProcessName
        '
        Me.TB_ProcessName.Location = New System.Drawing.Point(70, 87)
        Me.TB_ProcessName.Name = "TB_ProcessName"
        Me.TB_ProcessName.Size = New System.Drawing.Size(133, 21)
        Me.TB_ProcessName.TabIndex = 20
        '
        'TB_RadioX
        '
        Me.TB_RadioX.Location = New System.Drawing.Point(71, 50)
        Me.TB_RadioX.Name = "TB_RadioX"
        Me.TB_RadioX.Size = New System.Drawing.Size(70, 21)
        Me.TB_RadioX.TabIndex = 13
        '
        'TB_RadioY
        '
        Me.TB_RadioY.Location = New System.Drawing.Point(147, 50)
        Me.TB_RadioY.Name = "TB_RadioY"
        Me.TB_RadioY.Size = New System.Drawing.Size(70, 21)
        Me.TB_RadioY.TabIndex = 14
        '
        'LB_Radio
        '
        Me.LB_Radio.AutoSize = True
        Me.LB_Radio.Location = New System.Drawing.Point(24, 53)
        Me.LB_Radio.Name = "LB_Radio"
        Me.LB_Radio.Size = New System.Drawing.Size(41, 12)
        Me.LB_Radio.TabIndex = 12
        Me.LB_Radio.Text = "位置比"
        '
        'LB_WinSizeWidth
        '
        Me.LB_WinSizeWidth.AutoSize = True
        Me.LB_WinSizeWidth.Location = New System.Drawing.Point(24, 23)
        Me.LB_WinSizeWidth.Name = "LB_WinSizeWidth"
        Me.LB_WinSizeWidth.Size = New System.Drawing.Size(41, 12)
        Me.LB_WinSizeWidth.TabIndex = 10
        Me.LB_WinSizeWidth.Text = "窗口宽"
        '
        'TB_WinSizeWidth
        '
        Me.TB_WinSizeWidth.Enabled = False
        Me.TB_WinSizeWidth.Location = New System.Drawing.Point(71, 20)
        Me.TB_WinSizeWidth.Name = "TB_WinSizeWidth"
        Me.TB_WinSizeWidth.Size = New System.Drawing.Size(54, 21)
        Me.TB_WinSizeWidth.TabIndex = 11
        '
        'LB_WinSizeHeight
        '
        Me.LB_WinSizeHeight.AutoSize = True
        Me.LB_WinSizeHeight.Location = New System.Drawing.Point(131, 23)
        Me.LB_WinSizeHeight.Name = "LB_WinSizeHeight"
        Me.LB_WinSizeHeight.Size = New System.Drawing.Size(41, 12)
        Me.LB_WinSizeHeight.TabIndex = 21
        Me.LB_WinSizeHeight.Text = "窗口高"
        '
        'TB_WinSizeHeight
        '
        Me.TB_WinSizeHeight.Enabled = False
        Me.TB_WinSizeHeight.Location = New System.Drawing.Point(178, 20)
        Me.TB_WinSizeHeight.Name = "TB_WinSizeHeight"
        Me.TB_WinSizeHeight.Size = New System.Drawing.Size(54, 21)
        Me.TB_WinSizeHeight.TabIndex = 22
        '
        'LB_Warning
        '
        Me.LB_Warning.AutoSize = True
        Me.LB_Warning.ForeColor = System.Drawing.Color.Red
        Me.LB_Warning.Location = New System.Drawing.Point(43, 80)
        Me.LB_Warning.Name = "LB_Warning"
        Me.LB_Warning.Size = New System.Drawing.Size(0, 12)
        Me.LB_Warning.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LB_Warning)
        Me.Panel1.Controls.Add(Me.TB_WinSizeHeight)
        Me.Panel1.Controls.Add(Me.LB_WinSizeHeight)
        Me.Panel1.Controls.Add(Me.TB_WinSizeWidth)
        Me.Panel1.Controls.Add(Me.LB_WinSizeWidth)
        Me.Panel1.Controls.Add(Me.LB_Radio)
        Me.Panel1.Controls.Add(Me.TB_RadioY)
        Me.Panel1.Controls.Add(Me.TB_RadioX)
        Me.Panel1.Location = New System.Drawing.Point(14, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 99)
        Me.Panel1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(7, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 114)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'GetWindowLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TB_ProcessName)
        Me.Controls.Add(Me.LB_InputName)
        Me.Controls.Add(Me.TB_MouseY)
        Me.Controls.Add(Me.TB_MouseX)
        Me.Controls.Add(Me.LB_Mouse)
        Me.Controls.Add(Me.TB_RB)
        Me.Controls.Add(Me.TB_LB)
        Me.Controls.Add(Me.TB_RU)
        Me.Controls.Add(Me.TB_LU)
        Me.Controls.Add(Me.LB_RightBottom)
        Me.Controls.Add(Me.LB_LeftBottom)
        Me.Controls.Add(Me.BTN_Run)
        Me.Controls.Add(Me.LB_RightUp)
        Me.Controls.Add(Me.LB_LeftUp)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "GetWindowLocation"
        Me.Text = "获取窗口位置小工具"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB_LeftUp As System.Windows.Forms.Label
    Friend WithEvents LB_RightUp As System.Windows.Forms.Label
    Friend WithEvents BTN_Run As System.Windows.Forms.Button
    Friend WithEvents LB_LeftBottom As System.Windows.Forms.Label
    Friend WithEvents LB_RightBottom As System.Windows.Forms.Label
    Friend WithEvents TB_LU As System.Windows.Forms.TextBox
    Friend WithEvents TB_RU As System.Windows.Forms.TextBox
    Friend WithEvents TB_LB As System.Windows.Forms.TextBox
    Friend WithEvents TB_RB As System.Windows.Forms.TextBox
    Friend WithEvents TB_MouseY As System.Windows.Forms.TextBox
    Friend WithEvents TB_MouseX As System.Windows.Forms.TextBox
    Friend WithEvents LB_Mouse As System.Windows.Forms.Label
    Friend WithEvents LB_InputName As System.Windows.Forms.Label
    Friend WithEvents TB_ProcessName As System.Windows.Forms.TextBox
    Friend WithEvents TB_RadioX As System.Windows.Forms.TextBox
    Friend WithEvents TB_RadioY As System.Windows.Forms.TextBox
    Friend WithEvents LB_Radio As System.Windows.Forms.Label
    Friend WithEvents LB_WinSizeWidth As System.Windows.Forms.Label
    Friend WithEvents TB_WinSizeWidth As System.Windows.Forms.TextBox
    Friend WithEvents LB_WinSizeHeight As System.Windows.Forms.Label
    Friend WithEvents TB_WinSizeHeight As System.Windows.Forms.TextBox
    Friend WithEvents LB_Warning As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
