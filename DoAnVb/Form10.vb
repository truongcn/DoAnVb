Imports System.Diagnostics

Public Class Form10

    ' facebook
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Lấy đường dẫn từ đối tượng LinkLabelLinkClickedEventArgs
        Dim link As String = CType(e.Link.LinkData, String)

        ' Mở liên kết trong trình duyệt mặc định
        Process.Start(link)
    End Sub

    ' instagram
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Lấy đường dẫn từ đối tượng LinkLabelLinkClickedEventArgs
        Dim link As String = CType(e.Link.LinkData, String)

        ' Mở liên kết trong trình duyệt mặc định
        Process.Start(link)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Đặt liên kết và hiển thị trên LinkLabel
        Dim link1 As New LinkLabel.Link
        Dim link2 As New LinkLabel.Link
        link1.LinkData = "https://www.facebook.com/truongcn2k4"
        LinkLabel1.Links.Add(link1)

        link2.LinkData = "https://www.instagram.com/truongcn04"
        LinkLabel2.Links.Add(link2)
    End Sub

    ' Thoát 
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub

End Class