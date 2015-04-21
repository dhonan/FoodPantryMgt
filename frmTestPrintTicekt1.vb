Public Class frmTestPrintTicekt1

    Private Sub frmTestPrintTicekt1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet2.qryVisitsWithClientForPickTicket' table. You can move, or remove it, as needed.
        Me.qryVisitsWithClientForPickTicketTableAdapter.Fill(Me.Food_PantryDataSet2.qryVisitsWithClientForPickTicket)


        Me.PrintTicketFoodItemsTableAdapter.Fill(Me.Food_PantryDataSet.PrintTicketFoodItems)


        Me.Food_PantryDataSet2.Clients.DefaultView.RowFilter = "CaseNumber=0"
        Me.Food_PantryDataSet2.qryVisitsWithClientForPickTicket.DefaultView.RowFilter = "ID=0"

        
        Me.qryVisitsWithClientForPickTicketBindingSource.DataSource = Me.Food_PantryDataSet2.qryVisitsWithClientForPickTicket.DefaultView



      
        Me.ReportViewer1.RefreshReport()
    End Sub

    
End Class