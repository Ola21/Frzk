
Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading

Imports System.Data.SqlServerCe
Imports System.Net.Mail
Imports System.Configuration

Imports System.Text
Imports System.Web
Public Class client

    Dim trlisten As Thread
    Dim trShutdown As Thread
    Dim trReboot As Thread
    Dim trLogOff As Thread
    Sub ListenToServer()


        Dim LISTENING As Boolean
        Dim localhostAddress As IPAddress = IPAddress.Parse(ipAddress.ToString())

        Dim port As String = Integer.Parse(txtPort.Text)    '' PORT ADDRESS
        ''''''''''' making socket tcpList ''''''''''''''''

        Dim tcpList As New TcpListener(localhostAddress, port)
        Try
            tcpList.Start()
            LISTENING = True

            Do While LISTENING

                Do While tcpList.Pending = False And LISTENING = True
                    ' Yield the CPU for a while.
                    Thread.Sleep(10)
                Loop
                If Not LISTENING Then Exit Do

                Dim tcpCli As TcpClient = tcpList.AcceptTcpClient()
                'ListBox1.Items.Add("Data from " & "128.10.20.63")
                Dim ns As NetworkStream = tcpCli.GetStream
                Dim sr As New StreamReader(ns)
                ''''''''' get data from client '''''''''''''''
                Dim receivedData As String = sr.ReadLine()
                If receivedData = "lock" Then
                    MsgBox("We Locked")
                End If
                If receivedData = "shutdown" Then
                    MsgBox("We shutdown")
                End If
                If receivedData = "lock" Then
                    MsgBox("We restarted")
                End If

                If receivedData = "log off" Then
                    MsgBox("We logged off")
                End If
                If receivedData = "lock" Then
                    MsgBox("We hibernate")
                End If
                Dim returnedData As String = "Ok" '& " From Server"
                Dim sw As New StreamWriter(ns)
                sw.WriteLine(returnedData)
                sw.Flush()
                sr.Close()
                sw.Close()
                ns.Close()
                tcpCli.Close()
            Loop
            tcpList.Stop()
        Catch ex As Exception
            'error
            LISTENING = False
        End Try
    End Sub
    Dim ipAddress As IPAddress = Dns.Resolve(Dns.GetHostName()).AddressList(0)
    Dim strHostName As String = System.Net.Dns.GetHostName()
    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPort.Text = 9081
        NotifyIcon1.Icon = Me.Icon
        lblMyIp.Text = strHostName
        txtIp.Text = ipAddress.ToString

        trlisten = New Thread(AddressOf ListenToServer)
        trlisten.Start()
        ' getIp()

    End Sub

    Private Sub getIp()

        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()


        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)

    End Sub

    Private Sub btnSendSMS_Click(sender As Object, e As EventArgs) Handles btnSendSMS.Click
        smsOTP()

    End Sub
    Public Sub smsOTP()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim url As String
        Dim username As String = "admin"
        Dim password As String = "jidlekbim@2102"
        Dim host As String = "http://127.0.0.1:9501"
        Dim originator As String = "9967469401"
        Dim body As String = "test if the sms gateway is valid or not"

        Try

            url = host + "/api?action=sendmessage&" _
                     & "username=" & HttpUtility.UrlEncode(username) _
                     & "&password=" + HttpUtility.UrlEncode(password) _
                     & "&recipient=" + HttpUtility.UrlEncode(txtTo.Text) _
                     & "&messagetype=SMS:TEXT" _
                     & "&messagedata=" + HttpUtility.UrlEncode(txtMsg.Text) _
                     & "&originator=" + HttpUtility.UrlEncode(txtFrom.Text) _
                     & "&serviceprovider=" _
                     & "&responseformat=html"


            request = DirectCast(WebRequest.Create(url), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)

            ' MessageBox.Show("Response: " & response.StatusDescription)
            MessageBox.Show("OTP sent!. Check your Mobile Number for password!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class