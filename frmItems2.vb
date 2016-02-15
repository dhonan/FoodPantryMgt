Public Class frmItems2
    Private ChangeInd As Boolean = False
    Private ValidEntriesInd As Boolean = True



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

    Private Sub frmItems2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet.ItemTypes' table. You can move, or remove it, as needed.
        Me.ItemTypesTableAdapter.Fill(Me.Food_PantryDataSet.ItemTypes)
        'TODO: This line of code loads data into the 'Food_PantryDataSet1.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.Food_PantryDataSet1.Items)
        ChangeInd = False
        btnCancel.Enabled = False
        btnUpdate.Enabled = False

    End Sub




    Private Sub DataGridView1_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating

        Dim headerText As String = _
       DataGridView1.Columns(e.ColumnIndex).HeaderText
        Dim errorind As Boolean = False



        If headerText.Equals("Item") Then

            ' Confirm that the cell is not empty. 
            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                errorind = True
            Else
                If Len(Trim(e.FormattedValue.ToString())) = 0 Then
                    errorind = True
                End If
            End If
            If errorind Then
                MsgBox("Name must not be empty")
                e.Cancel = True
            End If
        End If


        


        'MsgBox("header=" & headerText & " value=" & e.FormattedValue.ToString)



    End Sub


    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        
      
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
                    If ValidEntriesInd = True Then
                        Me.Close()
                    End If
                    Exit Sub
                Case MsgBoxResult.Cancel
                    Exit Sub
            End Select

        Else
            Me.Close()
            Exit Sub

        End If




      


    End Sub

    

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.ItemsTableAdapter.Fill(Me.Food_PantryDataSet1.Items)
        ChangeInd = False
        btnCancel.Enabled = False
        btnUpdate.Enabled = False

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        ValidEntriesInd = True

        If ValidEntries() = False Then
            ValidEntriesInd = False
            Exit Sub
        End If



        Me.Label2.Visible = True
        Me.btnDone.Visible = False
        btnCancel.Enabled = False
        btnUpdate.Enabled = False


        Application.DoEvents()

        Me.ItemsTableAdapter.Update(Me.Food_PantryDataSet1.Items)
        ChangeInd = False

        Dim PT As New PrintTicket
        PT.BuildFoodList()


        Me.Label2.Visible = False
        Me.btnDone.Visible = True


    End Sub
    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ChangeInd = True
        btnCancel.Enabled = True
        btnUpdate.Enabled = True

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim headerText As String
        Dim Errorind As Boolean = False
        Dim ItemName As String = ""



        For i = 0 To DataGridView1.Rows.Count - 1
            Errorind = False
            ItemName = ""
            For j = 0 To DataGridView1.Rows(i).Cells.Count - 1
                If Not DataGridView1.Rows(i).IsNewRow Then


                    headerText = _
                    DataGridView1.Columns(j).HeaderText


                    If headerText.Equals("Item") Then
                        ItemName = DataGridView1.Rows(i).Cells(j).Value
                    End If

                    If headerText.Equals("Type") Then
                        If DataGridView1.Rows(i).Cells(j).Value Is DBNull.Value Then
                            Errorind = True

                        Else

                            ' Confirm that the cell is not empty. 
                            If String.IsNullOrEmpty(DataGridView1.Rows(i).Cells(j).Value) Then
                                Errorind = True
                            Else
                                If Len(Trim(DataGridView1.Rows(i).Cells(j).Value)) = 0 Then
                                    Errorind = True
                                End If
                            End If
                        End If

                        If Errorind Then
                            MsgBox(DataGridView1.Rows(i).IsNewRow & " row=" & i & " col=" & j & " Item Type must not be empty for Item " & ItemName)
                            ' e.Cancel = True
                        End If
                    End If

                End If


            Next





        Next
    End Sub

    Private Function ValidEntries() As Boolean
        ValidEntries = True

        Dim headerText As String
        Dim Errorind As Boolean = False
        Dim ItemName As String = ""

        For i = 0 To DataGridView1.Rows.Count - 1
            Errorind = False
            ItemName = ""
            For j = 0 To DataGridView1.Rows(i).Cells.Count - 1
                If Not DataGridView1.Rows(i).IsNewRow Then
                    headerText = _
                        DataGridView1.Columns(j).HeaderText
                    If headerText.Equals("Item") Then
                        ItemName = DataGridView1.Rows(i).Cells(j).Value
                    End If
                    If headerText.Equals("Type") Then
                        If DataGridView1.Rows(i).Cells(j).Value Is DBNull.Value Then
                            Errorind = True
                        Else
                            If String.IsNullOrEmpty(DataGridView1.Rows(i).Cells(j).Value) Then
                                Errorind = True
                            Else
                                If Len(Trim(DataGridView1.Rows(i).Cells(j).Value)) = 0 Then
                                    Errorind = True
                                End If
                            End If
                        End If

                        If Errorind Then
                            ' MsgBox(DataGridView1.Rows(i).IsNewRow & " row=" & i & " col=" & j & " Item Type must not be empty for Item " & ItemName)
                            MsgBox("Item Type must not be empty for Item: " & ItemName)
                            ValidEntries = False
                        End If
                    End If
                End If
            Next
        Next

    End Function

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ItemsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsBindingSource.CurrentChanged

    End Sub
End Class