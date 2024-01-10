Imports System.Data.SqlClient

Public Class Form16

    'Đóng
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    'đổi mk
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

            ' Kết nối đến CSDL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Kiểm tra mật khẩu cũ
                Dim taikhoan As String = tk.Text
                Dim matkhaucu As String = mkcu.Text
                Dim matkhaumoi As String = mkmoi.Text

                Dim query As String = "SELECT Matkhau FROM DangNhap WHERE Taikhoan = @Taikhoan"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Taikhoan", taikhoan)

                    ' Thử lấy mật khẩu từ CSDL
                    Dim doimatkhau As String = DirectCast(cmd.ExecuteScalar(), String)

                    ' So sánh mật khẩu cũ
                    If doimatkhau IsNot Nothing AndAlso doimatkhau = matkhaucu Then
                        ' Cập nhật mật khẩu mới
                        Dim updateQuery As String = "UPDATE DangNhap SET Matkhau = @Matkhaumoi WHERE Taikhoan = @Taikhoan"
                        Using updateCmd As New SqlCommand(updateQuery, connection)
                            updateCmd.Parameters.AddWithValue("@Taikhoan", taikhoan)
                            updateCmd.Parameters.AddWithValue("@Matkhaumoi", matkhaumoi)

                            ' Thực hiện cập nhật mật khẩu mới
                            Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Đổi mật khẩu thành công!")
                                moi()
                            Else
                                MessageBox.Show("Mật khẩu cũ không đúng.")
                                moi()
                            End If
                        End Using
                    Else
                        MessageBox.Show("Tài khoản không tồn tại!")
                        moi()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ẩn hiện password
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            mkcu.PasswordChar = Convert.ToChar(0)
        Else
            mkcu.PasswordChar = Convert.ToChar("●")
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            mkmoi.PasswordChar = Convert.ToChar(0)
        Else
            mkmoi.PasswordChar = Convert.ToChar("●")
        End If
    End Sub

    'làm mới
    Private Sub moi()
        tk.Text = ""
        mkcu.Text = ""
        mkmoi.Text = ""
    End Sub
End Class