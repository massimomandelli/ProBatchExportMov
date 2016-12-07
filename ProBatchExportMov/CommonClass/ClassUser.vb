Public Class ClassUser
    'Public cUser As clsAUser_Collection

    Public Property User As String = "System"
    Public Property Password As String = "System"

    Public Property Level As Integer = 3
    Public Function Login(Optional User As String = "", Optional Password As String = "") As Boolean
        Try
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function Logout() As Boolean
        Return True
    End Function

End Class
