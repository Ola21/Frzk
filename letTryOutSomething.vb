Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Net.NetworkInformation

Public Class letTryOutSomething
    Dim myHost As String
    Dim myIps As System.Net.IPHostEntry
    Dim myIp As Net.IPAddress

    Private Sub letTryOutSomething_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim adapter As NetworkInterface
        For Each adapter In adapters
            Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
            If properties.UnicastAddresses.Count > 0 Then
                For Each unicastadress As UnicastIPAddressInformation In properties.UnicastAddresses
                    Dim ip As IPAddress = unicastadress.Address
                    If ip.AddressFamily = AddressFamily.InterNetwork Then
                        txtIpList.Items.Add(ip.ToString)
                    End If
                Next unicastadress
            End If
        Next adapter
    End Sub



End Class