<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_admin_package_manege
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
        Me.btn_search_pkg = New System.Windows.Forms.Button()
        Me.tb_grand_prize = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_pm_pkg_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.pb_pkg_icon_images = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_pm_pkg_name = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_pm_pkg_nights = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_pm_pkg_days = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pan_pkg_manege_main = New System.Windows.Forms.Panel()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_all_service_cost = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_browse_img = New System.Windows.Forms.Button()
        Me.cmb_valid_for_type = New System.Windows.Forms.ComboBox()
        Me.cmb_pm_pkg_type = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_no = New System.Windows.Forms.RadioButton()
        Me.rb_yes = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtp_last_date = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_create_date = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.clb_services = New System.Windows.Forms.CheckedListBox()
        Me.btn_create_pkg = New System.Windows.Forms.Button()
        Me.tb_pm_pkg_valid_for = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_pkg_discount = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_discount_value = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_pkg_icon_images, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_pkg_manege_main.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(91, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1540, 54)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(606, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Package Manegament"
        '
        'btn_search_pkg
        '
        Me.btn_search_pkg.BackColor = System.Drawing.Color.Transparent
        Me.btn_search_pkg.BackgroundImage = Global.Infinity.My.Resources.Resources.Find_32x32
        Me.btn_search_pkg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_search_pkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_pkg.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_pkg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search_pkg.Location = New System.Drawing.Point(543, 33)
        Me.btn_search_pkg.Name = "btn_search_pkg"
        Me.btn_search_pkg.Size = New System.Drawing.Size(51, 30)
        Me.btn_search_pkg.TabIndex = 22
        Me.btn_search_pkg.UseVisualStyleBackColor = False
        '
        'tb_grand_prize
        '
        Me.tb_grand_prize.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_grand_prize.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_grand_prize.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_grand_prize.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_grand_prize.BorderThickness = 1
        Me.tb_grand_prize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_grand_prize.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_grand_prize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_grand_prize.isPassword = False
        Me.tb_grand_prize.Location = New System.Drawing.Point(792, 857)
        Me.tb_grand_prize.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_grand_prize.Name = "tb_grand_prize"
        Me.tb_grand_prize.Size = New System.Drawing.Size(662, 52)
        Me.tb_grand_prize.TabIndex = 16
        Me.tb_grand_prize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Package Id:-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(662, 871)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 26)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Final Prize:-"
        '
        'tb_pm_pkg_id
        '
        Me.tb_pm_pkg_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pm_pkg_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pm_pkg_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pm_pkg_id.BorderThickness = 1
        Me.tb_pm_pkg_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pm_pkg_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pm_pkg_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_id.isPassword = False
        Me.tb_pm_pkg_id.Location = New System.Drawing.Point(265, 31)
        Me.tb_pm_pkg_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pm_pkg_id.Name = "tb_pm_pkg_id"
        Me.tb_pm_pkg_id.Size = New System.Drawing.Size(330, 33)
        Me.tb_pm_pkg_id.TabIndex = 1
        Me.tb_pm_pkg_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pb_pkg_icon_images
        '
        Me.pb_pkg_icon_images.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pb_pkg_icon_images.Location = New System.Drawing.Point(718, 3)
        Me.pb_pkg_icon_images.Name = "pb_pkg_icon_images"
        Me.pb_pkg_icon_images.Size = New System.Drawing.Size(880, 454)
        Me.pb_pkg_icon_images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_pkg_icon_images.TabIndex = 44
        Me.pb_pkg_icon_images.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(461, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Nights"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 23)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Package Name :-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(327, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 23)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Days"
        '
        'tb_pm_pkg_name
        '
        Me.tb_pm_pkg_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pm_pkg_name.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pm_pkg_name.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_name.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pm_pkg_name.BorderThickness = 1
        Me.tb_pm_pkg_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pm_pkg_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pm_pkg_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_name.isPassword = False
        Me.tb_pm_pkg_name.Location = New System.Drawing.Point(264, 111)
        Me.tb_pm_pkg_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pm_pkg_name.Name = "tb_pm_pkg_name"
        Me.tb_pm_pkg_name.Size = New System.Drawing.Size(330, 33)
        Me.tb_pm_pkg_name.TabIndex = 2
        Me.tb_pm_pkg_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_pm_pkg_nights
        '
        Me.tb_pm_pkg_nights.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pm_pkg_nights.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pm_pkg_nights.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_nights.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pm_pkg_nights.BorderThickness = 1
        Me.tb_pm_pkg_nights.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pm_pkg_nights.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pm_pkg_nights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_nights.isPassword = False
        Me.tb_pm_pkg_nights.Location = New System.Drawing.Point(397, 320)
        Me.tb_pm_pkg_nights.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pm_pkg_nights.Name = "tb_pm_pkg_nights"
        Me.tb_pm_pkg_nights.Size = New System.Drawing.Size(57, 33)
        Me.tb_pm_pkg_nights.TabIndex = 5
        Me.tb_pm_pkg_nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Package Type :-"
        '
        'tb_pm_pkg_days
        '
        Me.tb_pm_pkg_days.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pm_pkg_days.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pm_pkg_days.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_days.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pm_pkg_days.BorderThickness = 1
        Me.tb_pm_pkg_days.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pm_pkg_days.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pm_pkg_days.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_days.isPassword = False
        Me.tb_pm_pkg_days.Location = New System.Drawing.Point(265, 320)
        Me.tb_pm_pkg_days.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pm_pkg_days.Name = "tb_pm_pkg_days"
        Me.tb_pm_pkg_days.Size = New System.Drawing.Size(57, 33)
        Me.tb_pm_pkg_days.TabIndex = 4
        Me.tb_pm_pkg_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 23)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Duration :-"
        '
        'pan_pkg_manege_main
        '
        Me.pan_pkg_manege_main.Controls.Add(Me.Reset)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label17)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_all_service_cost)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label15)
        Me.pan_pkg_manege_main.Controls.Add(Me.btn_browse_img)
        Me.pan_pkg_manege_main.Controls.Add(Me.cmb_valid_for_type)
        Me.pan_pkg_manege_main.Controls.Add(Me.cmb_pm_pkg_type)
        Me.pan_pkg_manege_main.Controls.Add(Me.Panel2)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label16)
        Me.pan_pkg_manege_main.Controls.Add(Me.dtp_last_date)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label14)
        Me.pan_pkg_manege_main.Controls.Add(Me.dtp_create_date)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label13)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label12)
        Me.pan_pkg_manege_main.Controls.Add(Me.clb_services)
        Me.pan_pkg_manege_main.Controls.Add(Me.btn_create_pkg)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_pm_pkg_valid_for)
        Me.pan_pkg_manege_main.Controls.Add(Me.btn_update)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label11)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_pkg_discount)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label10)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_discount_value)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label9)
        Me.pan_pkg_manege_main.Controls.Add(Me.btn_search_pkg)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_grand_prize)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label2)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label8)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_pm_pkg_id)
        Me.pan_pkg_manege_main.Controls.Add(Me.pb_pkg_icon_images)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label7)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label3)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label6)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_pm_pkg_name)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_pm_pkg_nights)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label4)
        Me.pan_pkg_manege_main.Controls.Add(Me.tb_pm_pkg_days)
        Me.pan_pkg_manege_main.Controls.Add(Me.Label5)
        Me.pan_pkg_manege_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pan_pkg_manege_main.Location = New System.Drawing.Point(16, 95)
        Me.pan_pkg_manege_main.Name = "pan_pkg_manege_main"
        Me.pan_pkg_manege_main.Size = New System.Drawing.Size(1615, 934)
        Me.pan_pkg_manege_main.TabIndex = 27
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.Transparent
        Me.Reset.BackgroundImage = Global.Infinity.My.Resources.Resources.Reset_32x32
        Me.Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Reset.Location = New System.Drawing.Point(601, 34)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(51, 30)
        Me.Reset.TabIndex = 71
        Me.Reset.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(866, 813)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 23)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "%"
        '
        'tb_all_service_cost
        '
        Me.tb_all_service_cost.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_all_service_cost.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_all_service_cost.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_all_service_cost.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_all_service_cost.BorderThickness = 1
        Me.tb_all_service_cost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_all_service_cost.Enabled = False
        Me.tb_all_service_cost.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_all_service_cost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_all_service_cost.isPassword = False
        Me.tb_all_service_cost.Location = New System.Drawing.Point(883, 723)
        Me.tb_all_service_cost.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_all_service_cost.Name = "tb_all_service_cost"
        Me.tb_all_service_cost.Size = New System.Drawing.Size(146, 33)
        Me.tb_all_service_cost.TabIndex = 13
        Me.tb_all_service_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(662, 723)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(200, 26)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "All Services Cost:-"
        '
        'btn_browse_img
        '
        Me.btn_browse_img.BackColor = System.Drawing.Color.Black
        Me.btn_browse_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse_img.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse_img.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_browse_img.Location = New System.Drawing.Point(1525, 479)
        Me.btn_browse_img.Name = "btn_browse_img"
        Me.btn_browse_img.Size = New System.Drawing.Size(73, 37)
        Me.btn_browse_img.TabIndex = 67
        Me.btn_browse_img.Text = "Browse"
        Me.btn_browse_img.UseVisualStyleBackColor = False
        '
        'cmb_valid_for_type
        '
        Me.cmb_valid_for_type.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmb_valid_for_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_valid_for_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_valid_for_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_valid_for_type.FormattingEnabled = True
        Me.cmb_valid_for_type.Items.AddRange(New Object() {"Days", "Month", "Year"})
        Me.cmb_valid_for_type.Location = New System.Drawing.Point(921, 489)
        Me.cmb_valid_for_type.Name = "cmb_valid_for_type"
        Me.cmb_valid_for_type.Size = New System.Drawing.Size(136, 33)
        Me.cmb_valid_for_type.TabIndex = 9
        '
        'cmb_pm_pkg_type
        '
        Me.cmb_pm_pkg_type.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmb_pm_pkg_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_pm_pkg_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pm_pkg_type.FormattingEnabled = True
        Me.cmb_pm_pkg_type.Location = New System.Drawing.Point(265, 212)
        Me.cmb_pm_pkg_type.Name = "cmb_pm_pkg_type"
        Me.cmb_pm_pkg_type.Size = New System.Drawing.Size(330, 33)
        Me.cmb_pm_pkg_type.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_no)
        Me.Panel2.Controls.Add(Me.rb_yes)
        Me.Panel2.Location = New System.Drawing.Point(861, 643)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(212, 31)
        Me.Panel2.TabIndex = 11
        '
        'rb_no
        '
        Me.rb_no.AutoSize = True
        Me.rb_no.BackColor = System.Drawing.Color.Transparent
        Me.rb_no.FlatAppearance.BorderSize = 0
        Me.rb_no.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.rb_no.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.rb_no.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rb_no.Location = New System.Drawing.Point(84, 0)
        Me.rb_no.Name = "rb_no"
        Me.rb_no.Size = New System.Drawing.Size(61, 30)
        Me.rb_no.TabIndex = 64
        Me.rb_no.Text = "No"
        Me.rb_no.UseVisualStyleBackColor = False
        '
        'rb_yes
        '
        Me.rb_yes.AutoSize = True
        Me.rb_yes.BackColor = System.Drawing.Color.Transparent
        Me.rb_yes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime
        Me.rb_yes.Location = New System.Drawing.Point(22, 1)
        Me.rb_yes.Name = "rb_yes"
        Me.rb_yes.Size = New System.Drawing.Size(64, 29)
        Me.rb_yes.TabIndex = 63
        Me.rb_yes.Text = "Yes"
        Me.rb_yes.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(662, 564)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 26)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Last Date:-"
        '
        'dtp_last_date
        '
        Me.dtp_last_date.Enabled = False
        Me.dtp_last_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_last_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_last_date.Location = New System.Drawing.Point(798, 564)
        Me.dtp_last_date.Name = "dtp_last_date"
        Me.dtp_last_date.Size = New System.Drawing.Size(342, 30)
        Me.dtp_last_date.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 411)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 23)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Create Date:-"
        '
        'dtp_create_date
        '
        Me.dtp_create_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_create_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_create_date.Location = New System.Drawing.Point(256, 412)
        Me.dtp_create_date.Name = "dtp_create_date"
        Me.dtp_create_date.Size = New System.Drawing.Size(331, 30)
        Me.dtp_create_date.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(662, 644)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(191, 26)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Services Guide :-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 498)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 26)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Services :-"
        '
        'clb_services
        '
        Me.clb_services.CheckOnClick = True
        Me.clb_services.FormattingEnabled = True
        Me.clb_services.Location = New System.Drawing.Point(250, 489)
        Me.clb_services.Name = "clb_services"
        Me.clb_services.Size = New System.Drawing.Size(333, 254)
        Me.clb_services.TabIndex = 7
        Me.clb_services.ThreeDCheckBoxes = True
        '
        'btn_create_pkg
        '
        Me.btn_create_pkg.BackColor = System.Drawing.Color.Black
        Me.btn_create_pkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create_pkg.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_pkg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_create_pkg.Location = New System.Drawing.Point(11, 863)
        Me.btn_create_pkg.Name = "btn_create_pkg"
        Me.btn_create_pkg.Size = New System.Drawing.Size(177, 51)
        Me.btn_create_pkg.TabIndex = 28
        Me.btn_create_pkg.Text = "Create"
        Me.btn_create_pkg.UseVisualStyleBackColor = False
        '
        'tb_pm_pkg_valid_for
        '
        Me.tb_pm_pkg_valid_for.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pm_pkg_valid_for.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pm_pkg_valid_for.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_valid_for.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pm_pkg_valid_for.BorderThickness = 1
        Me.tb_pm_pkg_valid_for.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pm_pkg_valid_for.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pm_pkg_valid_for.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pm_pkg_valid_for.isPassword = False
        Me.tb_pm_pkg_valid_for.Location = New System.Drawing.Point(798, 489)
        Me.tb_pm_pkg_valid_for.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pm_pkg_valid_for.Name = "tb_pm_pkg_valid_for"
        Me.tb_pm_pkg_valid_for.Size = New System.Drawing.Size(95, 33)
        Me.tb_pm_pkg_valid_for.TabIndex = 8
        Me.tb_pm_pkg_valid_for.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Black
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_update.Location = New System.Drawing.Point(265, 863)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(173, 46)
        Me.btn_update.TabIndex = 29
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(662, 490)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 26)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Valid For :-"
        '
        'tb_pkg_discount
        '
        Me.tb_pkg_discount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pkg_discount.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pkg_discount.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_discount.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pkg_discount.BorderThickness = 1
        Me.tb_pkg_discount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pkg_discount.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pkg_discount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_discount.isPassword = False
        Me.tb_pkg_discount.Location = New System.Drawing.Point(250, 801)
        Me.tb_pkg_discount.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pkg_discount.Name = "tb_pkg_discount"
        Me.tb_pkg_discount.Size = New System.Drawing.Size(330, 33)
        Me.tb_pkg_discount.TabIndex = 15
        Me.tb_pkg_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 801)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 26)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Discount  Name:-"
        '
        'tb_discount_value
        '
        Me.tb_discount_value.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_discount_value.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_discount_value.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_discount_value.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_discount_value.BorderThickness = 1
        Me.tb_discount_value.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_discount_value.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_discount_value.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_discount_value.isPassword = False
        Me.tb_discount_value.Location = New System.Drawing.Point(815, 808)
        Me.tb_discount_value.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_discount_value.Name = "tb_discount_value"
        Me.tb_discount_value.Size = New System.Drawing.Size(50, 33)
        Me.tb_discount_value.TabIndex = 14
        Me.tb_discount_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(662, 808)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 26)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Discount  :-"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(27, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_admin_package_manege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pan_pkg_manege_main)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_admin_package_manege"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_pkg_icon_images, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_pkg_manege_main.ResumeLayout(False)
        Me.pan_pkg_manege_main.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search_pkg As Button
    Friend WithEvents tb_grand_prize As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_pm_pkg_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents pb_pkg_icon_images As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_pm_pkg_name As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_pm_pkg_nights As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_pm_pkg_days As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents pan_pkg_manege_main As Panel
    Friend WithEvents tb_pm_pkg_valid_for As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_pkg_discount As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_discount_value As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents clb_services As CheckedListBox
    Friend WithEvents btn_create_pkg As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dtp_last_date As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents dtp_create_date As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents rb_yes As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rb_no As RadioButton
    Friend WithEvents cmb_pm_pkg_type As ComboBox
    Friend WithEvents cmb_valid_for_type As ComboBox
    Friend WithEvents btn_browse_img As Button
    Friend WithEvents tb_all_service_cost As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Reset As Button
    Friend WithEvents Button1 As Button
End Class
