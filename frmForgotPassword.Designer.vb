<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword
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
        Me.ttClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblUIDorMail = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.timeToreturnToLogin = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'lblUIDorMail
        '
        Me.lblUIDorMail.AutoSize = True
        Me.lblUIDorMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUIDorMail.Location = New System.Drawing.Point(136, 407)
        Me.lblUIDorMail.Name = "lblUIDorMail"
        Me.lblUIDorMail.Size = New System.Drawing.Size(336, 24)
        Me.lblUIDorMail.TabIndex = 25
        Me.lblUIDorMail.Text = "Please check your mail for the App UID"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(246, 193)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 32)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtUID
        '
        Me.txtUID.Location = New System.Drawing.Point(202, 126)
        Me.txtUID.MaxLength = 20
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(214, 29)
        Me.txtUID.TabIndex = 8
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(-8, 459)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 49)
        Me.Panel2.TabIndex = 22
        '
        'lblVal
        '
        Me.lblVal.AutoSize = True
        Me.lblVal.Location = New System.Drawing.Point(67, 129)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(90, 24)
        Me.lblVal.TabIndex = 7
        Me.lblVal.Text = "Enter UID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(54, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(191, 24)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Do you have App UID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(204, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EPM PASSWORD RESET"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoNo)
        Me.GroupBox2.Controls.Add(Me.rdoYes)
        Me.GroupBox2.Controls.Add(Me.btnSubmit)
        Me.GroupBox2.Controls.Add(Me.txtUID)
        Me.GroupBox2.Controls.Add(Me.lblVal)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 267)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reset"
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Location = New System.Drawing.Point(388, 49)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(53, 28)
        Me.rdoNo.TabIndex = 21
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Location = New System.Drawing.Point(276, 49)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(60, 28)
        Me.rdoYes.TabIndex = 20
        Me.rdoYes.TabStop = True
        Me.rdoYes.Text = "Yes"
        Me.rdoYes.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 21
        '
        'timeToreturnToLogin
        '
        Me.timeToreturnToLogin.Interval = 1000
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 507)
        Me.Controls.Add(Me.lblUIDorMail)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmForgotPassword"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ttClose As ToolTip
    Friend WithEvents lblMinimize As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblUIDorMail As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtUID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblVal As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdoNo As RadioButton
    Friend WithEvents rdoYes As RadioButton
    Friend WithEvents timeToreturnToLogin As Timer
End Class
