<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintSampleTicket
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
        Me.btnWithOut = New System.Windows.Forms.Button
        Me.btnWith = New System.Windows.Forms.Button
        Me.btnNeverMind = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnWithOut
        '
        Me.btnWithOut.Location = New System.Drawing.Point(22, 22)
        Me.btnWithOut.Name = "btnWithOut"
        Me.btnWithOut.Size = New System.Drawing.Size(356, 48)
        Me.btnWithOut.TabIndex = 0
        Me.btnWithOut.Text = "Print sample ticket WITHOUT FacLess items"
        Me.btnWithOut.UseVisualStyleBackColor = True
        '
        'btnWith
        '
        Me.btnWith.Location = New System.Drawing.Point(22, 77)
        Me.btnWith.Name = "btnWith"
        Me.btnWith.Size = New System.Drawing.Size(356, 48)
        Me.btnWith.TabIndex = 1
        Me.btnWith.Text = "Print sample ticket WITH FacLess items"
        Me.btnWith.UseVisualStyleBackColor = True
        '
        'btnNeverMind
        '
        Me.btnNeverMind.Location = New System.Drawing.Point(22, 132)
        Me.btnNeverMind.Name = "btnNeverMind"
        Me.btnNeverMind.Size = New System.Drawing.Size(356, 48)
        Me.btnNeverMind.TabIndex = 2
        Me.btnNeverMind.Text = "Never mind, don't print a sample ticket"
        Me.btnNeverMind.UseVisualStyleBackColor = True
        '
        'frmPrintSampleTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 197)
        Me.Controls.Add(Me.btnNeverMind)
        Me.Controls.Add(Me.btnWith)
        Me.Controls.Add(Me.btnWithOut)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPrintSampleTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print a sample ticket"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnWithOut As System.Windows.Forms.Button
    Friend WithEvents btnWith As System.Windows.Forms.Button
    Friend WithEvents btnNeverMind As System.Windows.Forms.Button
End Class
