<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLocal
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
        Me.ttClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChbLock = New System.Windows.Forms.CheckBox()
        Me.chbHibernate = New System.Windows.Forms.CheckBox()
        Me.chbShutdown = New System.Windows.Forms.CheckBox()
        Me.chbRestart = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtHr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoStandard = New System.Windows.Forms.RadioButton()
        Me.rdoCustom = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(136, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 507)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChbLock)
        Me.Panel2.Controls.Add(Me.chbHibernate)
        Me.Panel2.Controls.Add(Me.chbShutdown)
        Me.Panel2.Controls.Add(Me.chbRestart)
        Me.Panel2.Location = New System.Drawing.Point(58, 348)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(499, 64)
        Me.Panel2.TabIndex = 3
        '
        'ChbLock
        '
        Me.ChbLock.AutoSize = True
        Me.ChbLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbLock.Location = New System.Drawing.Point(153, 18)
        Me.ChbLock.Name = "ChbLock"
        Me.ChbLock.Size = New System.Drawing.Size(69, 28)
        Me.ChbLock.TabIndex = 31
        Me.ChbLock.Text = "Lock"
        Me.ChbLock.UseVisualStyleBackColor = True
        '
        'chbHibernate
        '
        Me.chbHibernate.AutoSize = True
        Me.chbHibernate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbHibernate.Location = New System.Drawing.Point(366, 18)
        Me.chbHibernate.Name = "chbHibernate"
        Me.chbHibernate.Size = New System.Drawing.Size(111, 28)
        Me.chbHibernate.TabIndex = 33
        Me.chbHibernate.Text = "Hibernate"
        Me.chbHibernate.UseVisualStyleBackColor = True
        '
        'chbShutdown
        '
        Me.chbShutdown.AutoSize = True
        Me.chbShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbShutdown.Location = New System.Drawing.Point(21, 18)
        Me.chbShutdown.Name = "chbShutdown"
        Me.chbShutdown.Size = New System.Drawing.Size(114, 28)
        Me.chbShutdown.TabIndex = 30
        Me.chbShutdown.Text = "Shutdown"
        Me.chbShutdown.UseVisualStyleBackColor = True
        '
        'chbRestart
        '
        Me.chbRestart.AutoSize = True
        Me.chbRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRestart.Location = New System.Drawing.Point(256, 18)
        Me.chbRestart.Name = "chbRestart"
        Me.chbRestart.Size = New System.Drawing.Size(86, 28)
        Me.chbRestart.TabIndex = 32
        Me.chbRestart.Text = "Restart"
        Me.chbRestart.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnMore)
        Me.GroupBox3.Controls.Add(Me.btnStop)
        Me.GroupBox3.Controls.Add(Me.btnStart)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(118, 418)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 88)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'btnMore
        '
        Me.btnMore.Location = New System.Drawing.Point(288, 28)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(75, 36)
        Me.btnMore.TabIndex = 2
        Me.btnMore.Text = "More"
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(154, 28)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 36)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(20, 28)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 36)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComment)
        Me.GroupBox2.Controls.Add(Me.txtSec)
        Me.GroupBox2.Controls.Add(Me.txtMin)
        Me.GroupBox2.Controls.Add(Me.txtHr)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(118, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 139)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(31, 95)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(294, 26)
        Me.txtComment.TabIndex = 6
        Me.txtComment.Text = "Comments"
        '
        'txtSec
        '
        Me.txtSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.Location = New System.Drawing.Point(261, 28)
        Me.txtSec.MaxLength = 2
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(64, 38)
        Me.txtSec.TabIndex = 5
        Me.txtSec.Text = "sec"
        Me.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMin
        '
        Me.txtMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(146, 28)
        Me.txtMin.MaxLength = 2
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(64, 38)
        Me.txtMin.TabIndex = 4
        Me.txtMin.Text = "min"
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHr
        '
        Me.txtHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHr.Location = New System.Drawing.Point(31, 28)
        Me.txtHr.MaxLength = 2
        Me.txtHr.Name = "txtHr"
        Me.txtHr.Size = New System.Drawing.Size(64, 38)
        Me.txtHr.TabIndex = 3
        Me.txtHr.Text = "hr"
        Me.txtHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoStandard)
        Me.GroupBox1.Controls.Add(Me.rdoCustom)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(118, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 100)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'rdoStandard
        '
        Me.rdoStandard.AutoSize = True
        Me.rdoStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoStandard.Location = New System.Drawing.Point(31, 43)
        Me.rdoStandard.Name = "rdoStandard"
        Me.rdoStandard.Size = New System.Drawing.Size(103, 28)
        Me.rdoStandard.TabIndex = 1
        Me.rdoStandard.TabStop = True
        Me.rdoStandard.Text = "Standard"
        Me.rdoStandard.UseVisualStyleBackColor = True
        '
        'rdoCustom
        '
        Me.rdoCustom.AutoSize = True
        Me.rdoCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCustom.Location = New System.Drawing.Point(233, 43)
        Me.rdoCustom.Name = "rdoCustom"
        Me.rdoCustom.Size = New System.Drawing.Size(92, 28)
        Me.rdoCustom.TabIndex = 2
        Me.rdoCustom.TabStop = True
        Me.rdoCustom.Text = "Custom"
        Me.rdoCustom.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-8, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(637, 49)
        Me.Panel3.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(287, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Local"
        '
        'TimerCountDown
        '
        Me.TimerCountDown.Interval = 1000
        '
        'frmLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(900, 553)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLocal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ttClose As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents rdoCustom As RadioButton
    Friend WithEvents rdoStandard As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSec As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtHr As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnMore As Button
    Friend WithEvents TimerCountDown As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ChbLock As CheckBox
    Friend WithEvents chbHibernate As CheckBox
    Friend WithEvents chbShutdown As CheckBox
    Friend WithEvents chbRestart As CheckBox
End Class
