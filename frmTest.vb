Imports System.Data.OleDb
Public Class frmTest

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DSN = "" Then    ' Only during debugging
            GetDBLocation()
            dB = New OleDb.OleDbConnection(DSN)
        End If
        dB.Open()
        LoadListOfPaperSlips(True)
        LoadListOfVisitsRecordedInDB(True)
        dB.Close()
        lblNumberOfPaperSlips.Text = lstOfPaperSlips.Items.Count
        lblNumberOfVisitsInDB.Text = lstOfVisitsinDB.Items.Count
        SearchListOfPaperSlipsWithoutADBEntry()
        SearchListOfDBEntriesWithoutPaperSlips()
    End Sub
    Sub SearchListOfPaperSlipsWithoutADBEntry()
        Dim ThisDBEntryPerson As String = ""
        Dim ThisPaperSlipPerson As String = ""
        Dim FoundIt As Boolean = False
        For ThisPaperSlip As Integer = 0 To lstOfPaperSlips.Items.Count - 1
            ThisPaperSlipPerson = lstOfPaperSlips.Items(ThisPaperSlip).ToString
            FoundIt = False
            For ThisDBEntry As Integer = 0 To lstOfVisitsinDB.Items.Count - 1
                ThisDBEntryPerson = lstOfVisitsinDB.Items(ThisDBEntry).ToString
                If ThisPaperSlipPerson = ThisDBEntryPerson Then
                    FoundIt = True
                    Exit For
                End If
            Next
            If Not FoundIt Then
                lstOfProblems.Items.Add(ThisPaperSlipPerson & " has no entry recorded in the Visits table")
            End If
        Next
    End Sub
    Sub SearchListOfDBEntriesWithoutPaperSlips()
        Dim ThisDBEntryPerson As String = ""
        Dim ThisPaperSlipPerson As String = ""
        Dim FoundIt As Boolean = False
        For ThisDBEntry As Integer = 0 To lstOfVisitsinDB.Items.Count - 1
            ThisDBEntryPerson = lstOfVisitsinDB.Items(ThisDBEntry).ToString
            FoundIt = False
            For ThisPaperSlip As Integer = 0 To lstOfPaperSlips.Items.Count - 1
                ThisPaperSlipPerson = lstOfPaperSlips.Items(ThisPaperSlip).ToString
                If ThisPaperSlipPerson = ThisDBEntryPerson Then
                    FoundIt = True
                    Exit For
                End If
            Next
            If Not FoundIt Then
                lstOfProblems.Items.Add(ThisDBEntryPerson & " has no paper slip")
            End If
        Next

    End Sub
    Sub LoadListOfPaperSlips(Optional ByVal LoadALLSlips As Boolean = False)
        ' Check for slips that are recorded (an entry in "112613"), but there's no recorded visit for it (an entry in "Visits")
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        Dim ListIt As Boolean = False
        SQL += "SELECT ClientNumber FROM 112613 ORDER BY ClientNumber"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            lstOfPaperSlips.Items.Add(rsWork!ClientNumber)
            'ListIt = False
            'If LoadALLSlips Then
            '    ListIt = True
            'Else
            '    If Not SlipExistsForRecordedVisits(rsWork!ClientNumber) Then
            '        ListIt = True
            '    End If
            'End If
            'If ListIt Then lstOfPaperSlips.Items.Add(rsWork!ClientNumber)
        End While
        rsWork.Close() : rsWork = Nothing

    End Sub
    Sub LoadListOfVisitsRecordedInDB(Optional ByVal LoadALLVisits As Boolean = False)
        ' Check for visits recorded (an entry in "Visits"), but there's no slip for it (an entry in "112613")
        Dim rsWork As OleDbDataReader
        Dim SQL As String = ""
        Dim ListIt As Boolean = False
        SQL += "SELECT CaseNumber FROM Visits WHERE VisitDate = #11/26/13# ORDER BY CaseNumber"
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            lstOfVisitsinDB.Items.Add(rsWork!CaseNumber)

        End While
        rsWork.Close() : rsWork = Nothing

    End Sub
    Function SlipExistsForRecordedVisits(ByVal ClientNumber As Integer) As Boolean
        Dim rsWork As OleDbDataReader
        Dim FoundIt As Boolean = False
        Dim SQL As String = ""
        SQL += "SELECT ClientNumber FROM 112613 WHERE ClientNumber = " & ClientNumber
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            FoundIt = True
        End If
        rsWork.Close() : rsWork = Nothing
        Return FoundIt

    End Function
    Function VisitExistsInVisitTable(ByVal ClientNumber As Integer) As Boolean
        Dim rsWork As OleDbDataReader
        Dim FoundIt As Boolean = False
        Dim SQL As String = ""
        SQL += "SELECT CaseNumber FROM Visits WHERE VisitDate = #11/26/13# And CaseNumber = " & ClientNumber
        Dim sWork As String = ""
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            FoundIt = True
        End If
        rsWork.Close() : rsWork = Nothing
        Return FoundIt
    End Function
End Class