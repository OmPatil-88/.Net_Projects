<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucr_stock
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
        Me.btn_upload_bill = New System.Windows.Forms.Button()
        Me.tb_paid_amount = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_time = New System.Windows.Forms.DateTimePicker()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.tb_emp_name = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_stock_bill_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_emp_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_import = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_add_new_bill = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dg_sm_view = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pan_main_stock = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_stock_type = New System.Windows.Forms.ComboBox()
        Me.tb_dm_delear_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_reset_panel = New System.Windows.Forms.Button()
        Me.pb_bill_img = New System.Windows.Forms.PictureBox()
        Me.btn_search_id = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp_end = New System.Windows.Forms.DateTimePicker()
        Me.dtp_start = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.dg_sm_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pan_main_stock.SuspendLayout()
        CType(Me.pb_bill_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_upload_bill
        '
        Me.btn_upload_bill.BackColor = System.Drawing.Color.Black
        Me.btn_upload_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upload_bill.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upload_bill.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_upload_bill.Location = New System.Drawing.Point(864, 14)
        Me.btn_upload_bill.Name = "btn_upload_bill"
        Me.btn_upload_bill.Size = New System.Drawing.Size(93, 37)
        Me.btn_upload_bill.TabIndex = 6
        Me.btn_upload_bill.Text = "Upload"
        Me.btn_upload_bill.UseVisualStyleBackColor = False
        '
        'tb_paid_amount
        '
        Me.tb_paid_amount.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_paid_amount.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_paid_amount.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_paid_amount.BorderThickness = 1
        Me.tb_paid_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_paid_amount.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.tb_paid_amount.ForeColor = System.Drawing.Color.Red
        Me.tb_paid_amount.isPassword = False
        Me.tb_paid_amount.Location = New System.Drawing.Point(423, 219)
        Me.tb_paid_amount.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.tb_paid_amount.Name = "tb_paid_amount"
        Me.tb_paid_amount.Size = New System.Drawing.Size(288, 53)
        Me.tb_paid_amount.TabIndex = 7
        Me.tb_paid_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1220, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 23)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Bill Image "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(386, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Time:-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Date :-"
        '
        'dtp_time
        '
        Me.dtp_time.CalendarForeColor = System.Drawing.Color.White
        Me.dtp_time.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtp_time.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_time.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dtp_time.Enabled = False
        Me.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_time.Location = New System.Drawing.Point(461, 102)
        Me.dtp_time.Name = "dtp_time"
        Me.dtp_time.Size = New System.Drawing.Size(206, 20)
        Me.dtp_time.TabIndex = 40
        '
        'dtp_date
        '
        Me.dtp_date.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.dtp_date.Enabled = False
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(100, 106)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(206, 20)
        Me.dtp_date.TabIndex = 39
        '
        'tb_emp_name
        '
        Me.tb_emp_name.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_emp_name.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_emp_name.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_emp_name.BorderThickness = 1
        Me.tb_emp_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_emp_name.Enabled = False
        Me.tb_emp_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_emp_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_emp_name.isPassword = False
        Me.tb_emp_name.Location = New System.Drawing.Point(266, 50)
        Me.tb_emp_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_emp_name.Name = "tb_emp_name"
        Me.tb_emp_name.Size = New System.Drawing.Size(312, 28)
        Me.tb_emp_name.TabIndex = 37
        Me.tb_emp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(656, 424)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 37)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 23)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Amount Paid"
        '
        'tb_stock_bill_id
        '
        Me.tb_stock_bill_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_stock_bill_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_stock_bill_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_stock_bill_id.BorderThickness = 1
        Me.tb_stock_bill_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_stock_bill_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_stock_bill_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_stock_bill_id.isPassword = False
        Me.tb_stock_bill_id.Location = New System.Drawing.Point(167, 12)
        Me.tb_stock_bill_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_stock_bill_id.Name = "tb_stock_bill_id"
        Me.tb_stock_bill_id.Size = New System.Drawing.Size(412, 28)
        Me.tb_stock_bill_id.TabIndex = 1
        Me.tb_stock_bill_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_emp_id
        '
        Me.tb_emp_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_emp_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_emp_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_emp_id.BorderThickness = 1
        Me.tb_emp_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_emp_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_emp_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_emp_id.isPassword = False
        Me.tb_emp_id.Location = New System.Drawing.Point(167, 50)
        Me.tb_emp_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_emp_id.Name = "tb_emp_id"
        Me.tb_emp_id.Size = New System.Drawing.Size(71, 28)
        Me.tb_emp_id.TabIndex = 2
        Me.tb_emp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 23)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Stock Bill Id :-"
        '
        'cmb_import
        '
        Me.cmb_import.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_import.FormattingEnabled = True
        Me.cmb_import.Location = New System.Drawing.Point(148, 148)
        Me.cmb_import.Name = "cmb_import"
        Me.cmb_import.Size = New System.Drawing.Size(206, 28)
        Me.cmb_import.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Import From"
        '
        'btn_add_new_bill
        '
        Me.btn_add_new_bill.BackColor = System.Drawing.Color.Black
        Me.btn_add_new_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_new_bill.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_bill.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add_new_bill.Location = New System.Drawing.Point(18, 206)
        Me.btn_add_new_bill.Name = "btn_add_new_bill"
        Me.btn_add_new_bill.Size = New System.Drawing.Size(150, 56)
        Me.btn_add_new_bill.TabIndex = 8
        Me.btn_add_new_bill.Text = "Add Bill"
        Me.btn_add_new_bill.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(478, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 37)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "View All"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dg_sm_view)
        Me.Panel4.Location = New System.Drawing.Point(16, 473)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1619, 567)
        Me.Panel4.TabIndex = 43
        '
        'dg_sm_view
        '
        Me.dg_sm_view.AllowUserToAddRows = False
        Me.dg_sm_view.AllowUserToDeleteRows = False
        Me.dg_sm_view.AllowUserToOrderColumns = True
        Me.dg_sm_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_sm_view.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_sm_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_sm_view.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_sm_view.Location = New System.Drawing.Point(0, 0)
        Me.dg_sm_view.Name = "dg_sm_view"
        Me.dg_sm_view.Size = New System.Drawing.Size(1619, 567)
        Me.dg_sm_view.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(601, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Management"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Location = New System.Drawing.Point(76, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1537, 44)
        Me.Panel1.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 23)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Employee ID:-"
        '
        'pan_main_stock
        '
        Me.pan_main_stock.Controls.Add(Me.Label8)
        Me.pan_main_stock.Controls.Add(Me.cmb_stock_type)
        Me.pan_main_stock.Controls.Add(Me.tb_dm_delear_id)
        Me.pan_main_stock.Controls.Add(Me.Label7)
        Me.pan_main_stock.Controls.Add(Me.btn_reset_panel)
        Me.pan_main_stock.Controls.Add(Me.btn_upload_bill)
        Me.pan_main_stock.Controls.Add(Me.Label6)
        Me.pan_main_stock.Controls.Add(Me.tb_paid_amount)
        Me.pan_main_stock.Controls.Add(Me.pb_bill_img)
        Me.pan_main_stock.Controls.Add(Me.Label5)
        Me.pan_main_stock.Controls.Add(Me.Label4)
        Me.pan_main_stock.Controls.Add(Me.Label2)
        Me.pan_main_stock.Controls.Add(Me.dtp_time)
        Me.pan_main_stock.Controls.Add(Me.dtp_date)
        Me.pan_main_stock.Controls.Add(Me.tb_emp_name)
        Me.pan_main_stock.Controls.Add(Me.btn_search_id)
        Me.pan_main_stock.Controls.Add(Me.tb_stock_bill_id)
        Me.pan_main_stock.Controls.Add(Me.tb_emp_id)
        Me.pan_main_stock.Controls.Add(Me.Label13)
        Me.pan_main_stock.Controls.Add(Me.Label11)
        Me.pan_main_stock.Controls.Add(Me.cmb_import)
        Me.pan_main_stock.Controls.Add(Me.Label3)
        Me.pan_main_stock.Controls.Add(Me.btn_add_new_bill)
        Me.pan_main_stock.Location = New System.Drawing.Point(15, 79)
        Me.pan_main_stock.Name = "pan_main_stock"
        Me.pan_main_stock.Size = New System.Drawing.Size(1598, 301)
        Me.pan_main_stock.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(572, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 23)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Stock type :-"
        '
        'cmb_stock_type
        '
        Me.cmb_stock_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmb_stock_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmb_stock_type.BackColor = System.Drawing.Color.LightGray
        Me.cmb_stock_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_stock_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_stock_type.FormattingEnabled = True
        Me.cmb_stock_type.Location = New System.Drawing.Point(712, 151)
        Me.cmb_stock_type.Name = "cmb_stock_type"
        Me.cmb_stock_type.Size = New System.Drawing.Size(160, 28)
        Me.cmb_stock_type.TabIndex = 5
        '
        'tb_dm_delear_id
        '
        Me.tb_dm_delear_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_dm_delear_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_dm_delear_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_dm_delear_id.BorderThickness = 1
        Me.tb_dm_delear_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_dm_delear_id.Enabled = False
        Me.tb_dm_delear_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_dm_delear_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_dm_delear_id.isPassword = False
        Me.tb_dm_delear_id.Location = New System.Drawing.Point(494, 148)
        Me.tb_dm_delear_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_dm_delear_id.Name = "tb_dm_delear_id"
        Me.tb_dm_delear_id.Size = New System.Drawing.Size(71, 28)
        Me.tb_dm_delear_id.TabIndex = 4
        Me.tb_dm_delear_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(376, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 23)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Delear Id :-"
        '
        'btn_reset_panel
        '
        Me.btn_reset_panel.BackColor = System.Drawing.Color.Transparent
        Me.btn_reset_panel.BackgroundImage = Global.Infinity.My.Resources.Resources.Reset_32x32
        Me.btn_reset_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_reset_panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reset_panel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_panel.ForeColor = System.Drawing.Color.Transparent
        Me.btn_reset_panel.Location = New System.Drawing.Point(584, 14)
        Me.btn_reset_panel.Name = "btn_reset_panel"
        Me.btn_reset_panel.Size = New System.Drawing.Size(38, 25)
        Me.btn_reset_panel.TabIndex = 48
        Me.btn_reset_panel.UseVisualStyleBackColor = False
        '
        'pb_bill_img
        '
        Me.pb_bill_img.Location = New System.Drawing.Point(963, 13)
        Me.pb_bill_img.Name = "pb_bill_img"
        Me.pb_bill_img.Size = New System.Drawing.Size(615, 251)
        Me.pb_bill_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_bill_img.TabIndex = 44
        Me.pb_bill_img.TabStop = False
        '
        'btn_search_id
        '
        Me.btn_search_id.BackColor = System.Drawing.Color.Transparent
        Me.btn_search_id.BackgroundImage = Global.Infinity.My.Resources.Resources.Find_32x32
        Me.btn_search_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_search_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_id.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_id.ForeColor = System.Drawing.Color.Transparent
        Me.btn_search_id.Location = New System.Drawing.Point(527, 14)
        Me.btn_search_id.Name = "btn_search_id"
        Me.btn_search_id.Size = New System.Drawing.Size(51, 25)
        Me.btn_search_id.TabIndex = 36
        Me.btn_search_id.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 23)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "From:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(261, 433)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 23)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "To:"
        '
        'dtp_end
        '
        Me.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_end.Location = New System.Drawing.Point(304, 430)
        Me.dtp_end.Name = "dtp_end"
        Me.dtp_end.Size = New System.Drawing.Size(142, 20)
        Me.dtp_end.TabIndex = 103
        '
        'dtp_start
        '
        Me.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_start.Location = New System.Drawing.Point(113, 430)
        Me.dtp_start.Name = "dtp_start"
        Me.dtp_start.Size = New System.Drawing.Size(142, 20)
        Me.dtp_start.TabIndex = 102
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(14, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ucr_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtp_end)
        Me.Controls.Add(Me.dtp_start)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pan_main_stock)
        Me.Name = "ucr_stock"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dg_sm_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pan_main_stock.ResumeLayout(False)
        Me.pan_main_stock.PerformLayout()
        CType(Me.pb_bill_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_upload_bill As Button
    Friend WithEvents tb_paid_amount As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents pb_bill_img As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_time As DateTimePicker
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents tb_emp_name As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_search_id As Button
    Friend WithEvents tb_stock_bill_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_emp_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_import As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_add_new_bill As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dg_sm_view As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents pan_main_stock As Panel
    Friend WithEvents btn_reset_panel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_stock_type As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_dm_delear_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtp_end As DateTimePicker
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
