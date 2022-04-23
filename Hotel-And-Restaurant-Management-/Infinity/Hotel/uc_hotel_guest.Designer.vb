<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_hotel_guest
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_resert_guest = New System.Windows.Forms.Button()
        Me.btn_search_guest = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_gi_guest_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.gb_professional = New System.Windows.Forms.GroupBox()
        Me.tb_gi_Gst = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cb_add_services = New System.Windows.Forms.CheckedListBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.tb_discount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_gi_package_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_gi_room_no = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_gi_room_type = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tb_gi_nights = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_gi_children = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_gi_adults = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_gi_days = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtp_check_out_date = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_check_in_date = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tb_gi_final_amount = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gb_personal = New System.Windows.Forms.GroupBox()
        Me.tb_optmobile_number = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_permobile_number = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_gi_permadd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_gi_sirname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_gi_midname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_gi_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.search_type = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_end = New System.Windows.Forms.DateTimePicker()
        Me.dtp_start = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.cmb_Search_type = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_guest_info = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gb_professional.SuspendLayout()
        Me.gb_personal.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_guest_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Location = New System.Drawing.Point(63, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1586, 46)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(654, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest Information"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 82)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1653, 961)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_resert_guest)
        Me.TabPage1.Controls.Add(Me.btn_search_guest)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.tb_gi_guest_id)
        Me.TabPage1.Controls.Add(Me.gb_professional)
        Me.TabPage1.Controls.Add(Me.gb_personal)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1645, 923)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Guest Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_resert_guest
        '
        Me.btn_resert_guest.BackColor = System.Drawing.Color.Transparent
        Me.btn_resert_guest.BackgroundImage = Global.Infinity.My.Resources.Resources.Reset_32x32
        Me.btn_resert_guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_resert_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resert_guest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resert_guest.Location = New System.Drawing.Point(470, 8)
        Me.btn_resert_guest.Name = "btn_resert_guest"
        Me.btn_resert_guest.Size = New System.Drawing.Size(46, 33)
        Me.btn_resert_guest.TabIndex = 98
        Me.btn_resert_guest.UseVisualStyleBackColor = False
        '
        'btn_search_guest
        '
        Me.btn_search_guest.BackColor = System.Drawing.Color.Transparent
        Me.btn_search_guest.BackgroundImage = Global.Infinity.My.Resources.Resources.Find_32x32
        Me.btn_search_guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_search_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_guest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_guest.Location = New System.Drawing.Point(406, 8)
        Me.btn_search_guest.Name = "btn_search_guest"
        Me.btn_search_guest.Size = New System.Drawing.Size(54, 31)
        Me.btn_search_guest.TabIndex = 97
        Me.btn_search_guest.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 23)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "Guest Id:-"
        '
        'tb_gi_guest_id
        '
        Me.tb_gi_guest_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_guest_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_gi_guest_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_guest_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_gi_guest_id.BorderThickness = 1
        Me.tb_gi_guest_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_guest_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_guest_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_guest_id.isPassword = False
        Me.tb_gi_guest_id.Location = New System.Drawing.Point(131, 7)
        Me.tb_gi_guest_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_guest_id.Name = "tb_gi_guest_id"
        Me.tb_gi_guest_id.Size = New System.Drawing.Size(330, 33)
        Me.tb_gi_guest_id.TabIndex = 96
        Me.tb_gi_guest_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'gb_professional
        '
        Me.gb_professional.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_professional.Controls.Add(Me.tb_gi_Gst)
        Me.gb_professional.Controls.Add(Me.Label18)
        Me.gb_professional.Controls.Add(Me.Label36)
        Me.gb_professional.Controls.Add(Me.cb_add_services)
        Me.gb_professional.Controls.Add(Me.Label35)
        Me.gb_professional.Controls.Add(Me.tb_discount)
        Me.gb_professional.Controls.Add(Me.tb_gi_package_name)
        Me.gb_professional.Controls.Add(Me.tb_gi_room_no)
        Me.gb_professional.Controls.Add(Me.tb_gi_room_type)
        Me.gb_professional.Controls.Add(Me.Label21)
        Me.gb_professional.Controls.Add(Me.tb_gi_nights)
        Me.gb_professional.Controls.Add(Me.Label12)
        Me.gb_professional.Controls.Add(Me.tb_gi_children)
        Me.gb_professional.Controls.Add(Me.Label11)
        Me.gb_professional.Controls.Add(Me.tb_gi_adults)
        Me.gb_professional.Controls.Add(Me.Label13)
        Me.gb_professional.Controls.Add(Me.tb_gi_days)
        Me.gb_professional.Controls.Add(Me.dtp_check_out_date)
        Me.gb_professional.Controls.Add(Me.Label14)
        Me.gb_professional.Controls.Add(Me.dtp_check_in_date)
        Me.gb_professional.Controls.Add(Me.Label15)
        Me.gb_professional.Controls.Add(Me.Label16)
        Me.gb_professional.Controls.Add(Me.tb_gi_final_amount)
        Me.gb_professional.Controls.Add(Me.Label8)
        Me.gb_professional.Controls.Add(Me.Label9)
        Me.gb_professional.Controls.Add(Me.Label10)
        Me.gb_professional.Enabled = False
        Me.gb_professional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_professional.Location = New System.Drawing.Point(6, 337)
        Me.gb_professional.Name = "gb_professional"
        Me.gb_professional.Size = New System.Drawing.Size(1622, 384)
        Me.gb_professional.TabIndex = 18
        Me.gb_professional.TabStop = False
        Me.gb_professional.Text = "Professional Information"
        '
        'tb_gi_Gst
        '
        Me.tb_gi_Gst.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_Gst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_Gst.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_Gst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_Gst.HintForeColor = System.Drawing.Color.Silver
        Me.tb_gi_Gst.HintText = ""
        Me.tb_gi_Gst.isPassword = False
        Me.tb_gi_Gst.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_Gst.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_Gst.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_Gst.LineThickness = 3
        Me.tb_gi_Gst.Location = New System.Drawing.Point(848, 175)
        Me.tb_gi_Gst.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_Gst.Name = "tb_gi_Gst"
        Me.tb_gi_Gst.Size = New System.Drawing.Size(67, 33)
        Me.tb_gi_Gst.TabIndex = 111
        Me.tb_gi_Gst.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(790, 178)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 25)
        Me.Label18.TabIndex = 108
        Me.Label18.Text = "GST :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label36.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(16, 154)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(218, 25)
        Me.Label36.TabIndex = 103
        Me.Label36.Text = "Additional Services :"
        '
        'cb_add_services
        '
        Me.cb_add_services.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_add_services.FormattingEnabled = True
        Me.cb_add_services.Location = New System.Drawing.Point(240, 154)
        Me.cb_add_services.Name = "cb_add_services"
        Me.cb_add_services.Size = New System.Drawing.Size(312, 220)
        Me.cb_add_services.TabIndex = 102
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label35.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(590, 178)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(111, 25)
        Me.Label35.TabIndex = 101
        Me.Label35.Text = "Discount :"
        '
        'tb_discount
        '
        Me.tb_discount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_discount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_discount.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_discount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_discount.HintForeColor = System.Drawing.Color.Silver
        Me.tb_discount.HintText = ""
        Me.tb_discount.isPassword = False
        Me.tb_discount.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_discount.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_discount.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_discount.LineThickness = 3
        Me.tb_discount.Location = New System.Drawing.Point(712, 172)
        Me.tb_discount.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_discount.Name = "tb_discount"
        Me.tb_discount.Size = New System.Drawing.Size(67, 33)
        Me.tb_discount.TabIndex = 100
        Me.tb_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_gi_package_name
        '
        Me.tb_gi_package_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_package_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_package_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_package_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_package_name.HintForeColor = System.Drawing.Color.Empty
        Me.tb_gi_package_name.HintText = ""
        Me.tb_gi_package_name.isPassword = False
        Me.tb_gi_package_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_package_name.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_package_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_package_name.LineThickness = 3
        Me.tb_gi_package_name.Location = New System.Drawing.Point(962, 28)
        Me.tb_gi_package_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_package_name.Name = "tb_gi_package_name"
        Me.tb_gi_package_name.Size = New System.Drawing.Size(338, 34)
        Me.tb_gi_package_name.TabIndex = 97
        Me.tb_gi_package_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_gi_room_no
        '
        Me.tb_gi_room_no.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_room_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_room_no.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_room_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_room_no.HintForeColor = System.Drawing.Color.Empty
        Me.tb_gi_room_no.HintText = ""
        Me.tb_gi_room_no.isPassword = False
        Me.tb_gi_room_no.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_room_no.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_room_no.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_room_no.LineThickness = 3
        Me.tb_gi_room_no.Location = New System.Drawing.Point(129, 26)
        Me.tb_gi_room_no.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_room_no.Name = "tb_gi_room_no"
        Me.tb_gi_room_no.Size = New System.Drawing.Size(90, 34)
        Me.tb_gi_room_no.TabIndex = 96
        Me.tb_gi_room_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_gi_room_type
        '
        Me.tb_gi_room_type.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_room_type.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_room_type.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_room_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_room_type.HintForeColor = System.Drawing.Color.Empty
        Me.tb_gi_room_type.HintText = ""
        Me.tb_gi_room_type.isPassword = False
        Me.tb_gi_room_type.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_room_type.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_room_type.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_room_type.LineThickness = 3
        Me.tb_gi_room_type.Location = New System.Drawing.Point(375, 32)
        Me.tb_gi_room_type.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_room_type.Name = "tb_gi_room_type"
        Me.tb_gi_room_type.Size = New System.Drawing.Size(294, 34)
        Me.tb_gi_room_type.TabIndex = 13
        Me.tb_gi_room_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(157, 98)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 25)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "Nights:"
        '
        'tb_gi_nights
        '
        Me.tb_gi_nights.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_nights.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_nights.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_nights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_nights.HintForeColor = System.Drawing.Color.Silver
        Me.tb_gi_nights.HintText = ""
        Me.tb_gi_nights.isPassword = False
        Me.tb_gi_nights.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_nights.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_nights.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_nights.LineThickness = 3
        Me.tb_gi_nights.Location = New System.Drawing.Point(246, 85)
        Me.tb_gi_nights.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_nights.Name = "tb_gi_nights"
        Me.tb_gi_nights.Size = New System.Drawing.Size(58, 33)
        Me.tb_gi_nights.TabIndex = 94
        Me.tb_gi_nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(480, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 25)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = " Children:"
        '
        'tb_gi_children
        '
        Me.tb_gi_children.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_children.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_children.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_children.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_children.HintForeColor = System.Drawing.Color.Silver
        Me.tb_gi_children.HintText = ""
        Me.tb_gi_children.isPassword = False
        Me.tb_gi_children.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_children.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_children.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_children.LineThickness = 3
        Me.tb_gi_children.Location = New System.Drawing.Point(601, 85)
        Me.tb_gi_children.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_children.Name = "tb_gi_children"
        Me.tb_gi_children.Size = New System.Drawing.Size(64, 33)
        Me.tb_gi_children.TabIndex = 90
        Me.tb_gi_children.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(309, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 25)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Adults:"
        '
        'tb_gi_adults
        '
        Me.tb_gi_adults.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_adults.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_adults.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_adults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_adults.HintForeColor = System.Drawing.Color.Silver
        Me.tb_gi_adults.HintText = ""
        Me.tb_gi_adults.isPassword = False
        Me.tb_gi_adults.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_adults.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_adults.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_adults.LineThickness = 3
        Me.tb_gi_adults.Location = New System.Drawing.Point(407, 85)
        Me.tb_gi_adults.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_adults.Name = "tb_gi_adults"
        Me.tb_gi_adults.Size = New System.Drawing.Size(70, 33)
        Me.tb_gi_adults.TabIndex = 88
        Me.tb_gi_adults.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 25)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "Days:"
        '
        'tb_gi_days
        '
        Me.tb_gi_days.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_days.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_days.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_days.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_days.HintForeColor = System.Drawing.Color.Silver
        Me.tb_gi_days.HintText = ""
        Me.tb_gi_days.isPassword = False
        Me.tb_gi_days.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_days.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_days.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_days.LineThickness = 3
        Me.tb_gi_days.Location = New System.Drawing.Point(89, 85)
        Me.tb_gi_days.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_days.Name = "tb_gi_days"
        Me.tb_gi_days.Size = New System.Drawing.Size(63, 33)
        Me.tb_gi_days.TabIndex = 86
        Me.tb_gi_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dtp_check_out_date
        '
        Me.dtp_check_out_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_check_out_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_check_out_date.Location = New System.Drawing.Point(1016, 125)
        Me.dtp_check_out_date.Name = "dtp_check_out_date"
        Me.dtp_check_out_date.Size = New System.Drawing.Size(277, 26)
        Me.dtp_check_out_date.TabIndex = 85
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(829, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 25)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Check Out Date :"
        '
        'dtp_check_in_date
        '
        Me.dtp_check_in_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_check_in_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_check_in_date.Location = New System.Drawing.Point(1016, 85)
        Me.dtp_check_in_date.Name = "dtp_check_in_date"
        Me.dtp_check_in_date.Size = New System.Drawing.Size(277, 26)
        Me.dtp_check_in_date.TabIndex = 83
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(829, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 25)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Check In Date:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(777, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(185, 25)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Package Name :"
        '
        'tb_gi_final_amount
        '
        Me.tb_gi_final_amount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_final_amount.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_gi_final_amount.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_final_amount.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_gi_final_amount.BorderThickness = 1
        Me.tb_gi_final_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_final_amount.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.tb_gi_final_amount.ForeColor = System.Drawing.Color.Black
        Me.tb_gi_final_amount.isPassword = False
        Me.tb_gi_final_amount.Location = New System.Drawing.Point(765, 264)
        Me.tb_gi_final_amount.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_final_amount.Name = "tb_gi_final_amount"
        Me.tb_gi_final_amount.Size = New System.Drawing.Size(330, 44)
        Me.tb_gi_final_amount.TabIndex = 56
        Me.tb_gi_final_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(591, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 25)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Amount paid :-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 25)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Room No:-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(223, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 25)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Room Type :-"
        '
        'gb_personal
        '
        Me.gb_personal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_personal.Controls.Add(Me.tb_optmobile_number)
        Me.gb_personal.Controls.Add(Me.tb_permobile_number)
        Me.gb_personal.Controls.Add(Me.Label6)
        Me.gb_personal.Controls.Add(Me.tb_gi_permadd)
        Me.gb_personal.Controls.Add(Me.Label5)
        Me.gb_personal.Controls.Add(Me.tb_gi_sirname)
        Me.gb_personal.Controls.Add(Me.Label3)
        Me.gb_personal.Controls.Add(Me.tb_gi_midname)
        Me.gb_personal.Controls.Add(Me.Label2)
        Me.gb_personal.Controls.Add(Me.tb_gi_name)
        Me.gb_personal.Controls.Add(Me.Label4)
        Me.gb_personal.Enabled = False
        Me.gb_personal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_personal.Location = New System.Drawing.Point(3, 51)
        Me.gb_personal.Name = "gb_personal"
        Me.gb_personal.Size = New System.Drawing.Size(1625, 256)
        Me.gb_personal.TabIndex = 17
        Me.gb_personal.TabStop = False
        Me.gb_personal.Text = "Personal Information"
        '
        'tb_optmobile_number
        '
        Me.tb_optmobile_number.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_optmobile_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_optmobile_number.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_optmobile_number.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_optmobile_number.HintForeColor = System.Drawing.Color.DarkGray
        Me.tb_optmobile_number.HintText = "Optional number"
        Me.tb_optmobile_number.isPassword = False
        Me.tb_optmobile_number.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_optmobile_number.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_optmobile_number.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_optmobile_number.LineThickness = 3
        Me.tb_optmobile_number.Location = New System.Drawing.Point(506, 172)
        Me.tb_optmobile_number.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_optmobile_number.Name = "tb_optmobile_number"
        Me.tb_optmobile_number.Size = New System.Drawing.Size(255, 30)
        Me.tb_optmobile_number.TabIndex = 6
        Me.tb_optmobile_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_permobile_number
        '
        Me.tb_permobile_number.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_permobile_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_permobile_number.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_permobile_number.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_permobile_number.HintForeColor = System.Drawing.Color.Silver
        Me.tb_permobile_number.HintText = "Permanent number"
        Me.tb_permobile_number.isPassword = False
        Me.tb_permobile_number.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_permobile_number.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_permobile_number.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_permobile_number.LineThickness = 3
        Me.tb_permobile_number.Location = New System.Drawing.Point(219, 169)
        Me.tb_permobile_number.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_permobile_number.Name = "tb_permobile_number"
        Me.tb_permobile_number.Size = New System.Drawing.Size(242, 33)
        Me.tb_permobile_number.TabIndex = 5
        Me.tb_permobile_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Mobile Number :-"
        '
        'tb_gi_permadd
        '
        Me.tb_gi_permadd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_permadd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_permadd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_permadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_permadd.HintForeColor = System.Drawing.Color.Empty
        Me.tb_gi_permadd.HintText = ""
        Me.tb_gi_permadd.isPassword = False
        Me.tb_gi_permadd.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_permadd.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_permadd.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_permadd.LineThickness = 3
        Me.tb_gi_permadd.Location = New System.Drawing.Point(259, 96)
        Me.tb_gi_permadd.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_permadd.Name = "tb_gi_permadd"
        Me.tb_gi_permadd.Size = New System.Drawing.Size(1311, 38)
        Me.tb_gi_permadd.TabIndex = 4
        Me.tb_gi_permadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Permanant Adderess :-"
        '
        'tb_gi_sirname
        '
        Me.tb_gi_sirname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_sirname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_sirname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_sirname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_sirname.HintForeColor = System.Drawing.Color.Empty
        Me.tb_gi_sirname.HintText = ""
        Me.tb_gi_sirname.isPassword = False
        Me.tb_gi_sirname.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_sirname.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_sirname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_sirname.LineThickness = 3
        Me.tb_gi_sirname.Location = New System.Drawing.Point(965, 20)
        Me.tb_gi_sirname.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_sirname.Name = "tb_gi_sirname"
        Me.tb_gi_sirname.Size = New System.Drawing.Size(269, 36)
        Me.tb_gi_sirname.TabIndex = 3
        Me.tb_gi_sirname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(841, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SurName :-"
        '
        'tb_gi_midname
        '
        Me.tb_gi_midname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_midname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_midname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_midname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_midname.HintForeColor = System.Drawing.Color.Empty
        Me.tb_gi_midname.HintText = ""
        Me.tb_gi_midname.isPassword = False
        Me.tb_gi_midname.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_midname.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_midname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_midname.LineThickness = 3
        Me.tb_gi_midname.Location = New System.Drawing.Point(545, 20)
        Me.tb_gi_midname.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_midname.Name = "tb_gi_midname"
        Me.tb_gi_midname.Size = New System.Drawing.Size(247, 38)
        Me.tb_gi_midname.TabIndex = 2
        Me.tb_gi_midname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Middle Name :-"
        '
        'tb_gi_name
        '
        Me.tb_gi_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_gi_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_gi_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_gi_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_gi_name.HintForeColor = System.Drawing.Color.Empty
        Me.tb_gi_name.HintText = ""
        Me.tb_gi_name.isPassword = False
        Me.tb_gi_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_gi_name.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_gi_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_gi_name.LineThickness = 3
        Me.tb_gi_name.Location = New System.Drawing.Point(114, 20)
        Me.tb_gi_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_gi_name.Name = "tb_gi_name"
        Me.tb_gi_name.Size = New System.Drawing.Size(221, 34)
        Me.tb_gi_name.TabIndex = 1
        Me.tb_gi_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Name :-"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.search_type)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.dtp_end)
        Me.TabPage2.Controls.Add(Me.dtp_start)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.cmb_Search_type)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1645, 923)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guest List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'search_type
        '
        Me.search_type.Location = New System.Drawing.Point(1001, 25)
        Me.search_type.Name = "search_type"
        Me.search_type.Size = New System.Drawing.Size(183, 30)
        Me.search_type.TabIndex = 98
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(156, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 23)
        Me.Label19.TabIndex = 97
        Me.Label19.Text = "From:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(379, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 23)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "To:"
        '
        'dtp_end
        '
        Me.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_end.Location = New System.Drawing.Point(422, 19)
        Me.dtp_end.Name = "dtp_end"
        Me.dtp_end.Size = New System.Drawing.Size(142, 30)
        Me.dtp_end.TabIndex = 95
        '
        'dtp_start
        '
        Me.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_start.Location = New System.Drawing.Point(231, 19)
        Me.dtp_start.Name = "dtp_start"
        Me.dtp_start.Size = New System.Drawing.Size(142, 30)
        Me.dtp_start.TabIndex = 94
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(602, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 23)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "View By :"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkGray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1203, 22)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 32)
        Me.Button8.TabIndex = 92
        Me.Button8.Text = "search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'cmb_Search_type
        '
        Me.cmb_Search_type.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_Search_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_Search_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Search_type.FormattingEnabled = True
        Me.cmb_Search_type.Items.AddRange(New Object() {"Check In ID", "Guest name"})
        Me.cmb_Search_type.Location = New System.Drawing.Point(708, 22)
        Me.cmb_Search_type.Name = "cmb_Search_type"
        Me.cmb_Search_type.Size = New System.Drawing.Size(256, 28)
        Me.cmb_Search_type.TabIndex = 91
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button3.Location = New System.Drawing.Point(6, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 33)
        Me.Button3.TabIndex = 90
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_guest_info)
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1639, 852)
        Me.Panel2.TabIndex = 0
        '
        'dgv_guest_info
        '
        Me.dgv_guest_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_guest_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_guest_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_guest_info.Location = New System.Drawing.Point(0, 3)
        Me.dgv_guest_info.Name = "dgv_guest_info"
        Me.dgv_guest_info.Size = New System.Drawing.Size(1639, 849)
        Me.dgv_guest_info.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(4, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_hotel_guest
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_hotel_guest"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gb_professional.ResumeLayout(False)
        Me.gb_professional.PerformLayout()
        Me.gb_personal.ResumeLayout(False)
        Me.gb_personal.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_guest_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gb_personal As GroupBox
    Friend WithEvents tb_optmobile_number As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_permobile_number As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_gi_permadd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_gi_sirname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_gi_midname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_gi_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents cmb_Search_type As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents gb_professional As GroupBox
    Friend WithEvents tb_gi_final_amount As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_resert_guest As Button
    Friend WithEvents btn_search_guest As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents tb_gi_guest_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label21 As Label
    Friend WithEvents tb_gi_nights As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_gi_children As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_gi_adults As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_gi_days As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dtp_check_out_date As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents dtp_check_in_date As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tb_gi_room_no As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_gi_room_type As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_gi_package_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label35 As Label
    Friend WithEvents tb_discount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label36 As Label
    Friend WithEvents cb_add_services As CheckedListBox
    Friend WithEvents tb_gi_Gst As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label18 As Label
    Friend WithEvents dgv_guest_info As DataGridView
    Friend WithEvents search_type As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_end As DateTimePicker
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
