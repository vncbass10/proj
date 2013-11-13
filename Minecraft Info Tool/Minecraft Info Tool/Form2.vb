Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Me.Hide()
        Recipes.Show()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Me.Hide()
        Enchantments.Show()

    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click
        Form1.Close()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyPressed As Keys = CType(msg.WParam.ToInt32(), Keys)
        If keyPressed = Keys.Up Then
            ToolStripStatusLabel1.PerformClick()
            Return True
        ElseIf keyPressed = Keys.Right And ToolStripStatusLabel6.Text = 0 Then
            ToolStripStatusLabel6.Text = 1
            PictureBox1.Image = My.Resources.Capture1
            Return True
        ElseIf keyPressed = Keys.Right And ToolStripStatusLabel6.Text = 1 Then
            ToolStripStatusLabel6.Text = 2
            PictureBox1.Image = My.Resources.Capture2
            Return True
        ElseIf keyPressed = Keys.Right And ToolStripStatusLabel6.Text = 2 Then
            ToolStripStatusLabel6.Text = 3
            PictureBox1.Image = My.Resources.Capture3
            Me.Size = PictureBox1.Size
            Return True
        ElseIf keyPressed = Keys.Right And ToolStripStatusLabel6.Text = 3 Then
            MsgBox("Thats It, Use Left Arrow Key To Go Back")
            Return True
        ElseIf keyPressed = Keys.Left And ToolStripStatusLabel6.Text = 0 Then
            MsgBox("Thats It, Use Right Arrow Key To Go Back")
            Return True
        ElseIf keyPressed = Keys.Left And ToolStripStatusLabel6.Text = 1 Then
            ToolStripStatusLabel6.Text = 0
            PictureBox1.Image = My.Resources.Capture
            Return True
        ElseIf keyPressed = Keys.Left And ToolStripStatusLabel6.Text = 2 Then
            ToolStripStatusLabel6.Text = 1
            PictureBox1.Image = My.Resources.Capture1
            Return True
        ElseIf keyPressed = Keys.Left And ToolStripStatusLabel6.Text = 3 Then
            ToolStripStatusLabel6.Text = 2
            PictureBox1.Image = My.Resources.Capture2
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel5.Click
        MsgBox("Use Left/Right Arrow Keys")

    End Sub
End Class