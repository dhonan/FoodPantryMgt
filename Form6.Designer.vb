<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Food_PantryDataSet1 = New Food_Pantry.Food_PantryDataSet1
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New Food_Pantry.Food_PantryDataSet1TableAdapters.ItemsTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.Food_PantryDataSet = New Food_Pantry.Food_PantryDataSet
        Me.ItemTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTypesTableAdapter = New Food_Pantry.Food_PantryDataSetTableAdapters.ItemTypesTableAdapter
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AvailableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_PantryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemNameDataGridViewTextBoxColumn, Me.AvailableDataGridViewCheckBoxColumn, Me.Column1})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(618, 236)
        Me.DataGridView1.TabIndex = 0
        '
        'Food_PantryDataSet1
        '
        Me.Food_PantryDataSet1.DataSetName = "Food_PantryDataSet1"
        Me.Food_PantryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.Food_PantryDataSet1
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(454, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Food_PantryDataSet
        '
        Me.Food_PantryDataSet.DataSetName = "Food_PantryDataSet"
        Me.Food_PantryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemTypesBindingSource
        '
        Me.ItemTypesBindingSource.DataMember = "ItemTypes"
        Me.ItemTypesBindingSource.DataSource = Me.Food_PantryDataSet
        '
        'ItemTypesTableAdapter
        '
        Me.ItemTypesTableAdapter.ClearBeforeFill = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        '
        'AvailableDataGridViewCheckBoxColumn
        '
        Me.AvailableDataGridViewCheckBoxColumn.DataPropertyName = "Available"
        Me.AvailableDataGridViewCheckBoxColumn.HeaderText = "Available"
        Me.AvailableDataGridViewCheckBoxColumn.Name = "AvailableDataGridViewCheckBoxColumn"
        Me.AvailableDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ItemTypeID"
        Me.Column1.DataSource = Me.ItemTypesBindingSource
        Me.Column1.DisplayMember = "ItemTypeName"
        Me.Column1.HeaderText = "Tyoe"
        Me.Column1.MaxDropDownItems = 20
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.ValueMember = "ID"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 547)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_PantryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Food_PantryDataSet1 As Food_Pantry.Food_PantryDataSet1
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As Food_Pantry.Food_PantryDataSet1TableAdapters.ItemsTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Food_PantryDataSet As Food_Pantry.Food_PantryDataSet
    Friend WithEvents ItemTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemTypesTableAdapter As Food_Pantry.Food_PantryDataSetTableAdapters.ItemTypesTableAdapter
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
