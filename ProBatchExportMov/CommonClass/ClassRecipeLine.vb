


Public Class ClassRecipeLine

    Private RecipeLineCollection As Collection
    Private RecipeLineCollectionM As Collection
    Public RecipeLines As Collection
    Public Property BeforeManualComponent As Boolean = True
    Public Sub New()
        RecipeLineCollection = New Collection
        RecipeLineCollectionM = New Collection
        RecipeLines = New Collection
    End Sub


    Public Class RecipeLine
        Public Sub New(ByVal pMaterial As String, ByVal pSilos As Integer, ByVal pSql As String, ByVal pMAT_SETPOINT As String)
            Try
                Material = pMaterial
                Silos = pSilos
                SQL = pSql
                str_MAT_SETPOINT = pMAT_SETPOINT
            Catch ex As Exception

            End Try
        End Sub

        Public Property Material As String
        Public Property Silos As Integer
        Public Property SQL As String
        Public Property str_MAT_SETPOINT As String

    End Class

    Public Sub Add(ByVal material As String, ByVal SQL As String, ByVal MAT_SETPOINT As String)
        Dim silos As Integer = 0

        Debug.Print(material.Substring(0, 3).ToUpper)

        Select Case material.Substring(0, 3).ToUpper
            Case "MAG"
                'componente manuale
                RecipeLineCollectionM.Add(New RecipeLine(material, silos, SQL, MAT_SETPOINT), material)

            Case Else
                silos = CInt(material.Substring(0, 3))
                If RecipeLineCollection.Count = 0 Then
                    RecipeLineCollection.Add(New RecipeLine(material, silos, SQL, MAT_SETPOINT), silos.ToString)
                Else
                    Dim idx As Integer = 1
                    For Each r As RecipeLine In RecipeLineCollection


                        If silos < r.Silos Then
                            RecipeLineCollection.Add(New RecipeLine(material, silos, SQL, MAT_SETPOINT), silos.ToString, idx)
                            Exit Sub
                        End If
                        idx = idx + 1

                    Next
                    RecipeLineCollection.Add(New RecipeLine(material, silos, SQL, MAT_SETPOINT), silos.ToString)
                End If
        End Select
    End Sub


    Public Function GetValues() As Collection
        If BeforeManualComponent Then
            For Each r As RecipeLine In RecipeLineCollectionM
                RecipeLines.Add(r)
            Next
            For Each r As RecipeLine In RecipeLineCollection
                RecipeLines.Add(r)
            Next
        Else
            For Each r As RecipeLine In RecipeLineCollection
                RecipeLines.Add(r)
            Next
            For Each r As RecipeLine In RecipeLineCollectionM
                RecipeLines.Add(r)
            Next

        End If

        Return RecipeLines
    End Function


End Class
