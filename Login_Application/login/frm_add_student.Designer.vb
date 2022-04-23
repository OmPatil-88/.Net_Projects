<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_student
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
        Me.tb_roll_name = New System.Windows.Forms.TextBox()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.tb_city = New System.Windows.Forms.TextBox()
        Me.tb_mo_no = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_roll_name
        '
        Me.tb_roll_name.Location = New System.Drawing.Point(808, 147)
        Me.tb_roll_name.Name = "tb_roll_name"
        Me.tb_roll_name.Size = New System.Drawing.Size(191, 20)
        Me.tb_roll_name.TabIndex = 0
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(808, 257)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(191, 20)
        Me.tb_name.TabIndex = 1
        '
        'tb_city
        '
        Me.tb_city.Location = New System.Drawing.Point(808, 355)
        Me.tb_city.Name = "tb_city"
        Me.tb_city.Size = New System.Drawing.Size(191, 20)
        Me.tb_city.TabIndex = 2
        '
        'tb_mo_no
        '
        Me.tb_mo_no.Location = New System.Drawing.Point(808, 458)
        Me.tb_mo_no.MaxLength = 10
        Me.tb_mo_no.Name = "tb_mo_no"
        Me.tb_mo_no.Size = New System.Drawing.Size(191, 20)
        Me.tb_mo_no.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ROLL NO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "STUDENT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 458)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MOBILE NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(393, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(470, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "STUDENT  INFORMATION  FROM"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1242, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "LOG OUT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_view
        '
        Me.btn_view.Location = New System.Drawing.Point(680, 589)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(121, 43)
        Me.btn_view.TabIndex = 11
        Me.btn_view.Text = "VIEW DETAIL"
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Lime
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(490, 589)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(121, 43)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(847, 589)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(58, 43)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_add_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_mo_no)
        Me.Controls.Add(Me.tb_city)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.tb_roll_name)
        Me.Name = "frm_add_student"
        Me.Text = "STUDENT DETAILS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_roll_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_city As System.Windows.Forms.TextBox
    Friend WithEvents tb_mo_no As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
