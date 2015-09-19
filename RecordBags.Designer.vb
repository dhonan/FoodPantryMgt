<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecordBags
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecordBags))
        Me.grpVisits = New System.Windows.Forms.GroupBox
        Me.lvVisits = New System.Windows.Forms.ListView
        Me.VisitID = New System.Windows.Forms.ColumnHeader
        Me.PersonID = New System.Windows.Forms.ColumnHeader
        Me.PersonName = New System.Windows.Forms.ColumnHeader
        Me.VisitDate = New System.Windows.Forms.ColumnHeader
        Me.ApptTime = New System.Windows.Forms.ColumnHeader
        Me.btnDone = New System.Windows.Forms.Button
        Me.grpBags = New System.Windows.Forms.GroupBox
        Me.btnBags10 = New System.Windows.Forms.Button
        Me.btnBags9 = New System.Windows.Forms.Button
        Me.btnBags8 = New System.Windows.Forms.Button
        Me.btnBags7 = New System.Windows.Forms.Button
        Me.btnBags6 = New System.Windows.Forms.Button
        Me.btnBags5 = New System.Windows.Forms.Button
        Me.btnBags4 = New System.Windows.Forms.Button
        Me.btnBags3 = New System.Windows.Forms.Button
        Me.btnBags2 = New System.Windows.Forms.Button
        Me.btnBags1 = New System.Windows.Forms.Button
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtClientNumber = New System.Windows.Forms.TextBox
        Me.lblClientName = New System.Windows.Forms.Label
        Me.chkShowClientList = New System.Windows.Forms.CheckBox
        Me.lblVisitCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.numAddBags = New System.Windows.Forms.NumericUpDown
        Me.Delivery = New System.Windows.Forms.ColumnHeader
        Me.grpBags.SuspendLayout()
        CType(Me.numAddBags, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpVisits
        '
        Me.grpVisits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVisits.Location = New System.Drawing.Point(0, 0)
        Me.grpVisits.Name = "grpVisits"
        Me.grpVisits.Size = New System.Drawing.Size(271, 429)
        Me.grpVisits.TabIndex = 0
        Me.grpVisits.TabStop = False
        Me.grpVisits.Text = "Unresolved visits, colored rows are deliveries--"
        Me.grpVisits.Visible = False
        '
        'lvVisits
        '
        Me.lvVisits.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.VisitID, Me.PersonID, Me.PersonName, Me.VisitDate, Me.ApptTime, Me.Delivery})
        Me.lvVisits.FullRowSelect = True
        Me.lvVisits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvVisits.HideSelection = False
        Me.lvVisits.Location = New System.Drawing.Point(12, 23)
        Me.lvVisits.MultiSelect = False
        Me.lvVisits.Name = "lvVisits"
        Me.lvVisits.Size = New System.Drawing.Size(644, 406)
        Me.lvVisits.TabIndex = 0
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
        Me.PersonID.Width = 50
        '
        'PersonName
        '
        Me.PersonName.DisplayIndex = 1
        Me.PersonName.Text = "Name"
        Me.PersonName.Width = 210
        '
        'VisitDate
        '
        Me.VisitDate.DisplayIndex = 2
        Me.VisitDate.Text = "Date"
        Me.VisitDate.Width = 149
        '
        'ApptTime
        '
        Me.ApptTime.Text = "Appt Time"
        Me.ApptTime.Width = 149
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(765, 432)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'grpBags
        '
        Me.grpBags.Controls.Add(Me.btnBags10)
        Me.grpBags.Controls.Add(Me.btnBags9)
        Me.grpBags.Controls.Add(Me.btnBags8)
        Me.grpBags.Controls.Add(Me.btnBags7)
        Me.grpBags.Controls.Add(Me.btnBags6)
        Me.grpBags.Controls.Add(Me.btnBags5)
        Me.grpBags.Controls.Add(Me.btnBags4)
        Me.grpBags.Controls.Add(Me.btnBags3)
        Me.grpBags.Controls.Add(Me.btnBags2)
        Me.grpBags.Controls.Add(Me.btnBags1)
        Me.grpBags.Location = New System.Drawing.Point(692, 43)
        Me.grpBags.Name = "grpBags"
        Me.grpBags.Size = New System.Drawing.Size(99, 235)
        Me.grpBags.TabIndex = 2
        Me.grpBags.TabStop = False
        Me.grpBags.Text = "Number of bags"
        '
        'btnBags10
        '
        Me.btnBags10.Location = New System.Drawing.Point(64, 205)
        Me.btnBags10.Name = "btnBags10"
        Me.btnBags10.Size = New System.Drawing.Size(29, 24)
        Me.btnBags10.TabIndex = 9
        Me.btnBags10.Text = "10"
        Me.btnBags10.UseVisualStyleBackColor = True
        '
        'btnBags9
        '
        Me.btnBags9.Location = New System.Drawing.Point(16, 205)
        Me.btnBags9.Name = "btnBags9"
        Me.btnBags9.Size = New System.Drawing.Size(29, 24)
        Me.btnBags9.TabIndex = 8
        Me.btnBags9.Text = "9"
        Me.btnBags9.UseVisualStyleBackColor = True
        '
        'btnBags8
        '
        Me.btnBags8.Location = New System.Drawing.Point(64, 159)
        Me.btnBags8.Name = "btnBags8"
        Me.btnBags8.Size = New System.Drawing.Size(29, 24)
        Me.btnBags8.TabIndex = 7
        Me.btnBags8.Text = "8"
        Me.btnBags8.UseVisualStyleBackColor = True
        '
        'btnBags7
        '
        Me.btnBags7.Location = New System.Drawing.Point(16, 159)
        Me.btnBags7.Name = "btnBags7"
        Me.btnBags7.Size = New System.Drawing.Size(29, 24)
        Me.btnBags7.TabIndex = 6
        Me.btnBags7.Text = "7"
        Me.btnBags7.UseVisualStyleBackColor = True
        '
        'btnBags6
        '
        Me.btnBags6.Location = New System.Drawing.Point(64, 113)
        Me.btnBags6.Name = "btnBags6"
        Me.btnBags6.Size = New System.Drawing.Size(29, 24)
        Me.btnBags6.TabIndex = 5
        Me.btnBags6.Text = "6"
        Me.btnBags6.UseVisualStyleBackColor = True
        '
        'btnBags5
        '
        Me.btnBags5.Location = New System.Drawing.Point(16, 113)
        Me.btnBags5.Name = "btnBags5"
        Me.btnBags5.Size = New System.Drawing.Size(29, 24)
        Me.btnBags5.TabIndex = 4
        Me.btnBags5.Text = "5"
        Me.btnBags5.UseVisualStyleBackColor = True
        '
        'btnBags4
        '
        Me.btnBags4.Location = New System.Drawing.Point(64, 66)
        Me.btnBags4.Name = "btnBags4"
        Me.btnBags4.Size = New System.Drawing.Size(29, 24)
        Me.btnBags4.TabIndex = 3
        Me.btnBags4.Text = "4"
        Me.btnBags4.UseVisualStyleBackColor = True
        '
        'btnBags3
        '
        Me.btnBags3.Location = New System.Drawing.Point(16, 66)
        Me.btnBags3.Name = "btnBags3"
        Me.btnBags3.Size = New System.Drawing.Size(29, 24)
        Me.btnBags3.TabIndex = 2
        Me.btnBags3.Text = "3"
        Me.btnBags3.UseVisualStyleBackColor = True
        '
        'btnBags2
        '
        Me.btnBags2.Location = New System.Drawing.Point(64, 21)
        Me.btnBags2.Name = "btnBags2"
        Me.btnBags2.Size = New System.Drawing.Size(29, 24)
        Me.btnBags2.TabIndex = 1
        Me.btnBags2.Text = "2"
        Me.btnBags2.UseVisualStyleBackColor = True
        '
        'btnBags1
        '
        Me.btnBags1.Location = New System.Drawing.Point(16, 21)
        Me.btnBags1.Name = "btnBags1"
        Me.btnBags1.Size = New System.Drawing.Size(29, 24)
        Me.btnBags1.TabIndex = 0
        Me.btnBags1.Text = "1"
        Me.btnBags1.UseVisualStyleBackColor = True
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 460
        Me.ReSize1.InitialHostContainerWidth = 864
        Me.ReSize1.Tag = Nothing
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(765, 401)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(686, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Client:"
        '
        'txtClientNumber
        '
        Me.txtClientNumber.Location = New System.Drawing.Point(726, 284)
        Me.txtClientNumber.Name = "txtClientNumber"
        Me.txtClientNumber.Size = New System.Drawing.Size(65, 20)
        Me.txtClientNumber.TabIndex = 5
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.ForeColor = System.Drawing.Color.Red
        Me.lblClientName.Location = New System.Drawing.Point(277, 309)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(0, 13)
        Me.lblClientName.TabIndex = 7
        '
        'chkShowClientList
        '
        Me.chkShowClientList.AutoSize = True
        Me.chkShowClientList.Checked = True
        Me.chkShowClientList.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowClientList.Location = New System.Drawing.Point(695, 377)
        Me.chkShowClientList.Name = "chkShowClientList"
        Me.chkShowClientList.Size = New System.Drawing.Size(96, 17)
        Me.chkShowClientList.TabIndex = 8
        Me.chkShowClientList.Text = "Show client list"
        Me.chkShowClientList.UseVisualStyleBackColor = True
        '
        'lblVisitCount
        '
        Me.lblVisitCount.AutoSize = True
        Me.lblVisitCount.Location = New System.Drawing.Point(701, 9)
        Me.lblVisitCount.Name = "lblVisitCount"
        Me.lblVisitCount.Size = New System.Drawing.Size(96, 13)
        Me.lblVisitCount.TabIndex = 9
        Me.lblVisitCount.Text = "Visits left to record:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(701, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Automatically add bags:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'numAddBags
        '
        Me.numAddBags.Location = New System.Drawing.Point(788, 342)
        Me.numAddBags.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numAddBags.Name = "numAddBags"
        Me.numAddBags.Size = New System.Drawing.Size(43, 20)
        Me.numAddBags.TabIndex = 11
        '
        'Delivery
        '
        Me.Delivery.Text = "Delivery"
        Me.Delivery.Width = 63
        '
        'frmRecordBags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 460)
        Me.Controls.Add(Me.lvVisits)
        Me.Controls.Add(Me.numAddBags)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVisitCount)
        Me.Controls.Add(Me.chkShowClientList)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.txtClientNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpBags)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.grpVisits)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecordBags"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record the number of bags used by a client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpBags.ResumeLayout(False)
        CType(Me.numAddBags, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpVisits As System.Windows.Forms.GroupBox
    Friend WithEvents lvVisits As System.Windows.Forms.ListView
    Friend WithEvents PersonID As System.Windows.Forms.ColumnHeader
    Friend WithEvents PersonName As System.Windows.Forms.ColumnHeader
    Friend WithEvents VisitDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents grpBags As System.Windows.Forms.GroupBox
    Friend WithEvents btnBags8 As System.Windows.Forms.Button
    Friend WithEvents btnBags7 As System.Windows.Forms.Button
    Friend WithEvents btnBags6 As System.Windows.Forms.Button
    Friend WithEvents btnBags5 As System.Windows.Forms.Button
    Friend WithEvents btnBags4 As System.Windows.Forms.Button
    Friend WithEvents btnBags3 As System.Windows.Forms.Button
    Friend WithEvents btnBags2 As System.Windows.Forms.Button
    Friend WithEvents btnBags1 As System.Windows.Forms.Button
    Friend WithEvents VisitID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents btnBags10 As System.Windows.Forms.Button
    Friend WithEvents btnBags9 As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtClientNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents chkShowClientList As System.Windows.Forms.CheckBox
    Friend WithEvents lblVisitCount As System.Windows.Forms.Label
    Friend WithEvents numAddBags As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ApptTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents Delivery As System.Windows.Forms.ColumnHeader
End Class
