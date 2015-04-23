Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Imports System.IO
Imports System.Globalization
Imports System.Data.SqlClient

Public Class frmMain

    Dim Loading As Boolean = True
    Dim Changed As Boolean = False
    Dim Updating As Boolean = False
    Dim SortByClientNumber As Boolean = True
    Dim ErrorMessage As String = ""
    Public PrintSample As Boolean = False
    Dim TheClient As AClient = New AClient
    Public SelectedClientNumber As String = ""
    Public SelectedClientName As String = ""
    Public SelectedClientLastVisitDate As String = ""
    Public PrintFacLessSelections As Boolean = False
    Dim Testing As Boolean = False
    Dim ConvertCases As Boolean = False
    Dim UpdateButton As Boolean = False
    Dim VisitID As Integer

    Public ThisVisitID As Integer = 0  ' Helmar 3/27/15


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TestingMode = False
        GetCommandLineArguments()

        SetTodayDate()   ' Set the VisitedToday varible to end with TODAY, but start with the previous Wednesday.
        GetDBLocation()
        If TestingMode Then
            'chkPrintIt.Visible = True
            btnTest.Visible = True
            mnuFileImport.Visible = True
            mnuFileSQL.Visible = True
            mnuFileFixhtmlPages.Visible = True
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.WindowState = FormWindowState.Normal
        Else
            btnTest.Visible = False
            mnuFileImport.Visible = False
            mnuFileSQL.Visible = CLA.ShowSQLMenuItem
            mnuFileFixhtmlPages.Visible = False
            Me.WindowState = FormWindowState.Maximized
        End If
        Dim Column1Width As Integer = 125
        Dim Column2Width As Integer = 250
        If CLA.frmMainlvClientsColumn1Width <> -1 Then Column1Width = CLA.frmMainlvClientsColumn1Width
        If CLA.frmMainlvClientsColumn2Width <> -1 Then Column2Width = CLA.frmMainlvClientsColumn2Width
        lvClients.Columns.Add("Client", Column1Width, HorizontalAlignment.Left)
        lvClients.Columns.Add("Name", Column2Width, HorizontalAlignment.Left)
        If Not File.Exists(TheDirectory & dBName) Then
            MsgBox("The database '" & TheDirectory & dBName & "' is missing!")
            Me.Close()
        End If
        dB = New OleDb.OleDbConnection(DSN)



        'CLA.CheckForDBUpdates = True
        If CLA.CheckForDBUpdates Then CheckForDBMaintenance()
        If Not TestingMode Then BackupTheDB(False)
        If GetASetting("SpecialProcessingDone", "") = "" Then
            ' Allow the special processing button
            btnSpecial.Visible = True
        End If
        ' Set active clients who haven't visited in a while to inactive.
        SetActiveClientsWhoHaventVisitedToInactive()
        ' Finish up
        Loading = True
        LoadTownComboBox(cmbTown)
        LoadList()
        LoadComboBoxes()
        Loading = False
        SetVisForOrganization()
        SetVis()


        Dim VisitDate As String = GetASetting("VisitDate", "")
        If VisitDate <> "" Then
            SaveASetting("VisitDate", "")
            MsgBox("Date to use when a recording visits has been reset to 'Today'")
        End If

        'Dim sWork As String = GetASetting("TrimNames")
        'If sWork = "" Then
        '    TrimNames()
        '    SaveASetting("TrimNames", True)
        'End If
        If GetASetting("AutoULCase", "False") = "True" Then ConvertCases = True Else ConvertCases = False
        If GetASetting("TrackMilitary", "False") = "False" Then chkMilitary.Visible = False Else chkMilitary.Visible = True
        ShowVisitsToday()
        ShowDeliveriesToday()
        txtSearchClientNumber.Focus()
        Me.Text = "Week start day is " & GetASetting("WeekStartDay", "Wednesday") & ", Version: " & System.Windows.Forms.Application.ProductVersion
        ' 1.0.0.7
        ' Not tested enough, I think it causes an error......
        'If Not TestingMode And GetASetting("CurrentVersionChanges", "") <> System.Windows.Forms.Application.ProductVersion Then
        '    frmChanges.ShowDialog()
        '    frmChanges = Nothing
        '    frmChanges.Dispose()
        'End If

        'If TestingMode Then
        '    frmGroupItems.ShowDialog()
        '    frmGroupItems = Nothing
        '    frmGroupItems.Dispose()
        'End If

    End Sub
    Sub SetVisForOrganization()
        Dim sWork As String = ""
        Dim bFootPrints As Boolean = True
        sWork = GetASetting("FootPrints", "True")
        'If Debugger.IsAttached Then sWork = "False"
        If sWork = True Then
            ' FootPrints
            grpOtherAdults.Visible = False
            chkSNAP.Visible = False
            chkWIC.Visible = False
        Else
            ' NOT FootPrints
            grpOtherAdults.Visible = True
            chkSNAP.Visible = True
            chkWIC.Visible = True
        End If
        '        If sWork = "True" Then grpOtherAdults.Visible = False Else grpOtherAdults.Visible = True
    End Sub
    Sub SetTodayDate()
        '
        ' Create the WHERE portion of a SQL clause into VisitedThisWeekSQL to select the weeks worth of visits.
        ' The week starts at GetASetting("WeekStartDay", "Wednesday") and lasts 7 days. 
        '
        Dim WeekStartDayOfTheWeek As String = GetASetting("WeekStartDay", "Wednesday")
        Dim TodaysDate As Date = Now
        TodaysDate = Now ' DateAdd(DateInterval.Day, -1, Now)
        If WeekStartDayOfTheWeek = "" Then WeekStartDayOfTheWeek = "Wednesday"
        Dim TodayDayOfWeek As String = Format(TodaysDate, "dddd")
        Dim AdjustDays As Integer
        Dim WeekStart0 As String = WeekStartDayOfTheWeek


        Select Case WeekStartDayOfTheWeek
            Case "Wednesday"
                Select Case TodayDayOfWeek
                    Case "Wednesday" : AdjustDays = 0
                    Case "Thursday" : AdjustDays = 1
                    Case "Friday" : AdjustDays = 2
                    Case "Saturday" : AdjustDays = 3
                    Case "Sunday" : AdjustDays = 4
                    Case "Monday" : AdjustDays = 5
                    Case "Tuesday" : AdjustDays = 6
                End Select
            Case "Thursday"
                Select Case TodayDayOfWeek
                    Case "Wednesday" : AdjustDays = 6
                    Case "Thursday" : AdjustDays = 0
                    Case "Friday" : AdjustDays = 1
                    Case "Saturday" : AdjustDays = 2
                    Case "Sunday" : AdjustDays = 3
                    Case "Monday" : AdjustDays = 4
                    Case "Tuesday" : AdjustDays = 5
                End Select
            Case "Friday"
                Select Case TodayDayOfWeek
                    Case "Wednesday" : AdjustDays = 5
                    Case "Thursday" : AdjustDays = 6
                    Case "Friday" : AdjustDays = 0
                    Case "Saturday" : AdjustDays = 1
                    Case "Sunday" : AdjustDays = 2
                    Case "Monday" : AdjustDays = 3
                    Case "Tuesday" : AdjustDays = 4
                End Select
            Case "Saturday"
                Select Case TodayDayOfWeek
                    Case "Wednesday" : AdjustDays = 4
                    Case "Thursday" : AdjustDays = 5
                    Case "Friday" : AdjustDays = 6
                    Case "Saturday" : AdjustDays = 0
                    Case "Sunday" : AdjustDays = 1
                    Case "Monday" : AdjustDays = 2
                    Case "Tuesday" : AdjustDays = 3
                End Select
            Case "Sunday"
                Select Case TodayDayOfWeek
                    Case "Wednesday" : AdjustDays = 3
                    Case "Thursday" : AdjustDays = 4
                    Case "Friday" : AdjustDays = 5
                    Case "Saturday" : AdjustDays = 6
                    Case "Sunday" : AdjustDays = 0
                    Case "Monday" : AdjustDays = 1
                    Case "Tuesday" : AdjustDays = 2
                End Select
            Case "Monday"
                Select Case TodayDayOfWeek
                    Case "Wednesday" : AdjustDays = 2
                    Case "Thursday" : AdjustDays = 3
                    Case "Friday" : AdjustDays = 4
                    Case "Saturday" : AdjustDays = 5
                    Case "Sunday" : AdjustDays = 6
                    Case "Monday" : AdjustDays = 0
                    Case "Tuesday" : AdjustDays = 1
                End Select
            Case "Tuesday"
                Select Case TodayDayOfWeek
                    Case "Wednesday" : AdjustDays = 1
                    Case "Thursday" : AdjustDays = 2
                    Case "Friday" : AdjustDays = 3
                    Case "Saturday" : AdjustDays = 4
                    Case "Sunday" : AdjustDays = 5
                    Case "Monday" : AdjustDays = 6
                    Case "Tuesday" : AdjustDays = 0
                End Select

        End Select

        Dim dWork As Date = DateAdd(DateInterval.Day, -AdjustDays, Now)

        'VisitedThisWeekStartDate = Format(dWork, "MM/dd/yyyy") & " 12:00:00 AM"
        VisitedThisWeekStartDate = Format(Now, "MM/dd/yyyy") & " 12:00:00 AM"   ' 2/13/15 DJH changed to current date
        VisitedThisWeekEndDate = Format(Now, "MM/dd/yyyy") & " 11:59:59 PM"

        VisitedThisWeekSQL = Replace(VisitedThisWeekSQL, "?F", "#" & VisitedThisWeekStartDate & "#")
        VisitedThisWeekSQL = Replace(VisitedThisWeekSQL, "?T", "#" & VisitedThisWeekEndDate & "#")
        'VisitedThisWeekSQL = Replace(VisitedThisWeekSQL, "?T", "#" & Format(Now, "MM/dd/yyyy") & " 11:59:59 PM" & "#")
    End Sub
    Sub SetActiveClientsWhoHaventVisitedToInactive()
        ' This sub is only called at startup, and only does anything
        ' If the "After this many months with no visits, set them to inactive" setting isn't 0.
        '
        ' So, if a person is added, and then a visit is recorded, all is well, and they won't be made inactive.
        '
        Dim NumberOfClientsMadeInactive As Integer = 0
        Dim ClientsMadeInactive As String = ""
        Dim NumberOfMonthsOfNoVisitsBeforeTheyreMadeInactive As Integer = Val(GetASetting("MonthsToInactive", "0"))
        If NumberOfMonthsOfNoVisitsBeforeTheyreMadeInactive > 0 Then
            Dim InActivateThem As Boolean = False
            dB.Open()
            Dim SQL As String = "SELECT CaseNumber FROM Clients WHERE CaseNumber <> 0 and Active = True"
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            While rsWork.Read
                'If TestingMode And rsWork!CaseNumber = 191 Then Stop
                Dim DateOfLastVisit As String = DateLastVisited(rsWork!CaseNumber)
                If DateOfLastVisit <> "" Then
                    ' They've visited at least once.
                    Dim NumberOfMonthsSinceLastVisit As Integer = DateDiff(DateInterval.Month, CDate(DateOfLastVisit), Now) - 1
                    If NumberOfMonthsSinceLastVisit > NumberOfMonthsOfNoVisitsBeforeTheyreMadeInactive Then
                        ' Ok, make them inactive.
                        ExecuteSQLCommand("UPDATE Clients SET Active = False WHERE CaseNumber = " & rsWork!CaseNumber)
                        NumberOfClientsMadeInactive += 1
                        If ClientsMadeInactive <> "" Then ClientsMadeInactive += ", "
                        ClientsMadeInactive += rsWork!CaseNumber.ToString
                    End If
                End If
            End While
            dB.Close()
            If NumberOfClientsMadeInactive > 0 Then
                Dim sWork As String = "The following " & NumberOfClientsMadeInactive & " clients have been made inactive because they haven't visited in " & NumberOfMonthsOfNoVisitsBeforeTheyreMadeInactive & " months: "
                sWork += vbCrLf & vbCrLf & ClientsMadeInactive
                MsgBox(sWork)
            End If
        End If

    End Sub
    Sub CheckForDBMaintenance()
        '
        ' Determine whether DB maintenance is required.
        '
        'ExecuteSQLCommand("ALTER TABLE Clients DROP COLUMN OtherAdults")
        Dim MaintenanceIsRequired As Boolean = False
        'Dim SQL As String = "SELECT TOP 1 * FROM ApplicationChanges"
        Dim SQL As String = "SELECT TOP 1 OtherAdults FROM Clients"
        On Error Resume Next
        Err.Clear()
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        If Err.Description <> "" Then MaintenanceIsRequired = True
        rsWork.Close()
        dB.Close()
        If MaintenanceIsRequired Then
            'ExecuteSQLCommand("CREATE TABLE Groupings (GroupID integer, GroupName VARCHAR(50), ItemType VARCHAR(50), GroupedItems VARCHAR(100), ORLocationHorizontal YESNO)")
            ExecuteSQLCommand("ALTER TABLE Clients ADD OtherAdults VARCHAR(255)", True)
            ExecuteSQLCommand("ALTER TABLE Clients ADD SNAP YESNO", True)
            ExecuteSQLCommand("ALTER TABLE Clients ADD WIC YESNO", True)

            ExecuteSQLCommand("UPDATE Clients SET OtherAdults = ''", True)
            ExecuteSQLCommand("UPDATE Clients SET SNAP = False", True)
            ExecuteSQLCommand("UPDATE Clients SET WIC = False", True)

            MsgBox("DB Maintained.")

        End If
    End Sub
    Sub ShowVisitsToday()
        Dim iWork As Integer = GetNumberOfVisitsToday()
        Select Case iWork
            Case 0 : lblTotalVisitsToday.Text = "Total visits today: None"
            Case 1 : lblTotalVisitsToday.Text = "Total visits today: One"
            Case Else : lblTotalVisitsToday.Text = "Total visits today: " & iWork.ToString
        End Select
    End Sub
    Sub ShowDeliveriesToday()
        Dim iWork As Integer = GetNumberOfDeliveriesToday()
        Select Case iWork
            Case 0 : lblTotalDeliveriesToday.Text = "Total deliveries today: None"
            Case 1 : lblTotalDeliveriesToday.Text = "Total deliveries today: One"
            Case Else : lblTotalDeliveriesToday.Text = "Total deliveries today: " & iWork.ToString
        End Select

    End Sub
    Sub BackupTheDB(ByVal ForceIt As Boolean)
        Dim sWork As String = GetASetting("LastBackupDate")
        If sWork = "" Then sWork = Format(DateAdd(DateInterval.Day, -2, Now), "MM/dd/yyyy")
        Dim dbDateTime As Date = CDate(sWork)
        Dim NumberOfDaysSinceBackup As Integer = DateDiff(DateInterval.Day, dbDateTime, Now)
        If ForceIt Or NumberOfDaysSinceBackup >= BackupUpIntervalDays Then
            If MsgBox("It's been " & NumberOfDaysSinceBackup & " days since the database has been backed up.  Do you want to back it up now?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                Dim TodayWeekDayName As String = Format(Now, "dd") 'WeekdayName(Weekday(Now))
                Do Until Directory.Exists(ThumbDrive)
                    If MsgBox("Sorry, you must insert the thumb drive on " & ThumbDrive & ".  Skip the backup for now?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Exit Sub
                    End If
                Loop
                File.Copy(TheDirectory & dBName, ThumbDrive & TodayWeekDayName & "; " & dBName & ".bak", True)
                SaveASetting("LastBackupDate", Format(Now, "MM/dd/yyyy"))
            End If
        End If
    End Sub
    Sub LoadComboBoxes()
        Loading = True
        LoadTownComboBox(cmbTown)
        'dB.Open()
        'Dim SQL As String = "SELECT DISTINCT Town FROM Clients WHERE Town <> '' ORDER BY Town"
        'Command = New OleDbCommand(SQL, dB)
        'rsWork = Command.ExecuteReader
        'cmbTown.Items.Clear()
        'While rsWork.Read
        '    cmbTown.Items.Add(rsWork!Town)
        'End While
        'rsWork.Close()
        'dB.Close()
    End Sub
    Sub LoadList()
        lvClients.Items.Clear()
        Dim SQL As String = "SELECT CaseNumber, FirstName, LastName FROM Clients"
        If optActive.Checked Then SQL += " WHERE Active = True" Else SQL += " WHERE Active = False"
        'If Not chkIncludeInactive.Checked Then SQL += " AND CaseNumber <> 0"
        'If TestingMode Then SQL += " AND Homeless = True"
        If txtSearchLastName.Text <> "" Then
            SQL += " AND (LastName LIKE '" & SanitizeTextForSQL(txtSearchLastName.Text) & "%'"
            SQL += " OR FirstName LIKE '" & SanitizeTextForSQL(txtSearchLastName.Text) & "%')"
        End If
        If Testing Then SQL += " AND Homeless = True"
        Dim ClientRows(1) As String
        SQL += " ORDER BY "
        If SortByClientNumber Then
            SQL += "CaseNumber"
        Else
            SQL += "LastName, FirstName"
        End If
        ' "SELECT CaseNumber, FirstName, LastName FROM Clients AND Active = True ORDER BY CaseNumber"

        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            ClientRows(0) = Format(rsWork!CaseNumber, "00000")
            ClientRows(1) = rsWork!LastName & ", " & rsWork!FirstName
            Dim NewClientRow As ListViewItem = New ListViewItem(ClientRows)
            lvClients.Items.Add(NewClientRow)
        End While
        rsWork.Close()
        dB.Close()
        lvClients.SelectedItems.Clear()
    End Sub
    Sub ClearForm()
        Loading = True
        txtCaseNumber.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtAddress2.Text = ""
        cmbTown.SelectedIndex = -1
        txtZip.Text = ""
        txtPhoneH.Text = ""
        txtPhoneC.Text = ""
        txtPhoneW.Text = ""
        txtNotes.Text = ""
        datStarted.Value = Now
        datReopened.Value = Now
        cmbNumberOfAdults.SelectedIndex = 1
        cmbNumberOfChildren.SelectedIndex = 0
        cmbNumberOfSeniors.SelectedIndex = 0

        cmbMaleAdults.SelectedIndex = 0
        cmbFemaleAdults.SelectedIndex = 0
        cmbMaleChildren.SelectedIndex = 0
        cmbFemaleChildren.SelectedIndex = 0
        cmbMaleSeniors.SelectedIndex = 0
        cmbFemaleSeniors.SelectedIndex = 0

        txtAgesOfChildren.Text = ""
        chkActive.Checked = True
        chkHomeless.Checked = False
        chkDiabetic.Checked = False
        chkMilitary.Checked = False
        chkDeaf.Checked = False


        txtOtherAdults.Text = ""
        chkSNAP.Checked = False
        chkWIC.Checked = False
        cbFuelAsst.Checked = False
        cbMedicaid.Checked = False
        cbAidBlind.Checked = False
        cbCSFP.Checked = False
        cbOldAge.Checked = False
        cbTANF.Checked = False
        cbSubsHousing.Checked = False
        cbAPTD.Checked = False
        cbWelfare.Checked = False
        cbHeadStart.Checked = False
        cbIncomeEligible.Checked = False
        cbNoPork.Checked = False
        cbNoCooking.Checked = False
        tbSpecialReq.Text = ""
        tbFoodAllergies.Text = ""


        'Dim sWork As String = GetASetting("FootPrints", "True")
        'If sWork = "True" Then chkRegistrationIsComplete.Checked = False Else chkRegistrationIsComplete.Checked = True

        chkRegistrationIsComplete.Checked = True
        lstOfVisits.Items.Clear()
        Loading = False
    End Sub
    Sub FindCurrentlySelectedClient()
        ' Find the currently selected client and set the listview to select it.
        Dim iWork As Integer = 0
        Dim Found As Boolean = False
        If SelectedClientNumber <> "" And SelectedClientName <> "" Then
            For iWork = 0 To lvClients.Items.Count - 1
                Dim ThisClientNumber As String = lvClients.Items(iWork).SubItems(0).Text
                Dim ThisClientName As String = lvClients.Items(iWork).SubItems(1).Text
                If ThisClientNumber = SelectedClientNumber And ThisClientName = SelectedClientName Then
                    Found = True
                    Exit For
                End If
            Next
            If Found Then
                lvClients.SelectedItems.Clear()
                lvClients.Items(iWork).Selected = True
                lvClients.Items(iWork).EnsureVisible()
                'This code below isn't vital, and isn't working, so I'll just comment it out for now.
                If iWork <> -1 Then
                    Dim ThislvItem As ListViewItem = lvClients.Items(iWork)
                    Dim sWork As String = ThislvItem.Text
                    lvClients.TopItem = ThislvItem
                End If
            End If
        End If
    End Sub
    Sub CheckForRequiredFields(Optional ByVal Updating As Boolean = False)
        ErrorMessage = ""
        If txtCaseNumber.Text = "" Then
            SetErrorMessage("Case number is required.")
        Else
            If Not AllNumeric(txtCaseNumber.Text) Then
                SetErrorMessage("Case number must be numeric")
            End If
        End If
        If ErrorMessage = "" And Not Updating Then
            ' Check to make sure that this case number doesn't already exist.
            If Val(txtCaseNumber.Text) <> 0 AndAlso DoesCaseNumberExist(Val(txtCaseNumber.Text)) Then
                SetErrorMessage("That case number already exists!") : txtCaseNumber.Focus()
            End If

        End If

        If txtFirstName.Text = "" Then SetErrorMessage("First name is required") : txtFirstName.Focus()
        If txtLastName.Text = "" Then SetErrorMessage("Last name is required") : txtLastName.Focus()
        If cmbTown.SelectedIndex < 0 Then SetErrorMessage("Town is required") : cmbTown.Focus()
        If btnAddNew.Text = "Finish adding" And ErrorMessage = "" Then If DoesClientNumberExist(txtCaseNumber.Text) Then ErrorMessage = "That client number already exists"
        '3/20/15 DJH

        If (Val(cmbMaleAdults.Text) > 0 Or Val(cmbFemaleAdults.Text) > 0) _
            And (Val(cmbMaleAdults.Text) + Val(cmbFemaleAdults.Text) <> Val(cmbNumberOfAdults.Text)) Then

            SetErrorMessage("Sorry, number of Male Adults plus Female Adults must equal Number of Adults!")
            cmbMaleAdults.Focus()

        End If

        If (Val(cmbMaleChildren.Text) > 0 Or Val(cmbFemaleChildren.Text) > 0) _
            And (Val(cmbMaleChildren.Text) + Val(cmbFemaleChildren.Text) <> Val(cmbNumberOfChildren.Text)) Then


            SetErrorMessage("Sorry, number of Male Children plus Female Children must equal Number of Children!")
            cmbMaleChildren.Focus()
        End If

        If (Val(cmbMaleSeniors.Text) > 0 Or Val(cmbFemaleSeniors.Text) > 0) _
            And (Val(cmbMaleSeniors.Text) + Val(cmbFemaleSeniors.Text) <> Val(cmbNumberOfSeniors.Text)) Then
            SetErrorMessage("Sorry, number of Male Seniors plus Female Seniors must equal Number of Seniors!")
            cmbMaleSeniors.Focus()
        End If


        If ErrorMessage = "" Then

            Form2Structure()

        Else
            MsgBox(ErrorMessage)
        End If




    End Sub
    Sub Form2Structure()

        TheClient = New AClient
        TheClient.Active = chkActive.Checked
        TheClient.Notes = txtNotes.Text
        TheClient.Address = txtAddress.Text
        TheClient.Address2 = txtAddress2.Text
        TheClient.AgesOfChildren = txtAgesOfChildren.Text
        TheClient.CaseNumber = txtCaseNumber.Text
        TheClient.DateReOpened = datReopened.Value
        TheClient.DateStarted = datStarted.Value
        TheClient.Diabetic = chkDiabetic.Checked
        TheClient.Deaf = chkDeaf.Checked
        TheClient.FirstName = txtFirstName.Text
        TheClient.Homeless = chkHomeless.Checked
        TheClient.LastName = txtLastName.Text
        TheClient.NumberOfAdults = Val(cmbNumberOfAdults.Text)
        TheClient.NumberOfChildren = Val(cmbNumberOfChildren.Text)
        TheClient.NumberOfSeniors = Val(cmbNumberOfSeniors.Text)
        TheClient.MaleAdults = Val(cmbMaleAdults.Text)
        TheClient.FemaleAdults = Val(cmbFemaleAdults.Text)
        TheClient.MaleChildren = Val(cmbMaleChildren.Text)
        TheClient.FemaleChildren = Val(cmbFemaleChildren.Text)
        TheClient.MaleSeniors = Val(cmbMaleSeniors.Text)
        TheClient.FemaleSeniors = Val(cmbFemaleSeniors.Text)



        TheClient.PhoneH = txtPhoneH.Text
        TheClient.PhoneC = txtPhoneC.Text
        TheClient.PhoneW = txtPhoneW.Text
        TheClient.Town = cmbTown.Text
        TheClient.Zip = txtZip.Text
        TheClient.RegistrationIsComplete = chkRegistrationIsComplete.Checked
        TheClient.Military = chkMilitary.Checked
        TheClient.OtherAdults = txtOtherAdults.Text
        TheClient.WIC = chkWIC.Checked
        TheClient.FuelAsst = cbFuelAsst.Checked
        TheClient.SNAP = chkSNAP.Checked

        TheClient.Medicaid = cbMedicaid.Checked
        TheClient.AidBlind = cbAidBlind.Checked
        TheClient.CSFP = cbCSFP.Checked
        TheClient.OldAge = cbOldAge.Checked
        TheClient.TANF = cbTANF.Checked
        TheClient.SubsHOusing = cbSubsHousing.Checked
        TheClient.APTD = cbAPTD.Checked
        TheClient.Welfare = cbWelfare.Checked
        TheClient.HeadStart = cbHeadStart.Checked
        TheClient.IncomeEligible = cbIncomeEligible.Checked
        TheClient.NoPork = cbNoPork.Checked
        TheClient.NoCooking = cbNoCooking.Checked

        TheClient.SpecialReq = tbSpecialReq.Text
        TheClient.FoodAllergies = tbFoodAllergies.Text

    End Sub
    Sub UpdateThePerson()
        CheckForRequiredFields(True)
        If ErrorMessage = "" Then
            UpdateAClient(TheClient, chkUpdateDateUpdated.Checked)
            LoadList()
            Changed = False
            'ClearForm()

            FindCurrentlySelectedClient()
            SaveCurrentClientVariables()
            Record2Form()
            SetVis()
        End If

    End Sub
    Private Sub btnDone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
    Private Sub btnAddNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddNew.Click
        Dim sWork As String = ""
        If btnAddNew.Text = "Add new" Then
            ' Begin the add process
            ClearForm()
            txtFirstName.Focus()
            Loading = True
            txtCaseNumber.Text = GetNextClientNumber()
            Loading = False
            btnAddNew.Text = "Finish adding"
            SetVis()
        Else
            ' Finish adding
            ' Check to make sure that this client number doesn't exist, and that all required fields are filled in.
            ' First, check that all required fields are filled in.
            CheckForRequiredFields()
            If ErrorMessage = "" Then
                ErrorMessage = AddAClient(TheClient)
                If ErrorMessage <> "" Then MsgBox(ErrorMessage)
                SelectedClientNumber = TheClient.CaseNumber.ToString
                SelectedClientName = TheClient.LastName & ", " & TheClient.FirstName
                btnAddNew.Text = "Add new"
                LoadList()
                FindCurrentlySelectedClient()
                SetVis()
                txtSearchClientNumber.Focus()
            End If
        End If
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        UpdateButton = True
        UpdateThePerson()
        txtSearchClientNumber.Focus()
        UpdateButton = False

    End Sub
    Private Sub btnNewTown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewTown.Click
        Dim sWork As String = InputBox("Town, zip code", "Enter new town name, a comma, and the zip code", "")
        Dim TheTown As String = ""
        Dim TheZip As String = ""
        If sWork <> "" Then
            Dim iWork As Integer = InStr(sWork, ",")
            If iWork = 0 Then
                MsgBox("Sorry, you must enter: Town name, a comma, and the numeric 5 digit zip code.  For example:  Kittery, 03904")
            Else
                ' Ok, so far, so good....
                TheTown = SanitizeTextForSQL(Strings.Left(sWork, iWork - 1))
                TheZip = Trim(Strings.Mid(sWork, iWork + 1))
                If Not IsNumeric(TheZip) Or Len(TheZip) <> 5 Then
                    MsgBox("Sorry, the zip code must be 1-5 digits.")
                Else
                    If DoesTownExist(TheTown) Then
                        MsgBox("Sorry, that town already exists!")
                    Else
                        cmbTown.Items.Add(TheTown)
                        cmbTown.Text = TheTown
                        sWork = "INSERT INTO ZipCodes (Town, ZipCode) VALUES('" & TheTown & "', " & TheZip & ")"
                        ExecuteSQLCommand(sWork)
                        Changed = True
                        SetVis()
                        'LoadTownComboBox(cmbTown)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If MsgBox("Deleting this person will also delete all of their vist history.  Are you sure you want to delete " & SelectedClientName & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExecuteSQLCommand("DELETE FROM Clients WHERE CaseNumber = " & SelectedClientNumber)
            ExecuteSQLCommand("DELETE FROM Visits WHERE CaseNumber = " & SelectedClientNumber)
            LoadList()
            ClearForm()
        End If
        txtSearchClientNumber.Focus()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        btnAddNew.Text = "Add new"
        ClearForm()
        lvClients.SelectedItems.Clear()
        Changed = False
        SetVis()
        txtSearchClientNumber.Focus()
    End Sub
    Private Sub btnRecordAndPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRecordAndPrint.Click
        Dim Whoops As Boolean = False
        If Val(SelectedClientNumber) = 0 Then
            Dim sWork As String = "Sorry, you can't record bags for a client whose ClientNumber is 0"
            sWork += vbCrLf & vbCrLf & "You must first change their ClientNumber and make them active."
            sWork += vbCrLf & vbCrLf & "The next available ClientNumber is: " & GetNextClientNumber()
            MsgBox(sWork)
            Exit Sub
        End If

        ' 3/19/15 DJH added logic to schedule future date

        If Not IsDate(datApptDate.Value) Then
            MsgBox("Appointment Date must be a valid date")
            Exit Sub
        End If

        Dim ApptDate As Date = datApptDate.Value

        If DateDiff(DateInterval.Day, Now, ApptDate) < 0 Then
            MsgBox("Appointment date cannot be in the past")
            Exit Sub
        End If

        If DateDiff(DateInterval.Day, Now.Date, ApptDate.Date) > 5 Then
            MsgBox("Appointment date cannot be more than five days in the future")
            Exit Sub
        End If


        ' 1/31/2015 added appointment time and logic to validate D. Honan

        Dim dtApptTime As DateTime = #12:00:00 AM#
        Dim dtTEst As DateTime = Now()

        If Not IsDate(tbApptTime.Text) Then
            MsgBox("Please enter a valid Appointment Time")
            Exit Sub
        Else

            dtApptTime = tbApptTime.Text
            
            dtApptTime = dtApptTime.TimeOfDay.ToString
            Dim date2 As DateTime = #12:00:00 AM#
            If dtApptTime = date2 Then
                MsgBox("Appointment Time is invalid - Please enter a valid appointement time")
                Exit Sub
            End If
        End If

        Dim ProgramInd As Boolean = False
        If cbFuelAsst.Checked _
            Or cbMedicaid.Checked _
            Or chkWIC.Checked _
            Or cbAidBlind.Checked _
            Or cbCSFP.Checked _
            Or cbOldAge.Checked _
            Or cbTANF.Checked _
            Or cbSubsHousing.Checked _
            Or cbAPTD.Checked _
            Or cbWelfare.Checked _
            Or chkSNAP.Checked _
            Or cbHeadStart.Checked Then

            ProgramInd = True
        End If

        If ProgramInd = False And cbIncomeEligible.Checked = False Then
            MsgBox("To Be Eligible for the Food Pantry, either at least one Program must be " _
                   & "checked or Income Eligible must be checked")
            Exit Sub

        End If



        '
        ' First, if they haven't selected a printer, do so.
        '
        If GetASetting("Printer") = "" Then
            frmSettings.ShowDialog()
            frmSettings = Nothing
            frmSettings.Dispose()
        End If
        ' 
        ' Make sure that at least 1 Adult+Children+Seniors is specified.
        '
        If Val(cmbNumberOfAdults.Text) + Val(cmbNumberOfChildren.Text) + Val(cmbNumberOfSeniors.Text) = 0 Then
            MsgBox("Sorry, you must specify at least one adult, child, or senior!", MsgBoxStyle.Exclamation)
            Whoops = True
        End If




        ' If we haven't already recorded this visit, do so, otherwize, warn...

        ' 3/17/15 DJH for future appt dates
        Dim SQL As String = "SELECT CaseNumber FROM Visits WHERE CaseNumber = " _
            & SelectedClientNumber & _
            " AND DateValue(VisitDate)>=Date()"






        '& SelectedClientNumber & " AND " & VisitedThisWeekSQL 'VisitDate BETWEEN #" & Now.ToString("d") & " 12:00:01 AM# AND #" & Now.ToString("d") & " 11:59:59 PM#"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader

        VisitID = 0

        If Not rsWork.Read Then
            If LastVisitADelivery(SelectedClientNumber, SelectedClientName) And Not chkDelivery.Checked Then
                If MsgBox("Is this a delivery?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    chkDelivery.Checked = True
                End If
            End If
            Dim VisitDate As String = GetASetting("VisitDate", "")
            If VisitDate = "" Then VisitDate = Now.ToString

            'djh 3/19/15
            VisitDate = datApptDate.Value

            '4/18/15 DJH - changed to table adapters for insert since OLEDB was holding updates/
            ' inserts in cache and was not reachable from Table Adapters

            SQL = "INSERT INTO Visits (CaseNumber, VisitDate, ApptTime, NumberOfBags, Delivery) " _
                & "VALUES(" & SelectedClientNumber _
                & ", #" & VisitDate & "#, #" & dtApptTime & "#, 0," _
                & chkDelivery.Checked.ToString & ")"
            ' ExecuteSQLCommand(SQL)
            dB.Close()
            Dim TA1 As New DataSet1TableAdapters.VisitsTableAdapter
            TA1.Insert(SelectedClientNumber, VisitDate, dtApptTime, 0, False)
            ' Dim TA3 As New DataSet1TableAdapters.VisitsTableAdapter
            VisitID = TA1.GetLastIdForClient(SelectedClientNumber)

        Else
            dB.Close()
            MsgBox("You've already recorded a visit for this client!", MsgBoxStyle.Exclamation) 'DJH 3/20/15
            Whoops = True
        End If
        If Not Whoops Then

            ' Print the ticket, maybe

            If chkPrintIt.Checked Then

                Dim args(2) As String
                args(0) = VisitID
                args(1) = ""
                args(2) = ""

                Using TicketPrint As New TicketPrint()
                    TicketPrint.Main(args)
                End Using


                dB.Close()
                'frmPrintTickets.ShowDialog()
                'frmPrintTickets = Nothing
                'frmPrintTickets.Dispose()
            End If
            chkPrintIt.Checked = True
            If Not GetClientActiveOrInactiveFromNumber(SelectedClientNumber) Then
                ' This client is inactive.  Since they're visiting, make them active.
                SQL = GetSQLForClientRetrieve(SelectedClientNumber, SelectedClientName)
                ' "SELECT * FROM Clients WHERE FirstName = 'KELLY' AND LastName = 'TANNER' AND CaseNumber = 0"
                If SQL <> "" Then
                    Dim iWork As Integer = InStr(SQL, "WHERE")
                    SQL = "UPDATE Clients SET Active = True " & Mid(SQL, iWork)
                    'SQL = "UPDATE Clients SET Active = True WHERE CaseNumber = " & SelectedClientNumber
                    ExecuteSQLCommand(SQL)
                    optActive.Checked = True
                    LoadList()
                End If
            End If
            LoadListOfVisitsForClient()
            ShowVisitsToday()
            ShowDeliveriesToday()
            SortByClientNumber = True
            If txtSearchLastName.Text <> "" Then
                Loading = True
                txtSearchLastName.Text = ""
                Loading = False
            End If
            LoadList()
            txtSearchClientNumber.Focus()
            tbApptTime.Text = ""

        End If
        chkDelivery.Checked = False
        btnDelete.Visible = False   ' Don't do SetVis, 'cause that clears the display of the last (this) person.
    End Sub
    Private Sub btnPrintSample_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSample.Click
        'SelectedClientNumber = 0
        'SelectedClientName = ""
        'PrintSample = True
        ' Note, FootPrints food pantry needs to choose whether to print homeless items or not.  St. Vincents does not.
        'If GetASetting("FootPrints", "True") Then
        'frmPrintSampleTicket.ShowDialog()
        'frmPrintSampleTicket = Nothing
        'frmPrintSampleTicket.Dispose()
        'Else
        'PrintFacLessSelections = True
        'frmPrintTickets.ShowDialog()
        'frmPrintTickets = Nothing
        'frmPrintTickets.Dispose()
        'End If
        frmPrintTicketSample1.ShowDialog()
        frmPrintTicketSample1 = Nothing
        frmPrintTicketSample1.Dispose()

        PrintSample = False
    End Sub
    Private Sub btnUnVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnVisit.Click
        ' Remove the visited today record in Visits
        'Dim SQL As String = GetSQLForClientRetrieve(SelectedClientNumber, SelectedClientName)

        Dim LastVisitDate As Date = GetLastVisitDateForClient(SelectedClientNumber, SelectedClientName, True)


        'If MsgBox("Are you sure that you want to remove the recorded VISIT for TODAY for " & SelectedClientName & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        If MsgBox("Are you sure that you want to remove the recorded VISIT for " _
                  & Format(LastVisitDate, "MM/dd/yyyy") & " for " _
                  & SelectedClientName & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) _
                  = MsgBoxResult.Yes Then
            'SQL = "SELECT Count(*) AS CountEm FROM Visits WHERE VisitDate BETWEEN #" & Now.ToString("d") & " 12:00:01 AM# AND #" & Now.ToString("d") & " 11:59:59 PM#"

            ' djh 3/17/15 future appt date

            ' Dim SQL As String = "DELETE FROM Visits WHERE CaseNumber = " _
            '     & SelectedClientNumber & " And " & VisitedThisWeekSQL 'VisitDate = #" & Format(Now, "MM/dd/yyyy") & "#"
            Dim SQL As String = "DELETE FROM Visits WHERE CaseNumber = " _
                & SelectedClientNumber & " And " _
                & "DateValue(VisitDate)>=Date()"





            ExecuteSQLCommand(SQL)
            Record2Form()
            ShowVisitsToday()
            ShowDeliveriesToday()
        End If

    End Sub
    Private Sub btnTest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTest.Click
        lvClients.Items(3).Selected = True
        Stop
        lvClients.Items(4).Selected = True
        Stop

        'Dim TheText As String = ""
        ''TheText = "Helmar"
        ''TheText = "O 'CALLAGHAN"
        ''TheText = "LEIGH-WILLIAMS"
        ''TheText = "McCarthy"
        ''TheText = "Mc Carthy"
        ''TheText = "St.John"
        ''TheText = "St. John"
        ''TheText = "Von John"
        ''TheText = "Van John"
        'MsgBox(MakeUpperLowerCase(UCase("Helmar")))
        'MsgBox(MakeUpperLowerCase(UCase("O 'CALLAGHAN")))
        'MsgBox(MakeUpperLowerCase(UCase("LEIGH-WILLIAMS")))
        'MsgBox(MakeUpperLowerCase(UCase("McCarthy")))
        'MsgBox(MakeUpperLowerCase(UCase("Mc Carthy")))
        'MsgBox(MakeUpperLowerCase(UCase("St.John")))
        'MsgBox(MakeUpperLowerCase(UCase("St. John")))
        'MsgBox(MakeUpperLowerCase(UCase("Von John")))
        'MsgBox(MakeUpperLowerCase(UCase("Van John")))




        'Dim m0 As String = "This example increments the cursor size from " & _
        '                "1% to 100%:" & vbCrLf
        'Dim m1 As String = "Cursor size = {0}%. (Press any key to continue...)"
        'Dim sizes As Integer() = {1, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100}
        'Dim saveCursorSize As Integer
        ''
        'saveCursorSize = Console.CursorSize
        'Console.WriteLine(m0)
        'Dim size As Integer
        'For Each size In sizes
        '    Console.CursorSize = size
        '    Console.WriteLine(m1, size)
        '    Console.ReadKey()
        'Next size
        'Console.CursorSize = saveCursorSize

        'Dim FILE_NAME As String = "C:\aaaaTemp\test.txt"
        'Dim i As Integer
        'Dim aryText(4) As String

        'aryText(0) = "Mary WriteLine"
        'aryText(1) = "Had"
        'aryText(2) = "A"
        'aryText(3) = "Little"
        'aryText(4) = "One"

        'Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

        'For i = 0 To 4

        '    objWriter.WriteLine(aryText(i))

        'Next

        'objWriter.Close()



        'Dim SQL As String = "UPDATE Clients SET NumberOfSeniors = 1 WHERE Senior = True"
        'ExecuteSQLCommand(SQL)


        'dB.Open()
        'Dim rsWork As OleDbDataReader
        'SQL = "SELECT CaseNumber, FirstName, LastName FROM Clients WHERE CaseNumber <> 0"
        'Dim sWork As String = ""
        'Command = New OleDbCommand(SQL, dB)
        'rsWork = Command.ExecuteReader
        'While rsWork.Read
        '    If Strings.Right(rsWork!FirstName, 1) = " " Or Strings.Right(rsWork!LastName, 1) = " " Then
        '        Dim iWork As Integer = rsWork!CaseNumber
        '        Stop
        '    End If

        'End While
        'rsWork.Close()
        'dB.Close()

        '
        ' Convert all names that are currently all upper case, to Upper/Lower case.
        '
        'Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        'Dim rsWork As OleDbDataReader
        'SQL += "SELECT CaseNumber, FirstName, LastName FROM Clients WHERE CaseNumber <> 0"
        'Dim sWork As String = ""
        'Command = New OleDbCommand(SQL, dB)
        'rsWork = Command.ExecuteReader
        'While rsWork.Read
        '    ' See if we need to fix these names
        '    If rsWork!FirstName & rsWork!LastName = UCase(rsWork!FirstName) & UCase(rsWork!LastName) Then
        '        ' It's all upper case, fix it.
        '        SQL = "UPDATE Clients SET FirstName = '"
        '        SQL += SanitizeTextForSQL(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(rsWork!FirstName)))
        '        SQL += "', LastName = '"
        '        SQL += SanitizeTextForSQL(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LCase(rsWork!LastName)))
        '        SQL += "' WHERE CaseNumber = " & rsWork!CaseNumber
        '        ' Special exceptions:
        '        SQL = Replace(SQL, "Macdonald", "MacDonald")
        '        ' "UPDATE Clients SET FirstName = 'Ann', LastName = 'Macdonald' WHERE CaseNumber = 1035"
        '        ExecuteSQLCommand(SQL)
        '    End If
        'End While
        'rsWork.Close() : rsWork = Nothing
        'If Not dbWasOpen Then dB.Close()
        'frmPrintTicketsN.ShowDialog()
        'GetDBLocation(True)
        'ExecuteSQLCommand("UPDATE Visits SET NumberOfBags = 0")
        'Testing = True
        'LoadList()
        'Testing = False
        'PrintDocument()
    End Sub
    Private Sub txtSearchLastName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearchLastName.TextChanged
        If Not Loading Then
            SortByClientNumber = False
            LoadList()
        End If
    End Sub
    Function DoesClientNumberExist(ByVal ClientNumber As Integer) As Boolean
        Dim ItExists As Boolean = False
        If ClientNumber <> 0 Then   ' Allow multiple 0000's
            Dim SQL As String = "SELECT CaseNumber FROM Clients WHERE CaseNumber = " & ClientNumber.ToString
            dB.Open()
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            If rsWork.Read Then ItExists = True
            rsWork.Close()
            dB.Close()
        End If
        Return ItExists
    End Function
    Function GetNextClientNumber() As String
        Dim SQL As String = "SELECT MAX(CaseNumber) AS MaxNumber FROM Clients"
        Dim iWork As Integer = 0
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        If Not IsDBNull(rsWork!MaxNumber) Then
            iWork = Val(rsWork(0))
        Else
            iWork = 0
        End If
        rsWork.Close()
        dB.Close()
        Return iWork + 1.ToString
    End Function
    Sub SetErrorMessage(ByVal TheMessage As String)
        If ErrorMessage <> "" Then ErrorMessage += ", "
        ErrorMessage += TheMessage
    End Sub
    Function AllNumeric(ByVal TheText As String) As Boolean
        Dim ItsOk As Boolean = True
        For iWork As Integer = 1 To Len(TheText)
            If InStr("0123456789", Mid(TheText, iWork, 1)) = 0 Then
                ItsOk = False
                Exit For
            End If
        Next
        Return ItsOk
    End Function
    Private Sub mnuFileQuit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuFileQuit.Click
        Me.Close()
    End Sub
    Private Sub mnuFileImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuFileImport.Click
        ' Import the Saint Vincents items.
        ExecuteSQLCommand("DELETE FROM Items")
        Const ImportFileName As String = "C:\aaaaTemp\Hampton Inventory list.txt"
        Dim TheLine As String = ""
        Dim objReader As New System.IO.StreamReader(ImportFileName)
        ' Read the heading line
        TheLine = objReader.ReadLine()
        Do While objReader.Peek() <> -1
            TheLine = objReader.ReadLine()
            If Strings.Left(TheLine, 1) <> "\" Then
                Dim aWork() As String = Split(TheLine, vbTab)
                ' Normalize the data
                Dim TheItem As String = Replace(aWork(0), """", "")
                Dim TheType As String = Replace(aWork(1), """", "")
                If TheType = "home" Then TheType = "Home"
                If TheType = "food" Then TheType = "Food"
                If TheType = "specials" Then TheType = "Specials"

                Dim TheAvailable As String = UCase(aWork(2))
                If TheAvailable = "Y" Then TheAvailable = "True" Else TheAvailable = False
                'Dim SQL As String = "INSERT INTO Items"
                Dim SQL As String = "INSERT INTO Items (ItemName, ItemType, Limit, Available, CountForNPeople) VALUES("
                SQL += "'" & TheItem & "'"
                SQL += ",'" & TheType & "'"
                SQL += "," & 0
                SQL += "," & TheAvailable
                SQL += ",''"
                SQL += ")"
                ExecuteSQLCommand(SQL)
            End If

        Loop
        objReader.Close()
        MsgBox("Done")
    End Sub
    Private Sub mnuReportVisits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportVisits.Click
        frmReport.ShowDialog()
        frmReport = Nothing
        frmReport.Dispose()
    End Sub
    Private Sub lvClients_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs) Handles lvClients.ColumnClick
        If e.Column = 0 Then SortByClientNumber = True Else SortByClientNumber = False
        LoadList()
    End Sub
    Function GetSQLForSelectedClient() As String
        Dim sWork As String = "" ' lvClients.FocusedItem.SubItems(0).Text
        Dim TheClientNumber As String = ""
        Dim TheClientName As String = ""
        Dim SQL As String = ""
        Dim lvi As ListViewItem ' = lvClients.SelectedItems
        For Each lvi In lvClients.SelectedItems
            TheClientNumber = lvi.SubItems(0).Text
            TheClientName = lvi.SubItems(1).Text
        Next
        If Val(TheClientNumber) = 0 Then
            ' There are multiple clients who's client number is 0, so use their name.
            Dim FirstName As String = ""
            Dim LastName As String = ""
            Dim iWork As Integer = InStrRev(TheClientName, ",")
            If Strings.Trim(Strings.Left(TheClientName, iWork - 1)) <> "" Then
                LastName = Trim(Replace(Strings.Left(TheClientName, iWork - 1), ",", ""))
                FirstName = Trim(Strings.Mid(TheClientName, iWork + 1))
            Else
                FirstName = Trim(Mid(TheClientName, iWork + 1))
                LastName = ""
            End If
            SQL = "SELECT * FROM Clients WHERE "
            If FirstName <> "" Then SQL += "FirstName = '" & FirstName & "'"
            If LastName <> "" Then
                If FirstName <> "" Then SQL += " AND "
                SQL += "LastName = '" & LastName & "'"
            End If
        Else
            SQL = "SELECT * FROM Clients WHERE CaseNumber = " & TheClientNumber
        End If
        Return SQL
    End Function
    Sub Record2Form()
        Dim SQL As String = GetSQLForClientRetrieve(SelectedClientNumber, SelectedClientName)
        If SQL <> "" Then
            dB.Open()
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            If rsWork.Read Then
                Dim SaveLoading As Boolean = Loading
                Loading = True
                txtCaseNumber.Text = rsWork!CaseNumber.ToString
                txtNotes.Text = rsWork!Notes
                txtAddress.Text = rsWork!Address
                txtAddress2.Text = rsWork!Address2
                txtAgesOfChildren.Text = rsWork!AgesOfChildren
                txtFirstName.Text = rsWork!FirstName
                txtLastName.Text = rsWork!LastName
                txtPhoneH.Text = rsWork!PhoneH
                txtPhoneC.Text = rsWork!PhoneC
                txtPhoneW.Text = rsWork!PhoneW
                txtZip.Text = Strings.Right("00000" & rsWork!Zip, 5)
                If cmbTown.FindStringExact(rsWork!Town) Then
                    cmbTown.Text = rsWork!Town
                Else
                    cmbTown.SelectedIndex = -1
                End If
                'If IsDate(rsWork!DOB) Then datDOB.Value = rsWork!DOB Else datDOB.Value = Now
                datStarted.Value = rsWork!DateStarted
                If IsDate(rsWork!DateReopened) Then datReopened.Value = rsWork!DateReOpened Else datReopened.Value = Now
                chkActive.Checked = rsWork!Active
                chkHomeless.Checked = rsWork!Homeless
                chkDiabetic.Checked = rsWork!Diabetic
                chkDeaf.Checked = rsWork!Deaf

                cmbNumberOfAdults.Text = rsWork!NumberOfAdults
                cmbNumberOfChildren.Text = rsWork!NumberOfChildren
                cmbNumberOfSeniors.Text = rsWork!NumberOfSeniors

                cmbMaleAdults.Text = rsWork!MaleAdults
                cmbFemaleAdults.Text = rsWork!FemaleAdults

                cmbMaleChildren.Text = rsWork!MaleChildren
                cmbFemaleChildren.Text = rsWork!FemaleChildren

                cmbMaleSeniors.Text = rsWork!MaleSeniors
                cmbFemaleSeniors.Text = rsWork!FemaleSeniors

                If Not IsDBNull(rsWork!DateLastUpdated) Then
                    lblLastUpdated.Visible = True
                    datLastUpdated.Visible = True
                    'On Error Resume Next
                    datLastUpdated.Value = rsWork!DateLastUpdated
                    'MsgBox(Err.Description)
                Else
                    lblLastUpdated.Visible = False
                    datLastUpdated.Visible = False
                End If
                chkRegistrationIsComplete.Checked = Not rsWork!UnfinishedRegistraion
                If Not chkRegistrationIsComplete.Checked Then MsgBox("Registration is not complete for this client!", MsgBoxStyle.Exclamation)
                'Dim FirstName As String = rsWork!FirstName
                'Dim LastName As String = rsWork!LastName
                'Dim TheName As String = ""
                'FirstNameLastNameFromClientName(TheName, FirstName, LastName)
                If IsThisClientAReOpen(rsWork!CaseNumber, rsWork!FirstName & " " & rsWork!LastName) Then lblReOpened.Visible = True Else lblReOpened.Visible = False
                chkMilitary.Checked = rsWork!Military
                txtOtherAdults.Text = rsWork!OtherAdults
                chkSNAP.Checked = rsWork!SNAP
                chkWIC.Checked = rsWork!WIC
                cbFuelAsst.Checked = rsWork!FuelAssistance

                cbMedicaid.Checked = rsWork!Medicaid
                cbAidBlind.Checked = rsWork!AidBlind
                cbCSFP.Checked = rsWork!CSFP
                cbOldAge.Checked = rsWork!OldAge
                cbTANF.Checked = rsWork!TANF
                cbSubsHousing.Checked = rsWork!SubsHOusing
                cbAPTD.Checked = rsWork!APTD
                cbWelfare.Checked = rsWork!Welfare
                cbHeadStart.Checked = rsWork!HeadStart
                cbIncomeEligible.Checked = rsWork!IncomeEligible
                cbNoPork.Checked = rsWork!NoPork
                cbNoCooking.Checked = rsWork!NoCooking

                tbSpecialReq.Text = rsWork!SpecialReq
                tbFoodAllergies.Text = rsWork!FoodAllergies


                'If TestingMode And lblReOpened.Visible Then Stop
                Loading = SaveLoading
                Changed = False
                SetVis()
            End If
            rsWork.Close()
            '
            ' Load list of visits
            '
            LoadListOfVisitsForClient()
            'lstOfVisits.Items.Clear()
            'SQL = "SELECT VisitDate, NumberOfBags FROM Visits WHERE CaseNumber = " & txtCaseNumber.Text
            'SQL += " ORDER BY VisitDate DESC"
            'Command = New OleDbCommand(SQL, dB)
            'rsWork = Command.ExecuteReader
            'While rsWork.Read
            '    lstOfVisits.Items.Add(Format(rsWork!VisitDate, "MM/dd/yyyy") & ", " & rsWork!NumberOfBags & " bags.")
            'End While
            'rsWork.Close()

            dB.Close()

        End If

    End Sub
    Sub LoadListOfVisitsForClient()
        '
        ' Load list of visits
        '
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        lstOfVisits.Items.Clear()
        Dim SQL As String = ""



        SQL = GetSQLForClientRetrieve(SelectedClientNumber, SelectedClientName)
        SQL = Replace(SQL, "CaseNumber", "Clients.CaseNumber")  ' Make CaseNumber table specific for JOIN
        Dim iWork As Integer = InStr(SQL, "WHERE")
        Dim TheWhere As String = Mid(SQL, iWork)



        SQL = "SELECT VisitDate, ApptTime, NumberOfBags FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber " & TheWhere



        'SQL = "SELECT VisitDate, NumberOfBags FROM Visits WHERE CaseNumber = " & SelectedClientNumber
        SQL += " ORDER BY VisitDate DESC"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        ' 2/1/15 added appointment time D. Honan
        Dim stApptTime As String = ""
        While rsWork.Read
            If rsWork!ApptTime Is DBNull.Value Then
                stApptTime = ""
            Else
                stApptTime = " " & Format(rsWork!ApptTime, "h:mmtt") & " "
            End If
            lstOfVisits.Items.Add(Format(rsWork!VisitDate, "MM/dd/yyyy") _
                     & stApptTime _
                     & ", " & rsWork!NumberOfBags & " bags.")
        End While
        rsWork.Close()
        If Not dbWasOpen Then dB.Close()
    End Sub
    Sub SaveCurrentClientVariables()
        If lvClients.SelectedItems.Count <> 0 Then
            SelectedClientNumber = lvClients.SelectedItems(0).SubItems(0).Text
            SelectedClientName = lvClients.SelectedItems(0).SubItems(1).Text
            SelectedClientLastVisitDate = DateLastVisited(Val(SelectedClientNumber))

        End If

    End Sub
    Private Sub lvClients_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvClients.SelectedIndexChanged
        ' ***************************************************************************************
        ' NOTE: In any control where you can select multiple items, SelectedIndexChanged event fires twice. 
        ' One, to remove the deselected item and then to add selected item. 
        ' When you click first time, selected items collection is null and hence it fired once. 
        ' Next time it will fire twice.
        ' ***************************************************************************************
        If Not Loading Then
            Dim sWork As String = "" ' lvClients.FocusedItem.SubItems(0).Text
            Dim SQL As String = ""
            Dim iWork As Integer = 0
            If lvClients.SelectedItems.Count = 0 Then Exit Sub ' This must be the deselection cycle mentioned above!
            If btnUpdate.Visible And Changed Then
                MsgBox("You've selected a new person without updating " & SelectedClientName & ".  The changes have NOT been made.")
            End If
        End If
        SaveCurrentClientVariables()
        If Not UpdateButton Then
            tbApptTime.Text = ""
        End If
        UpdateButton = False

        Record2Form()
        'txtFirstName.Focus()

    End Sub

    Private Sub txtFirstName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirstName.LostFocus
        If Not Loading And ConvertCases Then
            txtFirstName.Text = MakeUpperLowerCase(txtFirstName.Text)
        End If
    End Sub

    Private Sub txtLastName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLastName.LostFocus
        If ConvertCases Then
            txtLastName.Text = MakeUpperLowerCase(txtLastName.Text)
        End If
    End Sub
    Sub SomethingsChanged() Handles txtAddress.TextChanged, txtAddress2.TextChanged, txtAgesOfChildren.TextChanged, txtFirstName.TextChanged, txtLastName.TextChanged, txtPhoneH.TextChanged, txtPhoneC.TextChanged, txtPhoneW.TextChanged, _
    txtZip.TextChanged, datReopened.ValueChanged, datStarted.ValueChanged, chkActive.CheckedChanged, chkDiabetic.CheckedChanged, chkRegistrationIsComplete.CheckedChanged, chkHomeless.CheckedChanged, _
    cmbNumberOfAdults.SelectedIndexChanged, cmbNumberOfChildren.SelectedIndexChanged, cmbNumberOfSeniors.SelectedIndexChanged, txtCaseNumber.TextChanged, _
    cmbTown.SelectedIndexChanged, txtNotes.TextChanged, chkDeaf.CheckedChanged, chkMilitary.CheckedChanged, _
    txtOtherAdults.TextChanged, chkWIC.CheckedChanged, chkSNAP.CheckedChanged, cbFuelAsst.CheckedChanged, _
        cbMedicaid.CheckedChanged, _
        cbAidBlind.CheckedChanged, _
        cbCSFP.CheckedChanged, _
        cbOldAge.CheckedChanged, _
        cbTANF.CheckedChanged, _
        cbSubsHousing.CheckedChanged, _
        cbAPTD.CheckedChanged, _
        cbWelfare.CheckedChanged, _
        cbHeadStart.CheckedChanged, _
        cbIncomeEligible.CheckedChanged, _
        cbNoPork.CheckedChanged, _
        cbNoCooking.CheckedChanged, _
        tbSpecialReq.TextChanged, _
        tbFoodAllergies.TextChanged, _
        cmbMaleAdults.SelectedIndexChanged, _
        cmbFemaleAdults.SelectedIndexChanged, _
        cmbMaleChildren.SelectedIndexChanged, _
        cmbFemaleChildren.SelectedIndexChanged, _
        cmbMaleSeniors.SelectedIndexChanged, _
        cmbFemaleSeniors.SelectedIndexChanged




        If Not Loading Then
            Changed = True
            SetVis()
        End If
    End Sub
    Sub SetVis()
        If btnAddNew.Text = "Finish adding" Then
            ' Adding a new record
            pnlClients.Enabled = False
            pnlClient.Enabled = True
            btnCancel.Visible = True
            btnRecordAndPrint.Enabled = False
            btnUnVisit.Visible = False
            btnDelete.Visible = False
        Else
            ' NOT adding a new record
            pnlClients.Enabled = True
            btnCancel.Visible = False
            btnDelete.Visible = True
            If lvClients.SelectedItems.Count = 0 Then
                ' Nobody's selected
                lblCurrentlySelected.Text = ""
                pnlClients.Enabled = True
                pnlClient.Enabled = False
                btnCancel.Visible = False
                btnUnVisit.Visible = False
                btnUpdate.Visible = False
                btnDelete.Visible = False
                btnRecordAndPrint.Enabled = False
            Else
                ' Sombody's been selected
                lblCurrentlySelected.Text = SelectedClientNumber & ", " & SelectedClientName
                If TestingMode Then lblCurrentlySelected.Text += ", " & lvClients.SelectedItems(0).Index.ToString
                pnlClient.Enabled = True
                pnlClients.Enabled = True
                btnCancel.Visible = False
                btnDelete.Visible = True
                If Changed Then btnRecordAndPrint.Enabled = False Else btnRecordAndPrint.Enabled = True
                Dim sWork As String = GetLastVisitDateForClient(SelectedClientNumber, SelectedClientName, True)
                If IsDate(sWork) AndAlso DateDiff(DateInterval.Day, CDate(sWork), Now) <= 0 Then btnUnVisit.Visible = True Else btnUnVisit.Visible = False

                If Changed Then
                    btnUpdate.Visible = True
                    MenuEnableDisable(False)
                    'btnRecordAndPrint.Visible = False
                Else
                    btnUpdate.Visible = False
                    MenuEnableDisable(True)
                    'btnRecordAndPrint.Visible = True
                End If
                chkUpdateDateUpdated.Visible = btnUpdate.Visible
            End If

        End If
    End Sub
    Sub MenuEnableDisable(ByVal EnableDisable As Boolean)
        mnuFile.Enabled = EnableDisable
        mnuEdit.Enabled = EnableDisable
        mnuReport.Enabled = EnableDisable

    End Sub
    Private Sub mnuFileChangeDBLocation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuFileChangeDBLocation.Click
        GetDBLocation(True)
        LoadList()
    End Sub
    Private Sub mnuEditItemsMaintain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditItemsMaintain.Click
        frmItems2.ShowDialog()
        frmItems2 = Nothing
        frmItems2.Dispose()
    End Sub
    Private Sub UpdateItemTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateItemTypesToolStripMenuItem.Click
        frmItemTypes.ShowDialog()
        frmItemTypes = Nothing
        frmItemTypes.Dispose()

    End Sub
    Private Sub mnuEditItemsGroupItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditItemsGroupItems.Click
        frmGroupItems.ShowDialog()
        frmGroupItems = Nothing
        frmGroupItems.Dispose()
    End Sub
    Private Sub mnuFileBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileBackup.Click
        BackupTheDB(True)
    End Sub
    Private Sub mnuEditItemsSetAvailability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSetAvailability.ShowDialog()
        frmSetAvailability = Nothing
        frmSetAvailability.Dispose()
    End Sub
    Private Sub mnuEditVisits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditVisits.Click
        Dim NumberOfVisitsToRecord As Integer = 0
        Dim SQL As String = "SELECT COUNT (*) AS CountEm FROM Visits WHERE NumberOfBags = 0"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfVisitsToRecord = rsWork!CountEm
        rsWork.Close()
        dB.Close()
        If NumberOfVisitsToRecord <> 0 Then

            frmRecordBags.ShowDialog()
            frmRecordBags = Nothing
            frmRecordBags.Dispose()
        Else
            MsgBox("There are no visits that need to be recorded.")
        End If
    End Sub
    Private Sub chkIncludeInactive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadList()
    End Sub
    Private Sub mnuFileSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSQL.Click
        Dim sWork As String = InputBox("SQL or FileName: ", "Enter SQL Command or FileName.SQL", "")
        If sWork <> "" Then
            If Strings.Right(UCase(sWork), 4) = ".SQL" Then
                '
                ' A file name which contains SQL commands.
                '
                ' C:\Projects.Net\VS2008\Food Pantry\FixDB.SQL

                If File.Exists(sWork) Then
                    Dim objReader As New System.IO.StreamReader(sWork)
                    dB.Open()
                    Do While objReader.Peek() <> -1
                        Dim SQL As String = objReader.ReadLine
                        If SQL <> "" AndAlso Strings.Left(SQL, 1) <> "'" Then
                            ExecuteSQLCommand(SQL, True)
                        End If
                    Loop
                    objReader.Close()
                    dB.Close()
                    MsgBox("Ok, SQL file processed.")
                Else
                    MsgBox("Sorry, that file doesn't exist!")
                End If
            Else
                ' 
                ' A single SQL command.
                '
                sWork = ExecuteSQLCommand(sWork)
                If sWork = "" Then
                    MsgBox("Ok, SQL command successfull.")
                Else
                    MsgBox(sWork)
                End If
            End If
        End If
    End Sub
    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        Dim sWork As String = "File location is: " & TheDirectory & dBName
        sWork += vbCrLf & "Backup drive is: " & ThumbDrive
        sWork += vbCrLf & "Printer is: " & GetASetting("Printer")
        sWork += vbCrLf & "Version: " & System.Windows.Forms.Application.ProductVersion
        MsgBox(sWork)
    End Sub
    Private Sub cmbTown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTown.SelectedIndexChanged
        'If txtZip.Text = "" Then
        Dim sWork As String = GetZipCodeForTown(cmbTown.Text)
        txtZip.Text = sWork
        'End If
    End Sub
    Sub ActiveOrInactiveClients() Handles optActive.Click, optInactive.Click
        LoadList()
        ClearForm()
    End Sub
    Private Sub txtSearchClientNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchClientNumber.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        Loading = True : txtSearchLastName.Text = "" : SortByClientNumber = True : Loading = False
        If e.KeyChar = vbCr Then
            If txtSearchClientNumber.Text <> "" And Val(txtSearchClientNumber.Text) <> 0 Then
                ' -1 = Not found, 0 = Not active, 1 = Active
                Dim iWork As Integer = GetClientActiveOrInactiveFromNumber(txtSearchClientNumber.Text)
                If iWork = -1 Then
                    MsgBox("Sorry, that client doesn't exist!")
                Else
                    ' See if we need to reload the client list.
                    If (optActive.Checked And iWork = 0) Or (optInactive.Checked And iWork = 1) Then
                        'optActive.Checked = Not optActive.Checked
                        If iWork = 1 Then optActive.Checked = True Else optInactive.Checked = True
                        LoadList()
                    End If
                    'If Val(txtSearchClientNumber.Text) <> 0 Then
                    Loading = True
                    SelectedClientNumber = Format(Val(txtSearchClientNumber.Text), "00000")
                    SelectedClientName = GetClientNameFromNumber(txtSearchClientNumber.Text, True)
                    SelectedClientLastVisitDate = DateLastVisited(SelectedClientNumber)
                    FindCurrentlySelectedClient()
                    Record2Form()
                    'Loading = True
                    txtFirstName.Focus()
                    txtFirstName.SelectionLength = 0
                    txtSearchClientNumber.Text = ""
                    btnRecordAndPrint.Enabled = True    ' .Focus doesn't work unless the control is enabled.
                    btnRecordAndPrint.Focus()
                    Loading = False
                    e.Handled = True

                    'End If
                End If
            End If
        Else
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    MsgBox("Numbers only please!")
                    e.Handled = True
                End If
            End If
        End If
    End Sub
    Private Sub mnuEditSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditSettings.Click
        frmSettings.ShowDialog()
        frmSettings = Nothing
        frmSettings.Dispose()
        If GetASetting("AutoULCase", "False") = "True" Then ConvertCases = True Else ConvertCases = False
    End Sub
    Private Sub mnuHelpCLA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpCLA.Click
        Dim sWork As String = "Command line arguments: X=1 WHERE"
        sWork += vbCrLf & "T, integer, Printed ticket top margin"
        sWork += vbCrLf & "B, integer, Printed ticket bottom margin"
        sWork += vbCrLf & "L, integer, Printed ticket left margin"
        sWork += vbCrLf & "R, integer, Printed ticket right margin"
        sWork += vbCrLf & "1, integer, Main form client list, column 1 width"
        sWork += vbCrLf & "2, integer, Main form client list, column 2 width"
        sWork += vbCrLf & "C, nothing, Check for DB updates on startup"
        sWork += vbCrLf & "Q, nothing, show ""Enter SQL Command"" menu item"
        sWork += vbCrLf & "P, nothing, report form, show print preview"
        sWork += vbCrLf & vbCrLf & "Current command line arguments: "
        Dim Arguments() As String = Environment.GetCommandLineArgs()
        For iWork As Integer = 1 To UBound(Arguments)
            sWork += Arguments(iWork) & " "
        Next
        MsgBox(sWork)

    End Sub
    Private Sub mnuReportItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportItems.Click
        Dim FileName As String = TheDirectory & "All items.txt"
        Dim TheLine As String = ""
        ' http://whatilearnttuday.blogspot.com/2011/10/write-text-files-without-byte-order.html
        ' https://www.google.com/search?q=vb.net+write+text+file+without+bom&ie=utf-8&oe=utf-8&aq=t&rls=org.mozilla:en-US:official&client=firefox-a
        'If File.Exists(FileName) Then File.Delete(FileName)
        ' Open the output file and write the header line
        Dim OutputFile As String = FileName
        If File.Exists(OutputFile) Then File.Delete(OutputFile)
        TheLine = "Item" & vbTab & "Type" & vbTab & "Available"
        File.WriteAllText(FileName, TheLine)
        Dim SQL As String = "SELECT * FROM Items"
        SQL += " ORDER BY ItemName"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            TheLine = rsWork!ItemName
            TheLine += vbTab & rsWork!ItemType
            TheLine += vbTab & rsWork!Available.ToString
            File.AppendAllText(FileName, Environment.NewLine & TheLine)
        End While
        rsWork.Close()
        dB.Close()
        MsgBox("Ok, " & OutputFile & " has been created.")


    End Sub
    Private Sub mnuFileFixhtmlPages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileFixhtmlPages.Click
        FixHtmlPages()
    End Sub
    Private Sub mnuReportExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportExtract.Click
        frmExtractInformation.ShowDialog()
        frmExtractInformation = Nothing
        frmExtractInformation.Dispose()
    End Sub
    Private Sub btnSpecial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpecial.Click
        Dim sWork As String = "Set all clients that haven't visited yet to inactive?"
        If MsgBox(sWork, MsgBoxStyle.YesNo, "Special processing") = MsgBoxResult.Yes Then
            Dim NumberProcessed As Integer = 0
            dB.Open()
            Dim SQL As String = "SELECT CaseNumber FROM Clients WHERE CaseNumber <> 0 and Active = True"
            Dim Command2 As OleDbCommand
            Dim rsWork2 As OleDbDataReader
            Command2 = New OleDbCommand(SQL, dB)
            rsWork2 = Command2.ExecuteReader
            Dim MakeThemInactive As Boolean = False
            While rsWork2.Read
                ' For each client, if they haven't ever visited, set them to inactive.
                SQL = "SELECT ID FROM Visits WHERE CaseNumber = " & rsWork2!CaseNumber
                Command = New OleDbCommand(SQL, dB)
                rsWork = Command.ExecuteReader
                If rsWork.Read Then
                    ' Found one, don't set them to inactive
                    MakeThemInactive = False
                Else
                    MakeThemInactive = True
                End If
                If MakeThemInactive Then
                    ExecuteSQLCommand("UPDATE Clients SET Active = False WHERE CaseNumber = " & rsWork2!CaseNumber)
                    NumberProcessed += 1
                End If
            End While
            rsWork.Close()
            dB.Close()
            SaveASetting("SpecialProcessingDone", Format(Now, "MM/dd/yyyy"))
            MsgBox("Ok, " & NumberProcessed & " clients that haven't visited yet have been set to inactive.")
            LoadList()
        End If
    End Sub
    Private Sub mnuReportTodaysDeliveries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportTodaysDeliveries.Click
        Dim NumberOfDeliveriesToday As Integer = 0
        Dim VisitDate As String = GetASetting("VisitDate", "")
        If VisitDate = "" Then VisitDate = Now.ToString("d")
        Dim SQL As String = "SELECT COUNT (*) AS CountEm FROM Visits WHERE Delivery = True AND " ' VisitDate = #" & VisitDate & "#"
        SQL += VisitedThisWeekSQL
        ' Public VisitedToday As String = "VisitDate BETWEEN #" & Now.ToString("d") & " 12:00:00 AM# AND #" & Now.ToString("d") & " 11:59:59 PM#"

        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfDeliveriesToday = rsWork!CountEm
        rsWork.Close()
        dB.Close()
        If NumberOfDeliveriesToday <> 0 Then
            frmReportDeliveries.ShowDialog()
            frmReportDeliveries = Nothing
            frmReportDeliveries.Dispose()
        Else
            MsgBox("There have been no deliveries today.")
        End If
    End Sub
    Private Sub mnuHelpChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpChanges.Click
        frmChanges.ShowDialog()
        frmChanges = Nothing
        frmChanges.Dispose()
    End Sub
    Private Sub chkPrintIt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrintIt.CheckedChanged
        If chkPrintIt.Checked Then
            btnRecordAndPrint.Text = "Record visit and print ticket"
        Else
            btnRecordAndPrint.Text = "Record visit without printing"
        End If
    End Sub
    Sub ShowCounts()
        Dim WhereClause As String = ""
        Dim sWork As String = ""
        Dim Notes As String = ""
        Notes = InputBox("Contents of notes field:", "Notes", "")
        'If Not Debugger.IsAttached Then
        'End If
        If Notes <> "" Then WhereClause = " WHERE Notes LIKE '%" & Notes & "%'"

        dB.Open()
        '
        ' Count total famlies
        '
        Dim NumberOfFamliesActive As Integer
        Dim NumberOfFamliesInactive As Integer
        Dim SQL As String = "SELECT COUNT(Active) as FamilyCount FROM Clients" & ThisWhere(Notes, True, True, "") ' WHERE Active = True AND" & WhereClause
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfFamliesActive = rsWork!FamilyCount
        rsWork.Close()
        SQL = "SELECT COUNT(Active) as FamilyCount FROM Clients" & ThisWhere(Notes, True, False, "")  ' WHERE Active = False AND" & WhereClause
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfFamliesInactive = rsWork!FamilyCount
        rsWork.Close()
        '
        ' Count 00000
        '
        Dim NumberOfZeroFamlies As Integer
        SQL = "SELECT COUNT(*) as FamilyCount FROM Clients WHERE CaseNumber = 0"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfZeroFamlies = rsWork!FamilyCount
        rsWork.Close()
        '
        ' Single famlies and famlies with children
        '
        Dim NumberOfFamliesWithChildren As Integer
        Dim NumberOfFamliesWithoutChildren As Integer
        SQL = "SELECT COUNT(*) as FamilyCount FROM Clients"
        sWork = ThisWhere(Notes, False, False, "NumberOfChildren = 0")
        If sWork = "" Then sWork = " WHERE "
        'sWork += " NumberOfChildren = 0"
        SQL += sWork
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfFamliesWithoutChildren = rsWork!FamilyCount
        rsWork.Close()
        SQL = "SELECT COUNT(*) as FamilyCount FROM Clients"
        sWork = ThisWhere(Notes, False, False, "NumberOfChildren <> 0")
        If sWork = "" Then sWork = " WHERE "
        SQL += sWork
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfFamliesWithChildren = rsWork!FamilyCount
        rsWork.Close()
        '
        ' Number of FacLess famlies
        '
        Dim NumberOfFacLessFamlies As Integer
        sWork = ThisWhere(Notes, False, False, "HomeLess = True")
        SQL = "SELECT COUNT(*) as FamilyCount FROM Clients"
        If sWork = "" Then sWork = " WHERE "
        SQL += sWork
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfFacLessFamlies = rsWork!FamilyCount
        rsWork.Close()
        '
        ' Number of Military families
        '
        Dim NumberOfMilitary As Integer
        sWork = ThisWhere(Notes, False, False, "Military = True")
        SQL = "SELECT COUNT(*) as FamilyCount FROM Clients"
        If sWork = "" Then sWork = " WHERE "
        SQL += sWork
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        NumberOfMilitary = rsWork!FamilyCount
        rsWork.Close()
        '
        ' Count of famlies by size
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 1"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith1Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 2"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith2Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 3"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith3Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 4"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith4Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 5"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith5Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 6"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith6Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 7"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith7Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 8"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith8Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 9"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith9Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) = 10"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith10Member As Integer = rsWork!CountEm
        rsWork.Close()
        '
        SQL = "SELECT COUNT(*) As CountEm FROM Clients WHERE Active = True AND  (NumberOfAdults + NumberOfChildren) > 10"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim NumberOfFamiliesWith10PlusMember As Integer = rsWork!CountEm
        rsWork.Close()
        '
        ' Construct message
        '
        dB.Close()
        Dim TheMessage As String = "Count of families"
        If Notes <> "" Then TheMessage += " where NOTES contains '" & Notes & "'"
        TheMessage += " as of " & Format(Now, "MM/dd/yyyy") & "."
        TheMessage += vbCrLf & vbCrLf
        TheMessage += "TOTAL families: " & NumberOfFamliesActive + NumberOfFamliesInactive
        TheMessage += ", of which " & NumberOfFamliesActive & " are active, and " & NumberOfFamliesInactive & " are inactive."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamliesWithChildren & " families with children, and " & NumberOfFamliesWithoutChildren & " families with NO children."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFacLessFamlies & " FacLess families."
        If GetASetting("TrackMilitary", "False") = "True" Then
            TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfMilitary & " Military families."
        End If
        If Notes = "" Then TheMessage += vbCrLf & vbCrLf & NumberOfZeroFamlies & " families have a client number of 00000."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith1Member & " active families with 1 member."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith2Member & " active families with 2 members."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith3Member & " active families with 3 members."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith4Member & " active families with 4 members."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith5Member & " active families with 5 members."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith6Member & " active families with 6 members."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith7Member & " active families with 7 members."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith8Member & " active families with 8 members."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith9Member & " active families with 9 members."
        TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith10Member & " active families with 10 members."
        If NumberOfFamiliesWith10PlusMember <> 0 Then TheMessage += vbCrLf & vbCrLf & "There are " & NumberOfFamiliesWith10PlusMember & " active families with 10+ members."

        Clipboard.Clear()
        Clipboard.SetText(TheMessage)
        MsgBox(TheMessage, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Family counts, to print, start NotePad and press Ctrl-V")
    End Sub
    Function ThisWhere(ByVal NotesField As String, ByVal IncludeActive As Boolean, ByVal Active As Boolean, ByVal OtherWhere As String)
        Dim TheWhere As String = " "
        If NotesField <> "" Then TheWhere += "Notes LIKE '%" & NotesField & "%'"
        If IncludeActive Then
            If Trim(TheWhere) <> "" Then TheWhere += " AND "
            If Active Then
                TheWhere += "Active = True"
            Else
                TheWhere += "Active = False"
            End If

        End If
        If OtherWhere <> "" Then
            If Trim(TheWhere) <> "" Then
                TheWhere += " AND " & OtherWhere
            Else
                TheWhere = OtherWhere
            End If

        End If
        TheWhere = " WHERE " & TheWhere
        Return TheWhere
    End Function
    Private Sub mnuReportCounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportCounts.Click
        ShowCounts()
    End Sub
    Private Sub mnuFileRestoreVisitsFromBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileRestoreVisitsFromBackup.Click
        frmRestoreVisitsFromBackup.ShowDialog()
        frmRestoreVisitsFromBackup = Nothing
        frmRestoreVisitsFromBackup.Dispose()
    End Sub
    Private Sub btnDeleteTown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteTown.Click
        If cmbTown.SelectedIndex <> -1 Then
            Dim TheTown As String = cmbTown.Text
            If GetNumberOfClientsForTown(TheTown) = 0 Then
                Dim SQL As String = "DELETE FROM ZipCodes WHERE Town = '" & TheTown & "'"
                ExecuteSQLCommand(SQL)
                LoadTownComboBox(cmbTown)
            End If
        End If
    End Sub



    ' Private Sub tbApptTime_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tbApptTime.Validating
    '    If Len(tbApptTime.Text) = 0 Then
    '       e.Cancel = True
    '  End If
    '
    'End Sub




    Private Sub SomethingsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtZip.TextChanged, txtPhoneW.TextChanged, txtPhoneH.TextChanged, txtPhoneC.TextChanged, _
    txtOtherAdults.TextChanged, txtNotes.TextChanged, txtLastName.TextChanged, txtFirstName.TextChanged, _
    txtCaseNumber.TextChanged, txtAgesOfChildren.TextChanged, txtAddress2.TextChanged, _
    txtAddress.TextChanged, tbSpecialReq.TextChanged, tbFoodAllergies.TextChanged, _
    datStarted.ValueChanged, datReopened.ValueChanged, cmbTown.SelectedIndexChanged, _
    cmbNumberOfSeniors.SelectedIndexChanged, cmbNumberOfChildren.SelectedIndexChanged, _
    cmbNumberOfAdults.SelectedIndexChanged, chkWIC.CheckedChanged, chkSNAP.CheckedChanged, _
    chkRegistrationIsComplete.CheckedChanged, chkMilitary.CheckedChanged, chkHomeless.CheckedChanged, _
    chkDiabetic.CheckedChanged, chkDeaf.CheckedChanged, chkActive.CheckedChanged, _
    cbWelfare.CheckedChanged, cbTANF.CheckedChanged, cbSubsHousing.CheckedChanged, _
    cbOldAge.CheckedChanged, cbNoPork.CheckedChanged, cbNoCooking.CheckedChanged, _
    cbMedicaid.CheckedChanged, cbIncomeEligible.CheckedChanged, cbHeadStart.CheckedChanged, _
    cbFuelAsst.CheckedChanged, cbCSFP.CheckedChanged, cbAPTD.CheckedChanged, cbAidBlind.CheckedChanged, _
      cmbMaleAdults.SelectedIndexChanged, _
        cmbFemaleAdults.SelectedIndexChanged, _
        cmbMaleChildren.SelectedIndexChanged, _
        cmbFemaleChildren.SelectedIndexChanged, _
        cmbMaleSeniors.SelectedIndexChanged, _
        cmbFemaleSeniors.SelectedIndexChanged

    End Sub

    Private Sub lstOfVisits_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOfVisits.DoubleClick

        ' From Helmar 3/27/2015 - suppors pop up form to view/change visit information

        Dim sWork As String = lstOfVisits.Text
        'Dim iWork As String = InStr(sWork, ",")
        Dim iWork As String = InStr(Trim(sWork), " ")


        Dim ThisVisitDate = Trim(Strings.Left(sWork, iWork - 1))
        ThisVisitDate = Replace(ThisVisitDate, ",", "")

        Dim ThisNumberOfBags As Integer = 0
        Dim ThisDelivery As Boolean = False
        dB.Open()
        ' Dim SQL As String = "SELECT * FROM Visits WHERE CaseNumber = " & SelectedClientNumber _
        '    & " AND VisitDate BETWEEN #" & ThisVisitDate & " 12:00:00 AM" & "#" _
        '   & " AND #" & ThisVisitDate & " 11:59:59 PM" & "#"
        Dim SQL As String = "SELECT * FROM Visits WHERE CaseNumber = " & SelectedClientNumber _
           & " AND VisitDate BETWEEN #" & ThisVisitDate & " 12:00:00 AM" & "#" _
          & " AND #" & ThisVisitDate & " 11:59:59 PM" & "#"

        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        ThisNumberOfBags = rsWork!NumberOfBags
        ThisDelivery = rsWork!Delivery
        ThisVisitID = rsWork!ID
        rsWork.Close()
        dB.Close()
        frmVisit.ShowDialog()
        frmVisit = Nothing
        frmVisit.Dispose()
        LoadListOfVisitsForClient()
        ShowVisitsToday()
        ShowDeliveriesToday()
        txtSearchClientNumber.Focus()
    End Sub



    
End Class