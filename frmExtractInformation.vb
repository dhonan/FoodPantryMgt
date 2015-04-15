Imports System.Data.OleDb
Imports System.IO
Public Class frmExtractInformation
    Dim CurrentMonthOrWeek As Integer = 0
    Dim CurrentTown As String = ""

    Dim TotalAdultsForTown As Integer = 0
    Dim TotalChildrenForTown As Integer = 0
    Dim TotalClientsForTown As Integer = 0
    Dim TotalHomelessForTown As Integer = 0
    Dim TotalSeniorsForTown As Integer = 0
    Dim TotalDiabeticsForTown As Integer = 0
    Dim TotalBagsForTown As Integer = 0
    Dim TotalNewClientForTown As Integer = 0
    Dim TotalReOpenClientForTown As Integer = 0
    Dim TotalDeliveriesForTown As Integer = 0
    Dim TotalVetsForTown As Integer = 0


    Dim TotalAdultsForMonthOrWeek As Integer = 0
    Dim TotalChildrenForMonthOrWeek As Integer = 0
    Dim TotalClientsForMonthOrWeek As Integer = 0
    Dim TotalHomelessForMonthOrWeek As Integer = 0
    Dim TotalSeniorsForMonthOrWeek As Integer = 0
    Dim TotalDiabeticsForMonthOrWeek As Integer = 0
    Dim TotalBagsForMonthOrWeek As Integer = 0
    Dim TotalNewClientForMonthOrWeek As Integer = 0
    Dim TotalReOpenClientForMonthOrWeek As Integer = 0
    Dim TotalDeliveriesForMonthOrWeek As Integer = 0
    Dim TotalVetsForMonthOrWeek As Integer = 0

    Dim GrandTotalAdults As Integer = 0
    Dim GrandTotalChildren As Integer = 0
    Dim GrandTotalClients As Integer = 0
    Dim GrandTotalHomeless As Integer = 0
    Dim GrandTotalSeniors As Integer = 0
    Dim GrandTotalDiabetics As Integer = 0
    Dim GrandTotalBags As Integer = 0
    Dim GrandTotalNewClient As Integer = 0
    Dim GrandTotalReOpenClient As Integer = 0
    Dim GrandTotalDeliveries As Integer = 0
    Dim GrandTotalVets As Integer = 0


    Private Sub frmExtractInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DSN = "" Then    ' Only during debugging
            GetDBLocation()
            dB = New OleDb.OleDbConnection(DSN)
        End If
        LoadComboBox()
    End Sub
    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        Dim TheLine As String = ""
        Dim sWork As String = ""
        Dim RecordsRead As Integer = 0
        Dim OutputFileName As String = ""
        If optByMonth.Checked Then
            OutputFileName = "Monthly "
        Else
            OutputFileName = "Weekly "
        End If
        OutputFileName += "visits during " & cmbCalendarYear.Text & ".txt"
        Dim objWriter As New System.IO.StreamWriter(TheDirectory & OutputFileName, False)
        TheLine = "Total for "
        If optByMonth.Checked Then
            TheLine += "Month"
        Else
            TheLine += "Week"
        End If
        TheLine += vbTab & "Town" & vbTab & "Adults" & vbTab & "Children" & vbTab & "Clients" & vbTab & "Homeless" & vbTab & "Seniors" & vbTab & "Diabetics" & vbTab & "Bags"
        TheLine += vbTab & "Deliveries" & vbTab & "ReOpen" & vbTab & "New"
        objWriter.WriteLine(TheLine)
        objWriter.WriteLine("")
        Dim SQL As String = ""
        SQL = "SELECT Visits.VisitDate, Visits.NumberOfBags, Visits.Delivery"
        SQL += ", Clients.CaseNumber, Clients.FirstName, Clients.LastName, Clients.Town, Clients.NumberOfAdults, Clients.NumberOfChildren, Clients.NumberOfSeniors, Clients.NumberOfSeniors, Clients.Diabetic, Clients.Homeless, Clients.DateStarted"
        SQL += " FROM Visits INNER JOIN Clients ON Visits.CaseNumber = Clients.CaseNumber"
        If optByCalendarYear.Checked Then
            SQL += " WHERE YEAR(VisitDate) = " & cmbCalendarYear.Text
        Else
            SQL += " WHERE VisitDate BETWEEN #" & Format(datRangeFrom.Value, "MM/dd/yyyy") & "# AND #" & Format(datRangeTo.Value, "MM/dd/yyyy") & "#"
        End If
        If optByMonth.Checked Then
            SQL += " ORDER BY MONTH(Visits.VisitDate), Clients.Town"
        Else
            SQL += " ORDER BY Visits.VisitDate, Clients.Town"
        End If
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read()
            Dim ThisRecordMonthOrWeek As Integer = Val(Format(rsWork!VisitDate, "MM"))
            Dim ThisRecordWeek As Integer = DatePart(DateInterval.WeekOfYear, rsWork!VisitDate, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
            If ThisRecordWeek = 53 Then ThisRecordWeek = 52 ' Doesn't work right for December 31st....
            'If ThisRecordWeek = 53 Then Stop
            If optByWeek.Checked Then ThisRecordMonthOrWeek = ThisRecordWeek
            If RecordsRead = 0 Then
                CurrentMonthOrWeek = ThisRecordMonthOrWeek
                CurrentTown = rsWork!Town
            End If
            RecordsRead += 1
            If CurrentMonthOrWeek = ThisRecordMonthOrWeek Then
                '
                ' Same month or week, check for new town
                '
                If rsWork!Town <> CurrentTown Then
                    ' Same month or week, new town, write out town totals, add town totals to month totals, and reset town totals
                    PrintTownTotals(objWriter)
                    CurrentTown = rsWork!Town
                End If
            Else
                '
                ' Put out a total line for this town and month/week
                '
                PrintMonthOrWeekTotals(objWriter)
                CurrentMonthOrWeek = ThisRecordMonthOrWeek
                CurrentTown = rsWork!Town

            End If
            AccumulateTownTotals(rsWork)
        End While
        PrintGrandTotals(objWriter)
        rsWork.Close()
        dB.Close()
        objWriter.Close()
        sWork = GetASetting("ProgramToLaunch", "Nothing")
        If sWork <> "Nothing" Then
            Process.Start(sWork & ".EXE", Chr(34) & TheDirectory & OutputFileName & Chr(34))
        Else
            MsgBox("Ok, '" & TheDirectory & OutputFileName & "' has been created.")
        End If
        Me.Close()
    End Sub
    Sub AccumulateTownTotals(ByVal rsWork As OleDbDataReader)
        ' Accumulate TOWN totals
        ' rsWork = SELECT Visits.VisitDate, Visits.NumberOfBags, Clients.CaseNumber, Clients.Town, Clients.NumberOfAdults, Clients.NumberOfChildren, Clients.NumberOfSeniors, Clients.Senior, Clients.Diabetic, Clients.Homeless
        TotalAdultsForTown += rsWork!NumberOfAdults

        TotalChildrenForTown += rsWork!NumberOfChildren
        TotalClientsForTown += 1
        If rsWork!Diabetic Then TotalDiabeticsForTown += 1
        If rsWork!Homeless Then TotalHomelessForTown += 1
        TotalSeniorsForTown += rsWork!NumberOfSeniors
        TotalBagsForTown += rsWork!NumberOfBags
        If rsWork!Delivery Then TotalDeliveriesForTown += 1
        ' Determine whether this client is new ????????????????????????????????????????????????????????????????????????????????????
        If rsWork!DateStarted = rsWork!VisitDate Then TotalNewClientForTown += 1
        ' Determine whether this client is ReOpened
        Dim sWork As String = rsWork!FirstName & " " & rsWork!LastName
        'Dim FirstName As String = ""
        'Dim LastName As String = ""
        'FirstNameLastNameFromClientName(sWork, FirstName, LastName)
        If IsThisClientAReOpen(rsWork!CaseNumber, sWork) Then TotalReOpenClientForTown += 1

    End Sub
    Sub PrintGrandTotals(ByRef objWriter As System.IO.StreamWriter)
        Dim TheLine As String = ""
        PrintMonthOrWeekTotals(objWriter)
        TheLine = "Grand totals" & vbTab & ""
        TheLine += vbTab & GrandTotalAdults.ToString
        TheLine += vbTab & GrandTotalChildren.ToString
        TheLine += vbTab & GrandTotalClients.ToString
        TheLine += vbTab & GrandTotalHomeless.ToString
        TheLine += vbTab & GrandTotalSeniors.ToString
        TheLine += vbTab & GrandTotalDiabetics.ToString
        TheLine += vbTab & GrandTotalBags.ToString
        TheLine += vbTab & GrandTotalReOpenClient.ToString
        TheLine += vbTab & GrandTotalNewClient.ToString
        TheLine += vbTab & GrandTotalVets.ToString
        objWriter.WriteLine(TheLine)
    End Sub
    Sub PrintMonthOrWeekTotals(ByRef objWriter As System.IO.StreamWriter)
        Dim TheLine As String = ""
        '
        ' First, do the town totals
        '
        PrintTownTotals(objWriter)
        '
        ' Now do the Month totals
        '
        If optByMonth.Checked Then
            TheLine = MonthName(CurrentMonthOrWeek)
        Else
            TheLine = "Week: " & CurrentMonthOrWeek.ToString
        End If
        'TheLine += vbTab & "Town" & vbTab & "Adults" & vbTab & "Children" & vbTab & "Clients" & vbTab & "Homeless" & vbTab & "Seniors" & vbTab & "Bags"
        'TheLine += vbTab & "ReOpen" & vbTab & "New"

        TheLine += vbTab & ""   ' Town
        TheLine += vbTab & TotalAdultsForMonthOrWeek.ToString
        TheLine += vbTab & TotalChildrenForMonthOrWeek.ToString
        TheLine += vbTab & TotalClientsForMonthOrWeek.ToString
        TheLine += vbTab & TotalHomelessForMonthOrWeek.ToString
        TheLine += vbTab & TotalSeniorsForMonthOrWeek.ToString
        TheLine += vbTab & TotalDiabeticsForMonthOrWeek.ToString
        TheLine += vbTab & TotalBagsForMonthOrWeek.ToString
        TheLine += vbTab & TotalDeliveriesForMonthOrWeek.ToString
        TheLine += vbTab & TotalReOpenClientForMonthOrWeek.ToString
        TheLine += vbTab & TotalNewClientForMonthOrWeek.ToString
        TheLine += vbTab & TotalVetsForMonthOrWeek.ToString

        objWriter.WriteLine(TheLine)
        objWriter.WriteLine("")

        '
        ' Now, accumulate the Grand totals
        '
        GrandTotalAdults += TotalAdultsForMonthOrWeek
        GrandTotalChildren += TotalChildrenForMonthOrWeek
        GrandTotalClients += TotalClientsForMonthOrWeek
        GrandTotalHomeless += TotalHomelessForMonthOrWeek
        GrandTotalSeniors += TotalSeniorsForMonthOrWeek
        GrandTotalDiabetics += TotalDiabeticsForMonthOrWeek
        GrandTotalBags += TotalBagsForMonthOrWeek
        GrandTotalDeliveries += TotalDeliveriesForMonthOrWeek
        GrandTotalReOpenClient += TotalReOpenClientForMonthOrWeek
        GrandTotalNewClient += TotalNewClientForMonthOrWeek
        GrandTotalVets += TotalVetsForMonthOrWeek
        '
        ' Reset month/week totals
        '
        TotalAdultsForMonthOrWeek = 0
        TotalChildrenForMonthOrWeek = 0
        TotalClientsForMonthOrWeek = 0
        TotalHomelessForMonthOrWeek = 0
        TotalSeniorsForMonthOrWeek = 0
        TotalDiabeticsForMonthOrWeek = 0
        TotalBagsForMonthOrWeek = 0
        TotalDeliveriesForMonthOrWeek = 0
        TotalReOpenClientForMonthOrWeek = 0
        TotalNewClientForMonthOrWeek = 0
        TotalVetsForMonthOrWeek = 0

    End Sub
    Sub PrintTownTotals(ByRef objWriter As System.IO.StreamWriter)
        Dim TheLine As String = ""
        TheLine = "" & vbTab & CurrentTown
        TheLine += vbTab & TotalAdultsForTown.ToString
        TheLine += vbTab & TotalChildrenForTown.ToString
        TheLine += vbTab & TotalClientsForTown.ToString
        TheLine += vbTab & TotalHomelessForTown.ToString
        TheLine += vbTab & TotalSeniorsForTown.ToString
        TheLine += vbTab & TotalDiabeticsForTown.ToString
        TheLine += vbTab & TotalBagsForTown.ToString
        TheLine += vbTab & TotalDeliveriesForTown.ToString
        TheLine += vbTab & TotalReOpenClientForTown
        TheLine += vbTab & TotalNewClientForTown
        TheLine += vbTab & TotalVetsForTown
        objWriter.WriteLine(TheLine)
        '
        ' Add town totals to month totals
        '
        TotalAdultsForMonthOrWeek += TotalAdultsForTown
        TotalChildrenForMonthOrWeek += TotalChildrenForTown
        TotalClientsForMonthOrWeek += TotalClientsForTown
        TotalHomelessForMonthOrWeek += TotalHomelessForTown
        TotalSeniorsForMonthOrWeek += TotalSeniorsForTown
        TotalDiabeticsForMonthOrWeek += TotalDiabeticsForTown
        TotalBagsForMonthOrWeek += TotalBagsForTown
        TotalDeliveriesForMonthOrWeek += TotalDeliveriesForTown
        TotalReOpenClientForMonthOrWeek += TotalReOpenClientForTown
        TotalNewClientForMonthOrWeek += TotalNewClientForTown
        TotalVetsForMonthOrWeek += TotalVetsForTown

        '
        ' Now, reset the town totals
        '
        TotalAdultsForTown = 0
        TotalChildrenForTown = 0
        TotalClientsForTown = 0
        TotalHomelessForTown = 0
        TotalSeniorsForTown = 0
        TotalDiabeticsForTown = 0
        TotalBagsForTown = 0
        TotalDeliveriesForTown = 0
        TotalReOpenClientForTown = 0
        TotalNewClientForTown = 0
        TotalVetsForTown = 0

    End Sub
    Sub LoadComboBox()
        Dim SQL As String = ""
        SQL = "SELECT DISTINCT YEAR(VisitDate) AS TheYear FROM Visits ORDER BY YEAR(VisitDate) DESC"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read()
            cmbCalendarYear.Items.Add(rsWork!TheYear)
        End While
        rsWork.Close()
        dB.Close()
        cmbCalendarYear.SelectedIndex = 0
    End Sub
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
    Private Sub DateRange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optByCalendarYear.CheckedChanged, optDateRange.CheckedChanged
        Dim TrueFalse As Boolean = False
        If optDateRange.Checked Then TrueFalse = True
        lblRangeFrom.Visible = TrueFalse
        lblRangeTo.Visible = TrueFalse
        datRangeFrom.Visible = TrueFalse
        datRangeTo.Visible = TrueFalse
        lblCalendarYear.Visible = Not TrueFalse
        cmbCalendarYear.Visible = Not TrueFalse
    End Sub
End Class