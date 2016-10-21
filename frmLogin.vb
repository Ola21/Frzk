Imports System.Data.SqlServerCe
Public Class frmLogin

    Dim con As SqlCeConnection = New SqlCeConnection("Data Source= |DataDirectory|\DB.sdf;Password=ladybecks@2102")
    Dim dr As SqlCeDataReader
    Dim cmd As SqlCeCommand = Nothing
    Private Sub lblclose_Click(sender As Object, e As EventArgs) Handles lblclose.Click
        Me.Close()

    End Sub

    Private Sub linkforgetpwd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkforgetpwd.LinkClicked
        frmForgotpwd.Show()

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        'Try
        '    If txtuser.Text = "root" And txtPass.Text = "123" Then
        '        Dim result As Integer = MessageBox.Show("Do you want to proceed ?", "login", MessageBoxButtons.YesNo)

        '        If result = DialogResult.Yes Then
        '            redoFrzk.Show()
        '            Me.Hide()
        '        ElseIf result = DialogResult.No Then
        '            Me.Close()


        '        End If

        '    Else



        '    End If

        'Catch ex As Exception

        'End Try

        Try
            con.Open()


            Dim sel As String = "select * from tblLogin where Username=@Username"




            cmd = New SqlCeCommand(sel, con)
            cmd.Parameters.AddWithValue("@Username", txtuser.Text)

            dr = cmd.ExecuteReader


            While dr.Read()


                MessageBox.Show("test")

                If txtuser.Text = dr.GetString(1) And txtPass.Text = dr.GetString(2) Then
                    MessageBox.Show("Login Successful")
                    Dim main As New frmMain
                    main.Show()
                    Me.Close()

                Else
                    MessageBox.Show("Wrong Credentials!")

                    txtuser.Clear()
                    txtPass.Clear()
                    txtuser.Focus()
                End If
            End While

            dr.Close()
            cmd.Dispose()






        Catch ex As Exception
            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()
        End Try

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnlogin


    End Sub

    Private Sub lnkReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReg.LinkClicked
        frmRegister.Show()

    End Sub


End Class