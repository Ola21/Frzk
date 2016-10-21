<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettiings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabUpdate = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtUPPort = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUPGate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUPMac = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUPIP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUPUser = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUpHost = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboGate = New System.Windows.Forms.ComboBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabCon = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.chbAllowRemoteAcce = New System.Windows.Forms.CheckBox()
        Me.chbAllowAll = New System.Windows.Forms.CheckBox()
        Me.chbReqPwd = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSec = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabUpdate.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCon.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabSec.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabUpdate
        '
        Me.tabUpdate.Controls.Add(Me.PictureBox1)
        Me.tabUpdate.Controls.Add(Me.btnDelete)
        Me.tabUpdate.Controls.Add(Me.btnEdit)
        Me.tabUpdate.Controls.Add(Me.btnSave)
        Me.tabUpdate.Controls.Add(Me.txtUPPort)
        Me.tabUpdate.Controls.Add(Me.Label7)
        Me.tabUpdate.Controls.Add(Me.txtUPGate)
        Me.tabUpdate.Controls.Add(Me.Label8)
        Me.tabUpdate.Controls.Add(Me.txtUPMac)
        Me.tabUpdate.Controls.Add(Me.Label9)
        Me.tabUpdate.Controls.Add(Me.txtUPIP)
        Me.tabUpdate.Controls.Add(Me.Label10)
        Me.tabUpdate.Controls.Add(Me.txtUPUser)
        Me.tabUpdate.Controls.Add(Me.Label11)
        Me.tabUpdate.Controls.Add(Me.txtUpHost)
        Me.tabUpdate.Controls.Add(Me.Label12)
        Me.tabUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUpdate.Location = New System.Drawing.Point(4, 29)
        Me.tabUpdate.Name = "tabUpdate"
        Me.tabUpdate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUpdate.Size = New System.Drawing.Size(892, 520)
        Me.tabUpdate.TabIndex = 1
        Me.tabUpdate.Text = "UPDATE"
        Me.tabUpdate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.shellControl.My.Resources.Resources.app_img
        Me.PictureBox1.Location = New System.Drawing.Point(578, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(578, 372)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(202, 32)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(578, 307)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(202, 32)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(578, 251)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(202, 32)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtUPPort
        '
        Me.txtUPPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPPort.Location = New System.Drawing.Point(199, 375)
        Me.txtUPPort.Name = "txtUPPort"
        Me.txtUPPort.Size = New System.Drawing.Size(357, 26)
        Me.txtUPPort.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(96, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Gateway"
        '
        'txtUPGate
        '
        Me.txtUPGate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPGate.Location = New System.Drawing.Point(199, 313)
        Me.txtUPGate.Name = "txtUPGate"
        Me.txtUPGate.Size = New System.Drawing.Size(357, 26)
        Me.txtUPGate.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Username"
        '
        'txtUPMac
        '
        Me.txtUPMac.Enabled = False
        Me.txtUPMac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPMac.Location = New System.Drawing.Point(199, 251)
        Me.txtUPMac.Name = "txtUPMac"
        Me.txtUPMac.Size = New System.Drawing.Size(357, 26)
        Me.txtUPMac.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(103, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "PORT"
        '
        'txtUPIP
        '
        Me.txtUPIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPIP.Location = New System.Drawing.Point(199, 189)
        Me.txtUPIP.Name = "txtUPIP"
        Me.txtUPIP.Size = New System.Drawing.Size(357, 26)
        Me.txtUPIP.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(98, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "MAC"
        '
        'txtUPUser
        '
        Me.txtUPUser.Enabled = False
        Me.txtUPUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPUser.Location = New System.Drawing.Point(199, 127)
        Me.txtUPUser.Name = "txtUPUser"
        Me.txtUPUser.Size = New System.Drawing.Size(357, 26)
        Me.txtUPUser.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(98, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "IP Address"
        '
        'txtUpHost
        '
        Me.txtUpHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpHost.Location = New System.Drawing.Point(199, 65)
        Me.txtUpHost.Name = "txtUpHost"
        Me.txtUpHost.Size = New System.Drawing.Size(357, 26)
        Me.txtUpHost.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(96, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Host Name"
        '
        'cboGate
        '
        Me.cboGate.Enabled = False
        Me.cboGate.FormattingEnabled = True
        Me.cboGate.Location = New System.Drawing.Point(314, 320)
        Me.cboGate.Name = "cboGate"
        Me.cboGate.Size = New System.Drawing.Size(357, 28)
        Me.cboGate.TabIndex = 12
        '
        'txtPort
        '
        Me.txtPort.Enabled = False
        Me.txtPort.Location = New System.Drawing.Point(314, 380)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(357, 26)
        Me.txtPort.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gateway"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Username"
        '
        'txtMac
        '
        Me.txtMac.Enabled = False
        Me.txtMac.Location = New System.Drawing.Point(314, 260)
        Me.txtMac.Name = "txtMac"
        Me.txtMac.Size = New System.Drawing.Size(357, 26)
        Me.txtMac.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PORT"
        '
        'txtIP
        '
        Me.txtIP.Enabled = False
        Me.txtIP.Location = New System.Drawing.Point(314, 196)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(357, 26)
        Me.txtIP.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MAC"
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(314, 130)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(357, 26)
        Me.txtUser.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IP Address"
        '
        'txtHost
        '
        Me.txtHost.Enabled = False
        Me.txtHost.Location = New System.Drawing.Point(314, 67)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(357, 26)
        Me.txtHost.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host Name"
        '
        'tabCon
        '
        Me.tabCon.BackColor = System.Drawing.Color.Transparent
        Me.tabCon.Controls.Add(Me.cboGate)
        Me.tabCon.Controls.Add(Me.txtPort)
        Me.tabCon.Controls.Add(Me.Label5)
        Me.tabCon.Controls.Add(Me.Label6)
        Me.tabCon.Controls.Add(Me.txtMac)
        Me.tabCon.Controls.Add(Me.Label3)
        Me.tabCon.Controls.Add(Me.txtIP)
        Me.tabCon.Controls.Add(Me.Label4)
        Me.tabCon.Controls.Add(Me.txtUser)
        Me.tabCon.Controls.Add(Me.Label2)
        Me.tabCon.Controls.Add(Me.txtHost)
        Me.tabCon.Controls.Add(Me.Label1)
        Me.tabCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCon.Location = New System.Drawing.Point(4, 29)
        Me.tabCon.Name = "tabCon"
        Me.tabCon.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCon.Size = New System.Drawing.Size(892, 520)
        Me.tabCon.TabIndex = 0
        Me.tabCon.Text = "OVERVIEW"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(232, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 20)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Welcome Username"
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Location = New System.Drawing.Point(443, 101)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(69, 20)
        Me.lblReg.TabIndex = 2
        Me.lblReg.Text = "Register"
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Location = New System.Drawing.Point(232, 101)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(125, 20)
        Me.lblReset.TabIndex = 1
        Me.lblReset.Text = "Password Reset"
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Location = New System.Drawing.Point(88, 101)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(66, 20)
        Me.lblLogout.TabIndex = 0
        Me.lblLogout.Text = "Log Out"
        '
        'chbAllowRemoteAcce
        '
        Me.chbAllowRemoteAcce.AutoSize = True
        Me.chbAllowRemoteAcce.Location = New System.Drawing.Point(468, 120)
        Me.chbAllowRemoteAcce.Name = "chbAllowRemoteAcce"
        Me.chbAllowRemoteAcce.Size = New System.Drawing.Size(182, 24)
        Me.chbAllowRemoteAcce.TabIndex = 5
        Me.chbAllowRemoteAcce.Text = "Allow Remote Access"
        Me.chbAllowRemoteAcce.UseVisualStyleBackColor = True
        '
        'chbAllowAll
        '
        Me.chbAllowAll.AutoSize = True
        Me.chbAllowAll.Location = New System.Drawing.Point(48, 120)
        Me.chbAllowAll.Name = "chbAllowAll"
        Me.chbAllowAll.Size = New System.Drawing.Size(132, 24)
        Me.chbAllowAll.TabIndex = 4
        Me.chbAllowAll.Text = "Allow All Users"
        Me.chbAllowAll.UseVisualStyleBackColor = True
        '
        'chbReqPwd
        '
        Me.chbReqPwd.AutoSize = True
        Me.chbReqPwd.Location = New System.Drawing.Point(255, 120)
        Me.chbReqPwd.Name = "chbReqPwd"
        Me.chbReqPwd.Size = New System.Drawing.Size(157, 24)
        Me.chbReqPwd.TabIndex = 2
        Me.chbReqPwd.Text = "Require Password"
        Me.chbReqPwd.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(232, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 20)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Authentication"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCon)
        Me.TabControl1.Controls.Add(Me.tabUpdate)
        Me.TabControl1.Controls.Add(Me.tabSec)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(900, 553)
        Me.TabControl1.TabIndex = 2
        '
        'tabSec
        '
        Me.tabSec.Controls.Add(Me.GroupBox2)
        Me.tabSec.Controls.Add(Me.GroupBox1)
        Me.tabSec.Location = New System.Drawing.Point(4, 29)
        Me.tabSec.Name = "tabSec"
        Me.tabSec.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSec.Size = New System.Drawing.Size(892, 520)
        Me.tabSec.TabIndex = 2
        Me.tabSec.Text = "SECURITY"
        Me.tabSec.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chbAllowRemoteAcce)
        Me.GroupBox2.Controls.Add(Me.chbAllowAll)
        Me.GroupBox2.Controls.Add(Me.chbReqPwd)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(114, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(652, 171)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "App Control"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblReg)
        Me.GroupBox1.Controls.Add(Me.lblReset)
        Me.GroupBox1.Controls.Add(Me.lblLogout)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin Center"
        '
        'frmSettiings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(900, 553)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettiings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmSettiings"
        Me.tabUpdate.ResumeLayout(False)
        Me.tabUpdate.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCon.ResumeLayout(False)
        Me.tabCon.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabSec.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabUpdate As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtUPPort As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUPGate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUPMac As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUPIP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUPUser As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUpHost As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboGate As ComboBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMac As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabCon As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents lblReg As Label
    Friend WithEvents lblReset As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents chbAllowRemoteAcce As CheckBox
    Friend WithEvents chbAllowAll As CheckBox
    Friend WithEvents chbReqPwd As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabSec As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
