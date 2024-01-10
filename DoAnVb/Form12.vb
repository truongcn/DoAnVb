Imports System.Data.SqlClient

Public Class Form12
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' { Hiển thị thông tin sinh viên trên datagridview
    Private Sub Form2_Load()
        Dim query As String = "SELECT * FROM ThongTinSinhVien"
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

    ' { Làm mới
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Hiển thị thông báo làm mới thành công
        MsgBox("Danh sách sinh viên đã được làm mới!")
        Form2_Load()
        themmsv.Text = ""
        themhosv.Text = ""
        themten.Text = ""
        themngaysinh.Text = ""
        themphai.Text = ""
        themdiachi.Text = ""
        thememail.Text = ""
        themmalop.Text = ""
        themtenlop.Text = ""
    End Sub ' }

    ' { Tìm kiếm
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Tạo kết nối đến CSDL
            Using connection As New SqlConnection(connectionString)
                ' Mở kết nối
                connection.Open()

                ' Thực hiện lệnh SQL SELECT để tìm kiếm sinh viên
                Dim commandText As String = "SELECT * FROM ThongTinSinhVien WHERE Msv LIKE @Msv And Hosv LIKE @Hosv And Ten LIKE @Ten And Ns LIKE @Ns And Phai LIKE @Phai And Diachi LIKE @Diachi And MALOP LIKE @MALOP And Tenlop LIKE @Tenlop"
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
        Catch ex As Exception
            ' Hiển thị thông báo lỗi
            MessageBox.Show("Có lỗi xảy ra: " & ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    ' thoát
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
    End Sub

End Class