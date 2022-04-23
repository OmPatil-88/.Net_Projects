<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuizStart
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtQNumber = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtopd = New System.Windows.Forms.Button()
        Me.txtopb = New System.Windows.Forms.Button()
        Me.txtopc = New System.Windows.Forms.Button()
        Me.txtopa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_subject = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmb_team = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_points = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_submit_score = New System.Windows.Forms.Button()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_pass = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.DarkViolet
        Me.txtAnswer.Location = New System.Drawing.Point(12, 365)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(1037, 60)
        Me.txtAnswer.TabIndex = 217
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAnswer
        '
        Me.btnAnswer.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAnswer.Enabled = False
        Me.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnswer.Location = New System.Drawing.Point(201, 538)
        Me.btnAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(117, 36)
        Me.btnAnswer.TabIndex = 216
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = False
        '
        'txtQNumber
        '
        Me.txtQNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNumber.ForeColor = System.Drawing.Color.Blue
        Me.txtQNumber.Location = New System.Drawing.Point(67, 485)
        Me.txtQNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQNumber.Name = "txtQNumber"
        Me.txtQNumber.Size = New System.Drawing.Size(49, 32)
        Me.txtQNumber.TabIndex = 211
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Red
        Me.btnStop.Location = New System.Drawing.Point(447, 538)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(79, 36)
        Me.btnStop.TabIndex = 213
        Me.btnStop.Text = "Clear"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Green
        Me.btnShow.Location = New System.Drawing.Point(12, 538)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(77, 36)
        Me.btnShow.TabIndex = 212
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.SystemColors.Control
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtQuestion.Location = New System.Drawing.Point(122, 92)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(927, 80)
        Me.txtQuestion.TabIndex = 230
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.Green
        Me.btnOptions.Location = New System.Drawing.Point(106, 538)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(89, 36)
        Me.btnOptions.TabIndex = 239
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.txtopd)
        Me.Panel1.Controls.Add(Me.txtopb)
        Me.Panel1.Controls.Add(Me.txtopc)
        Me.Panel1.Controls.Add(Me.txtopa)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 205)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 143)
        Me.Panel1.TabIndex = 240
        '
        'txtopd
        '
        Me.txtopd.BackColor = System.Drawing.Color.Beige
        Me.txtopd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtopd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopd.ForeColor = System.Drawing.Color.Black
        Me.txtopd.Location = New System.Drawing.Point(688, 88)
        Me.txtopd.Name = "txtopd"
        Me.txtopd.Size = New System.Drawing.Size(301, 33)
        Me.txtopd.TabIndex = 250
        Me.txtopd.UseVisualStyleBackColor = False
        '
        'txtopb
        '
        Me.txtopb.BackColor = System.Drawing.Color.Beige
        Me.txtopb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtopb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopb.ForeColor = System.Drawing.Color.Black
        Me.txtopb.Location = New System.Drawing.Point(688, 14)
        Me.txtopb.Name = "txtopb"
        Me.txtopb.Size = New System.Drawing.Size(301, 36)
        Me.txtopb.TabIndex = 249
        Me.txtopb.UseVisualStyleBackColor = False
        '
        'txtopc
        '
        Me.txtopc.BackColor = System.Drawing.Color.Beige
        Me.txtopc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtopc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopc.ForeColor = System.Drawing.Color.Black
        Me.txtopc.Location = New System.Drawing.Point(172, 88)
        Me.txtopc.Name = "txtopc"
        Me.txtopc.Size = New System.Drawing.Size(301, 33)
        Me.txtopc.TabIndex = 248
        Me.txtopc.UseVisualStyleBackColor = False
        '
        'txtopa
        '
        Me.txtopa.BackColor = System.Drawing.Color.Beige
        Me.txtopa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtopa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopa.ForeColor = System.Drawing.Color.Black
        Me.txtopa.Location = New System.Drawing.Point(172, 14)
        Me.txtopa.Name = "txtopa"
        Me.txtopa.Size = New System.Drawing.Size(300, 36)
        Me.txtopa.TabIndex = 247
        Me.txtopa.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(539, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 33)
        Me.Label4.TabIndex = 246
        Me.Label4.Text = "Option D"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 33)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "Option C"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(538, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 33)
        Me.Label2.TabIndex = 244
        Me.Label2.Text = "Option B"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 33)
        Me.Label1.TabIndex = 243
        Me.Label1.Text = "Option A"
        '
        'cmb_subject
        '
        Me.cmb_subject.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_subject.FormattingEnabled = True
        Me.cmb_subject.Location = New System.Drawing.Point(11, 432)
        Me.cmb_subject.Name = "cmb_subject"
        Me.cmb_subject.Size = New System.Drawing.Size(202, 33)
        Me.cmb_subject.TabIndex = 241
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(11, 483)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 34)
        Me.Button1.TabIndex = 242
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(122, 485)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 34)
        Me.Button2.TabIndex = 243
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmb_team
        '
        Me.cmb_team.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_team.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_team.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_team.FormattingEnabled = True
        Me.cmb_team.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cmb_team.Location = New System.Drawing.Point(804, 445)
        Me.cmb_team.Name = "cmb_team"
        Me.cmb_team.Size = New System.Drawing.Size(72, 33)
        Me.cmb_team.TabIndex = 244
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(709, 445)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 33)
        Me.Label5.TabIndex = 251
        Me.Label5.Text = "Team"
        '
        'cmb_points
        '
        Me.cmb_points.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_points.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_points.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_points.FormattingEnabled = True
        Me.cmb_points.Items.AddRange(New Object() {"10", "5"})
        Me.cmb_points.Location = New System.Drawing.Point(972, 445)
        Me.cmb_points.Name = "cmb_points"
        Me.cmb_points.Size = New System.Drawing.Size(72, 33)
        Me.cmb_points.TabIndex = 252
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(883, 445)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 33)
        Me.Label7.TabIndex = 253
        Me.Label7.Text = "Points"
        '
        'btn_submit_score
        '
        Me.btn_submit_score.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_submit_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit_score.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit_score.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_submit_score.Location = New System.Drawing.Point(830, 538)
        Me.btn_submit_score.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_submit_score.Name = "btn_submit_score"
        Me.btn_submit_score.Size = New System.Drawing.Size(96, 36)
        Me.btn_submit_score.TabIndex = 254
        Me.btn_submit_score.Text = "Submit"
        Me.btn_submit_score.UseVisualStyleBackColor = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.LightGreen
        Me.OvalShape1.Location = New System.Drawing.Point(936, 544)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.OvalShape1.Size = New System.Drawing.Size(15, 15)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1071, 741)
        Me.ShapeContainer1.TabIndex = 255
        Me.ShapeContainer1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 33)
        Me.Label6.TabIndex = 251
        Me.Label6.Text = "Question: "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1276, 49)
        Me.Panel2.TabIndex = 256
        '
        'btn_pass
        '
        Me.btn_pass.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_pass.Enabled = False
        Me.btn_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pass.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_pass.Location = New System.Drawing.Point(324, 538)
        Me.btn_pass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_pass.Name = "btn_pass"
        Me.btn_pass.Size = New System.Drawing.Size(117, 36)
        Me.btn_pass.TabIndex = 257
        Me.btn_pass.Text = "Pass"
        Me.btn_pass.UseVisualStyleBackColor = False
        '
        'frmQuizStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1071, 741)
        Me.Controls.Add(Me.btn_pass)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_submit_score)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_points)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_team)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_subject)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtQNumber)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuizStart"
        Me.Text = "frmQuizStart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents txtQNumber As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_subject As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtopd As System.Windows.Forms.Button
    Friend WithEvents txtopb As System.Windows.Forms.Button
    Friend WithEvents txtopc As System.Windows.Forms.Button
    Friend WithEvents txtopa As System.Windows.Forms.Button
    Friend WithEvents cmb_team As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_points As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_submit_score As System.Windows.Forms.Button
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_pass As System.Windows.Forms.Button
End Class
