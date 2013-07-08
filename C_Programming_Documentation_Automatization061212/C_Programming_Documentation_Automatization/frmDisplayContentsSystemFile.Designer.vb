<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayContentsSystemFile
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
    Me.txtSystemFileContents = New System.Windows.Forms.TextBox()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnRefresh = New System.Windows.Forms.Button()
    Me.lblFileNameDisplayed = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'txtSystemFileContents
    '
    Me.txtSystemFileContents.Location = New System.Drawing.Point(33, 22)
    Me.txtSystemFileContents.Multiline = True
    Me.txtSystemFileContents.Name = "txtSystemFileContents"
    Me.txtSystemFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.txtSystemFileContents.Size = New System.Drawing.Size(403, 297)
    Me.txtSystemFileContents.TabIndex = 0
    '
    'btnClose
    '
    Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnClose.Location = New System.Drawing.Point(238, 335)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(178, 64)
    Me.btnClose.TabIndex = 1
    Me.btnClose.Text = "Close"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'btnRefresh
    '
    Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRefresh.Location = New System.Drawing.Point(33, 335)
    Me.btnRefresh.Name = "btnRefresh"
    Me.btnRefresh.Size = New System.Drawing.Size(176, 64)
    Me.btnRefresh.TabIndex = 2
    Me.btnRefresh.Text = "Refresh"
    Me.btnRefresh.UseVisualStyleBackColor = True
    '
    'lblFileNameDisplayed
    '
    Me.lblFileNameDisplayed.AutoSize = True
    Me.lblFileNameDisplayed.Location = New System.Drawing.Point(30, 6)
    Me.lblFileNameDisplayed.Name = "lblFileNameDisplayed"
    Me.lblFileNameDisplayed.Size = New System.Drawing.Size(62, 13)
    Me.lblFileNameDisplayed.TabIndex = 3
    Me.lblFileNameDisplayed.Text = "placeholder"
    '
    'frmDisplayContentsSystemFile
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(462, 431)
    Me.Controls.Add(Me.lblFileNameDisplayed)
    Me.Controls.Add(Me.btnRefresh)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.txtSystemFileContents)
    Me.Name = "frmDisplayContentsSystemFile"
    Me.Text = "placeholder"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtSystemFileContents As System.Windows.Forms.TextBox
  Friend WithEvents btnClose As System.Windows.Forms.Button
  Friend WithEvents btnRefresh As System.Windows.Forms.Button
  Friend WithEvents lblFileNameDisplayed As System.Windows.Forms.Label
End Class
