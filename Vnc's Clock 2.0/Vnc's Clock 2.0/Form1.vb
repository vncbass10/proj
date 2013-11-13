Public Class Form1
    Dim i As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
        Label2.Text = Date.Now.Date
        If Label3.Text = "Off" Then
        Else
            If Label1.Text = Label3.Text Then
                form6.show()
            End If
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click

    End Sub
    Dim ccol As String
    Private Sub ClockColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockColorToolStripMenuItem.Click
        Form2.Show()
        Form2.Label1.Text = "Clock Text Color"
    End Sub
    Private Sub ClockBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockBackgroundColorToolStripMenuItem.Click
        Form2.Show()
        Form2.Label1.Text = "Clock Back Color"
    End Sub

    Private Sub DateTextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTextColorToolStripMenuItem.Click
        Form2.Show()
        Form2.Label1.Text = "Date Text Color"
    End Sub

    Private Sub FormBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormBackgroundColorToolStripMenuItem.Click
        Form2.Show()
        Form2.Label1.Text = "Form Back Color"
    End Sub

    Private Sub EnableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableToolStripMenuItem.Click
        Me.SetClientSizeCore(420, 110)
    End Sub

    Private Sub DisableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableToolStripMenuItem.Click
        Me.SetClientSizeCore(245, 110)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetClientSizeCore(245, 110)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Form3.Visible = True Then
            Form3.Close()
        Else
            Form3.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form4.Visible = True Then
            Form4.Close()
        Else
            Form4.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Form5.Visible = True Then
            Form5.Close()
        Else
            Form5.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Start()
        i = 0
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If i > 25 Then

            Me.BackColor.Equals(Color.White)

            Timer2.Stop()

        Else

            Threading.Thread.Sleep(100)

            Me.BackColor = Color.Red

            Threading.Thread.Sleep(100)

            Me.BackColor = Color.Blue

            Threading.Thread.Sleep(100)

            Me.BackColor = Color.Green

            Threading.Thread.Sleep(100)

            Me.BackColor = Color.Yellow

            Threading.Thread.Sleep(100)

            Me.BackColor = Color.Purple

            Threading.Thread.Sleep(100)

            Me.BackColor = Color.White

            Threading.Thread.Sleep(100)

            Me.BackColor = Color.Black

            Threading.Thread.Sleep(100)
            i = i + 1
        End If
    End Sub
End Class
