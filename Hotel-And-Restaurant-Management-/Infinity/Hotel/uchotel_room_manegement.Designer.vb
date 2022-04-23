<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uchotel_room_manegement
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pan_rm_room = New System.Windows.Forms.Panel()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.tb_desc = New System.Windows.Forms.RichTextBox()
        Me.tb_room_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_room_prize = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pb_room_images = New System.Windows.Forms.PictureBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_room_no = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_room_total_capacity = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.cmb_room_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tb_search_type = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.cmb_Search_type = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dg_rm_ri_view = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pan_rm_room.SuspendLayout()
        CType(Me.pb_room_images, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dg_rm_ri_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(85, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1547, 55)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(656, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room Information"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(16, 97)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1620, 928)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.pan_rm_room)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1612, 892)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Room Details"
        '
        'pan_rm_room
        '
        Me.pan_rm_room.Controls.Add(Me.btn_reset)
        Me.pan_rm_room.Controls.Add(Me.tb_desc)
        Me.pan_rm_room.Controls.Add(Me.tb_room_id)
        Me.pan_rm_room.Controls.Add(Me.Label7)
        Me.pan_rm_room.Controls.Add(Me.tb_room_prize)
        Me.pan_rm_room.Controls.Add(Me.Label2)
        Me.pan_rm_room.Controls.Add(Me.Label8)
        Me.pan_rm_room.Controls.Add(Me.pb_room_images)
        Me.pan_rm_room.Controls.Add(Me.btn_search)
        Me.pan_rm_room.Controls.Add(Me.Label3)
        Me.pan_rm_room.Controls.Add(Me.Label6)
        Me.pan_rm_room.Controls.Add(Me.tb_room_no)
        Me.pan_rm_room.Controls.Add(Me.BunifuMetroTextbox3)
        Me.pan_rm_room.Controls.Add(Me.Label4)
        Me.pan_rm_room.Controls.Add(Me.tb_room_total_capacity)
        Me.pan_rm_room.Controls.Add(Me.cmb_room_type)
        Me.pan_rm_room.Controls.Add(Me.Label5)
        Me.pan_rm_room.Location = New System.Drawing.Point(13, 16)
        Me.pan_rm_room.Name = "pan_rm_room"
        Me.pan_rm_room.Size = New System.Drawing.Size(1593, 870)
        Me.pan_rm_room.TabIndex = 19
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.Transparent
        Me.btn_reset.BackgroundImage = Global.Infinity.My.Resources.Resources.Reset_32x32
        Me.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reset.Location = New System.Drawing.Point(600, 21)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(52, 30)
        Me.btn_reset.TabIndex = 93
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'tb_desc
        '
        Me.tb_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_desc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_desc.Location = New System.Drawing.Point(23, 541)
        Me.tb_desc.Name = "tb_desc"
        Me.tb_desc.Size = New System.Drawing.Size(1542, 304)
        Me.tb_desc.TabIndex = 92
        Me.tb_desc.Text = ""
        '
        'tb_room_id
        '
        Me.tb_room_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_room_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_room_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_room_id.BorderThickness = 1
        Me.tb_room_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_room_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_room_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_id.isPassword = False
        Me.tb_room_id.Location = New System.Drawing.Point(248, 104)
        Me.tb_room_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_room_id.Name = "tb_room_id"
        Me.tb_room_id.Size = New System.Drawing.Size(341, 33)
        Me.tb_room_id.TabIndex = 49
        Me.tb_room_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 501)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 28)
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
        Me.tb_room_prize.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_room_prize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_prize.isPassword = False
        Me.tb_room_prize.Location = New System.Drawing.Point(530, 277)
        Me.tb_room_prize.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_room_prize.Name = "tb_room_prize"
        Me.tb_room_prize.Size = New System.Drawing.Size(235, 33)
        Me.tb_room_prize.TabIndex = 46
        Me.tb_room_prize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 28)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Room Id:-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(417, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 28)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Price:-"
        '
        'pb_room_images
        '
        Me.pb_room_images.BackColor = System.Drawing.Color.Silver
        Me.pb_room_images.Location = New System.Drawing.Point(1001, 21)
        Me.pb_room_images.Name = "pb_room_images"
        Me.pb_room_images.Size = New System.Drawing.Size(564, 461)
        Me.pb_room_images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_room_images.TabIndex = 44
        Me.pb_room_images.TabStop = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.BackgroundImage = Global.Infinity.My.Resources.Resources.Find_32x32
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Location = New System.Drawing.Point(536, 23)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(52, 30)
        Me.btn_search.TabIndex = 34
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 28)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Room No:-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(595, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 28)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Aquired By People :-"
        '
        'tb_room_no
        '
        Me.tb_room_no.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_room_no.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_room_no.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_no.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_room_no.BorderThickness = 1
        Me.tb_room_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_room_no.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_room_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_no.isPassword = False
        Me.tb_room_no.Location = New System.Drawing.Point(248, 21)
        Me.tb_room_no.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_room_no.Name = "tb_room_no"
        Me.tb_room_no.Size = New System.Drawing.Size(341, 33)
        Me.tb_room_no.TabIndex = 36
        Me.tb_room_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox3
        '
        Me.BunifuMetroTextbox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox3.BorderThickness = 1
        Me.BunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.isPassword = False
        Me.BunifuMetroTextbox3.Location = New System.Drawing.Point(866, 189)
        Me.BunifuMetroTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox3.Name = "BunifuMetroTextbox3"
        Me.BunifuMetroTextbox3.Size = New System.Drawing.Size(67, 33)
        Me.BunifuMetroTextbox3.TabIndex = 41
        Me.BunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 28)
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
        Me.tb_room_total_capacity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_room_total_capacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_room_total_capacity.isPassword = False
        Me.tb_room_total_capacity.Location = New System.Drawing.Point(248, 282)
        Me.tb_room_total_capacity.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_room_total_capacity.Name = "tb_room_total_capacity"
        Me.tb_room_total_capacity.Size = New System.Drawing.Size(53, 33)
        Me.tb_room_total_capacity.TabIndex = 40
        Me.tb_room_total_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmb_room_type
        '
        Me.cmb_room_type.BackColor = System.Drawing.Color.Silver
        Me.cmb_room_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_room_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_room_type.FormattingEnabled = True
        Me.cmb_room_type.Items.AddRange(New Object() {"Silver ", "Gold", "Platinum"})
        Me.cmb_room_type.Location = New System.Drawing.Point(248, 184)
        Me.cmb_room_type.Name = "cmb_room_type"
        Me.cmb_room_type.Size = New System.Drawing.Size(341, 33)
        Me.cmb_room_type.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 28)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Total Capacity :-"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1612, 892)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Room Lists"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tb_search_type)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.cmb_Search_type)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.dg_rm_ri_view)
        Me.Panel4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1612, 886)
        Me.Panel4.TabIndex = 0
        '
        'tb_search_type
        '
        Me.tb_search_type.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_search_type.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_search_type.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_search_type.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_search_type.BorderThickness = 1
        Me.tb_search_type.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_search_type.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_search_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_search_type.isPassword = False
        Me.tb_search_type.Location = New System.Drawing.Point(575, 16)
        Me.tb_search_type.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_search_type.Name = "tb_search_type"
        Me.tb_search_type.Size = New System.Drawing.Size(235, 33)
        Me.tb_search_type.TabIndex = 90
        Me.tb_search_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(160, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 23)
        Me.Label22.TabIndex = 89
        Me.Label22.Text = "View By :"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkGray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(817, 18)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 26)
        Me.Button8.TabIndex = 88
        Me.Button8.Text = "search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'cmb_Search_type
        '
        Me.cmb_Search_type.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_Search_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_Search_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Search_type.FormattingEnabled = True
        Me.cmb_Search_type.Location = New System.Drawing.Point(285, 17)
        Me.cmb_Search_type.Name = "cmb_Search_type"
        Me.cmb_Search_type.Size = New System.Drawing.Size(240, 28)
        Me.cmb_Search_type.TabIndex = 87
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button2.Location = New System.Drawing.Point(15, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 33)
        Me.Button2.TabIndex = 86
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dg_rm_ri_view
        '
        Me.dg_rm_ri_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_rm_ri_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_rm_ri_view.Location = New System.Drawing.Point(0, 69)
        Me.dg_rm_ri_view.Name = "dg_rm_ri_view"
        Me.dg_rm_ri_view.Size = New System.Drawing.Size(1609, 817)
        Me.dg_rm_ri_view.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(16, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uchotel_room_manegement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uchotel_room_manegement"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pan_rm_room.ResumeLayout(False)
        Me.pan_rm_room.PerformLayout()
        CType(Me.pb_room_images, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dg_rm_ri_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dg_rm_ri_view As DataGridView
    Friend WithEvents pan_rm_room As Panel
    Friend WithEvents tb_room_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_room_prize As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pb_room_images As PictureBox
    Friend WithEvents btn_search As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_room_no As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_room_total_capacity As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents cmb_room_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents tb_desc As RichTextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents tb_search_type As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label22 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents cmb_Search_type As ComboBox
    Friend WithEvents Button1 As Button
End Class
