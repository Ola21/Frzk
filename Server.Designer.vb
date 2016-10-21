<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server
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
        Me.cboOptions = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMyIp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboOptions
        '
        Me.cboOptions.BackColor = System.Drawing.Color.Gray
        Me.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOptions.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOptions.ForeColor = System.Drawing.Color.White
        Me.cboOptions.Items.AddRange(New Object() {"shutdown", "restart", "log off", "lock", "hibernate"})
        Me.cboOptions.Location = New System.Drawing.Point(52, 319)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(143, 26)
        Me.cboOptions.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Welcome"
        '
        'lblMyIp
        '
        Me.lblMyIp.AutoSize = True
        Me.lblMyIp.Location = New System.Drawing.Point(201, 38)
        Me.lblMyIp.Name = "lblMyIp"
        Me.lblMyIp.Size = New System.Drawing.Size(0, 13)
        Me.lblMyIp.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Client IP"
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(155, 129)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(184, 20)
        Me.txtClient.TabIndex = 21
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(276, 322)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 22
        Me.btnOk.Text = "Go"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Configure Port "
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(155, 209)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(82, 20)
        Me.txtPort.TabIndex = 24
        '
        'Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 375)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMyIp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboOptions)
        Me.Name = "Server"
        Me.Text = "Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOptions As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMyIp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClient As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPort As TextBox
End Class
