<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImage
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.imgShow = New System.Windows.Forms.PictureBox()
        Me.btn_submit_score = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_points = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_team = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_subject = New System.Windows.Forms.ComboBox()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtQNumber = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        CType(Me.imgShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShow.Location = New System.Drawing.Point(186, 646)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(81, 34)
        Me.btnShow.TabIndex = 242
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'imgShow
        '
        Me.imgShow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.imgShow.Location = New System.Drawing.Point(197, 52)
        Me.imgShow.Name = "imgShow"
        Me.imgShow.Size = New System.Drawing.Size(668, 440)
        Me.imgShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgShow.TabIndex = 241
        Me.imgShow.TabStop = False
        '
        'btn_submit_score
        '
        Me.btn_submit_score.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit_score.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_submit_score.Location = New System.Drawing.Point(891, 643)
        Me.btn_submit_score.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_submit_score.Name = "btn_submit_score"
        Me.btn_submit_score.Size = New System.Drawing.Size(96, 36)
        Me.btn_submit_score.TabIndex = 280
        Me.btn_submit_score.Text = "Submit"
        Me.btn_submit_score.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(712, 645)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 33)
        Me.Label7.TabIndex = 279
        Me.Label7.Text = "Points"
        '
        'cmb_points
        '
        Me.cmb_points.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_points.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_points.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_points.FormattingEnabled = True
        Me.cmb_points.Items.AddRange(New Object() {"10", "5"})
        Me.cmb_points.Location = New System.Drawing.Point(813, 645)
        Me.cmb_points.Name = "cmb_points"
        Me.cmb_points.Size = New System.Drawing.Size(72, 33)
        Me.cmb_points.TabIndex = 278
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(525, 646)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 33)
        Me.Label5.TabIndex = 277
        Me.Label5.Text = "Team"
        '
        'cmb_team
        '
        Me.cmb_team.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_team.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_team.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_team.FormattingEnabled = True
        Me.cmb_team.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cmb_team.Location = New System.Drawing.Point(634, 645)
        Me.cmb_team.Name = "cmb_team"
        Me.cmb_team.Size = New System.Drawing.Size(72, 33)
        Me.cmb_team.TabIndex = 276
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(123, 643)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 34)
        Me.Button3.TabIndex = 275
        Me.Button3.Text = ">>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(12, 641)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 34)
        Me.Button1.TabIndex = 274
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_subject
        '
        Me.cmb_subject.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_subject.FormattingEnabled = True
        Me.cmb_subject.Location = New System.Drawing.Point(12, 583)
        Me.cmb_subject.Name = "cmb_subject"
        Me.cmb_subject.Size = New System.Drawing.Size(202, 33)
        Me.cmb_subject.TabIndex = 273
        '
        'btnAnswer
        '
        Me.btnAnswer.Enabled = False
        Me.btnAnswer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnswer.Location = New System.Drawing.Point(273, 646)
        Me.btnAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(117, 36)
        Me.btnAnswer.TabIndex = 271
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtQNumber
        '
        Me.txtQNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNumber.ForeColor = System.Drawing.Color.Blue
        Me.txtQNumber.Location = New System.Drawing.Point(68, 643)
        Me.txtQNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQNumber.Name = "txtQNumber"
        Me.txtQNumber.Size = New System.Drawing.Size(49, 32)
        Me.txtQNumber.TabIndex = 268
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Red
        Me.btnStop.Location = New System.Drawing.Point(410, 647)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(79, 34)
        Me.btnStop.TabIndex = 270
        Me.btnStop.Text = "Clear"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.Red
        Me.txtQuestion.Location = New System.Drawing.Point(68, 496)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(929, 77)
        Me.txtQuestion.TabIndex = 282
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.Green
        Me.txtAnswer.Location = New System.Drawing.Point(220, 576)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(657, 61)
        Me.txtAnswer.TabIndex = 281
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAnswer.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 46)
        Me.Panel2.TabIndex = 284
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.LightGreen
        Me.OvalShape1.Location = New System.Drawing.Point(989, 654)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.OvalShape1.Size = New System.Drawing.Size(17, 15)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1055, 702)
        Me.ShapeContainer1.TabIndex = 285
        Me.ShapeContainer1.TabStop = False
        '
        'frmImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1055, 702)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btn_submit_score)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_points)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_team)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_subject)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtQNumber)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.imgShow)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmImage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents imgShow As System.Windows.Forms.PictureBox
    Friend WithEvents btn_submit_score As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_points As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_team As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmb_subject As System.Windows.Forms.ComboBox
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents txtQNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
