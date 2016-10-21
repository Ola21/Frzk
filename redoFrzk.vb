Public Class redoFrzk
    Dim forgetpwd As frmForgotpwd
    Dim frmset As frmSettiings
    Dim loginfrm As frmLogin
    Private Sub redoFrzk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        forgetpwd = New frmForgotpwd

        forgetpwd.MdiParent = Me
        loginfrm = New frmLogin
        loginfrm.MdiParent = Me
        loginfrm.Show()
        mnuFrzk.Hide()



    End Sub
    Public Shared ReadOnly Property ControlDark As Color





    Private Sub linkforgetpwd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)


        frmset = New frmSettiings



        frmset.MdiParent = Me
        frmset.Show()

        'frmForgotpwd.Show()
    End Sub
End Class