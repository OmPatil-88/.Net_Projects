Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class report_delear_payment_slip
    Inherits UserControl
    Private Shared _instanse As report_delear_payment_slip
    Public Shared ReadOnly Property Instance() As report_delear_payment_slip
        Get
            If _instanse Is Nothing Then
                _instanse = New report_delear_payment_slip()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        getconnection()
        Dim dt As New DataTable
        Dim addpter As New SqlDataAdapter
        If cmb_search_type.SelectedIndex <> -1 And tb_search.Text <> "" Then
            If cmb_search_type.SelectedIndex = 0 Then
                cmd = New SqlCommand("SELECT * from delar_data where d_id=" & tb_search.Text & "", con)
                addpter = New SqlDataAdapter(cmd)
                addpter.Fill(dt)
            ElseIf cmb_search_type.SelectedIndex = 1 Then
                cmd = New SqlCommand("SELECT * from delar_data where d_name like '%" & tb_search.Text & "%'", con)
                addpter = New SqlDataAdapter(cmd)
                addpter.Fill(dt)
            ElseIf cmb_search_type.SelectedIndex = 2 Then
                cmd = New SqlCommand("SELECT * from delar_data where tot_tranzection_done=" & tb_search.Text & "", con)
                addpter = New SqlDataAdapter(cmd)
                addpter.Fill(dt)
            ElseIf cmb_search_type.SelectedIndex = 3 Then
                cmd = New SqlCommand("SELECT * from delar_data where stock_type like '%" & tb_search.Text & "%'", con)
                addpter = New SqlDataAdapter(cmd)
                addpter.Fill(dt)
            End If

            Dim report As New dealer_rpt
            report.DataSource = dt
            report.DataAdapter = addpter
            report.DataMember = "delar_data"
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            report.CreateDocument()
            dealer_doc.DocumentSource = report
        Else
            MessageBox.Show("Please select all filds")
        End If
        endconnection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim addpter As SqlDataAdapter
        getconnection()
        cmd = New SqlCommand("SELECT * from delar_data", con)
        addpter = New SqlDataAdapter(cmd)
        addpter.Fill(dt)
        Dim report As New dealer_rpt

        report.DataSource = dt
        report.DataAdapter = addpter
        report.DataMember = "delar_data"
        Dim tool As ReportPrintTool = New ReportPrintTool(report)
        report.CreateDocument()
        dealer_doc.DocumentSource = report
        endconnection()
    End Sub
End Class
