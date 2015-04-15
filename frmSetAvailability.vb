Imports System.Data.OleDb
Public Class frmSetAvailability
    Dim Changed As Boolean = False
    Dim Loading As Boolean = False
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        '
        ' Disable the X close button
        '
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property
    Private Sub frmSetAvailability_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Loading = True
        LoadAnItemComboBox(cmbItemsToShow, False)
        cmbItemsToShow.Items.Insert(0, "All")
        cmbItemsToShow.SelectedIndex = 0
        LoadList()
        If Debugger.IsAttached Then btnClear.Visible = True
        Loading = False
    End Sub
    Sub LoadList()
        ' 0 = Normal, 1 = Special, 2 = Fresh, 3 = Kids snacks, 4 = Personal care, 5 = Home, 6 = Food, 7 = Homeless
        Loading = True
        clbItems.Items.Clear()
        Dim SQL As String = "SELECT ID, ItemName, ItemType, Available FROM Items"
        If cmbItemsToShow.Text = "Available" Then
            SQL += " WHERE Available = True"
        ElseIf cmbItemsToShow.Text <> "All" Then
            SQL += " WHERE ItemType = '" & cmbItemsToShow.Text & "'"    ' USDA Frozen
        End If
        SQL += " ORDER BY ItemName"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            Dim sWork As String = rsWork!ItemName & "(" & rsWork!ItemType & ")"
            clbItems.Items.Add(sWork)
            clbItems.SetItemChecked(clbItems.Items.Count - 1, rsWork!Available)
        End While
        rsWork.Close()
        dB.Close()
        clbItems.SelectedItems.Clear()
        cmbItemsToShow.Enabled = False
        clbItems.Focus()
        cmbItemsToShow.Enabled = True
        Loading = False
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim sWork As String = cmbItemsToShow.Text
   
        If MsgBox("Are you sure you want to clear the availability for all " & sWork & " items", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ExecuteSQLCommand("UPDATE Items SET Available = False WHERE ItemType = '" & sWork & "'")
            LoadList()
            'For ThisItem As Integer = 0 To clbItems.Items.Count - 1
            '    Dim ThisCheckBoxItemName As String = clbItems.Items(ThisItem).ToString
            '    Dim iWork2 As Integer = InStr(ThisCheckBoxItemName, "(")
            '    Dim ItemName As String = Strings.Left(ThisCheckBoxItemName, iWork2 - 1)
            '    sWork = Strings.Mid(sWork, iWork2 + 1)
            '    Dim ItemType As String = Strings.Left(sWork, Len(sWork) - 1) '  Replace(Strings.Mid(sWork, iWork2 + 1), ")", "")
            'Next

        End If
    End Sub
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        'If Changed Then
        '    lblSaving.Visible = True
        '    lblSaving.Refresh()
        '    Me.Refresh()
        '    ' Update the available state for each item.
        '    For iWork As Integer = 0 To clbItems.Items.Count - 1
        '        Dim ItemName As String = clbItems.Items.Item(iWork).ToString
        '        Dim iWork2 As Integer = InStr(ItemName, "(")
        '        ItemName = Strings.Left(ItemName, iWork2 - 1)
        '        Dim bWork As Boolean = clbItems.GetItemCheckState(iWork)
        '        Dim SQL As String = "UPDATE ITEMS SET Available = " & bWork & " WHERE ItemName = '" & SanitizeTextForSQL(ItemName) & "'"
        '        Dim sWork As String = ExecuteSQLCommand(SQL)
        '        If sWork <> "" Then MsgBox(sWork)
        '    Next
        'End If
        Me.Close()
    End Sub
    Private Sub clbItems_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbItems.ItemCheck
        If Not Loading Then
            ' Update the item clicked.
            Dim iWork As Integer = e.Index
            Dim sWork As String = clbItems.Items.Item(iWork).ToString
            Dim iWork2 As Integer = InStr(sWork, "(")
            Dim ItemName As String = Strings.Left(sWork, iWork2 - 1)
            sWork = Strings.Mid(sWork, iWork2 + 1)

            Dim ItemType As String = Strings.Left(sWork, Len(sWork) - 1) '  Replace(Strings.Mid(sWork, iWork2 + 1), ")", "")
            Dim ItemAvailability As Boolean = e.NewValue
            Dim SQL As String = "UPDATE ITEMS SET Available = " & ItemAvailability.ToString & " WHERE ItemName = '" & ItemName & "' AND ItemType = '" & ItemType & "'"
            ExecuteSQLCommand(SQL)

            'Changed = True
            'btnDone.Text = "Save and finish"
        End If
    End Sub
    Private Sub cmbItemsToShow_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemsToShow.SelectedIndexChanged
        LoadList()
    End Sub
    Private Sub cmbItemsToShow_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbItemsToShow.MouseWheel
        ' The mouse wheel is very confusing...
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True

    End Sub

End Class