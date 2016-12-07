Imports System
Imports System.Threading
Imports System.Threading.Thread

Public Class ClassDatabase
    Public Property ConnectionString As String
    Public WithEvents oleConn As OleDb.OleDbConnection
    Dim oleAdapter As OleDb.OleDbDataAdapter

    Public Event ConnectionError(ByVal Err As Exception)
    Public Event ActionError(ByVal Err As Exception)
    Public Event ConnectionState(ByVal ConnectionState As ConnectionState)
    Public Event BeginSQL()
    Public Event EndSQL()


    Public GLOBAL_DB_DATEFORMAT As String = "SET DATEFORMAT dmy"
    Public GLOBAL_DATE_FORMAT As String = "dd/MM/yyyy"
    'Public GLOBAL_DATE_FORMAT = "MM/dd/yyyy"
    Public GLOBAL_DATE_TIME As String = "HH:mm:ss"
    'Public GLOBAL_DATETIME_FORMAT = "MM/dd/yyyy HH:mm:ss"
    Public GLOBAL_DATETIME_FORMAT As String = "dd/MM/yyyy HH:mm:ss"
    Public GLOBAL_DB_DATETIME_FORMAT As String = GLOBAL_DATETIME_FORMAT '"MM/dd/yyyy HH:mm:ss"
    Public GLOBAL_DATENULL As Date = CDate("01/01/1900 00:00:00")


    Public Function GetDatabaseState() As ConnectionState
        Try
            Return oleConn.State
        Catch ex As Exception
            RaiseEvent ConnectionError(ex)
        End Try
    End Function
    Public Sub New(ByVal ConnectionString As String)
        Try
            oleConn = New OleDb.OleDbConnection(ConnectionString)
            Me.ConnectionString = ConnectionString
            oleConn.Open()

            'RaiseEvent ConnectionState(oleConn.State)
        Catch ex As Exception
            RaiseEvent ConnectionError(ex)
        End Try
    End Sub

    Public Function Connect() As Boolean
        Try
            Dim m_iRetary As Integer
            Do While Not oleConn.State = Data.ConnectionState.Open

                If oleConn.State = Data.ConnectionState.Closed Then
                    oleConn.Open()

                End If
                Sleep(100)
                RaiseEvent ConnectionState(oleConn.State)
                m_iRetary += 1

                If m_iRetary > 5 Then

                    Return False
                End If

                Select Case oleConn.State
                    Case Data.ConnectionState.Broken
                        Return False
                End Select
            Loop
            Return True
        Catch ex As Exception
            RaiseEvent ConnectionError(ex)
        End Try
    End Function

    Public Function Disconnect()
        Try
            oleConn.Close()
            Sleep(100)
            RaiseEvent ConnectionState(oleConn.State)
        Catch ex As Exception
            RaiseEvent ConnectionError(ex)
        End Try
    End Function

    Public Function GetDataTable(ByVal query As String) As DataTable
        Const DATEFORMAT As String = "SET DATEFORMAT dmy" & Chr(13) & Chr(10)
        query = DATEFORMAT & query
        query = CheckSql(query)

        Try
            '            Dim oleConn As New OleDb.OleDbConnection(ConnectionString)
            Dim oleAdapter As New OleDb.OleDbDataAdapter
            oleAdapter.SelectCommand = New OleDb.OleDbCommand(query, oleConn)
            Dim dt As New DataTable
            oleAdapter.Fill(dt)

            '   lg.WriteLog("dbconnect", query)
            oleAdapter.Dispose()
            oleAdapter = Nothing
            Return dt

        Catch Ex As Exception
            '  lg.WriteErr("RptOperationReport", "@ Error in Operation Report Err:" & Ex.Message & " StackTrace:" & Ex.StackTrace)
            RaiseEvent ActionError(Ex)
            Return Nothing
        End Try

    End Function
    Public Function ExecSql(ByVal query As String) As Integer
        ' theError$ = ""

        Const DATEFORMAT As String = "SET DATEFORMAT dmy" & Chr(13) & Chr(10)
        query = DATEFORMAT & query

        Try

            '  Dim oleConn As New OleDb.OleDbConnection(ConnectionString)
            Dim oleAdapter As New OleDb.OleDbDataAdapter
            Dim nrRow As Integer = 0


            If oleConn.State <> Data.ConnectionState.Open Then
                Connect()

            End If

            query = CheckSql(query)

            oleAdapter.SelectCommand = New OleDb.OleDbCommand(query, oleConn)
            nrRow = oleAdapter.SelectCommand.ExecuteNonQuery()

            'oleAdapter.Fill(theDataSet)

            '  lg.WriteLog("dbconnect", "@@ ExecSql: " & query)


            '   oleConn.Close()
            '   oleConn = Nothing
            oleAdapter.Dispose()
            oleAdapter = Nothing

            Return nrRow
        Catch Ex As Exception
            'theError$ = "@ Error in ExecSql() Err:" & Ex.Message
            'lg.WriteErr("DbConnect", "@ Error in ExecSql() Err:" & Ex.Message)
            RaiseEvent ActionError(Ex)
            Return 0
        End Try

    End Function
    Public Function GetDataMSAccessTable(ByVal query As String) As DataTable
        '  Const DATEFORMAT As String = "SET DATEFORMAT dmy" & Chr(13) & Chr(10)
        ' query = DATEFORMAT & query
        query = CheckSql(query)

        Try
            '            Dim oleConn As New OleDb.OleDbConnection(ConnectionString)
            Dim oleAdapter As New OleDb.OleDbDataAdapter
            oleAdapter.SelectCommand = New OleDb.OleDbCommand(query, oleConn)
            Dim dt As New DataTable
            Debug.Print(query)
            oleAdapter.Fill(dt)

            '   lg.WriteLog("dbconnect", query)
            oleAdapter.Dispose()
            oleAdapter = Nothing
            Return dt

        Catch Ex As Exception
            '  lg.WriteErr("RptOperationReport", "@ Error in Operation Report Err:" & Ex.Message & " StackTrace:" & Ex.StackTrace)
            RaiseEvent ActionError(Ex)
            Return Nothing
        End Try

    End Function
    Public Function ExecSqlMSAccess(ByVal query As String) As Integer
        ' theError$ = ""

        '     Const DATEFORMAT As String = "SET DATEFORMAT dmy" & Chr(13) & Chr(10)
        ' query = DATEFORMAT & query

        Try

            '  Dim oleConn As New OleDb.OleDbConnection(ConnectionString)
            Dim oleAdapter As New OleDb.OleDbDataAdapter
            Dim nrRow As Integer = 0


            If oleConn.State <> Data.ConnectionState.Open Then
                Connect()

            End If

            query = CheckSql(query)
            Debug.Print(query)

            oleAdapter.SelectCommand = New OleDb.OleDbCommand(query, oleConn)


            nrRow = oleAdapter.SelectCommand.ExecuteNonQuery

            'oleAdapter.Fill(theDataSet)

            '  lg.WriteLog("dbconnect", "@@ ExecSql: " & query)


            '   oleConn.Close()
            '   oleConn = Nothing
            oleAdapter.Dispose()
            oleAdapter = Nothing

            Return nrRow
        Catch Ex As Exception
            MsgBox("ERRORE SQL: " + vbCrLf + query + vbCrLf + "-------------------------------------------------" + vbCrLf + Ex.Message)

            'theError$ = "@ Error in ExecSql() Err:" & Ex.Message
            'lg.WriteErr("DbConnect", "@ Error in ExecSql() Err:" & Ex.Message)
            RaiseEvent ActionError(Ex)
            Return 0
        End Try

    End Function
    Private Function CheckSql(ByVal Sql As String) As String
        Try
            '*****************************************
            'Const nchar As Integer = 34
            Sql = Replace(Sql, "'", "''")
            'Sql = Replace(Sql, Chr(nchar), "'")
            Sql = Replace(Sql, "§", "'")
            '*****************************************
            Return Sql
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Private Sub oleConn_Disposed(sender As Object, e As EventArgs) Handles oleConn.Disposed
        Try
            Debug.Print("")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub oleConn_InfoMessage(sender As Object, e As OleDb.OleDbInfoMessageEventArgs) Handles oleConn.InfoMessage
        Try
            Debug.Print("")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub oleConn_StateChange(sender As Object, e As StateChangeEventArgs) Handles oleConn.StateChange
        Try
            Debug.Print("")
            Dim o_OleDbConnection As System.Data.OleDb.OleDbConnection = sender

            RaiseEvent ConnectionState(o_OleDbConnection.State)
        Catch ex As Exception

        End Try
    End Sub
End Class
