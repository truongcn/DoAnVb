Imports System.Data.SqlClient
Imports System.IO

Public Class Form5
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' { Hiển thị thông tin sinh viên trên datagridview
    Private Sub Form2_Load()
        Dim query As String = "SELECT * FROM KetQua"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2_Load()
    End Sub '}

    ' Thoát
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub

    ' { Thêm 
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        themmakq.Focus()
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmakq.Text) Or String.IsNullOrEmpty(themmsv.Text) Or String.IsNullOrEmpty(themmamh.Text) Or
           String.IsNullOrEmpty(themtenlop.Text) Or String.IsNullOrEmpty(thuongky.Text) Or
           String.IsNullOrEmpty(giuaky.Text) Or String.IsNullOrEmpty(cuoiky.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' mkq không tồn tại thực hiện truy vấn chèn dữ liệu
                Dim query As String = "INSERT INTO KetQua (Maketqua, Msv, Mamh, Tenlop, Diemthuongky, Diemgiuaky, Diemcuoiky) 
                                      VALUES (@Maketqua, @Msv, @Mamh, @Tenlop, @Diemthuongky, @Diemgiuaky, @Diemcuoiky)"

                ' Tạo đối tượng Command và thiết lập các tham số
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Maketqua", themmakq.Text)
                    command.Parameters.AddWithValue("@Msv", themmsv.Text)
                    command.Parameters.AddWithValue("@Mamh", themmamh.Text)
                    command.Parameters.AddWithValue("@Tenlop", themtenlop.Text)
                    command.Parameters.AddWithValue("@Diemthuongky", thuongky.Text)
                    command.Parameters.AddWithValue("@Diemgiuaky", giuaky.Text)
                    command.Parameters.AddWithValue("@Diemcuoiky", cuoiky.Text)
                    ' Thực thi truy vấn
                    command.ExecuteNonQuery()

                    ' Đóng kết nối
                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo thành công
            MsgBox("Thêm sinh viên thành công!")
            Form2_Load()
            trong()
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Làm mới
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Danh sách sinh viên đã được làm mới!")
        Form2_Load()
        trong()
    End Sub ' }

    ' { Sửa
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' Kiểm tra xem có ít nhất một dòng được chọn
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Truyền dữ liệu từ DataGridView vào các TextBox
            themmakq.Text = selectedRow.Cells("Maketqua").Value.ToString()
            themmsv.Text = selectedRow.Cells("Msv").Value.ToString()
            themmamh.Text = selectedRow.Cells("Mamh").Value.ToString()
            themtenlop.Text = selectedRow.Cells("Tenlop").Value.ToString()
            thuongky.Text = selectedRow.Cells("Diemthuongky").Value.ToString()
            giuaky.Text = selectedRow.Cells("Diemgiuaky").Value.ToString()
            cuoiky.Text = selectedRow.Cells("Diemcuoiky").Value.ToString()
            tongket.Text = selectedRow.Cells("Diemtongket").Value.ToString()
            loai.Text = selectedRow.Cells("Xeploai").Value.ToString()

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmakq.Text) Or String.IsNullOrEmpty(themmsv.Text) Or String.IsNullOrEmpty(themmamh.Text) Or
           String.IsNullOrEmpty(themtenlop.Text) Or String.IsNullOrEmpty(thuongky.Text) Or
           String.IsNullOrEmpty(giuaky.Text) Or String.IsNullOrEmpty(cuoiky.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE KetQua SET Diemthuongky = @Diemthuongky, Diemgiuaky = @Diemgiuaky, Diemcuoiky = @Diemcuoiky WHERE Maketqua = @Maketqua "
                Using cmdUpdate As New SqlCommand(updateQuery, connection)
                    cmdUpdate.Parameters.AddWithValue("@Maketqua", themmakq.Text)
                    cmdUpdate.Parameters.AddWithValue("@Diemthuongky", thuongky.Text)
                    cmdUpdate.Parameters.AddWithValue("@Diemgiuaky", giuaky.Text)
                    cmdUpdate.Parameters.AddWithValue("@Diemcuoiky", cuoiky.Text)
                    cmdUpdate.ExecuteNonQuery()

                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi sửa thành công
            MsgBox("Sửa thông tin sinh viên thành công!")
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
            If String.IsNullOrEmpty(themmakq.Text) Or String.IsNullOrEmpty(themmsv.Text) Or String.IsNullOrEmpty(themmamh.Text) Or
           String.IsNullOrEmpty(themtenlop.Text) Or String.IsNullOrEmpty(thuongky.Text) Or
           String.IsNullOrEmpty(giuaky.Text) Or String.IsNullOrEmpty(cuoiky.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Xóa sinh viên từ CSDL
                Dim commandText As String = "DELETE FROM KetQua WHERE Maketqua = @Maketqua"
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Maketqua", themmakq.Text)
                command.ExecuteNonQuery()
                connection.Close()

                ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa thành công
                MsgBox("Xóa kết quả của sinh viên thành công!")
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
                Dim commandText As String = "SELECT * FROM KetQua WHERE Maketqua LIKE @Maketqua AND Msv LIKE @Msv AND Mamh LIKE @Mamh AND Tenlop LIKE @Tenlop AND 
                    Diemthuongky LIKE @Diemthuongky AND Diemgiuaky LIKE @Diemgiuaky AND Diemcuoiky LIKE @Diemcuoiky AND 
                    Diemtongket LIKE @Diemtongket AND Xeploai LIKE @Xeploai"
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Maketqua", "%" + themmakq.Text + "%")
                command.Parameters.AddWithValue("@Msv", "%" + themmsv.Text + "%")
                command.Parameters.AddWithValue("@Mamh", "%" + themmamh.Text + "%")
                command.Parameters.AddWithValue("@Tenlop", "%" + themtenlop.Text + "%")
                command.Parameters.AddWithValue("@Diemthuongky", "%" + thuongky.Text + "%")
                command.Parameters.AddWithValue("@Diemgiuaky", "%" + giuaky.Text + "%")
                command.Parameters.AddWithValue("@Diemcuoiky", "%" + cuoiky.Text + "%")
                command.Parameters.AddWithValue("@Diemtongket", "%" + tongket.Text + "%")
                command.Parameters.AddWithValue("@Xeploai", "%" + loai.Text + "%")

                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "KetQua")

                ' Đóng kết nối
                connection.Close()

                ' Hiển thị kết quả tìm kiếm
                DataGridView1.DataSource = dataSet.Tables("KetQua")
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Xuất Excel
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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
    End Sub ' }

    Private Sub trong()
        themmakq.Text = ""
        themmsv.Text = ""
        themmamh.Text = ""
        themtenlop.Text = ""
        thuongky.Text = ""
        giuaky.Text = ""
        cuoiky.Text = ""
        tongket.Text = ""
        loai.Text = ""
    End Sub

End Class