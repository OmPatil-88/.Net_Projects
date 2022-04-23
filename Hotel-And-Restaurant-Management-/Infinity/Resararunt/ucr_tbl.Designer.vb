<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucr_tbl
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kit_capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.current_order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kitchen_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_tm_grid_viewall = New System.Windows.Forms.Button()
        Me.dg_tm_drid = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pan_tm_main_ = New System.Windows.Forms.Panel()
        Me.cmb_order_type = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_tm_search_table_no = New System.Windows.Forms.Button()
        Me.tb_tm_tableid = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_tm_update = New System.Windows.Forms.Button()
        Me.tb_tm_current_capacity = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_tm_people_capacity = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_tm_table_number = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_tm_drid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pan_tm_main_.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(386, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 44)
        Me.Label1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(1133, 291)
        Me.DataGridView1.TabIndex = 0
        '
        'status
        '
        Me.status.HeaderText = "Avilabilty"
        Me.status.Name = "status"
        '
        'kit_capacity
        '
        Me.kit_capacity.HeaderText = "Order Capacity"
        Me.kit_capacity.Name = "kit_capacity"
        '
        'current_order
        '
        Me.current_order.HeaderText = "Current  Orders"
        Me.current_order.Name = "current_order"
        '
        'kitchen_name
        '
        Me.kitchen_name.HeaderText = "Kitchen Name"
        Me.kitchen_name.Name = "kitchen_name"
        '
        'kid
        '
        Me.kid.HeaderText = "ID"
        Me.kid.Name = "kid"
        '
        'btn_tm_grid_viewall
        '
        Me.btn_tm_grid_viewall.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_tm_grid_viewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tm_grid_viewall.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tm_grid_viewall.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tm_grid_viewall.Location = New System.Drawing.Point(17, 345)
        Me.btn_tm_grid_viewall.Name = "btn_tm_grid_viewall"
        Me.btn_tm_grid_viewall.Size = New System.Drawing.Size(150, 37)
        Me.btn_tm_grid_viewall.TabIndex = 8
        Me.btn_tm_grid_viewall.Text = "Refresh"
        Me.btn_tm_grid_viewall.UseVisualStyleBackColor = False
        '
        'dg_tm_drid
        '
        Me.dg_tm_drid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_tm_drid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dg_tm_drid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tm_drid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_tm_drid.Location = New System.Drawing.Point(0, 0)
        Me.dg_tm_drid.Name = "dg_tm_drid"
        Me.dg_tm_drid.Size = New System.Drawing.Size(1618, 609)
        Me.dg_tm_drid.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dg_tm_drid)
        Me.Panel4.Location = New System.Drawing.Point(17, 407)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1618, 609)
        Me.Panel4.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(609, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 44)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Table Management "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Location = New System.Drawing.Point(91, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1544, 44)
        Me.Panel1.TabIndex = 8
        '
        'pan_tm_main_
        '
        Me.pan_tm_main_.Controls.Add(Me.cmb_order_type)
        Me.pan_tm_main_.Controls.Add(Me.Label9)
        Me.pan_tm_main_.Controls.Add(Me.btn_tm_search_table_no)
        Me.pan_tm_main_.Controls.Add(Me.tb_tm_tableid)
        Me.pan_tm_main_.Controls.Add(Me.Label10)
        Me.pan_tm_main_.Controls.Add(Me.btn_tm_update)
        Me.pan_tm_main_.Controls.Add(Me.tb_tm_current_capacity)
        Me.pan_tm_main_.Controls.Add(Me.Label11)
        Me.pan_tm_main_.Controls.Add(Me.tb_tm_people_capacity)
        Me.pan_tm_main_.Controls.Add(Me.Label12)
        Me.pan_tm_main_.Controls.Add(Me.tb_tm_table_number)
        Me.pan_tm_main_.Controls.Add(Me.Label13)
        Me.pan_tm_main_.Location = New System.Drawing.Point(17, 110)
        Me.pan_tm_main_.Name = "pan_tm_main_"
        Me.pan_tm_main_.Size = New System.Drawing.Size(1618, 229)
        Me.pan_tm_main_.TabIndex = 16
        '
        'cmb_order_type
        '
        Me.cmb_order_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_order_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_order_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_order_type.FormattingEnabled = True
        Me.cmb_order_type.Items.AddRange(New Object() {"Family", "Friends", "Solo"})
        Me.cmb_order_type.Location = New System.Drawing.Point(837, 93)
        Me.cmb_order_type.Name = "cmb_order_type"
        Me.cmb_order_type.Size = New System.Drawing.Size(252, 32)
        Me.cmb_order_type.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(647, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Table Type :-"
        '
        'btn_tm_search_table_no
        '
        Me.btn_tm_search_table_no.BackColor = System.Drawing.Color.Black
        Me.btn_tm_search_table_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tm_search_table_no.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tm_search_table_no.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tm_search_table_no.Location = New System.Drawing.Point(934, 16)
        Me.btn_tm_search_table_no.Name = "btn_tm_search_table_no"
        Me.btn_tm_search_table_no.Size = New System.Drawing.Size(72, 29)
        Me.btn_tm_search_table_no.TabIndex = 27
        Me.btn_tm_search_table_no.Text = "Search"
        Me.btn_tm_search_table_no.UseVisualStyleBackColor = False
        '
        'tb_tm_tableid
        '
        Me.tb_tm_tableid.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_tm_tableid.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tm_tableid.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_tm_tableid.BorderThickness = 1
        Me.tb_tm_tableid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_tm_tableid.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_tm_tableid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tm_tableid.isPassword = False
        Me.tb_tm_tableid.Location = New System.Drawing.Point(258, 15)
        Me.tb_tm_tableid.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_tm_tableid.Name = "tb_tm_tableid"
        Me.tb_tm_tableid.Size = New System.Drawing.Size(306, 30)
        Me.tb_tm_tableid.TabIndex = 24
        Me.tb_tm_tableid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 23)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Table Id:-"
        '
        'btn_tm_update
        '
        Me.btn_tm_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_tm_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tm_update.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tm_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tm_update.Location = New System.Drawing.Point(663, 164)
        Me.btn_tm_update.Name = "btn_tm_update"
        Me.btn_tm_update.Size = New System.Drawing.Size(150, 37)
        Me.btn_tm_update.TabIndex = 7
        Me.btn_tm_update.Text = "Update"
        Me.btn_tm_update.UseVisualStyleBackColor = False
        '
        'tb_tm_current_capacity
        '
        Me.tb_tm_current_capacity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_tm_current_capacity.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_tm_current_capacity.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tm_current_capacity.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_tm_current_capacity.BorderThickness = 1
        Me.tb_tm_current_capacity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_tm_current_capacity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_tm_current_capacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tm_current_capacity.isPassword = False
        Me.tb_tm_current_capacity.Location = New System.Drawing.Point(258, 160)
        Me.tb_tm_current_capacity.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_tm_current_capacity.Name = "tb_tm_current_capacity"
        Me.tb_tm_current_capacity.Size = New System.Drawing.Size(306, 29)
        Me.tb_tm_current_capacity.TabIndex = 7
        Me.tb_tm_current_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 23)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Current  People:-"
        '
        'tb_tm_people_capacity
        '
        Me.tb_tm_people_capacity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_tm_people_capacity.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_tm_people_capacity.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tm_people_capacity.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_tm_people_capacity.BorderThickness = 1
        Me.tb_tm_people_capacity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_tm_people_capacity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_tm_people_capacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tm_people_capacity.isPassword = False
        Me.tb_tm_people_capacity.Location = New System.Drawing.Point(258, 85)
        Me.tb_tm_people_capacity.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_tm_people_capacity.Name = "tb_tm_people_capacity"
        Me.tb_tm_people_capacity.Size = New System.Drawing.Size(306, 29)
        Me.tb_tm_people_capacity.TabIndex = 2
        Me.tb_tm_people_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 23)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "People Capacity :-"
        '
        'tb_tm_table_number
        '
        Me.tb_tm_table_number.BackColor = System.Drawing.Color.Yellow
        Me.tb_tm_table_number.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_tm_table_number.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tm_table_number.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_tm_table_number.BorderThickness = 1
        Me.tb_tm_table_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_tm_table_number.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_tm_table_number.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tb_tm_table_number.isPassword = False
        Me.tb_tm_table_number.Location = New System.Drawing.Point(856, 15)
        Me.tb_tm_table_number.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_tm_table_number.Name = "tb_tm_table_number"
        Me.tb_tm_table_number.Size = New System.Drawing.Size(71, 43)
        Me.tb_tm_table_number.TabIndex = 1
        Me.tb_tm_table_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(647, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(166, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Table Number :-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1098, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Avilability  Status"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(1246, 75)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(29, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ucr_tbl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pan_tm_main_)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_tm_grid_viewall)
        Me.Name = "ucr_tbl"
        Me.Size = New System.Drawing.Size(1653, 1043)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_tm_drid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pan_tm_main_.ResumeLayout(False)
        Me.pan_tm_main_.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents kit_capacity As DataGridViewTextBoxColumn
    Friend WithEvents current_order As DataGridViewTextBoxColumn
    Friend WithEvents kitchen_name As DataGridViewTextBoxColumn
    Friend WithEvents kid As DataGridViewTextBoxColumn
    Friend WithEvents btn_tm_grid_viewall As Button
    Friend WithEvents dg_tm_drid As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pan_tm_main_ As Panel
    Friend WithEvents cmb_order_type As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_tm_search_table_no As Button
    Friend WithEvents tb_tm_tableid As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_tm_update As Button
    Friend WithEvents tb_tm_current_capacity As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_tm_people_capacity As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_tm_table_number As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
End Class
