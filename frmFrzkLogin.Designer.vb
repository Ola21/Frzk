<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrzkLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lnkReg = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblforgtPwd = New System.Windows.Forms.Label()
        Me.linkforgetpwd = New System.Windows.Forms.LinkLabel()
        Me.ttClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblOTP = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.lblMinimize)
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-8, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 49)
        Me.Panel1.TabIndex = 1
        '
        'lblMinimize
        '
        Me.lblMinimize.AutoSize = True
        Me.lblMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimize.ForeColor = System.Drawing.Color.White
        Me.lblMinimize.Location = New System.Drawing.Point(571, 10)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(16, 24)
        Me.lblMinimize.TabIndex = 3
        Me.lblMinimize.Text = "-"
        Me.ttClose.SetToolTip(Me.lblMinimize, "Minimize")
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(603, 18)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(14, 13)
        Me.lblClose.TabIndex = 2
        Me.lblClose.Text = "X"
        Me.ttClose.SetToolTip(Me.lblClose, "Close")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(229, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EPM USER LOGIN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(-8, 459)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 49)
        Me.Panel2.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(524, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "@ Frzk 2016"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSubmit)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 267)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Credentials"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(289, 195)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 32)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(260, 128)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(184, 29)
        Me.txtPassword.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(129, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 24)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(260, 44)
        Me.txtUsername.MaxLength = 10
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(184, 29)
        Me.txtUsername.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(124, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 24)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Username"
        '
        'lnkReg
        '
        Me.lnkReg.AutoSize = True
        Me.lnkReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkReg.Location = New System.Drawing.Point(342, 397)
        Me.lnkReg.Name = "lnkReg"
        Me.lnkReg.Size = New System.Drawing.Size(79, 24)
        Me.lnkReg.TabIndex = 20
        Me.lnkReg.TabStop = True
        Me.lnkReg.Text = "*register"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "or"
        '
        'lblforgtPwd
        '
        Me.lblforgtPwd.AutoSize = True
        Me.lblforgtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforgtPwd.Location = New System.Drawing.Point(16, 397)
        Me.lblforgtPwd.Name = "lblforgtPwd"
        Me.lblforgtPwd.Size = New System.Drawing.Size(167, 24)
        Me.lblforgtPwd.TabIndex = 18
        Me.lblforgtPwd.Text = "forgot passsword ?"
        '
        'linkforgetpwd
        '
        Me.linkforgetpwd.AutoSize = True
        Me.linkforgetpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkforgetpwd.Location = New System.Drawing.Point(192, 397)
        Me.linkforgetpwd.Name = "linkforgetpwd"
        Me.linkforgetpwd.Size = New System.Drawing.Size(91, 24)
        Me.linkforgetpwd.TabIndex = 17
        Me.linkforgetpwd.TabStop = True
        Me.linkforgetpwd.Text = "click here"
        '
        'lblOTP
        '
        Me.lblOTP.AutoSize = True
        Me.lblOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOTP.Location = New System.Drawing.Point(492, 397)
        Me.lblOTP.Name = "lblOTP"
        Me.lblOTP.Size = New System.Drawing.Size(118, 24)
        Me.lblOTP.TabIndex = 21
        Me.lblOTP.TabStop = True
        Me.lblOTP.Text = "*OTP LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(445, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "or"
        '
        'frmFrzkLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 507)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOTP)
        Me.Controls.Add(Me.lnkReg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblforgtPwd)
        Me.Controls.Add(Me.linkforgetpwd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFrzkLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFrzkLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblClose As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lnkReg As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblforgtPwd As Label
    Friend WithEvents linkforgetpwd As LinkLabel
    Friend WithEvents ttClose As ToolTip
    Friend WithEvents lblMinimize As Label
    Friend WithEvents lblOTP As LinkLabel
    Friend WithEvents Label2 As Label
End Class
