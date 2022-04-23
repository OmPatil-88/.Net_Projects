<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stud_info
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Login_1DataSet = New login.login_1DataSet()
        Me.TblinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_infoTableAdapter = New login.login_1DataSetTableAdapters.tbl_infoTableAdapter()
        Me.ROLLNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ROLLNODataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.MobileNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblinfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1360, 683)
        Me.DataGridView1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(418, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(445, 31)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ALL STUDENT  INFORMATION  "
        '
        'Login_1DataSet
        '
        Me.Login_1DataSet.DataSetName = "login_1DataSet"
        Me.Login_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblinfoBindingSource
        '
        Me.TblinfoBindingSource.DataMember = "tbl_info"
        Me.TblinfoBindingSource.DataSource = Me.Login_1DataSet
        '
        'Tbl_infoTableAdapter
        '
        Me.Tbl_infoTableAdapter.ClearBeforeFill = True
        '
        'ROLLNODataGridViewTextBoxColumn
        '
        Me.ROLLNODataGridViewTextBoxColumn.DataPropertyName = "ROLL_NO"
        Me.ROLLNODataGridViewTextBoxColumn.HeaderText = "ROLL_NO"
        Me.ROLLNODataGridViewTextBoxColumn.Name = "ROLLNODataGridViewTextBoxColumn"
        Me.ROLLNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "Mobile_Number"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile_Number"
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        Me.MobileNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button4.Font = New System.Drawing.Font("Adobe Garamond Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 33)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "BACK"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1242, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 40)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "LOG OUT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm_stud_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frm_stud_info"
        Me.Text = "frm_stud_info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Login_1DataSet As login.login_1DataSet
    Friend WithEvents TblinfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_infoTableAdapter As login.login_1DataSetTableAdapters.tbl_infoTableAdapter
    Friend WithEvents ROLLNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
