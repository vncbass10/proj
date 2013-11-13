Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            w1.Enabled = True
            w2.Enabled = True
        Else
            CheckBox2.Enabled = True
            w1.Enabled = False
            w2.Enabled = False
            w1.Checked = False
            w2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            a1.Enabled = True
            a2.Enabled = True
            a3.Enabled = True
            a4.Enabled = True
        Else
            CheckBox1.Enabled = True
            a1.Enabled = False
            a2.Enabled = False
            a3.Enabled = False
            a4.Enabled = False
            a1.Checked = False
            a2.Checked = False
            a3.Checked = False
            a4.Checked = False
        End If
    End Sub

    Private Sub w1_CheckedChanged(sender As Object, e As EventArgs) Handles w1.CheckedChanged
        If w1.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Stonesword 1" + " "
            CheckBox1.Enabled = False
            w2.Enabled = False
            we1.Enabled = True
            we2.Enabled = True
            we3.Enabled = True
            we4.Enabled = True
            we5.Enabled = True
            we6.Enabled = True
        Else
            TextBox1.Text = ""
            CheckBox1.Enabled = True
            w2.Enabled = True
            we1.Enabled = False
            we2.Enabled = False
            we3.Enabled = False
            we4.Enabled = False
            we5.Enabled = False
            we6.Enabled = False
            we1.Checked = False
            we2.Checked = False
            we3.Checked = False
            we4.Checked = False
            we5.Checked = False
            we6.Checked = False
        End If
    End Sub

    Private Sub w2_CheckedChanged(sender As Object, e As EventArgs) Handles w2.CheckedChanged
        If w2.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Bow 1" + " "
            CheckBox1.Enabled = False
            w1.Enabled = False
            we7.Enabled = True
            we9.Enabled = True
            we10.Enabled = True
            we11.Enabled = True
            we12.Enabled = True
        Else
            TextBox1.Text = ""
            CheckBox1.Enabled = True
            w1.Enabled = True
            we7.Enabled = False
            we9.Enabled = False
            we10.Enabled = False
            we11.Enabled = False
            we12.Enabled = False
            we7.Checked = False
            we9.Checked = False
            we10.Checked = False
            we11.Checked = False
            we12.Checked = False
        End If

    End Sub

    Private Sub a1_CheckedChanged(sender As Object, e As EventArgs) Handles a1.CheckedChanged
        If a1.Checked = True Then
            TextBox1.Text = TextBox1.Text + "leatherchestplate 1" + " "
            CheckBox2.Enabled = False
            a2.Enabled = False
            a3.Enabled = False
            a4.Enabled = False
            a2.Checked = False
            a3.Checked = False
            a4.Checked = False
            ae1.Enabled = True
            ae2.Enabled = True
            ae3.Enabled = True
            ae4.Enabled = True
            ae5.Enabled = True
            ae6.Enabled = True
        Else
            TextBox1.Text = ""
            CheckBox2.Enabled = True
            a2.Enabled = True
            a3.Enabled = True
            a4.Enabled = True
            ae1.Enabled = False
            ae2.Enabled = False
            ae3.Enabled = False
            ae4.Enabled = False
            ae5.Enabled = False
            ae6.Enabled = False
            ae1.Checked = False
            ae2.Checked = False
            ae3.Checked = False
            ae4.Checked = False
            ae5.Checked = False
            ae6.Checked = False
        End If
    End Sub

    Private Sub a2_CheckedChanged(sender As Object, e As EventArgs) Handles a2.CheckedChanged
        If a2.Checked = True Then
            TextBox1.Text = TextBox1.Text + "leatherLeggings 1" + " "
            CheckBox2.Enabled = False
            a1.Enabled = False
            a3.Enabled = False
            a4.Enabled = False
            a1.Checked = False
            a3.Checked = False
            a4.Checked = False
            ae1.Enabled = True
            ae2.Enabled = True
            ae3.Enabled = True
            ae4.Enabled = True
            ae5.Enabled = True
            ae6.Enabled = True
        Else
            TextBox1.Text = ""
            CheckBox2.Enabled = True
            a1.Enabled = True
            a3.Enabled = True
            a4.Enabled = True
            ae1.Enabled = False
            ae2.Enabled = False
            ae3.Enabled = False
            ae4.Enabled = False
            ae5.Enabled = False
            ae6.Enabled = False
            ae1.Checked = False
            ae2.Checked = False
            ae3.Checked = False
            ae4.Checked = False
            ae5.Checked = False
            ae6.Checked = False
        End If
    End Sub

    Private Sub a3_CheckedChanged(sender As Object, e As EventArgs) Handles a3.CheckedChanged
        If a3.Checked = True Then
            TextBox1.Text = TextBox1.Text + "leatherBoots 1" + " "
            CheckBox2.Enabled = False
            a1.Enabled = False
            a2.Enabled = False
            a4.Enabled = False
            a1.Checked = False
            a2.Checked = False
            a4.Checked = False
            ae1.Enabled = True
            ae2.Enabled = True
            ae3.Enabled = True
            ae4.Enabled = True
            ae5.Enabled = True
            ae6.Enabled = True
            ae7.Enabled = True
        Else
            TextBox1.Text = ""
            CheckBox2.Enabled = True
            a1.Enabled = True
            a2.Enabled = True
            a4.Enabled = True
            ae1.Enabled = False
            ae2.Enabled = False
            ae3.Enabled = False
            ae4.Enabled = False
            ae5.Enabled = False
            ae6.Enabled = False
            ae7.Enabled = False
            ae1.Checked = False
            ae2.Checked = False
            ae3.Checked = False
            ae4.Checked = False
            ae5.Checked = False
            ae6.Checked = False
            ae7.Checked = False
        End If
    End Sub

    Private Sub a4_CheckedChanged(sender As Object, e As EventArgs) Handles a4.CheckedChanged
        If a4.Checked = True Then
            TextBox1.Text = TextBox1.Text + "leatherhelmet 1" + " "
            CheckBox2.Enabled = False
            a1.Enabled = False
            a3.Enabled = False
            a2.Enabled = False
            a1.Checked = False
            a3.Checked = False
            a2.Checked = False
            ae1.Enabled = True
            ae2.Enabled = True
            ae3.Enabled = True
            ae4.Enabled = True
            ae5.Enabled = True
            ae6.Enabled = True
        Else
            TextBox1.Text = ""
            CheckBox2.Enabled = True
            a1.Enabled = True
            a3.Enabled = True
            a2.Enabled = True
            ae1.Enabled = False
            ae2.Enabled = False
            ae3.Enabled = False
            ae4.Enabled = False
            ae5.Enabled = False
            ae6.Enabled = False
            ae1.Checked = False
            ae2.Checked = False
            ae3.Checked = False
            ae4.Checked = False
            ae5.Checked = False
            ae6.Checked = False
        End If
    End Sub

    Private Sub ae4_CheckedChanged(sender As Object, e As EventArgs) Handles ae4.CheckedChanged
        If ae4.Checked = True Then
            ae1.Enabled = False
            ae2.Enabled = False
            ae3.Enabled = False
        ElseIf ae4.Enabled = True Then
            ae1.Enabled = True
            ae2.Enabled = True
            ae3.Enabled = True
        End If
        If ae4.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Protection" + " "
        ElseIf TextBox1.Text.Count > 11 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 11)
        End If
    End Sub

    Private Sub ae3_CheckedChanged(sender As Object, e As EventArgs) Handles ae3.CheckedChanged
        If ae3.Checked = True Then
            ae1.Enabled = False
            ae2.Enabled = False
            ae4.Enabled = False
        ElseIf ae3.Enabled = True Then
            ae1.Enabled = True
            ae2.Enabled = True
            ae4.Enabled = True
        End If
        If ae3.Checked = True Then
            TextBox1.Text = TextBox1.Text + "BlastProtection" + " "
        ElseIf TextBox1.Text.Count > 16 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 16)
        End If
    End Sub

    Private Sub ae2_CheckedChanged(sender As Object, e As EventArgs) Handles ae2.CheckedChanged
        If ae2.Checked = True Then
            ae1.Enabled = False
            ae4.Enabled = False
            ae3.Enabled = False
        ElseIf ae2.Enabled = True Then
            ae1.Enabled = True
            ae4.Enabled = True
            ae3.Enabled = True
        End If
        If ae2.Checked = True Then
            TextBox1.Text = TextBox1.Text + "ProjectileProtection" + " "
        ElseIf TextBox1.Text.Count > 21 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 21)
        End If
    End Sub

    Private Sub ae1_CheckedChanged(sender As Object, e As EventArgs) Handles ae1.CheckedChanged
        If ae1.Checked = True Then
            ae4.Enabled = False
            ae2.Enabled = False
            ae3.Enabled = False
        ElseIf ae1.Enabled = True Then
            ae4.Enabled = True
            ae2.Enabled = True
            ae3.Enabled = True
        End If
        If ae1.Checked = True Then
            TextBox1.Text = TextBox1.Text + "FireProtection" + " "
        ElseIf TextBox1.Text.Count > 15 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 15)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        ae1.Enabled = False
        ae2.Enabled = False
        ae3.Enabled = False
        ae4.Enabled = False
        ae5.Enabled = False
        ae6.Enabled = False
        ae7.Enabled = False

        ae1.Checked = False
        ae2.Checked = False
        ae3.Checked = False
        ae4.Checked = False
        ae5.Checked = False
        ae6.Checked = False
        ae7.Checked = False

        we1.Enabled = False
        we2.Enabled = False
        we3.Enabled = False
        we4.Enabled = False
        we5.Enabled = False
        we6.Enabled = False
        we7.Enabled = False
        we9.Enabled = False
        we10.Enabled = False
        we11.Enabled = False
        we12.Enabled = False

        we1.Checked = False
        we2.Checked = False
        we3.Checked = False
        we4.Checked = False
        we5.Checked = False
        we6.Checked = False
        we7.Checked = False
        we9.Checked = False
        we10.Checked = False
        we11.Checked = False
        we12.Checked = False

        a1.Checked = False
        a2.Checked = False
        a3.Checked = False
        a4.Checked = False

        a1.Enabled = False
        a2.Enabled = False
        a3.Enabled = False
        a4.Enabled = False

        w1.Checked = False
        w2.Checked = False

        w1.Enabled = False
        w2.Enabled = False

        TextBox1.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.start()
        i = 0
    End Sub
    Dim i As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i = 0 And ListBox1.Items.Count <> 0 Then
            i = 0
            System.Threading.Thread.Sleep(2000)
        End If

        If ListBox1.Items.Count <> 0 Then
            SendKeys.Send("/")
            System.Threading.Thread.Sleep(50)
            SendKeys.Send("i ")
            System.Threading.Thread.Sleep(50)
            SendKeys.Send(ListBox1.Items.Item(i))
            System.Threading.Thread.Sleep(50)
            SendKeys.Send("{Enter}")
            System.Threading.Thread.Sleep(50)
            i = i + 1
        End If
        If ListBox1.Items.Count = i Then
            i = 0
            Timer1.Stop()
        End If
    End Sub

    Private Sub we1_CheckedChanged(sender As Object, e As EventArgs) Handles we1.CheckedChanged
        If we1.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Fire" + " "
        ElseIf TextBox1.Text.Count > 5 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 5)
        End If

    End Sub

    Private Sub we2_CheckedChanged(sender As Object, e As EventArgs) Handles we2.CheckedChanged
        If we2.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Sharpness" + " "
        ElseIf TextBox1.Text.Count > 10 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 10)
        End If
    End Sub

    Private Sub we3_CheckedChanged(sender As Object, e As EventArgs) Handles we3.CheckedChanged
        If we3.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Smite" + " "
        ElseIf TextBox1.Text.Count > 6 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 6)
        End If
    End Sub

    Private Sub we4_CheckedChanged(sender As Object, e As EventArgs) Handles we4.CheckedChanged
        If we4.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Looting" + " "
        ElseIf TextBox1.Text.Count > 8 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 8)
        End If
    End Sub

    Private Sub we5_CheckedChanged(sender As Object, e As EventArgs) Handles we5.CheckedChanged
        If we5.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Knockback" + " "
        ElseIf TextBox1.Text.Count > 10 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 10)
        End If
    End Sub

    Private Sub we6_CheckedChanged(sender As Object, e As EventArgs) Handles we6.CheckedChanged
        If we6.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Unbreaking" + " "
        ElseIf TextBox1.Text.Count > 11 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 11)
        End If
    End Sub

    Private Sub we7_CheckedChanged(sender As Object, e As EventArgs) Handles we7.CheckedChanged
        If we7.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Flame" + " "
        ElseIf TextBox1.Text.Count > 6 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 6)
        End If
    End Sub

    Private Sub we9_CheckedChanged(sender As Object, e As EventArgs) Handles we9.CheckedChanged
        If we9.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Punch" + " "
        ElseIf TextBox1.Text.Count > 6 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 6)
        End If
    End Sub

    Private Sub we10_CheckedChanged(sender As Object, e As EventArgs) Handles we10.CheckedChanged
        If we10.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Power" + " "
        ElseIf TextBox1.Text.Count > 6 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 6)
        End If
    End Sub

    Private Sub we11_CheckedChanged(sender As Object, e As EventArgs) Handles we11.CheckedChanged
        If we11.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Infinity" + " "
        ElseIf TextBox1.Text.Count > 9 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 9)
        End If
    End Sub

    Private Sub we12_CheckedChanged(sender As Object, e As EventArgs) Handles we12.CheckedChanged
        If we12.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Unbreaking" + " "
        ElseIf TextBox1.Text.Count > 11 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 11)
        End If
    End Sub

    Private Sub ae5_CheckedChanged(sender As Object, e As EventArgs) Handles ae5.CheckedChanged
        If ae5.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Thorns" + " "
        ElseIf TextBox1.Text.Count > 7 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 7)
        End If
    End Sub

    Private Sub ae6_CheckedChanged(sender As Object, e As EventArgs) Handles ae6.CheckedChanged
        If ae6.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Unbreaking" + " "
        ElseIf TextBox1.Text.Count > 11 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 11)
        End If
    End Sub

    Private Sub ae7_CheckedChanged(sender As Object, e As EventArgs) Handles ae7.CheckedChanged
        If ae7.Checked = True Then
            TextBox1.Text = TextBox1.Text + "Featherfalling" + " "
        ElseIf TextBox1.Text.Count > 15 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Count - 15)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add("Stonesword 1 Sharpness Smite Fire Looting Knockback Unbreaking")
        ListBox1.Items.Add("Bow 1 Power Punch Flame Infinity Unbreaking")
        ListBox1.Items.Add("Leatherchestplate 1 Protection Thorns Unbreaking")
        ListBox1.Items.Add("Leatherboots 1 Protection Thorns Unbreaking Featherfalling")
        ListBox1.Items.Add("Leatherleggings 1 fireProtection Thorns Unbreaking")
        ListBox1.Items.Add("Leatherhelmet 1 projectileProtection Thorns Unbreaking")


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
        End If
    End Sub

    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick
        Button3.PerformClick()
    End Sub

    Private Sub Label1_MouseClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseClick
        ListBox1.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Select()
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
    End Sub
End Class
