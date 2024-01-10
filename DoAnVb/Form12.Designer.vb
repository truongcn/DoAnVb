<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form12
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.themmsv = New System.Windows.Forms.TextBox()
        Me.themhosv = New System.Windows.Forms.TextBox()
        Me.themten = New System.Windows.Forms.TextBox()
        Me.themngaysinh = New System.Windows.Forms.TextBox()
        Me.themphai = New System.Windows.Forms.TextBox()
        Me.themdiachi = New System.Windows.Forms.TextBox()
        Me.thememail = New System.Windows.Forms.TextBox()
        Me.themmalop = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.themtenlop = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 58)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Thông Tin Sinh Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mã Sinh Viên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Họ Sinh Viên:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tên Sinh Viên:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ngày Sinh:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Phái:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Địa Chỉ:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Mã lớp:"
        '
        'themmsv
        '
        Me.themmsv.Location = New System.Drawing.Point(108, 84)
        Me.themmsv.Name = "themmsv"
        Me.themmsv.Size = New System.Drawing.Size(180, 20)
        Me.themmsv.TabIndex = 13
        '
        'themhosv
        '
        Me.themhosv.Location = New System.Drawing.Point(108, 118)
        Me.themhosv.Name = "themhosv"
        Me.themhosv.Size = New System.Drawing.Size(180, 20)
        Me.themhosv.TabIndex = 14
        '
        'themten
        '
        Me.themten.Location = New System.Drawing.Point(108, 152)
        Me.themten.Name = "themten"
        Me.themten.Size = New System.Drawing.Size(180, 20)
        Me.themten.TabIndex = 15
        '
        'themngaysinh
        '
        Me.themngaysinh.Location = New System.Drawing.Point(108, 187)
        Me.themngaysinh.Name = "themngaysinh"
        Me.themngaysinh.Size = New System.Drawing.Size(180, 20)
        Me.themngaysinh.TabIndex = 16
        '
        'themphai
        '
        Me.themphai.Location = New System.Drawing.Point(108, 222)
        Me.themphai.Name = "themphai"
        Me.themphai.Size = New System.Drawing.Size(180, 20)
        Me.themphai.TabIndex = 17
        '
        'themdiachi
        '
        Me.themdiachi.Location = New System.Drawing.Point(108, 258)
        Me.themdiachi.Name = "themdiachi"
        Me.themdiachi.Size = New System.Drawing.Size(180, 20)
        Me.themdiachi.TabIndex = 18
        '
        'thememail
        '
        Me.thememail.Location = New System.Drawing.Point(108, 293)
        Me.thememail.Name = "thememail"
        Me.thememail.Size = New System.Drawing.Size(180, 20)
        Me.thememail.TabIndex = 19
        '
        'themmalop
        '
        Me.themmalop.Location = New System.Drawing.Point(108, 327)
        Me.themmalop.Name = "themmalop"
        Me.themmalop.Size = New System.Drawing.Size(180, 20)
        Me.themmalop.TabIndex = 20
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 411)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 34)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Tìm Kiếm"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button3.Location = New System.Drawing.Point(216, 411)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 34)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Làm Mới"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button6.Location = New System.Drawing.Point(108, 411)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 34)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Xuất File"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button7.Location = New System.Drawing.Point(108, 475)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 34)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "Đóng"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(298, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(876, 497)
        Me.DataGridView1.TabIndex = 30
        '
        'themtenlop
        '
        Me.themtenlop.Location = New System.Drawing.Point(108, 361)
        Me.themtenlop.Name = "themtenlop"
        Me.themtenlop.Size = New System.Drawing.Size(180, 20)
        Me.themtenlop.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 365)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Tên lớp:"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1249, 529)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.themtenlop)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.themmalop)
        Me.Controls.Add(Me.thememail)
        Me.Controls.Add(Me.themdiachi)
        Me.Controls.Add(Me.themphai)
        Me.Controls.Add(Me.themngaysinh)
        Me.Controls.Add(Me.themten)
        Me.Controls.Add(Me.themhosv)
        Me.Controls.Add(Me.themmsv)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Form12"
        Me.Text = "( USER ) Sinh Viên"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents themmsv As TextBox
    Friend WithEvents themhosv As TextBox
    Friend WithEvents themten As TextBox
    Friend WithEvents themngaysinh As TextBox
    Friend WithEvents themphai As TextBox
    Friend WithEvents themdiachi As TextBox
    Friend WithEvents thememail As TextBox
    Friend WithEvents themmalop As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents themtenlop As TextBox
    Friend WithEvents Label10 As Label
End Class
