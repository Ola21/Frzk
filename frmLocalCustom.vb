Public Class frmLocalCustom
    Dim dt As Date = Date.Now

    Dim dthr As Date = dt.AddSeconds(5)


    Public Sub frmLocalCustom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TimerCountDown.Enabled = True



        Dim dt As Date = Date.Now

        Dim dthr As Date = dt.AddSeconds(5)


        MessageBox.Show("" + dt)
        MessageBox.Show("" + dthr)



        TimerCountDown.Start()





    End Sub

    Public Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles TimerCountDown.Tick
        If dt = dthr Then
            MessageBox.Show("time over")


        End If
    End Sub
End Class