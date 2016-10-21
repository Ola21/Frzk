Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets

Public Class frmCode
    Dim myHost As String
    Dim myIps As System.Net.IPHostEntry
    Dim myIp As Net.IPAddress
    ' Dim nic As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()


    Private Sub soln1_Click(sender As Object, e As EventArgs) Handles soln1.Click
        myHost = System.Net.Dns.GetHostName()
        MessageBox.Show("" + myHost)

        myIps = System.Net.Dns.GetHostEntry(myHost)

        ' Loop through all IP addresses And display each 
        For Each myIp In myIps.AddressList


            otp.Items.Add(myIp.ToString())
        Next


    End Sub

    Private Sub soln2_Click(sender As Object, e As EventArgs) Handles soln2.Click

        otp.Items.Clear()

        Dim ipTxt As String
        ipTxt += txtIpOne.Text + "." + txtIpTwo.Text + "." + txtIpThree.Text + "."

        myHost = System.Net.Dns.GetHostName()

        myIps = System.Net.Dns.GetHostEntry(myHost)

        ' Loop through all IP addresses And display each 
        For Each myIp In myIps.AddressList

            If myIp.ToString.StartsWith(ipTxt) Then
                otp.Items.Add(myIp.ToString())
            End If


        Next
    End Sub

    Private Sub soln3_Click(sender As Object, e As EventArgs) Handles soln3.Click
        Dim ipTxt As String
        ipTxt += txtIpOne.Text + "." + txtIpTwo.Text + "."

        myHost = System.Net.Dns.GetHostName()

        myIps = System.Net.Dns.GetHostEntry(myHost)

        ' Loop through all IP addresses And display each 
        For Each myIp In myIps.AddressList

            If myIp.ToString.StartsWith(ipTxt) Then
                cboAddresses.Items.Add(myIp.ToString)
            End If


        Next
    End Sub

    Private Sub soln4_Click(sender As Object, e As EventArgs) Handles soln4.Click
        'getInterfaces()
        'ShowNetworkInterfaces()
        ' ShowNetworkInterface()
        'GetPrimaryNic()
        experimet()

    End Sub
    Private Function getInterfaces()
        Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim adapter As NetworkInterface
        For Each adapter In adapters
            Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
            otp3.Items.Add(adapter.Description)
            otp3.Items.Add("  DNS suffix................................. :{0}" + properties.DnsSuffix)
            'otp3.Items.Add("  DNS enabled ............................. : {0}" + properties.IsDnsEnabled)
            'otp3.Items.Add("  Dynamically configured DNS .............. : {0}" + properties.IsDynamicDnsEnabled)
            'otp3.Items.Add(properties.GetIPv4Properties()).ToString()
        Next adapter


        For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            otp3.Items.Add(nic.GetIPProperties().UnicastAddresses(0).Address).ToString()
        Next
        Return 0

    End Function
    Public Sub ShowNetworkInterfaces()
        Dim computerProperties As IPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties()
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        If nics Is Nothing OrElse nics.Length < 1 Then
            otp3.Items.Add("  No network interfaces found.").ToString()
            Exit Sub
        End If
        For Each adapter As NetworkInterface In nics
            Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
            otp3.Items.Add(adapter.Name).ToString()
            For Each ip As System.Net.IPAddress In properties.DnsAddresses
                otp3.Items.Add("DNS server : {0}" + ip.ToString())
            Next
        Next

    End Sub
    Public Sub ShowNetworkInterface()
        Dim computerProperties As IPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties()
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        If nics Is Nothing OrElse nics.Length < 1 Then
            otp3.Items.Add("  No network interfaces found.").ToString()
            Exit Sub
        End If
        For Each adapter As NetworkInterface In nics
            otp3.Items.Add(adapter.Name).ToString()
        Next
    End Sub
    Private Function GetPrimaryNic()

        ' DESCRIPTION: this function  will provide networking details for primary network card
        Dim PrimaryNic As New Collection

        For Each networkCard As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
            ' Find network cards with gateway information (this may show more than one network card depending on computer)

            For Each gatewayAddr As GatewayIPAddressInformation In networkCard.GetIPProperties.GatewayAddresses
                ' if gateway address is NOT 0.0.0.0 and the network card status is UP then we've found the main network card
                If gatewayAddr.Address.ToString <> "0.0.0.0" And networkCard.OperationalStatus.ToString() = "Up" Then
                    PrimaryNic.Add("Interface GUID: " & networkCard.Id)
                    PrimaryNic.Add("Name:".PadRight(15) & networkCard.Name)
                    PrimaryNic.Add("Description:".PadRight(15) & networkCard.Description)
                    PrimaryNic.Add("Status:".PadRight(15) & networkCard.OperationalStatus.ToString)
                    PrimaryNic.Add("Status:".PadRight(15) & (networkCard.Speed / 1000000).ToString("#,000") & " Mbps")
                    PrimaryNic.Add("MAC Address:".PadRight(15) & networkCard.GetPhysicalAddress.ToString)

                    ' Get IP Address(es) and subnet(s) information
                    Dim IpAddressAndSubnet As UnicastIPAddressInformation

                    For Each IpAddressAndSubnet In networkCard.GetIPProperties.UnicastAddresses
                        PrimaryNic.Add("IP Address:".PadRight(15) & IpAddressAndSubnet.Address.ToString)
                        PrimaryNic.Add("Subnet:".PadRight(15) & IpAddressAndSubnet.IPv4Mask.ToString)
                    Next

                    ' Get IP gateway information
                    PrimaryNic.Add("Gateway:".PadRight(15) & gatewayAddr.Address.ToString)

                    ' Get IP DNS information
                    Dim DnsAddress As IPAddress

                    For Each DnsAddress In networkCard.GetIPProperties.DnsAddresses
                        PrimaryNic.Add("DNS entry:".PadRight(15) & DnsAddress.ToString)
                    Next

                    ' Other IP information
                    Dim IPProp As IPInterfaceProperties = networkCard.GetIPProperties

                    If Not IPProp Is Nothing Then
                        PrimaryNic.Add("DNS Enabled:".PadRight(15) & IPProp.IsDnsEnabled.ToString)
                        PrimaryNic.Add("Dynamic DNS:".PadRight(15) & IPProp.IsDynamicDnsEnabled.ToString)
                    End If

                    Dim IPv4 As IPv4InterfaceProperties = networkCard.GetIPProperties.GetIPv4Properties
                    If Not IPv4 Is Nothing Then
                        PrimaryNic.Add("DHCP Enabled:".PadRight(15) & IPv4.IsDhcpEnabled.ToString)
                        PrimaryNic.Add("MTU Setting:".PadRight(15) & IPv4.Mtu.ToString)
                        PrimaryNic.Add("Uses WINS:".PadRight(15) & IPv4.UsesWins.ToString)

                    End If

                End If
            Next
        Next

        Return PrimaryNic
    End Function
    Public Sub experimet()
        Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim adapter As NetworkInterface
        For Each adapter In adapters
            Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
            If properties.UnicastAddresses.Count > 0 Then
                For Each unicastadress As UnicastIPAddressInformation In properties.UnicastAddresses
                    Dim ip As IPAddress = unicastadress.Address
                    If ip.AddressFamily = AddressFamily.InterNetwork Then
                        otp3.Items.Add(ip.ToString)
                    End If
                Next unicastadress
            End If
        Next adapter
    End Sub

    Private Sub frmCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' new idea ... create a table in server app that list all ip address with host name and mac addresses

End Class



