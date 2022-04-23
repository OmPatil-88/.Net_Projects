Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class report_final_checkin_out
    Inherits UserControl
    Private Shared _instanse As report_final_checkin_out
    Public Shared ReadOnly Property Instance() As report_final_checkin_out
        Get
            If _instanse Is Nothing Then
                _instanse = New report_final_checkin_out()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt As New DataTable
        Dim addpter As SqlDataAdapter
        getconnection()
        cmd = New SqlCommand("SELECT * from Reservation_data", con)
        addpter = New SqlDataAdapter(cmd)
        addpter.Fill(dt)
        Dim report As New Reservation_Rpt

        report.DataSource = dt
        report.DataAdapter = addpter
        report.DataMember = "Reservation_data"
        Dim tool As ReportPrintTool = New ReportPrintTool(report)
        report.CreateDocument()
        List.DocumentSource = report
        endconnection()
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        If dtp_2.Value > dtp_1.Value Then
            List.DocumentSource = ""
            Dim dt As New DataTable
            Dim addpter As SqlDataAdapter
            getconnection()
            cmd = New SqlCommand("select * from Reservation_data where r_check_in_date between'" + dtp_1.Value + "' and '" & dtp_2.Value & "'", con)
            addpter = New SqlDataAdapter(cmd)
            addpter.Fill(dt)
            If dt.Rows.Count <> 0 Then
                Dim report As New Hotel_bill_rpt
                report.DataSource = dt
                report.DataAdapter = addpter
                report.DataMember = "Reservation_data"
                Dim tool As ReportPrintTool = New ReportPrintTool(report)
                report.CreateDocument()
                List.DocumentSource = report
            Else
                MessageBox.Show("No Record found!!!!!!!!!!")
            End If
            endconnection()
        Else
            MessageBox.Show("No Record found!!!!!!!!!!")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        List.DocumentSource = ""
    End Sub
End Class
