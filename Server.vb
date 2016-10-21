Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Public Class Server
    Dim trSendMessage As Thread
    Dim ipAddress As IPAddress = Dns.Resolve(Dns.GetHostName()).AddressList(0)

    Public Sub sendMsg()
        Dim host As String = txtClient.Text
        Dim port As Integer = txtPort.Text


        Try
            Dim tcpCli As New TcpClient(host, port)
            Dim ns As NetworkStream = tcpCli.GetStream

            ' Send data to the server.
            Dim sw As New StreamWriter(ns)
            If cboOptions.Text = "lock" Then
                sw.WriteLine("lock")
            End If
            If cboOptions.Text = "shutdown" Then
                sw.WriteLine("shutdown")
            End If
            If cboOptions.Text = "restart" Then
                sw.WriteLine("restart")
            End If
            If cboOptions.Text = "log off" Then
                sw.WriteLine("log off")
            End If
            If cboOptions.Text = "hibernate" Then
                sw.WriteLine("hibernate")
            End If









            sw.Flush()

            ' Receive and display data.
            Dim sr As New StreamReader(ns)
            Dim result As String = sr.ReadLine()
            If result = "Ok" Then
                MsgBox("Operation Performed!!!", MsgBoxStyle.Information, "Accepted by client")
            End If
            'MsgBox(result)
            sr.Close()
            sw.Close()
            ns.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Trim(txtClient.Text) = "" Then
            MsgBox("Please enter Client IP Address!!!", MsgBoxStyle.Information, "IP Address???")
            txtClient.Focus()
            Exit Sub
        End If
        If cboOptions.Text = "" Then
            trSendMessage = New Thread(AddressOf sendMsg)
            trSendMessage.Start()

        End If
        sendMsg()


    End Sub


    Private Sub Server_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblMyIp.Text = IPAddress.ToString
    End Sub
End Class