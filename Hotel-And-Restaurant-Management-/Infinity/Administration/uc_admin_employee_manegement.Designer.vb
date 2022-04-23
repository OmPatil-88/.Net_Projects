<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_admin_employee_manegement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Employee_Management = New System.Windows.Forms.Panel()
        Me.btn_em_emp_img_brows = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_em_emp_age = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_em_emp_adhar_no = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pb_em_emp_image = New System.Windows.Forms.PictureBox()
        Me.btn_em_search = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_em_emp_type = New System.Windows.Forms.ComboBox()
        Me.tb_em_emp_mob2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_em_emp_mob1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tb_em_emp_address = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_em_emp_minus = New System.Windows.Forms.Button()
        Me.btn_em_emp_plus = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_em_emp_sallery = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtp_em_emp_join = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_em_emp_birthday = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_em_emp_surname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_em_emp_middlename = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_em_emp_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_em_emp_id = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_em_emp_delete = New System.Windows.Forms.Button()
        Me.btn_em_emp_update = New System.Windows.Forms.Button()
        Me.btn_em_emp_add = New System.Windows.Forms.Button()
        Me.btn_em_emp_new = New System.Windows.Forms.Button()
        Me.dg_em_emp_grid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel_Employee_Management.SuspendLayout()
        CType(Me.pb_em_emp_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_em_emp_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(92, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1547, 54)
        Me.Panel1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(612, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employe Manegament"
        '
        'Panel_Employee_Management
        '
        Me.Panel_Employee_Management.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Employee_Management.Controls.Add(Me.btn_em_emp_img_brows)
        Me.Panel_Employee_Management.Controls.Add(Me.Label10)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_age)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_adhar_no)
        Me.Panel_Employee_Management.Controls.Add(Me.Label7)
        Me.Panel_Employee_Management.Controls.Add(Me.pb_em_emp_image)
        Me.Panel_Employee_Management.Controls.Add(Me.btn_em_search)
        Me.Panel_Employee_Management.Controls.Add(Me.Label6)
        Me.Panel_Employee_Management.Controls.Add(Me.cb_em_emp_type)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_mob2)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_mob1)
        Me.Panel_Employee_Management.Controls.Add(Me.Label20)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_address)
        Me.Panel_Employee_Management.Controls.Add(Me.Label21)
        Me.Panel_Employee_Management.Controls.Add(Me.btn_em_emp_minus)
        Me.Panel_Employee_Management.Controls.Add(Me.btn_em_emp_plus)
        Me.Panel_Employee_Management.Controls.Add(Me.Label11)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_sallery)
        Me.Panel_Employee_Management.Controls.Add(Me.dtp_em_emp_join)
        Me.Panel_Employee_Management.Controls.Add(Me.Label9)
        Me.Panel_Employee_Management.Controls.Add(Me.dtp_em_emp_birthday)
        Me.Panel_Employee_Management.Controls.Add(Me.Label8)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_surname)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_middlename)
        Me.Panel_Employee_Management.Controls.Add(Me.Label5)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_name)
        Me.Panel_Employee_Management.Controls.Add(Me.Label4)
        Me.Panel_Employee_Management.Controls.Add(Me.tb_em_emp_id)
        Me.Panel_Employee_Management.Controls.Add(Me.Label3)
        Me.Panel_Employee_Management.Location = New System.Drawing.Point(14, 110)
        Me.Panel_Employee_Management.Name = "Panel_Employee_Management"
        Me.Panel_Employee_Management.Size = New System.Drawing.Size(1625, 358)
        Me.Panel_Employee_Management.TabIndex = 60
        '
        'btn_em_emp_img_brows
        '
        Me.btn_em_emp_img_brows.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_em_emp_img_brows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_em_emp_img_brows.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_em_emp_img_brows.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_em_emp_img_brows.Location = New System.Drawing.Point(1531, 249)
        Me.btn_em_emp_img_brows.Name = "btn_em_emp_img_brows"
        Me.btn_em_emp_img_brows.Size = New System.Drawing.Size(79, 33)
        Me.btn_em_emp_img_brows.TabIndex = 14
        Me.btn_em_emp_img_brows.Text = "Brows"
        Me.btn_em_emp_img_brows.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(927, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 25)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Age:-"
        '
        'tb_em_emp_age
        '
        Me.tb_em_emp_age.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_age.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_age.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_age.HintForeColor = System.Drawing.Color.Silver
        Me.tb_em_emp_age.HintText = ""
        Me.tb_em_emp_age.isPassword = False
        Me.tb_em_emp_age.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_age.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_age.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_age.LineThickness = 3
        Me.tb_em_emp_age.Location = New System.Drawing.Point(1002, 238)
        Me.tb_em_emp_age.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_age.Name = "tb_em_emp_age"
        Me.tb_em_emp_age.Size = New System.Drawing.Size(110, 33)
        Me.tb_em_emp_age.TabIndex = 11
        Me.tb_em_emp_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_em_emp_adhar_no
        '
        Me.tb_em_emp_adhar_no.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_adhar_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_adhar_no.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_adhar_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_adhar_no.HintForeColor = System.Drawing.Color.Silver
        Me.tb_em_emp_adhar_no.HintText = "XXXX XXXX XXXX"
        Me.tb_em_emp_adhar_no.isPassword = False
        Me.tb_em_emp_adhar_no.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_adhar_no.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_adhar_no.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_adhar_no.LineThickness = 3
        Me.tb_em_emp_adhar_no.Location = New System.Drawing.Point(866, 173)
        Me.tb_em_emp_adhar_no.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_adhar_no.Name = "tb_em_emp_adhar_no"
        Me.tb_em_emp_adhar_no.Size = New System.Drawing.Size(346, 33)
        Me.tb_em_emp_adhar_no.TabIndex = 8
        Me.tb_em_emp_adhar_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(665, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 25)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Adhar Number :-"
        '
        'pb_em_emp_image
        '
        Me.pb_em_emp_image.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pb_em_emp_image.Location = New System.Drawing.Point(1380, 7)
        Me.pb_em_emp_image.Name = "pb_em_emp_image"
        Me.pb_em_emp_image.Size = New System.Drawing.Size(230, 236)
        Me.pb_em_emp_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_em_emp_image.TabIndex = 99
        Me.pb_em_emp_image.TabStop = False
        '
        'btn_em_search
        '
        Me.btn_em_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_em_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_em_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_em_search.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_em_search.Location = New System.Drawing.Point(559, 4)
        Me.btn_em_search.Name = "btn_em_search"
        Me.btn_em_search.Size = New System.Drawing.Size(98, 33)
        Me.btn_em_search.TabIndex = 98
        Me.btn_em_search.Text = "Search"
        Me.btn_em_search.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1167, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 25)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Employe type: -"
        '
        'cb_em_emp_type
        '
        Me.cb_em_emp_type.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cb_em_emp_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_em_emp_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_em_emp_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_em_emp_type.FormattingEnabled = True
        Me.cb_em_emp_type.Items.AddRange(New Object() {"Administration", "Chef", "Maneger", "Waiter", "Recipationist", ""})
        Me.cb_em_emp_type.Location = New System.Drawing.Point(1339, 307)
        Me.cb_em_emp_type.Name = "cb_em_emp_type"
        Me.cb_em_emp_type.Size = New System.Drawing.Size(256, 28)
        Me.cb_em_emp_type.TabIndex = 13
        '
        'tb_em_emp_mob2
        '
        Me.tb_em_emp_mob2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_mob2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_mob2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_mob2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_mob2.HintForeColor = System.Drawing.Color.DarkGray
        Me.tb_em_emp_mob2.HintText = "Optional number"
        Me.tb_em_emp_mob2.isPassword = False
        Me.tb_em_emp_mob2.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_mob2.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_mob2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_mob2.LineThickness = 3
        Me.tb_em_emp_mob2.Location = New System.Drawing.Point(423, 173)
        Me.tb_em_emp_mob2.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_mob2.Name = "tb_em_emp_mob2"
        Me.tb_em_emp_mob2.Size = New System.Drawing.Size(234, 33)
        Me.tb_em_emp_mob2.TabIndex = 7
        Me.tb_em_emp_mob2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_em_emp_mob1
        '
        Me.tb_em_emp_mob1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_mob1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_mob1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_mob1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_mob1.HintForeColor = System.Drawing.Color.Silver
        Me.tb_em_emp_mob1.HintText = "Permanent number"
        Me.tb_em_emp_mob1.isPassword = False
        Me.tb_em_emp_mob1.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_mob1.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_mob1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_mob1.LineThickness = 3
        Me.tb_em_emp_mob1.Location = New System.Drawing.Point(205, 173)
        Me.tb_em_emp_mob1.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_mob1.Name = "tb_em_emp_mob1"
        Me.tb_em_emp_mob1.Size = New System.Drawing.Size(204, 35)
        Me.tb_em_emp_mob1.TabIndex = 6
        Me.tb_em_emp_mob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 182)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(191, 25)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Mobile Number :-"
        '
        'tb_em_emp_address
        '
        Me.tb_em_emp_address.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_address.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_address.HintForeColor = System.Drawing.Color.Empty
        Me.tb_em_emp_address.HintText = ""
        Me.tb_em_emp_address.isPassword = False
        Me.tb_em_emp_address.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_address.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_address.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_address.LineThickness = 3
        Me.tb_em_emp_address.Location = New System.Drawing.Point(259, 110)
        Me.tb_em_emp_address.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_address.Name = "tb_em_emp_address"
        Me.tb_em_emp_address.Size = New System.Drawing.Size(1089, 42)
        Me.tb_em_emp_address.TabIndex = 5
        Me.tb_em_emp_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(246, 25)
        Me.Label21.TabIndex = 80
        Me.Label21.Text = "Permanant Adderess :-"
        '
        'btn_em_emp_minus
        '
        Me.btn_em_emp_minus.BackColor = System.Drawing.Color.DarkGray
        Me.btn_em_emp_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_em_emp_minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_em_emp_minus.Location = New System.Drawing.Point(122, 300)
        Me.btn_em_emp_minus.Name = "btn_em_emp_minus"
        Me.btn_em_emp_minus.Size = New System.Drawing.Size(49, 35)
        Me.btn_em_emp_minus.TabIndex = 72
        Me.btn_em_emp_minus.Text = "-"
        Me.btn_em_emp_minus.UseVisualStyleBackColor = False
        '
        'btn_em_emp_plus
        '
        Me.btn_em_emp_plus.BackColor = System.Drawing.Color.DarkGray
        Me.btn_em_emp_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_em_emp_plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_em_emp_plus.Location = New System.Drawing.Point(385, 302)
        Me.btn_em_emp_plus.Name = "btn_em_emp_plus"
        Me.btn_em_emp_plus.Size = New System.Drawing.Size(49, 35)
        Me.btn_em_emp_plus.TabIndex = 71
        Me.btn_em_emp_plus.Text = "+"
        Me.btn_em_emp_plus.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 25)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Sallery :-"
        '
        'tb_em_emp_sallery
        '
        Me.tb_em_emp_sallery.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_sallery.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_sallery.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_sallery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_sallery.HintForeColor = System.Drawing.Color.Silver
        Me.tb_em_emp_sallery.HintText = ""
        Me.tb_em_emp_sallery.isPassword = False
        Me.tb_em_emp_sallery.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_sallery.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_sallery.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_sallery.LineThickness = 3
        Me.tb_em_emp_sallery.Location = New System.Drawing.Point(179, 302)
        Me.tb_em_emp_sallery.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_sallery.Name = "tb_em_emp_sallery"
        Me.tb_em_emp_sallery.Size = New System.Drawing.Size(198, 33)
        Me.tb_em_emp_sallery.TabIndex = 12
        Me.tb_em_emp_sallery.Text = "0"
        Me.tb_em_emp_sallery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dtp_em_emp_join
        '
        Me.dtp_em_emp_join.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_em_emp_join.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_em_emp_join.Location = New System.Drawing.Point(620, 253)
        Me.dtp_em_emp_join.Name = "dtp_em_emp_join"
        Me.dtp_em_emp_join.Size = New System.Drawing.Size(260, 30)
        Me.dtp_em_emp_join.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(460, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 25)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Join In Date :-"
        '
        'dtp_em_emp_birthday
        '
        Me.dtp_em_emp_birthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_em_emp_birthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_em_emp_birthday.Location = New System.Drawing.Point(158, 249)
        Me.dtp_em_emp_birthday.Name = "dtp_em_emp_birthday"
        Me.dtp_em_emp_birthday.Size = New System.Drawing.Size(260, 30)
        Me.dtp_em_emp_birthday.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 25)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Birth Date :-"
        '
        'tb_em_emp_surname
        '
        Me.tb_em_emp_surname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_surname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_surname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_surname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_surname.HintForeColor = System.Drawing.Color.Silver
        Me.tb_em_emp_surname.HintText = "Surname"
        Me.tb_em_emp_surname.isPassword = False
        Me.tb_em_emp_surname.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_surname.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_surname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_surname.LineThickness = 3
        Me.tb_em_emp_surname.Location = New System.Drawing.Point(665, 53)
        Me.tb_em_emp_surname.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_surname.Name = "tb_em_emp_surname"
        Me.tb_em_emp_surname.Size = New System.Drawing.Size(240, 33)
        Me.tb_em_emp_surname.TabIndex = 4
        Me.tb_em_emp_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_em_emp_middlename
        '
        Me.tb_em_emp_middlename.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_middlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_middlename.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_middlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_middlename.HintForeColor = System.Drawing.Color.Silver
        Me.tb_em_emp_middlename.HintText = "Middle Nmae"
        Me.tb_em_emp_middlename.isPassword = False
        Me.tb_em_emp_middlename.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_middlename.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_middlename.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_middlename.LineThickness = 3
        Me.tb_em_emp_middlename.Location = New System.Drawing.Point(415, 53)
        Me.tb_em_emp_middlename.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_middlename.Name = "tb_em_emp_middlename"
        Me.tb_em_emp_middlename.Size = New System.Drawing.Size(242, 33)
        Me.tb_em_emp_middlename.TabIndex = 3
        Me.tb_em_emp_middlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Employe Name :"
        '
        'tb_em_emp_name
        '
        Me.tb_em_emp_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_name.HintForeColor = System.Drawing.Color.Silver
        Me.tb_em_emp_name.HintText = "Name"
        Me.tb_em_emp_name.isPassword = False
        Me.tb_em_emp_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_name.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_name.LineThickness = 3
        Me.tb_em_emp_name.Location = New System.Drawing.Point(203, 53)
        Me.tb_em_emp_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_name.Name = "tb_em_emp_name"
        Me.tb_em_emp_name.Size = New System.Drawing.Size(202, 33)
        Me.tb_em_emp_name.TabIndex = 2
        Me.tb_em_emp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 25)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Employe Id:"
        '
        'tb_em_emp_id
        '
        Me.tb_em_emp_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_emp_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_emp_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_em_emp_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_emp_id.HintForeColor = System.Drawing.Color.Empty
        Me.tb_em_emp_id.HintText = ""
        Me.tb_em_emp_id.isPassword = False
        Me.tb_em_emp_id.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_em_emp_id.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_em_emp_id.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_em_emp_id.LineThickness = 3
        Me.tb_em_emp_id.Location = New System.Drawing.Point(158, 4)
        Me.tb_em_emp_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_emp_id.Name = "tb_em_emp_id"
        Me.tb_em_emp_id.Size = New System.Drawing.Size(394, 33)
        Me.tb_em_emp_id.TabIndex = 1
        Me.tb_em_emp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 23)
        Me.Label3.TabIndex = 48
        '
        'btn_em_emp_delete
        '
        Me.btn_em_emp_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_em_emp_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_em_emp_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_em_emp_delete.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_em_emp_delete.Location = New System.Drawing.Point(1046, 492)
        Me.btn_em_emp_delete.Name = "btn_em_emp_delete"
        Me.btn_em_emp_delete.Size = New System.Drawing.Size(180, 44)
        Me.btn_em_emp_delete.TabIndex = 97
        Me.btn_em_emp_delete.Text = "Delete"
        Me.btn_em_emp_delete.UseVisualStyleBackColor = False
        '
        'btn_em_emp_update
        '
        Me.btn_em_emp_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_em_emp_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_em_emp_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_em_emp_update.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_em_emp_update.Location = New System.Drawing.Point(788, 492)
        Me.btn_em_emp_update.Name = "btn_em_emp_update"
        Me.btn_em_emp_update.Size = New System.Drawing.Size(180, 44)
        Me.btn_em_emp_update.TabIndex = 96
        Me.btn_em_emp_update.Text = "Update"
        Me.btn_em_emp_update.UseVisualStyleBackColor = False
        '
        'btn_em_emp_add
        '
        Me.btn_em_emp_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_em_emp_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_em_emp_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_em_emp_add.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_em_emp_add.Location = New System.Drawing.Point(498, 492)
        Me.btn_em_emp_add.Name = "btn_em_emp_add"
        Me.btn_em_emp_add.Size = New System.Drawing.Size(180, 44)
        Me.btn_em_emp_add.TabIndex = 95
        Me.btn_em_emp_add.Text = "Add"
        Me.btn_em_emp_add.UseVisualStyleBackColor = False
        '
        'btn_em_emp_new
        '
        Me.btn_em_emp_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_em_emp_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_em_emp_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_em_emp_new.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_em_emp_new.Location = New System.Drawing.Point(240, 492)
        Me.btn_em_emp_new.Name = "btn_em_emp_new"
        Me.btn_em_emp_new.Size = New System.Drawing.Size(180, 44)
        Me.btn_em_emp_new.TabIndex = 98
        Me.btn_em_emp_new.Text = "New"
        Me.btn_em_emp_new.UseVisualStyleBackColor = False
        '
        'dg_em_emp_grid
        '
        Me.dg_em_emp_grid.AllowUserToAddRows = False
        Me.dg_em_emp_grid.AllowUserToDeleteRows = False
        Me.dg_em_emp_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_em_emp_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_em_emp_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_em_emp_grid.Location = New System.Drawing.Point(14, 551)
        Me.dg_em_emp_grid.Name = "dg_em_emp_grid"
        Me.dg_em_emp_grid.ReadOnly = True
        Me.dg_em_emp_grid.Size = New System.Drawing.Size(1625, 475)
        Me.dg_em_emp_grid.TabIndex = 99
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(28, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_admin_employee_manegement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dg_em_emp_grid)
        Me.Controls.Add(Me.btn_em_emp_new)
        Me.Controls.Add(Me.btn_em_emp_delete)
        Me.Controls.Add(Me.btn_em_emp_update)
        Me.Controls.Add(Me.btn_em_emp_add)
        Me.Controls.Add(Me.Panel_Employee_Management)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_admin_employee_manegement"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Employee_Management.ResumeLayout(False)
        Me.Panel_Employee_Management.PerformLayout()
        CType(Me.pb_em_emp_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_em_emp_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Employee_Management As Panel
    Friend WithEvents tb_em_emp_mob2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_em_emp_mob1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label20 As Label
    Friend WithEvents tb_em_emp_address As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label21 As Label
    Friend WithEvents btn_em_emp_minus As Button
    Friend WithEvents btn_em_emp_plus As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_em_emp_sallery As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dtp_em_emp_join As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtp_em_emp_birthday As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_em_emp_surname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_em_emp_middlename As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_em_emp_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_em_emp_id As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_em_emp_type As ComboBox
    Friend WithEvents btn_em_emp_delete As Button
    Friend WithEvents btn_em_emp_update As Button
    Friend WithEvents btn_em_emp_add As Button
    Friend WithEvents pb_em_emp_image As PictureBox
    Friend WithEvents btn_em_search As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_em_emp_age As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_em_emp_adhar_no As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_em_emp_new As Button
    Friend WithEvents dg_em_emp_grid As DataGridView
    Friend WithEvents btn_em_emp_img_brows As Button
    Friend WithEvents Button1 As Button
End Class
