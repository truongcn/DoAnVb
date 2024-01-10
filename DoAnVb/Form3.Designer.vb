<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Khoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mon = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinhVien = New System.Windows.Forms.ToolStripMenuItem()
        Me.KetQua = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaiKhoan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongTin = New System.Windows.Forms.ToolStripMenuItem()
        Me.Thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrắngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XanhLáCâyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐỏToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(-1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(1415, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quản lý"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(8, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 596)
        Me.Panel1.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem11})
        Me.MenuStrip1.Location = New System.Drawing.Point(54, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(341, 38)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Khoa, Me.Lop, Me.Mon, Me.SinhVien, Me.KetQua, Me.TaiKhoan, Me.ThongTin, Me.Thoat})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(101, 34)
        Me.ToolStripMenuItem1.Text = "MENU"
        '
        'Khoa
        '
        Me.Khoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Khoa.Image = CType(resources.GetObject("Khoa.Image"), System.Drawing.Image)
        Me.Khoa.Name = "Khoa"
        Me.Khoa.Size = New System.Drawing.Size(180, 34)
        Me.Khoa.Text = "Khoa"
        '
        'Lop
        '
        Me.Lop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lop.Image = CType(resources.GetObject("Lop.Image"), System.Drawing.Image)
        Me.Lop.Name = "Lop"
        Me.Lop.Size = New System.Drawing.Size(180, 34)
        Me.Lop.Text = "Lớp Học"
        '
        'Mon
        '
        Me.Mon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Mon.Image = CType(resources.GetObject("Mon.Image"), System.Drawing.Image)
        Me.Mon.Name = "Mon"
        Me.Mon.Size = New System.Drawing.Size(180, 34)
        Me.Mon.Text = "Môn Học"
        '
        'SinhVien
        '
        Me.SinhVien.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SinhVien.Image = CType(resources.GetObject("SinhVien.Image"), System.Drawing.Image)
        Me.SinhVien.Name = "SinhVien"
        Me.SinhVien.Size = New System.Drawing.Size(180, 34)
        Me.SinhVien.Text = "Sinh Viên"
        '
        'KetQua
        '
        Me.KetQua.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KetQua.Image = CType(resources.GetObject("KetQua.Image"), System.Drawing.Image)
        Me.KetQua.Name = "KetQua"
        Me.KetQua.Size = New System.Drawing.Size(180, 34)
        Me.KetQua.Text = "Kết Quả"
        '
        'TaiKhoan
        '
        Me.TaiKhoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TaiKhoan.Image = CType(resources.GetObject("TaiKhoan.Image"), System.Drawing.Image)
        Me.TaiKhoan.Name = "TaiKhoan"
        Me.TaiKhoan.Size = New System.Drawing.Size(180, 34)
        Me.TaiKhoan.Text = "Tài Khoản"
        '
        'ThongTin
        '
        Me.ThongTin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThongTin.Image = CType(resources.GetObject("ThongTin.Image"), System.Drawing.Image)
        Me.ThongTin.Name = "ThongTin"
        Me.ThongTin.Size = New System.Drawing.Size(180, 34)
        Me.ThongTin.Text = "Thông Tin"
        '
        'Thoat
        '
        Me.Thoat.BackColor = System.Drawing.Color.Red
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(180, 34)
        Me.Thoat.Text = "Thoát"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrắngToolStripMenuItem, Me.XanhLáCâyToolStripMenuItem, Me.ĐỏToolStripMenuItem, Me.CamToolStripMenuItem, Me.VàngToolStripMenuItem})
        Me.ToolStripMenuItem11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(112, 34)
        Me.ToolStripMenuItem11.Text = "Màu Nền"
        '
        'TrắngToolStripMenuItem
        '
        Me.TrắngToolStripMenuItem.Name = "TrắngToolStripMenuItem"
        Me.TrắngToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.TrắngToolStripMenuItem.Text = "Trắng"
        '
        'XanhLáCâyToolStripMenuItem
        '
        Me.XanhLáCâyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XanhLáCâyToolStripMenuItem.Name = "XanhLáCâyToolStripMenuItem"
        Me.XanhLáCâyToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.XanhLáCâyToolStripMenuItem.Text = "Xanh lá cây"
        '
        'ĐỏToolStripMenuItem
        '
        Me.ĐỏToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.ĐỏToolStripMenuItem.Name = "ĐỏToolStripMenuItem"
        Me.ĐỏToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.ĐỏToolStripMenuItem.Text = "Đỏ"
        '
        'CamToolStripMenuItem
        '
        Me.CamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CamToolStripMenuItem.Name = "CamToolStripMenuItem"
        Me.CamToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.CamToolStripMenuItem.Text = "Cam"
        '
        'VàngToolStripMenuItem
        '
        Me.VàngToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.VàngToolStripMenuItem.Name = "VàngToolStripMenuItem"
        Me.VàngToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.VàngToolStripMenuItem.Text = "Vàng"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(1225, 26)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(68, 16)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Đăng Xuất"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1305, 670)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Trang Chủ ADMIN"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Khoa As ToolStripMenuItem
    Friend WithEvents Lop As ToolStripMenuItem
    Friend WithEvents Mon As ToolStripMenuItem
    Friend WithEvents SinhVien As ToolStripMenuItem
    Friend WithEvents KetQua As ToolStripMenuItem
    Friend WithEvents TaiKhoan As ToolStripMenuItem
    Friend WithEvents ThongTin As ToolStripMenuItem
    Friend WithEvents Thoat As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents TrắngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XanhLáCâyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐỏToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
