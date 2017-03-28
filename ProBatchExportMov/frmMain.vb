Imports System.ComponentModel

Public Class frmMain
    Dim f_export As Boolean
    Dim f_readmov As Boolean
    Dim i_AggregationType As Integer

    Dim DB As ClassDatabase
    Dim _840002C1 As ClassDatabase
    Dim _840002P1 As ClassDatabase
    Dim _840002R1 As ClassDatabase

    Dim [PRODLINE_IDENT] As String = "LP1"

    Dim c_CAR As String = "ZSCA"
    Dim c_SCA As String = "ZCAR"

    Private Sub TEST_connection()



        Try
            If _840002R1.Connect Then
                DB_ORIGINE.BackColor = Color.Lime
                f_readmov = True
                BTN_READ.Enabled = True
            Else
                DB_ORIGINE.BackColor = Color.Red
                f_readmov = False
                BTN_READ.Enabled = False
            End If


            If DB.Connect And f_readmov = True Then
                DB_DEST.BackColor = Color.Lime
                f_export = True
                BTN_EXPORT.Enabled = True
            Else
                DB_DEST.BackColor = Color.Red
                f_export = False
                BTN_EXPORT.Enabled = False
            End If



        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
             c_CAR =My.Settings.c_CAR 
            c_SCA =My.Settings.c_SCA   
        Catch ex As Exception

        End Try

        Try
            DB = New ClassDatabase(My.Settings.ConnectionString)

            '            _840002C1 = New ClassDatabase(My.Settings._840002C1ConnectionString)
            '           _840002P1 = New ClassDatabase(My.Settings._840002P1ConnectionString)
            _840002R1 = New ClassDatabase(My.Settings._840002R1ConnectionString)

            TEST_connection()

            DT1.Value = Now
            DT2.Value = Now

            LOAD_Settings()

            BTN_READ.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        SAVE_Settings()
        End
    End Sub

    Dim datatablemov As New DataTable
    Private Sub BTN_READ_Click(sender As Object, e As EventArgs) Handles BTN_READ.Click

        Try
            TEST_connection()

            If f_readmov Then
                datatablemov = ReadProbatchMov(DT1.Value, DT2.Value, Me.f_Compatta.Checked)

            DataGridView1.DataSource = datatablemov

                NR_MOV.Text = datatablemov.Rows.Count.ToString
            End If
        Catch ex As Exception
            NR_MOV.Text = "-1"
        End Try
    End Sub


    Private Function ReadProbatchMov(ByVal mydt1 As Date, mydt2 As Date, ByVal f_compatta As Boolean) As DataTable

        Try
            _840002R1.Connect()



            Dim strText As String = String.Empty & vbCrLf
            'strText = strText & "SELECT        REPORT_PRODUCTION.REPPROD_NUMBER, REPORT_PRODUCTION.PRODLINE_IDENT, REPORT_PRODUCTION.RECIPE_IDENT, " & vbCrLf
            'strText = strText & "                         REPORT_PRODUCTION.RECIPE_NAME, REPORT_PRODUCTION.PROD_SETPOINT, REPORT_PRODUCTION.PROD_ACTVALUE, " & vbCrLf
            'strText = strText & "                         REPORT_BATCH.SEQUENCE_NUMBER, REPORT_BATCH.BATCH_SETPOINT, REPORT_BATCH.BATCH_ACTVALUE, REPORT_BATCH.BATCH_NUMBER, " & vbCrLf
            'strText = strText & "                         REPORT_MATERIAL.MAT_START_DATE, REPORT_MATERIAL.MAT_END_DATE, REPORT_MATERIAL.MAT_ABORT, REPORT_MATERIAL.MAT_SETPOINT, " & vbCrLf
            'strText = strText & "                         REPORT_MATERIAL.MAT_UNIT, REPORT_MATERIAL.MAT_ACTVALUE, REPORT_MATERIAL.MAT_IDENT, REPORT_MATERIAL.MAT_NAME, " & vbCrLf
            'strText = strText & "                         REPORT_MATERIAL.MAT_BATCH_MODE, REPORT_PRODUCTION.PROD_ABORT, REPORT_BATCH.BATCH_ABORT, REPORT_MATERIAL.WP_IDENT" & vbCrLf
            'strText = strText & "FROM            ((REPORT_BATCH RIGHT OUTER JOIN" & vbCrLf
            'strText = strText & "                         REPORT_MATERIAL ON REPORT_BATCH.REPBATCH_NUMBER = REPORT_MATERIAL.REPBATCH_NUMBER) LEFT OUTER JOIN" & vbCrLf
            'strText = strText & "                         REPORT_PRODUCTION ON REPORT_BATCH.REPPROD_NUMBER = REPORT_PRODUCTION.REPPROD_NUMBER)" & vbCrLf
            'strText = strText & "WHERE        (REPORT_MATERIAL.MAT_BATCH_MODE NOT IN (§B8§, §D5§)) AND (REPORT_MATERIAL.MAT_START_DATE BETWEEN #" + DT1.Value.ToString("dd/MM/yyyy") + " 00:00:00# AND #" + DT2.Value.ToString("dd/MM/yyyy") + " 23:59:59#)" & vbCrLf




            If f_compatta Then
                'strText = "SELECT                " & vbCrLf
                'strText = strText & "	left(MAT_START_DATE,11) as MAT_START_DATE , " & vbCrLf
                'strText = strText & "	 sum(REPORT_MATERIAL.MAT_SETPOINT) as MAT_SETPOINT, " & vbCrLf
                'strText = strText & "	 max(REPORT_MATERIAL.MAT_UNIT) as MAT_UNIT, " & vbCrLf
                'strText = strText & "	 sum(REPORT_MATERIAL.MAT_ACTVALUE) as MAT_ACTVALUE, " & vbCrLf
                'strText = strText & "                 REPORT_MATERIAL.MAT_IDENT, " & vbCrLf
                'strText = strText & "	 max(REPORT_MATERIAL.MAT_NAME) as MAT_NAME, " & vbCrLf
                'strText = strText & "	 REPORT_MATERIAL.MAT_BATCH_MODE" & vbCrLf
                'strText = strText & "                         " & vbCrLf
                'strText = strText & "FROM            REPORT_BATCH RIGHT OUTER JOIN" & vbCrLf
                'strText = strText & "                      REPORT_MATERIAL ON REPORT_BATCH.REPBATCH_NUMBER = REPORT_MATERIAL.REPBATCH_NUMBER LEFT OUTER JOIN" & vbCrLf
                'strText = strText & "                      REPORT_PRODUCTION ON REPORT_BATCH.REPPROD_NUMBER = REPORT_PRODUCTION.REPPROD_NUMBER" & vbCrLf
                'strText = strText & "WHERE        (REPORT_MATERIAL.MAT_BATCH_MODE NOT IN (§B8§, §D5§))  AND (REPORT_MATERIAL.MAT_START_DATE BETWEEN #" + DT1.Value.ToString("dd/MM/yyyy") + " 00:00:00# AND #" + DT2.Value.ToString("dd/MM/yyyy") + " 23:59:59#)" & vbCrLf
                'strText = strText & "group by MAT_IDENT , REPORT_MATERIAL.MAT_BATCH_MODE,left(MAT_START_DATE,11)" & vbCrLf
                'strText = strText & "order by MAT_IDENT" & vbCrLf
                'Dim myDataTable As New DataTable
                'myDataTable = _840002R1.GetDataMSAccessTable(strText)
                'DataGridView1.DataSource = myDataTable

                'NR_MOV.Text = myDataTable.Rows.Count.ToString
                Select Case i_AggregationType
                    Case 0
                        Dim DataTableD As New DataTable
                        DataTableD = _840002R1.GetDataMSAccessTable(GetAggregationType_0(mydt1, mydt2))
                        'DataGridView1.DataSource = DataTableC

                        'NR_MOV.Text = DataTableD.Rows.Count.ToString
                        Return DataTableD
                    Case 1
                        Dim DataTableC As New _840002R1DataSet.V_GET_MOV_COMPACTDataTable
                        V_GET_MOV_COMPACTTableAdapter1.Connection = _840002R1.oleConn

                        V_GET_MOV_COMPACTTableAdapter1.FillCompact(DataTableC, CDate(mydt1.ToString("dd/MM/yyyy") + " 00:00:00"), CDate(mydt2.ToString("dd/MM/yyyy") + " 23:59:59"))
                        '   V_GET_MOVTableAdapter1.Fill(DataTable)

                        'DataGridView1.DataSource = DataTableC

                        'NR_MOV.Text = DataTableC.Rows.Count.ToString
                        Return DataTableC
                End Select


            Else
                    Dim DataTable As New _840002R1DataSet.V_GET_MOVDataTable
                V_GET_MOVTableAdapter1.Connection = _840002R1.oleConn

                V_GET_MOVTableAdapter1.FillByDate(DataTable, CDate(mydt1.ToString("dd/MM/yyyy") + " 00:00:00"), CDate(mydt2.ToString("dd/MM/yyyy") + " 23:59:59"))
                '   V_GET_MOVTableAdapter1.Fill(DataTable)

                'DataGridView1.DataSource = DataTable

                'NR_MOV.Text = DataTable.Rows.Count.ToString

                Return DataTable
            End If

            Debug.Print("")
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Function


    Private Function GetAggregationType_0(ByVal mDT1 As Date, ByVal mDT2 As Date) As String
        Try

            ' Dim m_DATA_FORMAT As String = "MM/dd/yyyy"
            Dim m_DATA_FORMAT As String = "yyyy-MM-dd"
            Dim m_SEP As String = "#"


            Dim strText As String = String.Empty & vbCrLf
            strText = "SELECT   LEFT(REPORT_MATERIAL.MAT_START_DATE, 11) AS MAT_START_DATE,[RECIPE_IDENT], round(SUM(REPORT_MATERIAL.MAT_SETPOINT),3) AS MAT_SETPOINT, " & vbCrLf
            strText = strText & "         round(SUM(REPORT_MATERIAL.MAT_ACTVALUE),3) AS MAT_ACTVALUE,MAX(REPORT_MATERIAL.MAT_UNIT) AS MAT_UNIT, REPORT_MATERIAL.MAT_IDENT, " & vbCrLf
            strText = strText & "         MAX(REPORT_MATERIAL.MAT_NAME) AS MAT_NAME, REPORT_MATERIAL.MAT_BATCH_MODE,§"+c_SCA +"§ as causale" & vbCrLf
            strText = strText & "FROM     ((REPORT_BATCH RIGHT OUTER JOIN" & vbCrLf
            strText = strText & "         REPORT_MATERIAL ON REPORT_BATCH.REPBATCH_NUMBER = REPORT_MATERIAL.REPBATCH_NUMBER) LEFT OUTER JOIN" & vbCrLf
            strText = strText & "         REPORT_PRODUCTION ON REPORT_BATCH.REPPROD_NUMBER = REPORT_PRODUCTION.REPPROD_NUMBER)" & vbCrLf
            strText = strText & "WHERE    (REPORT_MATERIAL.MAT_BATCH_MODE NOT IN (§B8§, §D5§)) AND (REPORT_MATERIAL.MAT_START_DATE BETWEEN " + m_SEP + mDT1.ToString(m_DATA_FORMAT) + " 00:00:00" + m_SEP + " And " + m_SEP + mDT2.ToString(m_DATA_FORMAT) + " 23:59:59" + m_SEP + ")" & vbCrLf
            strText = strText & "GROUP BY [RECIPE_IDENT],REPORT_MATERIAL.MAT_IDENT, REPORT_MATERIAL.MAT_BATCH_MODE, LEFT(REPORT_MATERIAL.MAT_START_DATE, 11)" & vbCrLf
            '     strText = strText & "--ORDER BY  LEFT(REPORT_MATERIAL.MAT_START_DATE, 11),[RECIPE_IDENT],REPORT_MATERIAL.MAT_IDENT" & vbCrLf
            strText = strText & "union" & vbCrLf
            strText = strText & "SELECT  LEFT(BATCH_START_DATE, 11) as  MAT_START_DATE, " & vbCrLf
            strText = strText & "		 RECIPE_IDENT, " & vbCrLf
            strText = strText & "		 round(sum(BATCH_SETPOINT),3) as BATCH_SETPOINT, round(sum(BATCH_ACTVALUE),3) as BATCH_ACTVALUE , " & vbCrLf
            strText = strText & "		 max(BATCH_UNIT) as BATCH_UNIT" & vbCrLf
            strText = strText & "		 ,§§ as MAT_IDENT,§§ as MAT_NAME,§§ as MAT_BATCH_MODE, §" +c_CAR  +"§ as causale" & vbCrLf
            strText = strText & "FROM   REPORT_BATCH LEFT OUTER JOIN" & vbCrLf
            strText = strText & "       REPORT_PRODUCTION ON REPORT_BATCH.REPPROD_NUMBER = REPORT_PRODUCTION.REPPROD_NUMBER" & vbCrLf
            strText = strText & "WHERE  Not LEFT(BATCH_START_DATE, 11) Is null  And (BATCH_START_DATE BETWEEN " + m_SEP + mDT1.ToString(m_DATA_FORMAT) + " 00:00:00" + m_SEP + " AND " + m_SEP + mDT2.ToString(m_DATA_FORMAT) + " 23:59:59" + m_SEP + ")" & vbCrLf
            strText = strText & "GROUP BY [RECIPE_IDENT], LEFT(BATCH_START_DATE, 11)" & vbCrLf
            ' strText = strText & "--ORDER BY  LEFT(BATCH_START_DATE, 11), [RECIPE_IDENT]" & vbCrLf
            Return strText
        Catch ex As Exception

        End Try
    End Function





    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SAVE_Settings()
    End Sub




    Private Sub LOAD_Settings()
        Try
            i_AggregationType = My.Settings.i_AggregationType

            Select Case i_AggregationType
                Case 0
                    i_AggregationType_0.Checked = True
                Case 1
                    i_AggregationType_1.Checked = True

            End Select



            Me.f_Compatta.Checked = My.Settings.f_Compatta
            Me.f_DeleteBefore.Checked = My.Settings.f_DeleteBefore

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Check_i_AggregationType()
        Try
            If i_AggregationType_0.Checked = True Then
                i_AggregationType = 0
                Exit Sub
            ElseIf i_AggregationType_1.Checked = True Then
                i_AggregationType = 1
                End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SAVE_Settings()
        Try
            My.Settings.i_AggregationType = i_AggregationType
            My.Settings.f_Compatta = Me.f_Compatta.Checked
            My.Settings.f_DeleteBefore = Me.f_DeleteBefore.Checked
            My.Settings.Save()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub DT1_ValueChanged(sender As Object, e As EventArgs) Handles DT1.ValueChanged
        Try
            DT2.Value = DT1.Value
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub BTN_EXPORT_Click(sender As Object, e As EventArgs) Handles BTN_EXPORT.Click
        BTN_READ.PerformClick()
        If f_export Then
            ExportMovimentiProbatch(datatablemov, Me.f_Compatta.Checked, Me.f_DeleteBefore.Checked)
        End If
    End Sub

    Private Function ExportMovimentiProbatch(ByVal MyDataTable As DataTable, ByVal f_compatta As Boolean, ByVal f_DeleteBefore As Boolean) As Boolean
        Try
            Dim DB As New ClassDatabase(My.Settings.ConnectionString)


            DB.Connect()

            'clear tabella export
            If f_DeleteBefore Then
                DB.ExecSql("DELETE [EXPORT_MOVIMENTI]")
            End If

            '+		MAT_ACTVALUEColumn	{MAT_ACTVALUE}	System.Data.DataColumn
            '+		MAT_BATCH_MODEColumn	{MAT_BATCH_MODE}	System.Data.DataColumn
            '+		MAT_IDENTColumn	{MAT_IDENT}	System.Data.DataColumn
            '+		MAT_NAMEColumn	{MAT_NAME}	System.Data.DataColumn
            '+		MAT_SETPOINTColumn	{MAT_SETPOINT}	System.Data.DataColumn
            '+		MAT_START_DATEColumn	{MAT_START_DATE}	System.Data.DataColumn
            '+		MAT_UNITColumn	{MAT_UNIT}	System.Data.DataColumn

            If f_compatta Then
                Select Case i_AggregationType
                    Case 0
                        For Each r As System.Data.DataRow In datatablemov.Rows

                            Debug.Print("")



                            If r("CAUSALE") = c_SCA  Then

                                'righe dettaglio

                                Dim sep As String = InStr(r("MAT_IDENT"), "_")
                                Dim tmp_MAT_IDENT As String = ""
                                If sep > 0 Then
                                    tmp_MAT_IDENT = r("MAT_IDENT").Substring(sep)
                                Else
                                    tmp_MAT_IDENT = r("MAT_IDENT")

                                End If
                                Dim SQL As String = String.Format("INSERT INTO [EXPORT_MOVIMENTI] (MAT_START_DATE, MAT_IDENT, MAT_NAME, MAT_ACTVALUE, MAT_BATCH_MODE,MAT_SETPOINT,MAT_UNIT,CODICE,CAUSALE) VALUES (§{0}§,§{1}§,§{2}§,{3},§{4}§,{5},§{6}§,§{7}§,§{8}§)", r("MAT_START_DATE"), r("MAT_IDENT"), r("MAT_NAME"), Replace(r("MAT_ACTVALUE"), ",", "."), r("MAT_BATCH_MODE"), Replace(r("MAT_SETPOINT"), ",", "."), r("MAT_UNIT"), tmp_MAT_IDENT, r("CAUSALE"))

                                DB.ExecSql(SQL)
                            Else
                                ' testate totali produzione ricette

                                Dim sep As String = InStr(r("RECIPE_IDENT"), "_")
                                Dim tmp_MAT_IDENT As String = ""
                                If sep > 0 Then
                                    tmp_MAT_IDENT = r("RECIPE_IDENT").Substring(sep)
                                Else
                                    tmp_MAT_IDENT = r("RECIPE_IDENT")

                                End If
                                Dim SQL As String = String.Format("INSERT INTO [EXPORT_MOVIMENTI] (MAT_START_DATE, MAT_IDENT, MAT_NAME, MAT_ACTVALUE, MAT_BATCH_MODE,MAT_SETPOINT,MAT_UNIT,CODICE,CAUSALE) VALUES (§{0}§,§{1}§,§{2}§,{3},§{4}§,{5},§{6}§,§{7}§,§{8}§)", r("MAT_START_DATE"), "", "", Replace(r("MAT_ACTVALUE"), ",", "."), "", Replace(r("MAT_SETPOINT"), ",", "."), r("MAT_UNIT"), tmp_MAT_IDENT, r("CAUSALE"))

                                DB.ExecSql(SQL)

                            End If





                        Next
                    Case 1
                        For Each r As _840002R1DataSet.V_GET_MOV_COMPACTRow In MyDataTable.Rows

                            Debug.Print("")

                            Dim sep As String = InStr(r.MAT_IDENT, "_")
                            Dim tmp_MAT_IDENT As String = ""

                            If sep > 0 Then
                                tmp_MAT_IDENT = r.MAT_IDENT.Substring(sep)
                            Else
                                tmp_MAT_IDENT = r.MAT_IDENT

                            End If
                            Try
                                Dim SQL As String = String.Format("INSERT INTO [EXPORT_MOVIMENTI] (MAT_START_DATE, MAT_IDENT, MAT_NAME, MAT_ACTVALUE, MAT_BATCH_MODE,MAT_SETPOINT,MAT_UNIT,CODICE,CAUSALE) VALUES (§{0}§,§{1}§,§{2}§,{3},§{4}§,{5},§{6}§,§{7}§,§{8}§)", r.MAT_START_DATE, r.MAT_IDENT, r.MAT_NAME, Replace(r.MAT_ACTVALUE, ",", "."), r.MAT_BATCH_MODE, Replace(r.MAT_SETPOINT, ",", "."), r.MAT_UNIT, tmp_MAT_IDENT, c_SCA )
                                DB.ExecSql(SQL)
                            Catch ex As Exception
                                Debug.Print(ex.Message)
                            End Try
                        Next
                End Select
            Else


            End If

            Dim EXPORT_MOVIMENTI As DataTable = DB.GetDataTable("select * from [EXPORT_MOVIMENTI]")
            If Not EXPORT_MOVIMENTI Is Nothing Then
                MsgBox(String.Format("Export terminato, sono presenti {0} movimenti", EXPORT_MOVIMENTI.Rows.Count.ToString.Trim))
                Return True
            Else
                MsgBox("Export fallito")
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TEST_connection()
    End Sub

    Private Sub i_AggregationType_0_CheckedChanged(sender As Object, e As EventArgs) Handles i_AggregationType_0.CheckedChanged, i_AggregationType_1.CheckedChanged
        Check_i_AggregationType()

    End Sub
End Class
