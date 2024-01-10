Imports System.Data.SqlClient
Imports System.IO

Public Class Form6
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' { Hiển thị thông tin sinh viên trên datagridview
    Private Sub Form2_Load()
        Dim query As String = "SELECT * FROM LopHoc"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2_Load()
    End Sub '}

    ' { Thoát
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub ' }

    ' { Thêm 
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        themmalop.Focus()
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmalop.Text) Or String.IsNullOrEmpty(themmalop.Text) Or
           String.IsNullOrEmpty(themhdt.Text) Or String.IsNullOrEmpty(themmakhoa.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Kiểm tra Malop tồn tại
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Malop không tồn tại, thực hiện truy vấn chèn dữ liệu
                Dim query As String = "INSERT INTO LopHoc (Malop, Tenlop, Hedaotao, Makhoa) 
                               VALUES (@Malop, @Tenlop, @Hedaotao, @Makhoa)"

                ' Tạo đối tượng Command và thiết lập các tham số
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Malop", themmalop.Text)
                    command.Parameters.AddWithValue("@Tenlop", themtenlop.Text)
                    command.Parameters.AddWithValue("@Hedaotao", themhdt.Text)
                    command.Parameters.AddWithValue("@Makhoa", themmakhoa.Text)

                    ' Thực thi truy vấn
                    command.ExecuteNonQuery()

                    ' Đóng kết nối
                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo thành công
            MsgBox("Thêm thêm thông tin thành công!")
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
            themmalop.Text = selectedRow.Cells("Malop").Value.ToString()
            themtenlop.Text = selectedRow.Cells("Tenlop").Value.ToString()
            themhdt.Text = selectedRow.Cells("Hedaotao").Value.ToString()
            themmakhoa.Text = selectedRow.Cells("Makhoa").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmalop.Text) Or String.IsNullOrEmpty(themmalop.Text) Or
           String.IsNullOrEmpty(themhdt.Text) Or String.IsNullOrEmpty(themmakhoa.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE LopHoc SET Tenlop = @Tenlop, Hedaotao = @Hedaotao, Makhoa = @Makhoa WHERE Malop = @Malop"
                Using cmdUpdate As New SqlCommand(updateQuery, connection)
                    cmdUpdate.Parameters.AddWithValue("@Malop", themmalop.Text)
                    cmdUpdate.Parameters.AddWithValue("@Tenlop", themtenlop.Text)
                    cmdUpdate.Parameters.AddWithValue("@Hedaotao", themhdt.Text)
                    cmdUpdate.Parameters.AddWithValue("@Makhoa", themmakhoa.Text)
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmalop.Text) Or String.IsNullOrEmpty(themmalop.Text) Or
           String.IsNullOrEmpty(themhdt.Text) Or String.IsNullOrEmpty(themmakhoa.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Xóa sinh viên từ CSDL
                Dim commandText As String = "DELETE FROM LopHoc WHERE Malop = @Malop"
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@MaLop", themmalop.Text)
                command.ExecuteNonQuery()
                connection.Close()

                ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa thành công
                MsgBox("Xóa lớp thành công!")
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
                Dim commandText As String = "SELECT * FROM LopHoc WHERE Malop LIKE @Malop And Tenlop LIKE @Tenlop And Hedaotao LIKE @Hedaotao And Makhoa Like @Makhoa "
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Malop", "%" + themmalop.Text + "%")
                command.Parameters.AddWithValue("@Tenlop", "%" + themtenlop.Text + "%")
                command.Parameters.AddWithValue("@Hedaotao", "%" + themhdt.Text + "%")
                command.Parameters.AddWithValue("@Makhoa", "%" + themmakhoa.Text + "%")

                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "LopHoc")

                ' Đóng kết nối
                connection.Close()

                ' Hiển thị kết quả tìm kiếm
                DataGridView1.DataSource = dataSet.Tables("LopHoc")
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Làm mới 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Danh sách đã được làm mới!")
        Form2_Load()
        trong()
    End Sub ' } 

    ' Trống
    Private Sub Button9_Click(sender As Object, e As EventArgs)
        trong()
    End Sub

    Private Sub trong()
        themmalop.Text = ""
        themtenlop.Text = ""
        themhdt.Text = ""
        themmakhoa.Text = ""
    End Sub


End Class