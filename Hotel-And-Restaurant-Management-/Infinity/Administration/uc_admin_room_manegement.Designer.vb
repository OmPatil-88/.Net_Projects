<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_admin_room_manegement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pan_rm_room = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.tb_desc = New System.Windows.Forms.RichTextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.tb_room_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_room_prize = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pb_room_images = New System.Windows.Forms.PictureBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_room_no = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_room_total_capacity = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.cmb_room_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pan_rm_room.SuspendLayout()
        CType(Me.pb_room_images, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(633, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room Manegement"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(85, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1543, 54)
        Me.Panel1.TabIndex = 20
        '
        'pan_rm_room
        '
        Me.pan_rm_room.Controls.Add(Me.Button2)
        Me.pan_rm_room.Controls.Add(Me.btn_new)
        Me.pan_rm_room.Controls.Add(Me.tb_desc)
        Me.pan_rm_room.Controls.Add(Me.btn_delete)
        Me.pan_rm_room.Controls.Add(Me.Button4)
        Me.pan_rm_room.Controls.Add(Me.btn_update)
        Me.pan_rm_room.Controls.Add(Me.btn_add)
        Me.pan_rm_room.Controls.Add(Me.tb_room_id)
        Me.pan_rm_room.Controls.Add(Me.Label7)
        Me.pan_rm_room.Controls.Add(Me.tb_room_prize)
        Me.pan_rm_room.Controls.Add(Me.Label2)
        Me.pan_rm_room.Controls.Add(Me.Label8)
        Me.pan_rm_room.Controls.Add(Me.pb_room_images)
        Me.pan_rm_room.Controls.Add(Me.btn_search)
        Me.pan_rm_room.Controls.Add(Me.Label3)
        Me.pan_rm_room.Controls.Add(Me.tb_room_no)
        Me.pan_rm_room.Controls.Add(Me.Label4)
        Me.pan_rm_room.Controls.Add(Me.tb_room_total_capacity)
        Me.pan_rm_room.Controls.Add(Me.cmb_room_type)
        Me.pan_rm_room.Controls.Add(Me.Label5)
        Me.pan_rm_room.Location = New System.Drawing.Point(14, 95)
        Me.pan_rm_room.Name = "pan_rm_room"
        Me.pan_rm_room.Size = New System.Drawing.Size(1614, 933)
        Me.pan_rm_room.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button2.Location = New System.Drawing.Point(1378, 435)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_new.Location = New System.Drawing.Point(184, 864)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(161, 50)
        Me.btn_new.TabIndex = 8
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'tb_desc
        '
        Me.tb_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_desc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_desc.Location = New System.Drawing.Point(22, 537)
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.Size = New System.Drawing.Size(1575, 308)
        Me.tb_desc.TabIndex = 6
        Me.tb_desc.Text = ""
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_delete.Location = New System.Drawing.Point(1084, 864)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(161, 50)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button4.Location = New System.Drawing.Point(859, 864)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(161, 50)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Hold"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_update.Location = New System.Drawing.Point(634, 864)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(161, 50)
        Me.btn_update.TabIndex = 10
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_add.Location = New System.Drawing.Point(409, 864)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(161, 50)
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'tb_room_id
        '
        Me.tb_room_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_room_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_room_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_room_id.BorderThickness = 1
        Me.tb_room_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_room_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_room_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_id.isPassword = False
        Me.tb_room_id.Location = New System.Drawing.Point(261, 112)
        Me.tb_room_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_room_id.Name = "tb_room_id"
        Me.tb_room_id.Size = New System.Drawing.Size(407, 52)
        Me.tb_room_id.TabIndex = 2
        Me.tb_room_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 493)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 32)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Room Description:-"
        '
        'tb_room_prize
        '
        Me.tb_room_prize.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_room_prize.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_room_prize.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_prize.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_room_prize.BorderThickness = 1
        Me.tb_room_prize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_room_prize.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_room_prize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_prize.isPassword = False
        Me.tb_room_prize.Location = New System.Drawing.Point(825, 477)
        Me.tb_room_prize.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_room_prize.Name = "tb_room_prize"
        Me.tb_room_prize.Size = New System.Drawing.Size(420, 48)
        Me.tb_room_prize.TabIndex = 5
        Me.tb_room_prize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 32)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Room Id:-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(719, 493)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 32)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Price:-"
        '
        'pb_room_images
        '
        Me.pb_room_images.BackColor = System.Drawing.Color.Silver
        Me.pb_room_images.Location = New System.Drawing.Point(859, 4)
        Me.pb_room_images.Name = "pb_room_images"
        Me.pb_room_images.Size = New System.Drawing.Size(607, 409)
        Me.pb_room_images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_room_images.TabIndex = 44
        Me.pb_room_images.TabStop = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.BackgroundImage = Global.Infinity.My.Resources.Resources.Find_32x32
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Location = New System.Drawing.Point(620, 45)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(48, 59)
        Me.btn_search.TabIndex = 34
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 32)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Room No:-"
        '
        'tb_room_no
        '
        Me.tb_room_no.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_room_no.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_room_no.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_no.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_room_no.BorderThickness = 1
        Me.tb_room_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_room_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_room_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_no.isPassword = False
        Me.tb_room_no.Location = New System.Drawing.Point(260, 44)
        Me.tb_room_no.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_room_no.Name = "tb_room_no"
        Me.tb_room_no.Size = New System.Drawing.Size(408, 60)
        Me.tb_room_no.TabIndex = 1
        Me.tb_room_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 32)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Room Type :-"
        '
        'tb_room_total_capacity
        '
        Me.tb_room_total_capacity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_room_total_capacity.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_room_total_capacity.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_total_capacity.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_room_total_capacity.BorderThickness = 1
        Me.tb_room_total_capacity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_room_total_capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_room_total_capacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_total_capacity.isPassword = False
        Me.tb_room_total_capacity.Location = New System.Drawing.Point(261, 265)
        Me.tb_room_total_capacity.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_room_total_capacity.Name = "tb_room_total_capacity"
        Me.tb_room_total_capacity.Size = New System.Drawing.Size(84, 43)
        Me.tb_room_total_capacity.TabIndex = 4
        Me.tb_room_total_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmb_room_type
        '
        Me.cmb_room_type.BackColor = System.Drawing.Color.Silver
        Me.cmb_room_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_room_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_room_type.FormattingEnabled = True
        Me.cmb_room_type.Location = New System.Drawing.Point(261, 183)
        Me.cmb_room_type.Name = "cmb_room_type"
        Me.cmb_room_type.Size = New System.Drawing.Size(407, 39)
        Me.cmb_room_type.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 32)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Total Capacity :-"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(23, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_admin_room_manegement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pan_rm_room)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_admin_room_manegement"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pan_rm_room.ResumeLayout(False)
        Me.pan_rm_room.PerformLayout()
        CType(Me.pb_room_images, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pan_rm_room As Panel
    Friend WithEvents tb_room_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_room_prize As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pb_room_images As PictureBox
    Friend WithEvents btn_search As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_room_no As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_room_total_capacity As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents cmb_room_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents tb_desc As RichTextBox
    Friend WithEvents btn_new As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
