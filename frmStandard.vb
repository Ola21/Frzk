Public Class frmStandard
    Public Property URL As System.String
    Private Sub frmStandard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "select an option"

        txtHrs.TextAlign = HorizontalAlignment.Center
        txtMins.TextAlign = HorizontalAlignment.Center
        txtSec.TextAlign = HorizontalAlignment.Center


        CountDown.Enabled = False
        If txtHrs.Text = "" Then
            txtHrs.Text = "0"
        End If
        If txtMins.Text = "" Then
            txtMins.Text = "00"
        End If

        If txtSec.Text = "" Then
            txtSec.Text = "00"
        End If



    End Sub

    Private Sub txtHrs_MouseLeave(sender As Object, e As EventArgs) Handles txtHrs.MouseLeave

    End Sub

    Private Sub CountDown_Tick(sender As Object, e As EventArgs) Handles CountDown.Tick
        txtSec.Text = txtSec.Text - 1

        If txtSec.Text < 0 Then
            txtMins.Text = txtMins.Text - 1

        End If

        If txtSec.Text < 0 Then
            txtSec.Text = 59

        End If

        If txtMins.Text < 0 Then
            txtHrs.Text = txtHrs.Text - 1

        End If

        If txtMins.Text < 0 Then
            txtMins.Text = 59
        End If

        If txtHrs.Text = 0 And txtMins.Text = 30 And txtSec.Text = 0 Then
            MessageBox.Show(txtMins.Text + "minits" + "remaining")

        End If

        If txtHrs.Text = 0 And txtMins.Text = 20 And txtSec.Text = 0 Then
            MessageBox.Show(txtMins.Text + "minits" + "remaining")

        End If

        If txtHrs.Text = 0 And txtMins.Text = 10 And txtSec.Text = 0 Then
            MessageBox.Show(txtMins.Text + "minits" + "remaining")

        End If

        If txtHrs.Text = 0 And txtMins.Text = 0 And txtSec.Text = 30 Then
            MessageBox.Show(txtSec.Text + "seconds" + "remaining")

        End If

        If txtHrs.Text = 0 And txtMins.Text = 0 And txtSec.Text = 0 Then
            CountDown.Enabled = False
            txtHrs.Text = 0
            txtMins.Text = 00
            txtSec.Text = 00
            MessageBox.Show("Time is up" + "\t" + "i am about to " + ComboBox1.Text + "now" + "" + "goodbye")

            If ComboBox1.SelectedItem.ToString = "lock" Then
                Shell("shutdown -h")
            End If
        End If

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        CountDown.Enabled = True
        CountDown.Start()
    End Sub


End Class