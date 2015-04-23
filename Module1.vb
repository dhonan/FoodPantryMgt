'https://msdn.microsoft.com/en-us/library/ms252091(v=vs.90).aspx



Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms



Public Class TicketPrint
    Implements IDisposable
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    Private VisitID As Integer




    Private Function LoadFoodData() As DataTable
        ' Create a new DataSet and read sales data file 
        ' data.xml into the first DataTable.

        'Dim dataSet As New DataSet()
        'dataSet.ReadXml("..\..\data.xml")
        'Return dataSet.Tables(0)

        'Dim DataSet2 As New DataSet()

        Dim TA As New Food_PantryDataSetTableAdapters.PrintTicketFoodItemsTableAdapter
        'Dim TA As New Food_PantryDataSetTableAdapters.ClientsTableAdapter
        Return TA.GetData()

    End Function

    Private Function LoadVisitData() As DataTable
        ' Create a new DataSet and read sales data file 


        Dim TA As New Food_PantryDataSet2TableAdapters.qryVisitsWithClientForPickTicketTableAdapter
        Dim Tbl As New Food_PantryDataSet2.qryVisitsWithClientForPickTicketDataTable

        Tbl = TA.GetDataByID(VisitID)
        Return Tbl


        'TA.GetData()

        'Dim TA As New Food_PantryDataSetTableAdapters.ClientsTableAdapter
        'Return TA.GetDataByID(VisitID)

        'Return TA.GetData()

    End Function




    ' Routine to provide to the report renderer, in order to
    ' save an image for each page of the report.
    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        m_streams.Add(stream)
        Return stream
    End Function

    ' Export the given report as an EMF (Enhanced Metafile) file.
    Private Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String = "<DeviceInfo>" & _
            "<OutputFormat>EMF</OutputFormat>" & _
            "<PageWidth>8.5in</PageWidth>" & _
            "<PageHeight>11in</PageHeight>" & _
            "<MarginTop>0.25in</MarginTop>" & _
            "<MarginLeft>0.25in</MarginLeft>" & _
            "<MarginRight>0.25in</MarginRight>" & _
            "<MarginBottom>0.25in</MarginBottom>" & _
            "</DeviceInfo>"
        Dim warnings As Warning()
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        For Each stream As Stream In m_streams
            stream.Position = 0
        Next
    End Sub

    ' Handler for PrintPageEvents
    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

        ' Adjust rectangular area with printer margins.
        Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX), _
                                          ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY), _
                                          ev.PageBounds.Width, _
                                          ev.PageBounds.Height)

        ' Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

        ' Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect)

        ' Prepare for the next page. Make sure we haven't hit the end.
        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub Print()
        If m_streams Is Nothing OrElse m_streams.Count = 0 Then
            Throw New Exception("Error: no stream to print.")
        End If
        Dim printDoc As New PrintDocument()
        If Not printDoc.PrinterSettings.IsValid Then
            Throw New Exception("Error: cannot find the default printer.")
        Else
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            m_currentPageIndex = 0
            printDoc.Print()
        End If
    End Sub

    ' Create a local report for Report.rdlc, load the data,
    ' export the report to an .emf file, and print it.
    Private Sub Run(ByVal ID As Integer)
        Dim report As New LocalReport()
        VisitID = ID

        'report.ReportPath = "..\..\PrintTicket2.rdlc"  ' test
        report.ReportPath = "PrintTicket2.rdlc"   


        'report.ClientsTableAdapter.Fill(Me.Food_PantryDataSet.Clients)

        'report.DataSources.Add(New ReportDataSource("Sales", LoadSalesData()))
        'report.DataSources.Clear()
        'report.DataSources.Add(New ReportDataSource("Clients", LoadSalesData()))
        ' report.DataSources.Add(New ReportDataSource("Food_PantryDataSet", LoadSalesData()))


        'report.DataSources.Add(New ReportDataSource("Clients", GetReportData()))
        'report.DataSources.Add(New ReportDataSource("Food_PantryDataSet.Clients", GetReportData()))
        'report.DataSources.Add(New ReportDataSource("Food_PantryDataSet", GetReportData()))
        'WORKED report.DataSources.Add(New ReportDataSource("Food_PantryDataSet_Clients", LoadSalesData()))
        report.DataSources.Add(New ReportDataSource("Food_PantryDataSet_PrintTicketFoodItems", LoadFoodData()))
        report.DataSources.Add(New ReportDataSource("Food_PantryDataSet2_qryVisitsWithClientForPickTicket", LoadVisitData()))


        Export(report)
        Print()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If m_streams IsNot Nothing Then
            For Each stream As Stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub

    Public Shared Sub Main(ByVal args As String())
        Using TicketPrint As New TicketPrint()
            TicketPrint.Run(args(0))

        End Using

    End Sub
End Class


