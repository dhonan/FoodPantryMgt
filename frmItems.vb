
Imports System.Data.OleDb
Public Class frmItems
    Dim Loading As Boolean = True
    Dim Changed As Boolean = False
    Dim SortByName As Boolean = True
    Dim SelectedItemName As String = ""
    Dim SelectedItemType As String = ""
    Dim ErrorMessage As String = ""
    Dim TheItem As AnItem
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
    Private Sub frmItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lvItems.Columns.Add("Name", 100, HorizontalAlignment.Left)
        'lvItems.Columns.Add("Type", 50, HorizontalAlignment.Left)
        'If TestingMode Then
        '    Me.WindowState = FormWindowState.Normal
        '    Me.StartPosition = FormStartPosition.CenterParent
        'End If

        If DSN = "" Then    ' Only during debugging
            GetDBLocation()
            dB = New OleDb.OleDbConnection(DSN)
        End If
        'lvItems.Columns.Add("Item", 50, HorizontalAlignment.Left)
        'lvItems.Columns.Add("Type", 150, HorizontalAlignment.Left)
        Loading = True
        LoadComboBoxes()
        cmbItemsToShow.SelectedIndex = 0
        LoadList()
        'pnlItem.Text = "Whooppee"
        Loading = False
        SetVis()
    End Sub
    Sub LoadComboBoxes()
        LoadAnItemComboBox(cmbItemsToShow, True)
        cmbItemsToShow.Items.Insert(0, "All")
        LoadAnItemComboBox(cmbType, True)

        'cmbItemsToShow.Items.Clear()
        'cmbType.Items.Clear()
        'cmbItemsToShow.Items.Add(GetASetting("LabelForFoodBox", "Food"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForHomeBox", "Home"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForColdBox", "Cold"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForColdSpecialsBox", "Cold specials"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForLimitOf3Items", "Limit of 3 items"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForFreshBox", "Fresh"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForSpecialsBox", "Specials"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForColdPickOnly2Box", "Cold(2 only)"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForLimitOf4ItemsBox", "Limit of 4 items"))
        'cmbItemsToShow.Items.Add(GetASetting("LabelForOtherItemsBox", "Other items"))
        '' Now copy 'em to the other combo box.
        'For iWork As Integer = 0 To cmbItemsToShow.Items.Count - 1
        '    Dim sWork As String = cmbItemsToShow.Items(iWork).ToString
        '    cmbType.Items.Add(sWork)
        'Next
    End Sub
    Sub LoadList()
        ' 0 = Normal, 1 = Special, 2 = Fresh, 3 = Kids snacks, 4 = Personal care, 5 = Home, 6 = Food, 7 = Homeless
        lvItems.Items.Clear()
        Dim SQL As String = "SELECT ItemName, ItemType FROM Items"
        ' "Limit of 3 items"
        Select Case cmbItemsToShow.Text
            'Case "All"
            'SQL += " WHERE ItemType = '" & cmbItemsToShow.Text & "'"
            Case "Limit of 3 items"
                SQL += " WHERE ItemType = 'HomeLess' AND Limit = 3"
            Case "Limit of 4 items"
                SQL += " WHERE ItemType = 'HomeLess' AND Limit = 4"
            Case Else
                If cmbItemsToShow.Text <> "All" Then
                    SQL += " WHERE ItemType = '" & cmbItemsToShow.Text & "'"
                End If

        End Select
        Dim ClientRows(1) As String
        If SortByName Then
            SQL += " ORDER BY ItemName"
        Else
            SQL += " ORDER BY ItemType, ItemName"
        End If
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        While rsWork.Read
            'If rsWork!ItemName = "Toilet paper" Then Stop
            ClientRows(0) = rsWork!ItemName
            ClientRows(1) = rsWork!ItemType
            Dim iWork As Integer = lvItems.Columns.Count
            Dim NewClientRow As ListViewItem = New ListViewItem(ClientRows)
            lvItems.Items.Add(NewClientRow)
        End While
        rsWork.Close()
        dB.Close()
        lvItems.SelectedItems.Clear()
    End Sub
    Sub SetVis()
        If btnAddNew.Text = "Finish adding" Then
            ' Adding a new record
            lvItems.Enabled = False
            btnCancel.Visible = True
            pnlItem.Enabled = True
        Else
            ' NOT adding a new record
            lvItems.Enabled = True
            'btnCancel.Visible = False
            'btnDelete.Visible = True
            If lvItems.SelectedItems.Count = 0 Then
                ' Nobody's selected
                lvItems.Enabled = True
                btnCancel.Visible = False
                btnUpdate.Visible = False
                btnDelete.Visible = False
                pnlItem.Enabled = False
            Else
                ' Sombody's been selected
                lvItems.Enabled = True
                btnCancel.Visible = False
                btnDelete.Visible = True
                pnlItem.Enabled = True
                If Changed Then
                    btnUpdate.Visible = True
                Else
                    btnUpdate.Visible = False
                End If
            End If

        End If

    End Sub
    Sub ClearForm()
        txtName.Text = ""
        cmbType.SelectedIndex = 0
        optLimitNone.Checked = True
    End Sub
    Private Sub lvItems_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvItems.ColumnClick
        If e.Column = 0 Then SortByName = True Else SortByName = False
        LoadList()
    End Sub
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        If btnUpdate.Visible Then
            MsgBox("You must complete or cancel your update before leaving this form.")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Sub SetErrorMessage(ByVal TheMessage As String)
        If ErrorMessage <> "" Then ErrorMessage += ", "
        ErrorMessage += TheMessage
    End Sub
    Private Sub btnAddNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddNew.Click
        Dim sWork As String = ""
        ErrorMessage = ""
        If btnAddNew.Text = "Add new" Then
            ' Begin the add process
            Loading = True
            ClearForm()
            Loading = False
            btnAddNew.Text = "Finish adding"
            txtName.Focus()
            Changed = False
            SetVis()
        Else
            ' Finish adding
            ' Check to make sure that this Item Name/Type doesn't exist, and that all required fields are filled in.
            ' First, check that all required fields are filled in.
            If txtName.Text = "" Then
                SetErrorMessage("Item name is required.")
            Else
                If cmbType.SelectedIndex < 0 Then
                    SetErrorMessage("Item type is required.")
                End If

            End If
            'If InStr(txtName.Text, "(") <> 0 Or InStr(txtName.Text, ")") <> 0 Then
            '    SetErrorMessage("Item name may not contain parenthese")
            'End If
            If DoesItemNameExist(SanitizeTextForSQL(txtName.Text), cmbType.Text) Then ErrorMessage = "That item/type already exists."
            If ErrorMessage = "" Then

                Form2Structure()
                ErrorMessage = AddAnItem(TheItem)
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

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Form2Structure()
        UpdateAnItem(SelectedItemName, SelectedItemType, TheItem)
        'Dim UpdateItem As AnItem = New AnItem
        'UpdateItem.ItemName = txtName.Text
        'UpdateItem.ItemType = cmbType.Text
        'UpdateItem.Limit = numLimit.Value
        'UpdateItem.Available = chkAvailableToday.Checked
        'Dim sWork As String = ""
        '' 1,2,1|3,4,2|5,10,3
        'If numFrom1.Value <> 0 Then

        'End If
        'UpdateItem.CountForNPeople = ""
        'UpdateAnItem(SelectedItemName, UpdateItem)
        Changed = False
        LoadList()
        SetVis()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete " & SelectedItemName & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim sWork As String = ExecuteSQLCommand("DELETE FROM Items WHERE ItemName = '" & SelectedItemName & "' AND ItemType = '" & SelectedItemType & "'")
            If sWork <> "" Then MsgBox(sWork)
            ClearForm()
            LoadList()
            Changed = False
            SetVis()
        End If

    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        btnAddNew.Text = "Add new"
        ClearForm()
        lvItems.SelectedItems.Clear()
        Changed = False
        SetVis()
    End Sub
    Sub Form2Structure()
        TheItem = New AnItem
        TheItem.ItemName = SanitizeTextForSQL(txtName.Text)
        If cmbType.Text = "Limit of 3 items" Or cmbType.Text = "Limit of 4 items" Then
            TheItem.ItemType = "HomeLess"
        Else
            TheItem.ItemType = cmbType.Text
        End If

        TheItem.ItemType = cmbType.Text

        If optLimit3.Checked Then
            TheItem.Limit = 3
        ElseIf optLimit4.Checked Then
            TheItem.Limit = 4
        Else
            TheItem.Limit = 0
        End If
        TheItem.Available = chkAvailableToday.Checked
        Dim sWork As String = ""
        ' 0,3,5|4,5,2 = From 0 to 3 people, 1 item, from 4 to 5 people, 2 items
        If numFrom1.Value <> 0 Then
            sWork = numFrom1.Value & "," & numTo1.Value & "," & numCount1.Value
            If numFrom2.Value <> 0 Then
                sWork += "|" & numFrom2.Value & "," & numTo2.Value & "," & numCount2.Value
                If numFrom3.Value <> 0 Then
                    sWork += "|" & numFrom3.Value & "," & numTo3.Value & "," & numCount3.Value
                End If
            End If
        End If
        TheItem.CountForNPeople = sWork

    End Sub
    Function DoesItemNameExist(ByVal ItemName As String, ByVal ItemType As String) As Boolean
        Dim ItExists As Boolean = False
        Dim SQL As String = "SELECT ItemName FROM Items WHERE ItemName = '" & ItemName & "' AND ItemType = '" & ItemType & "'"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then ItExists = True
        rsWork.Close()
        dB.Close()
        Return ItExists
    End Function
    'Sub SomethingsChanged() Handles txtName.TextChanged, cmbType.Click, numLimit.ValueChanged
    '    If Not Loading And btnAddNew.Text <> "Finish adding" Then
    '        Changed = True
    '        SetVis()
    '    End If
    'End Sub
    Private Sub lvItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvItems.SelectedIndexChanged
        If lvItems.SelectedItems.Count = 0 Then Exit Sub ' This must be the deselection cycle mentioned above!
        SelectedItemName = lvItems.SelectedItems(0).SubItems(0).Text
        SelectedItemType = lvItems.SelectedItems(0).SubItems(1).Text
        Dim SQL As String = "SELECT * FROM Items WHERE ItemName = '" & SanitizeTextForSQL(SelectedItemName) & "'"
        SQL += " AND ItemType = '" & SelectedItemType & "'"
        dB.Open()
        Command = New OleDbCommand(SQL, dB)
        rsWork = Command.ExecuteReader
        If rsWork.Read Then
            Record2Form(rsWork)
            'Loading = True
            'txtName.Text = rsWork!ItemName
            'cmbType.Text = rsWork!ItemType
            'numLimit.Value = rsWork!Limit
            'chkAvailableToday.Checked = rsWork!Available
            'Loading = False
        End If
        rsWork.Close()
        dB.Close()
        Changed = False
        SetVis()
    End Sub
    Sub Record2Form(ByVal rsWork As OleDbDataReader)
        Loading = True
        txtName.Text = rsWork!ItemName
        cmbType.Text = rsWork!ItemType
        chkAvailableToday.Checked = rsWork!Available
        Dim bWork As Boolean = False
        If rsWork!ItemType = "Homeless" Then bWork = True
        optLimit3.Visible = bWork
        optLimit4.Visible = bWork
        optLimitNone.Visible = bWork
        Select Case rsWork!Limit
            Case 3 : optLimit3.Checked = True
            Case 4 : optLimit4.Checked = True
            Case Else : optLimitNone.Checked = True

        End Select
        ' Parse and set the CountForNPeople
        Dim sWork As String = rsWork!CountForNPeople
        If sWork <> "" Then
            Dim aWork() As String = Split(sWork, "|")
            For ThisItem As Integer = 0 To UBound(aWork)
                ' From, To, Count
                Dim aWork2() As String = Split(aWork(ThisItem), ",")
                Select Case ThisItem
                    Case 0
                        numFrom1.Value = Val(aWork2(0))
                        numTo1.Value = Val(aWork2(1))
                        numCount1.Value = Val(aWork2(2))
                    Case 1
                        numFrom2.Value = Val(aWork2(0))
                        numTo2.Value = Val(aWork2(1))
                        numCount2.Value = Val(aWork2(2))
                    Case 2
                        numFrom3.Value = Val(aWork2(0))
                        numTo3.Value = Val(aWork2(1))
                        numCount3.Value = Val(aWork2(2))
                End Select
            Next
        Else
            numCount1.Value = 0
            numCount2.Value = 0
            numCount3.Value = 0
            numFrom1.Value = 0
            numFrom2.Value = 0
            numFrom3.Value = 0
            numTo1.Value = 0
            numTo2.Value = 0
            numTo3.Value = 0
        End If
        Loading = False
    End Sub
    Private Sub cmbItemsToShow_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemsToShow.SelectedIndexChanged
        If Not Loading Then LoadList()
    End Sub

    Private Sub SomethingsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged, cmbType.Click, chkAvailableToday.Click, _
    numCount1.ValueChanged, numCount2.ValueChanged, numCount3.ValueChanged, numFrom1.ValueChanged, numFrom2.ValueChanged, numFrom3.ValueChanged, numTo1.ValueChanged, numTo2.ValueChanged, numTo3.ValueChanged, _
    optLimit3.CheckedChanged, optLimit4.CheckedChanged, optLimitNone.CheckedChanged
        If Not Loading And btnAddNew.Text <> "Finish adding" Then
            Changed = True
            SetVis()
        End If
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = "(" Or e.KeyChar = ")" Then
            MsgBox("Sorry, you can't use parenthese here.")
            e.Handled = True
        End If
    End Sub

End Class