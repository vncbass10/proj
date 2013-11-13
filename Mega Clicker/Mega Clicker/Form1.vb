
Public Class Form1
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4

    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Label1.Text = Label1.Text + 1
        If Label1.Text = TextBox1.Text Then
            Timer1.Stop()
            Label1.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Label1.Text = 0
    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        If Timer1.Enabled = True Then
            Close()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Start()
        Timer2.Stop()
    End Sub
End Class
