Imports System.Data.OleDb
Public Class frmVisit
    Dim Loading As Boolean = False
    Private Sub frmVisit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dB.Open()
        Dim SQL As String = "SELECT * FROM Visits WHERE ID = " & frmMain.ThisVisitID
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Loading = True
        lblClientName.Text = frmMain.SelectedClientName
        datVisitDate.Value = rsWork!VisitDate
        numNumberOfBags.Value = rsWork!NumberOfBags
        chkDelivery.Checked = rsWork!Delivery
        rsWork.Close()
        dB.Close()
        Loading = False
    End Sub
    Private Sub SomethingsBeenChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datVisitDate.ValueChanged, numNumberOfBags.ValueChanged, chkDelivery.Click
        If Not Loading Then btnUpdateAndDone.Visible = True
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateAndDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateAndDone.Click
        Dim SQL As String = "UPDATE Visits SET "
        SQL += "VisitDate = #" & Format(datVisitDate.Value, "MM/dd/yyyy") & "#"
        SQL += ", NumberOfBags = " & numNumberOfBags.Value
        SQL += ", Delivery = " & chkDelivery.Checked
        SQL += " WHERE ID = " & frmMain.ThisVisitID
        ExecuteSQLCommand(SQL)
        Me.Close()
    End Sub
End Class