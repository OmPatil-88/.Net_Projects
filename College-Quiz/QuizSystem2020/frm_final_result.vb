Imports System.Data
Imports System.Data.OleDb
Public Class frm_final_result
    Private Sub frm_final_result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Startconnection()
            Dim cm As New OleDbCommand("SELECT collegename, sname1, sname2, score  FROM Student_Final_data ORDER BY score desc", con)
            Dim dda As New OleDbDataAdapter(cm)
            Dim dt As New DataTable
            dda.Fill(dt)
            dgv_view_student.DataSource = dt
            cm.Dispose()
            Endconnection()
        Catch
        End Try
    End Sub
End Class