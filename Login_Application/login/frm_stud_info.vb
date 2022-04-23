Public Class frm_stud_info

    Private Sub frm_stud_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Login_1DataSet.tbl_info' table. You can move, or remove it, as needed.
        Me.Tbl_infoTableAdapter.Fill(Me.Login_1DataSet.tbl_info)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        frm_add_student.Show()
    End Sub

    Private Sub frm_stud_info_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'Login_1DataSet.tbl_info' table. You can move, or remove it, as needed.
        Me.Tbl_infoTableAdapter.Fill(Me.Login_1DataSet.tbl_info)
    End Sub
End Class