Public Class Form3

    Private Sub Khoa_Click(sender As Object, e As EventArgs) Handles Khoa.Click
        ' Tạo một biểu mẫu mới
        Dim f As New Form7()
        f.TopLevel = False
        Panel1.Controls.Add(f)
        f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        ' Thêm biểu mẫu vào bảng điều khiển
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub Lop_Click(sender As Object, e As EventArgs) Handles Lop.Click
        Dim f As New Form6()
        f.TopLevel = False
        Panel1.Controls.Add(f)
        f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub Mon_Click(sender As Object, e As EventArgs) Handles Mon.Click
        Dim f As New Form9()
        f.TopLevel = False
        Panel1.Controls.Add(f)
        f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub SinhVien_Click(sender As Object, e As EventArgs) Handles SinhVien.Click
        Dim f As New Form4()
        f.TopLevel = False
        Panel1.Controls.Add(f)
        f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub KetQua_Click(sender As Object, e As EventArgs) Handles KetQua.Click
        Dim f As New Form5()
        f.TopLevel = False
        Panel1.Controls.Add(f)
        f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub TaiKhoan_Click(sender As Object, e As EventArgs) Handles TaiKhoan.Click
        Dim f As New Form15()
        f.TopLevel = False
        Panel1.Controls.Add(f)
        f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub ThongTin_Click(sender As Object, e As EventArgs) Handles ThongTin.Click
        Dim f As New Form10()
        f.TopLevel = False
        Panel1.Controls.Add(f)
        f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        f.Dock = DockStyle.Fill
        f.Show()
        Panel1.Controls.Clear()
        Panel1.Controls.Add(f)
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
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

    Private Sub TrắngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrắngToolStripMenuItem.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub XanhLáCâyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XanhLáCâyToolStripMenuItem.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub ĐỏToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐỏToolStripMenuItem.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub CamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CamToolStripMenuItem.Click
        Me.BackColor = Color.Orange
    End Sub

    Private Sub VàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VàngToolStripMenuItem.Click
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

End Class