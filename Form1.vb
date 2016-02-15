Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet.PrintTicketFoodItems' table. You can move, or remove it, as needed.
        Me.PrintTicketFoodItemsTableAdapter.Fill(Me.Food_PantryDataSet.PrintTicketFoodItems)
        'TODO: This line of code loads data into the 'Food_PantryDataSet2.qryVisitsWithClientForPickTicket' table. You can move, or remove it, as needed.
        Me.qryVisitsWithClientForPickTicketTableAdapter.Fill(Me.Food_PantryDataSet2.qryVisitsWithClientForPickTicket)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class