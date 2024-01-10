Imports System.Data.SqlClient
Public Class Form2

    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' Đăng ký
    Private Sub Dangky_Click(sender As Object, e As EventArgs) Handles Dangky.Click
        Dim Gmail As String = dkygmail.Text
        Dim Taikhoan As String = dkytk.Text
        Dim Matkhau As String = dkymk.Text
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(Gmail) Or String.IsNullOrEmpty(Taikhoan) Or String.IsNullOrEmpty(Matkhau) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Kiểm tra xem Gmail đã tồn tại hay chưa
                Dim selectGmailQuery As String = "SELECT COUNT(*) FROM Dangnhap WHERE Gmail = @Gmail"
                Using selectGmailCommand As New SqlCommand(selectGmailQuery, connection)
                    selectGmailCommand.Parameters.AddWithValue("@Gmail", Gmail)
                    Dim count As Integer = Convert.ToInt32(selectGmailCommand.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Vui lòng sử dụng địa chỉ Gmail khác!", "Địa chỉ Gmail đã tồn tại!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ClearForm()
                        Return
                    End If
                End Using

                ' Kiểm tra xem người dùng đã tồn tại hay chưa
                Dim selectQuery As String = "SELECT COUNT(*) FROM Dangnhap WHERE Taikhoan = @Taikhoan"
                Using selectCommand As New SqlCommand(selectQuery, connection)
                    selectCommand.Parameters.AddWithValue("@Taikhoan", Taikhoan)
                    Dim count As Integer = Convert.ToInt32(selectCommand.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Vui lòng sử dụng tài khoản khác!", "Tài khoản đã tồn tại!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ClearForm()
                        Return
                    End If
                End Using

                ' Thêm người dùng mới vào cơ sở dữ liệu
                Dim insertQuery As String = "INSERT INTO Dangnhap (Gmail, Taikhoan, Matkhau, Vaitro) VALUES (@Gmail, @Taikhoan, @Matkhau, @Vaitro)"
                Using insertCommand As New SqlCommand(insertQuery, connection)
                    insertCommand.Parameters.AddWithValue("@Gmail", Gmail)
                    insertCommand.Parameters.AddWithValue("@Taikhoan", Taikhoan)
                    insertCommand.Parameters.AddWithValue("@Matkhau", Matkhau)
                    insertCommand.Parameters.AddWithValue("@Vaitro", "MEMBER")
                    insertCommand.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Đăng ký thành công!")
            ClearForm()
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm() ' xóa
        dkygmail.Text = ""
        dkytk.Text = ""
        dkymk.Text = ""
        dkygmail.Focus()
    End Sub

    ' Thoát
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

End Class