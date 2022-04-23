<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uchome_bill
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgv_biiled_order = New System.Windows.Forms.DataGridView()
        Me.dgv_current_order = New System.Windows.Forms.DataGridView()
        Me.pan_table = New System.Windows.Forms.Panel()
        Me.panel_bill = New System.Windows.Forms.Panel()
        Me.dtp_bill_date = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_hm_gst = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_cost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_total_cost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_quanty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_menu_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_customer_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_bill_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_table_number = New System.Windows.Forms.TextBox()
        Me.btn_hm_order = New System.Windows.Forms.Button()
        Me.btn_hm_Bill = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lb_menu_items = New System.Windows.Forms.ListBox()
        Me.pan_load = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_biiled_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_current_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_bill.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Location = New System.Drawing.Point(63, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1572, 42)
        Me.Panel1.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(709, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restarunt Bill"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(1169, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 43)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgv_biiled_order
        '
        Me.dgv_biiled_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_biiled_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_biiled_order.Location = New System.Drawing.Point(711, 82)
        Me.dgv_biiled_order.Name = "dgv_biiled_order"
        Me.dgv_biiled_order.Size = New System.Drawing.Size(924, 324)
        Me.dgv_biiled_order.TabIndex = 0
        '
        'dgv_current_order
        '
        Me.dgv_current_order.AllowUserToAddRows = False
        Me.dgv_current_order.AllowUserToDeleteRows = False
        Me.dgv_current_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_current_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_current_order.Location = New System.Drawing.Point(650, 429)
        Me.dgv_current_order.Name = "dgv_current_order"
        Me.dgv_current_order.ReadOnly = True
        Me.dgv_current_order.Size = New System.Drawing.Size(985, 586)
        Me.dgv_current_order.TabIndex = 0
        '
        'pan_table
        '
        Me.pan_table.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pan_table.Location = New System.Drawing.Point(18, 64)
        Me.pan_table.Name = "pan_table"
        Me.pan_table.Size = New System.Drawing.Size(669, 361)
        Me.pan_table.TabIndex = 66
        '
        'panel_bill
        '
        Me.panel_bill.Controls.Add(Me.dtp_bill_date)
        Me.panel_bill.Controls.Add(Me.Label9)
        Me.panel_bill.Controls.Add(Me.tb_hm_gst)
        Me.panel_bill.Controls.Add(Me.Label8)
        Me.panel_bill.Controls.Add(Me.tb_cost)
        Me.panel_bill.Controls.Add(Me.Label7)
        Me.panel_bill.Controls.Add(Me.tb_total_cost)
        Me.panel_bill.Controls.Add(Me.Label6)
        Me.panel_bill.Controls.Add(Me.tb_quanty)
        Me.panel_bill.Controls.Add(Me.Label5)
        Me.panel_bill.Controls.Add(Me.tb_menu_name)
        Me.panel_bill.Controls.Add(Me.Label4)
        Me.panel_bill.Controls.Add(Me.tb_customer_name)
        Me.panel_bill.Controls.Add(Me.Label3)
        Me.panel_bill.Controls.Add(Me.tb_bill_no)
        Me.panel_bill.Controls.Add(Me.Label2)
        Me.panel_bill.Controls.Add(Me.tb_table_number)
        Me.panel_bill.Controls.Add(Me.btn_hm_order)
        Me.panel_bill.Controls.Add(Me.btn_hm_Bill)
        Me.panel_bill.Location = New System.Drawing.Point(18, 477)
        Me.panel_bill.Name = "panel_bill"
        Me.panel_bill.Size = New System.Drawing.Size(606, 523)
        Me.panel_bill.TabIndex = 67
        '
        'dtp_bill_date
        '
        Me.dtp_bill_date.Enabled = False
        Me.dtp_bill_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_bill_date.Location = New System.Drawing.Point(409, 14)
        Me.dtp_bill_date.Name = "dtp_bill_date"
        Me.dtp_bill_date.Size = New System.Drawing.Size(126, 20)
        Me.dtp_bill_date.TabIndex = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(345, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 19)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "GST :-"
        '
        'tb_hm_gst
        '
        Me.tb_hm_gst.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_hm_gst.Location = New System.Drawing.Point(404, 436)
        Me.tb_hm_gst.Multiline = True
        Me.tb_hm_gst.Name = "tb_hm_gst"
        Me.tb_hm_gst.Size = New System.Drawing.Size(70, 34)
        Me.tb_hm_gst.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(241, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 23)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Cost :-"
        '
        'tb_cost
        '
        Me.tb_cost.Enabled = False
        Me.tb_cost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cost.Location = New System.Drawing.Point(316, 243)
        Me.tb_cost.Multiline = True
        Me.tb_cost.Name = "tb_cost"
        Me.tb_cost.Size = New System.Drawing.Size(122, 34)
        Me.tb_cost.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 23)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Total Cost :-"
        '
        'tb_total_cost
        '
        Me.tb_total_cost.Enabled = False
        Me.tb_total_cost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total_cost.Location = New System.Drawing.Point(149, 356)
        Me.tb_total_cost.Multiline = True
        Me.tb_total_cost.Name = "tb_total_cost"
        Me.tb_total_cost.Size = New System.Drawing.Size(229, 29)
        Me.tb_total_cost.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Quantity. :-"
        '
        'tb_quanty
        '
        Me.tb_quanty.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_quanty.Location = New System.Drawing.Point(149, 243)
        Me.tb_quanty.Multiline = True
        Me.tb_quanty.Name = "tb_quanty"
        Me.tb_quanty.Size = New System.Drawing.Size(80, 34)
        Me.tb_quanty.TabIndex = 94
        Me.tb_quanty.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 23)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Menu Name. :-"
        '
        'tb_menu_name
        '
        Me.tb_menu_name.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_menu_name.Location = New System.Drawing.Point(160, 145)
        Me.tb_menu_name.Multiline = True
        Me.tb_menu_name.Name = "tb_menu_name"
        Me.tb_menu_name.Size = New System.Drawing.Size(419, 34)
        Me.tb_menu_name.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Customer Name. :-"
        '
        'tb_customer_name
        '
        Me.tb_customer_name.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customer_name.Location = New System.Drawing.Point(197, 69)
        Me.tb_customer_name.Multiline = True
        Me.tb_customer_name.Name = "tb_customer_name"
        Me.tb_customer_name.Size = New System.Drawing.Size(382, 34)
        Me.tb_customer_name.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Bill No. :-"
        '
        'tb_bill_no
        '
        Me.tb_bill_no.Enabled = False
        Me.tb_bill_no.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_bill_no.Location = New System.Drawing.Point(308, 14)
        Me.tb_bill_no.Multiline = True
        Me.tb_bill_no.Name = "tb_bill_no"
        Me.tb_bill_no.Size = New System.Drawing.Size(80, 34)
        Me.tb_bill_no.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Table No. :-"
        '
        'tb_table_number
        '
        Me.tb_table_number.Enabled = False
        Me.tb_table_number.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_table_number.Location = New System.Drawing.Point(130, 14)
        Me.tb_table_number.Multiline = True
        Me.tb_table_number.Name = "tb_table_number"
        Me.tb_table_number.Size = New System.Drawing.Size(80, 34)
        Me.tb_table_number.TabIndex = 86
        '
        'btn_hm_order
        '
        Me.btn_hm_order.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_hm_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hm_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hm_order.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_hm_order.Location = New System.Drawing.Point(5, 436)
        Me.btn_hm_order.Name = "btn_hm_order"
        Me.btn_hm_order.Size = New System.Drawing.Size(134, 34)
        Me.btn_hm_order.TabIndex = 84
        Me.btn_hm_order.Text = "Add"
        Me.btn_hm_order.UseVisualStyleBackColor = False
        '
        'btn_hm_Bill
        '
        Me.btn_hm_Bill.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_hm_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hm_Bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hm_Bill.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_hm_Bill.Location = New System.Drawing.Point(160, 436)
        Me.btn_hm_Bill.Name = "btn_hm_Bill"
        Me.btn_hm_Bill.Size = New System.Drawing.Size(141, 34)
        Me.btn_hm_Bill.TabIndex = 85
        Me.btn_hm_Bill.Text = "Bill"
        Me.btn_hm_Bill.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Location = New System.Drawing.Point(178, 443)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 18)
        Me.Panel2.TabIndex = 82
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(189, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Guest"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(30, 1)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Regular"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 443)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 17)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Customer Type :-"
        '
        'lb_menu_items
        '
        Me.lb_menu_items.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_menu_items.FormattingEnabled = True
        Me.lb_menu_items.ItemHeight = 20
        Me.lb_menu_items.Location = New System.Drawing.Point(463, 486)
        Me.lb_menu_items.Name = "lb_menu_items"
        Me.lb_menu_items.Size = New System.Drawing.Size(378, 384)
        Me.lb_menu_items.TabIndex = 81
        Me.lb_menu_items.Visible = False
        '
        'pan_load
        '
        Me.pan_load.Location = New System.Drawing.Point(694, 54)
        Me.pan_load.Name = "pan_load"
        Me.pan_load.Size = New System.Drawing.Size(959, 989)
        Me.pan_load.TabIndex = 1
        Me.pan_load.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 17)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Double Tap to relese the table."
        Me.Label11.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uchome_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lb_menu_items)
        Me.Controls.Add(Me.pan_load)
        Me.Controls.Add(Me.dgv_biiled_order)
        Me.Controls.Add(Me.dgv_current_order)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pan_table)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel_bill)
        Me.Name = "uchome_bill"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_biiled_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_current_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_bill.ResumeLayout(False)
        Me.panel_bill.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents dgv_biiled_order As DataGridView
    Friend WithEvents dgv_current_order As DataGridView
    Friend WithEvents pan_table As Panel
    Friend WithEvents panel_bill As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_cost As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_total_cost As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_quanty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_menu_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_customer_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_bill_no As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_table_number As TextBox
    Friend WithEvents btn_hm_order As Button
    Friend WithEvents btn_hm_Bill As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_hm_gst As TextBox
    Friend WithEvents dtp_bill_date As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents lb_menu_items As ListBox
    Friend WithEvents pan_load As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
End Class
