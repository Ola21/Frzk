Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
    End Sub

    Private Sub lblLocal_MouseHover(sender As Object, e As EventArgs) Handles lblLocal.MouseHover
        lblLocal.BackColor = Color.Teal
        lblLocal.ForeColor = Color.White

        Me.Refresh()

    End Sub

    Private Sub lblLocal_MouseLeave(sender As Object, e As EventArgs) Handles lblLocal.MouseLeave
        lblLocal.BackColor = Color.Transparent
        lblLocal.ForeColor = Color.Black
        ' Label1.ForeColor = Color.FromArgb(150, Color.Red);
    End Sub

    Private Sub lblLocal_Click(sender As Object, e As EventArgs) Handles lblLocal.Click
        lblLocal.BackColor = Color.Black
        lblLocal.ForeColor = Color.White

        Dim localfrm As New frmLocal


        localfrm.MdiParent = Me
        localfrm.Location = New Point(-1, 100)
        localfrm.Show()
        If localfrm.rdoCustom.Checked = True Then
            Dim localcust As New frmLocalCustom
            localcust.MdiParent = Me
            localcust.Location = New Point(-1, 100)
            localcust.Show()
        End If
    End Sub

    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        lblSettings.BackColor = Color.Black
        lblSettings.ForeColor = Color.White
        Dim setting As New frmSettiings

        setting.MdiParent = Me
        setting.Location = New Point(-1, 100)

        setting.Show()


    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
        'Me.Hide()

    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        lblHelp.BackColor = Color.Black
        lblHelp.ForeColor = Color.White
        Dim help As New frmHelp

        help.MdiParent = Me
        help.Location = New Point(-1, 100)

        help.Show()
    End Sub

    Private Sub lblRemote_Click(sender As Object, e As EventArgs) Handles lblRemote.Click
        lblRemote.BackColor = Color.Black
        lblRemote.ForeColor = Color.White
        Dim remote As New frmRemote

        remote.MdiParent = Me
        remote.Location = New Point(-1, 100)

        remote.Show()
    End Sub

    Private Sub lblWOL_Click(sender As Object, e As EventArgs) Handles lblWOL.Click
        lblWOL.BackColor = Color.Black
        lblWOL.ForeColor = Color.White
        Dim wol As New frmWol

        wol.MdiParent = Me
        wol.Location = New Point(-1, 100)

        wol.Show()
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click

    End Sub

    Private Sub lblRemote_DoubleClick(sender As Object, e As EventArgs) Handles lblRemote.DoubleClick
        lblRemote.BackColor = Color.White
        lblRemote.ForeColor = Color.Black

        Dim lol As New frmLocal
        lol.MdiParent = Me
        lol.Location = New Point(-1, 100)
        lol.Show()
        lblLocal.ForeColor = Color.White
        lblLocal.BackColor = Color.Black


    End Sub

    Private Sub frmMain_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick


    End Sub

    Private Sub lblWOL_DoubleClick(sender As Object, e As EventArgs) Handles lblWOL.DoubleClick
        lblWOL.BackColor = Color.White
        lblWOL.ForeColor = Color.Black
        Dim lol As New frmLocal
        lol.MdiParent = Me
        lol.Location = New Point(-1, 100)
        lol.Show()
        lblLocal.ForeColor = Color.White
        lblLocal.BackColor = Color.Black

    End Sub

    Private Sub lblSettings_DoubleClick(sender As Object, e As EventArgs) Handles lblSettings.DoubleClick
        lblSettings.BackColor = Color.White
        lblSettings.ForeColor = Color.Black
        Dim lol As New frmLocal
        lol.MdiParent = Me
        lol.Location = New Point(-1, 100)
        lol.Show()
        lblLocal.ForeColor = Color.White
        lblLocal.BackColor = Color.Black

    End Sub

    Private Sub lblHelp_DoubleClick(sender As Object, e As EventArgs) Handles lblHelp.DoubleClick
        lblHelp.BackColor = Color.White
        lblHelp.ForeColor = Color.Black

        Dim lol As New frmLocal
        lol.MdiParent = Me
        lol.Location = New Point(-1, 100)
        lol.Show()
        lblLocal.ForeColor = Color.White
        lblLocal.BackColor = Color.Black

    End Sub
End Class