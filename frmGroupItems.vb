Imports System.Data.OleDb
Public NotInheritable Class frmGroupItems
    Dim ErrorMessage As String
    Dim Loading As Boolean = False
    Dim Changed As Boolean = False
    Private Sub frmGroupItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DSN = "" Then    ' Only during debugging
            GetDBLocation()
            dB = New OleDb.OleDbConnection(DSN)
        End If
        LoadList()
        LoadItemTypes()
        Dim sWork As String = "To add a new group:"
        sWork += vbCrLf & vbCrLf & "1. Press 'Add New'"
        sWork += vbCrLf & vbCrLf & "2. Select the item type"
        sWork += vbCrLf & vbCrLf & "3. Type in the new name for the group."
        sWork += vbCrLf & vbCrLf & "4. Select the items that are to be members of this new group.  Use the Ctrl key to select multiple items."
        sWork += vbCrLf & vbCrLf & "5. Press 'Finish adding'"
        lblHelp.Text = sWork
    End Sub
    Sub LoadItemTypes()
        dB.Open()
        Dim SQL As String = "SELECT DISTINCT ItemType FROM Items ORDER BY ItemType"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        cmbItemType.Items.Clear()
        While rsWork.Read
            cmbItemType.Items.Add(rsWork!ItemType)
        End While
        rsWork.Close() : rsWork = Nothing
        dB.Close()
    End Sub
    Sub LoadList()
        Dim CurrentItemGroups(1) As String
        dB.Open()
        Dim SQL As String = "SELECT GroupName, ItemType FROM Groupings ORDER BY GroupName"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        lvExistingGroups.Items.Clear()
        While rsWork.Read
            CurrentItemGroups(0) = rsWork!GroupName
            CurrentItemGroups(1) = rsWork!ItemType
            Dim NewClientRow As ListViewItem = New ListViewItem(CurrentItemGroups)
            lvExistingGroups.Items.Add(NewClientRow)
        End While
        rsWork.Close() : rsWork = Nothing
        dB.Close()
    End Sub
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub


    Sub SetVis()
        If btnAddNew.Text = "Finish adding" Then
            ' Adding a new record
            btnCancel.Visible = True
            grpExistingGroups.Enabled = False
            grpNew.Visible = True
        Else
            If lvExistingGroups.SelectedItems.Count <> 0 Then
                btnDelete.Enabled = True
            Else
                btnDelete.Enabled = False
            End If
            grpExistingGroups.Enabled = True
            grpNew.Visible = False
            ' NOT adding a new record
            btnCancel.Visible = False
            If lvExistingGroups.SelectedItems.Count = 0 Then
                ' Nothing's selected
                btnCancel.Visible = False
                btnDelete.Visible = False
            Else
                ' Sombody's been selected
                btnCancel.Visible = False
                btnDelete.Visible = True

            End If

        End If

    End Sub

    Sub ClearForm()
        Loading = True
        txtNewGroupName.Text = ""
        Loading = False
    End Sub
    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim sWork As String = ""
        ErrorMessage = ""
        If btnAddNew.Text = "Add new" Then
            ' Begin the add process
            Loading = True
            ClearForm()
            cmbItemType.SelectedIndex = -1
            'lvItems.Items.Clear()
            Loading = False
            btnAddNew.Text = "Finish adding"
            SetVis()
        Else
            ' Finish adding
            If txtNewGroupName.Text = "" Then
                ErrorMessage = "You must enter a name for the new group!"
            End If
            If InStr(txtNewGroupName.Text, "'") <> 0 Or InStr(txtNewGroupName.Text, """") <> 0 Then
                ErrorMessage = "You can't use quotes in the group name!"
            Else
                If GroupNameExists(txtNewGroupName.Text) Then ErrorMessage = "That group already exists!"
            End If
            If lstOfItemsToIncludeInGroup.SelectedItems.Count < 2 Then
                ErrorMessage = "You must select at least two items to group!"
            End If
            If ErrorMessage = "" Then
                ' ToDo: Add the Group Item
                Dim SQL As String = "INSERT INTO Groupings (GroupName, ItemType, ORLocationHorizontal, GroupedItems) VALUES ("
                SQL += "'" & txtNewGroupName.Text & "'"
                SQL += ", '" & cmbItemType.Text & "'"
                SQL += ", " & optORHorizontal.Checked

                sWork = ""
                For iWork As Integer = 0 To lstOfItemsToIncludeInGroup.Items.Count - 1
                    If lstOfItemsToIncludeInGroup.GetSelected(iWork) Then
                        Dim ThisItemNumber As Integer = GetItemNumberFromNameAndType(lstOfItemsToIncludeInGroup.Items(iWork).ToString, cmbItemType.Text)
                        sWork += ThisItemNumber.ToString & vbTab
                    End If
                Next
                SQL += ", '" & sWork & "')"
                ExecuteSQLCommand(SQL)
                If ErrorMessage <> "" Then MsgBox(ErrorMessage)
                LoadList()
                ClearForm()
                btnAddNew.Text = "Add new"
                SetVis()
            Else
                MsgBox(ErrorMessage)
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        btnAddNew.Text = "Add new"
        ClearForm()
        lvExistingGroups.SelectedItems.Clear()
        Changed = False
        SetVis()
    End Sub
    Private Sub lvExistingGroups_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvExistingGroups.SelectedIndexChanged
        SetVis()
    End Sub

    Private Sub cmbItemType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItemType.Click

    End Sub


    Private Sub cmbItemType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItemType.SelectedIndexChanged
        dB.Open()
        Dim SQL As String = "SELECT ItemName FROM Items WHERE ItemType = '" & cmbItemType.Text & "' ORDER BY ItemName"
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        lstOfItemsToIncludeInGroup.Items.Clear()
        While rsWork.Read
            '
            ' ToDo: Make sure that this items isn't part of another group!
            '
            If Not ItemIsAlreadyAMemberOfAGroup(rsWork!ItemName, cmbItemType.Text) Then
                ' Now add the item
                lstOfItemsToIncludeInGroup.Items.Add(rsWork!ItemName)
            End If
        End While
        rsWork.Close() : rsWork = Nothing
        dB.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SelectedItemName As String = lvExistingGroups.SelectedItems(0).SubItems(0).Text
        If MsgBox("Are you sure that you want to delete group " & SelectedItemName & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim SQL As String = "DELETE FROM Groupings WHERE GroupName = '" & SelectedItemName & "'"
            ExecuteSQLCommand(SQL)
            LoadList()
            SetVis()
        End If
        'If lvItems.SelectedItems.Count = 0 Then Exit Sub ' This must be the deselection cycle mentioned above!
        'SelectedItemName = lvItems.SelectedItems(0).SubItems(0).Text
        'SelectedItemType = lvItems.SelectedItems(0).SubItems(1).Text
        'Dim SQL As String = "SELECT * FROM Items WHERE ItemName = '" & SanitizeTextForSQL(SelectedItemName) & "'"
        'SQL += " AND ItemType = '" & SelectedItemType & "'"
        'dB.Open()
        'Command = New OleDbCommand(SQL, dB)
        'rsWork = Command.ExecuteReader
        'If rsWork.Read Then
        '    Record2Form(rsWork)
        '    'Loading = True
        '    'txtName.Text = rsWork!ItemName
        '    'cmbType.Text = rsWork!ItemType
        '    'numLimit.Value = rsWork!Limit
        '    'chkAvailableToday.Checked = rsWork!Available
        '    'Loading = False
        'End If
        'rsWork.Close()
        'dB.Close()
        'Changed = False
        'SetVis()
    End Sub
End Class
