Imports Microsoft.Reporting.WinForms

Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet.PrintTicketFoodItems' table. You can move, or remove it, as needed.
        Me.PrintTicketFoodItemsTableAdapter.Fill(Me.Food_PantryDataSet.PrintTicketFoodItems)
        'TODO: This line of code loads data into the 'Food_PantryDataSet2.qryVisitsWithClientForPickTicket' table. You can move, or remove it, as needed.
        Me.qryVisitsWithClientForPickTicketTableAdapter.Fill(Me.Food_PantryDataSet2.qryVisitsWithClientForPickTicket)
        ' Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class