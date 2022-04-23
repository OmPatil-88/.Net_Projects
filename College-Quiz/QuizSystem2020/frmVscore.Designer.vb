<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVscore
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTeamA = New System.Windows.Forms.TextBox()
        Me.txtTeamE = New System.Windows.Forms.TextBox()
        Me.lblE = New System.Windows.Forms.Label()
        Me.txtTeamD = New System.Windows.Forms.TextBox()
        Me.lblD = New System.Windows.Forms.Label()
        Me.txtTeamC = New System.Windows.Forms.TextBox()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtTeamB = New System.Windows.Forms.TextBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1319, 50)
        Me.Panel1.TabIndex = 118
        '
        'Timer5
        '
        Me.Timer5.Interval = 1
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(458, -99)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(76, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 234
        Me.PictureBox3.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTeamA)
        Me.GroupBox2.Controls.Add(Me.txtTeamE)
        Me.GroupBox2.Controls.Add(Me.lblE)
        Me.GroupBox2.Controls.Add(Me.txtTeamD)
        Me.GroupBox2.Controls.Add(Me.lblD)
        Me.GroupBox2.Controls.Add(Me.txtTeamC)
        Me.GroupBox2.Controls.Add(Me.lblC)
        Me.GroupBox2.Controls.Add(Me.txtTeamB)
        Me.GroupBox2.Controls.Add(Me.lblB)
        Me.GroupBox2.Controls.Add(Me.lblA)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1082, 635)
        Me.GroupBox2.TabIndex = 226
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Score Card "
        '
        'txtTeamA
        '
        Me.txtTeamA.Font = New System.Drawing.Font("Times New Roman", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamA.ForeColor = System.Drawing.Color.Red
        Me.txtTeamA.Location = New System.Drawing.Point(83, 310)
        Me.txtTeamA.Multiline = True
        Me.txtTeamA.Name = "txtTeamA"
        Me.txtTeamA.Size = New System.Drawing.Size(132, 112)
        Me.txtTeamA.TabIndex = 20
        Me.txtTeamA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTeamE
        '
        Me.txtTeamE.Font = New System.Drawing.Font("Times New Roman", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamE.ForeColor = System.Drawing.Color.Red
        Me.txtTeamE.Location = New System.Drawing.Point(780, 315)
        Me.txtTeamE.Multiline = True
        Me.txtTeamE.Name = "txtTeamE"
        Me.txtTeamE.Size = New System.Drawing.Size(132, 112)
        Me.txtTeamE.TabIndex = 28
        Me.txtTeamE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblE
        '
        Me.lblE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblE.Font = New System.Drawing.Font("Times New Roman", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.ForeColor = System.Drawing.Color.Blue
        Me.lblE.Location = New System.Drawing.Point(756, 39)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(178, 12)
        Me.lblE.TabIndex = 27
        Me.lblE.Text = "E"
        '
        'txtTeamD
        '
        Me.txtTeamD.Font = New System.Drawing.Font("Times New Roman", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamD.ForeColor = System.Drawing.Color.Red
        Me.txtTeamD.Location = New System.Drawing.Point(606, 314)
        Me.txtTeamD.Multiline = True
        Me.txtTeamD.Name = "txtTeamD"
        Me.txtTeamD.Size = New System.Drawing.Size(132, 112)
        Me.txtTeamD.TabIndex = 26
        Me.txtTeamD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblD
        '
        Me.lblD.BackColor = System.Drawing.Color.Peru
        Me.lblD.Font = New System.Drawing.Font("Times New Roman", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.ForeColor = System.Drawing.Color.Blue
        Me.lblD.Location = New System.Drawing.Point(582, 39)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(176, 12)
        Me.lblD.TabIndex = 25
        Me.lblD.Text = "D"
        '
        'txtTeamC
        '
        Me.txtTeamC.Font = New System.Drawing.Font("Times New Roman", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamC.ForeColor = System.Drawing.Color.Red
        Me.txtTeamC.Location = New System.Drawing.Point(431, 314)
        Me.txtTeamC.Multiline = True
        Me.txtTeamC.Name = "txtTeamC"
        Me.txtTeamC.Size = New System.Drawing.Size(132, 112)
        Me.txtTeamC.TabIndex = 24
        Me.txtTeamC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblC
        '
        Me.lblC.BackColor = System.Drawing.Color.Olive
        Me.lblC.Font = New System.Drawing.Font("Times New Roman", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.ForeColor = System.Drawing.Color.Blue
        Me.lblC.Location = New System.Drawing.Point(406, 39)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(179, 12)
        Me.lblC.TabIndex = 23
        Me.lblC.Text = "C"
        '
        'txtTeamB
        '
        Me.txtTeamB.Font = New System.Drawing.Font("Times New Roman", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamB.ForeColor = System.Drawing.Color.Red
        Me.txtTeamB.Location = New System.Drawing.Point(252, 313)
        Me.txtTeamB.Multiline = True
        Me.txtTeamB.Name = "txtTeamB"
        Me.txtTeamB.Size = New System.Drawing.Size(132, 112)
        Me.txtTeamB.TabIndex = 22
        Me.txtTeamB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblB
        '
        Me.lblB.BackColor = System.Drawing.Color.Salmon
        Me.lblB.Font = New System.Drawing.Font("Times New Roman", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.Color.Blue
        Me.lblB.Location = New System.Drawing.Point(231, 40)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(177, 11)
        Me.lblB.TabIndex = 21
        Me.lblB.Text = "B"
        '
        'lblA
        '
        Me.lblA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblA.Font = New System.Drawing.Font("Times New Roman", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.ForeColor = System.Drawing.Color.Blue
        Me.lblA.Location = New System.Drawing.Point(56, 40)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(176, 11)
        Me.lblA.TabIndex = 19
        Me.lblA.Text = "A"
        Me.lblA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'frmVscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1055, 702)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVscore"
        Me.Text = "frmVscore"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTeamA As System.Windows.Forms.TextBox
    Friend WithEvents txtTeamE As System.Windows.Forms.TextBox
    Friend WithEvents lblE As System.Windows.Forms.Label
    Friend WithEvents txtTeamD As System.Windows.Forms.TextBox
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents txtTeamC As System.Windows.Forms.TextBox
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents txtTeamB As System.Windows.Forms.TextBox
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
