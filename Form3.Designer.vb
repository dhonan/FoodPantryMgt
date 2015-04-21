<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Food_PantryDataSet = New Food_Pantry.Food_PantryDataSet
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientsTableAdapter = New Food_Pantry.Food_PantryDataSetTableAdapters.ClientsTableAdapter
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "Food_PantryDataSet_Clients"
        ReportDataSource2.Value = Me.ClientsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Food_Pantry.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(65, 121)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(400, 250)
        Me.ReportViewer1.TabIndex = 0
        '
        'Food_PantryDataSet
        '
        Me.Food_PantryDataSet.DataSetName = "Food_PantryDataSet"
        Me.Food_PantryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.Food_PantryDataSet
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Food_PantryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Food_PantryDataSet As Food_Pantry.Food_PantryDataSet
    Friend WithEvents ClientsTableAdapter As Food_Pantry.Food_PantryDataSetTableAdapters.ClientsTableAdapter
End Class
