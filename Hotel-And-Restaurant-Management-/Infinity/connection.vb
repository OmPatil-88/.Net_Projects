Imports System.Data.SqlClient
Imports System.IO
Imports Bunifu.Framework.UI

Module connection
    Public obj As New OpenFileDialog
    Public ms As New MemoryStream
    Public Const constring = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net Projects\All_project_Database\infinity.mdf;Integrated Security=True;Connect Timeout=30"
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public Sub getconnection()

        con = New SqlConnection
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Net Projects\All_project_Database\infinity.mdf;Integrated Security=True;Connect Timeout=30"

        If con.ConnectionString <> constring Then
            MsgBox("Database connection failed ", MsgBoxStyle.Critical + MsgBoxStyle.Information, "Try Again")
            Exit Sub
        ElseIf con.State = ConnectionState.Closed Then
            con.Open()
        Else
            MsgBox("Not Connected")

        End If
    End Sub
    Public Sub endconnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    Function autoincr(ByVal get_string As String, ByVal start_no As Integer)
        Dim cnt As Integer
        Try
            getconnection()
            cmd = New SqlCommand(get_string, con)
            cnt = cmd.ExecuteScalar()
            cnt = cnt + start_no
            cmd.Dispose()
            endconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cnt
    End Function
    Sub grid_load(ByRef str As String, ByRef dg As DataGridView)
        Try
            getconnection()
            cmd = New SqlCommand(str, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dg.DataSource = dt
            cmd.Dispose()
            endconnection()
        Catch ex As Exception
        End Try
    End Sub
    Function max(ByVal str As String)
        Dim cnt As Integer
        getconnection()
        Dim cm As New SqlCommand
        cm = New SqlCommand(str, con)
        cnt = cm.ExecuteScalar()
        cnt = cnt + 1
        endconnection()
        cm.Dispose()
        Return cnt
    End Function
End Module
