<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStructDocResults
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
    Me.lblStructureChartDoc = New System.Windows.Forms.Label()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.txtStructDocResults = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lblStructureChartDoc
    '
    Me.lblStructureChartDoc.AutoSize = True
    Me.lblStructureChartDoc.Location = New System.Drawing.Point(28, 22)
    Me.lblStructureChartDoc.Name = "lblStructureChartDoc"
    Me.lblStructureChartDoc.Size = New System.Drawing.Size(39, 13)
    Me.lblStructureChartDoc.TabIndex = 5
    Me.lblStructureChartDoc.Text = "Label1"
    '
    'btnClose
    '
    Me.btnClose.Location = New System.Drawing.Point(189, 298)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(141, 32)
    Me.btnClose.TabIndex = 4
    Me.btnClose.Text = "Close"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'txtStructDocResults
    '
    Me.txtStructDocResults.Location = New System.Drawing.Point(31, 55)
    Me.txtStructDocResults.Multiline = True
    Me.txtStructDocResults.Name = "txtStructDocResults"
    Me.txtStructDocResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.txtStructDocResults.Size = New System.Drawing.Size(493, 220)
    Me.txtStructDocResults.TabIndex = 3
    '
    'frmStructDocResults
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(552, 353)
    Me.Controls.Add(Me.lblStructureChartDoc)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.txtStructDocResults)
    Me.Name = "frmStructDocResults"
    Me.Text = "Contents of Structure Chart (Outline) Document"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblStructureChartDoc As System.Windows.Forms.Label
  Friend WithEvents btnClose As System.Windows.Forms.Button
  Friend WithEvents txtStructDocResults As System.Windows.Forms.TextBox
End Class
