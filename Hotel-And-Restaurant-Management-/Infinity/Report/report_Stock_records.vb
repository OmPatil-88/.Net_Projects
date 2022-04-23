Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class report_Stock_records
    Inherits UserControl
    Private Shared _instanse As report_Stock_records
    Public Shared ReadOnly Property Instance() As report_Stock_records
        Get
            If _instanse Is Nothing Then
                _instanse = New report_Stock_records()
            End If
            Return _instanse
        End Get
    End Property
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        getconnection()
        If dtp_2.Value > dtp_1.Value Then
            Dim dt As New DataTable("Stock_details")
            With dt
                .Columns.Add("S_Bill_Id")
                .Columns.Add("S_name")
                .Columns.Add("S_d_name")
                .Columns.Add("S_e_name")
                .Columns.Add("S_date")
                .Columns.Add("S_time")
                .Columns.Add("S_cost")
            End With
            dt.Rows.Clear()
            cmd = New SqlCommand("select * from restarunt_stock where stock_add_date between'" + dtp_1.Value + "' and '" & dtp_2.Value & "'", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                dt.Rows.Add(dr("stock_bill_id"), dr("stock_name"), dr("delear_name"), dr("employe_name"), dr("stock_add_date"), dr("stock_add_time"), dr("amount_paid"))
            End While
            Dim report As New Stock_report_rpt
            report.DataSource = dt
            report.DataMember = "Stock_details"
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            report.CreateDocument()
            Stock_doc.DocumentSource = report

        Else
            MessageBox.Show("Plsese select valid date interval")
            endconnection()
        End If
        endconnection()
    End Sub

    Private Sub btn_view_all_Click(sender As Object, e As EventArgs) Handles btn_view_all.Click
        getconnection()
        Dim dt As New DataTable("Stock_details")
            With dt
                .Columns.Add("S_Bill_Id")
                .Columns.Add("S_name")
                .Columns.Add("S_d_name")
                .Columns.Add("S_e_name")
                .Columns.Add("S_date")
                .Columns.Add("S_time")
                .Columns.Add("S_cost")
            End With
            dt.Rows.Clear()
            cmd = New SqlCommand("select * from restarunt_stock", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                dt.Rows.Add(dr("stock_bill_id"), dr("stock_name"), dr("delear_name"), dr("employe_name"), dr("stock_add_date"), dr("stock_add_time"), dr("amount_paid"))
            End While
            Dim addpter As New SqlDataAdapter
            Dim report As New Stock_report_rpt
            report.DataSource = dt
            report.DataAdapter = addpter
            report.DataMember = "Stock_details"
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            report.CreateDocument()
            Stock_doc.DocumentSource = report
        endconnection()
    End Sub
End Class
