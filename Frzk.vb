Public Class Frzk

    Public ref As Boolean = True

    Private Sub Frzk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLocalOpt.Hide()
        pnlLocalStandard.Hide()


        'declaring the initial value of the text fields

        CountDown.Enabled = False
        If txtHr.Text = "" Then
            txtHr.Text = "00"
        End If
        If txtMin.Text = "" Then
            txtMin.Text = "00"
        End If

        If txtSec.Text = "" Then
            txtSec.Text = "00"
        End If



    End Sub

    Private Sub Local_MouseHover(sender As Object, e As EventArgs) Handles Local.MouseHover


        lblNow.Text = Now
        ClockTimer.Start()
        If ref = True Then
            pnlLocalOpt.Show()
            Local.BackColor = Color.FromArgb(255, 255, 255, 255)
            Local.Image = My.Resources._1_2_onMouse_over_Local
        End If



    End Sub




    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        lblNow.Text = Now
    End Sub

    Private Sub Local_MouseLeave(sender As Object, e As EventArgs) Handles Local.MouseLeave
        If ref = True Then
            Local.Image = My.Resources._1_Local
            pnlLocalOpt.Hide()
        End If

    End Sub

    Private Sub Local_MouseClick(sender As Object, e As MouseEventArgs) Handles Local.MouseClick
        ref = False

        Local.Image = My.Resources._1_3_onClick_Local
        pnlLocalOpt.Show()

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Refresh()
        ref = True
        Local.Image = My.Resources._1_Local
        pnlLocalOpt.Hide()

        Me.Show()

    End Sub

    Private Sub lblMain_Click(sender As Object, e As EventArgs) Handles lblMain.Click
        Me.Refresh()
        ref = True
        Local.Image = My.Resources._1_Local
        pnlLocalOpt.Hide()

        Me.Show()
    End Sub

    Private Sub lblStd_Click(sender As Object, e As EventArgs) Handles lblStd.Click
        pnlLocalStandard.Show()

    End Sub

    Private Sub CountDown_Tick(sender As Object, e As EventArgs) Handles CountDown.Tick
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
            CountDown.Enabled = False
            txtHr.Text = 00
            txtMin.Text = 00
            txtSec.Text = 00
            MessageBox.Show("Time is up" + "\t" + "i am about to " + cboOptions.Text + "now" + "" + "goodbye")


            If cboOptions.SelectedItem.ToString = "lock" Then
                '  Shell("shutdown -h")
                Process.Start("C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation")
                reset()


            End If

            If cboOptions.SelectedItem.ToString = "shutdown" Then
                Shell("shutdown -s")
                reset()

            End If

            If cboOptions.SelectedItem.ToString = "restart" Then
                Shell("shutdown -r")
                reset()

            End If
            If cboOptions.SelectedItem.ToString = "log off" Then
                Shell("shutdown -l")
                reset()

            End If

            If cboOptions.SelectedItem.ToString = "hibernate" Then
                Shell("shutdown -h")
                reset()

            End If
        End If



    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click


        If btnStart.Text = "Start" Then
            lblHr.Text = txtHr.Text
            lblMin.Text = txtMin.Text
            lblSec.Text = txtSec.Text


            CountDown.Enabled = True
            CountDown.Start()
            btnStart.Text = "Pause"
            btnStart.BackColor = Color.Green

        ElseIf btnStart.Text = "Pause" Then
            CountDown.Stop()
            btnStart.Text = "Start"
            btnStart.BackColor = Color.White


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
            btnStop.BackColor = Color.Red
            CountDown.Enabled = False
            CountDown.Stop()

            reset()


            btnStop.Enabled = False
            MsgBox("Thank u")
        End If
        If result3 = DialogResult.No Then
            'do nothing

        End If

        If result3 = DialogResult.Cancel Then
            'do  nothing
        End If




    End Sub

    Public Sub reset()
        lblSec.Text = "S"
        lblMin.Text = "M"
        lblHr.Text = "H"

        txtHr.Text = 00
        txtMin.Text = 00
        txtSec.Text = 00
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        Dim result3 As DialogResult = MessageBox.Show("are you sure you want to stop?",
        "Add More Time",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2)
        If result3 = DialogResult.Yes Then

            CountDown.Enabled = False
            CountDown.Stop()


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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Refresh()
        pnlLocalStandard.Hide()

        pnlLocalOpt.Show()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub
End Class