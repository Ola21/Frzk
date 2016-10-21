Imports System.Net.Mail
Imports System.Data.SqlServerCe
Imports System.Configuration


Public Class frmRegister
    Dim rand As String = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim names, email, company, address, username, password, purpose, Country, Uid As String
    Dim con As New SqlCeConnection(ConfigurationManager.ConnectionStrings("frzkConnect").ConnectionString)
    Private Sub chkAgree_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgree.CheckedChanged
        'Try
        '    con.Open()

        '    Dim cmd As SqlCeCommand
        '    Dim sel As String = "select * from tblReg where Username=@Username"

        '    cmd = New SqlCeCommand(sel, con)

        '    cmd.Parameters.AddWithValue("@Username", "lol")

        '    Dim dr As SqlCeDataReader = cmd.ExecuteReader()


        '    While dr.Read

        '        MessageBox.Show(dr(1).ToString)

        '    End While

        'Catch ex As Exception
        '    MessageBox.Show("" + ex.ToString)
        'Finally
        '    con.Close()


        'End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Dim cmd As SqlCeCommand
    Private Sub txtConfirmPwd_MouseLeave(sender As Object, e As EventArgs) Handles txtConfirmPwd.MouseLeave
        If txtPassword.Text <> txtConfirmPwd.Text Then
            'MessageBox.Show("not equal")
            txtConfirmPwd.Clear()
            txtConfirmPwd.Focus()

        End If
    End Sub

    Dim phone As Int32


    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnSubmit
        cboCountry.Text = "Select"

        Try
            Dim count = 0
            Dim strpos = ""
            Dim UID As New Random
            Dim result = ""
            While count <= 20

                strpos = UID.Next(0, rand.Length)
                result &= rand(strpos)
                count = count + 1

            End While

            txtUID.Text = result

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim mail As New MailMessage
        Dim SupportMail = "help.frzk@gmail.com"
        Dim Usermail = txtMail.Text
        Dim UID = txtUID.Text
        Dim gmailsmtp = "smtp.gmail.com"
        Dim yahoosmtp = "smtp.mail.yahoo.com"
        Dim outlooksmtp = "smtp-mail.outlook.com"

        Dim body As String = "Welcome to Frzk. Thank you trying out our app " & Environment.NewLine & "Your Frzk Unique ID (UID) is" & vbCrLf & UID & vbCrLf &
            "Please Keep your UID safe as you may need it to reset your password in the future" & vbCrLf & "You can mail us at support.frzk.com or visit our website www.frzkapp.com" & vbCrLf &
            "Regards Team Frzk"
        Try
            If Usermail.Contains("outlook.com") Then
                'MessageBox.Show("Outlook SMTP")
                mail.From = New MailAddress(SupportMail)
                mail.To.Add(Usermail)
                mail.Subject = "Thank you for Joining Frzk"
                mail.Body = body

                Dim smtp As New SmtpClient(outlooksmtp)

                smtp.Port = 587
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential(SupportMail, "FIYINbecky@2102")

                smtp.Send(mail)

            End If

            If Usermail.Contains("yahoo.com") Then
                'MessageBox.Show("Yahoo SMTP")
                mail.From = New MailAddress(SupportMail)
                mail.To.Add(Usermail)
                mail.Subject = "Thank you for Joining Frzk"
                mail.Body = body

                Dim smtp As New SmtpClient(yahoosmtp)

                smtp.Port = 25
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential(SupportMail, "FIYINbecky@2102")

                smtp.Send(mail)

            End If

            If Usermail.Contains("gmail.com") Then
                '    MessageBox.Show("gmail SMTP")
                mail.From = New MailAddress(SupportMail)
                mail.To.Add(Usermail)
                mail.Subject = "Thank you for Joining Frzk"
                mail.Body = body

                Dim smtp As New SmtpClient(gmailsmtp)

                smtp.Port = 587
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential(SupportMail, "FIYINbecky@2102")

                smtp.Send(mail)

            End If

            If chkAgree.Checked = True Then
                reg()
                Dim login As New frmFrzkLogin

                login.Show()
                Me.Hide()


            Else
                MessageBox.Show("Please Agree to terms and Conditions!")
            End If





        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
    Public Sub reg()
        names = txtName.Text
        email = txtMail.Text
        company = txtCompany.Text
        address = txtAddress.Text
        username = txtUsername.Text
        password = txtPassword.Text
        purpose = txtPurpose.Text
        Country = cboCountry.Text
        phone = txtPhone.Text
        Uid = txtUID.Text

        Try
            con.Open()

            Dim insert As String
            insert = "insert into tblReg(Name,Email,Phone,Company,Address,Purpose,Country,UID,Username,Password)values(@Name,@Email,@Phone,@Company,@Address,@Purpose,@Country,@UID,@Username,@Password)"
            cmd = New SqlCeCommand(insert, con)

            cmd.Parameters.AddWithValue("@Name", names)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@Phone", phone)
            cmd.Parameters.AddWithValue("@Company", company)
            cmd.Parameters.AddWithValue("@Address", address)
            cmd.Parameters.AddWithValue("@Purpose", purpose)
            cmd.Parameters.AddWithValue("@Country", Country)
            cmd.Parameters.AddWithValue("@UID", txtUID.Text)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Successful")


        Catch ex As Exception


            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()
        End Try







    End Sub
End Class