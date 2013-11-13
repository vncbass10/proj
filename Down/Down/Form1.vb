Public Class Form1
    Dim i As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        SendKeys.Send("{Down}")
        SendKeys.Send("{Backspace}")
        SendKeys.Send(i)
        i = i + 1
        If i = 111 Then
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
End Class
