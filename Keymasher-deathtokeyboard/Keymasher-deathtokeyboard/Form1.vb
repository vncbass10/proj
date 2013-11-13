Public Class Form1
    Dim i As String
    Dim j As String
    Dim k As String

    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim time As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        a = 0
        b = 0
        c = 0
        time = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If a < 1 Then
            System.Threading.Thread.Sleep(3000)
            time = 1
            a = 1
        End If

        Dim rndnumber As Random
        Dim number, mxnum As Integer
        mxnum = 26
        rndnumber = New Random
        number = rndnumber.Next(0, mxnum)
        If number = 0 Then
            i = "a"
        ElseIf number = 1 Then
            i = "b"
        ElseIf number = 2 Then
            i = "c"
        ElseIf number = 3 Then
            i = "d"
        ElseIf number = 4 Then
            i = "e"
        ElseIf number = 5 Then
            i = "f"
        ElseIf number = 6 Then
            i = "g"
        ElseIf number = 7 Then
            i = "h"
        ElseIf number = 8 Then
            i = "i"
        ElseIf number = 9 Then
            i = "j"
        ElseIf number = 10 Then
            i = "k"
        ElseIf number = 11 Then
            i = "l"
        ElseIf number = 12 Then
            i = "m"
        ElseIf number = 13 Then
            i = "n"
        ElseIf number = 14 Then
            i = "o"
        ElseIf number = 15 Then
            i = "p"
        ElseIf number = 16 Then
            i = "q"
        ElseIf number = 17 Then
            i = "r"
        ElseIf number = 18 Then
            i = "s"
        ElseIf number = 19 Then
            i = "t"
        ElseIf number = 20 Then
            i = "u"
        ElseIf number = 21 Then
            i = "v"
        ElseIf number = 22 Then
            i = "w"
        ElseIf number = 23 Then
            i = "x"
        ElseIf number = 24 Then
            i = "y"
        ElseIf number = 25 Then
            i = "z"
        Else
            MsgBox("26")
        End If
        Label1.Text = (i + j + k)
        If CheckBox1.Checked = True Then
            SendKeys.Send(i)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer3.Start()
        Timer4.Start()
        time = 1
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button1.Enabled = True
            Button2.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Close()
    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        If time = 1 Then
            Timer2.Start()
        End If

    End Sub

    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        If time = 1 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
        Timer3.Start()
        Timer4.Start()
        time = 1
        Me.Hide()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If b < 1 Then
            time = 1
            System.Threading.Thread.Sleep(3000)
            b = 1
        End If

        Dim rnndnumber As Random
        Dim nnumber, mxnnum As Integer
        mxnnum = 26
        rnndnumber = New Random
        nnumber = rnndnumber.Next(0, mxnnum)
        If nnumber = 0 Then
            j = "a"
        ElseIf nnumber = 1 Then
            j = "b"
        ElseIf nnumber = 2 Then
            j = "c"
        ElseIf nnumber = 3 Then
            j = "d"
        ElseIf nnumber = 4 Then
            j = "e"
        ElseIf nnumber = 5 Then
            j = "f"
        ElseIf nnumber = 6 Then
            j = "g"
        ElseIf nnumber = 7 Then
            j = "h"
        ElseIf nnumber = 8 Then
            j = "i"
        ElseIf nnumber = 9 Then
            j = "j"
        ElseIf nnumber = 10 Then
            j = "k"
        ElseIf nnumber = 11 Then
            j = "l"
        ElseIf nnumber = 12 Then
            j = "m"
        ElseIf nnumber = 13 Then
            j = "n"
        ElseIf nnumber = 14 Then
            j = "o"
        ElseIf nnumber = 15 Then
            j = "p"
        ElseIf nnumber = 16 Then
            j = "q"
        ElseIf nnumber = 17 Then
            j = "r"
        ElseIf nnumber = 18 Then
            j = "s"
        ElseIf nnumber = 19 Then
            j = "t"
        ElseIf nnumber = 20 Then
            j = "u"
        ElseIf nnumber = 21 Then
            j = "v"
        ElseIf nnumber = 22 Then
            j = "w"
        ElseIf nnumber = 23 Then
            j = "x"
        ElseIf nnumber = 24 Then
            j = "y"
        ElseIf nnumber = 25 Then
            j = "z"
        Else
            MsgBox("26")
        End If
        Label1.Text = (i + j + k)
        If CheckBox1.Checked = True Then
            SendKeys.Send(j)
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If c < 1 Then
            System.Threading.Thread.Sleep(3000)
            c = 1
            time = 1
        End If

        Dim rrndnumber As Random
        Dim nuumber, mxxnum As Integer
        mxxnum = 26
        rrndnumber = New Random
        nuumber = rrndnumber.Next(0, mxxnum)
        If nuumber = 0 Then
            k = "a"
        ElseIf nuumber = 1 Then
            k = "b"
        ElseIf nuumber = 2 Then
            k = "c"
        ElseIf nuumber = 3 Then
            k = "d"
        ElseIf nuumber = 4 Then
            k = "e"
        ElseIf nuumber = 5 Then
            k = "f"
        ElseIf nuumber = 6 Then
            k = "g"
        ElseIf nuumber = 7 Then
            k = "h"
        ElseIf nuumber = 8 Then
            k = "i"
        ElseIf nuumber = 9 Then
            k = "j"
        ElseIf nuumber = 10 Then
            k = "k"
        ElseIf nuumber = 11 Then
            k = "l"
        ElseIf nuumber = 12 Then
            k = "m"
        ElseIf nuumber = 13 Then
            k = "n"
        ElseIf nuumber = 14 Then
            k = "o"
        ElseIf nuumber = 15 Then
            k = "p"
        ElseIf nuumber = 16 Then
            k = "q"
        ElseIf nuumber = 17 Then
            k = "r"
        ElseIf nuumber = 18 Then
            k = "s"
        ElseIf nuumber = 19 Then
            k = "t"
        ElseIf nuumber = 20 Then
            k = "u"
        ElseIf nuumber = 21 Then
            k = "v"
        ElseIf nuumber = 22 Then
            k = "w"
        ElseIf nuumber = 23 Then
            k = "x"
        ElseIf nuumber = 24 Then
            k = "y"
        ElseIf nuumber = 25 Then
            k = "z"
        Else
            MsgBox("26")
        End If
        Label1.Text = (i + j + k)
        If CheckBox1.Checked = True Then
            SendKeys.Send(k)
        End If
    End Sub

    Private Sub Form1_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        If time = 1 Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        If time = 1 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If time = 1 Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        If time = 1 Then
            Timer2.Stop()
        End If
    End Sub
End Class
