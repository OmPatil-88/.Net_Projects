<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_use = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.tb_use = New System.Windows.Forms.TextBox()
        Me.tb_pass = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USER NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'lbl_use
        '
        Me.lbl_use.AutoSize = True
        Me.lbl_use.BackColor = System.Drawing.Color.Transparent
        Me.lbl_use.ForeColor = System.Drawing.Color.Red
        Me.lbl_use.Location = New System.Drawing.Point(31, 179)
        Me.lbl_use.Name = "lbl_use"
        Me.lbl_use.Size = New System.Drawing.Size(97, 13)
        Me.lbl_use.TabIndex = 3
        Me.lbl_use.Text = "*invalid user name*"
        Me.lbl_use.Visible = False
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pass.ForeColor = System.Drawing.Color.Red
        Me.lbl_pass.Location = New System.Drawing.Point(31, 264)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(93, 13)
        Me.lbl_pass.TabIndex = 4
        Me.lbl_pass.Text = "*invalid password*"
        Me.lbl_pass.Visible = False
        '
        'tb_use
        '
        Me.tb_use.Location = New System.Drawing.Point(34, 157)
        Me.tb_use.Name = "tb_use"
        Me.tb_use.Size = New System.Drawing.Size(155, 20)
        Me.tb_use.TabIndex = 2
        '
        'tb_pass
        '
        Me.tb_pass.Enabled = False
        Me.tb_pass.Location = New System.Drawing.Point(34, 241)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_pass.Size = New System.Drawing.Size(155, 20)
        Me.tb_pass.TabIndex = 2
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Red
        Me.btn_login.Enabled = False
        Me.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_login.Location = New System.Drawing.Point(35, 332)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 1
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(32, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Plese enter valid user name and password"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(748, 423)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.tb_use)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_use)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frm_login"
        Me.Text = "LOGIN"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_use As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents tb_use As System.Windows.Forms.TextBox
    Friend WithEvents tb_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
