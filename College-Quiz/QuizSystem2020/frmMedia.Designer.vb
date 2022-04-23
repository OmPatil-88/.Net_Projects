<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedia))
        Me.btn_submit_score = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_points = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_team = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_subject = New System.Windows.Forms.ComboBox()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.txtQNumber = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_submit_score
        '
        Me.btn_submit_score.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit_score.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_submit_score.Location = New System.Drawing.Point(929, 688)
        Me.btn_submit_score.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_submit_score.Name = "btn_submit_score"
        Me.btn_submit_score.Size = New System.Drawing.Size(96, 36)
        Me.btn_submit_score.TabIndex = 267
        Me.btn_submit_score.Text = "Submit"
        Me.btn_submit_score.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(765, 690)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 33)
        Me.Label7.TabIndex = 266
        Me.Label7.Text = "Points"
        '
        'cmb_points
        '
        Me.cmb_points.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_points.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_points.FormattingEnabled = True
        Me.cmb_points.Items.AddRange(New Object() {"10", "5"})
        Me.cmb_points.Location = New System.Drawing.Point(854, 690)
        Me.cmb_points.Name = "cmb_points"
        Me.cmb_points.Size = New System.Drawing.Size(72, 33)
        Me.cmb_points.TabIndex = 265
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(592, 691)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 33)
        Me.Label5.TabIndex = 264
        Me.Label5.Text = "Team"
        '
        'cmb_team
        '
        Me.cmb_team.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_team.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_team.FormattingEnabled = True
        Me.cmb_team.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cmb_team.Location = New System.Drawing.Point(687, 690)
        Me.cmb_team.Name = "cmb_team"
        Me.cmb_team.Size = New System.Drawing.Size(72, 33)
        Me.cmb_team.TabIndex = 263
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(143, 687)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 34)
        Me.Button2.TabIndex = 262
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(32, 685)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 34)
        Me.Button1.TabIndex = 261
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_subject
        '
        Me.cmb_subject.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmb_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_subject.FormattingEnabled = True
        Me.cmb_subject.Location = New System.Drawing.Point(32, 645)
        Me.cmb_subject.Name = "cmb_subject"
        Me.cmb_subject.Size = New System.Drawing.Size(202, 33)
        Me.cmb_subject.TabIndex = 260
        '
        'btnOptions
        '
        Me.btnOptions.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.Green
        Me.btnOptions.Location = New System.Drawing.Point(280, 687)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(89, 36)
        Me.btnOptions.TabIndex = 259
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Enabled = False
        Me.btnAnswer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnswer.Location = New System.Drawing.Point(375, 687)
        Me.btnAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(117, 36)
        Me.btnAnswer.TabIndex = 258
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'txtQNumber
        '
        Me.txtQNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNumber.ForeColor = System.Drawing.Color.Blue
        Me.txtQNumber.Location = New System.Drawing.Point(88, 687)
        Me.txtQNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQNumber.Name = "txtQNumber"
        Me.txtQNumber.Size = New System.Drawing.Size(49, 32)
        Me.txtQNumber.TabIndex = 255
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Red
        Me.btnStop.Location = New System.Drawing.Point(498, 687)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(79, 34)
        Me.btnStop.TabIndex = 257
        Me.btnStop.Text = "Clear"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.Green
        Me.btnShow.Location = New System.Drawing.Point(197, 686)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(77, 36)
        Me.btnShow.TabIndex = 256
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.LightGreen
        Me.OvalShape1.Location = New System.Drawing.Point(1029, 698)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.SelectionColor = System.Drawing.SystemColors.HotTrack
        Me.OvalShape1.Size = New System.Drawing.Size(15, 19)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1284, 758)
        Me.ShapeContainer1.TabIndex = 268
        Me.ShapeContainer1.TabStop = False
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.Red
        Me.txtQuestion.Location = New System.Drawing.Point(32, 528)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(1040, 73)
        Me.txtQuestion.TabIndex = 271
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.Green
        Me.txtAnswer.Location = New System.Drawing.Point(252, 631)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(807, 52)
        Me.txtAnswer.TabIndex = 270
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 43)
        Me.Panel2.TabIndex = 273
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 433)
        Me.Panel3.TabIndex = 274
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1284, 433)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(32, 685)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 34)
        Me.Button3.TabIndex = 261
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmMedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1284, 758)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btn_submit_score)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_points)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_team)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_subject)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtQNumber)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMedia"
        Me.Text = "frmMedia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_submit_score As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_points As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_team As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmb_subject As System.Windows.Forms.ComboBox
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents txtQNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
