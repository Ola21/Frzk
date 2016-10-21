Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System.Data.SqlServerCe

Public Class frmRemote
    Dim con As New SqlCeConnection("Data Source=|DataDirectory|\final.sdf;Password=ladybecky")
    Dim dr As SqlCeDataReader
    Dim trSendMessage As Thread
    Dim alert As Thread

    Dim port As Integer
    Dim ip() As Array = Nothing
    Dim finalIp As String
    Dim lent As Integer
    Dim host As String
    Private Sub frmRemote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        port = 9081

        Dim lent As String = cboIP.Items.Count.ToString

        Dim i As Integer

        For i = 0 To lent - 1
            ' MessageBox.Show(cboIP.Items(i).ToString)
        Next

        Try
            con.Open()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)

            Dim da As New SqlCeDataAdapter("Select * from tblClientData", con)
            Dim row As DataRow

            For Each row In dt.Rows
                ListView1.Items.Add(row.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(row.Item(1))
            Next
            da.Fill(dt)
        Catch ex As Exception

        Finally
            con.Close()

        End Try

    End Sub



    Public Sub msgAlert()



        Try
            Dim tcpCli As New TcpClient(host, port)
            Dim ns As NetworkStream = tcpCli.GetStream

            ' Send data to the server.
            Dim sw As New StreamWriter(ns)
            If ChbLock.Checked Then
                sw.WriteLine("lock")
            End If
            If chbShutdown.Checked Then
                sw.WriteLine("shutdown")
            End If
            If chbRestart.Checked Then
                sw.WriteLine("restart")
            End If

            If chbHibernate.Checked Then
                sw.WriteLine("hibernate")
            End If









            sw.Flush()

            ' Receive and display data.
            Dim sr As New StreamReader(ns)
            Dim result As String = sr.ReadLine()
            MessageBox.Show("" + result)
            If result = "NO" Then
                TimerCountDown.Stop()
                ' reset()


            End If
            'MsgBox(result)
            sr.Close()
            sw.Close()
            ns.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

        End Try
    End Sub



    Public Sub sendMsg()


        Try
            Dim tcpCli As New TcpClient(host, port)
            Dim ns As NetworkStream = tcpCli.GetStream

            ' Send data to the server.
            Dim sw As New StreamWriter(ns)
            If ChbLock.Checked Then
                sw.WriteLine("lock")
            End If
            If chbShutdown.Checked Then
                sw.WriteLine("shutdown")
            End If
            If chbRestart.Checked Then
                sw.WriteLine("restart")
            End If

            If chbHibernate.Checked Then
                sw.WriteLine("hibernate")
            End If









            sw.Flush()

            ' Receive and display data.
            Dim sr As New StreamReader(ns)
            Dim result As String = sr.ReadLine()
            MessageBox.Show("" + result)
            If result = "Ok" Then
                MsgBox("Operation Performed!!!", MsgBoxStyle.Information, "Accepted by client")


            End If
            'MsgBox(result)
            sr.Close()
            sw.Close()
            ns.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            'reset()
        End Try
    End Sub


    Dim hr, min, sec As Integer


    Private Sub txtMin_MouseEnter(sender As Object, e As EventArgs) Handles txtMin.MouseEnter
        txtMin.Text = "00"
    End Sub

    Private Sub txtSec_MouseEnter(sender As Object, e As EventArgs) Handles txtSec.MouseEnter
        txtSec.Text = "00"
    End Sub

    Private Sub txtHr_MouseEnter(sender As Object, e As EventArgs) Handles txtHr.MouseEnter
        txtHr.Text = "00"
    End Sub



    Private Sub txtHr_MouseLeave(sender As Object, e As EventArgs) Handles txtHr.MouseLeave
        If txtHr.Text = "" Then
            txtHr.Text = "00"
        End If

        If txtHr.Text <> "" Then
            hr = 23
            If txtHr.Text > hr Or txtHr.Text = "hr" Then
                txtHr.Clear()
                txtHr.Focus()

                txtHr.Text = "00"
            End If
        End If
    End Sub

    Private Sub txtMin_MouseLeave(sender As Object, e As EventArgs) Handles txtMin.MouseLeave
        If txtMin.Text = "" Then
            txtMin.Text = "00"
        End If

        If txtMin.Text <> "" Then
            min = 59
            If txtMin.Text > min Or txtMin.Text = "min" Then
                txtMin.Clear()
                txtMin.Focus()
                txtMin.Text = "00"
            End If
        End If
    End Sub

    Private Sub txtSec_MouseLeave(sender As Object, e As EventArgs) Handles txtSec.MouseLeave
        If txtSec.Text = "" Then
            txtSec.Text = "00"
        End If

        If txtSec.Text <> "" Or txtSec.Text = "sec" Then
            sec = 59
            If txtSec.Text > sec Then
                txtSec.Clear()
                txtSec.Focus()
                txtSec.Text = "00"
            End If
        End If
    End Sub

    Private Sub chbShutdown_CheckedChanged(sender As Object, e As EventArgs) Handles chbShutdown.CheckedChanged
        chbHibernate.Enabled = False
        ChbLock.Enabled = False
        chbRestart.Enabled = False

        If chbShutdown.Checked = False Then
            chbHibernate.Enabled = True
            ChbLock.Enabled = True
            chbRestart.Enabled = True
        End If

    End Sub

    Private Sub ChbLock_CheckedChanged(sender As Object, e As EventArgs) Handles ChbLock.CheckedChanged
        chbHibernate.Enabled = False
        chbShutdown.Enabled = False
        chbRestart.Enabled = False
        If ChbLock.Checked = False Then
            chbHibernate.Enabled = True
            chbShutdown.Enabled = True
            chbRestart.Enabled = True
        End If
    End Sub

    Private Sub chbRestart_CheckedChanged(sender As Object, e As EventArgs) Handles chbRestart.CheckedChanged
        chbHibernate.Enabled = False
        chbShutdown.Enabled = False
        ChbLock.Enabled = False

        If chbRestart.Checked = False Then
            chbHibernate.Enabled = True
            ChbLock.Enabled = True
            chbShutdown.Enabled = True
        End If
    End Sub

    Private Sub chbHibernate_CheckedChanged(sender As Object, e As EventArgs) Handles chbHibernate.CheckedChanged
        ChbLock.Enabled = False
        chbShutdown.Enabled = False
        chbRestart.Enabled = False

        If chbHibernate.Checked = False Then
            chbShutdown.Enabled = True
            ChbLock.Enabled = True
            chbRestart.Enabled = True
        End If
    End Sub


    Private Sub txtSec_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSec.MouseClick

        txtSec.Text = ""
    End Sub

    Private Sub txtMin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtMin.MouseClick
        txtMin.Text = ""
    End Sub



    Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles TimerCountDown.Tick
        txtSec.Text = txtSec.Text - 1

        If txtSec.Text < 0 Then
            txtMin.Text = txtMin.Text - 1

        End If

        If txtSec.Text < 0 Then
            txtSec.Text = 59

        End If

        If txtMin.Text < 0 Then
            txtHr.Text = txtHr.Text - 1

        End If

        If txtMin.Text < 0 Then
            txtMin.Text = 59
        End If

        If txtHr.Text = 0 And txtMin.Text = 30 And txtSec.Text = 0 Then
            MessageBox.Show(txtMin.Text + "minits" + "remaining")

        End If

        If txtHr.Text = 0 And txtMin.Text = 20 And txtSec.Text = 0 Then
            MessageBox.Show(txtMin.Text + "minits" + "remaining")

        End If

        If txtHr.Text = 0 And txtMin.Text = 10 And txtSec.Text = 0 Then
            MessageBox.Show(txtMin.Text + "minits" + "remaining")

        End If

        If txtHr.Text = 0 And txtMin.Text = 0 And txtSec.Text = 30 Then
            MessageBox.Show(txtSec.Text + "seconds" + "remaining")

        End If

        If txtHr.Text = 0 And txtMin.Text = 0 And txtSec.Text = 0 Then

            TimerCountDown.Enabled = False
            txtHr.Text = 0
            txtMin.Text = 0
            txtSec.Text = 0




            If cboIP.Text = "All" Then

                Dim lent As String = cboIP.Items.Count.ToString

                Dim i As Integer

                For i = 1 To lent - 1
                    host = cboIP.Items(i).ToString
                    trSendMessage = New Thread(AddressOf sendMsg)
                    trSendMessage.Start()


                Next


            Else
                host = cboIP.Text
                trSendMessage = New Thread(AddressOf sendMsg)
                trSendMessage.Start()


            End If


            'reset()


        End If

        '  MessageBox.Show("Time is up" + "\t" + "i am about to " + "now" + "" + "goodbye")



        ' reset()


    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' host = cboIP.Text
        cboIP.Enabled = False


        If btnStart.Text = "Start" Then


            TimerCountDown.Enabled = True
            TimerCountDown.Start()
            btnStart.Text = "Pause"
            'btnStart.BackColor = Color.Green

        ElseIf btnStart.Text = "Pause" Then
            TimerCountDown.Stop()
            btnStart.Text = "Start"
            'btnStart.BackColor = Color.White


        End If
        'txtHr.ReadOnly = True
        ' txtMin.ReadOnly = True
        'txtSec.ReadOnly = True
        txtMin.Enabled = False
        txtHr.Enabled = False
        txtSec.Enabled = False

        btnStart.Enabled = True






    End Sub
    Public Sub reset()
        txtMin.Enabled = True
        txtSec.Enabled = True
        txtHr.Enabled = True
        cboIP.Enabled = True
        btnStart.Text = "Start"
        btnStop.Text = "Stop"
        btnMore.Text = "More"



        txtHr.Text = "hr"
        txtMin.Text = "min"
        txtSec.Text = "sec"
        chbHibernate.Enabled = True
        chbHibernate.Checked = False
        chbRestart.Checked = False
        chbRestart.Enabled = True
        ChbLock.Enabled = True
        ChbLock.Checked = False
        chbShutdown.Enabled = True
        chbShutdown.Checked = False

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Dim result3 As DialogResult = MessageBox.Show("are you sure you want to stop?",
        "Abort",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2)
        If result3 = DialogResult.Yes Then
            ' btnStop.BackColor = Color.Red
            TimerCountDown.Enabled = False
            TimerCountDown.Stop()

            reset()



            btnStop.Enabled = False
            MsgBox("Thank u")
        End If
        If result3 = DialogResult.No Then
            'do nothing

        End If

        If result3 = DialogResult.Cancel Then
            'do  nothing
        End If

        If btnStart.Text = "Pause" Then

        End If
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        Dim result3 As DialogResult = MessageBox.Show("are you sure you want to stop?",
        "Add More Time",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2)
        If result3 = DialogResult.Yes Then

            TimerCountDown.Enabled = False
            TimerCountDown.Stop()


            txtHr.Enabled = True
            txtMin.Enabled = True
            txtSec.Enabled = True



            MsgBox("Thank u")
        End If
        If result3 = DialogResult.No Then
            'do nothing

        End If

        If result3 = DialogResult.Cancel Then
            'do  nothing
        End If
    End Sub



    Private Sub rdoCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCustom.CheckedChanged


    End Sub

    Private Sub txtHr_MouseClick(sender As Object, e As MouseEventArgs) Handles txtHr.MouseClick
        txtHr.Text = ""
    End Sub


    Private Sub frmLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoStandard.Checked = True

    End Sub



End Class