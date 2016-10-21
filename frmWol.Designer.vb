<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWol
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.lstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstMac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtMac = New System.Windows.Forms.TextBox()
        Me.txtSubnet = New System.Windows.Forms.TextBox()
        Me.CboHosts = New System.Windows.Forms.ComboBox()
        Me.btnWake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstName, Me.lstIP, Me.lstMac, Me.lstStatus})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(1, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(375, 552)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'lstName
        '
        Me.lstName.Text = "Name"
        Me.lstName.Width = 68
        '
        'lstIP
        '
        Me.lstIP.Text = "IP Address"
        Me.lstIP.Width = 104
        '
        'lstMac
        '
        Me.lstMac.Text = "MAC Address"
        Me.lstMac.Width = 128
        '
        'lstStatus
        '
        Me.lstStatus.Text = "Status"
        Me.lstStatus.Width = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(553, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MAGIC PACKET"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(441, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hostname"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(441, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "IP Address"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(441, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MAC Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Subnet"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(574, 158)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(232, 26)
        Me.txtIP.TabIndex = 9
        '
        'txtMac
        '
        Me.txtMac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMac.Location = New System.Drawing.Point(574, 220)
        Me.txtMac.Name = "txtMac"
        Me.txtMac.Size = New System.Drawing.Size(232, 26)
        Me.txtMac.TabIndex = 10
        '
        'txtSubnet
        '
        Me.txtSubnet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubnet.Location = New System.Drawing.Point(574, 276)
        Me.txtSubnet.Name = "txtSubnet"
        Me.txtSubnet.Size = New System.Drawing.Size(232, 26)
        Me.txtSubnet.TabIndex = 11
        Me.txtSubnet.Text = "Optional"
        '
        'CboHosts
        '
        Me.CboHosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboHosts.FormattingEnabled = True
        Me.CboHosts.Location = New System.Drawing.Point(574, 98)
        Me.CboHosts.Name = "CboHosts"
        Me.CboHosts.Size = New System.Drawing.Size(232, 28)
        Me.CboHosts.TabIndex = 12
        '
        'btnWake
        '
        Me.btnWake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWake.Location = New System.Drawing.Point(591, 361)
        Me.btnWake.Name = "btnWake"
        Me.btnWake.Size = New System.Drawing.Size(112, 32)
        Me.btnWake.TabIndex = 13
        Me.btnWake.Text = "Wake Up"
        Me.btnWake.UseVisualStyleBackColor = True
        '
        'frmWol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 553)
        Me.Controls.Add(Me.btnWake)
        Me.Controls.Add(Me.CboHosts)
        Me.Controls.Add(Me.txtSubnet)
        Me.Controls.Add(Me.txtMac)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmWol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents lstName As ColumnHeader
    Friend WithEvents lstIP As ColumnHeader
    Friend WithEvents lstMac As ColumnHeader
    Friend WithEvents lstStatus As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtMac As TextBox
    Friend WithEvents txtSubnet As TextBox
    Friend WithEvents CboHosts As ComboBox
    Friend WithEvents btnWake As Button
End Class
