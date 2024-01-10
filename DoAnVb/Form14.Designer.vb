<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinhViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KếtQuảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 31
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(53, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(109, 38)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinhViênToolStripMenuItem, Me.KếtQuảToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.MENUToolStripMenuItem.Image = CType(resources.GetObject("MENUToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(101, 34)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'SinhViênToolStripMenuItem
        '
        Me.SinhViênToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SinhViênToolStripMenuItem.Image = CType(resources.GetObject("SinhViênToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SinhViênToolStripMenuItem.Name = "SinhViênToolStripMenuItem"
        Me.SinhViênToolStripMenuItem.Size = New System.Drawing.Size(179, 34)
        Me.SinhViênToolStripMenuItem.Text = "Sinh Viên"
        '
        'KếtQuảToolStripMenuItem
        '
        Me.KếtQuảToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KếtQuảToolStripMenuItem.Image = CType(resources.GetObject("KếtQuảToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KếtQuảToolStripMenuItem.Name = "KếtQuảToolStripMenuItem"
        Me.KếtQuảToolStripMenuItem.Size = New System.Drawing.Size(179, 34)
        Me.KếtQuảToolStripMenuItem.Text = "Kết Quả"
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GiớiThiệuToolStripMenuItem.Image = CType(resources.GetObject("GiớiThiệuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(179, 34)
        Me.GiớiThiệuToolStripMenuItem.Text = "Thông Tin"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(179, 34)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(10, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 546)
        Me.Panel1.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label3.Location = New System.Drawing.Point(-1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(1415, 39)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Quản lý"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(1153, 12)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(68, 16)
        Me.LinkLabel1.TabIndex = 38
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Đăng Xuất"
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1227, 613)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form14"
        Me.Text = "Trang Chủ USER"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SinhViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KếtQuảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiớiThiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
