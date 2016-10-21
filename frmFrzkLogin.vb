Imports System.Data.SqlServerCe
Imports System.Configuration

Public Class frmFrzkLogin
    Dim connects As String = ConfigurationManager.ConnectionStrings("frzkConnect").ConnectionString
    Dim con As SqlCeConnection = New SqlCeConnection(connects)
    Dim dr As SqlCeDataReader
    Dim cmd As SqlCeCommand = Nothing
    Dim def As String

    Dim user, pass, login As String

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub linkforgetpwd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkforgetpwd.LinkClicked
        Dim f2 As New frmForgotPassword
        f2.Show()

        'frmForgotPassword.Show()
        Me.Hide()

    End Sub

    Private Sub lnkReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReg.LinkClicked
        frmRegister.Show()
        Me.Hide()

    End Sub

    Private Sub frmFrzkLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnSubmit
        'check()

        def = "root"

    End Sub


    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub
    Public Sub updat()

        Dim up As String = "update tblLogin set login=1 where Username=@Username"

        Try
            'con.Open()

            cmd = New SqlCeCommand(up, con)

            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally
            'con.Close()

        End Try

    End Sub
    Public Sub del()
        Dim del As String = "delete from tblLogin where Username=@Username"
        Try
            con.Open()

            cmd = New SqlCeCommand(del, con)

            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Successful !")


        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally
            con.Close()


        End Try
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'del()



        'Try

        '    con.Open()

        '    Dim insert As String = "insert into tblLogin(Username,Password,login)values(@Username,@Password,@login)"

        '    cmd = New SqlCeCommand(insert, con)

        '    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        '    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
        '    cmd.Parameters.AddWithValue("@login", login)

        '    cmd.ExecuteNonQuery()

        '    MessageBox.Show("Successful !")

        'Catch ex As Exception
        '    MessageBox.Show("" + ex.ToString)

        'Finally
        '    con.Close()

        'End Try



        'Try
        '    If txtUsername.Text = "root" And txtPassword.Text = "123" Then
        '        Dim result As Integer = MessageBox.Show("Do you want to proceed ?", "login", MessageBoxButtons.YesNo)

        '        If result = DialogResult.Yes Then
        '            Dim fm As New frmMain
        '            fm.Show()

        '            Me.Hide()
        '        ElseIf result = DialogResult.No Then
        '            Me.Close()


        '        End If

        '    Else



        '    End If

        'Catch ex As Exception

        'End Try

        'If txtUsername.Text = def Then
        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '        defLogin()

        '    Else
        '        defLogin()

        '    End If



        'Else

        '    If con.State = ConnectionState.Open Then
        '        con.Close()
        '        newUser()

        '    Else
        '        defLogin()
        '        newUser()
        '    End If

        'End If

        Try
            con.Open()
            If txtUsername.Text = def Then
                defLogin()
            Else
                newUser()

            End If
        Catch ex As Exception
            MessageBox.Show("" + ex.ToString)

        Finally
            con.Close()

        End Try




    End Sub

    Public Sub check()


        Try
            con.Open()


            Dim sel As String = "select  from tblLogin where Username=1"




            cmd = New SqlCeCommand(sel, con)
            'cmd.Parameters.AddWithValue("@Username", txtUsername.Text)

            dr = cmd.ExecuteReader()






            While dr.Read()


                MessageBox.Show("test")

            End While

            dr.Close()
            cmd.Dispose()






        Catch ex As Exception
            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()
        End Try




    End Sub

    Private Sub lblOTP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblOTP.LinkClicked
        Dim otp As New frmLoginOTP

        otp.Show()
        Me.Hide()


    End Sub

    Public Sub defLogin()
        Try
            'con.Open()


            Dim sel As String = "select * from tblLogin where Username=@Username"

            Dim log As Integer



            cmd = New SqlCeCommand(sel, con)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)

            dr = cmd.ExecuteReader


            While dr.Read()



                ' MessageBox.Show("test")

                ' MessageBox.Show(dr.GetString(2))
                user = dr.GetString(1)
                pass = dr.GetString(2)
                log = dr.GetInt32(3)

                If log = 0 Then
                    If txtUsername.Text = user And txtPassword.Text = pass Then
                        MessageBox.Show("Login Successful")
                        Dim main As New frmMain
                        Me.Hide()

                        main.Show()

                    Else
                        MessageBox.Show("Wrong Credentials!")

                        txtUsername.Clear()
                        txtPassword.Clear()
                        txtUsername.Focus()
                    End If
                    updat()

                Else
                    MessageBox.Show("You have Exhausted your Default Login Credentials")
                End If

            End While

            dr.Close()
            cmd.Dispose()






        Catch ex As Exception
            MessageBox.Show("" + ex.ToString)

        Finally

            'con.Close()
        End Try
    End Sub
    Public Sub newUser()
        Try
            'con.Open()


            Dim sel As String = "select * from tblReg where Username=@Username"

            ' Dim log As Integer



            cmd = New SqlCeCommand(sel, con)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)

            dr = cmd.ExecuteReader


            While dr.Read()

                'log = dr.GetInt32(3)


                ' MessageBox.Show("test")

                ' MessageBox.Show(dr.GetString(2))
                user = dr.GetString(9)
                pass = dr.GetString(10)

                If txtUsername.Text = user And txtPassword.Text = pass Then
                    MessageBox.Show("Login Successful")
                    Dim main As New frmMain
                    Me.Hide()

                    main.Show()

                Else
                    MessageBox.Show("Wrong Credentials!")

                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtUsername.Focus()
                End If
            End While

            dr.Close()
            cmd.Dispose()






        Catch ex As Exception
            MessageBox.Show("" + ex.ToString)

        Finally

            'con.Close()
        End Try
    End Sub
End Class