<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.themtenkhoa = New System.Windows.Forms.TextBox()
        Me.themmakhoa = New System.Windows.Forms.TextBox()
        Me.them = New System.Windows.Forms.Button()
        Me.sua = New System.Windows.Forms.Button()
        Me.xoa = New System.Windows.Forms.Button()
        Me.tim = New System.Windows.Forms.Button()
        Me.moi = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sdt = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.chunhiem = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mã Khoa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tên Khoa:"
        '
        'themtenkhoa
        '
        Me.themtenkhoa.Location = New System.Drawing.Point(98, 130)
        Me.themtenkhoa.Name = "themtenkhoa"
        Me.themtenkhoa.Size = New System.Drawing.Size(180, 20)
        Me.themtenkhoa.TabIndex = 16
        '
        'themmakhoa
        '
        Me.themmakhoa.Location = New System.Drawing.Point(98, 98)
        Me.themmakhoa.Name = "themmakhoa"
        Me.themmakhoa.Size = New System.Drawing.Size(180, 20)
        Me.themmakhoa.TabIndex = 17
        '
        'them
        '
        Me.them.Cursor = System.Windows.Forms.Cursors.Hand
        Me.them.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.them.Location = New System.Drawing.Point(17, 292)
        Me.them.Name = "them"
        Me.them.Size = New System.Drawing.Size(72, 34)
        Me.them.TabIndex = 25
        Me.them.Text = "Thêm"
        Me.them.UseVisualStyleBackColor = True
        '
        'sua
        '
        Me.sua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.sua.Location = New System.Drawing.Point(111, 292)
        Me.sua.Name = "sua"
        Me.sua.Size = New System.Drawing.Size(72, 34)
        Me.sua.TabIndex = 26
        Me.sua.Text = "Sửa"
        Me.sua.UseVisualStyleBackColor = True
        '
        'xoa
        '
        Me.xoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.xoa.Location = New System.Drawing.Point(210, 292)
        Me.xoa.Name = "xoa"
        Me.xoa.Size = New System.Drawing.Size(72, 34)
        Me.xoa.TabIndex = 27
        Me.xoa.Text = "Xóa"
        Me.xoa.UseVisualStyleBackColor = True
        '
        'tim
        '
        Me.tim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.tim.Location = New System.Drawing.Point(17, 351)
        Me.tim.Name = "tim"
        Me.tim.Size = New System.Drawing.Size(72, 34)
        Me.tim.TabIndex = 29
        Me.tim.Text = "Tìm Kiếm"
        Me.tim.UseVisualStyleBackColor = True
        '
        'moi
        '
        Me.moi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.moi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.moi.Location = New System.Drawing.Point(111, 351)
        Me.moi.Name = "moi"
        Me.moi.Size = New System.Drawing.Size(72, 34)
        Me.moi.TabIndex = 30
        Me.moi.Text = "Làm Mới"
        Me.moi.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button7.Location = New System.Drawing.Point(195, 351)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 34)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Đóng"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(312, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(582, 426)
        Me.DataGridView1.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 53)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Khoa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Chủ nhiệm:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "SĐT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Email:"
        '
        'sdt
        '
        Me.sdt.Location = New System.Drawing.Point(98, 192)
        Me.sdt.Name = "sdt"
        Me.sdt.Size = New System.Drawing.Size(180, 20)
        Me.sdt.TabIndex = 41
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(98, 222)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(180, 20)
        Me.email.TabIndex = 42
        '
        'chunhiem
        '
        Me.chunhiem.Location = New System.Drawing.Point(98, 161)
        Me.chunhiem.Name = "chunhiem"
        Me.chunhiem.Size = New System.Drawing.Size(180, 20)
        Me.chunhiem.TabIndex = 40
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(906, 450)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.sdt)
        Me.Controls.Add(Me.chunhiem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.moi)
        Me.Controls.Add(Me.tim)
        Me.Controls.Add(Me.xoa)
        Me.Controls.Add(Me.sua)
        Me.Controls.Add(Me.them)
        Me.Controls.Add(Me.themmakhoa)
        Me.Controls.Add(Me.themtenkhoa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Form7"
        Me.Text = "Khoa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents themtenkhoa As TextBox
    Friend WithEvents themmakhoa As TextBox
    Friend WithEvents them As Button
    Friend WithEvents sua As Button
    Friend WithEvents xoa As Button
    Friend WithEvents tim As Button
    Friend WithEvents moi As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents sdt As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents chunhiem As TextBox
End Class
