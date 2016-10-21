Imports System.Net

Public Class Crazy_Forms

    Dim ischecked As Boolean = True

    Dim d As DateTime

    Dim sysDate As Date
    Dim myDate As Date

    Dim sysTime As Date
    Dim myTime As Date
    Private Sub Crazy_Forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        GetIPAddress()

        ClockTimer.Enabled = True
        lblNow.Text = Now
        ClockTimer.Start()
        cboDays.Enabled = False
        cboExpiry.Enabled = False

    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        lblNow.Text = Now
        Dim time As String = sysDate.Hour




    End Sub

    Private Sub GetIPAddress()

        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()


        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)

    End Sub

    Private Sub chbEvent_CheckedChanged(sender As Object, e As EventArgs) Handles chbEvent.CheckedChanged
        If chbEvent.Checked = True Then
            dtpTime.Enabled = False
            cboDays.Enabled = True
            cboExpiry.Enabled = True
            Me.Refresh()

        End If

        If chbEvent.Checked = False Then
            dtpTime.Enabled = True
            cboDays.Enabled = False
            cboExpiry.Enabled = False
        End If

    End Sub


End Class