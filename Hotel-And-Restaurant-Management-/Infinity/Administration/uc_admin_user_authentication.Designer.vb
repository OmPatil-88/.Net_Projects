<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_admin_user_authentication
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
        Me.pb_um_user_image = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_um_name = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_pass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_con_pass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmb_um_user_roll = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_um_update = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_um_delete = New System.Windows.Forms.Button()
        Me.btn_save_password = New System.Windows.Forms.Button()
        Me.dg_user_manegament = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lbl_password_confirmation = New System.Windows.Forms.Label()
        Me.btn_um_search = New System.Windows.Forms.Button()
        Me.tb_um_user_name = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_um_user_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_user_manegament, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(85, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1555, 54)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(654, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Manegament"
        '
        'pb_um_user_image
        '
        Me.pb_um_user_image.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pb_um_user_image.Image = Global.Infinity.My.Resources.Resources.user
        Me.pb_um_user_image.Location = New System.Drawing.Point(1326, 103)
        Me.pb_um_user_image.Name = "pb_um_user_image"
        Me.pb_um_user_image.Size = New System.Drawing.Size(244, 192)
        Me.pb_um_user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_um_user_image.TabIndex = 39
        Me.pb_um_user_image.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "User ID:-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = " Name :-"
        '
        'tb_um_name
        '
        Me.tb_um_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_um_name.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_um_name.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_name.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_um_name.BorderThickness = 1
        Me.tb_um_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_um_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_um_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_name.isPassword = False
        Me.tb_um_name.Location = New System.Drawing.Point(292, 229)
        Me.tb_um_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_um_name.Name = "tb_um_name"
        Me.tb_um_name.Size = New System.Drawing.Size(579, 33)
        Me.tb_um_name.TabIndex = 3
        Me.tb_um_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 23)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Password  :-"
        '
        'tb_pass
        '
        Me.tb_pass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pass.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pass.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pass.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pass.BorderThickness = 1
        Me.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pass.isPassword = True
        Me.tb_pass.Location = New System.Drawing.Point(292, 321)
        Me.tb_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.Size = New System.Drawing.Size(580, 33)
        Me.tb_pass.TabIndex = 4
        Me.tb_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 23)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Confirm Password  :-"
        '
        'tb_con_pass
        '
        Me.tb_con_pass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_con_pass.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_con_pass.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_con_pass.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_con_pass.BorderThickness = 1
        Me.tb_con_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_con_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_con_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_con_pass.isPassword = True
        Me.tb_con_pass.Location = New System.Drawing.Point(292, 402)
        Me.tb_con_pass.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_con_pass.Name = "tb_con_pass"
        Me.tb_con_pass.Size = New System.Drawing.Size(581, 33)
        Me.tb_con_pass.TabIndex = 5
        Me.tb_con_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Location = New System.Drawing.Point(816, 323)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(55, 30)
        Me.btn_search.TabIndex = 48
        Me.btn_search.Text = "srh"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(817, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 30)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "srh"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmb_um_user_roll
        '
        Me.cmb_um_user_roll.BackColor = System.Drawing.Color.Silver
        Me.cmb_um_user_roll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_um_user_roll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_um_user_roll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_um_user_roll.FormattingEnabled = True
        Me.cmb_um_user_roll.Items.AddRange(New Object() {"Administration", "Chef", "Employe", "Recepationeast"})
        Me.cmb_um_user_roll.Location = New System.Drawing.Point(1082, 320)
        Me.cmb_um_user_roll.Name = "cmb_um_user_roll"
        Me.cmb_um_user_roll.Size = New System.Drawing.Size(330, 33)
        Me.cmb_um_user_roll.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(940, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "User Role :-"
        '
        'btn_um_update
        '
        Me.btn_um_update.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_um_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_um_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_um_update.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_um_update.Location = New System.Drawing.Point(1376, 438)
        Me.btn_um_update.Name = "btn_um_update"
        Me.btn_um_update.Size = New System.Drawing.Size(130, 42)
        Me.btn_um_update.TabIndex = 11
        Me.btn_um_update.Text = "Update"
        Me.btn_um_update.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Location = New System.Drawing.Point(944, 440)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 38)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "New"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btn_um_delete
        '
        Me.btn_um_delete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_um_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_um_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_um_delete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_um_delete.Location = New System.Drawing.Point(1232, 438)
        Me.btn_um_delete.Name = "btn_um_delete"
        Me.btn_um_delete.Size = New System.Drawing.Size(130, 42)
        Me.btn_um_delete.TabIndex = 10
        Me.btn_um_delete.Text = "Delete"
        Me.btn_um_delete.UseVisualStyleBackColor = False
        '
        'btn_save_password
        '
        Me.btn_save_password.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_save_password.Enabled = False
        Me.btn_save_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_password.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save_password.Location = New System.Drawing.Point(1088, 438)
        Me.btn_save_password.Name = "btn_save_password"
        Me.btn_save_password.Size = New System.Drawing.Size(130, 42)
        Me.btn_save_password.TabIndex = 9
        Me.btn_save_password.Text = "Save"
        Me.btn_save_password.UseVisualStyleBackColor = False
        '
        'dg_user_manegament
        '
        Me.dg_user_manegament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_user_manegament.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dg_user_manegament.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_user_manegament.Location = New System.Drawing.Point(32, 498)
        Me.dg_user_manegament.Name = "dg_user_manegament"
        Me.dg_user_manegament.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_user_manegament.Size = New System.Drawing.Size(1599, 523)
        Me.dg_user_manegament.TabIndex = 57
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(1576, 263)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(55, 33)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Browse"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'lbl_password_confirmation
        '
        Me.lbl_password_confirmation.AutoSize = True
        Me.lbl_password_confirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password_confirmation.ForeColor = System.Drawing.Color.Green
        Me.lbl_password_confirmation.Location = New System.Drawing.Point(292, 438)
        Me.lbl_password_confirmation.Name = "lbl_password_confirmation"
        Me.lbl_password_confirmation.Size = New System.Drawing.Size(123, 16)
        Me.lbl_password_confirmation.TabIndex = 59
        Me.lbl_password_confirmation.Text = "Password Matched"
        Me.lbl_password_confirmation.Visible = False
        '
        'btn_um_search
        '
        Me.btn_um_search.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_um_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_um_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_um_search.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_um_search.Location = New System.Drawing.Point(872, 138)
        Me.btn_um_search.Name = "btn_um_search"
        Me.btn_um_search.Size = New System.Drawing.Size(73, 33)
        Me.btn_um_search.TabIndex = 2
        Me.btn_um_search.Text = "Search"
        Me.btn_um_search.UseVisualStyleBackColor = False
        '
        'tb_um_user_name
        '
        Me.tb_um_user_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_um_user_name.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_um_user_name.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_user_name.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_um_user_name.BorderThickness = 1
        Me.tb_um_user_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_um_user_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_um_user_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_um_user_name.isPassword = False
        Me.tb_um_user_name.Location = New System.Drawing.Point(292, 138)
        Me.tb_um_user_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_um_user_name.Name = "tb_um_user_name"
        Me.tb_um_user_name.Size = New System.Drawing.Size(579, 33)
        Me.tb_um_user_name.TabIndex = 1
        Me.tb_um_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(23, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_admin_user_authentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_um_search)
        Me.Controls.Add(Me.lbl_password_confirmation)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.dg_user_manegament)
        Me.Controls.Add(Me.btn_save_password)
        Me.Controls.Add(Me.btn_um_delete)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_um_update)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_um_user_roll)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_con_pass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_um_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_um_user_name)
        Me.Controls.Add(Me.pb_um_user_image)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_admin_user_authentication"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_um_user_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_user_manegament, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pb_um_user_image As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_um_name As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_pass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_con_pass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btn_search As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmb_um_user_roll As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_um_update As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btn_um_delete As Button
    Friend WithEvents btn_save_password As Button
    Friend WithEvents dg_user_manegament As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents lbl_password_confirmation As Label
    Friend WithEvents btn_um_search As Button
    Friend WithEvents tb_um_user_name As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button1 As Button
End Class
