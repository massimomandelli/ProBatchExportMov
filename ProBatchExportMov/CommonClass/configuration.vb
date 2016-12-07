Imports System
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Globalization
Imports System.SystemException
Imports System.Math

Module Configuration
    Public Conn As New System.Data.SqlClient.SqlConnection(My.Settings.ConnectionString)
    'Conn = New SqlConnection(My.Settings.Okey_netConnectionString)

    'Public W_Cliente As Int32
    'Public W_DesCliente As String
    'Public T_Elab As DataTable
    ''Public W_FormCli As f_clienti

    'Public W_Report As CrystalDecisions.CrystalReports.Engine.ReportDocument
    'Public W_ReportFile As String
    'Public W_Report_SF As String
    'Public W_ReportTitolo As String
    'Public W_ReportNPar As Int16
    'Public W_ReportPar(2, 0) As String
    'Public w_kqta As Int32
    'Public W_User As String
    Public c_ON_color As Color = Color.Lime
    Public c_Off_color As Color = Color.Black
    Public c_Waiting_color As Color = Color.Orange
    Public c_Error_color As Color = Color.Red


    Interface I_UC_Common_CMD
        'Event ComittedChange(ByVal Success As Boolean)
        ' Property Division() As String
        Sub Activated()
        Sub Deactivated()

    End Interface


    '<+>============================================================<->
    '  Const DATE
    Public GLOBAL_DB_DATEFORMAT As String = "SET DATEFORMAT dmy"
    Public GLOBAL_DATE_FORMAT As String = "dd/MM/yyyy"
    Public GLOBAL_DATE_TIME As String = "HH:mm:ss"
    'Public GLOBAL_DATETIME_FORMAT = "MM/dd/yyyy HH:mm:ss"
    Public GLOBAL_DATETIME_FORMAT As String = "dd/MM/yyyy HH:mm:ss"
    Public GLOBAL_DB_DATETIME_FORMAT As String = GLOBAL_DATETIME_FORMAT '"MM/dd/yyyy HH:mm:ss"
    Public GLOBAL_DATENULL As Date = CDate("01/01/1900 00:00:00")
    Public ReportDirectory As String = String.Empty

    '<+>============================================================<->
    '  Global class
    Public Lg As clsLog                             ' Class for LOG
    ' Public Cn As DbConnect                      ' DB 
    'Public Cn As cl_sql                            ' DB 
    Public fIni As IniReader
    ' Public MyDate As ClassDateUtility
    '   Public cPrinter As clsAPrinters_Collection
    '  Public cGridPos As ClassGridPosition
    Public cUser As ClassUser

    'Public myPrtTypeList() As Object = {"Report", "Etichette"}
    ' Public myStatusList() As Object = {"Carico", "Scarico"}
    ' Public myProductionStatusList() As Object = {"In programmazione", "Pronto per la produzione", "In produzione", "Produzione completata", "Errore", "Pausa"}

    ' Public cReports As clsReportconfiguration_Collection
    'Public cScanners As New clsAScanner_Collection
    'Public WithEvents cScanner As New clsAScanner_Class
    Public G_IsDeveloper As Boolean = False 'My.Settings.IsDeveloper

    ' Windows size definitions
    Public G_MainForm As Object
    Public G_NEWFRM As Long = 0
    'Public G_SHOWDIALOG As Boolean = True
    Public G_WINSIZE_SYSTEM As Boolean = False
    Public G_FormWindowState As FormWindowState = FormWindowState.Maximized
    Public G_MAX_Width As Integer = 1280
    Public G_MAX_Height As Integer = 1024

    ' Store definitions
    'Public G_STORE_Raw_Material As Integer = 1   'materia prima
    'Public G_STORE_Semifinished As Integer = 2
    'Public G_STORE_End_Product As Integer = 3
    'Public G_STORE_Rejection As Integer = 4
    'Public G_STORE_Production As Integer = 5

    ' Mesaure unit
    Public G_UM As String = "kg"
    Public G_UMR As String = "kg"
    Public G_DECIMALPLACE As Integer = 2
    Public G_TOLLERANZAPERC_DEF As Integer = 5

    'Public G_MESISCADENZA As Integer = 12
    Public G_EXPIRYDATE_DAY As Integer = 365
    Public G_EXPIRYDATE_DAY_DEF As Integer = 12
    Public G_EXPIRYDATE_UM As String = "MM"     'MM=mesi dd=giorni

    Public G_IDUSER As Long = 0
    Public G_USERNAME As String = ""
    Public G_LEVEL As Integer = 0

    Public G_INVALID_DATE As Date = CDate("01/01/1900")
    Public G_REPORT_DIRECTORY As String = Application.StartupPath & "\rpt\"
    ' Dim mReportName As String = Application.StartupPath & "\rpt\tankticket.rpt"


    '<+>============================================================<->
    '  Produzione
    Public G_PRODUCTION_MODE As Integer = 0 '0=Vertical 1=Orizzontal
    Public DbType As String
    Public DBSEP As String = Chr(39)
    Public WithEvents Log As clsLog                        ' Class for LOG
    Public fUDL As IniReader
    '  Public myUm As clsAUm_Collection
    ' Dim Security As ClassSecurity
    '  Dim Key As ClassKey

    Public Enum eLoadState As Integer
        Load = 1
        Unload = 2
        Reserved = 5
    End Enum

    <STAThread()>
    Public Sub MainInit()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB", True)

        With Thread.CurrentThread.CurrentCulture
            '.NumberFormat.DigitSubstitution = ","
            .NumberFormat.NumberDecimalSeparator = "."
            .DateTimeFormat.DateSeparator = "/"
            .DateTimeFormat.TimeSeparator = ":"
            .DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
            .DateTimeFormat.ShortTimePattern = "HH:mm"
            .DateTimeFormat.LongTimePattern = "HH:mm:ss"
        End With

        Try
            ' Security = New ClassSecurity
            '    Key = New ClassKey
            'CheckKey()
            'Log = New clsLog
            fUDL = New IniReader
            'myUm = New clsAUm_Collection

            Lg = New clsLog



            'Cn = New DbConnect
            'Public Cn As cl_sql                            
            fIni = New IniReader
            'MyDate = New ClassDateUtility

            'cGridPos = New ClassGridPosition
            cUser = New ClassUser
            ' cPrinter = New clsAPrinters_Collection
        Catch ex As Exception
            MsgBox("Errore : " & ex.Message)
        End Try

        ' G_MainForm = Me
        'Main()
        'Cn.ConnectionString = My.Settings.ConnectionString
        'Cn.User = "ef"
        'Cn.Password = "ef"
        'Cn.Catalog = "EF"
        'Cn.Server = "PROMIXPC"
        'Cn.MakeConnectionString()

        'Cn.MakeConnectionStringFromConn(My.Settings.ConnectionString)

        'If Cn.DBOpen = False Then
        '    MsgBox("Database not found!")
        'Else




        'Cn.GetTableStructure()
        cUser.LogOut()
        'Me.User.Text = G_USERNAME
        'Me.Level.Text = G_LEVEL


        '  myUm.Load()
        'ScannerOn()
        'frmScannerLog.Show()

        ' cPrinter.Load()
        'cReports = New clsReportconfiguration_Collection
        'cReports.Load()




        'End If
        '  ToolStripStatusLabel.Text = "Server: " & Cn.Server.ToUpper

        'Application.EnableVisualStyles()
        'Application.SetCompatibleTextRenderingDefault(False)
        'Try
        '    Application.Run(New frmMain())

        '    Debug.Print("")
        'Catch ex As Exception
        '    MsgBox("Errore : " & ex.Message)
        'End Try

        'Try
        '    'Log = New clsLog
        '    fUDL = Nothing
        '    myUm = Nothing

        '    Lg = Nothing
        '    Cn = Nothing
        '    'Public Cn As cl_sql                            
        '    fIni = Nothing
        '    MyDate = Nothing
        '    cPrinter = Nothing
        '    cGridPos = Nothing
        '    cUser = Nothing
        'Catch ex As Exception

        'End Try

        'Try
        '    frmReport.Dispose()
        '    frmReport = Nothing
        'Catch ex As Exception

        'End Try


    End Sub

    'Public Sub CheckKey(Optional showForm As Boolean = False)
    '    Dim mK1 As String = ""
    '    Do Until False
    '        mK1 = Security.UTL_Encrypt(Security.getMacAddress)

    '        ' autenticazione
    '        If My.Settings.KEY <> mK1 Or showForm Then

    '            With ClassKey
    '                '.Show()
    '                .mKey1 = mK1
    '                .ShowDialog()
    '                If .f_OK = True Then Exit Do
    '            End With
    '        Else
    '            Exit Do
    '        End If

    '        If MsgBox("Vuoi terminare?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            End
    '        End If

    '    Loop
    'End Sub


    'Public Function UmC(ByVal Value As Decimal, ByVal UmValue As String, Optional ByVal UmFinal As String = "") As Decimal
    '    Dim tmpV As Decimal
    '    Dim tmpV1 As Decimal

    '    Try
    '        If UmFinal = "" Then
    '            UmFinal = myUm.KeyItem(UmValue).UMRIF
    '        End If
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '    End Try


    '    If UmFinal = UmValue Then
    '        Return Round(Value, G_DECIMALPLACE)
    '    End If

    '    Try
    '        If UmValue <> myUm.KeyItem(UmValue).UMRIF Then
    '            'Debug.Print(Round(myUm.KeyItem(UmValue).FACTOR(), G_DECIMALPLACE))
    '            tmpV = Round(myUm.KeyItem(UmValue).FACTOR() * Value, G_DECIMALPLACE)
    '        Else
    '            tmpV = Value
    '        End If
    '    Catch ex As Exception
    '        tmpV = Value
    '    End Try

    '    Try
    '        If UmFinal <> UmValue Then
    '            'Debug.Print(Round(myUm.KeyItem(UmFinal).FACTOR(), G_DECIMALPLACE))
    '            tmpV1 = Round(1 / myUm.KeyItem(UmFinal).FACTOR(), G_DECIMALPLACE) * tmpV
    '        Else
    '            tmpV1 = tmpV
    '        End If
    '    Catch ex As Exception
    '        tmpV1 = tmpV
    '    End Try

    '    tmpV1 = Round(tmpV1, G_DECIMALPLACE)
    '    Return tmpV1

    'End Function


    'Public Function UmRif(ByVal UmValue As String) As String
    '    Try
    '        Return myUm.KeyItem(UmValue).UMRIF
    '    Catch ex As Exception
    '        Return ""
    '    End Try
    'End Function

    Public Function MyRound(ByVal Value As Decimal) As Decimal
        Return Round(Value, G_DECIMALPLACE)
    End Function

    'Public Function EXPIRYDATE_def() As Date
    '    Return Format(DateAdd(DateInterval.Day, G_EXPIRYDATE_DAY_DEF, Now), GLOBAL_DATE_FORMAT)
    'End Function


    Public Sub Er(ByVal theExeption As Exception)
        MsgBox("Errore : " & theExeption.Message, MsgBoxStyle.Critical)
    End Sub

    Public Function KeyConv(ByVal Key As String) As Keys
        Select Case Key
            Case "F1"
                Return Keys.F1
            Case "F2"
                Return Keys.F2
            Case "F3"
                Return Keys.F3
            Case "F4"
                Return Keys.F4
            Case "F5"
                Return Keys.F5
            Case "F6"
                Return Keys.F6
            Case "F7"
                Return Keys.F7
            Case "F8"
                Return Keys.F8
            Case "F9"
                Return Keys.F9
            Case "F10"
                Return Keys.F10
            Case "F11"
                Return Keys.F11
            Case "F12"
                Return Keys.F12
            Case "F13"
                Return Keys.F13
            Case "F14"
                Return Keys.F14
            Case "F15"
                Return Keys.F15
            Case "F16"
                Return Keys.F16
            Case "F17"
                Return Keys.F17
            Case "F18"
                Return Keys.F18
            Case "F19"
                Return Keys.F19
            Case "F20"
                Return Keys.F20
            Case "F21"
                Return Keys.F21

        End Select
    End Function


    'Public Function JulianDate(ByVal datDate As Date) As Double
    '    Dim GGG
    '    Dim DD, MM, YY
    '    Dim S, A
    '    Dim JD, J1

    '    MM = Month(datDate)
    '    'DD = Day(datDate)
    '    DD = DatePart(DateInterval.Day, datDate)
    '    YY = Year(datDate)
    '    GGG = 1

    '    If (YY <= 1585) Then
    '        GGG = 0
    '    End If

    '    JD = -1 * Int(7 * (Int((MM + 9) / 12) + YY) / 4)
    '    S = 1

    '    If ((MM - 9) < 0) Then
    '        S = -1
    '    End If


    '    A = Math.Abs(MM - 9)
    '    J1 = Int(YY + S * Int(A / 7))
    '    J1 = -1 * Int((Int(J1 / 100) + 1) * 3 / 4)
    '    JD = JD + Int(275 * MM / 9) + DD + (GGG * J1)
    '    JD = JD + 1721027 + 2 * GGG + 367 * YY

    '    If ((DD = 0) And (MM = 0) And (YY = 0)) Then
    '        MsgBox("Please enter a meaningful date!")
    '    Else
    '        JulianDate = JD
    '    End If

    'End Function


    Public Sub SetGlobalGridStyle(ByVal theGrid As System.Windows.Forms.DataGridView)
        With theGrid
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ColumnHeadersHeight = 46
            .RowHeadersWidth = 25
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
        End With
    End Sub

    Public Sub GlobalBindingNavigatorStyle(ByVal theObject As System.Windows.Forms.BindingNavigator)

        'ToolStripButtonRefresh

        'System.Windows.Forms.BindingNavigator.ToolStripAccessibleObject
        For Each mItems As Object In theObject.Items
            With mItems
                If mItems.GetType.FullName = "System.Windows.Forms.ToolStripButton" Then
                    Select Case mItems.Name
                        Case "ToolStripButtonRefresh"
                            .Text = "Aggiorna"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Case "ToolStripButtonFilter"
                            .Text = "Filtri"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Case "BindingNavigatorAddNewItem"
                            .Text = "Aggiungi"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Case "ToolStripButtonEdit"
                            .Text = "Modifica"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Case "BindingNavigatorDeleteItem"
                            .Text = "Elimina"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Case "ToolStripButtonDuplicate"
                            .Text = "Duplica"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Case "ToolStripButtonNewDetail"
                            .Text = "Dettaglio"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Case "ToolStripButtonPrint"
                            .Text = "stampa"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                        Case "ToolStripButtonFind"
                            .Text = "Cerca"
                            .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText

                        Case "BindingNavigatorCountItem"
                            .text = "di {0}" 'of {0}
                    End Select

                End If
            End With
        Next
    End Sub

End Module




