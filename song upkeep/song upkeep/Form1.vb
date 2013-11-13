Public Class Form1
    Dim lb3c As Integer
    Dim ftr As String
    Dim uf As String
    Dim au As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb3c = ListBox3.Items.Count
        ftr = My.Settings.ftr
        uf = My.Settings.uf
        au = My.Settings.au
        If ftr = "C:/" Then
        Else
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(ftr)
                ListBox1.Items.Add(foundFile)
            Next
        End If
        If uf = "C:/" Then
        Else
            For Each fiundFile As String In My.Computer.FileSystem.GetFiles(uf)
                ListBox3.Items.Add(fiundFile)
            Next
        End If
        'If au = "Y" Then
        '    ToolStripComboBox1.Text = "Automatic"
        '    Timer1.Start()
        'Else

        'End If
    End Sub


    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        ListBox2.Items.Clear()
        For Each copyFile As String In My.Computer.FileSystem.GetFiles(ftr)
            Dim cf As String
            On Error Resume Next
            cf = uf + copyFile.Replace(ftr, "")
            On Error Resume Next
            My.Computer.FileSystem.CopyFile(copyFile, cf)

            ListBox2.Items.Add(copyFile)
        Next
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        FolderBrowserDialog1.ShowDialog()
        ListBox3.Items.Clear()
        On Error Resume Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath)
            On Error Resume Next
            If foundFile.ToString = "" Then
            Else
                ListBox3.Items.Add(foundFile)
            End If
        Next
        uf = FolderBrowserDialog1.SelectedPath.ToString

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        FolderBrowserDialog1.ShowDialog()
        ListBox1.Items.Clear()
        On Error Resume Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath)
            On Error Resume Next
            If foundFile.ToString = "" Then
            Else
                ListBox1.Items.Add(foundFile)
            End If
        Next
        ftr = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub ToolStripLabel1_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStripLabel1.MouseDown
        ToolStripLabel1.ForeColor = Color.White
    End Sub

    Private Sub ToolStripLabel1_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripLabel1.MouseUp
        ToolStripLabel1.ForeColor = Color.Black
    End Sub

    Private Sub ToolStripLabel2_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStripLabel2.MouseDown
        ToolStripLabel2.ForeColor = Color.White
    End Sub

    Private Sub ToolStripLabel2_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripLabel2.MouseUp
        ToolStripLabel2.ForeColor = Color.Black
    End Sub

    Private Sub ToolStripLabel3_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStripLabel3.MouseDown
        ToolStripLabel3.ForeColor = Color.White
    End Sub

    Private Sub ToolStripLabel3_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripLabel3.MouseUp
        ToolStripLabel3.ForeColor = Color.Black
    End Sub
    Private Sub ToolStripLabel4_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStripLabel4.MouseDown
        ToolStripLabel4.ForeColor = Color.White
    End Sub

    Private Sub ToolStripLabel4_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripLabel4.MouseUp
        ToolStripLabel4.ForeColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripLabel1.PerformClick()
        ListBox1.Items.Clear()
        ListBox3.Items.Clear()
        On Error Resume Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(ftr)
            On Error Resume Next
            If foundFile.ToString = "" Then
            Else
                ListBox1.Items.Add(foundFile)
            End If
        Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(uf)
            On Error Resume Next
            If foundFile.ToString = "" Then
                On Error Resume Next
            Else
                ListBox3.Items.Add(foundFile)
            End If
        Next
    End Sub

    Private Sub ToolStripComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.TextChanged
        If ToolStripComboBox1.Text = "Automatic" Then
            MsgBox("Make Sure You Set Up Your Folders Before Hand, Did You Do This Yet?", MsgBoxStyle.YesNo)
            If MsgBoxResult.Yes Then
                Timer1.Start()
            Else

            End If
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub ListBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox2.KeyDown
        If e.KeyCode = Keys.Delete Then
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        ListBox1.Items.Clear()
        ListBox3.Items.Clear()
        If ftr = "C:/" Then
        Else
            On Error Resume Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(ftr)
                On Error Resume Next
                ListBox1.Items.Add(foundFile)
            Next
        End If
        If uf = "C:/" Then
        Else
            On Error Resume Next
            For Each fiundFile As String In My.Computer.FileSystem.GetFiles(uf)
                On Error Resume Next
                ListBox3.Items.Add(fiundFile)
            Next
        End If
        ' If au = "Y" Then
        'ToolStripComboBox1.Text = "Automatic"
        '    Timer1.Start()
        '  Else
        ' End If
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        MsgBox("Update Worked")
    End Sub
End Class
