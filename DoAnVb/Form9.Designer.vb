<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mamh = New System.Windows.Forms.TextBox()
        Me.tenmh = New System.Windows.Forms.TextBox()
        Me.tiet = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Mã Môn Học:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tên Môn Học:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Số Tiết:"
        '
        'mamh
        '
        Me.mamh.Location = New System.Drawing.Point(133, 117)
        Me.mamh.Name = "mamh"
        Me.mamh.Size = New System.Drawing.Size(180, 20)
        Me.mamh.TabIndex = 24
        '
        'tenmh
        '
        Me.tenmh.Location = New System.Drawing.Point(133, 154)
        Me.tenmh.Name = "tenmh"
        Me.tenmh.Size = New System.Drawing.Size(180, 20)
        Me.tenmh.TabIndex = 25
        '
        'tiet
        '
        Me.tiet.Location = New System.Drawing.Point(133, 232)
        Me.tiet.Name = "tiet"
        Me.tiet.Size = New System.Drawing.Size(180, 20)
        Me.tiet.TabIndex = 26
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button6.Location = New System.Drawing.Point(25, 302)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 34)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "Thêm"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button1.Location = New System.Drawing.Point(133, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 34)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Sửa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button2.Location = New System.Drawing.Point(241, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 34)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Xóa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button3.Location = New System.Drawing.Point(133, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 34)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Làm Mới"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button7.Location = New System.Drawing.Point(229, 371)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 34)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "Đóng"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button4.Location = New System.Drawing.Point(25, 371)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 34)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Tìm Kiếm"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(335, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(561, 426)
        Me.DataGridView1.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 52)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Môn Học"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tin
        '
        Me.tin.Location = New System.Drawing.Point(133, 194)
        Me.tin.Name = "tin"
        Me.tin.Size = New System.Drawing.Size(180, 20)
        Me.tin.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Số tín:"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(908, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.tiet)
        Me.Controls.Add(Me.tenmh)
        Me.Controls.Add(Me.mamh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "Form9"
        Me.Text = "Môn Học"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mamh As TextBox
    Friend WithEvents tenmh As TextBox
    Friend WithEvents tiet As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents tin As TextBox
    Friend WithEvents Label5 As Label
End Class
