Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

' form thongtin của sinh viên ( user )
Public Class Form17
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' Hàm để lấy thông tin sinh viên từ SQL Server
    Public Sub LoadStudentInfoFromDatabase(Msv As String)
        ' Gọi phương thức để thiết lập các cột cho DataGridView
        SetupDataGridView()

        ' Gọi phương thức để tải dữ liệu kết quả
        LoadKetQua(Msv)

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Tạo câu truy vấn để lấy thông tin sinh viên
            Dim query As String = "SELECT * FROM ThongTinSinhVien WHERE Msv = @Msv"

            ' Tạo và thực thi lệnh truy vấn
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Msv", Msv)

                ' Sử dụng SqlDataReader để đọc dữ liệu từ truy vấn
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Đọc thông tin sinh viên từ dữ liệu đọc được
                        Dim Ma As String = reader("Msv").ToString()
                        Dim Ho As String = reader("Hosv").ToString()
                        Dim Ten As String = reader("Ten").ToString()
                        Dim Ngaysinh As Date = reader("Ns").ToString()
                        Dim Gioitinh As String = reader("Phai").ToString()
                        Dim Diachi As String = reader("Diachi").ToString()
                        Dim Email As String = reader("Email").ToString()
                        Dim Malop As String = reader("Malop").ToString()
                        Dim Tenlop As String = reader("Tenlop").ToString()

                        ' Hiển thị thông tin sinh viên trên form
                        themmsv.Text = $"{Ma}"
                        themhosv.Text = $"{Ho}"
                        themten.Text = $"{Ten}"
                        themngaysinh.Text = $"{Ngaysinh}"
                        themphai.Text = $"{Gioitinh}"
                        themdiachi.Text = $"{Diachi}"
                        thememail.Text = $"{Email}"
                        themmalop.Text = $"{Malop}"
                        themtenlop.Text = $"{Tenlop}"

                        Dim imagePath As String = reader("Anh").ToString()
                        Dim fullImagePath As String = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), imagePath)
                        anh.ImageLocation = fullImagePath
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub SetupDataGridView()
        ' Xóa cột cũ (nếu có)
        DataGridView1.Columns.Clear()

        ' Tạo các cột cho DataGridView
        DataGridView1.Columns.Add("Maketqua", "Mã Kết Quả")
        DataGridView1.Columns.Add("Mamh", "Mã Môn Học")
        DataGridView1.Columns.Add("Diemthuongky", "Điểm Thưởng Kỳ")
        DataGridView1.Columns.Add("Diemgiuaky", "Điểm Giữa Kỳ")
        DataGridView1.Columns.Add("Diemcuoiky", "Điểm Cuối Kỳ")
        DataGridView1.Columns.Add("Diemtongket", "Điểm Tổng Kết")
        DataGridView1.Columns.Add("Xeploai", "Xếp Loại")
    End Sub

    Private Sub LoadKetQua(ByVal Msv As String)
        ' Xóa dữ liệu cũ trên bảng
        DataGridView1.Rows.Clear()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Tạo câu truy vấn để lấy dữ liệu kết quả của sinh viên
                Dim query As String = "SELECT * FROM KetQua WHERE Msv = @Msv"

                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Msv", Msv)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Đọc dữ liệu từ SqlDataReader và thêm vào DataGridView
                            Dim makq As String = reader("Maketqua").ToString()
                            Dim mamon As String = reader("Mamh").ToString()
                            Dim thuongky As String = reader("Diemthuongky").ToString()
                            Dim giuaky As String = reader("Diemgiuaky").ToString()
                            Dim cuoiky As String = reader("Diemcuoiky").ToString()
                            Dim tongket As String = reader("Diemtongket").ToString()
                            Dim xeploai As String = reader("Xeploai").ToString()

                            DataGridView1.Rows.Add(makq, mamon, thuongky, giuaky, cuoiky, tongket, xeploai)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("Không tải dữ liệu kết quả! " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' đóng
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class