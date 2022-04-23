<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_button
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
        Me.lbl_table_name = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_table_name
        '
        Me.lbl_table_name.BackColor = System.Drawing.Color.Khaki
        Me.lbl_table_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_table_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_table_name.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_table_name.Location = New System.Drawing.Point(0, 0)
        Me.lbl_table_name.Name = "lbl_table_name"
        Me.lbl_table_name.Size = New System.Drawing.Size(59, 50)
        Me.lbl_table_name.TabIndex = 0
        Me.lbl_table_name.Text = "T"
        Me.lbl_table_name.UseVisualStyleBackColor = False
        '
        'uc_button
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.lbl_table_name)
        Me.Name = "uc_button"
        Me.Size = New System.Drawing.Size(59, 50)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_table_name As Button
End Class
