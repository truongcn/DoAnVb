<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dkygmail = New System.Windows.Forms.TextBox()
        Me.Dangky = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dkymk = New System.Windows.Forms.TextBox()
        Me.dkytk = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightYellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Đăng ký tài khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gmail:"
        '
        'dkygmail
        '
        Me.dkygmail.Location = New System.Drawing.Point(167, 84)
        Me.dkygmail.Name = "dkygmail"
        Me.dkygmail.Size = New System.Drawing.Size(218, 20)
        Me.dkygmail.TabIndex = 5
        '
        'Dangky
        '
        Me.Dangky.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dangky.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Dangky.Location = New System.Drawing.Point(93, 245)
        Me.Dangky.Name = "Dangky"
        Me.Dangky.Size = New System.Drawing.Size(83, 34)
        Me.Dangky.TabIndex = 8
        Me.Dangky.Text = "Đăng ký"
        Me.Dangky.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tài Khoản:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mật Khẩu:"
        '
        'dkymk
        '
        Me.dkymk.Location = New System.Drawing.Point(167, 176)
        Me.dkymk.Name = "dkymk"
        Me.dkymk.Size = New System.Drawing.Size(218, 20)
        Me.dkymk.TabIndex = 11
        '
        'dkytk
        '
        Me.dkytk.Location = New System.Drawing.Point(167, 129)
        Me.dkytk.Name = "dkytk"
        Me.dkytk.Size = New System.Drawing.Size(218, 20)
        Me.dkytk.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button1.Location = New System.Drawing.Point(336, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 34)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Đóng"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 346)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dkytk)
        Me.Controls.Add(Me.dkymk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dangky)
        Me.Controls.Add(Me.dkygmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Đăng Ký Tài Khoản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dkygmail As TextBox
    Friend WithEvents Dangky As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dkymk As TextBox
    Friend WithEvents dkytk As TextBox
    Friend WithEvents Button1 As Button
End Class
