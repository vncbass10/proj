Public Class Form4

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ProgressBar1.Maximum = TextBox1.Text
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button8.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            My.Computer.Audio.Play(My.Resources.beep_9, AudioPlayMode.WaitToComplete)
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If

        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Stop()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Timer1.Stop()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button8.Enabled = True
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            My.Computer.Audio.Play(My.Resources.beep_9, AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Value = ProgressBar1.Value + 10
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            My.Computer.Audio.Play(My.Resources.beep_9, AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProgressBar1.Value = ProgressBar1.Value + 100
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            My.Computer.Audio.Play(My.Resources.beep_9, AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ProgressBar1.Value = ProgressBar1.Value + 1000
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            My.Computer.Audio.Play(My.Resources.beep_9, AudioPlayMode.WaitToComplete)
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = ProgressBar1.Value

        If ProgressBar1.Maximum < Label1.Text + 1 Then
            Button1.Enabled = False
        End If
        If ProgressBar1.Maximum < Label1.Text + 10 Then
            Button2.Enabled = False
        End If
        If ProgressBar1.Maximum < Label1.Text + 100 Then
            Button3.Enabled = False
        End If

        If ProgressBar1.Maximum < Label1.Text + 1000 Then
            Button8.Enabled = False
        End If

        If ProgressBar1.Maximum > Label1.Text + 1 Then
            Button1.Enabled = True
        End If

        If ProgressBar1.Maximum > Label1.Text + 10 Then
            Button2.Enabled = True
        End If

        If ProgressBar1.Maximum > Label1.Text + 100 Then
            Button3.Enabled = True
        End If

        If ProgressBar1.Maximum > Label1.Text + 1000 Then
            Button8.Enabled = True
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum - 1 Then
            Timer1.Stop()

        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Button6.PerformClick()
        End If
    End Sub
End Class