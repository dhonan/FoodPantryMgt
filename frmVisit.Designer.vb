<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisit
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
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblClientName = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.datVisitDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.numNumberOfBags = New System.Windows.Forms.NumericUpDown
        Me.chkDelivery = New System.Windows.Forms.CheckBox
        Me.btnDone = New System.Windows.Forms.Button
        Me.btnUpdateAndDone = New System.Windows.Forms.Button
        CType(Me.numNumberOfBags, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 142
        Me.ReSize1.InitialHostContainerWidth = 301
        Me.ReSize1.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client:"
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Location = New System.Drawing.Point(92, 12)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(35, 13)
        Me.lblClientName.TabIndex = 1
        Me.lblClientName.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Visit date:"
        '
        'datVisitDate
        '
        Me.datVisitDate.Location = New System.Drawing.Point(92, 29)
        Me.datVisitDate.Name = "datVisitDate"
        Me.datVisitDate.Size = New System.Drawing.Size(200, 20)
        Me.datVisitDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of bags:"
        '
        'numNumberOfBags
        '
        Me.numNumberOfBags.Location = New System.Drawing.Point(92, 55)
        Me.numNumberOfBags.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.numNumberOfBags.Name = "numNumberOfBags"
        Me.numNumberOfBags.Size = New System.Drawing.Size(56, 20)
        Me.numNumberOfBags.TabIndex = 5
        Me.numNumberOfBags.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(92, 81)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(64, 17)
        Me.chkDelivery.TabIndex = 6
        Me.chkDelivery.Text = "Delivery"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(152, 109)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(140, 23)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "Done, don't change"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnUpdateAndDone
        '
        Me.btnUpdateAndDone.Location = New System.Drawing.Point(12, 109)
        Me.btnUpdateAndDone.Name = "btnUpdateAndDone"
        Me.btnUpdateAndDone.Size = New System.Drawing.Size(134, 23)
        Me.btnUpdateAndDone.TabIndex = 8
        Me.btnUpdateAndDone.Text = "Save changes and Done"
        Me.btnUpdateAndDone.UseVisualStyleBackColor = True
        Me.btnUpdateAndDone.Visible = False
        '
        'frmVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 142)
        Me.Controls.Add(Me.btnUpdateAndDone)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.chkDelivery)
        Me.Controls.Add(Me.numNumberOfBags)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.datVisitDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVisit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit a visit"
        CType(Me.numNumberOfBags, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents numNumberOfBags As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datVisitDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateAndDone As System.Windows.Forms.Button
End Class
