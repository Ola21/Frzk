Imports System.Net.Mail


Public Class frmHelp
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtError_MouseEnter(sender As Object, e As EventArgs)
        'txtError.Clear()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://www.rccgindia.org/albums/frzk/help.html")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.rccgindia.org/albums/frzk/help.html")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://www.rccgindia.org/albums/frzk/help.html")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("http://www.rccgindia.org/albums/frzk/help.html")
    End Sub

    Private Sub txtError_MouseEnter_1(sender As Object, e As EventArgs) Handles txtError.MouseEnter
        txtError.Clear()

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try

            Dim mail As New MailMessage
            Dim SupportMail = "help.frzk@gmail.com"
            Dim Usermail = "help.frzk@gmail.com"


            Dim gmailsmtp = "smtp.gmail.com"
            Dim yahoosmtp = "smtp.mail.yahoo.com"
            Dim outlooksmtp = "smtp-mail.outlook.com"

            Dim body As String = txtError.Text


            If Usermail.Contains("gmail.com") Then
                ' MessageBox.Show("gmail SMTP")
                mail.From = New MailAddress(SupportMail)
                mail.To.Add(Usermail)
                mail.Subject = "Error"
                mail.Body = body

                Dim smtp As New SmtpClient(gmailsmtp)

                smtp.Port = 587
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential(SupportMail, "FIYINbecky@2102")

                smtp.Send(mail)
                MessageBox.Show("Message Sent")
                txtError.Text = "Please tell  us what you are facing."

            End If




        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class