Public Class FuckYou

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub FuckYou_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        My.Computer.Audio.Play(My.Resources.stupid_CUT, AudioPlayMode.Background)
    End Sub
End Class