Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO

Public Class frmWol
    Dim ipAddress As IPAddress = Dns.Resolve(Dns.GetHostName()).AddressList(0)
    Dim strHostName As String = System.Net.Dns.GetHostName()

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWake.Click
        ''This expects the the mac address as a string of hex numbers separated by dashes
        ''e.g. 4d-3f-2-F-3c-40
        ''The "magic packet" consists of six FF's followed by the six bytes of the mac address repeated 16 times
        'Dim dataSend((17 * 6) - 1) As Byte
        'Dim macAddr(5) As Byte
        'Dim s() As String = Split(txtMac.Text, "-")
        'For i As Integer = 0 To 5
        '    dataSend(i) = &HFF                      'Six FF's at the front of the data
        '    macAddr(i) = Convert.ToByte(s(i), 16)   'Cache the six bytes of the mac address
        'Next
        'For i = 1 To 16                 'follow the six FF's with 16 copies of the mac address
        '    Array.Copy(macAddr, 0, dataSend, i * 6, 6)
        'Next

        'Dim myUdpClient As UdpClient
        'myUdpClient = New UdpClient(txtIP.Text, 9081)
        'myUdpClient.Send(dataSend, dataSend.Length)
        'myUdpClient.Close()
        Dim myAddress As String = "255.255.255.255"
        Dim MacAddress As String = txtMac.Text

        Dim udpClient As New System.Net.Sockets.UdpClient

        Dim buf(101) As Char

        Dim sendBytes As [Byte]() = System.Text.Encoding.ASCII.GetBytes(buf)

        For x As Integer = 0 To 5

            sendBytes(x) = CByte("&HFF")

        Next

        Dim i As Integer = 6

        For x As Integer = 1 To 16

            sendBytes(i) = CByte("&H" + MacAddress.Substring(0, 2))

            sendBytes(i + 1) = CByte("&H" + MacAddress.Substring(2, 2))

            sendBytes(i + 2) = CByte("&H" + MacAddress.Substring(4, 2))

            sendBytes(i + 3) = CByte("&H" + MacAddress.Substring(6, 2))

            sendBytes(i + 4) = CByte("&H" + MacAddress.Substring(8, 2))

            sendBytes(i + 5) = CByte("&H" + MacAddress.Substring(10, 2))

            i += 6

        Next

        udpClient.Send(sendBytes, sendBytes.Length, myAddress, 9)

        MessageBox.Show("Packet Sent!")

    End Sub

    Private Sub frmWol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboHosts.Text = Convert.ToString(strHostName)
        txtIP.Text = Convert.ToString(ipAddress)



    End Sub

    Private Sub txtSubnet_MouseEnter(sender As Object, e As EventArgs) Handles txtSubnet.MouseEnter
        txtSubnet.Clear()

    End Sub

    Private Sub txtSubnet_MouseLeave(sender As Object, e As EventArgs) Handles txtSubnet.MouseLeave
        If txtSubnet.Text = "" Then
            txtSubnet.Text = "Optional"
        End If
    End Sub


End Class