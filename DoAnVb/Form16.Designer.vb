<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tk = New System.Windows.Forms.TextBox()
        Me.mkcu = New System.Windows.Forms.TextBox()
        Me.mkmoi = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đổi Mật Khẩu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập Tài Khoản:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nhập Mật Khẩu Cũ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nhập Mật Khẩu Mới:"
        '
        'tk
        '
        Me.tk.Location = New System.Drawing.Point(202, 94)
        Me.tk.Name = "tk"
        Me.tk.Size = New System.Drawing.Size(177, 20)
        Me.tk.TabIndex = 4
        '
        'mkcu
        '
        Me.mkcu.Location = New System.Drawing.Point(202, 143)
        Me.mkcu.Name = "mkcu"
        Me.mkcu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.mkcu.Size = New System.Drawing.Size(177, 20)
        Me.mkcu.TabIndex = 5
        '
        'mkmoi
        '
        Me.mkmoi.Location = New System.Drawing.Point(202, 191)
        Me.mkmoi.Name = "mkmoi"
        Me.mkmoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.mkmoi.Size = New System.Drawing.Size(177, 20)
        Me.mkmoi.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button1.Location = New System.Drawing.Point(249, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Đổi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button2.Location = New System.Drawing.Point(460, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Đóng"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox2.Image = CType(resources.GetObject("CheckBox2.Image"), System.Drawing.Image)
        Me.CheckBox2.Location = New System.Drawing.Point(387, 186)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(47, 32)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Image = CType(resources.GetObject("CheckBox1.Image"), System.Drawing.Image)
        Me.CheckBox1.Location = New System.Drawing.Point(387, 138)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(47, 32)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(564, 359)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mkmoi)
        Me.Controls.Add(Me.mkcu)
        Me.Controls.Add(Me.tk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Form16"
        Me.Text = "Form16"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tk As TextBox
    Friend WithEvents mkcu As TextBox
    Friend WithEvents mkmoi As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Private WithEvents CheckBox2 As CheckBox
    Private WithEvents CheckBox1 As CheckBox
End Class
