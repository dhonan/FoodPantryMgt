Public Class PrintTicket
    Public Function Testit() As Integer
        Testit = 1

    End Function

    Public Sub BuildFoodList()

        Dim ItemTableAdapter As New Food_PantryDataSetTableAdapters.ItemsTableAdapter
        Dim ItemsTable As New Food_PantryDataSet.ItemsDataTable
        Dim ItemsRow As Food_PantryDataSet.ItemsRow

        Dim TempItemsTableAdapter As New Food_PantryDataSetTableAdapters.tempHoldItemPrint1TableAdapter
        Dim CurrentCol As Integer = 1
        Dim CurrentRow As Integer = 0
        Dim MaxRows As Integer = 30
        Dim CurrentItemType As String = ""

        Dim Checkbox1 As String = "☐"  ' not sure what this is, but I think it works
        Dim UnderLine1 As String = "___"
        Dim Prefix As String = ""
        Dim PrefixItemType As String = "■"






        TempItemsTableAdapter.DeleteAllRows()

        ItemsTable = ItemTableAdapter.GetDataByAvailable()

        For Each ItemsRow In ItemsTable
            CurrentRow = CurrentRow + 1

            If (ItemsRow.ItemTypeName <> CurrentItemType And CurrentRow > (MaxRows - 5)) Then
                For i = CurrentRow To MaxRows
                    TempItemsTableAdapter.Insert(CurrentCol, CurrentRow, "")
                    CurrentRow = CurrentRow + 1
                Next
            End If



            If CurrentRow > MaxRows Then
                CurrentRow = 1
                CurrentCol = CurrentCol + 1
            End If



            If ItemsRow.ItemTypeName <> CurrentItemType Then
                If CurrentRow <> 1 Then
                    TempItemsTableAdapter.Insert(CurrentCol, CurrentRow, "")
                    CurrentRow = CurrentRow + 1
                End If

                TempItemsTableAdapter.Insert(CurrentCol, CurrentRow, PrefixItemType & ItemsRow.ItemTypeName)
                CurrentRow = CurrentRow + 1

                CurrentItemType = ItemsRow.ItemTypeName
            Else
                If CurrentRow = 1 And CurrentCol <> 1 Then
                    TempItemsTableAdapter.Insert(CurrentCol, CurrentRow, PrefixItemType & ItemsRow.ItemTypeName & "(Cont'd)")
                    CurrentRow = CurrentRow + 1
                End If


            End If
            If ItemsRow.ItemTypeUnderlineInd Then
                Prefix = UnderLine1
            Else
                Prefix = Checkbox1
            End If
            TempItemsTableAdapter.Insert(CurrentCol, CurrentRow, Prefix & " " & ItemsRow.ItemName)


        Next
        InsertPrintTicketRows()

        
    End Sub

    Private Sub InsertPrintTicketRows()
        Dim PTAdapter As New Food_PantryDataSetTableAdapters.PrintTicketFoodItemsTableAdapter
        PTAdapter.DeleteAllRows()
        PTAdapter.InsertColumn1()
        PTAdapter.InsertColumn2()
        PTAdapter.InsertColumn3()
        PTAdapter.InsertColumn4()











    End Sub
End Class

