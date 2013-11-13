Public Class Form2

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")> Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label1.Text = "Clock Text Color" Then
            Form1.Label1.ForeColor = Color.FromName(TextBox1.Text)
            Close()

        End If
        If Label1.Text = "Date Text Color" Then
            Form1.Label2.ForeColor = Color.FromName(TextBox1.Text)
            Me.Close()
        End If
        If Label1.Text = "Clock Back Color" Then
            Form1.Panel1.BackColor = Color.FromName(TextBox1.Text)
            Me.Close()
        End If
        If Label1.Text = "Form Back Color" Then
            Form1.BackColor = Color.FromName(TextBox1.Text)
            Me.Close()
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Button1.PerformClick()
        End If
    End Sub
End Class