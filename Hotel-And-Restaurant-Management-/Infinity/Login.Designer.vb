<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.tb_id = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_login = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_forgot_password = New System.Windows.Forms.Label()
        Me.lbl_register = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_user_type = New System.Windows.Forms.ComboBox()
        Me.tb_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_id
        '
        Me.tb_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_id.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_id.HintText = "Enter your id"
        Me.tb_id.isPassword = False
        Me.tb_id.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.tb_id.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.tb_id.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.tb_id.LineThickness = 4
        Me.tb_id.Location = New System.Drawing.Point(111, 248)
        Me.tb_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(321, 36)
        Me.tb_id.TabIndex = 2
        Me.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_login
        '
        Me.btn_login.ActiveBorderThickness = 1
        Me.btn_login.ActiveCornerRadius = 20
        Me.btn_login.ActiveFillColor = System.Drawing.Color.Green
        Me.btn_login.ActiveForecolor = System.Drawing.Color.White
        Me.btn_login.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_login.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_login.BackgroundImage = CType(resources.GetObject("btn_login.BackgroundImage"), System.Drawing.Image)
        Me.btn_login.ButtonText = "LOGIN"
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.IdleBorderThickness = 1
        Me.btn_login.IdleCornerRadius = 20
        Me.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_login.IdleForecolor = System.Drawing.Color.White
        Me.btn_login.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(14, 363)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(415, 41)
        Me.btn_login.TabIndex = 4
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(487, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Application Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(487, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Make sure you are authorised user"
        '
        'lbl_forgot_password
        '
        Me.lbl_forgot_password.AutoSize = True
        Me.lbl_forgot_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_forgot_password.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbl_forgot_password.Location = New System.Drawing.Point(21, 409)
        Me.lbl_forgot_password.Name = "lbl_forgot_password"
        Me.lbl_forgot_password.Size = New System.Drawing.Size(108, 15)
        Me.lbl_forgot_password.TabIndex = 9
        Me.lbl_forgot_password.Text = "Forgot password ?"
        '
        'lbl_register
        '
        Me.lbl_register.AutoSize = True
        Me.lbl_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_register.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbl_register.Location = New System.Drawing.Point(350, 409)
        Me.lbl_register.Name = "lbl_register"
        Me.lbl_register.Size = New System.Drawing.Size(53, 15)
        Me.lbl_register.TabIndex = 10
        Me.lbl_register.Text = "Register"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(781, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(164, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(467, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(320, 304)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(14, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(14, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(14, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "User Type"
        '
        'cmb_user_type
        '
        Me.cmb_user_type.BackColor = System.Drawing.Color.Silver
        Me.cmb_user_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_user_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_user_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_user_type.FormattingEnabled = True
        Me.cmb_user_type.Items.AddRange(New Object() {"Administration", "Chef", "Employe", "Recepationeast"})
        Me.cmb_user_type.Location = New System.Drawing.Point(111, 195)
        Me.cmb_user_type.Name = "cmb_user_type"
        Me.cmb_user_type.Size = New System.Drawing.Size(321, 33)
        Me.cmb_user_type.TabIndex = 1
        '
        'tb_password
        '
        Me.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_password.HintForeColor = System.Drawing.Color.Empty
        Me.tb_password.HintText = ""
        Me.tb_password.isPassword = True
        Me.tb_password.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.tb_password.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.tb_password.LineThickness = 3
        Me.tb_password.Location = New System.Drawing.Point(111, 312)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(321, 33)
        Me.tb_password.TabIndex = 3
        Me.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(827, 461)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.cmb_user_type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_register)
        Me.Controls.Add(Me.lbl_forgot_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tb_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_forgot_password As Label
    Friend WithEvents lbl_register As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_user_type As ComboBox
    Friend WithEvents tb_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_id As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
