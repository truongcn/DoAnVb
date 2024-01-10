Imports System.Data.SqlClient
Imports System.Net

Public Class Form15
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' { Hiển thị thông tin sinh viên trên datagridview
    Private Sub Form2_Load()
        Dim query As String = "SELECT * FROM DangNhap"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2_Load()
    End Sub '}

    ' { Thêm 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themgmail.Text) Or String.IsNullOrEmpty(themtk.Text) Or
           String.IsNullOrEmpty(themmk.Text) Or String.IsNullOrEmpty(themvt.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Kiểm tra Tài khoản tồn tại
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Tài khoản không tồn tại, thực hiện truy vấn chèn dữ liệu
                Dim query As String = "INSERT INTO DangNhap (Email, Taikhoan, Matkhau, Vaitro) 
                               VALUES (@Email, @Taikhoan, @Matkhau, @Vaitro)"

                ' Tạo đối tượng Command và thiết lập các tham số
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Email", themgmail.Text)
                    command.Parameters.AddWithValue("@Taikhoan", themtk.Text)
                    command.Parameters.AddWithValue("@Matkhau", themmk.Text)
                    command.Parameters.AddWithValue("@Vaitro", themvt.Text)

                    ' Thực thi truy vấn
                    command.ExecuteNonQuery()

                    ' Đóng kết nối
                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo thành công
            MsgBox("Thêm thành công!")
            Form2_Load()
            trong()
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Sửa
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' Kiểm tra xem có ít nhất một dòng được chọn
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            ' Truyền dữ liệu từ DataGridView vào các TextBox
            themgmail.Text = selectedRow.Cells("Email").Value.ToString()
            themtk.Text = selectedRow.Cells("Taikhoan").Value.ToString()
            themmk.Text = selectedRow.Cells("Matkhau").Value.ToString()
            themvt.Text = selectedRow.Cells("Vaitro").Value.ToString()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themgmail.Text) Or String.IsNullOrEmpty(themtk.Text) Or
           String.IsNullOrEmpty(themmk.Text) Or String.IsNullOrEmpty(themvt.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE DangNhap SET Email = @Email, Matkhau = @Matkhau, Vaitro = @Vaitro WHERE Taikhoan = @Taikhoan"
                Using cmdUpdate As New SqlCommand(updateQuery, connection)
                    cmdUpdate.Parameters.AddWithValue("@Email", themgmail.Text)
                    cmdUpdate.Parameters.AddWithValue("@Taikhoan", themtk.Text)
                    cmdUpdate.Parameters.AddWithValue("@Matkhau", themmk.Text)
                    cmdUpdate.Parameters.AddWithValue("@Vaitro", themvt.Text)
                    cmdUpdate.ExecuteNonQuery()

                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa thành công
            MsgBox("Sửa thông tin thành công!")
            Form2_Load()
            trong()
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Xóa
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themgmail.Text) Or String.IsNullOrEmpty(themtk.Text) Or
           String.IsNullOrEmpty(themmk.Text) Or String.IsNullOrEmpty(themvt.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Xóa sinh viên từ CSDL
                Dim deleteStatement As String = "DELETE FROM DangNhap WHERE Taikhoan = @Taikhoan"
                Dim command As New SqlCommand(deleteStatement, connection)
                command.Parameters.AddWithValue("@Taikhoan", themtk.Text)
                command.ExecuteNonQuery()
                connection.Close()

                ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa thành công
                MsgBox("Xóa tài khoản thành công!")
                Form2_Load()
                trong()
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Tìm kiếm
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ' Tạo kết nối đến CSDL
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Thực hiện lệnh SQL SELECT để tìm kiếm 
                Dim commandText As String = "SELECT * FROM DangNhap WHERE Email LIKE @Email And Taikhoan LIKE @Taikhoan And Matkhau LIKE @Matkhau And Vaitro Like @Vaitro "
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Email", "%" + themgmail.Text + "%")
                command.Parameters.AddWithValue("@Taikhoan", "%" + themtk.Text + "%")
                command.Parameters.AddWithValue("@Matkhau", "%" + themmk.Text + "%")
                command.Parameters.AddWithValue("@Vaitro", "%" + themvt.Text + "%")

                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "DangNhap")

                ' Đóng kết nối
                connection.Close()

                ' Hiển thị kết quả tìm kiếm
                DataGridView1.DataSource = dataSet.Tables("DangNhap")
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Làm mới
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Danh sách đã được làm mới!")
        Form2_Load()
        trong()
    End Sub ' }

    Private Sub trong()
        themgmail.Text = ""
        themtk.Text = ""
        themmk.Text = ""
        themvt.Text = ""
    End Sub

    'Đóng
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub
End Class