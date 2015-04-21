Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet2.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.Food_PantryDataSet2.Clients)
        Me.Food_PantryDataSet2.Clients.DefaultView.RowFilter = "CaseNumber=421"
        Me.ClientsBindingSource.DataSource = Me.Food_PantryDataSet2.Clients.DefaultView
        ' Me.PrintTicketFoodItemsTableAdapter.Fill(Me.Food_PantryDataSet.PrintTicketFoodItems)



        Me.ReportViewer1.RefreshReport()
    End Sub
End Class