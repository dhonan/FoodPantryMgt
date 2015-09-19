Imports System.Data.OleDb
Imports System.IO
Public Class frmRecordBags
    Dim Loading As Boolean = False
    Dim SQL As String = ""
    Dim SelectedVisitID As String = ""
    Dim SelectedVisitCaseNumber As String = ""
    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    ' Disable the X close button
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        Const CS_DBLCLKS As Int32 = &H8
    '        Const CS_NOCLOSE As Int32 = &H200
    '        cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
    '        Return cp
    '    End Get
    'End Property
    Private Sub RecordBags_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Debugger.IsAttached Then
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterScreen
        Else
            'btnTest.Visible = False
        End If
        Dim sWork As String = GetASetting("AddBags", "0")
        numAddBags.Value = CInt(sWork)
        LoadList()
        txtClientNumber.Focus()
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
        lblVisitCount.Text = "Visits left to record: " & iWork.ToString

        Loading = True

        Dim LastVisitDate As Date = GetLastVisitDate()
        lvVisits.Items.Clear()
        'SQL = "SELECT * FROM Visits WHERE NumberOfBags = 0 AND VisitDate = #" & Format(LastVisitDate, "MM/dd/yyyy") & "#"
        SQL = "SELECT * FROM Visits WHERE NumberOfBags = 0" ' AND VisitDate = #" & Format(LastVisitDate, "MM/dd/yyyy") & "#"
        SQL += " ORDER BY Year(VisitDate), Month(visitDate), day(visitDate), ApptTime, CaseNumber" ' 3/7/15 DJH

        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        Dim ClientRows(5) As String     ' VisitID, PersonID, ClientName, Visit date, Appt Time
        'Dim myfont As New Font("Microsoft Sans Serif", FontStyle.Bold)
        While rsWork.Read
            ClientRows(0) = rsWork!ID.ToString
            ClientRows(1) = rsWork!CaseNumber.ToString
            ClientRows(2) = GetClientNameFromNumber(rsWork!CaseNumber)
            ClientRows(3) = Format(rsWork!VisitDate, "MM/dd")
            ' Added delivery indicator DJH 9/18/15
            If rsWork!Delivery Then
                ClientRows(5) = "X"
            Else
                ClientRows(5) = ""
            End If



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
        grpBags.Enabled = False
        If lvVisits.Items.Count = 0 Then Me.Close()
        Loading = False
    End Sub
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
    Private Sub lvVisits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvVisits.SelectedIndexChanged
        If Not Loading Then
            Dim lvi As ListViewItem
            For Each lvi In lvVisits.SelectedItems
                SelectedVisitID = lvi.SubItems(0).Text
                SelectedVisitCaseNumber = lvi.SubItems(1).Text
                '    'Dim SelectedVisitID As String = lvi.Text
                '    Dim SQL As String = "UPDATE Visits SET NumberOfBags = " & Bags.ToString & " WHERE ID = " & SelectedVisitID
                '    'ExecuteSQLCommand(SQL)
            Next
            grpBags.Enabled = True
        End If
    End Sub
    Sub UpdateVisit(ByVal Bags As Integer)
        Dim SQL As String = "UPDATE Visits SET NumberOfBags = " & Bags + numAddBags.Value.ToString & " WHERE ID = " & SelectedVisitID
        'Dim lvi As ListViewItem
        'For Each lvi In lvVisits.SelectedItems
        '    'Dim SelectedVisitID As String = lvi.Text
        '    Dim SQL As String = "UPDATE Visits SET NumberOfBags = " & Bags.ToString & " WHERE ID = " & SelectedVisitID
        '    'ExecuteSQLCommand(SQL)
        'Next



        ExecuteSQLCommand(SQL)
        LoadList()
        txtClientNumber.Enabled = True
        lblClientName.Text = ""
        txtClientNumber.Text = ""
        txtClientNumber.Focus()

    End Sub
    Private Sub btnBags1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags1.Click
        UpdateVisit(1)
    End Sub
    Private Sub btnBags2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags2.Click
        UpdateVisit(2)
    End Sub
    Private Sub btnBags3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags3.Click
        UpdateVisit(3)
    End Sub
    Private Sub btnBags4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags4.Click
        UpdateVisit(4)
    End Sub
    Private Sub btnBags5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags5.Click
        UpdateVisit(5)
    End Sub
    Private Sub btnBags6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags6.Click
        UpdateVisit(6)
    End Sub
    Private Sub btnBags7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags7.Click
        UpdateVisit(7)
    End Sub
    Private Sub btnBags8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags8.Click
        UpdateVisit(8)
    End Sub
    Private Sub btnBags9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags9.Click
        UpdateVisit(9)
    End Sub
    Private Sub btnBags10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBags10.Click
        UpdateVisit(10)
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim Where As String = GetSelectionWhere()

        '3/7/15 DJH - to print form not make it an excel spread sheet

        frmOpenTickets.ShowDialog()
        frmOpenTickets = Nothing
        frmOpenTickets.Dispose()
        Exit Sub

        Dim sWork As String = ""
        Dim FileName As String = TheDirectory & "Visits today.txt"
        Dim TheLine As String = ""
        If File.Exists(FileName) Then File.Delete(FileName)
        ' Open the output file and write the header line
        Dim objWriter As New System.IO.StreamWriter(FileName, False)
        'TheLine = "Client #" & vbTab & "Client name" & vbTab & vbTab & vbTab & "Delivery"
        TheLine = "Client #" & vbTab & "Client name" & vbTab & vbTab & vbTab & "Appt Time" _
           & vbTab & "Delivery"
        objWriter.WriteLine(TheLine)
        objWriter.WriteLine("")

        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            TheLine = rsWork!CaseNumber.ToString
            TheLine += vbTab & GetClientNameFromNumber(rsWork!CaseNumber)
            Dim sWork2 As String = rsWork!Delivery.ToString

            If IsDBNull(rsWork!ApptTime) Then
                TheLine += vbTab & vbTab & vbTab & ""
            Else
                TheLine += vbTab & vbTab & vbTab & Format(rsWork!ApptTime, "hh:mm tt")
            End If

            If sWork2 = "False" Then
                sWork = ""
            Else
                sWork = "Delivery"
            End If
            TheLine += vbTab & vbTab & vbTab & sWork
            objWriter.WriteLine(TheLine)


            


        End While
        rsWork.Close()
        dB.Close()
        objWriter.Close()

        sWork = GetASetting("ProgramToLaunch", "Nothing")
        If sWork <> "Nothing" Then
            Process.Start(sWork & ".EXE", Chr(34) & FileName & Chr(34))
        Else
            MsgBox("Ok, '" & FileName & "' has been created.")
        End If


    End Sub

    Private Sub txtClientNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientNumber.TextChanged
        lblClientName.Text = ""
        Dim iWork As Integer = 0
        Dim ThisClientNumber As String = ""
        Dim ThisVisitID As String = ""
        Dim FoundClient As Boolean = False
        If Len(txtClientNumber.Text) = 6 Then
            ' Find this client in the list.
            For iWork = 0 To lvVisits.Items.Count - 1
                ThisVisitID = lvVisits.Items(iWork).SubItems(0).Text
                ThisClientNumber = lvVisits.Items(iWork).SubItems(1).Text
                'Dim ThisClientName As String = lvVisits.Items(iWork).SubItems(1).Text
                If Val(ThisClientNumber) = Val(txtClientNumber.Text) Then
                    ' Got the client!
                    Loading = True
                    txtClientNumber.Enabled = False
                    SelectedVisitID = ThisVisitID
                    SelectedVisitCaseNumber = ThisClientNumber
                    lvVisits.SelectedItems.Clear()
                    lvVisits.Items(iWork).Selected = True
                    lvVisits.Items(iWork).EnsureVisible()
                    lblClientName.Text = GetClientNameFromNumber(SelectedVisitCaseNumber)
                    'lvVisits.Items(iWork).EnsureVisible()
                    grpBags.Enabled = True
                    Loading = False
                    FoundClient = True
                    Exit For
                End If
            Next
            If Not FoundClient Then
                lblClientName.Text = "No visits"
            End If
            'Dim sWork As String = """" & ThisClientNumber & """"
            'lvVisits.Items(sWork).Selected = True
        End If
    End Sub

    'Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
    '    grpVisits.Visible = True
    '    lvVisits.SelectedItems.Clear()
    '    lvVisits.Items(9).Focused = True
    '    lvVisits.Items(9).Selected = True
    '    lvVisits.Refresh()
    'End Sub

    Private Sub chkShowClientList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowClientList.CheckedChanged
        Dim bWork As Boolean = False
        If chkShowClientList.Checked Then bWork = True
        grpVisits.Visible = bWork


    End Sub
    Private Sub numAddBags_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numAddBags.ValueChanged
        SaveASetting("AddBags", numAddBags.Value.ToString)
    End Sub

    Private Sub grpVisits_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpVisits.Enter

    End Sub
End Class