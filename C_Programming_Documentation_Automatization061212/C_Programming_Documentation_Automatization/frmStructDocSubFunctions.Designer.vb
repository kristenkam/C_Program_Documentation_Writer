<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStructDocSubFunctions
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
    Me.cboFuncName = New System.Windows.Forms.ComboBox()
    Me.lblSubFuncName = New System.Windows.Forms.Label()
    Me.btn = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'cboFuncName
    '
    Me.cboFuncName.FormattingEnabled = True
    Me.cboFuncName.Location = New System.Drawing.Point(258, 21)
    Me.cboFuncName.Name = "cboFuncName"
    Me.cboFuncName.Size = New System.Drawing.Size(395, 21)
    Me.cboFuncName.Sorted = True
    Me.cboFuncName.TabIndex = 0
    '
    'lblSubFuncName
    '
    Me.lblSubFuncName.AutoSize = True
    Me.lblSubFuncName.Location = New System.Drawing.Point(12, 29)
    Me.lblSubFuncName.Name = "lblSubFuncName"
    Me.lblSubFuncName.Size = New System.Drawing.Size(175, 13)
    Me.lblSubFuncName.TabIndex = 1
    Me.lblSubFuncName.Text = "Enter Name of Sub Function Name:"
    '
    'btn
    '
    Me.btn.Location = New System.Drawing.Point(204, 73)
    Me.btn.Name = "btn"
    Me.btn.Size = New System.Drawing.Size(75, 23)
    Me.btn.TabIndex = 2
    Me.btn.Text = "Enter"
    Me.btn.UseVisualStyleBackColor = True
    '
    'frmStructDocSubFunctions
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(736, 113)
    Me.Controls.Add(Me.btn)
    Me.Controls.Add(Me.lblSubFuncName)
    Me.Controls.Add(Me.cboFuncName)
    Me.Name = "frmStructDocSubFunctions"
    Me.Text = "Sub Function Name"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboFuncName As System.Windows.Forms.ComboBox
  Friend WithEvents lblSubFuncName As System.Windows.Forms.Label
  Friend WithEvents btn As System.Windows.Forms.Button
End Class
