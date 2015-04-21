Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Food_PantryDataSet.ItemTypes' table. You can move, or remove it, as needed.
        Me.ItemTypesTableAdapter.Fill(Me.Food_PantryDataSet.ItemTypes)
        'TODO: This line of code loads data into the 'Food_PantryDataSet1.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.Food_PantryDataSet1.Items)
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ItemsTableAdapter.Update(Me.Food_PantryDataSet1.Items)
    End Sub
End Class