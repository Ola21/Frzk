<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class local
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
        Me.pnlLocal = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.lblCustom = New System.Windows.Forms.Label()
        Me.lblStd = New System.Windows.Forms.Label()
        Me.lblNow = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.pnlLocal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLocal
        '
        Me.pnlLocal.BackgroundImage = Global.shellControl.My.Resources.Resources.winLo
        Me.pnlLocal.Controls.Add(Me.Label1)
        Me.pnlLocal.Controls.Add(Me.lblOptions)
        Me.pnlLocal.Controls.Add(Me.lblMain)
        Me.pnlLocal.Controls.Add(Me.lblBack)
        Me.pnlLocal.Controls.Add(Me.lblCustom)
        Me.pnlLocal.Controls.Add(Me.lblStd)
        Me.pnlLocal.Controls.Add(Me.lblNow)
        Me.pnlLocal.Controls.Add(Me.lblTime)
        Me.pnlLocal.Controls.Add(Me.lblDate)
        Me.pnlLocal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLocal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlLocal.Location = New System.Drawing.Point(0, 0)
        Me.pnlLocal.Name = "pnlLocal"
        Me.pnlLocal.Size = New System.Drawing.Size(959, 508)
        Me.pnlLocal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(349, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 62)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Local PC operations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.BackColor = System.Drawing.Color.Transparent
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.ForeColor = System.Drawing.Color.White
        Me.lblOptions.Location = New System.Drawing.Point(418, 139)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(109, 31)
        Me.lblOptions.TabIndex = 8
        Me.lblOptions.Text = "options"
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(491, 304)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(55, 24)
        Me.lblMain.TabIndex = 7
        Me.lblMain.Text = "main"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(383, 304)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(54, 24)
        Me.lblBack.TabIndex = 6
        Me.lblBack.Text = "back"
        '
        'lblCustom
        '
        Me.lblCustom.AutoSize = True
        Me.lblCustom.BackColor = System.Drawing.Color.Transparent
        Me.lblCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustom.Location = New System.Drawing.Point(383, 224)
        Me.lblCustom.Name = "lblCustom"
        Me.lblCustom.Size = New System.Drawing.Size(77, 24)
        Me.lblCustom.TabIndex = 5
        Me.lblCustom.Text = "custom"
        '
        'lblStd
        '
        Me.lblStd.AutoSize = True
        Me.lblStd.BackColor = System.Drawing.Color.Transparent
        Me.lblStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStd.Location = New System.Drawing.Point(481, 224)
        Me.lblStd.Name = "lblStd"
        Me.lblStd.Size = New System.Drawing.Size(90, 24)
        Me.lblStd.TabIndex = 4
        Me.lblStd.Text = "standard"
        '
        'lblNow
        '
        Me.lblNow.AutoSize = True
        Me.lblNow.BackColor = System.Drawing.Color.Transparent
        Me.lblNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNow.ForeColor = System.Drawing.Color.White
        Me.lblNow.Location = New System.Drawing.Point(570, 16)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(101, 31)
        Me.lblNow.TabIndex = 2
        Me.lblNow.Text = "Label1"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(313, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(101, 31)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Label1"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(256, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(101, 31)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Label1"
        '
        'local
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 508)
        Me.Controls.Add(Me.pnlLocal)
        Me.Name = "local"
        Me.Text = "local"
        Me.pnlLocal.ResumeLayout(False)
        Me.pnlLocal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLocal As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents lblBack As Label
    Friend WithEvents lblCustom As Label
    Friend WithEvents lblStd As Label
    Friend WithEvents lblNow As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
End Class
