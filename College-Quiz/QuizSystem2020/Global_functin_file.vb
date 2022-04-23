Imports System.Data.OleDb

Module Global_functin_file
    Public con As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public dr As DataRow

    Public Sub Startconnection()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Extra_project_&_gernal\SGM_Quiz_applcation\QuizSystem2020\QuizSystem2020\QuizDb2020.accdb")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Public Sub Endconnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    Public Function Show_question(ByVal subject As String, ByVal question_no As Integer)
        Dim cm As OleDbCommand
        Dim dtr As OleDbDataReader
        Startconnection()
        cm = New OleDbCommand("select * from Question1 where ID=" & question_no & " and subject= '" & subject & "'", con)
        dtr = cm.ExecuteReader
        If dtr.Read() Then
            Return dtr("Question")
        End If
        Return "Check Database"
        cm.Dispose()
        dtr.Close()
        Endconnection()
    End Function
    Public Function Show_option(ByVal subject As String, ByVal question_no As Integer, ByVal opt As Char)
        Dim cm As OleDbCommand
        Dim dtr As OleDbDataReader
        Startconnection()
        cm = New OleDbCommand("select * from Question1 where ID=" & question_no & " and subject= '" & subject & "'", con)
        dtr = cm.ExecuteReader
        If dtr.Read() Then
            If opt = "a" Then
                Return dtr("opa")
                Exit Function
            ElseIf opt = "b" Then
                Return dtr("opb")
                Exit Function
            ElseIf opt = "c" Then
                Return dtr("opc")
                Exit Function
            ElseIf opt = "d" Then
                Return dtr("opd")
                Exit Function
            End If
        End If
        Return "null"
        cm.Dispose()
        dtr.Close()
        Endconnection()
    End Function
    Public Function Show_answer(ByVal subject As String, ByVal question_no As Integer)
        Dim cm As OleDbCommand
        Dim dtr As OleDbDataReader
        Startconnection()
        cm = New OleDbCommand("select * from Question1 where ID=" & question_no & " and subject= '" & subject & "'", con)
        dtr = cm.ExecuteReader
        If dtr.Read() Then
            Return dtr("Answer")
        End If
        Return "Check Database"
        cm.Dispose()
        dtr.Close()
        Endconnection()
    End Function
    Public Function submit_points(ByVal team_name As String, ByVal points As Integer)
        Dim cm As OleDbCommand
        Startconnection()
        cm = New OleDbCommand("update studinfo set score = score + " & points & " where team='" & team_name & "'", con)
        If cm.ExecuteNonQuery() > 0 Then
            Return 1
        End If
        Return 0
        cm.Dispose()
        Endconnection()
    End Function

    Function auto_incr(ByVal count As String, ByRef first_no As Integer)
        Startconnection()
        Dim cnt As Integer = 0
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(count, con)
        cnt = cmd.ExecuteScalar()
        cnt = cnt + first_no
        Return cnt
    End Function
  
End Module
