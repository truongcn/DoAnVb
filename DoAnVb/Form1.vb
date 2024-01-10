Imports System.Data.SqlClient

Public Class Form1

    Private connectionString As String = "Data Source=localhost;Initial Catalog=Do_an_QLSV;User ID=sa;Password=123456aA@"

    ' { Nhạc
    'Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    ' Phát nhạc khi form được hiển thị
    'If Not CheckBox1.Checked Then
    '       My.Computer.Audio.Play("D:\DataProjects\vbnet\DoAnQLSV\DoAnvb\Piano.wav", AudioPlayMode.BackgroundLoop)
    'End If
    'End Sub

    Private Sub LoginForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ' Dừng phát nhạc khi form bị ẩn
        If Not Me.Visible Then
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Bật âm thanh nhạc khi checkbox được chọn và ngược lại
        If CheckBox1.Checked Then
            My.Computer.Audio.Play("D:\DataProjects\DoAnvb\Piano.wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub ' }

    ' Đăng nhập
    Private Function CheckLogin(Taikhoan As String, Matkhau As String, ByRef Vaitro As String) As Boolean
        ' Tạo kết nối đến cơ sở dữ liệu
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Tạo câu truy vấn kiểm tra đăng nhập
            Dim query As String = "SELECT Vaitro FROM Dangnhap WHERE Taikhoan = @Taikhoan AND Matkhau = @Matkhau"

            ' Tạo và thực thi lệnh truy vấn
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Taikhoan", Taikhoan)
                command.Parameters.AddWithValue("@Matkhau", Matkhau)

                ' Lấy vai trò từ cơ sở dữ liệu
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing Then
                    Vaitro = Convert.ToString(result)
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Private Sub kiemtra()
        Dim Taikhoan As String = tk.Text
        Dim Matkhau As String = mk.Text
        Dim Vaitro As String = ""

        ' Kiểm tra xem tên đăng nhập và mật khẩu có tồn tại trong cơ sở dữ liệu hay không
        If CheckLogin(Taikhoan, Matkhau, Vaitro) Then
            ' Mở form theo vai trò
            Select Case Vaitro
                Case "ADMIN"
                    MessageBox.Show("Tài khoản ADMIN", "Xin chào!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    moi()
                    ' Mở form chính cho admin
                    Form3.Show()
                Case "MEMBER"
                    MsgBox("Tài khoản MEMBER", vbOKOnly, "Xin chào!")
                    moi()
                    ' Mở form chỉ định cho member
                    Form14.Show()
                Case "USER"
                    MsgBox("Tài khoản USER", vbOKOnly, "Xin chào!")
                    Dim Msv As String = Taikhoan
                    moi()
                    ' Mở form chứa toàn bộ thông tin của sinh viên
                    Dim Form17 As New Form17()
                    Form17.LoadStudentInfoFromDatabase(Msv)
                    Form17.Show()
                Case Else
                    MessageBox.Show("Vai trò không hợp lệ!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

            ' Ẩn form đăng nhập
            Me.Hide()

        ElseIf tk.Text = "" Or mk.Text = "" Then
            MessageBox.Show("Tài khoản hoặc Mật khẩu không được để trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            moi()
        Else
            MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng!", "Vui lòng nhập lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            moi()
        End If
    End Sub  ' }

    ' Thoát
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Chào tạm biệt!", "Thân ái!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End
    End Sub

    ' Đăng ký
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    'Quên mật khẩu
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form11.Show()
    End Sub

    ' Báo lỗi
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MsgBox(" Cảm ơn bạn đã gửi phản hồi đến cho chúng tôi,
                chúng tôi đã nhận được phản hồi của bạn. 
                Chúng tôi quyết định không làm gì cả vì sẽ rất mất thời gian
                            ...
                THÂN ÁI!", vbOKOnly, "Thông Báo")
    End Sub

    ' Đổi mật khẩu
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Form16.Show()
    End Sub

    ' Ẩn hiện password
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked Then
            mk.PasswordChar = Convert.ToChar(0)
        Else
            mk.PasswordChar = Convert.ToChar("●")
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Ngày 08/08/2023")
    End Sub

    'enter đăng nhập
    Private Sub mk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mk.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            kiemtra()
        End If
    End Sub
    Private Sub tk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tk.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            kiemtra()
        End If
    End Sub

    'dang nhap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kiemtra()
    End Sub

    ' thông tin
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form10.Show()
    End Sub

    Private Sub moi()
        tk.Text = ""
        mk.Text = ""
    End Sub
End Class
