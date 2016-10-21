Public Class frmloading
    Private Sub frmloading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerLoad.Enabled = True


    End Sub

    Private Sub timerLoad_Tick(sender As Object, e As EventArgs) Handles timerLoad.Tick
        ProgressBar1.Increment(+1)
        If ProgressBar1.Value = 30 Then
            timerLoad.Enabled = False


            frmFrzkLogin.Show()
            Me.Hide()



        End If

    End Sub


End Class