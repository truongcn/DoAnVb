Imports System.Data.SqlClient

Public Class Form7
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' { Hiển thị thông tin sinh viên trên datagridview
    Private Sub Form_Load()
        Dim query As String = "SELECT * FROM Khoa"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form_Load()
    End Sub '}

    ' { Thoát
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub ' }

    ' { Thêm
    Private Sub Them_Click(sender As Object, e As EventArgs) Handles them.Click
        themmakhoa.Focus()
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmakhoa.Text) Or String.IsNullOrEmpty(themtenkhoa.Text) Or
               String.IsNullOrEmpty(chunhiem.Text) Or String.IsNullOrEmpty(sdt.Text) Or String.IsNullOrEmpty(email.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Kiểm tra makhoa tồn tại
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' makhoa không tồn tại, thực hiện truy vấn chèn dữ liệu
                Dim query As String = "INSERT INTO Khoa (Makhoa, Tenkhoa, Chunhiem, SDT, Email) 
                               VALUES (@Makhoa, @Tenkhoa, @Chunhiem, @SDT, @Email)"

                ' Tạo đối tượng Command và thiết lập các tham số
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Makhoa", themmakhoa.Text)
                    command.Parameters.AddWithValue("@Tenkhoa", themtenkhoa.Text)
                    command.Parameters.AddWithValue("@Chunhiem", chunhiem.Text)
                    command.Parameters.AddWithValue("@SDT", sdt.Text)
                    command.Parameters.AddWithValue("@Email", email.Text)
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo thành công
            MsgBox("Thêm thông tin thành công!")
            Form_Load()
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
            themmakhoa.Text = selectedRow.Cells("Makhoa").Value.ToString()
            themtenkhoa.Text = selectedRow.Cells("Tenkhoa").Value.ToString()
            chunhiem.Text = selectedRow.Cells("Chunhiem").Value.ToString()
            sdt.Text = selectedRow.Cells("SDT").Value.ToString()
            email.Text = selectedRow.Cells("Email").Value.ToString()
        End If
    End Sub
    Private Sub Sua_Click(sender As Object, e As EventArgs) Handles sua.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmakhoa.Text) Or String.IsNullOrEmpty(themtenkhoa.Text) Or
               String.IsNullOrEmpty(chunhiem.Text) Or String.IsNullOrEmpty(sdt.Text) Or String.IsNullOrEmpty(email.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE Khoa SET Tenkhoa = @Tenkhoa, Chunhiem = @Chunhiem, SDT = @SDT, Email = @Email  WHERE Makhoa = @Makhoa"
                Using cmdUpdate As New SqlCommand(updateQuery, connection)
                    cmdUpdate.Parameters.AddWithValue("@Makhoa", themmakhoa.Text)
                    cmdUpdate.Parameters.AddWithValue("@Tenkhoa", themtenkhoa.Text)
                    cmdUpdate.Parameters.AddWithValue("@Chunhiem", chunhiem.Text)
                    cmdUpdate.Parameters.AddWithValue("@SDT", sdt.Text)
                    cmdUpdate.Parameters.AddWithValue("@Email", email.Text)
                    cmdUpdate.ExecuteNonQuery()

                    connection.Close()
                End Using
            End Using

            ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi sửa thành công
            MsgBox("Sửa thông tin thành công!")
            Form_Load()
            trong()
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Xóa
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles xoa.Click
        Try
            ' Kiểm tra thông tin trống
            If String.IsNullOrEmpty(themmakhoa.Text) Or String.IsNullOrEmpty(themtenkhoa.Text) Or
               String.IsNullOrEmpty(chunhiem.Text) Or String.IsNullOrEmpty(sdt.Text) Or String.IsNullOrEmpty(email.Text) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Xóa sinh viên từ CSDL
                Dim commandText As String = "DELETE FROM Khoa WHERE Makhoa = @Makhoa"
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Makhoa", themmakhoa.Text)
                command.ExecuteNonQuery()
                connection.Close()

                ' Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa thành công
                MsgBox("Xóa khoa thành công!")
                Form_Load()
                trong()
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' } 

    ' { Tìm kiếm
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles tim.Click
        Try
            ' Tạo kết nối đến CSDL
            Using connection As New SqlConnection(connectionString)
                ' Mở kết nối
                connection.Open()

                ' Thực hiện lệnh SQL SELECT để tìm kiếm sinh viên
                Dim commandText As String = "SELECT * FROM Khoa WHERE Makhoa LIKE @Makhoa And Tenkhoa LIKE @Tenkhoa AND Chunhiem LIKE @Chunhiem AND SDT LIKE @SDT AND Email LIKE @Email"
                Dim command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@Makhoa", "%" + themmakhoa.Text + "%")
                command.Parameters.AddWithValue("@Tenkhoa", "%" + themtenkhoa.Text + "%")
                command.Parameters.AddWithValue("@Chunhiem", "%" + chunhiem.Text + "%")
                command.Parameters.AddWithValue("@SDT", "%" + sdt.Text + "%")
                command.Parameters.AddWithValue("@Email", "%" + email.Text + "%")
                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "Khoa")

                ' Đóng kết nối
                connection.Close()

                ' Hiển thị kết quả tìm kiếm
                DataGridView1.DataSource = dataSet.Tables("Khoa")
            End Using
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub ' }

    ' { Làm mới
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles moi.Click
        MsgBox("Danh sách đã được làm mới!")
        Form_Load()
        trong()
    End Sub  ' } 

    Private Sub trong()
        themmakhoa.Text = ""
        themtenkhoa.Text = ""
        chunhiem.Text = ""
        sdt.Text = ""
        email.Text = ""
    End Sub
End Class