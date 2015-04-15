Imports System.Data.OleDb
Imports System.IO
Imports System.Environment
Module modCommon
    Private Declare Function BringWindowToTop Lib "user32" (ByVal _
         hwnd As Long) As Long
    Private Declare Function FindWindow Lib "user32" Alias _
       "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName _
       As String) As Long
    ' http://support2.microsoft.com/kb/186431
    Public ThumbDrive As String = ""
    Public TheDirectory As String = ""
    Public DSN As String
    Public dB As OleDbConnection
    Public TestingMode As Boolean = Debugger.IsAttached
    Public Const UseAccess2007 As Boolean = False
    Public Const AccessACCDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    Public Const AccessMDBConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
    Public dBName As String = "Food Pantry.accdb"
   

    Public Command As OleDbCommand
    Public rsWork As OleDbDataReader
    Public ApplicationDirectory As String = ""
    Public Const BackupUpIntervalDays As Integer = 1
    Public Const ItemTypeNormal As String = "Normal"
    Public Const ItemTypeSpecial As String = "Special"
    Public Const ItemTypeFresh As String = "Fresh"
    Public Const ItemTypeKidSnack As String = "Kids snack"
    Public Const ItemTypePersonalCare As String = "Personal care"
    Public Const ItemTypeHome As String = "Home"
    Public Const ItemTypeFood As String = "Food"
    Public Const ItemTypeFoodCold As String = "Cold"
    Public Const ItemTypeFoodCold2 As String = "Cold (2 only)"
    Public Const ItemTypeFoodColdSpecial As String = "Cold Special"
    'Public VisitedThisWeek As String = "VisitDate BETWEEN ## AND #" & Now.ToString("d") & " 11:59:59 PM#"
    Public VisitedThisWeekStartDate As String = "?"
    Public VisitedThisWeekEndDate As String
    'Public VisitedToday As String = "VisitDate BETWEEN ## AND #" & Now.ToString("d") & " 11:59:59 PM#"
    Public VisitedThisWeekSQL As String = "VisitDate BETWEEN ?F AND ?T"
    'Public Const UseItemGroups As Boolean = False
    'Public VisitedToday As String = "VisitDate BETWEEN #" & Now.ToString("d") & " 12:00:00 AM# AND #" & Now.ToString("d") & " 11:59:59 PM#"
    Public Structure CommandLineArguments
        Dim LeftMargin As Integer
        Dim RightMargin As Integer
        Dim TopMargin As Integer
        Dim BottomMargin As Integer
        Dim frmMainlvClientsColumn1Width As Integer
        Dim frmMainlvClientsColumn2Width As Integer
        Dim ViewFirst As Boolean
        Dim ShowSQLMenuItem As Boolean
        Dim CheckForDBUpdates As Boolean
        Dim ReportPrintPreview As Boolean
    End Structure
    Public Structure AClient
        Dim CaseNumber As Integer
        Dim Notes As String
        Dim Active As Boolean
        Dim LastName As String
        Dim FirstName As String
        Dim Address As String
        Dim Address2 As String
        Dim Town As String
        Dim Zip As String
        Dim PhoneH As String
        Dim PhoneC As String
        Dim PhoneW As String
        Dim NumberOfAdults As Integer
        Dim NumberOfChildren As Integer
        Dim NumberOfSeniors As Integer
        Dim MaleAdults As Integer
        Dim FemaleAdults As Integer
        Dim MaleChildren As Integer
        Dim FemaleChildren As Integer
        Dim MaleSeniors As Integer
        Dim FemaleSeniors As Integer

        Dim AgesOfChildren As String
        Dim DateStarted As Nullable(Of Date)
        Dim DateReOpened As Nullable(Of Date)
        Dim Homeless As Boolean
        Dim Diabetic As Boolean
        Dim Deaf As Boolean
        Dim Special As Boolean
        Dim RegistrationIsComplete As Boolean
        Dim Military As Boolean
        Dim OtherAdults As String
        Dim SNAP As Boolean
        Dim WIC As Boolean
        Dim FuelAsst As Boolean
        Dim Medicaid As Boolean
        Dim AidBlind As Boolean
        Dim CSFP As Boolean
        Dim OldAge As Boolean
        Dim TANF As Boolean
        Dim SubsHOusing As Boolean
        Dim APTD As Boolean
        Dim Welfare As Boolean
        Dim HeadStart As Boolean
        Dim IncomeEligible As Boolean
        Dim NoPork As Boolean
        Dim NoCooking As Boolean

        Dim SpecialReq As String
        Dim FoodAllergies As String






    End Structure
    Public CLA As CommandLineArguments = New CommandLineArguments
    Public Structure AnItem
        Dim ItemName As String
        Dim ItemType As String
        Dim Limit As Integer
        Dim Available As Boolean
        Dim CountForNPeople As String
    End Structure
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(2033, #1/15/2014#, 5)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(2034, #1/15/2014#, 3)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(2035, #1/15/2014#, 5)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(2036, #1/15/2014#, 5)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(2037, #1/15/2014#, 3)
    '
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(496, #11/20/2013#, 2)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(496, #11/26/2013#, 3)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(496, #12/4/2013#, 4)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(496, #12/11/2013#, 3)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(496, #12/18/2013#, 4)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(496, #12/31/2013#, 4)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(496, #1/8/2014#, 4)
    'INSERT INTO Visits (CaseNumber, VisitDate, NumberOfBags) VALUES(496, #1/15/2014#, 3)
    Function BrowseForDB(ByVal WhatToBrowseFor As String, ByVal InitialDirectory As String) As String
        Dim FileBrowseDialog As New OpenFileDialog
        Dim sWork As String = ""

        Dim fd As OpenFileDialog = New OpenFileDialog
        Dim FileName As String = ""
        fd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
        fd.Title = "DataBase"
        fd.Filter = "Access 7 database files (*.ACCDB)|*.ACCDB|Access database files (*.MDB)|*.MDB"
        fd.RestoreDirectory = True
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then sWork = fd.FileName
        Return sWork
    End Function
    Function BrowseForThumbDrive(ByVal InitialDirectory As String) As String
        Dim FileBrowseDialog As New OpenFileDialog
        Dim sWork As String = ""

        Dim fd As OpenFileDialog = New OpenFileDialog
        Dim FileName As String = ""
        fd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
        fd.Title = "ThumbDrive, just pick ANY file"
        fd.Filter = "All files (*.*)|*.*"
        fd.RestoreDirectory = True
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then sWork = fd.FileName
        Dim iWork As Integer = InStr(sWork, ":")
        sWork = Strings.Left(sWork, iWork + 1)  ' Just save "D:\"
        Return sWork
    End Function
    Sub GetDBLocation(Optional ByVal ForceIt As Boolean = False)
        Dim DefaultDirectoryLocation As String = ""
        Dim DBExists As Boolean = False
        Dim TheFileName As String = ""
        Dim sWork As String = ""
        If TestingMode Then
            DefaultDirectoryLocation = GetFolderPath(SpecialFolder.ApplicationData) & "\Food Pantry"
            ApplicationDirectory = My.Application.Info.DirectoryPath & "\"

        End If
        If Strings.Right(DefaultDirectoryLocation, 1) <> "\" Then DefaultDirectoryLocation += "\"
        TheDirectory = GetSetting("Food Pantry", "Files", "DBLocation", "")
        dBName = GetSetting("Food Pantry", "Files", "DBName", "")
        If TestingMode Then
            dBName = "Food Pantry.mdb"     ' Saint Vincents de Paul
            'dBName = "Food Pantry.accdb"    ' FootPrints
            'MsgBox("Database forced to " & dBName)
        End If
        ThumbDrive = GetSetting("Food Pantry", "Files", "ThumbDrive", "")
        If TheDirectory <> "" And dBName <> "" Then
            If File.Exists(TheDirectory & dBName) Then DBExists = True
        End If
        Dim TheCommandLine As String = LCase(System.Environment.CommandLine)
        If InStr(TheCommandLine, "getdblocation") <> 0 Or TheDirectory = "" Or dBName = "" Or ForceIt Or (Not DBExists) Then
            '
            ' We need to locate the database
            '
            'Dim Ok As Boolean = False
            While TheFileName = ""
                sWork = BrowseForDB("Select the DDB Database", DefaultDirectoryLocation)
                If sWork = "" Then
                    MsgBox("You MUST select the database")
                Else
                    TheFileName = sWork
                End If
                SaveSetting("Food Pantry", "Files", "ThumbDrive", sWork)
            End While
            ThumbDrive = BrowseForThumbDrive("")
            Dim iWork As Integer = InStrRev(TheFileName, "\")
            TheDirectory = Strings.Left(TheFileName, iWork)
            dBName = Strings.Mid(TheFileName, iWork + 1)
            SaveSetting("Food Pantry", "Files", "DBLocation", TheDirectory)
            SaveSetting("Food Pantry", "Files", "DBName", dBName)
            iWork = InStr(ThumbDrive, "\")
            SaveSetting("Food Pantry", "Files", "ThumbDrive", Strings.Left(ThumbDrive, iWork))
        End If
        If InStr(LCase(dBName), ".accdb") = 0 Then
            ' MDB file
            DSN = AccessMDBConnectionString & TheDirectory & dBName
        Else
            ' ACCDB file
            DSN = AccessACCDBConnectionString & TheDirectory & dBName
        End If



    End Sub
    Function AddAnItem(ByVal TheItem As AnItem) As String
        Dim SQL As String = "INSERT INTO Items (ItemName, ItemType, Limit, Available, CountForNPeople) VALUES("
        SQL += "'" & TheItem.ItemName & "'"
        SQL += ",'" & TheItem.ItemType & "'"
        SQL += "," & TheItem.Limit
        SQL += "," & TheItem.Available
        SQL += ",'" & TheItem.CountForNPeople & "'"
        SQL += ")"
        Dim sWork As String = ExecuteSQLCommand(SQL)
        Return sWork
    End Function
    Function AddAClient(ByVal TheClient As AClient) As String
        Dim SQL As String = ""
        Dim sWork As String = ""
        If TheClient.FirstName = "" And TheClient.LastName = "" Then
            sWork = "First and Last name blank!"
        Else
            SQL = "INSERT INTO Clients (CaseNumber, Notes, Active, FirstName, LastName, Address, Address2, Town, Zip, PhoneH, PhoneC, PhoneW, DateStarted"
            SQL += ", DateReOpened, NumberOfAdults, NumberOfChildren, NumberOfSeniors "
            SQL += ", MaleAdults, FemaleAdults, MaleChildren, FemaleChildren, MaleSeniors "
            SQL += ", FemaleSeniors, AgesOfChildren, Homeless, Diabetic, Military "
            SQL += ", UnfinishedRegistraion, Deaf, Special, DateLastUpdated"
            SQL += ", OtherAdults, SNAP, WIC, FuelAssistance"
            SQL += " , Medicaid"
            SQL += " , AidBlind"
            SQL += " , CSFP"
            SQL += " , OldAge"
            SQL += " , TANF"
            SQL += " , SubsHOusing"
            SQL += " , APTD"
            SQL += " , Welfare"
            SQL += " , HeadStart"
            SQL += " , IncomeEligible"
            SQL += " , NoPork"
            SQL += " , NoCooking"

            SQL += " , SpecialReq"
            SQL += " , FoodAllergies"

            SQL += ") VALUES("
            SQL += TheClient.CaseNumber.ToString
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.Notes)) & "'"
            SQL += ", " & TheClient.Active
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.FirstName)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.LastName)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.Address)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.Address2)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.Town)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.Zip)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.PhoneH)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.PhoneC)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.PhoneW)) & "'"
            If IsDate(TheClient.DateStarted) Then
                sWork = ", #" & Format(TheClient.DateStarted, "MM/dd/yyyy") & "#"
            Else
                sWork = ", Null"
            End If
            SQL += sWork
            If IsDate(TheClient.DateReOpened) Then
                sWork = ", #" & Format(TheClient.DateReOpened, "MM/dd/yyyy") & "#"
            Else
                sWork = ", Null"
            End If
            SQL += sWork
            SQL += ", " & TheClient.NumberOfAdults.ToString          ' Number of adults
            SQL += ", " & TheClient.NumberOfChildren.ToString         ' Number of children
            SQL += ", " & TheClient.NumberOfSeniors.ToString         ' Number of seniors
            SQL += ", " & TheClient.MaleAdults.ToString
            SQL += ", " & TheClient.Femaleadults.ToString
            SQL += ", " & TheClient.MaleChildren.ToString
            SQL += ", " & TheClient.FemaleChildren.ToString
            SQL += ", " & TheClient.MaleSeniors.ToString
            SQL += ", " & TheClient.FemaleSeniors.ToString



            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.AgesOfChildren)) & "'"              ' AgesOfChildren
            SQL += ", " & TheClient.Homeless
            SQL += ", " & TheClient.Diabetic
            SQL += ", " & TheClient.Military
            SQL += ", " & Not TheClient.RegistrationIsComplete
            SQL += ", " & TheClient.Deaf
            SQL += ", " & TheClient.Special
            SQL += ", #" & Format(Now, "MM/dd/yyyy") & "#"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.OtherAdults)) & "'"
            SQL += ", " & TheClient.SNAP
            SQL += ", " & TheClient.WIC
            SQL += ", " & TheClient.FuelAsst
            SQL += ", " & TheClient.Medicaid
            SQL += ", " & TheClient.AidBlind
            SQL += ", " & TheClient.CSFP
            SQL += ", " & TheClient.OldAge
            SQL += ", " & TheClient.TANF
            SQL += ", " & TheClient.SubsHOusing
            SQL += ", " & TheClient.APTD
            SQL += ", " & TheClient.Welfare
            SQL += ", " & TheClient.HeadStart
            SQL += ", " & TheClient.IncomeEligible
            SQL += ", " & TheClient.NoPork
            SQL += ", " & TheClient.NoCooking


            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.SpecialReq)) & "'"
            SQL += ", '" & Trim(SanitizeTextForSQL(TheClient.FoodAllergies)) & "'"


            SQL += ")"
            sWork = ExecuteSQLCommand(SQL)

        End If
        Return sWork

    End Function
    Function AnyGroupings() As Boolean
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim bWork As Boolean = False
        Dim SQL As String = "SELECT COUNT(*) As CountEm FROM Groupings"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If rsWork!CountEm > 0 Then bWork = True
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return bWork

    End Function
    Function GetItemNumberFromNameAndType(ByVal ItemName As String, ByVal ItemType As String) As Integer
        Dim iWork As Integer = 0
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = "Select ID FROM Items WHERE ItemName = '" & ItemName & "' AND ItemType = '" & ItemType & "'"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            iWork = rsWork!ID
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return iWork

    End Function
    Function GetItemNameFromItemNumber(ByVal ItemNumber As Integer) As String
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = "Select ItemName FROM Items WHERE ID = " & ItemNumber.ToString
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            sWork = rsWork!ItemName
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return sWork

    End Function
    Function IsThisItemAvailableToday(ByVal ItemNumber As Integer) As Boolean
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = "Select Available FROM Items WHERE ID = " & ItemNumber.ToString
        Dim bWork As Boolean = False
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            bWork = rsWork!Available
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return bWork

    End Function
    Function GroupNameExists(ByVal GroupName As String) As Boolean
        Dim bWork As Boolean = False
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        Dim iWork As Integer = 0
        SQL += "SELECT GroupName FROM Groupings WHERE GroupName = '" & GroupName & "'"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            bWork = True
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return bWork
    End Function
    Function ItemIsAlreadyAMemberOfAGroup(ByVal ItemName As String, ByVal ItemType As String) As Boolean
        Dim bWork As Boolean = False
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = "Select ID FROM Items WHERE ItemName = '" & ItemName & "' AND ItemType = '" & ItemType & "'"
        Dim ThisItemID As Integer = 0
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then ThisItemID = rsWork!ID
        rsWork.Close()
        Dim iWork As Integer = 0
        SQL = "SELECT Count(GroupedItems) AS CountEm FROM Groupings WHERE GroupedItems LIKE '%" & ThisItemID.ToString & vbTab & "%'"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If rsWork!CountEm <> 0 Then bWork = True
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return bWork

    End Function
    Function GetNumberOfVisitsForClient(ByVal ClientNumber As Integer) As Integer
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        Dim iWork As Integer = 0
        SQL += "SELECT COUNT(*) AS CountEm FROM Visits WHERE CaseNumber = " & ClientNumber
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If IsNumeric(rsWork!CountEm) Then
                iWork = rsWork!CountEm
            End If
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return iWork
    End Function
    Function DateLastVisited(ByVal ClientNumber As Integer) As String
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        Dim dWork As Date = Now
        SQL += "SELECT MAX(VisitDate) AS LastVisitDate FROM Visits WHERE CaseNumber = " & ClientNumber
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If Not IsDBNull(rsWork!LastVisitDate) Then
                dWork = rsWork!LastVisitDate
                sWork = Format(dWork, "MM/dd/yyyy")
            End If
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return Trim(sWork)
    End Function
    Function dBIsOpen() As Boolean
        If dB.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub DeleteASetting(ByVal TheKey As String)
        Dim SQL As String = ""
        SQL += "DELETE FROM Settings WHERE TheParameter = '" & TheKey & "'"
        ExecuteSQLCommand(SQL)
    End Sub
    Function DoesThisItemExistAsAHomelessItem(ByVal TheItem As String) As Boolean
        Dim YupOrNope As Boolean = False
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = "SELECT ID FROM Items WHERE ItemName = '" & TheItem & "' AND ItemType = 'Homeless'"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then YupOrNope = True
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return YupOrNope
    End Function
    Function DoesCaseNumberExist(ByVal CaseNumber As Integer) As Boolean
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim ItDoesExist As Boolean = False
        Dim SQL As String = ""
        SQL += "SELECT CaseNumber FROM Clients WHERE CaseNumber = " & CaseNumber.ToString
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            ItDoesExist = True
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return ItDoesExist
    End Function
    Function DoesTownExist(ByVal TownName As String) As Boolean
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim ItDoesExist As Boolean = False
        Dim SQL As String = ""
        SQL += "SELECT Town FROM ZipCodes WHERE Town = '" & TownName & "'"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            ItDoesExist = True
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return ItDoesExist

    End Function
    Function ExecuteSQLCommand(ByVal SQL As String, Optional ByVal ShowError As Boolean = False) As String
        Dim TheResult As String = ""
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Command = New OleDbCommand(SQL, dB)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            TheResult = ex.Message
            If ShowError Then MsgBox(TheResult)
        End Try
        If Not dbWasOpen Then dB.Close()
        Return TheResult
    End Function
    Function Integer2String(ByVal TheInteger As Integer, Optional ByVal NumberOfDigits As Integer = 5) As String
        Dim sWork As String = Strings.Left("000000000000000", NumberOfDigits)
        Return Format(TheInteger, sWork)
    End Function
    Sub FixHtmlPages()
        ' This Sub, only available when in Debug mode, updates the header information (including menu items) of all of the html files to match the index.html file
        Const InputFolder As String = "C:\WebSites\FootPrints\"
        Const OutputFolder As String = "C:\aaaaTemp\FootPrints\"
        Dim ArrayOfIndexHTMLBeginningInformation As ArrayList = New ArrayList
        If Not Directory.Exists(OutputFolder) Then Directory.CreateDirectory(OutputFolder)
        '
        ' First, retrieve the beginning information (including menu items) from index.html
        '
        Const HeaderDeliniator As String = "<!-- Header information - DO NOT CHANGE OR REMOVE -->"
        'Const FooterDeliniator As String = "<!-- Footer information - DO NOT CHANGE OR REMOVE -->"
        Dim objReader As New System.IO.StreamReader(InputFolder & "index.html")
        Dim TheLine As String = ""
        Dim IndexHTMLBeginningInformation As String = ""
        Do While InStr(TheLine, HeaderDeliniator) = 0 And objReader.Peek() <> -1
            TheLine = objReader.ReadLine
            IndexHTMLBeginningInformation += TheLine & vbNewLine
            ArrayOfIndexHTMLBeginningInformation.Add(TheLine)
        Loop
        objReader.Close()
        If ArrayOfIndexHTMLBeginningInformation.Count = 0 Then
            MsgBox("Whoops!  Can't find header line in index.html!")
        Else
            '
            ' Ok, now update all of the html files
            '
            Dim DirectoryInfo As New DirectoryInfo(InputFolder)
            Dim FileArray As FileInfo() = DirectoryInfo.GetFiles("*.html")
            Dim FileInformation As FileInfo
            For Each FileInformation In FileArray
                If LCase(FileInformation.Name) <> "index.html" Then
                    Dim ThisInputFileName As String = InputFolder & FileInformation.Name
                    Dim ThisOutputFileName As String = OutputFolder & FileInformation.Name
                    UpdateAnHTMLPage(ArrayOfIndexHTMLBeginningInformation, FileInformation.Name, InputFolder, OutputFolder, HeaderDeliniator)
                End If

            Next
            'UpdateAnHTMLPage(IndexHTMLBeginningInformation, "AboutUs.html", InputFolder, OutputFolder, HeaderDeliniator)
            'UpdateAnHTMLPage(IndexHTMLBeginningInformation, "Contact.html", InputFolder, OutputFolder, HeaderDeliniator)
            'UpdateAnHTMLPage(IndexHTMLBeginningInformation, "HowToHelp.html", InputFolder, OutputFolder, HeaderDeliniator)
            'UpdateAnHTMLPage(IndexHTMLBeginningInformation, "WhyHere.html", InputFolder, OutputFolder, HeaderDeliniator)
            'For Each FileInformation In FileArray
            '    If FileInformation.Name <> "index.html" Then
            '        Dim ThisInputFileName As String = InputFolder & FileInformation.Name
            '        Dim ThisOutputFileName As String = OutputFolder & FileInformation.Name

            '    End If

            'Next
        End If
        MsgBox("Done")

    End Sub
    Function GetASetting(ByVal TheKey As String, Optional ByVal DefaultValue As String = "") As String
        On Error Resume Next
        Dim dbWasOpen As Boolean = dBIsOpen()
        If Not dbWasOpen Then dB.Open()
        'MsgBox(Err.Description)
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        SQL += "SELECT TheValue FROM Settings WHERE TheParameter = '" & TheKey & "'"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            sWork = rsWork!TheValue
        Else
            sWork = DefaultValue
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return sWork
    End Function
    Function GetClientActiveOrInactiveFromNumber(ByVal ClientNumber As Integer) As Integer
        Dim TheStatus As Integer = -1   ' -1 = Not found, 0 = Not active, 1 = Active
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim TheClientName As String = GetClientNameFromNumber(ClientNumber)
        Dim SQL As String = ""
        'SQL += "SELECT Active FROM Clients WHERE CaseNumber = " & ClientNumber
        SQL = GetSQLForClientRetrieve(ClientNumber, TheClientName)
        If SQL <> "" Then
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            If rsWork.Read Then
                If Not IsDBNull(rsWork!Active) Then
                    If rsWork!Active Then TheStatus = 1 Else TheStatus = 0
                End If
            End If
            rsWork.Close() : rsWork = Nothing
            If Not dbWasOpen Then dB.Close()

        End If
        Return Trim(TheStatus)

    End Function
    Function GetClientNameFromNumber(ByVal ClientNumber As Integer, Optional ByVal LastNameFirstName As Boolean = False) As String
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        If ClientNumber <> 0 Then
            SQL = "SELECT FirstName, LastName FROM Clients WHERE CaseNumber = " & ClientNumber
            Dim sWork As String = ""
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            If rsWork.Read Then
                If LastNameFirstName Then
                    sWork = rsWork!LastName & ", " & rsWork!FirstName
                Else
                    sWork = rsWork!FirstName & " " & rsWork!LastName
                End If
            End If
            rsWork.Close() : rsWork = Nothing
            If Not dbWasOpen Then dB.Close()
            Return Trim(sWork)
        Else
            Dim FirstName As String = ""
            Dim LastName As String = ""
            FirstNameLastNameFromClientName(frmMain.SelectedClientName, FirstName, LastName)
            If LastNameFirstName Then
                Return LastName & ", " & FirstName
            Else
                Return FirstName & " " & LastName
            End If
        End If
    End Function
    Sub GetCommandLineArguments()
        Dim Arguments() As String = Environment.GetCommandLineArgs()
        CLA.BottomMargin = -1
        CLA.LeftMargin = -1
        CLA.RightMargin = -1
        CLA.TopMargin = -1
        CLA.frmMainlvClientsColumn1Width = -1
        CLA.frmMainlvClientsColumn2Width = -1
        CLA.ViewFirst = False
        CLA.ShowSQLMenuItem = False
        CLA.CheckForDBUpdates = False
        CLA.ReportPrintPreview = False
        If UBound(Arguments) > 0 Then
            For iWork As Integer = 1 To UBound(Arguments)
                ' T=1 B=2 L=3 R=4
                Dim sWork As String = Arguments(iWork)
                Select Case Strings.Left(sWork.ToUpper, 1)
                    Case "T" : CLA.TopMargin = Val(Strings.Mid(sWork, 3))
                    Case "B" : CLA.BottomMargin = Val(Strings.Mid(sWork, 3))
                    Case "L" : CLA.LeftMargin = Val(Strings.Mid(sWork, 3))
                    Case "R" : CLA.RightMargin = Val(Strings.Mid(sWork, 3))
                        'Case "S" : mnuFileSQL.Visible = True
                    Case "V" : CLA.ViewFirst = True
                    Case "1" : CLA.frmMainlvClientsColumn1Width = Val(Strings.Mid(sWork, 3))
                    Case "2" : CLA.frmMainlvClientsColumn2Width = Val(Strings.Mid(sWork, 3))
                    Case "C" : CLA.CheckForDBUpdates = True
                    Case "Q" : CLA.ShowSQLMenuItem = True
                    Case "P" : CLA.ReportPrintPreview = True
                End Select
            Next

        End If
    End Sub
    Function GetNumberOfClientsForTown(ByVal TheTown As String) As Integer
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim iWork As Integer = 0
        Dim SQL As String = "SELECT COUNT(*) AS CountEm FROM Clients WHERE Town = '" & TheTown & "'"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            iWork = rsWork!CountEm
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return iWork

    End Function
    Function GetNextGroupingNumber() As Integer
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim iWork As Integer = 0
        Dim SQL As String = "SELECT MAX GroupID FROM Groupings"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            iWork = rsWork!GroupID + 1
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return iWork
    End Function
    Function GetNumberOfVisitsToday() As Integer
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim NumberToday As Integer = 0
        Dim SQL As String = ""
        'SQL += "SELECT COUNT(*) As CountEm FROM Visits WHERE VisitDate = #" & Format(Now, "MM/dd/yyyy") & "#"
        SQL = "SELECT Count(*) AS CountEm FROM Visits WHERE " & VisitedThisWeekSQL ' VisitDate BETWEEN #" & Now.ToString("d") & " 12:00:00 AM# AND #" & Now.ToString("d") & " 11:59:59 PM#"
        ' SELECT * FROM Visits WHERE VisitDate BETWEEN #5/7/2014 12:00:01 AM# AND #5/7/2014 11:59:59 PM#
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If Not IsDBNull(rsWork!CountEm) Then
                NumberToday = rsWork!CountEm
            End If
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return NumberToday
    End Function
    Function GetNumberOfDeliveriesToday() As Integer
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim NumberToday As Integer = 0
        Dim SQL As String = "SELECT COUNT (*) AS CountEm FROM Visits WHERE Delivery = True AND " ' VisitDate = #" & VisitDate & "#"
        SQL += VisitedThisWeekSQL
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If Not IsDBNull(rsWork!CountEm) Then
                NumberToday = rsWork!CountEm
            End If
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return NumberToday
    End Function
    Function GetZipCodeForTown(ByVal TheTown As String) As String
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        SQL += "SELECT ZipCode FROM ZipCodes WHERE Town = '" & TheTown & "'"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then sWork = Strings.Right("00000" & rsWork!ZipCode, 5) ' rsWork!ZipCode
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return Trim(sWork)
    End Function
    Function GetLastVisitDateForClient(ByVal ClientNumber As String, ByVal ClientName As String, Optional ByVal AllowToday As Boolean = False) As String
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        SQL = GetSQLForClientRetrieve(ClientNumber, ClientName)
        SQL = Replace(SQL, "CaseNumber", "Clients.CaseNumber")  ' Make CaseNumber table specific for JOIN
        Dim iWork As Integer = InStr(SQL, "WHERE")
        SQL = "SELECT Max(VisitDate) AS LastDate FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber " & Mid(SQL, iWork)
        If Not AllowToday Then SQL += " AND VisitDate <> #" & Format(Now, "MM/dd/yyyy") & "#"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If Not IsDBNull(rsWork!LastDate) AndAlso IsDate(rsWork!LastDate) Then
                sWork = rsWork!LastDate
            End If
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return Trim(sWork)
    End Function
    Function GetLastVisitDate() As Date
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        SQL += "SELECT MAX(VisitDate) AS LastDate FROM Visits"
        Dim dWork As Date = Now
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If Not IsDBNull(rsWork!LastDate) Then
                dWork = rsWork!LastDate
            End If
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return dWork
    End Function
    Sub FirstNameLastNameFromClientName(ByVal ClientName As String, ByRef FirstName As String, ByRef LastName As String)
        If ClientName = "" Then
            FirstName = ""
            LastName = ""
        Else
            Dim iWork As Integer = InStrRev(ClientName, ",")
            If iWork = 0 Then
                iWork = InStr(ClientName, " ")
                If iWork <> 0 Then
                    LastName = Trim(Mid(ClientName, iWork + 1))
                    FirstName = Trim(Strings.Left(ClientName, iWork - 1))
                Else
                    FirstName = ClientName
                    LastName = ""
                End If
            Else
                If Strings.Trim(Strings.Left(ClientName, iWork - 1)) <> "" Then
                    LastName = Trim(Replace(Strings.Left(ClientName, iWork - 1), ",", ""))
                    FirstName = Trim(Strings.Mid(ClientName, iWork + 1))
                Else
                    FirstName = Trim(Mid(ClientName, iWork + 1))
                    LastName = ""
                End If

            End If
            FirstName = SanitizeTextForSQL(FirstName)
            LastName = SanitizeTextForSQL(LastName)
        End If
    End Sub
    Function GetSQLForClientRetrieve(ByVal ClientNumber As String, ByVal ClientName As String) As String
        Dim SQL As String = ""
        Dim FoundAName As Boolean = False
        If Val(ClientNumber) = 0 Then
            If ClientName <> "" Then
                ' There are multiple clients who's client number is 0, so use their name.
                Dim FirstName As String = ""
                Dim LastName As String = ""
                FirstNameLastNameFromClientName(ClientName, FirstName, LastName)
                'Dim iWork As Integer = InStrRev(ClientName, ",")
                'If iWork = 0 Then
                '    iWork = InStr(ClientName, " ")
                '    If iWork <> 0 Then
                '        LastName = Trim(Mid(ClientName, iWork + 1))
                '        FirstName = Trim(Strings.Left(ClientName, iWork - 1))
                '    Else
                '        FirstName = ClientName
                '        LastName = ""
                '    End If
                'Else
                '    If Strings.Trim(Strings.Left(ClientName, iWork - 1)) <> "" Then
                '        LastName = Trim(Replace(Strings.Left(ClientName, iWork - 1), ",", ""))
                '        FirstName = Trim(Strings.Mid(ClientName, iWork + 1))
                '    Else
                '        FirstName = Trim(Mid(ClientName, iWork + 1))
                '        LastName = ""
                '    End If

                'End If
                SQL = "SELECT * FROM Clients WHERE "
                If FirstName <> "" Then
                    SQL += "FirstName = '" & FirstName & "'"
                    FoundAName = True
                End If
                If LastName <> "" Then
                    If FoundAName Then SQL += " AND "
                    SQL += "LastName = '" & LastName & "'"
                    FoundAName = True
                End If
                If FoundAName Then
                    SQL += " AND CaseNumber = 0"
                Else
                    SQL = ""
                End If
            Else
                ' No client number, and no client name!

            End If
        Else
            ' Use the client number
            SQL = "SELECT * FROM Clients WHERE CaseNumber = " & ClientNumber
        End If
        Return SQL
    End Function
    Function IsThisClientAReOpen(ByVal ClientNumber As Integer, ByVal ClientName As String) As Boolean
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim TheyWereInactive As Boolean = False
        Dim ThisClientsLastVisitDate As String = GetLastVisitDateForClient(ClientNumber, ClientName)
        'If TestingMode And ClientNumber = 79 Then ThisClientsLastVisitDate = "01/01/2013"
        If IsDate(ThisClientsLastVisitDate) Then
            ' See if their last visit date was x months ago
            Dim InactiveToActiveMonths As Integer = Val(GetASetting("InactiveToActiveMonths", "3"))
            Dim MonthsSinceLastVisit As Integer = DateDiff(DateInterval.Month, CDate(ThisClientsLastVisitDate), Now)
            If MonthsSinceLastVisit >= InactiveToActiveMonths Then TheyWereInactive = True
        End If
        If Not dbWasOpen Then dB.Close()
        Return TheyWereInactive
    End Function
    Sub LoadTownComboBox(ByRef cmbTown As ComboBox)
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim SQL As String = ""
        SQL = "SELECT DISTINCT Town FROM ZipCodes WHERE Town <> '' ORDER BY Town"
        'SQL = "SELECT DISTINCT Town FROM Clients WHERE Town <> '' ORDER BY Town"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        cmbTown.Items.Clear()
        While rsWork.Read
            cmbTown.Items.Add(rsWork!Town)
        End While
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
    End Sub
    Function NextID(ByVal TableName As String, ByVal IDField As String) As Integer
        Dim iWork As Integer
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = "SELECT MAX(" & IDField & ") AS HighestID FROM " & TableName
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            If Not IsDBNull(rsWork!HighestID) Then
                iWork = rsWork!HighestID + 1
            Else
                iWork = 0
            End If
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return iWork
    End Function
    Function N2Z(ByVal TheNumber As Object) As Integer
        If IsDBNull(TheNumber) Then
            Return 0
        Else
            Return TheNumber
        End If
    End Function
    Sub LoadAnItemComboBox(ByVal TheComboBox As ComboBox, ByVal LoadLimitOfxItems As Boolean)
        If GetASetting("FootPrints") <> "True" Then
            ' Must be St. Vincents.
            TheComboBox.Items.Clear()
            TheComboBox.Items.Add(GetASetting("LabelForFoodBox", "Food"))
            TheComboBox.Items.Add(GetASetting("LabelForHomeBox", "Home"))
            TheComboBox.Items.Add(GetASetting("LabelForColdBox", "Cold"))
            TheComboBox.Items.Add(GetASetting("LabelForColdSpecialsBox", "Cold specials"))
            'If LoadLimitOfxItems Then
            TheComboBox.Items.Add(GetASetting("LabelForLimitOf3Items", "Limit of 3 items"))
            TheComboBox.Items.Add(GetASetting("LabelForLimitOf4ItemsBox", "Limit of 4 items"))
            'End If
            TheComboBox.Items.Add(GetASetting("LabelForFreshBox", "Fresh"))
            TheComboBox.Items.Add(GetASetting("LabelForSpecialsBox", "Specials"))
            'TheComboBox.Items.Add("Homeless")
            TheComboBox.Items.Add(GetASetting("LabelForColdPickOnly2Box", "Cold(2 only)"))
            TheComboBox.Items.Add(GetASetting("LabelForOtherItemsBox", "Other items"))
            'TheComboBox.Items.Add(GetASetting("LabelForOtherItemsBox", "USDA Frozen"))
            ' Baked Goods
            ' USDA Frozen

        End If
    End Sub
    Public Sub SaveASetting(ByVal TheKey As String, ByVal TheValue As String)
        ' If the setting already exists, delete it.
        DeleteASetting(TheKey)
        Dim SQL As String = "INSERT INTO Settings (TheParameter, TheValue) VALUES( "
        SQL += "'" & TheKey & "'"
        SQL += ", '" & SanitizeTextForSQL(TheValue) & "')"
        ExecuteSQLCommand(SQL)
    End Sub
    Function SanitizeTextForSQL(ByVal TheText As String) As String
        Dim sWork As String = Replace(TheText, """", "'")
        sWork = Replace(sWork, "'", "''")
        Return sWork
    End Function
    Function StripLeadingStuff(ByVal TheItem As String) As String
        Dim sWork As String = Trim(TheItem)
        If sWork <> "" Then
            Dim iWork As Integer = 0
            ' Remove any leading periods
            Do While Strings.Left(sWork, 1) = "."
                sWork = Strings.Mid(sWork, 2)
            Loop
            ' Remove any leading digits
            For iWork = 1 To Len(sWork)
                If IsNumeric(Strings.Mid(sWork, 1, 1)) Then
                    sWork = Strings.Mid(sWork, 2)
                Else
                    Exit For
                End If
            Next
        End If
        Return sWork
    End Function
    Sub UpdateAnHTMLPage(ByVal TheHeaderText As ArrayList, ByVal TheHTMLFileName As String, ByVal InputFolder As String, ByVal OutputFolder As String, ByVal HeaderDeliniator As String)
        ' TheHTMLFile = "AboutUs.html"
        If File.Exists(OutputFolder & TheHTMLFileName) Then File.Delete(OutputFolder & TheHTMLFileName)
        '
        ' First, write the header information
        '
        Dim objWriter As New System.IO.StreamWriter(OutputFolder & TheHTMLFileName, False)
        For ThisHeaderLine As Integer = 0 To TheHeaderText.Count - 1
            objWriter.WriteLine(TheHeaderText(ThisHeaderLine))
        Next
        '
        ' Now, find the header marker in the input file
        '
        Dim objReader As New System.IO.StreamReader(InputFolder & TheHTMLFileName)
        Dim TheLine As String = ""
        Do While InStr(TheLine, HeaderDeliniator) = 0 And objReader.Peek() <> -1
            TheLine = objReader.ReadLine
        Loop
        '
        ' Now, line by line, copy the (rest of the) input file to the output file
        '
        Do While objReader.Peek() <> -1
            TheLine = objReader.ReadLine
            objWriter.WriteLine(TheLine)
        Loop
        objWriter.Close()
        objReader.Close()
    End Sub
    Sub UpdateAnItem(ByVal PreviousItemName As String, ByVal PreviousItemType As String, ByVal TheItem As AnItem)
        Dim UpdateSQL As String = ""
        Dim sWork As String = ""
        UpdateSQL = "ItemName = '" & SanitizeTextForSQL(TheItem.ItemName) & "'"
        UpdateSQL += ", ItemType = '" & SanitizeTextForSQL(TheItem.ItemType) & "'"
        UpdateSQL += ", Limit = " & TheItem.Limit
        UpdateSQL += ", Available = " & TheItem.Available
        UpdateSQL += ", CountForNPeople = '" & TheItem.CountForNPeople & "'"
        Dim SQL As String = "UPDATE Items SET " & UpdateSQL & " WHERE ItemName = '" & SanitizeTextForSQL(PreviousItemName) & "' AND ItemType = '" & SanitizeTextForSQL(PreviousItemType) & "'"
        ExecuteSQLCommand(SQL)

    End Sub
    Sub UpdateAClient(ByVal TheClient As AClient, Optional ByVal UpdateDateLastUpdated As Boolean = True)
        Dim UpdateSQL As String = ""
        Dim sWork As String = ""
        UpdateSQL = "Active = " & TheClient.Active
        UpdateSQL += ", CaseNumber = " & TheClient.CaseNumber.ToString
        UpdateSQL += ", Notes = '" & Trim(SanitizeTextForSQL(TheClient.Notes)) & "'"
        UpdateSQL += ", FirstName = '" & Trim(SanitizeTextForSQL(TheClient.FirstName)) & "'"
        UpdateSQL += ", LastName = '" & Trim(SanitizeTextForSQL(TheClient.LastName)) & "'"
        UpdateSQL += ", Address = '" & Trim(SanitizeTextForSQL(TheClient.Address)) & "'"
        UpdateSQL += ", Address2 = '" & Trim(SanitizeTextForSQL(TheClient.Address2)) & "'"
        UpdateSQL += ", Town = '" & Trim(SanitizeTextForSQL(TheClient.Town)) & "'"
        UpdateSQL += ", Zip = '" & Trim(SanitizeTextForSQL(TheClient.Zip)) & "'"
        UpdateSQL += ", PhoneH = '" & Trim(SanitizeTextForSQL(TheClient.PhoneH)) & "'"
        UpdateSQL += ", PhoneC = '" & Trim(SanitizeTextForSQL(TheClient.PhoneC)) & "'"
        UpdateSQL += ", PhoneW = '" & Trim(SanitizeTextForSQL(TheClient.PhoneW)) & "'"
        UpdateSQL += ", NumberOfAdults = " & TheClient.NumberOfAdults.ToString
        UpdateSQL += ", NumberOfChildren = " & TheClient.NumberOfChildren.ToString
        UpdateSQL += ", NumberOfSeniors = " & TheClient.NumberOfSeniors.ToString



        UpdateSQL += ", MaleAdults = " & TheClient.MaleAdults.ToString
        UpdateSQL += ", FemaleAdults = " & TheClient.Femaleadults.ToString
        UpdateSQL += ", MaleChildren = " & TheClient.MaleChildren.ToString
        UpdateSQL += ", FemaleChildren = " & TheClient.FemaleChildren.ToString
        UpdateSQL += ", MaleSeniors = " & TheClient.MaleSeniors.ToString
        UpdateSQL += ", FemaleSeniors = " & TheClient.FemaleSeniors.ToString




        UpdateSQL += ", AgesOfChildren = '" & Trim(SanitizeTextForSQL(TheClient.AgesOfChildren)) & "'"
        UpdateSQL += ", Homeless = " & TheClient.Homeless
        UpdateSQL += ", Diabetic = " & TheClient.Diabetic
        UpdateSQL += ", UnfinishedRegistraion = " & Not TheClient.RegistrationIsComplete
        UpdateSQL += ", Deaf = " & TheClient.Deaf
        UpdateSQL += ", Special = " & TheClient.Special
        UpdateSQL += ", Military = " & TheClient.Military
        UpdateSQL += ", OtherAdults = '" & Trim(SanitizeTextForSQL(TheClient.OtherAdults)) & "'"
        UpdateSQL += ", SNAP = " & TheClient.SNAP
        UpdateSQL += ", WIC = " & TheClient.WIC
        UpdateSQL += ", FuelAssistance  = " & TheClient.FuelAsst
        UpdateSQL += ", Medicaid = " & TheClient.Medicaid
        UpdateSQL += ", AidBlind = " & TheClient.AidBlind
        UpdateSQL += ", CSFP = " & TheClient.CSFP
        UpdateSQL += ", OldAge = " & TheClient.OldAge
        UpdateSQL += ", TANF = " & TheClient.TANF
        UpdateSQL += ", SubsHOusing = " & TheClient.SubsHOusing
        UpdateSQL += ", APTD = " & TheClient.APTD
        UpdateSQL += ", Welfare = " & TheClient.Welfare
        UpdateSQL += ", HeadStart = " & TheClient.HeadStart
        UpdateSQL += ", IncomeEligible = " & TheClient.IncomeEligible
        UpdateSQL += ", NoPork = " & TheClient.NoPork
        UpdateSQL += ", NoCooking = " & TheClient.NoCooking

        UpdateSQL += ", SpecialReq = '" & Trim(SanitizeTextForSQL(TheClient.SpecialReq)) & "'"
        UpdateSQL += ", FoodAllergies = '" & Trim(SanitizeTextForSQL(TheClient.FoodAllergies)) & "'"

        If UpdateDateLastUpdated Then UpdateSQL += ", DateLastUpdated = #" & Format(Now, "MM/dd/yyyy") & "#"
        Dim SQL As String = "UPDATE Clients SET " & UpdateSQL & " WHERE "
        If frmMain.SelectedClientNumber = 0 Then
            SQL += "LastName = '" & SanitizeTextForSQL(TheClient.LastName) & "'"
            SQL += " AND FirstName = '" & SanitizeTextForSQL(TheClient.FirstName) & "'"
        Else
            SQL += "CaseNumber = " & frmMain.SelectedClientNumber   ' Don't use TheClient.CaseNumber 'cause they might be changing the number!
        End If


        'Clipboard.Clear()    '3/22/15 DJH causing error in production I think
        'Clipboard.SetText(SQL)



        ExecuteSQLCommand(SQL)


    End Sub
    Function LastVisitADelivery(ByVal ClientNumber As Integer, ByVal ClientName As String) As Boolean
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        Dim bWork As Boolean = False
        SQL = GetSQLForClientRetrieve(ClientNumber, ClientName)
        SQL = Replace(SQL, "CaseNumber", "Clients.CaseNumber")  ' Make CaseNumber table specific for JOIN
        Dim iWork As Integer = InStr(SQL, "WHERE")
        SQL = "SELECT VisitDate AS LastDate, Delivery FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber " & Mid(SQL, iWork)
        SQL += " ORDER BY VisitDate DESC"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            bWork = rsWork!Delivery
        End If
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
        Return bWork
    End Function
    Function MakeUpperLowerCase(ByVal TheText As String) As String
        Dim iWork As Integer, iWork2 As Integer
        'Dim sWork As String
        Dim TheName As String
        'TheText = "O 'CALLAGHAN"
        'TheText = "LEIGH-WILLIAMS"
        'TheText = "McCarthy"
        'TheText = "Mc Carthy"
        'TheText = "St.John"
        'TheText = "St. John"
        'TheText = "Von John"
        'TheText = "Van John"
        TheName = UCase$(Left$(TheText, 1)) & LCase$(Mid$(TheText, 2))
        '
        '    LEIGH-WILLIAMS     Leigh-Williams
        '
        iWork = InStr(TheName, "-")
        If iWork <> 0 Then
            ' Find the first non-blank
            For iWork2 = iWork + 1 To Len(TheName)
                If Mid$(TheName, iWork2, 1) <> " " Then Exit For
            Next
            Mid$(TheName, iWork2, 1) = UCase$(Mid$(TheName, iWork2, 1))

        End If
        '
        '    McCarthy           McCarthy
        '
        If Left$(TheName, 2) = "Mc" Then
            iWork = InStr(TheName, " ")
            If iWork <> 0 Then
                ' Find the first non-blank
                For iWork2 = iWork + 1 To Len(TheName)
                    If Mid$(TheName, iWork2, 1) <> " " Then Exit For
                Next
                Mid$(TheName, iWork2, 1) = UCase$(Mid$(TheName, iWork2, 1))
            Else
                Mid$(TheName, 3, 1) = UCase$(Mid$(TheName, 3, 1))
            End If
        End If
        '
        '    O 'CALLAGHAN       O'Callaghan
        '
        If InStr(TheName, "'") <> 0 Then
            TheName = Replace$(TheName, " ", "")
            iWork = InStr(TheName, "'")
            ' Find the first non-blank
            For iWork2 = iWork + 1 To Len(TheName)
                If Mid$(TheName, iWork2, 1) <> " " Then Exit For
            Next
            Mid$(TheName, iWork2, 1) = UCase$(Mid$(TheName, iWork2, 1))
        End If
        '
        '    St.John            St.John
        '
        If Left$(TheName, 2) = "St" And InStr(TheName, ".") <> 0 Then
            iWork = InStr(TheName, ".")
            ' Find the first non-blank
            For iWork2 = iWork + 1 To Len(TheName)
                If Mid$(TheName, iWork2, 1) <> " " Then Exit For
            Next
            Mid$(TheName, iWork2, 1) = UCase$(Mid$(TheName, iWork2, 1))
        End If
        '
        '    VON STREIT         von Streit
        '
        If Left$(TheName, 4) = "Von " Or Left$(TheName, 4) = "Van " Then
            Mid$(TheName, 5, 1) = UCase$(Mid$(TheName, 5, 1))
        End If

        Return TheName
        '    AP LLWYD DAFYDD    ap Llwyd Dafydd
        'MacArthur
        'McGavley
        'McGrath
        'McGraw
        'McNeil
        'MacDonald
        'De Guzman
        'De Jong
        'DellRosso
        'DeScenza
        'DiGirolamo
        'DiPietro
        'LaRose
        'LaRouche
    End Function
End Module
