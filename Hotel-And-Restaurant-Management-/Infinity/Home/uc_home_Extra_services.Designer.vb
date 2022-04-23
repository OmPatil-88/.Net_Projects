<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_home_Extra_services
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tb_ec_check_in_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_ec_service_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_em_cost = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btn_update_all_menu_data = New System.Windows.Forms.Button()
        Me.tb_ec_services_name = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.panel_main_charge = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panel_main_charge.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Location = New System.Drawing.Point(65, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1573, 50)
        Me.Panel1.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(618, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Extra Charge"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(1229, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tb_ec_check_in_id
        '
        Me.tb_ec_check_in_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_ec_check_in_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_ec_check_in_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_ec_check_in_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_ec_check_in_id.BorderThickness = 1
        Me.tb_ec_check_in_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_ec_check_in_id.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.tb_ec_check_in_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_ec_check_in_id.isPassword = False
        Me.tb_ec_check_in_id.Location = New System.Drawing.Point(258, 19)
        Me.tb_ec_check_in_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_ec_check_in_id.Name = "tb_ec_check_in_id"
        Me.tb_ec_check_in_id.Size = New System.Drawing.Size(334, 38)
        Me.tb_ec_check_in_id.TabIndex = 30
        Me.tb_ec_check_in_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Check In ID :-"
        '
        'tb_ec_service_id
        '
        Me.tb_ec_service_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_ec_service_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_ec_service_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_ec_service_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_ec_service_id.BorderThickness = 1
        Me.tb_ec_service_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_ec_service_id.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.tb_ec_service_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_ec_service_id.isPassword = False
        Me.tb_ec_service_id.Location = New System.Drawing.Point(258, 117)
        Me.tb_ec_service_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_ec_service_id.Name = "tb_ec_service_id"
        Me.tb_ec_service_id.Size = New System.Drawing.Size(334, 38)
        Me.tb_ec_service_id.TabIndex = 67
        Me.tb_ec_service_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Services ID :-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 23)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Services Name :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Cost :-"
        '
        'tb_em_cost
        '
        Me.tb_em_cost.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_em_cost.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_em_cost.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_cost.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_em_cost.BorderThickness = 1
        Me.tb_em_cost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_em_cost.Enabled = False
        Me.tb_em_cost.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.tb_em_cost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_em_cost.isPassword = False
        Me.tb_em_cost.Location = New System.Drawing.Point(258, 320)
        Me.tb_em_cost.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_em_cost.Name = "tb_em_cost"
        Me.tb_em_cost.Size = New System.Drawing.Size(334, 38)
        Me.tb_em_cost.TabIndex = 89
        Me.tb_em_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_update_all_menu_data
        '
        Me.btn_update_all_menu_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btn_update_all_menu_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update_all_menu_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_all_menu_data.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_update_all_menu_data.Location = New System.Drawing.Point(231, 425)
        Me.btn_update_all_menu_data.Name = "btn_update_all_menu_data"
        Me.btn_update_all_menu_data.Size = New System.Drawing.Size(135, 47)
        Me.btn_update_all_menu_data.TabIndex = 98
        Me.btn_update_all_menu_data.Text = "Add"
        Me.btn_update_all_menu_data.UseVisualStyleBackColor = False
        '
        'tb_ec_services_name
        '
        Me.tb_ec_services_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_ec_services_name.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_ec_services_name.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_ec_services_name.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_ec_services_name.BorderThickness = 1
        Me.tb_ec_services_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_ec_services_name.Enabled = False
        Me.tb_ec_services_name.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.tb_ec_services_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_ec_services_name.isPassword = False
        Me.tb_ec_services_name.Location = New System.Drawing.Point(258, 222)
        Me.tb_ec_services_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_ec_services_name.Name = "tb_ec_services_name"
        Me.tb_ec_services_name.Size = New System.Drawing.Size(334, 38)
        Me.tb_ec_services_name.TabIndex = 102
        Me.tb_ec_services_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panel_main_charge
        '
        Me.panel_main_charge.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel_main_charge.Controls.Add(Me.Label5)
        Me.panel_main_charge.Controls.Add(Me.tb_ec_services_name)
        Me.panel_main_charge.Controls.Add(Me.Label2)
        Me.panel_main_charge.Controls.Add(Me.Label7)
        Me.panel_main_charge.Controls.Add(Me.tb_ec_check_in_id)
        Me.panel_main_charge.Controls.Add(Me.btn_update_all_menu_data)
        Me.panel_main_charge.Controls.Add(Me.tb_em_cost)
        Me.panel_main_charge.Controls.Add(Me.tb_ec_service_id)
        Me.panel_main_charge.Controls.Add(Me.Label4)
        Me.panel_main_charge.Location = New System.Drawing.Point(405, 106)
        Me.panel_main_charge.Name = "panel_main_charge"
        Me.panel_main_charge.Size = New System.Drawing.Size(672, 511)
        Me.panel_main_charge.TabIndex = 103
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 50)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_home_Extra_services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.panel_main_charge)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_home_Extra_services"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_main_charge.ResumeLayout(False)
        Me.panel_main_charge.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents tb_ec_check_in_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_ec_service_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_em_cost As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btn_update_all_menu_data As Button
    Friend WithEvents tb_ec_services_name As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents panel_main_charge As Panel
    Friend WithEvents Button1 As Button
End Class
