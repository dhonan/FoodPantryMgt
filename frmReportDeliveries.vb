Imports System.Data.OleDb
Public Class frmReportDeliveries
    Dim CurrentListBox As ListBox = ListBox1

    Private Sub frmReportDeliveries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Command As OleDbCommand
        Dim rsWork As OleDbDataReader
        Dim CurrentListBoxNumber As Integer = 1
        Dim NumberOfDeliveriesToday As Integer = 0
        Dim VisitDate As String = GetASetting("VisitDate", "")
        Dim NumberPrinted As Integer = 0
        If VisitDate = "" Then VisitDate = Now.ToString("d")
        lblDeliveries.Text = "Deliveries for " & VisitDate
        Dim SQL As String = "SELECT CaseNumber FROM Visits WHERE Delivery = True AND " 'VisitDate = #" & VisitDate & "#"
        SQL += VisitedThisWeekSQL
        'SQL = "SELECT TOP 25 CaseNumber FROM Visits"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            NumberPrinted += 1
            Select Case NumberPrinted
                Case 0 To 10
                    CurrentListBox = ListBox1
                Case 11 To 21
                    CurrentListBox = ListBox2
                Case Else
                    CurrentListBox = ListBox3
            End Select
            PrintADeliveryAddress(rsWork!CaseNumber)

        End While

        rsWork.Close()
        dB.Close()
        PrintForm1.PrinterSettings.PrinterName = GetASetting("Printer")
        ' commented out DJH 3/19/15
        'If TestingMode Then
        'PrintForm1.PrinterSettings.PrinterName = "Brother MFC-J4510DW Printer"
        'PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        'End If
        PrintForm1.PrinterSettings.DefaultPageSettings.PrinterResolution.Kind = Printing.PrinterResolutionKind.High
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0

        'TopMargin = 10
        If CLA.LeftMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = CLA.LeftMargin
        If CLA.RightMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = CLA.RightMargin
        If CLA.TopMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = CLA.TopMargin
        If CLA.BottomMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = CLA.BottomMargin
        Try
            PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Catch ex As Exception
            MsgBox("Unable to print form, the wrong printer has been specified.")
        End Try


        Me.Close()
    End Sub
    Sub PrintADeliveryAddress(ByVal CaseNumber As Integer)
        Dim SQL As String = "SELECT * FROM Clients WHERE CaseNumber = " & CaseNumber
        Dim Command As OleDbCommand = New OleDbCommand(SQL, dB)
        Dim rsWork As OleDbDataReader = Command.ExecuteReader
        rsWork.Read()
        CurrentListBox.Items.Add("Client number " & rsWork!CaseNumber & " - " & rsWork!FirstName & " " & rsWork!LastName)
        CurrentListBox.Items.Add(rsWork!Address & "; " & rsWork!Address2)
        Dim sWork As String = rsWork!Town & "; "
        If Not IsDBNull(rsWork!PhoneH) AndAlso rsWork!PhoneH <> "" Then sWork += rsWork!PhoneH
        If Not IsDBNull(rsWork!PhoneC) AndAlso rsWork!PhoneC <> "" Then sWork += " " & rsWork!PhoneC
        CurrentListBox.Items.Add(sWork)
        CurrentListBox.Items.Add("--------------------------------------------------------------------")
        rsWork.Close()
    End Sub
End Class