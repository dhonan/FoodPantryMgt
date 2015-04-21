Imports System.Data.OleDb

Public Class Form10

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQL As String
        dB.Open()

        SQL = "INSERT INTO Visits (CaseNumber, VisitDate, ApptTime, NumberOfBags, Delivery) " _
             & "VALUES(6, #4/18/2015#, #9:00:00 AM#, 0, 0)"

        ExecuteSQLCommand(SQL)
        dB.Close()
        rsWork.Close()
        dB.Close()
        SQL = "select max(Id) as LastId from Visits where caseNumber=6"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim VisitID As Integer = rsWork!LastId
        dB.Close()

        MsgBox("last=" & VisitID)

        Dim ta As New Food_PantryDataSet2TableAdapters.qryVisitsWithClientForPickTicketTableAdapter


        Dim tbl As New Food_PantryDataSet2.qryVisitsWithClientForPickTicketDataTable
        ta.Fill(tbl)

        'ta.FillByID(tbl, VisitID)





        tbl = ta.GetDataByID(VisitID - 1)
        MsgBox("ID=" & VisitID & " rows=" & tbl.Rows.Count)


    End Sub
End Class