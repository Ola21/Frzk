<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frzk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logs = New System.Windows.Forms.PictureBox()
        Me.settings = New System.Windows.Forms.PictureBox()
        Me.help = New System.Windows.Forms.PictureBox()
        Me.remote = New System.Windows.Forms.PictureBox()
        Me.Local = New System.Windows.Forms.PictureBox()
        Me.lblNow = New System.Windows.Forms.Label()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlLocalOpt = New System.Windows.Forms.Panel()
        Me.pnlLocalStandard = New System.Windows.Forms.Panel()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblHr = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtHr = New System.Windows.Forms.TextBox()
        Me.cboOptions = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.lblCustom = New System.Windows.Forms.Label()
        Me.lblStd = New System.Windows.Forms.Label()
        Me.lblLocalOpts = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ttOptLocal = New System.Windows.Forms.ToolTip(Me.components)
        Me.CountDown = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.logs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.remote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Local, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLocalOpt.SuspendLayout()
        Me.pnlLocalStandard.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.logs)
        Me.Panel1.Controls.Add(Me.settings)
        Me.Panel1.Controls.Add(Me.help)
        Me.Panel1.Controls.Add(Me.remote)
        Me.Panel1.Controls.Add(Me.Local)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 300)
        Me.Panel1.TabIndex = 1
        '
        'logs
        '
        Me.logs.Image = Global.shellControl.My.Resources.Resources._3_Logs
        Me.logs.Location = New System.Drawing.Point(0, 121)
        Me.logs.Name = "logs"
        Me.logs.Size = New System.Drawing.Size(200, 60)
        Me.logs.TabIndex = 4
        Me.logs.TabStop = False
        '
        'settings
        '
        Me.settings.Image = Global.shellControl.My.Resources.Resources._4_Settings
        Me.settings.Location = New System.Drawing.Point(0, 181)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(200, 60)
        Me.settings.TabIndex = 3
        Me.settings.TabStop = False
        '
        'help
        '
        Me.help.Image = Global.shellControl.My.Resources.Resources._5_Help
        Me.help.Location = New System.Drawing.Point(0, 240)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(200, 60)
        Me.help.TabIndex = 2
        Me.help.TabStop = False
        '
        'remote
        '
        Me.remote.Image = Global.shellControl.My.Resources.Resources._2_Remote
        Me.remote.Location = New System.Drawing.Point(0, 61)
        Me.remote.Name = "remote"
        Me.remote.Size = New System.Drawing.Size(200, 60)
        Me.remote.TabIndex = 1
        Me.remote.TabStop = False
        '
        'Local
        '
        Me.Local.Image = Global.shellControl.My.Resources.Resources._1_Local
        Me.Local.Location = New System.Drawing.Point(0, 1)
        Me.Local.Name = "Local"
        Me.Local.Size = New System.Drawing.Size(200, 60)
        Me.Local.TabIndex = 0
        Me.Local.TabStop = False
        '
        'lblNow
        '
        Me.lblNow.AutoSize = True
        Me.lblNow.BackColor = System.Drawing.Color.Transparent
        Me.lblNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNow.ForeColor = System.Drawing.Color.White
        Me.lblNow.Location = New System.Drawing.Point(295, 1)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(101, 31)
        Me.lblNow.TabIndex = 3
        Me.lblNow.Text = "Label1"
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        '
        'pnlLocalOpt
        '
        Me.pnlLocalOpt.BackgroundImage = Global.shellControl.My.Resources.Resources.Main_Body
        Me.pnlLocalOpt.Controls.Add(Me.pnlLocalStandard)
        Me.pnlLocalOpt.Controls.Add(Me.lblMain)
        Me.pnlLocalOpt.Controls.Add(Me.lblBack)
        Me.pnlLocalOpt.Controls.Add(Me.lblCustom)
        Me.pnlLocalOpt.Controls.Add(Me.lblStd)
        Me.pnlLocalOpt.Controls.Add(Me.lblLocalOpts)
        Me.pnlLocalOpt.Controls.Add(Me.Label1)
        Me.pnlLocalOpt.Location = New System.Drawing.Point(201, 1)
        Me.pnlLocalOpt.Name = "pnlLocalOpt"
        Me.pnlLocalOpt.Size = New System.Drawing.Size(400, 300)
        Me.pnlLocalOpt.TabIndex = 4
        '
        'pnlLocalStandard
        '
        Me.pnlLocalStandard.BackgroundImage = Global.shellControl.My.Resources.Resources.Main_Body
        Me.pnlLocalStandard.Controls.Add(Me.lblMin)
        Me.pnlLocalStandard.Controls.Add(Me.lblSec)
        Me.pnlLocalStandard.Controls.Add(Me.lblHr)
        Me.pnlLocalStandard.Controls.Add(Me.btnExit)
        Me.pnlLocalStandard.Controls.Add(Me.btnBack)
        Me.pnlLocalStandard.Controls.Add(Me.btnMore)
        Me.pnlLocalStandard.Controls.Add(Me.btnStop)
        Me.pnlLocalStandard.Controls.Add(Me.btnStart)
        Me.pnlLocalStandard.Controls.Add(Me.txtMin)
        Me.pnlLocalStandard.Controls.Add(Me.txtSec)
        Me.pnlLocalStandard.Controls.Add(Me.txtHr)
        Me.pnlLocalStandard.Controls.Add(Me.cboOptions)
        Me.pnlLocalStandard.Controls.Add(Me.Label2)
        Me.pnlLocalStandard.Location = New System.Drawing.Point(-1, 0)
        Me.pnlLocalStandard.Name = "pnlLocalStandard"
        Me.pnlLocalStandard.Size = New System.Drawing.Size(400, 300)
        Me.pnlLocalStandard.TabIndex = 16
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(109, 86)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(42, 31)
        Me.lblMin.TabIndex = 29
        Me.lblMin.Text = "M"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.Transparent
        Me.lblSec.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.Location = New System.Drawing.Point(146, 115)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(32, 31)
        Me.lblSec.TabIndex = 28
        Me.lblSec.Text = "S"
        '
        'lblHr
        '
        Me.lblHr.AutoSize = True
        Me.lblHr.BackColor = System.Drawing.Color.Transparent
        Me.lblHr.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHr.Location = New System.Drawing.Point(79, 62)
        Me.lblHr.Name = "lblHr"
        Me.lblHr.Size = New System.Drawing.Size(39, 31)
        Me.lblHr.TabIndex = 27
        Me.lblHr.Text = "H"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(316, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 48)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(316, 171)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 48)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.White
        Me.btnMore.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMore.ForeColor = System.Drawing.Color.Black
        Me.btnMore.Location = New System.Drawing.Point(316, 126)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(84, 48)
        Me.btnMore.TabIndex = 24
        Me.btnMore.Text = "More"
        Me.btnMore.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.White
        Me.btnStop.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(316, 79)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(84, 48)
        Me.btnStop.TabIndex = 23
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(316, 33)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(84, 48)
        Me.btnStart.TabIndex = 22
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'txtMin
        '
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMin.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(97, 178)
        Me.txtMin.MaxLength = 2
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(73, 55)
        Me.txtMin.TabIndex = 19
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSec
        '
        Me.txtSec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSec.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.Location = New System.Drawing.Point(222, 178)
        Me.txtSec.MaxLength = 2
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(73, 55)
        Me.txtSec.TabIndex = 18
        Me.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHr
        '
        Me.txtHr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHr.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHr.Location = New System.Drawing.Point(222, 67)
        Me.txtHr.MaxLength = 2
        Me.txtHr.Name = "txtHr"
        Me.txtHr.Size = New System.Drawing.Size(73, 55)
        Me.txtHr.TabIndex = 17
        Me.txtHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboOptions
        '
        Me.cboOptions.BackColor = System.Drawing.Color.Gray
        Me.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOptions.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOptions.ForeColor = System.Drawing.Color.White
        Me.cboOptions.Items.AddRange(New Object() {"shutdown", "restart", "log off", "lock", "hibernate"})
        Me.cboOptions.Location = New System.Drawing.Point(139, 14)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(143, 26)
        Me.cboOptions.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(139, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Standard  Settings"
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(218, 178)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(55, 24)
        Me.lblMain.TabIndex = 15
        Me.lblMain.Text = "main"
        Me.ttOptLocal.SetToolTip(Me.lblMain, "takes you to the main page of the app")
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(97, 178)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(54, 24)
        Me.lblBack.TabIndex = 14
        Me.lblBack.Text = "back"
        Me.ttOptLocal.SetToolTip(Me.lblBack, "takes you once step back")
        '
        'lblCustom
        '
        Me.lblCustom.AutoSize = True
        Me.lblCustom.BackColor = System.Drawing.Color.Transparent
        Me.lblCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustom.Location = New System.Drawing.Point(97, 98)
        Me.lblCustom.Name = "lblCustom"
        Me.lblCustom.Size = New System.Drawing.Size(77, 24)
        Me.lblCustom.TabIndex = 13
        Me.lblCustom.Text = "custom"
        Me.ttOptLocal.SetToolTip(Me.lblCustom, "Allows you to customize you settings")
        '
        'lblStd
        '
        Me.lblStd.AutoSize = True
        Me.lblStd.BackColor = System.Drawing.Color.Transparent
        Me.lblStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStd.Location = New System.Drawing.Point(218, 98)
        Me.lblStd.Name = "lblStd"
        Me.lblStd.Size = New System.Drawing.Size(90, 24)
        Me.lblStd.TabIndex = 12
        Me.lblStd.Text = "standard"
        Me.ttOptLocal.SetToolTip(Me.lblStd, "Recommended Standard Settings")
        '
        'lblLocalOpts
        '
        Me.lblLocalOpts.AutoSize = True
        Me.lblLocalOpts.BackColor = System.Drawing.Color.Transparent
        Me.lblLocalOpts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalOpts.ForeColor = System.Drawing.Color.White
        Me.lblLocalOpts.Location = New System.Drawing.Point(165, 32)
        Me.lblLocalOpts.Name = "lblLocalOpts"
        Me.lblLocalOpts.Size = New System.Drawing.Size(59, 16)
        Me.lblLocalOpts.TabIndex = 11
        Me.lblLocalOpts.Text = "options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(145, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Local PC operations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CountDown
        '
        Me.CountDown.Interval = 1000
        '
        'Frzk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.shellControl.My.Resources.Resources.Secondary_Screen
        Me.ClientSize = New System.Drawing.Size(602, 301)
        Me.Controls.Add(Me.pnlLocalOpt)
        Me.Controls.Add(Me.lblNow)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frzk"
        Me.Text = "Frzk"
        Me.Panel1.ResumeLayout(False)
        CType(Me.logs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.remote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Local, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLocalOpt.ResumeLayout(False)
        Me.pnlLocalOpt.PerformLayout()
        Me.pnlLocalStandard.ResumeLayout(False)
        Me.pnlLocalStandard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents logs As PictureBox
    Friend WithEvents settings As PictureBox
    Friend WithEvents help As PictureBox
    Friend WithEvents remote As PictureBox
    Friend WithEvents Local As PictureBox
    Friend WithEvents lblNow As Label
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents pnlLocalOpt As Panel
    Friend WithEvents lblMain As Label
    Friend WithEvents lblBack As Label
    Friend WithEvents lblCustom As Label
    Friend WithEvents lblStd As Label
    Friend WithEvents lblLocalOpts As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ttOptLocal As ToolTip
    Friend WithEvents pnlLocalStandard As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnMore As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtSec As TextBox
    Friend WithEvents txtHr As TextBox
    Friend WithEvents cboOptions As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CountDown As Timer
    Friend WithEvents lblMin As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents lblHr As Label
End Class
