Imports System.Data.SqlServerCe
Imports System.Configuration

Public Class frmForgotPassword
    Dim connects As String = ConfigurationManager.ConnectionStrings("frzkConnect").ConnectionString
    Dim con As SqlCeConnection = New SqlCeConnection(connects)
    Dim dr As SqlCeDataReader
    Dim cmd As SqlCeCommand = Nothing
    'Dim timeCountdown = 0
    Dim timecount = 6
    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetform()

        rdoYes.Checked = True

        Me.AcceptButton = btnSubmit


    End Sub
    Public Sub yes()

        Try
            Dim u As String = txtUID.Text
            Dim sel As String = "select * from tblReg where UID=@UID"

            cmd = New SqlCeCommand(sel, con)
            cmd.Parameters.AddWithValue("@UID", u)


            dr = cmd.ExecuteReader

            While dr.Read


                MessageBox.Show(dr.GetString(2) + vbNewLine + dr.GetString(10))


            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Public Sub no()

        Dim sel As String = "select * from tblReg where Email=@Email"

        cmd = New SqlCeCommand(sel, con)
        cmd.Parameters.AddWithValue("@Email", txtUID.Text)

        dr = cmd.ExecuteReader

        While dr.Read

            MessageBox.Show(dr.GetString(8))

        End While


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            con.Open()

            If rdoYes.Checked = True Then
                lblVal.Text = "Enter UID"
                lblUIDorMail.ForeColor = Color.Green
                'getD()
                yes()

                lblUIDorMail.Text = "Password has been sent to your app email"
                timeToreturnToLogin.Enabled = True
                timeToreturnToLogin.Start()


            End If
            If rdoNo.Checked = True Then
                lblVal.Text = "Enter Email"
                lblUIDorMail.ForeColor = Color.DarkRed
                no()

                lblUIDorMail.Text = "UID has been sent to your app email"
                timeToreturnToLogin.Enabled = True
                timeToreturnToLogin.Start()

            End If

        Catch ex As Exception
            MessageBox.Show("" + ex.ToString)

        Finally
            con.Close()

        End Try


    End Sub
    Public Sub resetform()
        lblVal.Text = "Enter UID"
        lblUIDorMail.ForeColor = Color.Black


    End Sub

    Private Sub rdoYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoYes.CheckedChanged
        lblVal.Text = "Enter UID"
        lblUIDorMail.ForeColor = Color.Black
        lblUIDorMail.Text = "Please check your mail for the App Password"
    End Sub

    Private Sub rdoNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNo.CheckedChanged
        lblVal.Text = "Enter Email"
        lblUIDorMail.ForeColor = Color.Black
        lblUIDorMail.Text = "Please check your mail for the App UID"
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub timeToreturnToLogin_Tick(sender As Object, e As EventArgs) Handles timeToreturnToLogin.Tick
        'timeCountdown += 1
        'If timeCountdown = 5 Then
        'Me.Hide()
        'frmFrzkLogin.Show()
        'timeToreturnToLogin.Stop()

        'End If
        timecount -= 1
        lblUIDorMail.ForeColor = Color.DarkGray
        lblUIDorMail.Text = "returning to app login in " & "" & timecount & "" & "s"
        If timecount = 0 Then
            Me.Hide()
            Dim login As New frmFrzkLogin

            login.Show()
            timeToreturnToLogin.Stop()

        End If

    End Sub

    Public Sub getD()
        Dim sel As String = "select * from tblReg where Username=@Username"

        cmd = New SqlCeCommand(sel, con)
        cmd.Parameters.AddWithValue("@Username", txtUID.Text)

        dr = cmd.ExecuteReader

        While dr.Read
            txtUID.Clear()
            txtUID.Text = dr.GetString(8)
            MessageBox.Show(dr.GetString(8)+vbNewLine + dr.GetString(2))
        End While

        dr.Dispose()

    End Sub


End Class