<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCode
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
        Me.soln1 = New System.Windows.Forms.Button()
        Me.otp = New System.Windows.Forms.ListBox()
        Me.soln2 = New System.Windows.Forms.Button()
        Me.soln3 = New System.Windows.Forms.Button()
        Me.soln4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIpOne = New System.Windows.Forms.TextBox()
        Me.txtIpTwo = New System.Windows.Forms.TextBox()
        Me.txtIpThree = New System.Windows.Forms.TextBox()
        Me.txtIpFour = New System.Windows.Forms.TextBox()
        Me.cboAddresses = New System.Windows.Forms.ComboBox()
        Me.otp3 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'soln1
        '
        Me.soln1.Location = New System.Drawing.Point(12, 338)
        Me.soln1.Name = "soln1"
        Me.soln1.Size = New System.Drawing.Size(84, 51)
        Me.soln1.TabIndex = 0
        Me.soln1.Text = "solution 1"
        Me.soln1.UseVisualStyleBackColor = True
        '
        'otp
        '
        Me.otp.FormattingEnabled = True
        Me.otp.Location = New System.Drawing.Point(12, 12)
        Me.otp.Name = "otp"
        Me.otp.Size = New System.Drawing.Size(241, 173)
        Me.otp.TabIndex = 1
        '
        'soln2
        '
        Me.soln2.Location = New System.Drawing.Point(156, 338)
        Me.soln2.Name = "soln2"
        Me.soln2.Size = New System.Drawing.Size(84, 51)
        Me.soln2.TabIndex = 2
        Me.soln2.Text = "solution 2"
        Me.soln2.UseVisualStyleBackColor = True
        '
        'soln3
        '
        Me.soln3.Location = New System.Drawing.Point(280, 338)
        Me.soln3.Name = "soln3"
        Me.soln3.Size = New System.Drawing.Size(84, 51)
        Me.soln3.TabIndex = 3
        Me.soln3.Text = "solution 3"
        Me.soln3.UseVisualStyleBackColor = True
        '
        'soln4
        '
        Me.soln4.Location = New System.Drawing.Point(426, 338)
        Me.soln4.Name = "soln4"
        Me.soln4.Size = New System.Drawing.Size(84, 51)
        Me.soln4.TabIndex = 4
        Me.soln4.Text = "solution 4"
        Me.soln4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IP RANGE"
        '
        'txtIpOne
        '
        Me.txtIpOne.Location = New System.Drawing.Point(99, 282)
        Me.txtIpOne.Name = "txtIpOne"
        Me.txtIpOne.Size = New System.Drawing.Size(47, 20)
        Me.txtIpOne.TabIndex = 6
        '
        'txtIpTwo
        '
        Me.txtIpTwo.Location = New System.Drawing.Point(167, 282)
        Me.txtIpTwo.Name = "txtIpTwo"
        Me.txtIpTwo.Size = New System.Drawing.Size(47, 20)
        Me.txtIpTwo.TabIndex = 7
        '
        'txtIpThree
        '
        Me.txtIpThree.Location = New System.Drawing.Point(235, 282)
        Me.txtIpThree.Name = "txtIpThree"
        Me.txtIpThree.Size = New System.Drawing.Size(47, 20)
        Me.txtIpThree.TabIndex = 8
        '
        'txtIpFour
        '
        Me.txtIpFour.Location = New System.Drawing.Point(304, 282)
        Me.txtIpFour.Name = "txtIpFour"
        Me.txtIpFour.Size = New System.Drawing.Size(47, 20)
        Me.txtIpFour.TabIndex = 9
        '
        'cboAddresses
        '
        Me.cboAddresses.FormattingEnabled = True
        Me.cboAddresses.Location = New System.Drawing.Point(374, 281)
        Me.cboAddresses.Name = "cboAddresses"
        Me.cboAddresses.Size = New System.Drawing.Size(198, 21)
        Me.cboAddresses.TabIndex = 10
        '
        'otp3
        '
        Me.otp3.FormattingEnabled = True
        Me.otp3.Location = New System.Drawing.Point(331, 12)
        Me.otp3.Name = "otp3"
        Me.otp3.Size = New System.Drawing.Size(241, 173)
        Me.otp3.TabIndex = 11
        '
        'frmCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 401)
        Me.Controls.Add(Me.otp3)
        Me.Controls.Add(Me.cboAddresses)
        Me.Controls.Add(Me.txtIpFour)
        Me.Controls.Add(Me.txtIpThree)
        Me.Controls.Add(Me.txtIpTwo)
        Me.Controls.Add(Me.txtIpOne)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.soln4)
        Me.Controls.Add(Me.soln3)
        Me.Controls.Add(Me.soln2)
        Me.Controls.Add(Me.otp)
        Me.Controls.Add(Me.soln1)
        Me.Name = "frmCode"
        Me.Text = "frmCode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents soln1 As Button
    Friend WithEvents otp As ListBox
    Friend WithEvents soln2 As Button
    Friend WithEvents soln3 As Button
    Friend WithEvents soln4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIpOne As TextBox
    Friend WithEvents txtIpTwo As TextBox
    Friend WithEvents txtIpThree As TextBox
    Friend WithEvents txtIpFour As TextBox
    Friend WithEvents cboAddresses As ComboBox
    Friend WithEvents otp3 As ListBox
End Class
