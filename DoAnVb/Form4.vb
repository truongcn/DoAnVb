Imports System.Data.SqlClient
Imports System.IO

Public Class Form4
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"


    ' { Hiển thị thông tin sinh viên trên datagridview
    Private Sub Form_Load()
        Dim query As String = "SELECT * FROM ThongTinSinhVien"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form_Load()
    End Sub '}

    ' { Làm mới
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Hiển thị thông báo làm mới thành công
        MsgBox("Danh sách sinh viên đã được làm mới!")
        Form_Load()
        trong()
    End Sub ' }

    ' { Thoát
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub '}

    ' { Thêm 
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        themmsv.Focus()
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmsv.Text) Or String.IsNullOrEmpty(themhosv.Text) Or
           String.IsNullOrEmpty(themten.Text) Or String.IsNullOrEmpty(themngaysinh.Text) Or
           String.IsNullOrEmpty(themphai.Text) Or String.IsNullOrEmpty(themdiachi.Text) Or
           String.IsNullOrEmpty(thememail.Text) Or String.IsNullOrEmpty(themmalop.Text) Or String.IsNullOrEmpty(themtenlop.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' MSV không tồn tại, thực hiện truy vấn chèn dữ liệu
                Dim query As String = "INSERT INTO ThongTinSinhVien (Msv, Hosv, Ten, Ns, Phai, Diachi, Email, Malop, Tenlop) 
                               VALUES (@Msv, @Hosv, @Ten, @Ns, @Phai, @Diachi, @Email, @Malop, @Tenlop)"

                ' Tạo đối tượng Command và thiết lập các tham số
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Msv", themmsv.Text)
                    command.Parameters.AddWithValue("@Hosv", themhosv.Text)
                    command.Parameters.AddWithValue("@Ten", themten.Text)
                    command.Parameters.AddWithValue("@Ns", themngaysinh.Text)
                    command.Parameters.AddWithValue("@Phai", themphai.Text)
                    command.Parameters.AddWithValue("@Diachi", themdiachi.Text)
                    command.Parameters.AddWithValue("@Email", thememail.Text)
                    command.Parameters.AddWithValue("@Malop", themmalop.Text)
                    command.Parameters.AddWithValue("@Tenlop", themtenlop.Text)

                    ' Thực thi truy vấn
                    command.ExecuteNonQuery()

                    ' Đóng kết nối
                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo thành công
            MsgBox("Thêm sinh viên thành công!")
            Form_Load()
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
            If String.IsNullOrEmpty(themmsv.Text) Or String.IsNullOrEmpty(themhosv.Text) Or
           String.IsNullOrEmpty(themten.Text) Or String.IsNullOrEmpty(themngaysinh.Text) Or
           String.IsNullOrEmpty(themphai.Text) Or String.IsNullOrEmpty(themdiachi.Text) Or
           String.IsNullOrEmpty(thememail.Text) Or String.IsNullOrEmpty(themmalop.Text) Or String.IsNullOrEmpty(themtenlop.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Xóa sinh viên từ CSDL
                Dim commandText As String = "DELETE FROM ThongTinSinhVien WHERE Msv = @Msv"
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Msv", themmsv.Text)
                command.ExecuteNonQuery()
                connection.Close()

                ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa thành công
                MsgBox("Xóa sinh viên thành công!")
                Form_Load()
                trong()
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub '}

    ' { Sửa
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' Kiểm tra xem có ít nhất một dòng được chọn
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Truyền dữ liệu từ DataGridView vào các TextBox
            themmsv.Text = selectedRow.Cells("Msv").Value.ToString()
            themhosv.Text = selectedRow.Cells("Hosv").Value.ToString()
            themten.Text = selectedRow.Cells("Ten").Value.ToString()
            themngaysinh.Text = selectedRow.Cells("Ns").Value.ToString()
            themphai.Text = selectedRow.Cells("Phai").Value.ToString()
            themdiachi.Text = selectedRow.Cells("Diachi").Value.ToString()
            thememail.Text = selectedRow.Cells("Email").Value.ToString()
            themmalop.Text = selectedRow.Cells("Malop").Value.ToString()
            themtenlop.Text = selectedRow.Cells("Tenlop").Value.ToString()

            Dim image As String = Path.GetDirectoryName(Application.ExecutablePath) & "\" & selectedRow.Cells("Anh").Value.ToString()
            anh.ImageLocation = image

        End If
    End Sub

    ' sửa dữ liệu trong csdl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmsv.Text) Or String.IsNullOrEmpty(themhosv.Text) Or
           String.IsNullOrEmpty(themten.Text) Or String.IsNullOrEmpty(themngaysinh.Text) Or
           String.IsNullOrEmpty(themphai.Text) Or String.IsNullOrEmpty(themdiachi.Text) Or
           String.IsNullOrEmpty(thememail.Text) Or String.IsNullOrEmpty(themmalop.Text) Or String.IsNullOrEmpty(themtenlop.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE ThongTinSinhVien SET Hosv = @Hosv, Ten = @Ten, Ns = @Ns, Phai = @Phai, Diachi = @Diachi, Email = @Email, Malop = @Malop WHERE Msv = @Msv"
                Using cmdUpdate As New SqlCommand(updateQuery, connection)
                    cmdUpdate.Parameters.AddWithValue("@Msv", themmsv.Text)
                    cmdUpdate.Parameters.AddWithValue("@Hosv", themhosv.Text)
                    cmdUpdate.Parameters.AddWithValue("@Ten", themten.Text)
                    cmdUpdate.Parameters.AddWithValue("@Ns", themngaysinh.Text)
                    cmdUpdate.Parameters.AddWithValue("@Phai", themphai.Text)
                    cmdUpdate.Parameters.AddWithValue("@Diachi", themdiachi.Text)
                    cmdUpdate.Parameters.AddWithValue("@Email", thememail.Text)
                    cmdUpdate.Parameters.AddWithValue("@Malop", themmalop.Text)
                    cmdUpdate.Parameters.AddWithValue("@Tenlop", themtenlop.Text)
                    cmdUpdate.ExecuteNonQuery()

                    connection.Close()

                    ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi sửa thành công
                    MsgBox("Sửa thông tin sinh viên thành công!")
                    Form_Load()
                    trong()
                End Using
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Tìm kiếm 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Tạo kết nối đến CSDL
        Using connection As New SqlConnection(connectionString)
            ' Mở kết nối
            connection.Open()

            ' Thực hiện lệnh SQL SELECT để tìm kiếm sinh viên
            Dim commandText As String = "SELECT * FROM ThongTinSinhVien WHERE Msv LIKE @Msv And Hosv LIKE @Hosv And Ten LIKE @Ten And Ns LIKE @Ns And Phai LIKE @Phai And Diachi LIKE @Diachi And Tenlop LIKE @Tenlop"
            Dim command As New SqlCommand(commandText, connection)
            command.Parameters.AddWithValue("@Msv", "%" + themmsv.Text + "%")
            command.Parameters.AddWithValue("@Hosv", "%" + themhosv.Text + "%")
            command.Parameters.AddWithValue("@Ten", "%" + themten.Text + "%")
            command.Parameters.AddWithValue("@Ns", "%" + themngaysinh.Text + "%")
            command.Parameters.AddWithValue("@Phai", "%" + themphai.Text + "%")
            command.Parameters.AddWithValue("@Diachi", "%" + themdiachi.Text + "%")
            command.Parameters.AddWithValue("@Malop", "%" + themmalop.Text + "%")
            command.Parameters.AddWithValue("@Tenlop", "%" + themtenlop.Text + "%")

            Dim adapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet, "ThongTinSinhVien")

            ' Đóng kết nối
            connection.Close()

            ' Hiển thị kết quả tìm kiếm
            DataGridView1.DataSource = dataSet.Tables("ThongTinSinhVien")
        End Using
    End Sub ' }


    ' { Xuất Excel
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim csvFilePath As String = saveFileDialog.FileName

                Using writer As New System.IO.StreamWriter(csvFilePath, False, System.Text.Encoding.UTF8)
                    ' Ghi tiêu đề cột
                    For Each column As DataGridViewColumn In DataGridView1.Columns
                        writer.Write(column.HeaderText & ",")
                    Next
                    writer.WriteLine()

                    ' Ghi dữ liệu từ DataGridView
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        For Each cell As DataGridViewCell In row.Cells
                            If cell.Value IsNot Nothing Then
                                writer.Write("""" & cell.Value.ToString() & """,")
                            Else
                                writer.Write(",")
                            End If
                        Next
                        writer.WriteLine()
                    Next
                End Using

                MessageBox.Show("Dữ liệu đã được xuất ra tệp CSV thành công!", "Xuất dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    Private Sub trong()
        themmsv.Text = ""
        themhosv.Text = ""
        themten.Text = ""
        themngaysinh.Text = ""
        themphai.Text = ""
        themdiachi.Text = ""
        thememail.Text = ""
        themmalop.Text = ""
        themtenlop.Text = ""
        anh.ImageLocation = Nothing
    End Sub

End Class