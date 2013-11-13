Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.ALARM, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Close()
    End Sub

    Private Sub Form6_Activated(sender As Object, e As KeyEventArgs) Handles MyBase.Activated
        If (e.KeyCode = Keys.Enter) Then
            Button1.PerformClick()
        End If
    End Sub
End Class