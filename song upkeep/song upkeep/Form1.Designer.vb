<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetUploadFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetToUploadFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ConstantUpkeepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetUploadFolderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetToUploadFolderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(578, 360)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(570, 334)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "To Add"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(564, 328)
        Me.ListBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(570, 334)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Just Added"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(3, 3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(564, 328)
        Me.ListBox2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(570, 334)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Already In"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(0, 0)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(570, 334)
        Me.ListBox3.TabIndex = 1
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'SetUploadFolderToolStripMenuItem
        '
        Me.SetUploadFolderToolStripMenuItem.Name = "SetUploadFolderToolStripMenuItem"
        Me.SetUploadFolderToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'SetToUploadFolderToolStripMenuItem
        '
        Me.SetToUploadFolderToolStripMenuItem.Name = "SetToUploadFolderToolStripMenuItem"
        Me.SetToUploadFolderToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'ConstantUpkeepToolStripMenuItem
        '
        Me.ConstantUpkeepToolStripMenuItem.Name = "ConstantUpkeepToolStripMenuItem"
        Me.ConstantUpkeepToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'UploadToolStripMenuItem1
        '
        Me.UploadToolStripMenuItem1.Name = "UploadToolStripMenuItem1"
        Me.UploadToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        '
        'SetUploadFolderToolStripMenuItem1
        '
        Me.SetUploadFolderToolStripMenuItem1.Name = "SetUploadFolderToolStripMenuItem1"
        Me.SetUploadFolderToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        '
        'SetToUploadFolderToolStripMenuItem1
        '
        Me.SetToUploadFolderToolStripMenuItem1.Name = "SetToUploadFolderToolStripMenuItem1"
        Me.SetToUploadFolderToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(0, 0)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripSeparator6, Me.ToolStripLabel2, Me.ToolStripSeparator7, Me.ToolStripLabel3, Me.ToolStripSeparator8, Me.ToolStripComboBox1, Me.ToolStripSeparator9, Me.ToolStripLabel4, Me.ToolStripSeparator10})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.MaximumSize = New System.Drawing.Size(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(580, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel1.Text = "Upload"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel2.Text = "Set Upload Folder"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripLabel3.Text = "Set To Upload Folder"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Automatic", "Manual"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ToolStripComboBox1.Text = "Manual"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel4.Text = "Settings"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 6)
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 362)
        Me.Panel1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 387)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Vnc's File Upkeep"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents SetToUploadFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents UploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetUploadFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConstantUpkeepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetUploadFolderToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetToUploadFolderToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator

End Class
