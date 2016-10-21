<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class letTryOutSomething
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
        Me.txtIp1 = New System.Windows.Forms.TextBox()
        Me.txtIp2 = New System.Windows.Forms.TextBox()
        Me.txtIp3 = New System.Windows.Forms.TextBox()
        Me.txtIp4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBossIt = New System.Windows.Forms.Button()
        Me.txtIpList = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'txtIp1
        '
        Me.txtIp1.Location = New System.Drawing.Point(8, 299)
        Me.txtIp1.Name = "txtIp1"
        Me.txtIp1.Size = New System.Drawing.Size(43, 20)
        Me.txtIp1.TabIndex = 0
        '
        'txtIp2
        '
        Me.txtIp2.Location = New System.Drawing.Point(85, 299)
        Me.txtIp2.Name = "txtIp2"
        Me.txtIp2.Size = New System.Drawing.Size(43, 20)
        Me.txtIp2.TabIndex = 1
        '
        'txtIp3
        '
        Me.txtIp3.Location = New System.Drawing.Point(155, 299)
        Me.txtIp3.Name = "txtIp3"
        Me.txtIp3.Size = New System.Drawing.Size(43, 20)
        Me.txtIp3.TabIndex = 2
        '
        'txtIp4
        '
        Me.txtIp4.Location = New System.Drawing.Point(226, 299)
        Me.txtIp4.Name = "txtIp4"
        Me.txtIp4.Size = New System.Drawing.Size(43, 20)
        Me.txtIp4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Freazk Boss"
        '
        'btnBossIt
        '
        Me.btnBossIt.Location = New System.Drawing.Point(301, 297)
        Me.btnBossIt.Name = "btnBossIt"
        Me.btnBossIt.Size = New System.Drawing.Size(82, 23)
        Me.btnBossIt.TabIndex = 5
        Me.btnBossIt.Text = "Boss It"
        Me.btnBossIt.UseVisualStyleBackColor = True
        '
        'txtIpList
        '
        Me.txtIpList.Location = New System.Drawing.Point(150, 12)
        Me.txtIpList.Name = "txtIpList"
        Me.txtIpList.Size = New System.Drawing.Size(233, 256)
        Me.txtIpList.TabIndex = 6
        Me.txtIpList.UseCompatibleStateImageBehavior = False
        '
        'letTryOutSomething
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 331)
        Me.Controls.Add(Me.txtIpList)
        Me.Controls.Add(Me.btnBossIt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIp4)
        Me.Controls.Add(Me.txtIp3)
        Me.Controls.Add(Me.txtIp2)
        Me.Controls.Add(Me.txtIp1)
        Me.Name = "letTryOutSomething"
        Me.Text = "letTryOutSomething"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIp1 As TextBox
    Friend WithEvents txtIp2 As TextBox
    Friend WithEvents txtIp3 As TextBox
    Friend WithEvents txtIp4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBossIt As Button
    Friend WithEvents txtIpList As ListView
End Class
