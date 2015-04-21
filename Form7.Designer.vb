<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.ItemTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_PantryDataSet = New Food_Pantry.Food_PantryDataSet
        Me.ItemTypesTableAdapter = New Food_Pantry.Food_PantryDataSetTableAdapters.ItemTypesTableAdapter
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ItemTypeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemTypeSequenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemTypeUnderlineIndDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemTypeNameDataGridViewTextBoxColumn, Me.ItemTypeSequenceDataGridViewTextBoxColumn, Me.ItemTypeUnderlineIndDataGridViewCheckBoxColumn, Me.Column1})
        Me.DataGridView1.DataSource = Me.ItemTypesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(60, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(596, 181)
        Me.DataGridView1.TabIndex = 0
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
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(443, 268)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Save Changes"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(60, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(552, 268)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ItemTypeNameDataGridViewTextBoxColumn
        '
        Me.ItemTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeName"
        Me.ItemTypeNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ItemTypeNameDataGridViewTextBoxColumn.Name = "ItemTypeNameDataGridViewTextBoxColumn"
        '
        'ItemTypeSequenceDataGridViewTextBoxColumn
        '
        Me.ItemTypeSequenceDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeSequence"
        Me.ItemTypeSequenceDataGridViewTextBoxColumn.HeaderText = "Sequence"
        Me.ItemTypeSequenceDataGridViewTextBoxColumn.Name = "ItemTypeSequenceDataGridViewTextBoxColumn"
        '
        'ItemTypeUnderlineIndDataGridViewCheckBoxColumn
        '
        Me.ItemTypeUnderlineIndDataGridViewCheckBoxColumn.DataPropertyName = "ItemTypeUnderlineInd"
        Me.ItemTypeUnderlineIndDataGridViewCheckBoxColumn.HeaderText = "Use Underline"
        Me.ItemTypeUnderlineIndDataGridViewCheckBoxColumn.Name = "ItemTypeUnderlineIndDataGridViewCheckBoxColumn"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 408)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Food_PantryDataSet As Food_Pantry.Food_PantryDataSet
    Friend WithEvents ItemTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemTypesTableAdapter As Food_Pantry.Food_PantryDataSetTableAdapters.ItemTypesTableAdapter
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ItemTypeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemTypeSequenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemTypeUnderlineIndDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
