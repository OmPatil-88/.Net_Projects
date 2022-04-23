Public Class uc_admin_costscheduling
    Inherits UserControl
    Private Shared _instanse As uc_admin_costscheduling
    Public Shared ReadOnly Property Instance() As uc_admin_costscheduling
        Get
            If _instanse Is Nothing Then
                _instanse = New uc_admin_costscheduling()
            End If
            Return _instanse
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Instance.Hide()
    End Sub
End Class
