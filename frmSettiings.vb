Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Net.NetworkInformation
Imports System.Data.SqlServerCe
Imports System.Data.SqlServerCe.Entity
Imports Microsoft.Ink
Imports System.Configuration

Public Class frmSettiings


    'Dim con As SqlCeConnection
    Dim con As New SqlCeConnection("Data Source= |DataDirectory|\final.sdf;Password=ladybecky@2102")
    Dim dr As SqlCeDataReader
    Dim ipAddress As IPAddress = Dns.Resolve(Dns.GetHostName()).AddressList(0)
    Dim strHostName As String = System.Net.Dns.GetHostName()
    Dim nic() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
    Dim nicProp As IPInterfaceProperties = Nothing
    Dim gateway As GatewayIPAddressInformationCollection = Nothing

    Public Shared Sub DisplayGatewayAddresses()
        Console.WriteLine("Gateways")
        Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim adapter As NetworkInterface
        For Each adapter In adapters
            Dim adapterProperties As IPInterfaceProperties = adapter.GetIPProperties()
            Dim addresses As GatewayIPAddressInformationCollection = adapterProperties.GatewayAddresses
            If addresses.Count > 0 Then
                Console.WriteLine(adapter.Description)
                Dim address As GatewayIPAddressInformation
                For Each address In addresses
                    MessageBox.Show("" + address.ToString)
                Next address
                Console.WriteLine()
            End If
        Next adapter

    End Sub



    Public Sub overview()
        txtHost.Text = strHostName
        txtIP.Text = ipAddress.ToString
        txtPort.Text = 9081
        txtUser.Text = "root"
        txtMac.Text = nic(2).GetPhysicalAddress.ToString

        Dim myNetworkAdapters() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Dim myAdapterProps As IPInterfaceProperties = Nothing
        Dim myGateways As GatewayIPAddressInformationCollection = Nothing

        For Each adapter As NetworkInterface In myNetworkAdapters
            myAdapterProps = adapter.GetIPProperties

            myGateways = myAdapterProps.GatewayAddresses

            Dim gate As GatewayIPAddressInformation
            'txtGate.Text = gate.Address.ToString()

            For Each Gateway As GatewayIPAddressInformation In myGateways

                Dim gate1 = Gateway.Address.ToString
                Dim gate2 = Gateway.Address.ToString
                cboGate.Items.Add(gate1)
                cboGate.SelectedIndex = 0









            Next
        Next




    End Sub
    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click



        Dim main As New frmMain


        Dim login As New frmFrzkLogin

        login.Show()

        main.Close()









    End Sub
    Public Sub update()
        txtUpHost.Text = strHostName
        txtUPIP.Text = ipAddress.ToString
        txtUPMac.Text = nic(2).GetPhysicalAddress.ToString
        txtUPUser.Text = "root"
        txtUPPort.Text = "9081"
        txtUPGate.Text = cboGate.Text


    End Sub
    Private Sub frmSettiings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        overview()
        Update()
        'checkDB()
    End Sub

    Public Sub checkDB()
        con.Open()
        Try
            Dim check As String = "select * from tblUpdate where Username=@Username"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(check, con)
            cmd.Parameters.AddWithValue("@Username", txtUser.Text)

            dr = cmd.ExecuteReader
            Dim row As Boolean = False


            While dr.Read
                row = True
                If row = True Then
                    MessageBox.Show("has rows")
                Else
                    MessageBox.Show("No rows")
                End If

                MessageBox.Show(dr(0).ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("" + ex.ToString)

        Finally
            con.Close()
        End Try


    End Sub

    Private Sub chbAllowAll_CheckedChanged(sender As Object, e As EventArgs) Handles chbAllowAll.CheckedChanged
        If chbAllowAll.Checked = True Then
            AllowAllYes()

        Else

            AllowAllNo()

        End If
    End Sub

    Private Sub chbReqPwd_CheckedChanged(sender As Object, e As EventArgs) Handles chbReqPwd.CheckedChanged
        If chbReqPwd.Checked = True Then
            ReqPwdYes()

        Else

            reqPwdNo()

        End If

    End Sub

    Private Sub chbAllowRemoteAcce_CheckedChanged(sender As Object, e As EventArgs) Handles chbAllowRemoteAcce.CheckedChanged
        If chbAllowRemoteAcce.Checked = True Then
            AllowRemoteYes()

        Else
            AllowRemoteNO()

        End If
    End Sub

    Public Sub AllowRemoteNO()
        con.Open()

        Try
            Dim update As String = "update  tblAppCntl set AllowRemote=@AllowRemote where Id=1"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(update, con)
            cmd.Parameters.AddWithValue("@AllowRemote", "NO")


            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile updated")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally
            con.Close()
        End Try

    End Sub

    Public Sub AllowRemoteYes()
        con.Open()

        Try
            Dim update As String = "update  tblAppCntl set AllowRemote=@AllowRemote where Id=1"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(update, con)
            cmd.Parameters.AddWithValue("@AllowRemote", "YES")


            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile updated")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()
        End Try

    End Sub

    Public Sub reqPwdNo()
        con.Open()

        Try
            Dim update As String = "update  tblAppCntl set ReqPwd=@ReqPwd where Id=1"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(update, con)
            cmd.Parameters.AddWithValue("@ReqPwd", "NO")


            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile updated")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)


        Finally
            con.Close()
        End Try


    End Sub
    Public Sub AllowAllYes()
        con.Open()

        Try
            Dim update As String = "update  tblAppCntl set AllowAll=@AllowAll where Id=1"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(update, con)
            cmd.Parameters.AddWithValue("@AllowAll", "YES")


            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile updated")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally


            con.Close()
        End Try



    End Sub

    Public Sub AllowAllNo()
        con.Open()

        Try
            Dim update As String = "update  tblAppCntl set AllowAll=@AllowAll where Id=1"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(update, con)
            cmd.Parameters.AddWithValue("@AllowAll", "NO")


            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile updated")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()

        End Try


    End Sub
    Public Sub ReqPwdYes()
        con.Open()

        Try
            Dim update As String = "update  tblAppCntl set ReqPwd=@ReqPwd where Id=1"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(update, con)
            cmd.Parameters.AddWithValue("@ReqPwd", "YES")


            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile updated")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()

        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        con.Open()

        Try
            Dim update As String = "update  tblUpdate set Host=@Host,IP=@IP,MAC=@MAC,Gateway=@Gateway,Port=@Port where Username=@Username"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(update, con)
            cmd.Parameters.AddWithValue("@Host", txtUpHost.Text)
            cmd.Parameters.AddWithValue("@Username", txtUPUser.Text)
            cmd.Parameters.AddWithValue("@IP", txtUPIP.Text)
            cmd.Parameters.AddWithValue("@MAC", txtUPMac.Text)
            cmd.Parameters.AddWithValue("@Gateway", txtUPGate.Text)
            cmd.Parameters.AddWithValue("@Port", txtUPPort.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile updated")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        con.Open()

        Try
            Dim del As String = "delete from tblUpdate where Username=@Username"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(del, con)

            cmd.Parameters.AddWithValue("@Username", txtUPUser.Text)
            cmd.Parameters.AddWithValue("@IP", txtUPIP.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile Deleted")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con.Open()

        Try
            Dim insert As String = "insert into tblUpdate (Host,Username,IP,MAC,Gateway,Port) values(@Host,@Username,@IP,@MAC,@Gateway,@Port)"

            Dim cmd As SqlCeCommand
            cmd = New SqlCeCommand(insert, con)
            cmd.Parameters.AddWithValue("@Host", txtUpHost.Text)
            cmd.Parameters.AddWithValue("@Username", txtUPUser.Text)
            cmd.Parameters.AddWithValue("@IP", txtUPIP.Text)
            cmd.Parameters.AddWithValue("@MAC", txtUPMac.Text)
            cmd.Parameters.AddWithValue("@Gateway", txtUPGate.Text)
            cmd.Parameters.AddWithValue("@Port", txtUPPort.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Profile Saved")




        Catch ex As Exception

            MessageBox.Show("" + ex.ToString)

        Finally

            con.Close()

        End Try
    End Sub

    Private Sub tabSec_Click(sender As Object, e As EventArgs) Handles tabSec.Click

    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        Dim res As New frmForgotPassword

        res.Show()

    End Sub

    Private Sub lblReg_Click(sender As Object, e As EventArgs) Handles lblReg.Click
        Dim reg As New frmRegister

        reg.Show()

    End Sub
End Class