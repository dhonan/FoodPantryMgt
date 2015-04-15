<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpenTickets))
        Me.lvVisits = New System.Windows.Forms.ListView
        Me.VisitID = New System.Windows.Forms.ColumnHeader
        Me.PersonID = New System.Windows.Forms.ColumnHeader
        Me.PersonName = New System.Windows.Forms.ColumnHeader
        Me.VisitDate = New System.Windows.Forms.ColumnHeader
        Me.ApptTime = New System.Windows.Forms.ColumnHeader
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lvVisits
        '
        Me.lvVisits.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.VisitID, Me.PersonID, Me.PersonName, Me.VisitDate, Me.ApptTime})
        Me.lvVisits.FullRowSelect = True
        Me.lvVisits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvVisits.HideSelection = False
        Me.lvVisits.Location = New System.Drawing.Point(25, 12)
        Me.lvVisits.MultiSelect = False
        Me.lvVisits.Name = "lvVisits"
        Me.lvVisits.Size = New System.Drawing.Size(590, 679)
        Me.lvVisits.TabIndex = 1
        Me.lvVisits.UseCompatibleStateImageBehavior = False
        Me.lvVisits.View = System.Windows.Forms.View.Details
        '
        'VisitID
        '
        Me.VisitID.DisplayIndex = 3
        Me.VisitID.Width = 0
        '
        'PersonID
        '
        Me.PersonID.DisplayIndex = 0
        Me.PersonID.Text = "ID"
        Me.PersonID.Width = 87
        '
        'PersonName
        '
        Me.PersonName.DisplayIndex = 1
        Me.PersonName.Text = "Name"
        Me.PersonName.Width = 221
        '
        'VisitDate
        '
        Me.VisitDate.DisplayIndex = 2
        Me.VisitDate.Text = "Date"
        Me.VisitDate.Width = 150
        '
        'ApptTime
        '
        Me.ApptTime.Text = "Appt Time"
        Me.ApptTime.Width = 109
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 730
        Me.ReSize1.InitialHostContainerWidth = 639
        Me.ReSize1.Tag = Nothing
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmOpenTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 730)
        Me.Controls.Add(Me.lvVisits)
        Me.Name = "frmOpenTickets"
        Me.Text = "frmOpenTickets"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvVisits As System.Windows.Forms.ListView
    Friend WithEvents VisitID As System.Windows.Forms.ColumnHeader
    Friend WithEvents PersonID As System.Windows.Forms.ColumnHeader
    Friend WithEvents PersonName As System.Windows.Forms.ColumnHeader
    Friend WithEvents VisitDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApptTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
