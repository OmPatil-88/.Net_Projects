<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_menu))
        Me.menu_panel = New System.Windows.Forms.Panel()
        Me.lb_user_name = New System.Windows.Forms.Label()
        Me.pb_user = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.pan_moving = New System.Windows.Forms.Panel()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_administartion = New System.Windows.Forms.Button()
        Me.btn_hotal = New System.Windows.Forms.Button()
        Me.btn_restorunt = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_global_usr_statues = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.main_img_slider = New DevExpress.XtraEditors.Controls.ImageSlider()
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.menu_panel.SuspendLayout()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.main_img_slider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.main_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_panel
        '
        Me.menu_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.menu_panel.Controls.Add(Me.lb_user_name)
        Me.menu_panel.Controls.Add(Me.pb_user)
        Me.menu_panel.Controls.Add(Me.btn_logout)
        Me.menu_panel.Controls.Add(Me.pan_moving)
        Me.menu_panel.Controls.Add(Me.btn_report)
        Me.menu_panel.Controls.Add(Me.btn_administartion)
        Me.menu_panel.Controls.Add(Me.btn_hotal)
        Me.menu_panel.Controls.Add(Me.btn_restorunt)
        Me.menu_panel.Controls.Add(Me.btn_home)
        Me.menu_panel.Controls.Add(Me.Panel1)
        Me.menu_panel.Controls.Add(Me.lbl_global_usr_statues)
        Me.menu_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.menu_panel.Location = New System.Drawing.Point(0, 0)
        Me.menu_panel.Margin = New System.Windows.Forms.Padding(4)
        Me.menu_panel.Name = "menu_panel"
        Me.menu_panel.Size = New System.Drawing.Size(267, 1080)
        Me.menu_panel.TabIndex = 0
        '
        'lb_user_name
        '
        Me.lb_user_name.AutoSize = True
        Me.lb_user_name.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lb_user_name.ForeColor = System.Drawing.Color.White
        Me.lb_user_name.Location = New System.Drawing.Point(4, 1012)
        Me.lb_user_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_user_name.Name = "lb_user_name"
        Me.lb_user_name.Size = New System.Drawing.Size(71, 23)
        Me.lb_user_name.TabIndex = 17
        Me.lb_user_name.Text = "Name"
        '
        'pb_user
        '
        Me.pb_user.Location = New System.Drawing.Point(0, 775)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Size = New System.Drawing.Size(267, 222)
        Me.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_user.TabIndex = 16
        Me.pb_user.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_logout.Location = New System.Drawing.Point(0, 568)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(267, 74)
        Me.btn_logout.TabIndex = 15
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'pan_moving
        '
        Me.pan_moving.BackColor = System.Drawing.Color.White
        Me.pan_moving.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pan_moving.Location = New System.Drawing.Point(-5, 198)
        Me.pan_moving.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_moving.Name = "pan_moving"
        Me.pan_moving.Size = New System.Drawing.Size(13, 74)
        Me.pan_moving.TabIndex = 2
        '
        'btn_report
        '
        Me.btn_report.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_report.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_report.FlatAppearance.BorderSize = 0
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_report.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_report.Location = New System.Drawing.Point(0, 494)
        Me.btn_report.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(267, 74)
        Me.btn_report.TabIndex = 14
        Me.btn_report.Text = "Report"
        Me.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_report.UseVisualStyleBackColor = True
        '
        'btn_administartion
        '
        Me.btn_administartion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_administartion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_administartion.FlatAppearance.BorderSize = 0
        Me.btn_administartion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_administartion.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_administartion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_administartion.Location = New System.Drawing.Point(0, 420)
        Me.btn_administartion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_administartion.Name = "btn_administartion"
        Me.btn_administartion.Size = New System.Drawing.Size(267, 74)
        Me.btn_administartion.TabIndex = 13
        Me.btn_administartion.Text = "Administration"
        Me.btn_administartion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_administartion.UseVisualStyleBackColor = True
        '
        'btn_hotal
        '
        Me.btn_hotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_hotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_hotal.FlatAppearance.BorderSize = 0
        Me.btn_hotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hotal.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_hotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_hotal.Location = New System.Drawing.Point(0, 346)
        Me.btn_hotal.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_hotal.Name = "btn_hotal"
        Me.btn_hotal.Size = New System.Drawing.Size(267, 74)
        Me.btn_hotal.TabIndex = 12
        Me.btn_hotal.Text = "Hotel"
        Me.btn_hotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hotal.UseVisualStyleBackColor = True
        '
        'btn_restorunt
        '
        Me.btn_restorunt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_restorunt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_restorunt.FlatAppearance.BorderSize = 0
        Me.btn_restorunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restorunt.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_restorunt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_restorunt.Location = New System.Drawing.Point(0, 272)
        Me.btn_restorunt.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_restorunt.Name = "btn_restorunt"
        Me.btn_restorunt.Size = New System.Drawing.Size(267, 74)
        Me.btn_restorunt.TabIndex = 11
        Me.btn_restorunt.Text = "Restaurant"
        Me.btn_restorunt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_restorunt.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_home.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btn_home.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.Location = New System.Drawing.Point(0, 198)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(267, 74)
        Me.btn_home.TabIndex = 0
        Me.btn_home.Text = "Home"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 198)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_global_usr_statues
        '
        Me.lbl_global_usr_statues.AutoSize = True
        Me.lbl_global_usr_statues.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lbl_global_usr_statues.ForeColor = System.Drawing.Color.White
        Me.lbl_global_usr_statues.Location = New System.Drawing.Point(4, 1046)
        Me.lbl_global_usr_statues.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_global_usr_statues.Name = "lbl_global_usr_statues"
        Me.lbl_global_usr_statues.Size = New System.Drawing.Size(73, 23)
        Me.lbl_global_usr_statues.TabIndex = 9
        Me.lbl_global_usr_statues.Text = "Admin"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(267, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1653, 37)
        Me.Panel3.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1488, -1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 54)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'main_img_slider
        '
        Me.main_img_slider.AnimationTime = 1000
        Me.main_img_slider.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.main_img_slider.Appearance.Options.UseBackColor = True
        Me.main_img_slider.CurrentImageIndex = 0
        Me.main_img_slider.Images.Add(CType(resources.GetObject("main_img_slider.Images"), System.Drawing.Image))
        Me.main_img_slider.Images.Add(CType(resources.GetObject("main_img_slider.Images1"), System.Drawing.Image))
        Me.main_img_slider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
        Me.main_img_slider.Location = New System.Drawing.Point(0, 0)
        Me.main_img_slider.Margin = New System.Windows.Forms.Padding(4)
        Me.main_img_slider.Name = "main_img_slider"
        Me.main_img_slider.Size = New System.Drawing.Size(1652, 559)
        Me.main_img_slider.TabIndex = 0
        Me.main_img_slider.Text = "ImageSlider1"
        Me.main_img_slider.UseDisabledStatePainter = True
        '
        'main_panel
        '
        Me.main_panel.AutoSize = True
        Me.main_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.main_panel.Controls.Add(Me.main_img_slider)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Location = New System.Drawing.Point(267, 37)
        Me.main_panel.Margin = New System.Windows.Forms.Padding(4)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(1653, 1043)
        Me.main_panel.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1606, -17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 54)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'main_menu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.main_panel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.menu_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "main_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menu_panel.ResumeLayout(False)
        Me.menu_panel.PerformLayout()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.main_img_slider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.main_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_panel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_global_usr_statues As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pan_moving As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_hotal As Button
    Friend WithEvents btn_restorunt As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_administartion As Button
    Friend WithEvents main_img_slider As DevExpress.XtraEditors.Controls.ImageSlider
    Friend WithEvents main_panel As Panel
    Friend WithEvents pb_user As PictureBox
    Friend WithEvents lb_user_name As Label
    Friend WithEvents Button2 As Button
End Class
