Imports System.Data.OleDb
Imports System.IO

Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Imaging

Imports System

Imports System.Data
Imports System.Text
Imports System.Drawing

Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms


Public Class Form1
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    'https://msdn.microsoft.com/en-us/library/ms252091.aspx

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet.PrintTicketFoodItems' table. You can move, or remove it, as needed.
        Me.PrintTicketFoodItemsTableAdapter.Fill(Me.Food_PantryDataSet.PrintTicketFoodItems)
        'TODO: This line of code loads data into the 'Food_PantryDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.Food_PantryDataSet.Clients)

        'Me.ReportViewer1.RefreshReport()

        Dim report As New LocalReport()
        report.ReportPath = "..\..\Report1.rdlc"
        'report.DataSources.Add(New ReportDataSource("Sales", LoadSalesData()))


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

    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        m_streams.Add(stream)
        Return stream
    End Function

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
End Class