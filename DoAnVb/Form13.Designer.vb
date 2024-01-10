<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.themmsv = New System.Windows.Forms.TextBox()
        Me.themmamh = New System.Windows.Forms.TextBox()
        Me.themtenlop = New System.Windows.Forms.TextBox()
        Me.thuongky = New System.Windows.Forms.TextBox()
        Me.giuaky = New System.Windows.Forms.TextBox()
        Me.cuoiky = New System.Windows.Forms.TextBox()
        Me.tongket = New System.Windows.Forms.TextBox()
        Me.loai = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.themmakq = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 53)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 31)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Kết Quả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Mã Sinh Viên:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Mã Môn Học:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Tên Lớp:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Điểm Thường Kỳ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Điểm Giữa Kỳ:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Điểm Cuối Kỳ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Điểm Tổng Kết:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Xếp Loại:"
        '
        'themmsv
        '
        Me.themmsv.Location = New System.Drawing.Point(131, 127)
        Me.themmsv.Name = "themmsv"
        Me.themmsv.Size = New System.Drawing.Size(180, 20)
        Me.themmsv.TabIndex = 32
        '
        'themmamh
        '
        Me.themmamh.Location = New System.Drawing.Point(131, 157)
        Me.themmamh.Name = "themmamh"
        Me.themmamh.Size = New System.Drawing.Size(180, 20)
        Me.themmamh.TabIndex = 33
        '
        'themtenlop
        '
        Me.themtenlop.Location = New System.Drawing.Point(131, 187)
        Me.themtenlop.Name = "themtenlop"
        Me.themtenlop.Size = New System.Drawing.Size(180, 20)
        Me.themtenlop.TabIndex = 34
        '
        'thuongky
        '
        Me.thuongky.Location = New System.Drawing.Point(131, 217)
        Me.thuongky.Name = "thuongky"
        Me.thuongky.Size = New System.Drawing.Size(180, 20)
        Me.thuongky.TabIndex = 35
        '
        'giuaky
        '
        Me.giuaky.Location = New System.Drawing.Point(131, 247)
        Me.giuaky.Name = "giuaky"
        Me.giuaky.Size = New System.Drawing.Size(180, 20)
        Me.giuaky.TabIndex = 36
        '
        'cuoiky
        '
        Me.cuoiky.Location = New System.Drawing.Point(131, 277)
        Me.cuoiky.Name = "cuoiky"
        Me.cuoiky.Size = New System.Drawing.Size(180, 20)
        Me.cuoiky.TabIndex = 37
        '
        'tongket
        '
        Me.tongket.Location = New System.Drawing.Point(131, 307)
        Me.tongket.Name = "tongket"
        Me.tongket.Size = New System.Drawing.Size(180, 20)
        Me.tongket.TabIndex = 38
        '
        'loai
        '
        Me.loai.Location = New System.Drawing.Point(131, 337)
        Me.loai.Name = "loai"
        Me.loai.Size = New System.Drawing.Size(180, 20)
        Me.loai.TabIndex = 39
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 400)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 34)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "Tìm Kiếm"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button3.Location = New System.Drawing.Point(229, 400)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 34)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Làm Mới"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button6.Location = New System.Drawing.Point(113, 400)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 34)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "Xuất File"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button7.Location = New System.Drawing.Point(113, 489)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 34)
        Me.Button7.TabIndex = 47
        Me.Button7.Text = "Đóng"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(327, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(851, 513)
        Me.DataGridView1.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Mã Kết Quả:"
        '
        'themmakq
        '
        Me.themmakq.Location = New System.Drawing.Point(131, 97)
        Me.themmakq.Name = "themmakq"
        Me.themmakq.Size = New System.Drawing.Size(180, 20)
        Me.themmakq.TabIndex = 50
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1254, 532)
        Me.Controls.Add(Me.themmakq)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.loai)
        Me.Controls.Add(Me.tongket)
        Me.Controls.Add(Me.cuoiky)
        Me.Controls.Add(Me.giuaky)
        Me.Controls.Add(Me.thuongky)
        Me.Controls.Add(Me.themtenlop)
        Me.Controls.Add(Me.themmamh)
        Me.Controls.Add(Me.themmsv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form13"
        Me.Text = "( USER ) Kết Quả"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents themmsv As TextBox
    Friend WithEvents themmamh As TextBox
    Friend WithEvents themtenlop As TextBox
    Friend WithEvents thuongky As TextBox
    Friend WithEvents giuaky As TextBox
    Friend WithEvents cuoiky As TextBox
    Friend WithEvents tongket As TextBox
    Friend WithEvents loai As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents themmakq As TextBox
End Class
