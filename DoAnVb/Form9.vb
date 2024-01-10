Imports System.Data.SqlClient

Public Class Form9
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' { Hiển thị thông tin trên datagridview
    Private Sub Form2_Load()
        Dim query As String = "SELECT * FROM MonHoc"
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

    ' Thoát
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub

    ' { Thêm
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(mamh.Text) Or String.IsNullOrEmpty(tenmh.Text) Or
               String.IsNullOrEmpty(tin.Text) Or String.IsNullOrEmpty(tiet.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Thực hiện truy vấn chèn dữ liệu
                Dim query As String = "INSERT INTO MonHoc (Mamh, Tenmh, Sotin, Sotiet) 
                           VALUES (@Mamh, @Tenmh, @Sotin, @Sotiet)"

                ' Tạo đối tượng Command và thiết lập các tham số
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Mamh", mamh.Text)
                    command.Parameters.AddWithValue("@Tenmh", tenmh.Text)
                    command.Parameters.AddWithValue("@Sotin", tin.Text)
                    command.Parameters.AddWithValue("@Sotiet", tiet.Text)
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using

                ' Hiển thị thông báo thành công
                MsgBox("Thêm thành công!")
                Form2_Load()
                trong()
            End Using
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
            mamh.Text = selectedRow.Cells("Mamh").Value.ToString()
            tenmh.Text = selectedRow.Cells("Tenmh").Value.ToString()
            tin.Text = selectedRow.Cells("Sotin").Value.ToString()
            tiet.Text = selectedRow.Cells("Sotiet").Value.ToString()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(mamh.Text) Or String.IsNullOrEmpty(tenmh.Text) Or
               String.IsNullOrEmpty(tin.Text) Or String.IsNullOrEmpty(tiet.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE MonHoc SET Tenmh = @Tenmh, Sotin = @Sotin, Sotiet = @Sotiet WHERE Mamh = @Mamh"
                Using cmdUpdate As New SqlCommand(updateQuery, connection)
                    cmdUpdate.Parameters.AddWithValue("@Mamh", mamh.Text)
                    cmdUpdate.Parameters.AddWithValue("@Tenmh", tenmh.Text)
                    cmdUpdate.Parameters.AddWithValue("@Sotin", tin.Text)
                    cmdUpdate.Parameters.AddWithValue("@Sotiet", tiet.Text)
                    cmdUpdate.ExecuteNonQuery()
                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi sửa thành công
            MsgBox("Sửa thành công!")
            Form2_Load()
            trong()
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Xóa
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(mamh.Text) Or String.IsNullOrEmpty(tenmh.Text) Or
               String.IsNullOrEmpty(tin.Text) Or String.IsNullOrEmpty(tiet.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Xóa sinh viên từ CSDL
                Dim commandText As String = "DELETE FROM MonHoc WHERE Mamh = @Mamh"
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Mamh", mamh.Text)
                command.ExecuteNonQuery()
                connection.Close()

                ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa thành công
                MsgBox("Xóa môn học thành công!")
                Form2_Load()
                trong()
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Tìm kiếm
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Tạo kết nối đến CSDL
            Using connection As New SqlConnection(connectionString)
                ' Mở kết nối
                connection.Open()

                ' Thực hiện lệnh SQL SELECT để tìm kiếm sinh viên
                Dim commandText As String = "SELECT * FROM MonHoc WHERE Mamh LIKE @Mamh And Tenmh LIKE @Tenmh AND Sotin LIKE @Sotin And Sotiet LIKE @Sotiet"
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Mamh", "%" + mamh.Text + "%")
                command.Parameters.AddWithValue("@Tenmh", "%" + tenmh.Text + "%")
                command.Parameters.AddWithValue("@Sotin", "%" + tin.Text + "%")
                command.Parameters.AddWithValue("@Sotiet", "%" + tiet.Text + "%")
                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "MonHoc")

                ' Đóng kết nối
                connection.Close()

                ' Hiển thị kết quả tìm kiếm
                DataGridView1.DataSource = dataSet.Tables("MonHoc")
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Làm mới
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Hiển thị thông báo làm mới thành công
        MsgBox("Danh sách đã được làm mới!")
        Form2_Load()
        trong()
    End Sub ' }

    Private Sub trong()
        mamh.Text = ""
        tenmh.Text = ""
        tin.Text = ""
        tiet.Text = ""
    End Sub

End Class