<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStandard
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
        Me.CountDown = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pnlSettingDesign = New System.Windows.Forms.Panel()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblH = New System.Windows.Forms.Label()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtSet = New System.Windows.Forms.TextBox()
        Me.txtHrs = New System.Windows.Forms.TextBox()
        Me.txtMins = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlSettingDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'CountDown
        '
        Me.CountDown.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.shellControl.My.Resources.Resources.winLo
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMore)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.pnlSettingDesign)
        Me.Panel1.Controls.Add(Me.txtSec)
        Me.Panel1.Controls.Add(Me.txtSet)
        Me.Panel1.Controls.Add(Me.txtHrs)
        Me.Panel1.Controls.Add(Me.txtMins)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(895, 523)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(630, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 48)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.White
        Me.btnMore.ForeColor = System.Drawing.Color.Black
        Me.btnMore.Location = New System.Drawing.Point(472, 395)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(111, 48)
        Me.btnMore.TabIndex = 20
        Me.btnMore.Text = "More"
        Me.btnMore.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.White
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(355, 395)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(111, 48)
        Me.btnStop.TabIndex = 19
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(189, 395)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(111, 48)
        Me.btnStart.TabIndex = 18
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'pnlSettingDesign
        '
        Me.pnlSettingDesign.BackColor = System.Drawing.Color.White
        Me.pnlSettingDesign.Controls.Add(Me.lblSec)
        Me.pnlSettingDesign.Controls.Add(Me.lblMin)
        Me.pnlSettingDesign.Controls.Add(Me.lblH)
        Me.pnlSettingDesign.Location = New System.Drawing.Point(355, 169)
        Me.pnlSettingDesign.Name = "pnlSettingDesign"
        Me.pnlSettingDesign.Size = New System.Drawing.Size(111, 97)
        Me.pnlSettingDesign.TabIndex = 17
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.White
        Me.lblSec.ForeColor = System.Drawing.Color.Black
        Me.lblSec.Location = New System.Drawing.Point(71, 28)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(29, 31)
        Me.lblSec.TabIndex = 20
        Me.lblSec.Text = "s"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.White
        Me.lblMin.ForeColor = System.Drawing.Color.Black
        Me.lblMin.Location = New System.Drawing.Point(31, 28)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(37, 31)
        Me.lblMin.TabIndex = 19
        Me.lblMin.Text = "m"
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.BackColor = System.Drawing.Color.White
        Me.lblH.ForeColor = System.Drawing.Color.Black
        Me.lblH.Location = New System.Drawing.Point(3, 28)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(30, 31)
        Me.lblH.TabIndex = 18
        Me.lblH.Text = "h"
        '
        'txtSec
        '
        Me.txtSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.Location = New System.Drawing.Point(472, 274)
        Me.txtSec.MaxLength = 2
        Me.txtSec.Multiline = True
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(111, 97)
        Me.txtSec.TabIndex = 16
        '
        'txtSet
        '
        Me.txtSet.Location = New System.Drawing.Point(355, 169)
        Me.txtSet.Multiline = True
        Me.txtSet.Name = "txtSet"
        Me.txtSet.Size = New System.Drawing.Size(111, 97)
        Me.txtSet.TabIndex = 15
        '
        'txtHrs
        '
        Me.txtHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHrs.Location = New System.Drawing.Point(472, 169)
        Me.txtHrs.MaxLength = 1
        Me.txtHrs.Multiline = True
        Me.txtHrs.Name = "txtHrs"
        Me.txtHrs.Size = New System.Drawing.Size(111, 97)
        Me.txtHrs.TabIndex = 14
        '
        'txtMins
        '
        Me.txtMins.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMins.Location = New System.Drawing.Point(355, 274)
        Me.txtMins.MaxLength = 2
        Me.txtMins.Multiline = True
        Me.txtMins.Name = "txtMins"
        Me.txtMins.Size = New System.Drawing.Size(111, 97)
        Me.txtMins.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.DimGray
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"shudown", "restart", "log off", "lock", "hibernate"})
        Me.ComboBox1.Location = New System.Drawing.Point(342, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(241, 39)
        Me.ComboBox1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(322, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Standard Settings"
        '
        'frmStandard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 567)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmStandard"
        Me.Text = "frmStandard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSettingDesign.ResumeLayout(False)
        Me.pnlSettingDesign.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSec As TextBox
    Friend WithEvents txtSet As TextBox
    Friend WithEvents txtHrs As TextBox
    Friend WithEvents txtMins As TextBox
    Friend WithEvents pnlSettingDesign As Panel
    Friend WithEvents lblSec As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblH As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMore As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents CountDown As Timer
End Class
