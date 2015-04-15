<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetAvailability
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetAvailability))
        Me.cmbItemsToShow = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.clbItems = New System.Windows.Forms.CheckedListBox
        Me.btnDone = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.ReSize1 = New LarcomAndYoung.Windows.Forms.ReSize(Me.components)
        Me.SuspendLayout()
        '
        'cmbItemsToShow
        '
        Me.cmbItemsToShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemsToShow.FormattingEnabled = True
        Me.cmbItemsToShow.Items.AddRange(New Object() {"All", "Available", "Cold", "Cold Special", "Cold(2 only)", "Food", "Fresh", "Home", "Homeless", "Kid snack", "Personal care", "Special"})
        Me.cmbItemsToShow.Location = New System.Drawing.Point(113, 12)
        Me.cmbItemsToShow.MaxDropDownItems = 15
        Me.cmbItemsToShow.Name = "cmbItemsToShow"
        Me.cmbItemsToShow.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemsToShow.Sorted = True
        Me.cmbItemsToShow.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Items to show in list:"
        '
        'clbItems
        '
        Me.clbItems.CheckOnClick = True
        Me.clbItems.FormattingEnabled = True
        Me.clbItems.Location = New System.Drawing.Point(12, 39)
        Me.clbItems.Name = "clbItems"
        Me.clbItems.Size = New System.Drawing.Size(273, 514)
        Me.clbItems.TabIndex = 94
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(291, 530)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(147, 23)
        Me.btnDone.TabIndex = 95
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(291, 501)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(147, 23)
        Me.btnClear.TabIndex = 97
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 561
        Me.ReSize1.InitialHostContainerWidth = 450
        Me.ReSize1.Tag = Nothing
        '
        'frmSetAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 561)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.clbItems)
        Me.Controls.Add(Me.cmbItemsToShow)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetAvailability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set availability for today"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbItemsToShow As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clbItems As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
End Class
