<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Food_PantryDataSet = New Food_Pantry.Food_PantryDataSet
        Me.PrintTicketFoodItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintTicketFoodItemsTableAdapter = New Food_Pantry.Food_PantryDataSetTableAdapters.PrintTicketFoodItemsTableAdapter
        Me.Food_PantryDataSet2 = New Food_Pantry.Food_PantryDataSet2
        Me.qryVisitsWithClientForPickTicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.qryVisitsWithClientForPickTicketTableAdapter = New Food_Pantry.Food_PantryDataSet2TableAdapters.qryVisitsWithClientForPickTicketTableAdapter
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTicketFoodItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_PantryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qryVisitsWithClientForPickTicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Food_PantryDataSet_PrintTicketFoodItems"
        ReportDataSource1.Value = Me.PrintTicketFoodItemsBindingSource
        ReportDataSource2.Name = "Food_PantryDataSet2_qryVisitsWithClientForPickTicket"
        ReportDataSource2.Value = Me.qryVisitsWithClientForPickTicketBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Food_Pantry.PrintTicket2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(698, 473)
        Me.ReportViewer1.TabIndex = 0
        '
        'Food_PantryDataSet
        '
        Me.Food_PantryDataSet.DataSetName = "Food_PantryDataSet"
        Me.Food_PantryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintTicketFoodItemsBindingSource
        '
        Me.PrintTicketFoodItemsBindingSource.DataMember = "PrintTicketFoodItems"
        Me.PrintTicketFoodItemsBindingSource.DataSource = Me.Food_PantryDataSet
        '
        'PrintTicketFoodItemsTableAdapter
        '
        Me.PrintTicketFoodItemsTableAdapter.ClearBeforeFill = True
        '
        'Food_PantryDataSet2
        '
        Me.Food_PantryDataSet2.DataSetName = "Food_PantryDataSet2"
        Me.Food_PantryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'qryVisitsWithClientForPickTicketBindingSource
        '
        Me.qryVisitsWithClientForPickTicketBindingSource.DataMember = "qryVisitsWithClientForPickTicket"
        Me.qryVisitsWithClientForPickTicketBindingSource.DataSource = Me.Food_PantryDataSet2
        '
        'qryVisitsWithClientForPickTicketTableAdapter
        '
        Me.qryVisitsWithClientForPickTicketTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 511)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTicketFoodItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_PantryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qryVisitsWithClientForPickTicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrintTicketFoodItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Food_PantryDataSet As Food_Pantry.Food_PantryDataSet
    Friend WithEvents qryVisitsWithClientForPickTicketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Food_PantryDataSet2 As Food_Pantry.Food_PantryDataSet2
    Friend WithEvents PrintTicketFoodItemsTableAdapter As Food_Pantry.Food_PantryDataSetTableAdapters.PrintTicketFoodItemsTableAdapter
    Friend WithEvents qryVisitsWithClientForPickTicketTableAdapter As Food_Pantry.Food_PantryDataSet2TableAdapters.qryVisitsWithClientForPickTicketTableAdapter
End Class
