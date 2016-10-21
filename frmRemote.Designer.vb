<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemote
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.lstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstMac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.cboIP = New System.Windows.Forms.ComboBox()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtHr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoStandard = New System.Windows.Forms.RadioButton()
        Me.rdoCustom = New System.Windows.Forms.RadioButton()
        Me.TimerCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstName, Me.lstIP, Me.lstMac, Me.lstStatus})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(375, 515)
        Me.ListView1.TabIndex = 0
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ChbLock)
        Me.Panel2.Controls.Add(Me.chbHibernate)
        Me.Panel2.Controls.Add(Me.chbShutdown)
        Me.Panel2.Controls.Add(Me.chbRestart)
        Me.Panel2.Location = New System.Drawing.Point(381, 312)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(499, 64)
        Me.Panel2.TabIndex = 26
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
        Me.GroupBox3.Location = New System.Drawing.Point(441, 382)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 88)
        Me.GroupBox3.TabIndex = 29
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
        Me.GroupBox2.Controls.Add(Me.cboIP)
        Me.GroupBox2.Controls.Add(Me.txtSec)
        Me.GroupBox2.Controls.Add(Me.txtMin)
        Me.GroupBox2.Controls.Add(Me.txtHr)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(441, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 139)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'cboIP
        '
        Me.cboIP.FormattingEnabled = True
        Me.cboIP.Items.AddRange(New Object() {"All", "192.168.9.144", "192.168.9.145", "192.168.9.146", "192.168.9.147", "192.168.9.148"})
        Me.cboIP.Location = New System.Drawing.Point(31, 91)
        Me.cboIP.Name = "cboIP"
        Me.cboIP.Size = New System.Drawing.Size(294, 32)
        Me.cboIP.TabIndex = 7
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
        Me.GroupBox1.Location = New System.Drawing.Point(441, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 100)
        Me.GroupBox1.TabIndex = 27
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
        'TimerCountDown
        '
        Me.TimerCountDown.Interval = 1000
        '
        'frmRemote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 514)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRemote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmRemote"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents lstName As ColumnHeader
    Friend WithEvents lstIP As ColumnHeader
    Friend WithEvents lstMac As ColumnHeader
    Friend WithEvents lstStatus As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ChbLock As CheckBox
    Friend WithEvents chbHibernate As CheckBox
    Friend WithEvents chbShutdown As CheckBox
    Friend WithEvents chbRestart As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnMore As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSec As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtHr As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoStandard As RadioButton
    Friend WithEvents rdoCustom As RadioButton
    Friend WithEvents cboIP As ComboBox
    Friend WithEvents TimerCountDown As Timer
End Class
