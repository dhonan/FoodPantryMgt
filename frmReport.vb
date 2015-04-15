Imports System.Data.OleDb
Imports System.IO
Public Class frmReport
    Dim ClientsThatHaveRestarted As ArrayList = New ArrayList
    'Dim FromDate As Date
    'Dim ToDate As Date
    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DSN = "" Then    ' Only during debugging
            GetDBLocation()
            dB = New OleDb.OleDbConnection(DSN)
        End If
        'CalculateFromAndToDates()
        'optVisitsLastWeek.Text += " - " & Format(FromDate, "dddd MMMM d") & " through " & Format(ToDate, "dddd MMMM d")
        datFrom.Value = CDate(VisitedThisWeekStartDate)
        datTo.Value = Now
        optVisitsLastWeek.Text = "Latest week (" & Format(CDate(VisitedThisWeekStartDate), "MM/dd") & " through " & Format(CDate(VisitedThisWeekEndDate), "MM/dd") & ")"
        'optVisitsLastWeek.Text += " - " & Format(GetLastVisitDate, "MM/dd/yyyy")
        LoadListOfTowns()
        lstOfTowns.SetSelected(0, True)
        chkActiveToInactive.Text += " - " & GetASetting("InactiveToActiveMonths", "3") & " months since last visit."
        'LoadListOfRestarts()
    End Sub
    Sub CalculateFromAndToDates()
        'ToDate = GetLastVisitDate()
        'Dim DayOfTheWork = ToDate.DayOfWeek
        'Dim AdjustDays As Integer
        'Select Case ToDate.DayOfWeek.ToString
        '    Case "Wednesday" : AdjustDays = 0
        '    Case "Thursday" : AdjustDays = 1
        '    Case "Friday" : AdjustDays = 2
        '    Case "Saturday" : AdjustDays = 3
        '    Case "Sunday" : AdjustDays = 4
        '    Case "Monday" : AdjustDays = 5
        '    Case "Tuesday" : AdjustDays = 6
        'End Select
        'FromDate = DateAdd(DateInterval.Day, -AdjustDays, ToDate)
    End Sub
    Sub LoadListOfRestarts()
        'Dim SQL As String = ""
        'SQL = "SELECT Clients.CaseNumber"
        'SQL += " FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber "
        'SQL += GetSelectionWhere(True)
        '' "SELECT Clients.CaseNumber FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber WHERE Visits.VisitDate = #11/26/2013#"

        'dB.Open()
        'Command = New OleDbCommand(SQL, dB)
        'rsWork = Command.ExecuteReader
        'While rsWork.Read
        '    If ClientsThatHaveRestarted.BinarySearch(rsWork!CaseNumber.ToString) < 1 Then
        '        ' Add the client
        '        ClientsThatHaveRestarted.Add(rsWork!CaseNumber)
        '        ClientsThatHaveRestarted.Sort()
        '    End If
        'End While
        'rsWork.Close()
        'dB.Close()
    End Sub
    Sub LoadListOfTowns()
        Dim dbWasOpen As Boolean = dBIsOpen() : If Not dbWasOpen Then dB.Open()
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        SQL += "SELECT DISTINCT Town FROM Clients WHERE Town <> '' ORDER BY Town"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        lstOfTowns.Items.Add("<All>")
        While rsWork.Read
            lstOfTowns.Items.Add(rsWork!Town)
        End While
        rsWork.Close() : rsWork = Nothing
        If Not dbWasOpen Then dB.Close()
    End Sub
    Private Sub optVisitsLastWeek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVisitsLastWeek.CheckedChanged
        grpDateRange.Visible = False
    End Sub
    Private Sub optDateRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDateRange.CheckedChanged
        grpDateRange.Visible = True
    End Sub
    Function GetSelectionWhere(ByVal IncludeVisits As Boolean) As String
        Dim Where As String = "" ' "WHERE Visits.VisitDate "
        Dim sWork As String = ""
        If optDateRange.Checked Then
            ' Specific date range selected
            If datFrom.Value > datTo.Value Then
                MsgBox("Sorry, the to date must be greater than the from date!")
            Else
                '     Public VisitedToday As String = "VisitDate BETWEEN #" & Now.ToString("d") & " 12:00:01 AM# AND #" & Now.ToString("d") & " 11:59:59 PM#"
                Where = "WHERE Visits.VisitDate BETWEEN #" & Format(datFrom.Value, "MM/dd/yyyy") & " 12:00:00 AM# AND #" & Format(datTo.Value, "MM/dd/yyyy") & " 11:59:59 PM#"
            End If
        Else
            ' Last week selected.  Use the previous Wednesday through the following Tuesday
            'Dim ToDateS As String = "#" & Format(ToDate, "MM/dd/yyyy") & " 11:59:59 PM#"
            'Dim FromDateS As String = "#" & Format(FromDate, "MM/dd/yyyy") & " 12:00:00 AM#"

            'Where = "WHERE Visits.VisitDate Between " & FromDateS & " AND " & ToDateS
            Where = "WHERE Visits.VisitDate Between #" & VisitedThisWeekStartDate & "# AND #" & VisitedThisWeekEndDate & "#"
        End If
        ' 
        ' Now process towns
        '
        If lstOfTowns.SelectedItems.Count = 1 And lstOfTowns.SelectedIndex = 0 Then
            ' <All> is selected, do nothing
        Else
            Dim ListOfTowns As String = ""
            sWork = "Town IN("
            For iWork As Integer = 0 To lstOfTowns.SelectedItems.Count - 1
                If lstOfTowns.SelectedItems(iWork).ToString <> "<All>" Then
                    If ListOfTowns <> "" Then ListOfTowns += ", "
                    ListOfTowns += "'" & lstOfTowns.SelectedItems(iWork).ToString & "'"
                End If
            Next
            Where += " AND Town IN(" & ListOfTowns & ")"
        End If
        '
        ' Now process other criteria
        '
        If txtNotes.Text <> "" Then Where += " AND Notes LIKE '%" & SanitizeTextForSQL(txtNotes.Text) & "%'"
        If chkOnlyHomeless.Checked Then Where += " AND HomeLess = True"
        If chkOnlySeniors.Checked Then Where += " AND NumberOfSeniors > 0"
        If chkOnlyActive.Checked Then Where += " AND Active = True"
        If chkActiveToInactive.Checked And IncludeVisits Then
            Dim TodaysDate As String = Format(Now, "MM, dd, yyyy")
            'If TestingMode Then TodaysDate = "01/01/2020"
            Where += " AND DATEDIFF('m', VisitDate, #" & TodaysDate & "#) > " & GetASetting("InactiveToActiveMonths", "3")   ' & NumberOfMonthsToInactive.ToString
            ' DATEDIFF("m", VisitDate, #12/2/2014#) > 3
        End If
        If chkOnlyFamliesWithChildren.Checked Then Where += " AND NumberOfChildren > 0"
        Return Where
    End Function
    Sub AddARow(ByVal Town As String, ByVal Visits As Integer, ByVal Vets As Integer, ByVal Adults As Integer, ByVal Seniors As Integer, ByVal Children As Integer, ByVal Bags As Integer, ByVal InactiveToActive As Integer)
        Dim CountRows(9) As String
        Dim NewClientRow As ListViewItem
        Dim iWork As Integer = 0
        CountRows(0) = Town
        CountRows(1) = Visits.ToString
        CountRows(2) = Vets.ToString
        CountRows(3) = Adults.ToString
        CountRows(4) = Seniors.ToString
        CountRows(5) = Children.ToString
        CountRows(6) = (Adults + Children).ToString
        CountRows(7) = Bags.ToString
        CountRows(8) = InactiveToActive.ToString
        CountRows(9) = Vets.ToString
        iWork = lvVisits.Columns.Count
        NewClientRow = New ListViewItem(CountRows)
        lvVisits.Items.Add(NewClientRow)
    End Sub
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
    Function OnlyRestartedRequestedAndHasRestarted(ByVal ClientNumber As Integer) As Boolean
        ' NumberOfMonthsToInactive
        If ClientsThatHaveRestarted.BinarySearch(ClientNumber) >= 0 Then Return True Else Return False
    End Function
    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        ' If date range is select, make sure that they're valid.
        'Dim Where As String = GetSelectionWhere() ' "WHERE Visits.VisitDate "
        Dim iWork As Integer = 0
        Dim sWork As String = ""
        Dim GrandTotalVisits As Integer = 0
        Dim GrandTotalAdults As Integer = 0
        Dim GrandTotalSeniors As Integer = 0
        Dim GrandTotalChildren As Integer = 0
        Dim GrandTotalBags As Integer = 0
        Dim GrandTotalInactiveToActive As Integer = 0
        Dim GrandTotalVets As Integer = 0
        Dim TownNames As ArrayList = New ArrayList
        Dim TotalAdults As Integer = 0
        Dim TotalChildren As Integer = 0
        Dim TotalSeniors As Integer = 0
        Dim TotalNew As Integer = 0
        Dim TotalVets As Integer = 0   ' DJH 3/7/15

        Dim TotalInactiveToActive As Integer = 0
        Dim SQL As String = ""
        GrandTotalBags = 0
        dB.Open()
        Dim LeftToDo As Integer = 6
        lblCountDown.Visible = True
        'LeftToDo -= 1 : lblCountDown.Text = LeftToDo.ToString : Me.Refresh()
        '
        ' Show visits by hour
        '
        lvByHour.Items.Clear()
        SQL = "SELECT * FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber "
        SQL += GetSelectionWhere(False)
        ' SQL += " ORDER BY VisitDate"
        SQL += " Order By ApptTime"

        Dim HourCount(0 To 24) As Integer
        Dim FirstHourIndex As Integer = -1
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            Dim TheHour As String
            If IsDBNull(rsWork!ApptTime) Then
                TheHour = ""
            Else
                TheHour = Format(rsWork!ApptTime, "HH")
            End If


            iWork = Val(TheHour)
            HourCount(iWork) += 1
            If FirstHourIndex = -1 Then FirstHourIndex = iWork
        End While

        rsWork.Close()
        If FirstHourIndex <> -1 Then
            '
            ' Find the Last hour indewx
            '
            Dim LastHourIndex As Integer = -1
            For iWork = 24 To FirstHourIndex Step -1
                If HourCount(iWork) <> 0 Then
                    LastHourIndex = iWork
                    Exit For
                End If
            Next
            For iWork = FirstHourIndex To LastHourIndex
                If HourCount(iWork) <> 0 Then
                    sWork = HourCount(iWork).ToString
                    Dim sWork2 As String = ""
                    If iWork < 13 Then
                        sWork2 = iWork.ToString & "am"
                    Else
                        sWork2 = (iWork - 12).ToString & "pm"
                    End If
                    Dim lvString(1) As String
                    lvString(0) = sWork2
                    lvString(1) = sWork

                    Dim lvItem As ListViewItem = New ListViewItem(lvString)
                    lvByHour.Items.Add(lvItem)

                End If

            Next
        End If
        '
        ' Retrieve Total visits and total bags
        '
        'LeftToDo -= 1 : lblCountDown.Text = LeftToDo.ToString : Me.Refresh()
        SQL = "SELECT Count(*) AS CountEm, SUM(NumberOfBags) AS TotalBags"
        SQL += " FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber "
        SQL += GetSelectionWhere(True)
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        lblTotalVisits.Text = "Total visits: " & rsWork!CountEm.ToString
        GrandTotalVisits = rsWork!CountEm
        lblBags.Text = "Total bags: " & rsWork!TotalBags.ToString
        rsWork.Close()
        '
        ' Retrieve Number new that time period
        '
        LeftToDo -= 1 : lblCountDown.Text = LeftToDo.ToString : Me.Refresh()
        SQL = "SELECT COUNT(*) AS CountEm FROM Clients "
        SQL += Replace(GetSelectionWhere(False), "Visits.VisitDate", "Clients.DateStarted")
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read() Then
            If Not IsDBNull(rsWork!CountEm) Then
                TotalNew = rsWork!CountEm
            Else
                TotalNew = "None"
            End If
        End If
        rsWork.Close()
        If TotalNew = 0 Then
            lblNumberNew.Text = "New: None"
        Else
            lblNumberNew.Text = "New: " & TotalNew
        End If


        '
        ' Retrieve Number that went from inactive to active in this time period
        '

        '
        ' Retrieve Total adults and children
        '
        'LeftToDo -= 1 : lblCountDown.Text = LeftToDo.ToString : Me.Refresh()
        SQL = "SELECT Sum([NumberOfAdults]) AS TotalAdults, Sum([NumberOfChildren]) AS TotalChildren"
        SQL += ", Sum([NumberOfSeniors]) AS TotalSeniors"
        SQL += ", sum(iif(Military,1,0))as TotalVets"
        SQL += " FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber"
        SQL += " " & GetSelectionWhere(True)
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        TotalAdults = 0
        TotalSeniors = 0
        TotalChildren = 0
        lvVisits.Items.Clear()
        If rsWork.Read() Then
            If Not IsDBNull(rsWork!TotalAdults) And Not IsDBNull(rsWork!TotalChildren) And Not IsDBNull(rsWork!TotalSeniors) Then
                GrandTotalAdults = rsWork!TotalAdults
                GrandTotalSeniors = rsWork!TotalSeniors
                GrandTotalChildren = rsWork!TotalChildren
                GrandTotalVets = rsWork!TotalVets
            End If
        End If
        rsWork.Close()
        lblNumberOfAdults.Text = "Total adults: " & GrandTotalAdults.ToString
        lblNumberOfChildren.Text = "Total children: " & GrandTotalChildren.ToString
        lblNumberOfSeniors.Text = "Total seniors: " & GrandTotalSeniors.ToString
        '
        ' Get all of the town names
        '
        LeftToDo -= 1 : lblCountDown.Text = LeftToDo.ToString : Me.Refresh()
        SQL = "SELECT DISTINCT Town FROM Clients ORDER BY Town"

        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            If rsWork!Town <> "" Then TownNames.Add(rsWork!Town)
            'TownNames.Add(rsWork!Town)
        End While
        rsWork.Close()
        '
        ' For each town, count up the number of visits, adults, and children, and then add it to the list
        '
        'LeftToDo -= 1 : lblCountDown.Text = LeftToDo.ToString : Me.Refresh()
        LeftToDo = TownNames.Count
        For ThisTown As Integer = 0 To TownNames.Count - 1
            lblCountDown.Visible = True
            LeftToDo -= 1 : lblCountDown.Text = LeftToDo.ToString : Me.Refresh()
            '
            ' Count total visits seperately
            '
            Dim ThisTownName As String = TownNames(ThisTown).ToString
            Dim ThisTownTotalVisits As Integer = 0
            'If ThisTownName = "Kittery" Then Stop
            SQL = "SELECT Count(*) AS CountEm"
            SQL += " FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber "
            SQL += GetSelectionWhere(True)
            SQL += " AND Clients.Town='" & ThisTownName & "'"
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            rsWork.Read()
            ThisTownTotalVisits = rsWork!CountEm
            rsWork.Close()
            '
            ' Retrieve Total adults and children
            '
            SQL = "SELECT Clients.NumberOfAdults, Clients.NumberOfChildren, Clients.NumberOfSeniors, " _
                & "Clients.CaseNumber, Clients.FirstName, Clients.LastName, Clients.Military"
            SQL += " FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber "
            SQL += GetSelectionWhere(True)
            SQL += " AND Clients.Town='" & ThisTownName & "'"
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            TotalAdults = 0
            TotalSeniors = 0
            TotalChildren = 0
            TotalVets = 0
            ' 
            While rsWork.Read
                TotalAdults += rsWork!NumberOfAdults
                TotalSeniors += rsWork!NumberOfSeniors
                TotalChildren += rsWork!NumberOfChildren
                If rsWork!Military Then
                    TotalVets = TotalVets + 1
                End If

                If IsThisClientAReOpen(rsWork!CaseNumber, rsWork!FirstName & " " & rsWork!LastName) Then
                    TotalInactiveToActive += 1
                End If
            End While
            rsWork.Close()

            '
            ' Now count visits, and load up the list view
            '
            SQL = "SELECT SUM(Clients.NumberOfAdults) AS TotalAdults, SUM(Clients.NumberOfSeniors) AS TotalSeniors, SUM(Clients.NumberOfChildren) AS TotalChildren, SUM(Visits.NumberOfBags) AS TotalBags"
            SQL += " FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber "
            SQL += GetSelectionWhere(True)
            SQL += " AND Clients.Town='" & ThisTownName & "'"
            Command = New OleDbCommand(SQL, dB)
            rsWork = Command.ExecuteReader
            If rsWork.Read() Then
                'If Not IsDBNull(rsWork!TotalBags) Then
                '    iWork = rsWork!TotalBags
                'Else
                '    iWork = 0
                'End If
                iWork = N2Z(rsWork!TotalBags)
                'If TestingMode And TownNames(ThisTown) = "Kittery" Then Stop
                'If iWork <> 0 And (ThisTownTotalVisits + TotalAdults + TotalChildren + TotalInactiveToActive <> 0) Then
                If (ThisTownTotalVisits + TotalAdults + TotalChildren) <> 0 Then ' + TotalInactiveToActive <> 0) Then
                    AddARow(TownNames(ThisTown), ThisTownTotalVisits, TotalVets, TotalAdults, TotalSeniors, TotalChildren, iWork, 0)

                    GrandTotalBags += iWork
                    GrandTotalInactiveToActive += TotalInactiveToActive
                End If

            End If

        Next
        If GrandTotalInactiveToActive = 0 Then
            lblInactiveToActive.Text = "Reactivated: None"
        Else
            lblInactiveToActive.Text = "Reactivated: " & GrandTotalInactiveToActive
        End If
        '
        ' Count up the deliveries for this period
        '
        SQL = "SELECT Delivery FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber "
        SQL += GetSelectionWhere(True)
        SQL += " AND Delivery = True"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        iWork = 0
        While rsWork.Read
            iWork += 1
        End While
        If iWork > 0 Then
            lblDeliveries.Text = "Deliveries: " & iWork.ToString
        Else
            lblDeliveries.Text = "Deliveries: None"
        End If
        dB.Close()
        If lvByHour.Items.Count > 0 Then grpVisitsByHour.Visible = True


        ' 
        ' Add the "Total" row
        AddARow("== Total ==", GrandTotalVisits, GrandTotalVets, GrandTotalAdults, _
               GrandTotalSeniors, GrandTotalChildren, GrandTotalBags, GrandTotalInactiveToActive)

        grpReport.Visible = True
        'End If
        btnPrint.Enabled = True
        lblCountDown.Visible = False
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim ShowMargins As Boolean = False
        CLA.RightMargin = 0
        If CLA.LeftMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = CLA.LeftMargin : ShowMargins = True
        If CLA.RightMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = CLA.RightMargin : ShowMargins = True
        If CLA.TopMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = CLA.TopMargin : ShowMargins = True
        If CLA.BottomMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = CLA.BottomMargin : ShowMargins = True
        'grpVisits.Visible = False
        Dim SaveColor As System.Drawing.Color = Me.BackColor
        Me.BackColor = Color.White
        ' commented out DJH 3/19/15
        ' If TestingMode Then
        'PrintForm1.PrinterSettings.PrinterName = "Brother MFC-465CN Printer"
        'Else
        'PrintForm1.PrinterSettings.PrinterName = GetASetting("Printer")
        'End If
        If TestingMode Or CLA.ReportPrintPreview Then PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        pnlButtons.Visible = False

        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        pnlButtons.Visible = True
        Me.BackColor = SaveColor
        'grpVisits.Visible = True
    End Sub
    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        'Dim Where As String = GetSelectionWhere()
        Dim FileName As String = TheDirectory & "Visits.txt"
        'Dim FileNameB As String = TheDirectory & "Visits.dat"
        Dim TheLine As String = ""
        'Dim TheLineB As String = ""
        ' http://whatilearnttuday.blogspot.com/2011/10/write-text-files-without-byte-order.html
        ' https://www.google.com/search?q=vb.net+write+text+file+without+bom&ie=utf-8&oe=utf-8&aq=t&rls=org.mozilla:en-US:official&client=firefox-a

        If File.Exists(FileName) Then File.Delete(FileName)

        ' Open the output file and write the header line
        Dim OutputFile As String = TheDirectory & "Visits.txt"
        If File.Exists(OutputFile) Then File.Delete(OutputFile)
        'Dim ExtractFile As System.IO.TextWriter
        'ExtractFile = My.Computer.FileSystem.OpenTextFileWriter(OutputFile, True)
        TheLine = "Date" & vbTab & "Client number" & vbTab & "Client name" & vbTab & "Town" & vbTab & "Date Started"
        TheLine += vbTab & "FacLess" & vbTab & "Diabetic"
        TheLine += vbTab & "Adults" & vbTab & "Seniors" & vbTab & "Children" & vbTab & "Bags"
        'ExtractFile.WriteLine(TheLine)
        File.WriteAllText(FileName, TheLine)
        'TheLineB = TheLine & vbCrLf
        'ExtractFile.Close()
        'Stop
        Dim SQL As String = "SELECT Visits.CaseNumber, Visits.VisitDate, Visits.NumberOfBags, Clients.FirstName, Clients.LastName, Clients.Town, Clients.DateStarted, Clients.NumberOfAdults, Clients.NumberOfSeniors, Clients.NumberOfChildren, Clients.HomeLess, Clients.Diabetic, Clients.Senior"
        SQL += " FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber "
        SQL += GetSelectionWhere(True)
        SQL += " ORDER BY LastName, FirstName"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            TheLine = Format(rsWork!VisitDate, "MM/dd/yyyy")
            TheLine += vbTab & rsWork!CaseNumber
            TheLine += vbTab & rsWork!FirstName & " " & rsWork!LastName
            TheLine += vbTab & rsWork!Town
            TheLine += vbTab & Format(rsWork!DateStarted, "MM/dd/yyyy")
            TheLine += vbTab & rsWork!Homeless.ToString
            TheLine += vbTab & rsWork!Diabetic.ToString
            TheLine += vbTab & rsWork!NumberOfAdults
            TheLine += vbTab & rsWork!NumberOfSeniors
            TheLine += vbTab & rsWork!NumberOfChildren
            TheLine += vbTab & rsWork!NumberOfBags
            'ExtractFile.WriteLine(TheLine)
            File.AppendAllText(FileName, Environment.NewLine & TheLine)
            'TheLineB += TheLine & vbCrLf
        End While
        rsWork.Close()
        'ExtractFile.Close()

        dB.Close()
        MsgBox("Ok, " & OutputFile & " has been created.")


    End Sub


End Class