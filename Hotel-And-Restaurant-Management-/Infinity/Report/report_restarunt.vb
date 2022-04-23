Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class report_restarunt
    Inherits UserControl
    Private Shared _instanse As report_restarunt
    Public Shared ReadOnly Property Instance() As report_restarunt
        Get
            If _instanse Is Nothing Then
                _instanse = New report_restarunt()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Dim dt As New DataTable
        Dim addpter As SqlDataAdapter
        getconnection()
        cmd = New SqlCommand("SELECT * from Final_bill_table join Final_Bill_menu on Final_bill_table.bill_no=Final_Bill_menu.bill_no where Final_bill_table.bill_no=" + tb_search.Text + "", con)
        addpter = New SqlDataAdapter(cmd)
        addpter.Fill(dt)
        If dt.Rows.Count <> 0 Then
            Dim report As New resto_bill_rpt
            report.DataSource = dt
            report.DataAdapter = addpter
            report.DataMember = "Final_bill_table"
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            report.CreateDocument()
            Resto_bill_doc.DocumentSource = report
        Else
            MessageBox.Show("No Record found!!!!!!!!!!")
        End If
        endconnection()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Resto_bill_doc.DocumentSource = ""
    End Sub
End Class
