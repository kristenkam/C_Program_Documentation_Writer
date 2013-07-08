<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncDocResults
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
    Me.txtFuncDocResults = New System.Windows.Forms.TextBox()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.lblFunctionDocumentation = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'txtFuncDocResults
    '
    Me.txtFuncDocResults.Location = New System.Drawing.Point(29, 49)
    Me.txtFuncDocResults.Multiline = True
    Me.txtFuncDocResults.Name = "txtFuncDocResults"
    Me.txtFuncDocResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.txtFuncDocResults.Size = New System.Drawing.Size(493, 220)
    Me.txtFuncDocResults.TabIndex = 0
    '
    'btnClose
    '
    Me.btnClose.Location = New System.Drawing.Point(187, 292)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(141, 32)
    Me.btnClose.TabIndex = 1
    Me.btnClose.Text = "Close"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'lblFunctionDocumentation
    '
    Me.lblFunctionDocumentation.AutoSize = True
    Me.lblFunctionDocumentation.Location = New System.Drawing.Point(26, 16)
    Me.lblFunctionDocumentation.Name = "lblFunctionDocumentation"
    Me.lblFunctionDocumentation.Size = New System.Drawing.Size(39, 13)
    Me.lblFunctionDocumentation.TabIndex = 2
    Me.lblFunctionDocumentation.Text = "Label1"
    '
    'frmFuncDocResults
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(552, 353)
    Me.Controls.Add(Me.lblFunctionDocumentation)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.txtFuncDocResults)
    Me.Name = "frmFuncDocResults"
    Me.Text = "Contents of Function Document"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtFuncDocResults As System.Windows.Forms.TextBox
  Friend WithEvents btnClose As System.Windows.Forms.Button
  Friend WithEvents lblFunctionDocumentation As System.Windows.Forms.Label
End Class
