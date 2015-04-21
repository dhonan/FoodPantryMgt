<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Food_PantryDataSet2 = New Food_Pantry.Food_PantryDataSet2
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientsTableAdapter = New Food_Pantry.Food_PantryDataSet2TableAdapters.ClientsTableAdapter
        CType(Me.Food_PantryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Food_PantryDataSet2_Clients"
        ReportDataSource1.Value = Me.ClientsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Food_Pantry.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(42, 86)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(680, 250)
        Me.ReportViewer1.TabIndex = 0
        '
        'Food_PantryDataSet2
        '
        Me.Food_PantryDataSet2.DataSetName = "Food_PantryDataSet2"
        Me.Food_PantryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "Clients"
        Me.ClientsBindingSource.DataSource = Me.Food_PantryDataSet2
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 460)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.Food_PantryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Food_PantryDataSet2 As Food_Pantry.Food_PantryDataSet2
    Friend WithEvents ClientsTableAdapter As Food_Pantry.Food_PantryDataSet2TableAdapters.ClientsTableAdapter
End Class
