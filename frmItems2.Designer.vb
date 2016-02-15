<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnDone = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_PantryDataSet1 = New Food_Pantry.Food_PantryDataSet1
        Me.ItemsTableAdapter = New Food_Pantry.Food_PantryDataSet1TableAdapters.ItemsTableAdapter
        Me.ItemTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_PantryDataSet = New Food_Pantry.Food_PantryDataSet
        Me.ItemTypesTableAdapter = New Food_Pantry.Food_PantryDataSetTableAdapters.ItemTypesTableAdapter
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AvailableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.LimitedItem = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_PantryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemNameDataGridViewTextBoxColumn, Me.AvailableDataGridViewCheckBoxColumn, Me.LimitedItem, Me.Column1})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(608, 523)
        Me.DataGridView1.TabIndex = 0
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(673, 152)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(103, 23)
        Me.btnDone.TabIndex = 8
        Me.btnDone.Text = "Done"
        Me.btnDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(672, 98)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 25)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(672, 57)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 25)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Save Changes"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(623, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SAVING . . . . . ."
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Items"
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.Food_PantryDataSet1
        '
        'Food_PantryDataSet1
        '
        Me.Food_PantryDataSet1.DataSetName = "Food_PantryDataSet1"
        Me.Food_PantryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'ItemTypesBindingSource
        '
        Me.ItemTypesBindingSource.DataMember = "ItemTypes"
        Me.ItemTypesBindingSource.DataSource = Me.Food_PantryDataSet
        '
        'Food_PantryDataSet
        '
        Me.Food_PantryDataSet.DataSetName = "Food_PantryDataSet"
        Me.Food_PantryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemTypesTableAdapter
        '
        Me.ItemTypesTableAdapter.ClearBeforeFill = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.Width = 200
        '
        'AvailableDataGridViewCheckBoxColumn
        '
        Me.AvailableDataGridViewCheckBoxColumn.DataPropertyName = "Available"
        Me.AvailableDataGridViewCheckBoxColumn.HeaderText = "Available"
        Me.AvailableDataGridViewCheckBoxColumn.Name = "AvailableDataGridViewCheckBoxColumn"
        Me.AvailableDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'LimitedItem
        '
        Me.LimitedItem.DataPropertyName = "LimitedItem"
        Me.LimitedItem.HeaderText = "Limited Client"
        Me.LimitedItem.Name = "LimitedItem"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ItemTypeID"
        Me.Column1.DataSource = Me.ItemTypesBindingSource
        Me.Column1.DisplayMember = "ItemTypeName"
        Me.Column1.HeaderText = "Type"
        Me.Column1.MaxDropDownItems = 20
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.ValueMember = "ID"
        Me.Column1.Width = 160
        '
        'frmItems2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 632)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmItems2"
        Me.Text = "frmItems2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_PantryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Food_PantryDataSet1 As Food_Pantry.Food_PantryDataSet1
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As Food_Pantry.Food_PantryDataSet1TableAdapters.ItemsTableAdapter
    Friend WithEvents Food_PantryDataSet As Food_Pantry.Food_PantryDataSet
    Friend WithEvents ItemTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemTypesTableAdapter As Food_Pantry.Food_PantryDataSetTableAdapters.ItemTypesTableAdapter
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LimitedItem As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
