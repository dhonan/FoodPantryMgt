Public Class frmItemTypes
    Dim ItemTypeTA As New Food_PantryDataSetTableAdapters.Items1TableAdapter
    Dim ItemsTypeTable As New Food_PantryDataSet.Items1DataTable
    Dim ChangeInd As Boolean = False
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

    

    Private Sub frmItemTypes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet.ItemTypes' table. You can move, or remove it, as needed.
        Me.ItemTypesTableAdapter.Fill(Me.Food_PantryDataSet.ItemTypes)
        ChangeInd = False
        btnCancel.Enabled = False
        btnUpdate.Enabled = False


    End Sub

    

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

    End Sub

    Private Sub DataGridView1_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating

        Dim headerText As String = _
       DataGridView1.Columns(e.ColumnIndex).HeaderText
        Dim errorind As Boolean = False


        ' Abort validation if cell is not in the CompanyName column. 
        If Not headerText.Equals("ItemTypeName") Then Return

        ' Confirm that the cell is not empty. 
        If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
            errorind = True
        Else
            If Len(Trim(e.FormattedValue.ToString())) = 0 Then
                errorind = True
            End If
        End If
        If errorind Then
            MsgBox("Item Type must not be empty")
            e.Cancel = True
        End If



    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ChangeInd = True
        btnCancel.Enabled = True
        btnUpdate.Enabled = True

    End Sub

    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        ' MsgBox(DataGridView1.SelectedRows(0).DataBoundItem.ToString())

        For i = 0 To DataGridView1.Columns.Count - 1

            If DataGridView1.Columns(i).DataPropertyName.ToString = "ID" Then
                ItemsTypeTable = ItemTypeTA.GetDataByItemTypeId(DataGridView1.SelectedRows(0).Cells(i).Value)
                If ItemsTypeTable.Rows.Count > 0 Then
                    MsgBox("Item Type Cannot Be Deleted as long as this Item Type is Assigned to ITEMS." _
                            & vbCrLf & "Change the Type for Items with this type")
                    e.Cancel = True
                    Exit Sub
                End If



            End If
        Next

        ChangeInd = True
        btnCancel.Enabled = True
        btnUpdate.Enabled = True





    End Sub

    

    



   

    
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        If ChangeInd Then
            Select Case MsgBox("Save Changes?", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.No
                    Me.Close()
                    Exit Sub
                Case MsgBoxResult.Yes
                    btnUpdate_Click(sender, e)
                    Me.Close()
                    Exit Sub
                Case MsgBoxResult.Cancel
                    Exit Sub
            End Select

        Else
            Me.Close()
            Exit Sub

        End If



    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
   
        Me.Label2.Visible = True
        Me.btnDone.Visible = False
        btnCancel.Enabled = False
        btnUpdate.Enabled = False


        Application.DoEvents()



        Me.ItemTypesTableAdapter.Update(Me.Food_PantryDataSet.ItemTypes)

        ChangeInd = False
        Dim PT As New PrintTicket
        PT.BuildFoodList()


        Me.Label2.Visible = False
        Me.btnDone.Visible = True






    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
       Me.ItemTypesTableAdapter.Fill(Me.Food_PantryDataSet.ItemTypes)
        ChangeInd = False
        btnCancel.Enabled = False
        btnUpdate.Enabled = False

    End Sub
End Class