Imports System.Data.OleDb
Imports System.IO

Public Class frmOpenTickets

    Dim Loading As Boolean = False
    Dim SQL As String = ""
    Dim SelectedVisitID As String = ""
    Dim SelectedVisitCaseNumber As String = ""
  
    Private Sub frmOpenTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dB = New OleDb.OleDbConnection(DSN)


        Dim sWork As String = GetASetting("AddBags", "0")
        'numAddBags.Value = CInt(sWork)
        LoadList()
        PrintTheTicket(False)

        'txtClientNumber.Focus()
    End Sub
    Sub LoadList()

        ' Visits left to record:

        SQL = "SELECT Count(*) AS CountEm FROM Visits WHERE NumberOfBags = 0" ' AND VisitDate = #" & Format(LastVisitDate, "MM/dd/yyyy") & "#"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        rsWork.Read()
        Dim iWork As Integer = rsWork!CountEm
        rsWork.Close()
        'lblVisitCount.Text = "Visits left to record: " & iWork.ToString

        Loading = True

        Dim LastVisitDate As Date = GetLastVisitDate()
        lvVisits.Items.Clear()
        'SQL = "SELECT * FROM Visits WHERE NumberOfBags = 0 AND VisitDate = #" & Format(LastVisitDate, "MM/dd/yyyy") & "#"
        SQL = "SELECT * FROM Visits WHERE NumberOfBags = 0" ' AND VisitDate = #" & Format(LastVisitDate, "MM/dd/yyyy") & "#"
        SQL += " ORDER BY Year(VisitDate), Month(visitDate), day(visitDate), ApptTime, CaseNumber"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        Dim ClientRows(4) As String     ' VisitID, PersonID, ClientName, Visit date, Appt Time
        'Dim myfont As New Font("Microsoft Sans Serif", FontStyle.Bold)
        While rsWork.Read
            ClientRows(0) = rsWork!ID.ToString
            ClientRows(1) = rsWork!CaseNumber.ToString
            ClientRows(2) = GetClientNameFromNumber(rsWork!CaseNumber)
            ClientRows(3) = Format(rsWork!VisitDate, "MM/dd")
            
            If IsDBNull(rsWork!ApptTime) Then
                ClientRows(4) = ""
            Else
                ClientRows(4) = Format(rsWork!ApptTime, "hh:mm tt")  ' added 2/28/15 DJH
            End If

            Dim NewClientRow As ListViewItem = New ListViewItem(ClientRows)
            If rsWork!Delivery Then
                NewClientRow.ForeColor = Color.DarkOrchid
                'NewClientRow.Font = myfont
            End If
            lvVisits.Items.Add(NewClientRow)


        End While
        rsWork.Close()
        dB.Close()
        lvVisits.SelectedItems.Clear()
        'grpBags.Enabled = False
        If lvVisits.Items.Count = 0 Then Me.Close()
        ' Loading = FalsentRow)


    End Sub
    Sub PrintTheTicket(Optional ByVal ForceIt As Boolean = False)
        Dim ShowMargins As Boolean = False
        PrintForm1.PrinterSettings.PrinterName = GetASetting("Printer")

        'If TestingMode Then
        '    PrintForm1.PrinterSettings.PrinterName = "Brother MFC-465CN Printer"
        'End If

        PrintForm1.PrinterSettings.DefaultPageSettings.PrinterResolution.Kind = Printing.PrinterResolutionKind.Medium
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 5
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0



        Dim NumberOfCopiesToPrint As Integer = CInt(GetASetting("NumberOfCopies", "1"))
        PrintForm1.Form.AutoSize = True
        PrintForm1.PrinterSettings.Copies = NumberOfCopiesToPrint
     
        'TopMargin = 10
        If CLA.LeftMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = CLA.LeftMargin : ShowMargins = True
        If CLA.RightMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = CLA.RightMargin : ShowMargins = True
        If CLA.TopMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = CLA.TopMargin : ShowMargins = True
        If CLA.BottomMargin <> -1 Then PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = CLA.BottomMargin : ShowMargins = True
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter     ' 2/13/15 DJH vcanuse prview also
        ' PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview

        Try
            PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
            'PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)
        Catch ex As Exception
            MsgBox("Unable to print form, the wrong printer has been specified.")
        End Try
        Me.Close()

    End Sub
End Class