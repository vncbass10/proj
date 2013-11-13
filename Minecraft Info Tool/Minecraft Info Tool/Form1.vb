Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        MsgBox("If you have any Questions Please send me an Email at 'Vncbass10@gmail.com' with the subject of 'Minecraft info Help'")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Enchantments.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Recipes.Show()

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyPressed As Keys = CType(msg.WParam.ToInt32(), Keys)
        If keyPressed = Keys.NumPad1 Then
            Button1.PerformClick()
            Return True
        elseIf keyPressed = Keys.NumPad2 Then
                Button2.PerformClick()
                Return True
        ElseIf keyPressed = Keys.NumPad3 Then
            Button3.PerformClick()
            Return True
        ElseIf keyPressed = Keys.NumPad4 Then
            Button4.PerformClick()
            Return True
        ElseIf keyPressed = Keys.Down Then
            Close()
            Return True
            Else
                Return MyBase.ProcessCmdKey(msg, keyData)
            End If
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Enchant_Id_s.Show()

    End Sub
End Class
