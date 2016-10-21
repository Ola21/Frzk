<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Me.lblMyIp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.btnSendSMS = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.RichTextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMyIp
        '
        Me.lblMyIp.AutoSize = True
        Me.lblMyIp.Location = New System.Drawing.Point(241, 37)
        Me.lblMyIp.Name = "lblMyIp"
        Me.lblMyIp.Size = New System.Drawing.Size(0, 13)
        Me.lblMyIp.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Welcome"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(205, 53)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(82, 20)
        Me.txtPort.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Configure Port "
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(92, 76)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(251, 20)
        Me.txtIp.TabIndex = 28
        '
        'btnSendSMS
        '
        Me.btnSendSMS.Location = New System.Drawing.Point(160, 273)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(104, 23)
        Me.btnSendSMS.TabIndex = 29
        Me.btnSendSMS.Text = "Send SMS"
        Me.btnSendSMS.UseVisualStyleBackColor = True
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(92, 208)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(319, 48)
        Me.txtMsg.TabIndex = 30
        Me.txtMsg.Text = ""
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(92, 167)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(319, 20)
        Me.txtTo.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "TO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "From"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(92, 128)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(319, 20)
        Me.txtFrom.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Message"
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 308)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.btnSendSMS)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMyIp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "client"
        Me.Text = "client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMyIp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents txtIp As TextBox
    Friend WithEvents btnSendSMS As Button
    Friend WithEvents txtMsg As RichTextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents Label5 As Label
End Class
