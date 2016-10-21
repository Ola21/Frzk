<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Crazy_Forms
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.lblNow = New System.Windows.Forms.Label()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtHr = New System.Windows.Forms.TextBox()
        Me.CountDown = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.chbEvent = New System.Windows.Forms.CheckBox()
        Me.cboDayNite = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboExpiry = New System.Windows.Forms.ComboBox()
        Me.cboDays = New System.Windows.Forms.ComboBox()
        Me.cboOptions = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(271, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Custom  Settings"
        '
        'dtpTime
        '
        Me.dtpTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Location = New System.Drawing.Point(293, 68)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(200, 20)
        Me.dtpTime.TabIndex = 12
        '
        'lblNow
        '
        Me.lblNow.AutoSize = True
        Me.lblNow.BackColor = System.Drawing.Color.Transparent
        Me.lblNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNow.ForeColor = System.Drawing.Color.White
        Me.lblNow.Location = New System.Drawing.Point(478, 472)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(101, 31)
        Me.lblNow.TabIndex = 13
        Me.lblNow.Text = "Label1"
        '
        'ClockTimer
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(208, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Set Time"
        '
        'txtMin
        '
        Me.txtMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(471, 169)
        Me.txtMin.MaxLength = 1
        Me.txtMin.Multiline = True
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(113, 101)
        Me.txtMin.TabIndex = 16
        '
        'txtHr
        '
        Me.txtHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHr.Location = New System.Drawing.Point(368, 169)
        Me.txtHr.MaxLength = 2
        Me.txtHr.Multiline = True
        Me.txtHr.Name = "txtHr"
        Me.txtHr.Size = New System.Drawing.Size(97, 101)
        Me.txtHr.TabIndex = 15
        '
        'CountDown
        '
        Me.CountDown.Interval = 1000
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(12, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 79)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(12, 312)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(141, 79)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.White
        Me.btnMore.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMore.ForeColor = System.Drawing.Color.Black
        Me.btnMore.Location = New System.Drawing.Point(12, 245)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(141, 79)
        Me.btnMore.TabIndex = 29
        Me.btnMore.Text = "More"
        Me.btnMore.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.White
        Me.btnStop.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(12, 169)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(141, 79)
        Me.btnStop.TabIndex = 28
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(12, 92)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(141, 79)
        Me.btnStart.TabIndex = 27
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'chbEvent
        '
        Me.chbEvent.AutoSize = True
        Me.chbEvent.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chbEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEvent.Location = New System.Drawing.Point(339, 276)
        Me.chbEvent.Name = "chbEvent"
        Me.chbEvent.Size = New System.Drawing.Size(263, 42)
        Me.chbEvent.TabIndex = 33
        Me.chbEvent.Text = "Schedule Event"
        Me.chbEvent.UseVisualStyleBackColor = True
        '
        'cboDayNite
        '
        Me.cboDayNite.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDayNite.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDayNite.FormattingEnabled = True
        Me.cboDayNite.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboDayNite.Location = New System.Drawing.Point(590, 203)
        Me.cboDayNite.Name = "cboDayNite"
        Me.cboDayNite.Size = New System.Drawing.Size(96, 45)
        Me.cboDayNite.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(208, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 31)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Expiry"
        '
        'cboExpiry
        '
        Me.cboExpiry.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboExpiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExpiry.FormattingEnabled = True
        Me.cboExpiry.Items.AddRange(New Object() {"lifetime", "1 week", "1 month", "3 months"})
        Me.cboExpiry.Location = New System.Drawing.Point(339, 406)
        Me.cboExpiry.Name = "cboExpiry"
        Me.cboExpiry.Size = New System.Drawing.Size(257, 45)
        Me.cboExpiry.TabIndex = 37
        '
        'cboDays
        '
        Me.cboDays.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDays.FormattingEnabled = True
        Me.cboDays.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cboDays.Location = New System.Drawing.Point(339, 327)
        Me.cboDays.Name = "cboDays"
        Me.cboDays.Size = New System.Drawing.Size(257, 45)
        Me.cboDays.TabIndex = 34
        '
        'cboOptions
        '
        Me.cboOptions.BackColor = System.Drawing.Color.Gray
        Me.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOptions.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOptions.ForeColor = System.Drawing.Color.White
        Me.cboOptions.Items.AddRange(New Object() {"shudown", "restart", "log off", "lock", "hibernate"})
        Me.cboOptions.Location = New System.Drawing.Point(293, 103)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(200, 26)
        Me.cboOptions.TabIndex = 38
        '
        'Crazy_Forms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.shellControl.My.Resources.Resources.winLo
        Me.ClientSize = New System.Drawing.Size(802, 512)
        Me.Controls.Add(Me.cboOptions)
        Me.Controls.Add(Me.cboDays)
        Me.Controls.Add(Me.chbEvent)
        Me.Controls.Add(Me.cboExpiry)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDayNite)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtHr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNow)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Crazy_Forms"
        Me.Text = "Crazy_Forms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents lblNow As Label
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtHr As TextBox
    Friend WithEvents CountDown As Timer
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnMore As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents chbEvent As CheckBox
    Friend WithEvents cboDayNite As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboExpiry As ComboBox
    Friend WithEvents cboDays As ComboBox
    Friend WithEvents cboOptions As ComboBox
End Class
