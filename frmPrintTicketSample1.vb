Imports Microsoft.Reporting.WinForms


Public Class frmPrintTicketSample1

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        ' Disable the X close button
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub frmPrintTicketSample1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        'TODO: This line of code loads data into the 'Food_PantryDataSet2.qryVisitsWithClientForPickTicket' table. You can move, or remove it, as needed.
        Me.qryVisitsWithClientForPickTicketTableAdapter.Fill(Me.Food_PantryDataSet2.qryVisitsWithClientForPickTicket)


        Me.PrintTicketFoodItemsTableAdapter.Fill(Me.Food_PantryDataSet.PrintTicketFoodItems)


        Me.Food_PantryDataSet2.Clients.DefaultView.RowFilter = "CaseNumber=0"
        Me.Food_PantryDataSet2.qryVisitsWithClientForPickTicket.DefaultView.RowFilter = "ID=0"


        Me.qryVisitsWithClientForPickTicketBindingSource.DataSource = Me.Food_PantryDataSet2.qryVisitsWithClientForPickTicket.DefaultView

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent





        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Exit Sub
    End Sub
End Class