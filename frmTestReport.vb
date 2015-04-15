Public Class frmTestReport

    Private Sub frmTestReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.Food_PantryDataSet.Clients)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class