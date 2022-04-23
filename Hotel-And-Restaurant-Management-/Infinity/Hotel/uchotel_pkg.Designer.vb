<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uchotel_pkg
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
        Me.pan_view_pkg = New System.Windows.Forms.Panel()
        Me.tb_pkg_type = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btn_pkg_reset = New System.Windows.Forms.Button()
        Me.btn_pkg_search = New System.Windows.Forms.Button()
        Me.tb_pkg_prize = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_pi_pkg_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.pb_pkg_img = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_pkg_name = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_pkg_nights = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_pkg_days = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pan_all_pkg_detail = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pan_view_pkg.SuspendLayout()
        CType(Me.pb_pkg_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(83, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1552, 54)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(730, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Package Info"
        '
        'pan_view_pkg
        '
        Me.pan_view_pkg.Controls.Add(Me.tb_pkg_type)
        Me.pan_view_pkg.Controls.Add(Me.btn_pkg_reset)
        Me.pan_view_pkg.Controls.Add(Me.btn_pkg_search)
        Me.pan_view_pkg.Controls.Add(Me.tb_pkg_prize)
        Me.pan_view_pkg.Controls.Add(Me.Label2)
        Me.pan_view_pkg.Controls.Add(Me.Label8)
        Me.pan_view_pkg.Controls.Add(Me.tb_pi_pkg_id)
        Me.pan_view_pkg.Controls.Add(Me.pb_pkg_img)
        Me.pan_view_pkg.Controls.Add(Me.Label7)
        Me.pan_view_pkg.Controls.Add(Me.Label3)
        Me.pan_view_pkg.Controls.Add(Me.Label6)
        Me.pan_view_pkg.Controls.Add(Me.tb_pkg_name)
        Me.pan_view_pkg.Controls.Add(Me.tb_pkg_nights)
        Me.pan_view_pkg.Controls.Add(Me.Label4)
        Me.pan_view_pkg.Controls.Add(Me.tb_pkg_days)
        Me.pan_view_pkg.Controls.Add(Me.Label5)
        Me.pan_view_pkg.Location = New System.Drawing.Point(15, 102)
        Me.pan_view_pkg.Name = "pan_view_pkg"
        Me.pan_view_pkg.Size = New System.Drawing.Size(1620, 367)
        Me.pan_view_pkg.TabIndex = 17
        '
        'tb_pkg_type
        '
        Me.tb_pkg_type.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pkg_type.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pkg_type.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_type.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pkg_type.BorderThickness = 1
        Me.tb_pkg_type.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pkg_type.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pkg_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_type.isPassword = False
        Me.tb_pkg_type.Location = New System.Drawing.Point(210, 164)
        Me.tb_pkg_type.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pkg_type.Name = "tb_pkg_type"
        Me.tb_pkg_type.Size = New System.Drawing.Size(392, 33)
        Me.tb_pkg_type.TabIndex = 48
        Me.tb_pkg_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_pkg_reset
        '
        Me.btn_pkg_reset.BackColor = System.Drawing.Color.Transparent
        Me.btn_pkg_reset.BackgroundImage = Global.Infinity.My.Resources.Resources.Reset_32x32
        Me.btn_pkg_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_pkg_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pkg_reset.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pkg_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_pkg_reset.Location = New System.Drawing.Point(609, 23)
        Me.btn_pkg_reset.Name = "btn_pkg_reset"
        Me.btn_pkg_reset.Size = New System.Drawing.Size(51, 30)
        Me.btn_pkg_reset.TabIndex = 3
        Me.btn_pkg_reset.UseVisualStyleBackColor = False
        '
        'btn_pkg_search
        '
        Me.btn_pkg_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_pkg_search.BackgroundImage = Global.Infinity.My.Resources.Resources.Find_32x32
        Me.btn_pkg_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_pkg_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pkg_search.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pkg_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_pkg_search.Location = New System.Drawing.Point(549, 23)
        Me.btn_pkg_search.Name = "btn_pkg_search"
        Me.btn_pkg_search.Size = New System.Drawing.Size(51, 30)
        Me.btn_pkg_search.TabIndex = 2
        Me.btn_pkg_search.UseVisualStyleBackColor = False
        '
        'tb_pkg_prize
        '
        Me.tb_pkg_prize.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pkg_prize.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pkg_prize.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_prize.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pkg_prize.BorderThickness = 1
        Me.tb_pkg_prize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pkg_prize.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pkg_prize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_prize.isPassword = False
        Me.tb_pkg_prize.Location = New System.Drawing.Point(170, 300)
        Me.tb_pkg_prize.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pkg_prize.Name = "tb_pkg_prize"
        Me.tb_pkg_prize.Size = New System.Drawing.Size(250, 47)
        Me.tb_pkg_prize.TabIndex = 46
        Me.tb_pkg_prize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Package Id:-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 23)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Grand Prize:-"
        '
        'tb_pi_pkg_id
        '
        Me.tb_pi_pkg_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pi_pkg_id.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pi_pkg_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pi_pkg_id.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pi_pkg_id.BorderThickness = 1
        Me.tb_pi_pkg_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pi_pkg_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pi_pkg_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pi_pkg_id.isPassword = False
        Me.tb_pi_pkg_id.Location = New System.Drawing.Point(210, 21)
        Me.tb_pi_pkg_id.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pi_pkg_id.Name = "tb_pi_pkg_id"
        Me.tb_pi_pkg_id.Size = New System.Drawing.Size(392, 33)
        Me.tb_pi_pkg_id.TabIndex = 1
        Me.tb_pi_pkg_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pb_pkg_img
        '
        Me.pb_pkg_img.Location = New System.Drawing.Point(854, 3)
        Me.pb_pkg_img.Name = "pb_pkg_img"
        Me.pb_pkg_img.Size = New System.Drawing.Size(654, 330)
        Me.pb_pkg_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_pkg_img.TabIndex = 44
        Me.pb_pkg_img.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(332, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Nights"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 23)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Package Name :-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(199, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 23)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Days"
        '
        'tb_pkg_name
        '
        Me.tb_pkg_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pkg_name.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pkg_name.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_name.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pkg_name.BorderThickness = 1
        Me.tb_pkg_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pkg_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pkg_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_name.isPassword = False
        Me.tb_pkg_name.Location = New System.Drawing.Point(210, 89)
        Me.tb_pkg_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pkg_name.Name = "tb_pkg_name"
        Me.tb_pkg_name.Size = New System.Drawing.Size(392, 33)
        Me.tb_pkg_name.TabIndex = 36
        Me.tb_pkg_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_pkg_nights
        '
        Me.tb_pkg_nights.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pkg_nights.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pkg_nights.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_nights.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pkg_nights.BorderThickness = 1
        Me.tb_pkg_nights.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pkg_nights.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pkg_nights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_nights.isPassword = False
        Me.tb_pkg_nights.Location = New System.Drawing.Point(268, 243)
        Me.tb_pkg_nights.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pkg_nights.Name = "tb_pkg_nights"
        Me.tb_pkg_nights.Size = New System.Drawing.Size(57, 33)
        Me.tb_pkg_nights.TabIndex = 41
        Me.tb_pkg_nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Package Type :-"
        '
        'tb_pkg_days
        '
        Me.tb_pkg_days.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pkg_days.BorderColorFocused = System.Drawing.Color.Blue
        Me.tb_pkg_days.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_days.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pkg_days.BorderThickness = 1
        Me.tb_pkg_days.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pkg_days.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tb_pkg_days.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pkg_days.isPassword = False
        Me.tb_pkg_days.Location = New System.Drawing.Point(135, 243)
        Me.tb_pkg_days.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pkg_days.Name = "tb_pkg_days"
        Me.tb_pkg_days.Size = New System.Drawing.Size(57, 33)
        Me.tb_pkg_days.TabIndex = 40
        Me.tb_pkg_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 23)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Duration :-"
        '
        'pan_all_pkg_detail
        '
        Me.pan_all_pkg_detail.AutoScroll = True
        Me.pan_all_pkg_detail.Location = New System.Drawing.Point(15, 488)
        Me.pan_all_pkg_detail.Name = "pan_all_pkg_detail"
        Me.pan_all_pkg_detail.Size = New System.Drawing.Size(1620, 530)
        Me.pan_all_pkg_detail.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(21, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uchotel_pkg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pan_all_pkg_detail)
        Me.Controls.Add(Me.pan_view_pkg)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uchotel_pkg"
        Me.Size = New System.Drawing.Size(1653, 1043)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pan_view_pkg.ResumeLayout(False)
        Me.pan_view_pkg.PerformLayout()
        CType(Me.pb_pkg_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pan_view_pkg As Panel
    Friend WithEvents tb_pkg_prize As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_pi_pkg_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents pb_pkg_img As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_pkg_name As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_pkg_nights As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_pkg_days As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_pkg_search As Button
    Friend WithEvents btn_pkg_reset As Button
    Friend WithEvents tb_pkg_type As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents pan_all_pkg_detail As Panel
    Friend WithEvents Button1 As Button
End Class
