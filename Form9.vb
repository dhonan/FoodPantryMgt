Public Class Form9

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TA As New Food_PantryDataSet2TableAdapters.qryVisitsWithClientForPickTicketTableAdapter
        Dim TBL As New Food_PantryDataSet2.qryVisitsWithClientForPickTicketDataTable
        TBL = TA.GetDataByID(200)

        MsgBox(TBL.Rows.Count)

    End Sub
End Class