Public Class frmPrintSampleTicket

    Private Sub btnNeverMind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeverMind.Click
        Me.Close()
    End Sub

    Private Sub btnWith_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWith.Click
        frmMain.PrintFacLessSelections = True
        PrintTicket()
    End Sub

    Private Sub btnWithOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithOut.Click
        frmMain.PrintFacLessSelections = False
        PrintTicket()
    End Sub
    Sub PrintTicket()
        'frmMain.SelectedClientNumber = 0
        'frmMain.SelectedClientName = ""
        'frmMain.PrintSample = True
        Me.Visible = False
        frmPrintTickets.ShowDialog()
        frmPrintTickets = Nothing
        frmPrintTickets.Dispose()
        Me.Close()
        'frmMain.PrintSample = False
    End Sub
End Class