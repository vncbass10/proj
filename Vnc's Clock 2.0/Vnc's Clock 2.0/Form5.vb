Public Class Form5
    Dim i As String
    Dim j As String
    Dim jj As String
    Dim jjj As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            j = "12"
        Else
            j = TextBox1.Text
        End If

        If TextBox2.Text = "" Then
            jj = "00"
        Else
            jj = TextBox2.Text
        End If

        If TextBox3.Text = "" Then
            jjj = "00"
        Else
            jjj = TextBox3.Text
        End If

        Form1.Label3.Text = j + ":" + jj + ":" + jjj + " " + i
        Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            i = "AM"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            i = "PM"
        End If
    End Sub


    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Button1.PerformClick()
        End If
    End Sub

End Class