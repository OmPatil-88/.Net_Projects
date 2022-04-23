Public Class frm_login

    Private Sub tb_use_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_use.TextChanged
        tb_pass.Enabled = True
    End Sub

    Private Sub tb_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_pass.TextChanged
        btn_login.Enabled = True
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If tb_use.Text = "a" And tb_pass.Text = "a" Or tb_use.Text = "z" And tb_pass.Text = "z" Or tb_use.Text = "s" And tb_pass.Text = "s" Then
            If tb_use.Text = "a" Then
                If MessageBox.Show("welcome admin", "WELCOME", MessageBoxButtons.OKCancel, MessageBoxIcon.None) = Windows.Forms.DialogResult.OK Then
                    Me.Hide()
                    frm_add_student.Show()
                Else
                    btn_login.Enabled = False
                    tb_pass.Enabled = False

                End If
            Else
                MessageBox.Show("welcome")
            End If
            ' Me.Hide()
            'frm_add_student.Show()
        Else
            lbl_pass.Visible = True
            lbl_use.Visible = True
        End If
    End Sub

    Private Sub frm_login_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        lbl_pass.Visible = False
        lbl_use.Visible = False
        btn_login.Enabled = False
        tb_pass.Enabled = False
        tb_use.Text = ""
        tb_pass.Text = ""
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_use.Focus()
        Dim name As String
        name = InputBox("what is your name?", "Inquiry")
        Label4.Text = name + "    please enter valid name and password "

    End Sub


End Class
