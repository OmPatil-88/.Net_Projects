<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamEntry
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
        Me.cmbTeamName = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtSStudName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFStudName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCollageName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Reset = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbT = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbTeamName
        '
        Me.cmbTeamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeamName.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTeamName.FormattingEnabled = True
        Me.cmbTeamName.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cmbTeamName.Location = New System.Drawing.Point(236, 58)
        Me.cmbTeamName.Name = "cmbTeamName"
        Me.cmbTeamName.Size = New System.Drawing.Size(121, 31)
        Me.cmbTeamName.TabIndex = 39
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Location = New System.Drawing.Point(295, 334)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 33)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtScore
        '
        Me.txtScore.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(236, 239)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(761, 30)
        Me.txtScore.TabIndex = 30
        Me.txtScore.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(41, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 23)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Score"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(44, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 23)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Team Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 303)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 11)
        Me.Panel1.TabIndex = 34
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(514, 334)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 33)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Red
        Me.btnUpdate.Location = New System.Drawing.Point(392, 334)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 33)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtSStudName
        '
        Me.txtSStudName.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSStudName.Location = New System.Drawing.Point(236, 186)
        Me.txtSStudName.Name = "txtSStudName"
        Me.txtSStudName.Size = New System.Drawing.Size(761, 30)
        Me.txtSStudName.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(41, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Second Student Name"
        '
        'txtFStudName
        '
        Me.txtFStudName.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFStudName.Location = New System.Drawing.Point(236, 146)
        Me.txtFStudName.Name = "txtFStudName"
        Me.txtFStudName.Size = New System.Drawing.Size(761, 30)
        Me.txtFStudName.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(41, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "First Student Name"
        '
        'txtCollageName
        '
        Me.txtCollageName.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollageName.Location = New System.Drawing.Point(236, 94)
        Me.txtCollageName.Name = "txtCollageName"
        Me.txtCollageName.Size = New System.Drawing.Size(761, 30)
        Me.txtCollageName.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(41, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "College Name"
        '
        'tb_Reset
        '
        Me.tb_Reset.BackColor = System.Drawing.Color.Red
        Me.tb_Reset.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Reset.ForeColor = System.Drawing.Color.White
        Me.tb_Reset.Location = New System.Drawing.Point(644, 334)
        Me.tb_Reset.Name = "tb_Reset"
        Me.tb_Reset.Size = New System.Drawing.Size(97, 33)
        Me.tb_Reset.TabIndex = 219
        Me.tb_Reset.Text = "Reset"
        Me.tb_Reset.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 36)
        Me.Panel2.TabIndex = 35
        '
        'cmbT
        '
        Me.cmbT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbT.Enabled = False
        Me.cmbT.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbT.FormattingEnabled = True
        Me.cmbT.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cmbT.Location = New System.Drawing.Point(367, 58)
        Me.cmbT.Name = "cmbT"
        Me.cmbT.Size = New System.Drawing.Size(121, 31)
        Me.cmbT.TabIndex = 40
        '
        'frmTeamEntry
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1055, 702)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tb_Reset)
        Me.Controls.Add(Me.cmbT)
        Me.Controls.Add(Me.cmbTeamName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtSStudName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFStudName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCollageName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTeamEntry"
        Me.Text = "frmTeamEntry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTeamName As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtSStudName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFStudName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCollageName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_Reset As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbT As System.Windows.Forms.ComboBox
End Class
