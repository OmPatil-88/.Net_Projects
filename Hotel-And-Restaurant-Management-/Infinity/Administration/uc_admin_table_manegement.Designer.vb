<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_admin_table_manegement
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
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kit_capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.current_order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kitchen_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_um_tm_delete = New System.Windows.Forms.Button()
        Me.btn_um_tm_update = New System.Windows.Forms.Button()
        Me.btn_um_tm_new = New System.Windows.Forms.Button()
        Me.btn_um_tm_save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_um_tm_people_capacity = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_um_tm_table_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btn_um_tm_search = New System.Windows.Forms.Button()
        Me.tb_um_tm_table_number = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.pan_um_tm = New System.Windows.Forms.Panel()
        Me.cmb_um_tm_order_type = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pan_um_tm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(87, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1545, 54)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(652, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Table Manegment"
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
        'btn_um_tm_delete
        '
        Me.btn_um_tm_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_um_tm_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_um_tm_delete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_um_tm_delete.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_um_tm_delete.Location = New System.Drawing.Point(1075, 542)
        Me.btn_um_tm_delete.Name = "btn_um_tm_delete"
        Me.btn_um_tm_delete.Size = New System.Drawing.Size(144, 33)
        Me.btn_um_tm_delete.TabIndex = 8
        Me.btn_um_tm_delete.Text = "Delete"
        Me.btn_um_tm_delete.UseVisualStyleBackColor = False
        '
        'btn_um_tm_update
        '
        Me.btn_um_tm_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_um_tm_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_um_tm_update.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_um_tm_update.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_um_tm_update.Location = New System.Drawing.Point(824, 542)
        Me.btn_um_tm_update.Name = "btn_um_tm_update"
        Me.btn_um_tm_update.Size = New System.Drawing.Size(144, 33)
        Me.btn_um_tm_update.TabIndex = 7
        Me.btn_um_tm_update.Text = "Update"
        Me.btn_um_tm_update.UseVisualStyleBackColor = False
        '
        'btn_um_tm_new
        '
        Me.btn_um_tm_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_um_tm_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_um_tm_new.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_um_tm_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_um_tm_new.Location = New System.Drawing.Point(291, 542)
        Me.btn_um_tm_new.Name = "btn_um_tm_new"
        Me.btn_um_tm_new.Size = New System.Drawing.Size(160, 37)
        Me.btn_um_tm_new.TabIndex = 5
        Me.btn_um_tm_new.Text = "New"
        Me.btn_um_tm_new.UseVisualStyleBackColor = False
        '
        'btn_um_tm_save
        '
        Me.btn_um_tm_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_um_tm_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_um_tm_save.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_um_tm_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_um_tm_save.Location = New System.Drawing.Point(557, 542)
        Me.btn_um_tm_save.Name = "btn_um_tm_save"
        Me.btn_um_tm_save.Size = New System.Drawing.Size(160, 37)
        Me.btn_um_tm_save.TabIndex = 6
        Me.btn_um_tm_save.Text = "Save"
        Me.btn_um_tm_save.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Table Number :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "People Capacity :-"
        '
        'tb_um_tm_people_capacity
        '
        Me.tb_um_tm_people_capacity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_um_tm_people_capacity.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_um_tm_people_capacity.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_tm_people_capacity.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_um_tm_people_capacity.BorderThickness = 1
        Me.tb_um_tm_people_capacity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_um_tm_people_capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_um_tm_people_capacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_tm_people_capacity.isPassword = False
        Me.tb_um_tm_people_capacity.Location = New System.Drawing.Point(539, 189)
        Me.tb_um_tm_people_capacity.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_um_tm_people_capacity.Name = "tb_um_tm_people_capacity"
        Me.tb_um_tm_people_capacity.Size = New System.Drawing.Size(326, 42)
        Me.tb_um_tm_people_capacity.TabIndex = 3
        Me.tb_um_tm_people_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(299, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 23)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Table Id:-"
        '
        'tb_um_tm_table_id
        '
        Me.tb_um_tm_table_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_um_tm_table_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_tm_table_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_um_tm_table_id.BorderThickness = 1
        Me.tb_um_tm_table_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_um_tm_table_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_um_tm_table_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_tm_table_id.isPassword = False
        Me.tb_um_tm_table_id.Location = New System.Drawing.Point(539, 28)
        Me.tb_um_tm_table_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_um_tm_table_id.Name = "tb_um_tm_table_id"
        Me.tb_um_tm_table_id.Size = New System.Drawing.Size(326, 41)
        Me.tb_um_tm_table_id.TabIndex = 1
        Me.tb_um_tm_table_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_um_tm_search
        '
        Me.btn_um_tm_search.BackColor = System.Drawing.Color.Black
        Me.btn_um_tm_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_um_tm_search.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_um_tm_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_um_tm_search.Location = New System.Drawing.Point(890, 35)
        Me.btn_um_tm_search.Name = "btn_um_tm_search"
        Me.btn_um_tm_search.Size = New System.Drawing.Size(77, 34)
        Me.btn_um_tm_search.TabIndex = 25
        Me.btn_um_tm_search.Text = "View"
        Me.btn_um_tm_search.UseVisualStyleBackColor = False
        '
        'tb_um_tm_table_number
        '
        Me.tb_um_tm_table_number.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_um_tm_table_number.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_um_tm_table_number.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_tm_table_number.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_um_tm_table_number.BorderThickness = 1
        Me.tb_um_tm_table_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_um_tm_table_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_um_tm_table_number.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_tm_table_number.isPassword = False
        Me.tb_um_tm_table_number.Location = New System.Drawing.Point(539, 110)
        Me.tb_um_tm_table_number.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_um_tm_table_number.Name = "tb_um_tm_table_number"
        Me.tb_um_tm_table_number.Size = New System.Drawing.Size(326, 38)
        Me.tb_um_tm_table_number.TabIndex = 2
        Me.tb_um_tm_table_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pan_um_tm
        '
        Me.pan_um_tm.Controls.Add(Me.cmb_um_tm_order_type)
        Me.pan_um_tm.Controls.Add(Me.Label9)
        Me.pan_um_tm.Controls.Add(Me.tb_um_tm_table_number)
        Me.pan_um_tm.Controls.Add(Me.btn_um_tm_search)
        Me.pan_um_tm.Controls.Add(Me.tb_um_tm_table_id)
        Me.pan_um_tm.Controls.Add(Me.Label7)
        Me.pan_um_tm.Controls.Add(Me.tb_um_tm_people_capacity)
        Me.pan_um_tm.Controls.Add(Me.Label4)
        Me.pan_um_tm.Controls.Add(Me.Label2)
        Me.pan_um_tm.Location = New System.Drawing.Point(18, 127)
        Me.pan_um_tm.Name = "pan_um_tm"
        Me.pan_um_tm.Size = New System.Drawing.Size(1614, 392)
        Me.pan_um_tm.TabIndex = 26
        '
        'cmb_um_tm_order_type
        '
        Me.cmb_um_tm_order_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_um_tm_order_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_um_tm_order_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_um_tm_order_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_um_tm_order_type.FormattingEnabled = True
        Me.cmb_um_tm_order_type.Items.AddRange(New Object() {"Family", "Friends", "Solo"})
        Me.cmb_um_tm_order_type.Location = New System.Drawing.Point(539, 272)
        Me.cmb_um_tm_order_type.Name = "cmb_um_tm_order_type"
        Me.cmb_um_tm_order_type.Size = New System.Drawing.Size(326, 32)
        Me.cmb_um_tm_order_type.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(299, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 23)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Table Type :-"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(18, 604)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1614, 414)
        Me.Panel2.TabIndex = 97
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(18, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_admin_table_manegement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_um_tm_new)
        Me.Controls.Add(Me.btn_um_tm_save)
        Me.Controls.Add(Me.btn_um_tm_delete)
        Me.Controls.Add(Me.pan_um_tm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_um_tm_update)
        Me.Name = "uc_admin_table_manegement"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pan_um_tm.ResumeLayout(False)
        Me.pan_um_tm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents kit_capacity As DataGridViewTextBoxColumn
    Friend WithEvents current_order As DataGridViewTextBoxColumn
    Friend WithEvents kitchen_name As DataGridViewTextBoxColumn
    Friend WithEvents kid As DataGridViewTextBoxColumn
    Friend WithEvents btn_um_tm_delete As Button
    Friend WithEvents btn_um_tm_update As Button
    Friend WithEvents btn_um_tm_new As Button
    Friend WithEvents btn_um_tm_save As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_um_tm_people_capacity As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_um_tm_table_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btn_um_tm_search As Button
    Friend WithEvents tb_um_tm_table_number As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents pan_um_tm As Panel
    Friend WithEvents cmb_um_tm_order_type As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
