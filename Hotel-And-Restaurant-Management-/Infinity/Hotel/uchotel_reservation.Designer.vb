<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uchotel_reservation
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tb_rm_advance_payment = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_rm_total_amount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_rm_discount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cmb_rm_discount_name = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_end = New System.Windows.Forms.DateTimePicker()
        Me.dtp_start = New System.Windows.Forms.DateTimePicker()
        Me.btn_grid_Search = New System.Windows.Forms.Button()
        Me.tb_search_type = New System.Windows.Forms.TextBox()
        Me.cmb_search_type = New System.Windows.Forms.ComboBox()
        Me.btn_rm_grid_refresh = New System.Windows.Forms.Button()
        Me.dgv_rm_grid = New System.Windows.Forms.DataGridView()
        Me.tb_rm_sub_total = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_rm_book_reservation = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_rm_pkg_name = New System.Windows.Forms.ComboBox()
        Me.pan_balence_info = New System.Windows.Forms.Panel()
        Me.cb_apply_discount = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pan_main_reservation = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tb_rm_no_of_nights = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_optmobile_number = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_permobile_number = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tb_rm_permadd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_rm_childrens = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_rm_adults = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_rm_no_of_days = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtp_rm_check_in_date = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtp_rm_res_date = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_rm_surname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tb_rm_middlename = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_rm_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_rm_rid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_rm_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_balence_info.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pan_main_reservation.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_rm_advance_payment
        '
        Me.tb_rm_advance_payment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_advance_payment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_advance_payment.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_advance_payment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_advance_payment.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_advance_payment.HintText = ""
        Me.tb_rm_advance_payment.isPassword = False
        Me.tb_rm_advance_payment.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_advance_payment.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_advance_payment.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_advance_payment.LineThickness = 3
        Me.tb_rm_advance_payment.Location = New System.Drawing.Point(685, 83)
        Me.tb_rm_advance_payment.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_advance_payment.Name = "tb_rm_advance_payment"
        Me.tb_rm_advance_payment.Size = New System.Drawing.Size(388, 33)
        Me.tb_rm_advance_payment.TabIndex = 65
        Me.tb_rm_advance_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_rm_total_amount
        '
        Me.tb_rm_total_amount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_total_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_total_amount.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_total_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_total_amount.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_total_amount.HintText = ""
        Me.tb_rm_total_amount.isPassword = False
        Me.tb_rm_total_amount.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_total_amount.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_total_amount.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_total_amount.LineThickness = 3
        Me.tb_rm_total_amount.Location = New System.Drawing.Point(685, 11)
        Me.tb_rm_total_amount.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_total_amount.Name = "tb_rm_total_amount"
        Me.tb_rm_total_amount.Size = New System.Drawing.Size(388, 33)
        Me.tb_rm_total_amount.TabIndex = 63
        Me.tb_rm_total_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 25)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Discount :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(463, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(158, 25)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Total Amount :"
        '
        'tb_rm_discount
        '
        Me.tb_rm_discount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_discount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_discount.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_discount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_discount.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_discount.HintText = ""
        Me.tb_rm_discount.isPassword = False
        Me.tb_rm_discount.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_discount.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_discount.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_discount.LineThickness = 3
        Me.tb_rm_discount.Location = New System.Drawing.Point(113, 141)
        Me.tb_rm_discount.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_discount.Name = "tb_rm_discount"
        Me.tb_rm_discount.Size = New System.Drawing.Size(66, 33)
        Me.tb_rm_discount.TabIndex = 57
        Me.tb_rm_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmb_rm_discount_name
        '
        Me.cmb_rm_discount_name.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_rm_discount_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_rm_discount_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_rm_discount_name.FormattingEnabled = True
        Me.cmb_rm_discount_name.Location = New System.Drawing.Point(196, 87)
        Me.cmb_rm_discount_name.Name = "cmb_rm_discount_name"
        Me.cmb_rm_discount_name.Size = New System.Drawing.Size(240, 28)
        Me.cmb_rm_discount_name.TabIndex = 56
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.dtp_end)
        Me.TabPage2.Controls.Add(Me.dtp_start)
        Me.TabPage2.Controls.Add(Me.btn_grid_Search)
        Me.TabPage2.Controls.Add(Me.tb_search_type)
        Me.TabPage2.Controls.Add(Me.cmb_search_type)
        Me.TabPage2.Controls.Add(Me.btn_rm_grid_refresh)
        Me.TabPage2.Controls.Add(Me.dgv_rm_grid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1634, 896)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resarvation List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "From:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(404, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 23)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "To:"
        '
        'dtp_end
        '
        Me.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_end.Location = New System.Drawing.Point(447, 29)
        Me.dtp_end.Name = "dtp_end"
        Me.dtp_end.Size = New System.Drawing.Size(142, 32)
        Me.dtp_end.TabIndex = 99
        '
        'dtp_start
        '
        Me.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_start.Location = New System.Drawing.Point(256, 29)
        Me.dtp_start.Name = "dtp_start"
        Me.dtp_start.Size = New System.Drawing.Size(142, 32)
        Me.dtp_start.TabIndex = 98
        '
        'btn_grid_Search
        '
        Me.btn_grid_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_grid_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grid_Search.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_grid_Search.Location = New System.Drawing.Point(1181, 28)
        Me.btn_grid_Search.Name = "btn_grid_Search"
        Me.btn_grid_Search.Size = New System.Drawing.Size(135, 33)
        Me.btn_grid_Search.TabIndex = 80
        Me.btn_grid_Search.Text = "Search"
        Me.btn_grid_Search.UseVisualStyleBackColor = False
        '
        'tb_search_type
        '
        Me.tb_search_type.Location = New System.Drawing.Point(936, 28)
        Me.tb_search_type.Name = "tb_search_type"
        Me.tb_search_type.Size = New System.Drawing.Size(213, 32)
        Me.tb_search_type.TabIndex = 79
        '
        'cmb_search_type
        '
        Me.cmb_search_type.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_search_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_search_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_search_type.FormattingEnabled = True
        Me.cmb_search_type.Location = New System.Drawing.Point(636, 28)
        Me.cmb_search_type.Name = "cmb_search_type"
        Me.cmb_search_type.Size = New System.Drawing.Size(240, 28)
        Me.cmb_search_type.TabIndex = 78
        '
        'btn_rm_grid_refresh
        '
        Me.btn_rm_grid_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_rm_grid_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rm_grid_refresh.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_rm_grid_refresh.Location = New System.Drawing.Point(19, 28)
        Me.btn_rm_grid_refresh.Name = "btn_rm_grid_refresh"
        Me.btn_rm_grid_refresh.Size = New System.Drawing.Size(135, 33)
        Me.btn_rm_grid_refresh.TabIndex = 76
        Me.btn_rm_grid_refresh.Text = "Refresh"
        Me.btn_rm_grid_refresh.UseVisualStyleBackColor = False
        '
        'dgv_rm_grid
        '
        Me.dgv_rm_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_rm_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_rm_grid.Location = New System.Drawing.Point(0, 86)
        Me.dgv_rm_grid.Name = "dgv_rm_grid"
        Me.dgv_rm_grid.Size = New System.Drawing.Size(1631, 807)
        Me.dgv_rm_grid.TabIndex = 73
        '
        'tb_rm_sub_total
        '
        Me.tb_rm_sub_total.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_sub_total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_sub_total.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_sub_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_sub_total.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_sub_total.HintText = ""
        Me.tb_rm_sub_total.isPassword = False
        Me.tb_rm_sub_total.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_sub_total.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_sub_total.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_sub_total.LineThickness = 3
        Me.tb_rm_sub_total.Location = New System.Drawing.Point(681, 149)
        Me.tb_rm_sub_total.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_sub_total.Name = "tb_rm_sub_total"
        Me.tb_rm_sub_total.Size = New System.Drawing.Size(392, 31)
        Me.tb_rm_sub_total.TabIndex = 67
        Me.tb_rm_sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(463, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(215, 25)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Advance Payment :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 25)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Discount Name:"
        '
        'btn_rm_book_reservation
        '
        Me.btn_rm_book_reservation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_rm_book_reservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_rm_book_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rm_book_reservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rm_book_reservation.ForeColor = System.Drawing.Color.White
        Me.btn_rm_book_reservation.Location = New System.Drawing.Point(1030, 224)
        Me.btn_rm_book_reservation.Name = "btn_rm_book_reservation"
        Me.btn_rm_book_reservation.Size = New System.Drawing.Size(180, 59)
        Me.btn_rm_book_reservation.TabIndex = 69
        Me.btn_rm_book_reservation.Text = "Book"
        Me.btn_rm_book_reservation.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(463, 157)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 25)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Sub Total :"
        '
        'cmb_rm_pkg_name
        '
        Me.cmb_rm_pkg_name.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_rm_pkg_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_rm_pkg_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_rm_pkg_name.FormattingEnabled = True
        Me.cmb_rm_pkg_name.Location = New System.Drawing.Point(196, 15)
        Me.cmb_rm_pkg_name.Name = "cmb_rm_pkg_name"
        Me.cmb_rm_pkg_name.Size = New System.Drawing.Size(240, 28)
        Me.cmb_rm_pkg_name.TabIndex = 71
        '
        'pan_balence_info
        '
        Me.pan_balence_info.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pan_balence_info.Controls.Add(Me.cb_apply_discount)
        Me.pan_balence_info.Controls.Add(Me.cmb_rm_pkg_name)
        Me.pan_balence_info.Controls.Add(Me.Label15)
        Me.pan_balence_info.Controls.Add(Me.btn_rm_book_reservation)
        Me.pan_balence_info.Controls.Add(Me.Label19)
        Me.pan_balence_info.Controls.Add(Me.tb_rm_sub_total)
        Me.pan_balence_info.Controls.Add(Me.Label18)
        Me.pan_balence_info.Controls.Add(Me.tb_rm_advance_payment)
        Me.pan_balence_info.Controls.Add(Me.Label17)
        Me.pan_balence_info.Controls.Add(Me.tb_rm_total_amount)
        Me.pan_balence_info.Controls.Add(Me.Label14)
        Me.pan_balence_info.Controls.Add(Me.tb_rm_discount)
        Me.pan_balence_info.Controls.Add(Me.cmb_rm_discount_name)
        Me.pan_balence_info.Controls.Add(Me.Label13)
        Me.pan_balence_info.Location = New System.Drawing.Point(6, 464)
        Me.pan_balence_info.Name = "pan_balence_info"
        Me.pan_balence_info.Size = New System.Drawing.Size(1625, 304)
        Me.pan_balence_info.TabIndex = 60
        '
        'cb_apply_discount
        '
        Me.cb_apply_discount.AutoSize = True
        Me.cb_apply_discount.Location = New System.Drawing.Point(185, 160)
        Me.cb_apply_discount.Name = "cb_apply_discount"
        Me.cb_apply_discount.Size = New System.Drawing.Size(15, 14)
        Me.cb_apply_discount.TabIndex = 72
        Me.cb_apply_discount.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(185, 25)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Package Name :"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pan_main_reservation)
        Me.TabPage1.Controls.Add(Me.pan_balence_info)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1634, 896)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resarvation Form"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pan_main_reservation
        '
        Me.pan_main_reservation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pan_main_reservation.Controls.Add(Me.Label22)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_no_of_nights)
        Me.pan_main_reservation.Controls.Add(Me.tb_optmobile_number)
        Me.pan_main_reservation.Controls.Add(Me.tb_permobile_number)
        Me.pan_main_reservation.Controls.Add(Me.Label20)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_permadd)
        Me.pan_main_reservation.Controls.Add(Me.Label21)
        Me.pan_main_reservation.Controls.Add(Me.Button5)
        Me.pan_main_reservation.Controls.Add(Me.Button6)
        Me.pan_main_reservation.Controls.Add(Me.Button4)
        Me.pan_main_reservation.Controls.Add(Me.Button3)
        Me.pan_main_reservation.Controls.Add(Me.Label12)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_childrens)
        Me.pan_main_reservation.Controls.Add(Me.Label11)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_adults)
        Me.pan_main_reservation.Controls.Add(Me.Label10)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_no_of_days)
        Me.pan_main_reservation.Controls.Add(Me.dtp_rm_check_in_date)
        Me.pan_main_reservation.Controls.Add(Me.Label9)
        Me.pan_main_reservation.Controls.Add(Me.dtp_rm_res_date)
        Me.pan_main_reservation.Controls.Add(Me.Label8)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_surname)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_middlename)
        Me.pan_main_reservation.Controls.Add(Me.Label5)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_name)
        Me.pan_main_reservation.Controls.Add(Me.Label4)
        Me.pan_main_reservation.Controls.Add(Me.tb_rm_rid)
        Me.pan_main_reservation.Controls.Add(Me.Label3)
        Me.pan_main_reservation.Location = New System.Drawing.Point(6, 3)
        Me.pan_main_reservation.Name = "pan_main_reservation"
        Me.pan_main_reservation.Size = New System.Drawing.Size(1625, 426)
        Me.pan_main_reservation.TabIndex = 59
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(328, 371)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 25)
        Me.Label22.TabIndex = 83
        Me.Label22.Text = "Nights :"
        '
        'tb_rm_no_of_nights
        '
        Me.tb_rm_no_of_nights.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_no_of_nights.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_no_of_nights.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_no_of_nights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_no_of_nights.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_no_of_nights.HintText = ""
        Me.tb_rm_no_of_nights.isPassword = False
        Me.tb_rm_no_of_nights.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_no_of_nights.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_no_of_nights.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_no_of_nights.LineThickness = 3
        Me.tb_rm_no_of_nights.Location = New System.Drawing.Point(416, 364)
        Me.tb_rm_no_of_nights.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_no_of_nights.Name = "tb_rm_no_of_nights"
        Me.tb_rm_no_of_nights.Size = New System.Drawing.Size(83, 33)
        Me.tb_rm_no_of_nights.TabIndex = 82
        Me.tb_rm_no_of_nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.tb_optmobile_number.Location = New System.Drawing.Point(490, 207)
        Me.tb_optmobile_number.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_optmobile_number.Name = "tb_optmobile_number"
        Me.tb_optmobile_number.Size = New System.Drawing.Size(239, 31)
        Me.tb_optmobile_number.TabIndex = 79
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
        Me.tb_permobile_number.Location = New System.Drawing.Point(222, 206)
        Me.tb_permobile_number.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_permobile_number.Name = "tb_permobile_number"
        Me.tb_permobile_number.Size = New System.Drawing.Size(227, 33)
        Me.tb_permobile_number.TabIndex = 78
        Me.tb_permobile_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 206)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(191, 25)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Mobile Number :-"
        '
        'tb_rm_permadd
        '
        Me.tb_rm_permadd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_permadd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_permadd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_permadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_permadd.HintForeColor = System.Drawing.Color.Empty
        Me.tb_rm_permadd.HintText = ""
        Me.tb_rm_permadd.isPassword = False
        Me.tb_rm_permadd.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_permadd.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_permadd.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_permadd.LineThickness = 3
        Me.tb_rm_permadd.Location = New System.Drawing.Point(268, 124)
        Me.tb_rm_permadd.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_permadd.Name = "tb_rm_permadd"
        Me.tb_rm_permadd.Size = New System.Drawing.Size(1334, 35)
        Me.tb_rm_permadd.TabIndex = 77
        Me.tb_rm_permadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 134)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(246, 25)
        Me.Label21.TabIndex = 80
        Me.Label21.Text = "Permanant Adderess :-"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkGray
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(593, 359)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(46, 36)
        Me.Button5.TabIndex = 72
        Me.Button5.Text = "-"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkGray
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(734, 359)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 36)
        Me.Button6.TabIndex = 71
        Me.Button6.Text = "+"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(992, 362)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 36)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1135, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 36)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(822, 371)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 25)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "No of Children:"
        '
        'tb_rm_childrens
        '
        Me.tb_rm_childrens.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_childrens.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_childrens.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_childrens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_childrens.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_childrens.HintText = ""
        Me.tb_rm_childrens.isPassword = False
        Me.tb_rm_childrens.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_childrens.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_childrens.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_childrens.LineThickness = 3
        Me.tb_rm_childrens.Location = New System.Drawing.Point(1045, 362)
        Me.tb_rm_childrens.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_childrens.Name = "tb_rm_childrens"
        Me.tb_rm_childrens.Size = New System.Drawing.Size(83, 33)
        Me.tb_rm_childrens.TabIndex = 67
        Me.tb_rm_childrens.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(506, 371)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 25)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Adults:"
        '
        'tb_rm_adults
        '
        Me.tb_rm_adults.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_adults.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_adults.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_adults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_adults.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_adults.HintText = ""
        Me.tb_rm_adults.isPassword = False
        Me.tb_rm_adults.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_adults.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_adults.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_adults.LineThickness = 3
        Me.tb_rm_adults.Location = New System.Drawing.Point(644, 361)
        Me.tb_rm_adults.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_adults.Name = "tb_rm_adults"
        Me.tb_rm_adults.Size = New System.Drawing.Size(83, 33)
        Me.tb_rm_adults.TabIndex = 65
        Me.tb_rm_adults.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(187, 25)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Number Of Days:"
        '
        'tb_rm_no_of_days
        '
        Me.tb_rm_no_of_days.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_no_of_days.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_no_of_days.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_no_of_days.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_no_of_days.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_no_of_days.HintText = ""
        Me.tb_rm_no_of_days.isPassword = False
        Me.tb_rm_no_of_days.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_no_of_days.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_no_of_days.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_no_of_days.LineThickness = 3
        Me.tb_rm_no_of_days.Location = New System.Drawing.Point(213, 365)
        Me.tb_rm_no_of_days.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_no_of_days.Name = "tb_rm_no_of_days"
        Me.tb_rm_no_of_days.Size = New System.Drawing.Size(83, 33)
        Me.tb_rm_no_of_days.TabIndex = 63
        Me.tb_rm_no_of_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dtp_rm_check_in_date
        '
        Me.dtp_rm_check_in_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rm_check_in_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_rm_check_in_date.Location = New System.Drawing.Point(788, 288)
        Me.dtp_rm_check_in_date.Name = "dtp_rm_check_in_date"
        Me.dtp_rm_check_in_date.Size = New System.Drawing.Size(244, 26)
        Me.dtp_rm_check_in_date.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(508, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(274, 25)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Estimated Check In Date :"
        '
        'dtp_rm_res_date
        '
        Me.dtp_rm_res_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rm_res_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_rm_res_date.Location = New System.Drawing.Point(234, 288)
        Me.dtp_rm_res_date.Name = "dtp_rm_res_date"
        Me.dtp_rm_res_date.Size = New System.Drawing.Size(244, 26)
        Me.dtp_rm_res_date.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 25)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Resarvation Date:"
        '
        'tb_rm_surname
        '
        Me.tb_rm_surname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_surname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_surname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_surname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_surname.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_surname.HintText = "Surname"
        Me.tb_rm_surname.isPassword = False
        Me.tb_rm_surname.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_surname.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_surname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_surname.LineThickness = 3
        Me.tb_rm_surname.Location = New System.Drawing.Point(883, 67)
        Me.tb_rm_surname.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_surname.Name = "tb_rm_surname"
        Me.tb_rm_surname.Size = New System.Drawing.Size(435, 33)
        Me.tb_rm_surname.TabIndex = 54
        Me.tb_rm_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_rm_middlename
        '
        Me.tb_rm_middlename.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_middlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_middlename.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_middlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_middlename.HintForeColor = System.Drawing.Color.Gray
        Me.tb_rm_middlename.HintText = "Middle Name"
        Me.tb_rm_middlename.isPassword = False
        Me.tb_rm_middlename.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_middlename.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_middlename.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_middlename.LineThickness = 3
        Me.tb_rm_middlename.Location = New System.Drawing.Point(457, 67)
        Me.tb_rm_middlename.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_middlename.Name = "tb_rm_middlename"
        Me.tb_rm_middlename.Size = New System.Drawing.Size(414, 33)
        Me.tb_rm_middlename.TabIndex = 53
        Me.tb_rm_middlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Guest Name :"
        '
        'tb_rm_name
        '
        Me.tb_rm_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_name.HintForeColor = System.Drawing.Color.Silver
        Me.tb_rm_name.HintText = "Name"
        Me.tb_rm_name.isPassword = False
        Me.tb_rm_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_name.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_name.LineThickness = 3
        Me.tb_rm_name.Location = New System.Drawing.Point(175, 67)
        Me.tb_rm_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_name.Name = "tb_rm_name"
        Me.tb_rm_name.Size = New System.Drawing.Size(274, 33)
        Me.tb_rm_name.TabIndex = 51
        Me.tb_rm_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 25)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Reservation Id:"
        '
        'tb_rm_rid
        '
        Me.tb_rm_rid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_rm_rid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_rm_rid.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_rm_rid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_rm_rid.HintForeColor = System.Drawing.Color.Empty
        Me.tb_rm_rid.HintText = ""
        Me.tb_rm_rid.isPassword = False
        Me.tb_rm_rid.LineFocusedColor = System.Drawing.Color.Blue
        Me.tb_rm_rid.LineIdleColor = System.Drawing.Color.Gray
        Me.tb_rm_rid.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.tb_rm_rid.LineThickness = 3
        Me.tb_rm_rid.Location = New System.Drawing.Point(176, 4)
        Me.tb_rm_rid.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_rm_rid.Name = "tb_rm_rid"
        Me.tb_rm_rid.Size = New System.Drawing.Size(282, 33)
        Me.tb_rm_rid.TabIndex = 49
        Me.tb_rm_rid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 23)
        Me.Label3.TabIndex = 48
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 97)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1642, 932)
        Me.TabControl1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(85, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1552, 55)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(703, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservation "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(18, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uchotel_reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "uchotel_reservation"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_rm_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_balence_info.ResumeLayout(False)
        Me.pan_balence_info.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.pan_main_reservation.ResumeLayout(False)
        Me.pan_main_reservation.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tb_rm_advance_payment As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_rm_total_amount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tb_rm_discount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cmb_rm_discount_name As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_rm_grid_refresh As Button
    Friend WithEvents dgv_rm_grid As DataGridView
    Friend WithEvents tb_rm_sub_total As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_rm_book_reservation As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents cmb_rm_pkg_name As ComboBox
    Friend WithEvents pan_balence_info As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pan_main_reservation As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_rm_childrens As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_rm_adults As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_rm_no_of_days As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dtp_rm_check_in_date As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtp_rm_res_date As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_rm_surname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_rm_middlename As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_rm_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_rm_rid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents tb_rm_no_of_nights As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_optmobile_number As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tb_permobile_number As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label20 As Label
    Friend WithEvents tb_rm_permadd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label21 As Label
    Friend WithEvents btn_grid_Search As Button
    Friend WithEvents tb_search_type As TextBox
    Friend WithEvents cmb_search_type As ComboBox
    Friend WithEvents cb_apply_discount As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_end As DateTimePicker
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
