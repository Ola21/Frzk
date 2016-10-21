<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lnkReg = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblforgtPwd = New System.Windows.Forms.Label()
        Me.linkforgetpwd = New System.Windows.Forms.LinkLabel()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblclose = New System.Windows.Forms.Label()
        Me.ttClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(11, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 418)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.lnkReg)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblforgtPwd)
        Me.Panel2.Controls.Add(Me.linkforgetpwd)
        Me.Panel2.Controls.Add(Me.btnlogin)
        Me.Panel2.Controls.Add(Me.txtPass)
        Me.Panel2.Controls.Add(Me.txtuser)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(70, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 286)
        Me.Panel2.TabIndex = 1
        '
        'lnkReg
        '
        Me.lnkReg.AutoSize = True
        Me.lnkReg.Location = New System.Drawing.Point(315, 245)
        Me.lnkReg.Name = "lnkReg"
        Me.lnkReg.Size = New System.Drawing.Size(68, 20)
        Me.lnkReg.TabIndex = 16
        Me.lnkReg.TabStop = True
        Me.lnkReg.Text = "*register"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "or"
        '
        'lblforgtPwd
        '
        Me.lblforgtPwd.AutoSize = True
        Me.lblforgtPwd.Location = New System.Drawing.Point(38, 245)
        Me.lblforgtPwd.Name = "lblforgtPwd"
        Me.lblforgtPwd.Size = New System.Drawing.Size(144, 20)
        Me.lblforgtPwd.TabIndex = 14
        Me.lblforgtPwd.Text = "forgot passsword ?"
        '
        'linkforgetpwd
        '
        Me.linkforgetpwd.AutoSize = True
        Me.linkforgetpwd.Location = New System.Drawing.Point(182, 245)
        Me.linkforgetpwd.Name = "linkforgetpwd"
        Me.linkforgetpwd.Size = New System.Drawing.Size(75, 20)
        Me.linkforgetpwd.TabIndex = 13
        Me.linkforgetpwd.TabStop = True
        Me.linkforgetpwd.Text = "click here"
        '
        'btnlogin
        '
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(230, 181)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 32)
        Me.btnlogin.TabIndex = 9
        Me.btnlogin.Text = "login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(186, 129)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(197, 31)
        Me.txtPass.TabIndex = 12
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(186, 74)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(197, 31)
        Me.txtuser.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "user login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(162, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Freazk Solutions"
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblclose.ForeColor = System.Drawing.Color.DarkRed
        Me.lblclose.Location = New System.Drawing.Point(623, 0)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(14, 13)
        Me.lblclose.TabIndex = 2
        Me.lblclose.Text = "X"
        Me.ttClose.SetToolTip(Me.lblclose, "close")
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(635, 451)
        Me.Controls.Add(Me.lblclose)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblforgtPwd As Label
    Friend WithEvents linkforgetpwd As LinkLabel
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblclose As Label
    Friend WithEvents ttClose As ToolTip
    Friend WithEvents lnkReg As LinkLabel
    Friend WithEvents Label5 As Label
End Class
