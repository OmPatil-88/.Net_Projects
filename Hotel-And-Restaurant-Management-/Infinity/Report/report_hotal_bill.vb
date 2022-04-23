Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class report_hotal_bill
    Inherits UserControl
    Private Shared _instanse As report_hotal_bill
    Public Shared ReadOnly Property Instance() As report_hotal_bill
        Get
            If _instanse Is Nothing Then
                _instanse = New report_hotal_bill()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        If tb_search.Text <> "" Then
            Bill_doc.DocumentSource = ""
            Dim dt As New DataTable
            Dim addpter As SqlDataAdapter
            getconnection()
            cmd = New SqlCommand("SELECT * from Guest_data join Guest_Extra_services_Freezed on Guest_data.Check_id=Guest_Extra_services_Freezed.Check_id where Guest_data.Check_id=" + tb_search.Text + "", con)
            addpter = New SqlDataAdapter(cmd)
            addpter.Fill(dt)
            If dt.Rows.Count <> 0 Then
                Dim report As New Hotel_bill_rpt
                report.DataSource = dt
                report.DataAdapter = addpter
                report.DataMember = "Guest_data"
                Dim tool As ReportPrintTool = New ReportPrintTool(report)
                report.CreateDocument()
                Bill_doc.DocumentSource = report
            Else
                MessageBox.Show("No Record found!!!!!!!!!!")
            End If
            endconnection()
        Else
            MessageBox.Show("No Record found!!!!!!!!!!")
        End If

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Bill_doc.DocumentSource = ""
    End Sub
End Class
