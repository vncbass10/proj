Public Class Recipes

    Private Sub Recipes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Me.Hide()
        Enchantments.Show()
    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click
        Form1.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Axe" Or TextBox1.Text = "axe" Or TextBox1.Text = "Diamond Axe" Or TextBox1.Text = "Iron Axe" Or TextBox1.Text = "Gold Axe" Or TextBox1.Text = "Wooden Axe" Then
            PictureBox1.Image = My.Resources.axes_crafting
            PictureBox2.Image = My.Resources.hatchetDiamond
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
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