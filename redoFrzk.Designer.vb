<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class redoFrzk
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
        Me.mnuFrzk = New System.Windows.Forms.MenuStrip()
        Me.OptLocal = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptRemote = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mnuFrzk.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFrzk
        '
        Me.mnuFrzk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mnuFrzk.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuFrzk.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptLocal, Me.OptRemote, Me.OptRecords, Me.SettingsToolStripMenuItem, Me.OptHelp})
        Me.mnuFrzk.Location = New System.Drawing.Point(0, 0)
        Me.mnuFrzk.Name = "mnuFrzk"
        Me.mnuFrzk.Size = New System.Drawing.Size(895, 44)
        Me.mnuFrzk.TabIndex = 5
        Me.mnuFrzk.Text = "MenuStrip1"
        '
        'OptLocal
        '
        Me.OptLocal.BackColor = System.Drawing.Color.Transparent
        Me.OptLocal.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptLocal.ForeColor = System.Drawing.Color.White
        Me.OptLocal.Name = "OptLocal"
        Me.OptLocal.Size = New System.Drawing.Size(140, 40)
        Me.OptLocal.Text = "LOCAL"
        '
        'OptRemote
        '
        Me.OptRemote.ForeColor = System.Drawing.Color.White
        Me.OptRemote.Name = "OptRemote"
        Me.OptRemote.Size = New System.Drawing.Size(146, 40)
        Me.OptRemote.Text = "REMOTE"
        '
        'OptRecords
        '
        Me.OptRecords.ForeColor = System.Drawing.Color.White
        Me.OptRecords.Name = "OptRecords"
        Me.OptRecords.Size = New System.Drawing.Size(101, 40)
        Me.OptRecords.Text = "LOGS"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(161, 40)
        Me.SettingsToolStripMenuItem.Text = "SETTINGS"
        '
        'OptHelp
        '
        Me.OptHelp.ForeColor = System.Drawing.Color.White
        Me.OptHelp.Name = "OptHelp"
        Me.OptHelp.Size = New System.Drawing.Size(100, 40)
        Me.OptHelp.Text = "HELP"
        '
        'redoFrzk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 567)
        Me.Controls.Add(Me.mnuFrzk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "redoFrzk"
        Me.Text = "redoFrzk"
        Me.mnuFrzk.ResumeLayout(False)
        Me.mnuFrzk.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuFrzk As MenuStrip
    Friend WithEvents OptLocal As ToolStripMenuItem
    Friend WithEvents OptRemote As ToolStripMenuItem
    Friend WithEvents OptRecords As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptHelp As ToolStripMenuItem
    Friend WithEvents ClockTimer As Timer
End Class
