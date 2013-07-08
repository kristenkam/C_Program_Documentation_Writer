<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateParamtr
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
    Me.btnInsertToPre = New System.Windows.Forms.Button()
    Me.btnClear = New System.Windows.Forms.Button()
    Me.btnCreateArgument = New System.Windows.Forms.Button()
    Me.lblArgument = New System.Windows.Forms.Label()
    Me.lblParameter = New System.Windows.Forms.Label()
    Me.lblArgParamType = New System.Windows.Forms.Label()
    Me.txtArguementParameter = New System.Windows.Forms.TextBox()
    Me.cboParameterType = New System.Windows.Forms.ComboBox()
    Me.cboParameterName = New System.Windows.Forms.ComboBox()
    Me.SuspendLayout()
    '
    'btnInsertToPre
    '
    Me.btnInsertToPre.Location = New System.Drawing.Point(280, 128)
    Me.btnInsertToPre.Name = "btnInsertToPre"
    Me.btnInsertToPre.Size = New System.Drawing.Size(75, 53)
    Me.btnInsertToPre.TabIndex = 17
    Me.btnInsertToPre.Text = "Insert Argument to Pre or Post"
    Me.btnInsertToPre.UseVisualStyleBackColor = True
    '
    'btnClear
    '
    Me.btnClear.Location = New System.Drawing.Point(158, 128)
    Me.btnClear.Name = "btnClear"
    Me.btnClear.Size = New System.Drawing.Size(75, 53)
    Me.btnClear.TabIndex = 16
    Me.btnClear.Text = "Clear Fields"
    Me.btnClear.UseVisualStyleBackColor = True
    '
    'btnCreateArgument
    '
    Me.btnCreateArgument.Location = New System.Drawing.Point(44, 128)
    Me.btnCreateArgument.Name = "btnCreateArgument"
    Me.btnCreateArgument.Size = New System.Drawing.Size(75, 53)
    Me.btnCreateArgument.TabIndex = 15
    Me.btnCreateArgument.Text = "Create Argument"
    Me.btnCreateArgument.UseVisualStyleBackColor = True
    '
    'lblArgument
    '
    Me.lblArgument.AutoSize = True
    Me.lblArgument.Location = New System.Drawing.Point(41, 98)
    Me.lblArgument.Name = "lblArgument"
    Me.lblArgument.Size = New System.Drawing.Size(55, 13)
    Me.lblArgument.TabIndex = 14
    Me.lblArgument.Text = "Argument:"
    '
    'lblParameter
    '
    Me.lblParameter.AutoSize = True
    Me.lblParameter.Location = New System.Drawing.Point(41, 33)
    Me.lblParameter.Name = "lblParameter"
    Me.lblParameter.Size = New System.Drawing.Size(122, 13)
    Me.lblParameter.TabIndex = 13
    Me.lblParameter.Text = "Select Parameter Name:"
    '
    'lblArgParamType
    '
    Me.lblArgParamType.AutoSize = True
    Me.lblArgParamType.Location = New System.Drawing.Point(227, 33)
    Me.lblArgParamType.Name = "lblArgParamType"
    Me.lblArgParamType.Size = New System.Drawing.Size(115, 13)
    Me.lblArgParamType.TabIndex = 12
    Me.lblArgParamType.Text = "Select Parameter Type"
    '
    'txtArguementParameter
    '
    Me.txtArguementParameter.Location = New System.Drawing.Point(102, 91)
    Me.txtArguementParameter.Name = "txtArguementParameter"
    Me.txtArguementParameter.ReadOnly = True
    Me.txtArguementParameter.Size = New System.Drawing.Size(196, 20)
    Me.txtArguementParameter.TabIndex = 11
    '
    'cboParameterType
    '
    Me.cboParameterType.FormattingEnabled = True
    Me.cboParameterType.Location = New System.Drawing.Point(230, 49)
    Me.cboParameterType.Name = "cboParameterType"
    Me.cboParameterType.Size = New System.Drawing.Size(156, 21)
    Me.cboParameterType.Sorted = True
    Me.cboParameterType.TabIndex = 10
    '
    'cboParameterName
    '
    Me.cboParameterName.FormattingEnabled = True
    Me.cboParameterName.Location = New System.Drawing.Point(44, 49)
    Me.cboParameterName.Name = "cboParameterName"
    Me.cboParameterName.Size = New System.Drawing.Size(156, 21)
    Me.cboParameterName.Sorted = True
    Me.cboParameterName.TabIndex = 9
    '
    'frmCreateParamtr
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(426, 215)
    Me.Controls.Add(Me.btnInsertToPre)
    Me.Controls.Add(Me.btnClear)
    Me.Controls.Add(Me.btnCreateArgument)
    Me.Controls.Add(Me.lblArgument)
    Me.Controls.Add(Me.lblParameter)
    Me.Controls.Add(Me.lblArgParamType)
    Me.Controls.Add(Me.txtArguementParameter)
    Me.Controls.Add(Me.cboParameterType)
    Me.Controls.Add(Me.cboParameterName)
    Me.Name = "frmCreateParamtr"
    Me.Text = "Create Parameter"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnInsertToPre As System.Windows.Forms.Button
  Friend WithEvents btnClear As System.Windows.Forms.Button
  Friend WithEvents btnCreateArgument As System.Windows.Forms.Button
  Friend WithEvents lblArgument As System.Windows.Forms.Label
  Friend WithEvents lblParameter As System.Windows.Forms.Label
  Friend WithEvents lblArgParamType As System.Windows.Forms.Label
  Friend WithEvents txtArguementParameter As System.Windows.Forms.TextBox
  Friend WithEvents cboParameterType As System.Windows.Forms.ComboBox
  Friend WithEvents cboParameterName As System.Windows.Forms.ComboBox
End Class
