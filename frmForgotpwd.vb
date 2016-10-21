Public Class frmForgotpwd
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click




    End Sub

    Private Sub btnPwdResetExit_Click(sender As Object, e As EventArgs) Handles btnPwdResetExit.Click
        Me.Close()

    End Sub

    Private Sub btnPwdReset_Click(sender As Object, e As EventArgs) Handles btnPwdReset.Click
        If (cboPassResetUID.Text = "yes") Then
            lblmsg.Text = "Password has been sent to your app email"
            lblmsg.Show()


        ElseIf (cboPassResetUID.Text = "no") Then

            lblmsg.Text = "UID has been sent to your app email"
            lblmsg.Show()

            txtemailuid.Text = ""
            txtemailuid.Focus()



        End If

    End Sub

    Private Sub frmForgotpwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboPassResetUID.SelectedIndex = 0



        'lblEmailorUid.Hide()
        lblmsg.Hide()


        lblEmailorUid.Text += "app email"

    End Sub
End Class