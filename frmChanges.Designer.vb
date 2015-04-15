<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChanges
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
        Me.lblWhatsNew = New System.Windows.Forms.Label
        Me.chkDontShowAgain = New System.Windows.Forms.CheckBox
        Me.btnDone = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ReSize1
        '
        Me.ReSize1.About = Nothing
        Me.ReSize1.AutoCenterFormOnLoad = False
        Me.ReSize1.Enabled = True
        Me.ReSize1.HostContainer = Me
        Me.ReSize1.InitialHostContainerHeight = 407
        Me.ReSize1.InitialHostContainerWidth = 624
        Me.ReSize1.Tag = Nothing
        '
        'lblWhatsNew
        '
        Me.lblWhatsNew.Location = New System.Drawing.Point(58, 40)
        Me.lblWhatsNew.Name = "lblWhatsNew"
        Me.lblWhatsNew.Size = New System.Drawing.Size(554, 339)
        Me.lblWhatsNew.TabIndex = 0
        Me.lblWhatsNew.Text = "What's new!"
        '
        'chkDontShowAgain
        '
        Me.chkDontShowAgain.AutoSize = True
        Me.chkDontShowAgain.Location = New System.Drawing.Point(27, 9)
        Me.chkDontShowAgain.Name = "chkDontShowAgain"
        Me.chkDontShowAgain.Size = New System.Drawing.Size(184, 17)
        Me.chkDontShowAgain.TabIndex = 1
        Me.chkDontShowAgain.Text = "Don't show these changes again."
        Me.chkDontShowAgain.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(547, 382)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'frmChanges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 407)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.chkDontShowAgain)
        Me.Controls.Add(Me.lblWhatsNew)
        Me.Name = "frmChanges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Here's what's new!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReSize1 As LarcomAndYoung.Windows.Forms.ReSize
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents chkDontShowAgain As System.Windows.Forms.CheckBox
    Friend WithEvents lblWhatsNew As System.Windows.Forms.Label
End Class
