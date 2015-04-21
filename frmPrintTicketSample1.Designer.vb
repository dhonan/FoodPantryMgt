<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintTicketSample1
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
        Me.PrintTicketFoodItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_PantryDataSet = New Food_Pantry.Food_PantryDataSet
        Me.qryVisitsWithClientForPickTicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Food_PantryDataSet2 = New Food_Pantry.Food_PantryDataSet2
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.PrintTicketFoodItemsTableAdapter = New Food_Pantry.Food_PantryDataSetTableAdapters.PrintTicketFoodItemsTableAdapter
        Me.qryVisitsWithClientForPickTicketTableAdapter = New Food_Pantry.Food_PantryDataSet2TableAdapters.qryVisitsWithClientForPickTicketTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.PrintTicketFoodItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qryVisitsWithClientForPickTicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Food_PantryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintTicketFoodItemsBindingSource
        '
        Me.PrintTicketFoodItemsBindingSource.DataMember = "PrintTicketFoodItems"
        Me.PrintTicketFoodItemsBindingSource.DataSource = Me.Food_PantryDataSet
        '
        'Food_PantryDataSet
        '
        Me.Food_PantryDataSet.DataSetName = "Food_PantryDataSet"
        Me.Food_PantryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'qryVisitsWithClientForPickTicketBindingSource
        '
        Me.qryVisitsWithClientForPickTicketBindingSource.DataMember = "qryVisitsWithClientForPickTicket"
        Me.qryVisitsWithClientForPickTicketBindingSource.DataSource = Me.Food_PantryDataSet2
        '
        'Food_PantryDataSet2
        '
        Me.Food_PantryDataSet2.DataSetName = "Food_PantryDataSet2"
        Me.Food_PantryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 62)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(918, 556)
        Me.ReportViewer1.TabIndex = 0
        '
        'PrintTicketFoodItemsTableAdapter
        '
        Me.PrintTicketFoodItemsTableAdapter.ClearBeforeFill = True
        '
        'qryVisitsWithClientForPickTicketTableAdapter
        '
        Me.qryVisitsWithClientForPickTicketTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sample Print Ticket"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(483, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPrintTicketSample1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 630)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrintTicketSample1"
        Me.Text = "frmPrintTicketSample1"
        CType(Me.PrintTicketFoodItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qryVisitsWithClientForPickTicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Food_PantryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrintTicketFoodItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Food_PantryDataSet As Food_Pantry.Food_PantryDataSet
    Friend WithEvents qryVisitsWithClientForPickTicketBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Food_PantryDataSet2 As Food_Pantry.Food_PantryDataSet2
    Friend WithEvents PrintTicketFoodItemsTableAdapter As Food_Pantry.Food_PantryDataSetTableAdapters.PrintTicketFoodItemsTableAdapter
    Friend WithEvents qryVisitsWithClientForPickTicketTableAdapter As Food_Pantry.Food_PantryDataSet2TableAdapters.qryVisitsWithClientForPickTicketTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
