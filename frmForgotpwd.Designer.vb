<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotpwd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEmailorUid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPwdReset = New System.Windows.Forms.Button()
        Me.cboPassResetUID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uidTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtemailuid = New System.Windows.Forms.TextBox()
        Me.btnPwdResetExit = New System.Windows.Forms.Button()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(146, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password Reset Center"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblmsg)
        Me.Panel1.Controls.Add(Me.btnPwdResetExit)
        Me.Panel1.Controls.Add(Me.txtemailuid)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cboPassResetUID)
        Me.Panel1.Controls.Add(Me.lblEmailorUid)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnPwdReset)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 221)
        Me.Panel1.TabIndex = 3
        '
        'lblEmailorUid
        '
        Me.lblEmailorUid.AutoSize = True
        Me.lblEmailorUid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailorUid.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmailorUid.Location = New System.Drawing.Point(37, 77)
        Me.lblEmailorUid.Name = "lblEmailorUid"
        Me.lblEmailorUid.Size = New System.Drawing.Size(60, 24)
        Me.lblEmailorUid.TabIndex = 7
        Me.lblEmailorUid.Text = "Enter "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(37, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Do you have your unique ID ? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnPwdReset
        '
        Me.btnPwdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPwdReset.Location = New System.Drawing.Point(138, 170)
        Me.btnPwdReset.Name = "btnPwdReset"
        Me.btnPwdReset.Size = New System.Drawing.Size(75, 23)
        Me.btnPwdReset.TabIndex = 5
        Me.btnPwdReset.Text = "Enter"
        Me.btnPwdReset.UseVisualStyleBackColor = True
        '
        'cboPassResetUID
        '
        Me.cboPassResetUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPassResetUID.FormattingEnabled = True
        Me.cboPassResetUID.ItemHeight = 16
        Me.cboPassResetUID.Items.AddRange(New Object() {"yes", "no"})
        Me.cboPassResetUID.Location = New System.Drawing.Point(328, 18)
        Me.cboPassResetUID.Name = "cboPassResetUID"
        Me.cboPassResetUID.Size = New System.Drawing.Size(64, 24)
        Me.cboPassResetUID.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(408, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "unique ID?"
        Me.uidTT.SetToolTip(Me.Label5, "It identifies the user to the  app. your UID was sent to you by mail when you sig" &
        "n up")
        '
        'txtemailuid
        '
        Me.txtemailuid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemailuid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemailuid.Location = New System.Drawing.Point(200, 82)
        Me.txtemailuid.Name = "txtemailuid"
        Me.txtemailuid.Size = New System.Drawing.Size(168, 19)
        Me.txtemailuid.TabIndex = 10
        Me.txtemailuid.Text = "Email or Unique ID"
        Me.uidTT.SetToolTip(Me.txtemailuid, "Email must be same with your freazk user email")
        '
        'btnPwdResetExit
        '
        Me.btnPwdResetExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPwdResetExit.Location = New System.Drawing.Point(293, 170)
        Me.btnPwdResetExit.Name = "btnPwdResetExit"
        Me.btnPwdResetExit.Size = New System.Drawing.Size(75, 23)
        Me.btnPwdResetExit.TabIndex = 11
        Me.btnPwdResetExit.Text = "Exit"
        Me.btnPwdResetExit.UseVisualStyleBackColor = True
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblmsg.Location = New System.Drawing.Point(62, 121)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(74, 24)
        Me.lblmsg.TabIndex = 12
        Me.lblmsg.Text = "A  new "
        '
        'frmForgotpwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(548, 285)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmForgotpwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmForgotpwd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cboPassResetUID As ComboBox
    Friend WithEvents lblEmailorUid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPwdReset As Button
    Friend WithEvents uidTT As ToolTip
    Friend WithEvents txtemailuid As TextBox
    Friend WithEvents lblmsg As Label
    Friend WithEvents btnPwdResetExit As Button
End Class
