Public Class Enchant_Id_s

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyPressed As Keys = CType(msg.WParam.ToInt32(), Keys)
        If keyPressed = Keys.Up Then
            ToolStripStatusLabel1.PerformClick()
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Form1.Close()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class