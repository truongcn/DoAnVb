Public Class Form11

    ' Gửi mật khẩu mới
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Chức năng đang được hoàn thiện. Vui lòng nhấn nhấn vào đăng ký!")
    End Sub

    ' Đăng ký
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    ' Thoát
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ' MessageBox.Show("Chức năng đang được hoàn thiện. Vui lòng nhấn nhấn vào đăng ký!")
    End Sub

End Class