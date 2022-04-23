<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucr_kitchen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_kitchen_master = New System.Windows.Forms.Panel()
        Me.btn_km_view_single = New System.Windows.Forms.Button()
        Me.cmb_km_menu_type = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_km_chef_name = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_km_kitchen_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_km_update = New System.Windows.Forms.Button()
        Me.btn_km_new = New System.Windows.Forms.Button()
        Me.btn_save_kitchen_master = New System.Windows.Forms.Button()
        Me.cb_avilable_status = New System.Windows.Forms.CheckBox()
        Me.tb_km_current_orders = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_km_order_capacity = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_km_view = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_kitchen_master = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panel_kitchen_master.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_kitchen_master, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(62, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1573, 44)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(685, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kitchen Master "
        '
        'panel_kitchen_master
        '
        Me.panel_kitchen_master.Controls.Add(Me.btn_km_view_single)
        Me.panel_kitchen_master.Controls.Add(Me.cmb_km_menu_type)
        Me.panel_kitchen_master.Controls.Add(Me.Label8)
        Me.panel_kitchen_master.Controls.Add(Me.cmb_km_chef_name)
        Me.panel_kitchen_master.Controls.Add(Me.Label5)
        Me.panel_kitchen_master.Controls.Add(Me.Label2)
        Me.panel_kitchen_master.Controls.Add(Me.tb_km_kitchen_id)
        Me.panel_kitchen_master.Controls.Add(Me.Label3)
        Me.panel_kitchen_master.Controls.Add(Me.btn_km_update)
        Me.panel_kitchen_master.Controls.Add(Me.btn_km_new)
        Me.panel_kitchen_master.Controls.Add(Me.btn_save_kitchen_master)
        Me.panel_kitchen_master.Controls.Add(Me.cb_avilable_status)
        Me.panel_kitchen_master.Controls.Add(Me.tb_km_current_orders)
        Me.panel_kitchen_master.Controls.Add(Me.Label7)
        Me.panel_kitchen_master.Controls.Add(Me.tb_km_order_capacity)
        Me.panel_kitchen_master.Controls.Add(Me.Label4)
        Me.panel_kitchen_master.Controls.Add(Me.Label6)
        Me.panel_kitchen_master.Location = New System.Drawing.Point(16, 109)
        Me.panel_kitchen_master.Name = "panel_kitchen_master"
        Me.panel_kitchen_master.Size = New System.Drawing.Size(1596, 280)
        Me.panel_kitchen_master.TabIndex = 16
        '
        'btn_km_view_single
        '
        Me.btn_km_view_single.BackColor = System.Drawing.Color.Black
        Me.btn_km_view_single.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_km_view_single.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_km_view_single.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_km_view_single.Location = New System.Drawing.Point(547, 20)
        Me.btn_km_view_single.Name = "btn_km_view_single"
        Me.btn_km_view_single.Size = New System.Drawing.Size(49, 26)
        Me.btn_km_view_single.TabIndex = 22
        Me.btn_km_view_single.Text = "View"
        Me.btn_km_view_single.UseVisualStyleBackColor = False
        '
        'cmb_km_menu_type
        '
        Me.cmb_km_menu_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_km_menu_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_km_menu_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_km_menu_type.FormattingEnabled = True
        Me.cmb_km_menu_type.Items.AddRange(New Object() {"Snaks", "Drinks", "Lunch", "Dinner", "Break Fast", "Desert"})
        Me.cmb_km_menu_type.Location = New System.Drawing.Point(234, 84)
        Me.cmb_km_menu_type.Name = "cmb_km_menu_type"
        Me.cmb_km_menu_type.Size = New System.Drawing.Size(306, 33)
        Me.cmb_km_menu_type.TabIndex = 2
        Me.cmb_km_menu_type.Text = "Snaks"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Kitchen Menu Type :-"
        '
        'cmb_km_chef_name
        '
        Me.cmb_km_chef_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_km_chef_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_km_chef_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_km_chef_name.FormattingEnabled = True
        Me.cmb_km_chef_name.Location = New System.Drawing.Point(969, 80)
        Me.cmb_km_chef_name.Name = "cmb_km_chef_name"
        Me.cmb_km_chef_name.Size = New System.Drawing.Size(236, 33)
        Me.cmb_km_chef_name.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(820, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 23)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Chef Name :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1057, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Avilable In"
        '
        'tb_km_kitchen_id
        '
        Me.tb_km_kitchen_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_km_kitchen_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_km_kitchen_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_km_kitchen_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_km_kitchen_id.BorderThickness = 1
        Me.tb_km_kitchen_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_km_kitchen_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_km_kitchen_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_km_kitchen_id.isPassword = False
        Me.tb_km_kitchen_id.Location = New System.Drawing.Point(234, 17)
        Me.tb_km_kitchen_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_km_kitchen_id.Name = "tb_km_kitchen_id"
        Me.tb_km_kitchen_id.Size = New System.Drawing.Size(306, 29)
        Me.tb_km_kitchen_id.TabIndex = 1
        Me.tb_km_kitchen_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "kitchen Id:-"
        '
        'btn_km_update
        '
        Me.btn_km_update.BackColor = System.Drawing.Color.Black
        Me.btn_km_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_km_update.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_km_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_km_update.Location = New System.Drawing.Point(991, 230)
        Me.btn_km_update.Name = "btn_km_update"
        Me.btn_km_update.Size = New System.Drawing.Size(150, 37)
        Me.btn_km_update.TabIndex = 8
        Me.btn_km_update.Text = "Update"
        Me.btn_km_update.UseVisualStyleBackColor = False
        '
        'btn_km_new
        '
        Me.btn_km_new.BackColor = System.Drawing.Color.Black
        Me.btn_km_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_km_new.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_km_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_km_new.Location = New System.Drawing.Point(299, 230)
        Me.btn_km_new.Name = "btn_km_new"
        Me.btn_km_new.Size = New System.Drawing.Size(150, 37)
        Me.btn_km_new.TabIndex = 6
        Me.btn_km_new.Text = "New"
        Me.btn_km_new.UseVisualStyleBackColor = False
        '
        'btn_save_kitchen_master
        '
        Me.btn_save_kitchen_master.BackColor = System.Drawing.Color.Black
        Me.btn_save_kitchen_master.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_kitchen_master.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_kitchen_master.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save_kitchen_master.Location = New System.Drawing.Point(645, 230)
        Me.btn_save_kitchen_master.Name = "btn_save_kitchen_master"
        Me.btn_save_kitchen_master.Size = New System.Drawing.Size(150, 37)
        Me.btn_save_kitchen_master.TabIndex = 7
        Me.btn_save_kitchen_master.Text = "Save"
        Me.btn_save_kitchen_master.UseVisualStyleBackColor = False
        '
        'cb_avilable_status
        '
        Me.cb_avilable_status.AutoSize = True
        Me.cb_avilable_status.Location = New System.Drawing.Point(1025, 22)
        Me.cb_avilable_status.Name = "cb_avilable_status"
        Me.cb_avilable_status.Size = New System.Drawing.Size(15, 14)
        Me.cb_avilable_status.TabIndex = 4
        Me.cb_avilable_status.UseVisualStyleBackColor = True
        '
        'tb_km_current_orders
        '
        Me.tb_km_current_orders.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_km_current_orders.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_km_current_orders.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_km_current_orders.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_km_current_orders.BorderThickness = 1
        Me.tb_km_current_orders.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_km_current_orders.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_km_current_orders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_km_current_orders.isPassword = False
        Me.tb_km_current_orders.Location = New System.Drawing.Point(1015, 142)
        Me.tb_km_current_orders.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_km_current_orders.Name = "tb_km_current_orders"
        Me.tb_km_current_orders.Size = New System.Drawing.Size(306, 29)
        Me.tb_km_current_orders.TabIndex = 5
        Me.tb_km_current_orders.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(820, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Current  orders :-"
        '
        'tb_km_order_capacity
        '
        Me.tb_km_order_capacity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_km_order_capacity.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_km_order_capacity.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_km_order_capacity.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_km_order_capacity.BorderThickness = 1
        Me.tb_km_order_capacity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_km_order_capacity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_km_order_capacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_km_order_capacity.isPassword = False
        Me.tb_km_order_capacity.Location = New System.Drawing.Point(234, 148)
        Me.tb_km_order_capacity.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_km_order_capacity.Name = "tb_km_order_capacity"
        Me.tb_km_order_capacity.Size = New System.Drawing.Size(306, 29)
        Me.tb_km_order_capacity.TabIndex = 4
        Me.tb_km_order_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Capacity of order :-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(820, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Avilability  Status"
        '
        'btn_km_view
        '
        Me.btn_km_view.BackColor = System.Drawing.Color.Black
        Me.btn_km_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_km_view.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_km_view.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_km_view.Location = New System.Drawing.Point(16, 395)
        Me.btn_km_view.Name = "btn_km_view"
        Me.btn_km_view.Size = New System.Drawing.Size(150, 41)
        Me.btn_km_view.TabIndex = 9
        Me.btn_km_view.Text = "Refresh"
        Me.btn_km_view.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_kitchen_master)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(14, 442)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1636, 598)
        Me.Panel4.TabIndex = 17
        '
        'dgv_kitchen_master
        '
        Me.dgv_kitchen_master.AllowUserToAddRows = False
        Me.dgv_kitchen_master.AllowUserToDeleteRows = False
        Me.dgv_kitchen_master.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_kitchen_master.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_kitchen_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_kitchen_master.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_kitchen_master.Location = New System.Drawing.Point(0, 0)
        Me.dgv_kitchen_master.Name = "dgv_kitchen_master"
        Me.dgv_kitchen_master.ReadOnly = True
        Me.dgv_kitchen_master.Size = New System.Drawing.Size(1636, 598)
        Me.dgv_kitchen_master.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ucr_kitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panel_kitchen_master)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_km_view)
        Me.Name = "ucr_kitchen"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_kitchen_master.ResumeLayout(False)
        Me.panel_kitchen_master.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_kitchen_master, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panel_kitchen_master As Panel
    Friend WithEvents cmb_km_menu_type As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_km_chef_name As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_km_kitchen_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_km_update As Button
    Friend WithEvents btn_km_view As Button
    Friend WithEvents btn_km_new As Button
    Friend WithEvents btn_save_kitchen_master As Button
    Friend WithEvents cb_avilable_status As CheckBox
    Friend WithEvents tb_km_current_orders As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_km_order_capacity As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_kitchen_master As DataGridView
    Friend WithEvents btn_km_view_single As Button
    Friend WithEvents Button1 As Button
End Class
