<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gmail = New System.Windows.Forms.TextBox()
        Me.taikhoan = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nhập Gmail đã đăng ký:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nhập tài khoản đã đăng ký:"
        '
        'gmail
        '
        Me.gmail.Location = New System.Drawing.Point(252, 103)
        Me.gmail.Name = "gmail"
        Me.gmail.Size = New System.Drawing.Size(218, 20)
        Me.gmail.TabIndex = 6
        '
        'taikhoan
        '
        Me.taikhoan.Location = New System.Drawing.Point(252, 168)
        Me.taikhoan.Name = "taikhoan"
        Me.taikhoan.Size = New System.Drawing.Size(218, 20)
        Me.taikhoan.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button1.Location = New System.Drawing.Point(522, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 51)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Gửi mật khẩu mới"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(676, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Đóng"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(397, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "*Nếu bạn quên toàn bộ thông tin trên. Vui lòng chọn  ->"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button3.Location = New System.Drawing.Point(476, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 40)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Đăng Ký"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(277, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Quên Mật Khẩu"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(766, 396)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.taikhoan)
        Me.Controls.Add(Me.gmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Form11"
        Me.Text = "Quên Mật Khẩu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gmail As TextBox
    Friend WithEvents taikhoan As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
End Class
