Public Class Enchantments

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedIndex.Equals(0) Then
            MsgBox("Sharpness = ")
        End If
        If ListBox1.SelectedIndex.Equals(1) Then
            MsgBox("Knockback = ")
        End If
        If ListBox1.SelectedIndex.Equals(2) Then
            MsgBox("Bane Of Arthopods = ")
        End If
        If ListBox1.SelectedIndex.Equals(3) Then
            MsgBox("Unbreaking = ")
        End If
        If ListBox1.SelectedIndex.Equals(4) Then
            MsgBox("Fire Aspect = ")
        End If
        If ListBox1.SelectedIndex.Equals(5) Then
            MsgBox("Looting = ")
        End If
    End Sub
    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        If ListBox2.SelectedIndex.Equals(0) Then
            MsgBox("Power = ")
        End If
        If ListBox2.SelectedIndex.Equals(1) Then
            MsgBox("Punch = ")
        End If
        If ListBox2.SelectedIndex.Equals(2) Then
            MsgBox("Unbreaking = ")
        End If
        If ListBox2.SelectedIndex.Equals(3) Then
            MsgBox("Flame = ")
        End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Me.Hide()
        Recipes.Show()
    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click
        Form1.Close()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyPressed As Keys = CType(msg.WParam.ToInt32(), Keys)
        If keyPressed = Keys.Up Then
            ToolStripStatusLabel1.PerformClick()
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

End Class