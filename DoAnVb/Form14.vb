Imports DoAnvb.Do_an_QLSVDataSetTableAdapters

Public Class Form14

    Private Sub SinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinhViênToolStripMenuItem.Click
        Dim f As New Form12()
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Visible = True
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub KếtQuảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KếtQuảToolStripMenuItem.Click
        Dim f As New Form13()
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Visible = True
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        Dim f As New Form10()
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f.Visible = True
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim message As String = "Bạn có muốn thoát không?"
        Dim title As String = "Xác nhận!"

        Dim result As DialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Thực hiện hành động khi người dùng chọn Yes
            MessageBox.Show("Chào tạm biệt!", "Thân ái!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Else
            ' Thực hiện hành động khi người dùng chọn No
            MessageBox.Show("Bạn sẽ được chuyển hướng đến trang đăng nhập!", "Thân ái!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
End Class