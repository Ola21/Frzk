Public Class frmLocal
    Dim hr, min, sec As Integer


    Private Sub txtMin_MouseEnter(sender As Object, e As EventArgs) Handles txtMin.MouseEnter
        txtMin.Text = "00"
    End Sub

    Private Sub txtSec_MouseEnter(sender As Object, e As EventArgs) Handles txtSec.MouseEnter
        txtSec.Text = "00"
    End Sub

    Private Sub txtHr_MouseEnter(sender As Object, e As EventArgs) Handles txtHr.MouseEnter
        txtHr.Text = "00"
    End Sub



    Private Sub txtHr_MouseLeave(sender As Object, e As EventArgs) Handles txtHr.MouseLeave
        If txtHr.Text = "" Then
            txtHr.Text = "00"
        End If

        If txtHr.Text <> "" Then
            hr = 23
            If txtHr.Text > hr Or txtHr.Text = "hr" Then
                txtHr.Clear()
                txtHr.Focus()

                txtHr.Text = "00"
            End If
        End If
    End Sub

    Private Sub txtMin_MouseLeave(sender As Object, e As EventArgs) Handles txtMin.MouseLeave
        If txtMin.Text = "" Then
            txtMin.Text = "00"
        End If

        If txtMin.Text <> "" Then
            min = 59
            If txtMin.Text > min Or txtMin.Text = "min" Then
                txtMin.Clear()
                txtMin.Focus()
                txtMin.Text = "00"
            End If
        End If
    End Sub

    Private Sub txtSec_MouseLeave(sender As Object, e As EventArgs) Handles txtSec.MouseLeave
        If txtSec.Text = "" Then
            txtSec.Text = "00"
        End If

        If txtSec.Text <> "" Or txtSec.Text = "sec" Then
            sec = 59
            If txtSec.Text > sec Then
                txtSec.Clear()
                txtSec.Focus()
                txtSec.Text = "00"
            End If
        End If
    End Sub

    Private Sub chbShutdown_CheckedChanged(sender As Object, e As EventArgs) Handles chbShutdown.CheckedChanged
        chbHibernate.Enabled = False
        ChbLock.Enabled = False
        chbRestart.Enabled = False

        If chbShutdown.Checked = False Then
            chbHibernate.Enabled = True
            ChbLock.Enabled = True
            chbRestart.Enabled = True
        End If

    End Sub

    Private Sub ChbLock_CheckedChanged(sender As Object, e As EventArgs) Handles ChbLock.CheckedChanged
        chbHibernate.Enabled = False
        chbShutdown.Enabled = False
        chbRestart.Enabled = False
        If ChbLock.Checked = False Then
            chbHibernate.Enabled = True
            chbShutdown.Enabled = True
            chbRestart.Enabled = True
        End If
    End Sub

    Private Sub chbRestart_CheckedChanged(sender As Object, e As EventArgs) Handles chbRestart.CheckedChanged
        chbHibernate.Enabled = False
        chbShutdown.Enabled = False
        ChbLock.Enabled = False

        If chbRestart.Checked = False Then
            chbHibernate.Enabled = True
            ChbLock.Enabled = True
            chbShutdown.Enabled = True
        End If
    End Sub

    Private Sub chbHibernate_CheckedChanged(sender As Object, e As EventArgs) Handles chbHibernate.CheckedChanged
        ChbLock.Enabled = False
        chbShutdown.Enabled = False
        chbRestart.Enabled = False

        If chbHibernate.Checked = False Then
            chbShutdown.Enabled = True
            ChbLock.Enabled = True
            chbRestart.Enabled = True
        End If
    End Sub


    Private Sub txtSec_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSec.MouseClick

        txtSec.Text = ""
    End Sub

    Private Sub txtMin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtMin.MouseClick
        txtMin.Text = ""
    End Sub

    Private Sub txtComment_MouseEnter(sender As Object, e As EventArgs) Handles txtComment.MouseEnter
        txtComment.Text = ""
    End Sub

    Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles TimerCountDown.Tick
        txtSec.Text = txtSec.Text - 1

        If txtSec.Text < 0 Then
            txtMin.Text = txtMin.Text - 1

        End If

        If txtSec.Text < 0 Then
            txtSec.Text = 59

        End If

        If txtMin.Text < 0 Then
            txtHr.Text = txtHr.Text - 1

        End If

        If txtMin.Text < 0 Then
            txtMin.Text = 59
        End If

        If txtHr.Text = 0 And txtMin.Text = 30 And txtSec.Text = 0 Then
            MessageBox.Show(txtMin.Text + "minits" + "remaining")

        End If

        If txtHr.Text = 0 And txtMin.Text = 20 And txtSec.Text = 0 Then
            MessageBox.Show(txtMin.Text + "minits" + "remaining")

        End If

        If txtHr.Text = 0 And txtMin.Text = 10 And txtSec.Text = 0 Then
            MessageBox.Show(txtMin.Text + "minits" + "remaining")

        End If

        If txtHr.Text = 0 And txtMin.Text = 0 And txtSec.Text = 30 Then
            MessageBox.Show(txtSec.Text + "seconds" + "remaining")

        End If

        If txtHr.Text = 0 And txtMin.Text = 0 And txtSec.Text = 0 Then
            TimerCountDown.Enabled = False
            txtHr.Text = 0
            txtMin.Text = 0
            txtSec.Text = 00
            '  MessageBox.Show("Time is up" + "\t" + "i am about to " + "now" + "" + "goodbye")


            If ChbLock.Checked = True Then
                '  Shell("shutdown -h")
                Process.Start("C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation")
                MessageBox.Show("Time is up" + "\t" + "i am about to " + ChbLock.Text + "now" + "" + "goodbye")
                Reset()


            End If

            If chbShutdown.Checked = True Then
                'Shell("shutdown -s")
                MessageBox.Show("Time is up" + "\t" + "i am about to " + chbShutdown.Text + "now" + "" + "goodbye")
                Reset()

            End If

            If chbRestart.Checked = True Then
                'Shell("shutdown -r")
                MessageBox.Show("Time is up" + "\t" + "i am about to " + chbRestart.Text + "now" + "" + "goodbye")
                Reset()

            End If


            If chbHibernate.Checked = True Then
                'Shell("shutdown -h")
                MessageBox.Show("Time is up" + "\t" + "i am about to " + chbHibernate.Text + "now" + "" + "goodbye")
                Reset()

            End If
            reset()

        End If

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If btnStart.Text = "Start" Then


            TimerCountDown.Enabled = True
            TimerCountDown.Start()
            btnStart.Text = "Pause"
            'btnStart.BackColor = Color.Green

        ElseIf btnStart.Text = "Pause" Then
            TimerCountDown.Stop()
            btnStart.Text = "Start"
            'btnStart.BackColor = Color.White


        End If
        'txtHr.ReadOnly = True
        ' txtMin.ReadOnly = True
        'txtSec.ReadOnly = True
        txtMin.Enabled = False
        txtHr.Enabled = False
        txtSec.Enabled = False

        btnStart.Enabled = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Dim result3 As DialogResult = MessageBox.Show("are you sure you want to stop?",
        "Abort",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2)
        If result3 = DialogResult.Yes Then
            'btnStop.BackColor = Color.Red
            TimerCountDown.Enabled = False
            TimerCountDown.Stop()

            Reset()


            btnStop.Enabled = False
            MsgBox("Thank u")
        End If
        If result3 = DialogResult.No Then
            'do nothing

        End If

        If result3 = DialogResult.Cancel Then
            'do  nothing
        End If

        If btnStart.Text = "Pause" Then

        End If
    End Sub
    Public Sub reset()
        txtMin.Enabled = True
        txtSec.Enabled = True
        txtHr.Enabled = True

        btnStart.Text = "Start"
        btnStop.Text = "Stop"
        btnMore.Text = "More"



        txtHr.Text = "hr"
        txtMin.Text = "min"
        txtSec.Text = "sec"
        chbHibernate.Enabled = True
        chbHibernate.Checked = False
        chbRestart.Checked = False
        chbRestart.Enabled = True
        ChbLock.Enabled = True
        ChbLock.Checked = False
        chbShutdown.Enabled = True
        chbShutdown.Checked = False
    End Sub
    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        Dim result3 As DialogResult = MessageBox.Show("are you sure you want to stop?",
        "Add More Time",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2)
        If result3 = DialogResult.Yes Then

            TimerCountDown.Enabled = False
            TimerCountDown.Stop()


            txtHr.Enabled = True
            txtMin.Enabled = True
            txtSec.Enabled = True



            MsgBox("Thank u")
        End If
        If result3 = DialogResult.No Then
            'do nothing

        End If

        If result3 = DialogResult.Cancel Then
            'do  nothing
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub rdoCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCustom.CheckedChanged


    End Sub

    Private Sub txtHr_MouseClick(sender As Object, e As MouseEventArgs) Handles txtHr.MouseClick
        txtHr.Text = ""
    End Sub


    Private Sub frmLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoStandard.Checked = True

    End Sub


End Class