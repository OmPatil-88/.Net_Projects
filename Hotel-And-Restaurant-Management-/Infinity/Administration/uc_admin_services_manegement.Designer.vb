<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_admin_services_manegement
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
        Me.pan_main_services = New System.Windows.Forms.Panel()
        Me.btn_sm_search = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_services_prize = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rb_hotel = New System.Windows.Forms.RadioButton()
        Me.rb_restrurant = New System.Windows.Forms.RadioButton()
        Me.btn_services_save = New System.Windows.Forms.Button()
        Me.btn_services_Hold = New System.Windows.Forms.Button()
        Me.cmb_sm_services_type = New System.Windows.Forms.ComboBox()
        Me.btn_sm_new = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_services_update = New System.Windows.Forms.Button()
        Me.tb_sm_services_name = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_sm_services_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pan_main_services.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(96, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1542, 54)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(618, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Services Manegament"
        '
        'pan_main_services
        '
        Me.pan_main_services.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pan_main_services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pan_main_services.Controls.Add(Me.btn_sm_search)
        Me.pan_main_services.Controls.Add(Me.Label5)
        Me.pan_main_services.Controls.Add(Me.tb_services_prize)
        Me.pan_main_services.Controls.Add(Me.Panel4)
        Me.pan_main_services.Controls.Add(Me.btn_services_save)
        Me.pan_main_services.Controls.Add(Me.btn_services_Hold)
        Me.pan_main_services.Controls.Add(Me.cmb_sm_services_type)
        Me.pan_main_services.Controls.Add(Me.btn_sm_new)
        Me.pan_main_services.Controls.Add(Me.Label4)
        Me.pan_main_services.Controls.Add(Me.btn_services_update)
        Me.pan_main_services.Controls.Add(Me.tb_sm_services_name)
        Me.pan_main_services.Controls.Add(Me.Label3)
        Me.pan_main_services.Controls.Add(Me.Label2)
        Me.pan_main_services.Controls.Add(Me.tb_sm_services_id)
        Me.pan_main_services.Location = New System.Drawing.Point(495, 149)
        Me.pan_main_services.Name = "pan_main_services"
        Me.pan_main_services.Size = New System.Drawing.Size(670, 734)
        Me.pan_main_services.TabIndex = 25
        '
        'btn_sm_search
        '
        Me.btn_sm_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_sm_search.BackgroundImage = Global.Infinity.My.Resources.Resources.Find_32x32
        Me.btn_sm_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_sm_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sm_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sm_search.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sm_search.Location = New System.Drawing.Point(572, 58)
        Me.btn_sm_search.Name = "btn_sm_search"
        Me.btn_sm_search.Size = New System.Drawing.Size(50, 40)
        Me.btn_sm_search.TabIndex = 61
        Me.btn_sm_search.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 493)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Prize :-"
        '
        'tb_services_prize
        '
        Me.tb_services_prize.BackColor = System.Drawing.SystemColors.Window
        Me.tb_services_prize.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_services_prize.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_services_prize.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_services_prize.BorderThickness = 1
        Me.tb_services_prize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_services_prize.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_services_prize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_services_prize.isPassword = False
        Me.tb_services_prize.Location = New System.Drawing.Point(124, 493)
        Me.tb_services_prize.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_services_prize.Name = "tb_services_prize"
        Me.tb_services_prize.Size = New System.Drawing.Size(501, 40)
        Me.tb_services_prize.TabIndex = 6
        Me.tb_services_prize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rb_hotel)
        Me.Panel4.Controls.Add(Me.rb_restrurant)
        Me.Panel4.Location = New System.Drawing.Point(156, 255)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(400, 35)
        Me.Panel4.TabIndex = 73
        '
        'rb_hotel
        '
        Me.rb_hotel.AutoSize = True
        Me.rb_hotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_hotel.Location = New System.Drawing.Point(51, 2)
        Me.rb_hotel.Name = "rb_hotel"
        Me.rb_hotel.Size = New System.Drawing.Size(75, 29)
        Me.rb_hotel.TabIndex = 3
        Me.rb_hotel.TabStop = True
        Me.rb_hotel.Text = "Hotel"
        Me.rb_hotel.UseVisualStyleBackColor = True
        '
        'rb_restrurant
        '
        Me.rb_restrurant.AutoSize = True
        Me.rb_restrurant.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_restrurant.Location = New System.Drawing.Point(218, 4)
        Me.rb_restrurant.Name = "rb_restrurant"
        Me.rb_restrurant.Size = New System.Drawing.Size(113, 29)
        Me.rb_restrurant.TabIndex = 4
        Me.rb_restrurant.TabStop = True
        Me.rb_restrurant.Text = "Restarunt"
        Me.rb_restrurant.UseVisualStyleBackColor = True
        '
        'btn_services_save
        '
        Me.btn_services_save.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_services_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_services_save.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_services_save.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_services_save.Location = New System.Drawing.Point(195, 614)
        Me.btn_services_save.Name = "btn_services_save"
        Me.btn_services_save.Size = New System.Drawing.Size(130, 42)
        Me.btn_services_save.TabIndex = 8
        Me.btn_services_save.Text = "Save"
        Me.btn_services_save.UseVisualStyleBackColor = False
        '
        'btn_services_Hold
        '
        Me.btn_services_Hold.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_services_Hold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_services_Hold.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_services_Hold.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_services_Hold.Location = New System.Drawing.Point(339, 614)
        Me.btn_services_Hold.Name = "btn_services_Hold"
        Me.btn_services_Hold.Size = New System.Drawing.Size(130, 42)
        Me.btn_services_Hold.TabIndex = 9
        Me.btn_services_Hold.Text = "Hold"
        Me.btn_services_Hold.UseVisualStyleBackColor = False
        '
        'cmb_sm_services_type
        '
        Me.cmb_sm_services_type.BackColor = System.Drawing.Color.Silver
        Me.cmb_sm_services_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_sm_services_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sm_services_type.FormattingEnabled = True
        Me.cmb_sm_services_type.Location = New System.Drawing.Point(182, 365)
        Me.cmb_sm_services_type.Name = "cmb_sm_services_type"
        Me.cmb_sm_services_type.Size = New System.Drawing.Size(443, 33)
        Me.cmb_sm_services_type.TabIndex = 5
        '
        'btn_sm_new
        '
        Me.btn_sm_new.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_sm_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sm_new.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sm_new.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sm_new.Location = New System.Drawing.Point(51, 617)
        Me.btn_sm_new.Name = "btn_sm_new"
        Me.btn_sm_new.Size = New System.Drawing.Size(130, 38)
        Me.btn_sm_new.TabIndex = 7
        Me.btn_sm_new.Text = "New"
        Me.btn_sm_new.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Name :-"
        '
        'btn_services_update
        '
        Me.btn_services_update.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_services_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_services_update.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_services_update.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_services_update.Location = New System.Drawing.Point(483, 614)
        Me.btn_services_update.Name = "btn_services_update"
        Me.btn_services_update.Size = New System.Drawing.Size(130, 42)
        Me.btn_services_update.TabIndex = 10
        Me.btn_services_update.Text = "Update"
        Me.btn_services_update.UseVisualStyleBackColor = False
        '
        'tb_sm_services_name
        '
        Me.tb_sm_services_name.BackColor = System.Drawing.SystemColors.Window
        Me.tb_sm_services_name.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_sm_services_name.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_sm_services_name.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_sm_services_name.BorderThickness = 1
        Me.tb_sm_services_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_sm_services_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_sm_services_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_sm_services_name.isPassword = False
        Me.tb_sm_services_name.Location = New System.Drawing.Point(182, 154)
        Me.tb_sm_services_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_sm_services_name.Name = "tb_sm_services_name"
        Me.tb_sm_services_name.Size = New System.Drawing.Size(443, 42)
        Me.tb_sm_services_name.TabIndex = 2
        Me.tb_sm_services_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 369)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 25)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Services Type :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Services Id :-"
        '
        'tb_sm_services_id
        '
        Me.tb_sm_services_id.BackColor = System.Drawing.SystemColors.Window
        Me.tb_sm_services_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_sm_services_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_sm_services_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_sm_services_id.BorderThickness = 1
        Me.tb_sm_services_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_sm_services_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_sm_services_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_sm_services_id.isPassword = False
        Me.tb_sm_services_id.Location = New System.Drawing.Point(182, 56)
        Me.tb_sm_services_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_sm_services_id.Name = "tb_sm_services_id"
        Me.tb_sm_services_id.Size = New System.Drawing.Size(443, 43)
        Me.tb_sm_services_id.TabIndex = 1
        Me.tb_sm_services_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(25, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_admin_services_manegement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pan_main_services)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_admin_services_manegement"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pan_main_services.ResumeLayout(False)
        Me.pan_main_services.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pan_main_services As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rb_hotel As RadioButton
    Friend WithEvents rb_restrurant As RadioButton
    Friend WithEvents btn_services_save As Button
    Friend WithEvents cmb_sm_services_type As ComboBox
    Friend WithEvents btn_sm_new As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_services_update As Button
    Friend WithEvents tb_sm_services_name As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_sm_services_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_services_prize As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btn_services_Hold As Button
    Friend WithEvents btn_sm_search As Button
    Friend WithEvents Button1 As Button
End Class
