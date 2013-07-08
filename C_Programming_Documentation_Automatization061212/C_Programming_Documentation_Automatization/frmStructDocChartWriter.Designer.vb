<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStructDocChartWriter
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
    Me.btnSaveStudentDocInfo = New System.Windows.Forms.Button()
    Me.lblProgramName = New System.Windows.Forms.Label()
    Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
    Me.lblDocDate = New System.Windows.Forms.Label()
    Me.lblStudentName = New System.Windows.Forms.Label()
    Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
    Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
    Me.lblMainFunction = New System.Windows.Forms.Label()
    Me.txtInputNumSubFunc = New System.Windows.Forms.TextBox()
    Me.lblNumSubFunctions = New System.Windows.Forms.Label()
    Me.lblStructChartOutline = New System.Windows.Forms.Label()
    Me.lstStrucDoc = New System.Windows.Forms.ListBox()
    Me.btnCreateStructureChartDoc = New System.Windows.Forms.Button()
    Me.btnAppend = New System.Windows.Forms.Button()
    Me.btnSaveAndClose = New System.Windows.Forms.Button()
    Me.btnClear = New System.Windows.Forms.Button()
    Me.cboFuncName = New System.Windows.Forms.ComboBox()
    Me.gbxStudentProgInfo = New System.Windows.Forms.GroupBox()
    Me.cboInputProgramName = New System.Windows.Forms.ComboBox()
    Me.cboInputStudentName = New System.Windows.Forms.ComboBox()
    Me.gbxEnterFuncDoc = New System.Windows.Forms.GroupBox()
    Me.lblStatus = New System.Windows.Forms.Label()
    Me.lstStatus = New System.Windows.Forms.ListBox()
    Me.lblEnterStudProgBefore = New System.Windows.Forms.Label()
    Me.gbxStudentandProgramInfo = New System.Windows.Forms.GroupBox()
    Me.lblDocumentDateMem = New System.Windows.Forms.Label()
    Me.lblProgramNameMem = New System.Windows.Forms.Label()
    Me.lblStudentNameMem = New System.Windows.Forms.Label()
    Me.lblFileName = New System.Windows.Forms.Label()
    Me.gbxStudentProgInfo.SuspendLayout()
    Me.gbxEnterFuncDoc.SuspendLayout()
    Me.gbxStudentandProgramInfo.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnSaveStudentDocInfo
    '
    Me.btnSaveStudentDocInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSaveStudentDocInfo.Location = New System.Drawing.Point(340, 33)
    Me.btnSaveStudentDocInfo.Name = "btnSaveStudentDocInfo"
    Me.btnSaveStudentDocInfo.Size = New System.Drawing.Size(186, 88)
    Me.btnSaveStudentDocInfo.TabIndex = 6
    Me.btnSaveStudentDocInfo.Text = "Save Student and Program Documentation Information"
    Me.btnSaveStudentDocInfo.UseVisualStyleBackColor = True
    '
    'lblProgramName
    '
    Me.lblProgramName.AutoSize = True
    Me.lblProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProgramName.Location = New System.Drawing.Point(7, 110)
    Me.lblProgramName.Name = "lblProgramName"
    Me.lblProgramName.Size = New System.Drawing.Size(80, 13)
    Me.lblProgramName.TabIndex = 5
    Me.lblProgramName.Text = "Program Name:"
    '
    'dtpDocDate
    '
    Me.dtpDocDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpDocDate.Location = New System.Drawing.Point(101, 68)
    Me.dtpDocDate.Name = "dtpDocDate"
    Me.dtpDocDate.Size = New System.Drawing.Size(224, 20)
    Me.dtpDocDate.TabIndex = 4
    '
    'lblDocDate
    '
    Me.lblDocDate.AutoSize = True
    Me.lblDocDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocDate.Location = New System.Drawing.Point(7, 72)
    Me.lblDocDate.Name = "lblDocDate"
    Me.lblDocDate.Size = New System.Drawing.Size(85, 13)
    Me.lblDocDate.TabIndex = 3
    Me.lblDocDate.Text = "Document Date:"
    '
    'lblStudentName
    '
    Me.lblStudentName.AutoSize = True
    Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStudentName.Location = New System.Drawing.Point(7, 36)
    Me.lblStudentName.Name = "lblStudentName"
    Me.lblStudentName.Size = New System.Drawing.Size(75, 13)
    Me.lblStudentName.TabIndex = 1
    Me.lblStudentName.Text = "Student Name"
    '
    'LineShape1
    '
    Me.LineShape1.Name = "LineShape1"
    Me.LineShape1.X1 = 6
    Me.LineShape1.X2 = 775
    Me.LineShape1.Y1 = 170
    Me.LineShape1.Y2 = 171
    '
    'ShapeContainer1
    '
    Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
    Me.ShapeContainer1.Name = "ShapeContainer1"
    Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
    Me.ShapeContainer1.Size = New System.Drawing.Size(904, 534)
    Me.ShapeContainer1.TabIndex = 56
    Me.ShapeContainer1.TabStop = False
    '
    'lblMainFunction
    '
    Me.lblMainFunction.AutoSize = True
    Me.lblMainFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMainFunction.Location = New System.Drawing.Point(7, 38)
    Me.lblMainFunction.Name = "lblMainFunction"
    Me.lblMainFunction.Size = New System.Drawing.Size(112, 13)
    Me.lblMainFunction.TabIndex = 13
    Me.lblMainFunction.Text = "'Main' Function Name:"
    '
    'txtInputNumSubFunc
    '
    Me.txtInputNumSubFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInputNumSubFunc.Location = New System.Drawing.Point(143, 82)
    Me.txtInputNumSubFunc.Name = "txtInputNumSubFunc"
    Me.txtInputNumSubFunc.Size = New System.Drawing.Size(36, 20)
    Me.txtInputNumSubFunc.TabIndex = 16
    '
    'lblNumSubFunctions
    '
    Me.lblNumSubFunctions.AutoSize = True
    Me.lblNumSubFunctions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumSubFunctions.Location = New System.Drawing.Point(7, 85)
    Me.lblNumSubFunctions.Name = "lblNumSubFunctions"
    Me.lblNumSubFunctions.Size = New System.Drawing.Size(130, 13)
    Me.lblNumSubFunctions.TabIndex = 15
    Me.lblNumSubFunctions.Text = "Number of Sub Functions:"
    '
    'lblStructChartOutline
    '
    Me.lblStructChartOutline.AutoSize = True
    Me.lblStructChartOutline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStructChartOutline.Location = New System.Drawing.Point(443, 26)
    Me.lblStructChartOutline.Name = "lblStructChartOutline"
    Me.lblStructChartOutline.Size = New System.Drawing.Size(198, 13)
    Me.lblStructChartOutline.TabIndex = 17
    Me.lblStructChartOutline.Text = "Structure Chart (Outline) Documentation:"
    '
    'lstStrucDoc
    '
    Me.lstStrucDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstStrucDoc.FormattingEnabled = True
    Me.lstStrucDoc.Location = New System.Drawing.Point(446, 48)
    Me.lstStrucDoc.Name = "lstStrucDoc"
    Me.lstStrucDoc.Size = New System.Drawing.Size(224, 95)
    Me.lstStrucDoc.TabIndex = 18
    '
    'btnCreateStructureChartDoc
    '
    Me.btnCreateStructureChartDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCreateStructureChartDoc.Location = New System.Drawing.Point(14, 240)
    Me.btnCreateStructureChartDoc.Name = "btnCreateStructureChartDoc"
    Me.btnCreateStructureChartDoc.Size = New System.Drawing.Size(169, 91)
    Me.btnCreateStructureChartDoc.TabIndex = 21
    Me.btnCreateStructureChartDoc.Text = "Create Structure Chart (Outline)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Documentation"
    Me.btnCreateStructureChartDoc.UseVisualStyleBackColor = True
    '
    'btnAppend
    '
    Me.btnAppend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAppend.Location = New System.Drawing.Point(188, 240)
    Me.btnAppend.Name = "btnAppend"
    Me.btnAppend.Size = New System.Drawing.Size(177, 91)
    Me.btnAppend.TabIndex = 22
    Me.btnAppend.Text = "Save Structure Chart (Outline)  Documentation to Main Function Document (text fil" & _
        "e)"
    Me.btnAppend.UseVisualStyleBackColor = True
    '
    'btnSaveAndClose
    '
    Me.btnSaveAndClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSaveAndClose.Location = New System.Drawing.Point(551, 240)
    Me.btnSaveAndClose.Name = "btnSaveAndClose"
    Me.btnSaveAndClose.Size = New System.Drawing.Size(177, 91)
    Me.btnSaveAndClose.TabIndex = 24
    Me.btnSaveAndClose.Text = "View Structure Chart (Outline) Documentation  and Close Function Documentation Wr" & _
        "iter"
    Me.btnSaveAndClose.UseVisualStyleBackColor = True
    Me.btnSaveAndClose.Visible = False
    '
    'btnClear
    '
    Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnClear.Location = New System.Drawing.Point(368, 240)
    Me.btnClear.Name = "btnClear"
    Me.btnClear.Size = New System.Drawing.Size(177, 91)
    Me.btnClear.TabIndex = 23
    Me.btnClear.Text = "Clear Input Boxes and Create Additional Structure Chart (Outline) Documentation"
    Me.btnClear.UseVisualStyleBackColor = True
    '
    'cboFuncName
    '
    Me.cboFuncName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboFuncName.FormattingEnabled = True
    Me.cboFuncName.Location = New System.Drawing.Point(143, 30)
    Me.cboFuncName.Name = "cboFuncName"
    Me.cboFuncName.Size = New System.Drawing.Size(158, 21)
    Me.cboFuncName.Sorted = True
    Me.cboFuncName.TabIndex = 14
    '
    'gbxStudentProgInfo
    '
    Me.gbxStudentProgInfo.Controls.Add(Me.cboInputProgramName)
    Me.gbxStudentProgInfo.Controls.Add(Me.cboInputStudentName)
    Me.gbxStudentProgInfo.Controls.Add(Me.btnSaveStudentDocInfo)
    Me.gbxStudentProgInfo.Controls.Add(Me.lblStudentName)
    Me.gbxStudentProgInfo.Controls.Add(Me.lblDocDate)
    Me.gbxStudentProgInfo.Controls.Add(Me.dtpDocDate)
    Me.gbxStudentProgInfo.Controls.Add(Me.lblProgramName)
    Me.gbxStudentProgInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbxStudentProgInfo.Location = New System.Drawing.Point(6, 17)
    Me.gbxStudentProgInfo.Name = "gbxStudentProgInfo"
    Me.gbxStudentProgInfo.Size = New System.Drawing.Size(545, 134)
    Me.gbxStudentProgInfo.TabIndex = 0
    Me.gbxStudentProgInfo.TabStop = False
    Me.gbxStudentProgInfo.Text = "(1) Enter Student and Program Information:"
    '
    'cboInputProgramName
    '
    Me.cboInputProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboInputProgramName.FormattingEnabled = True
    Me.cboInputProgramName.Location = New System.Drawing.Point(101, 106)
    Me.cboInputProgramName.Name = "cboInputProgramName"
    Me.cboInputProgramName.Size = New System.Drawing.Size(224, 21)
    Me.cboInputProgramName.Sorted = True
    Me.cboInputProgramName.TabIndex = 57
    '
    'cboInputStudentName
    '
    Me.cboInputStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboInputStudentName.FormattingEnabled = True
    Me.cboInputStudentName.Location = New System.Drawing.Point(101, 31)
    Me.cboInputStudentName.Name = "cboInputStudentName"
    Me.cboInputStudentName.Size = New System.Drawing.Size(224, 21)
    Me.cboInputStudentName.Sorted = True
    Me.cboInputStudentName.TabIndex = 2
    '
    'gbxEnterFuncDoc
    '
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblStatus)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lstStatus)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnAppend)
    Me.gbxEnterFuncDoc.Controls.Add(Me.cboFuncName)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnSaveAndClose)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lstStrucDoc)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnClear)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnCreateStructureChartDoc)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblMainFunction)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblNumSubFunctions)
    Me.gbxEnterFuncDoc.Controls.Add(Me.txtInputNumSubFunc)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblStructChartOutline)
    Me.gbxEnterFuncDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbxEnterFuncDoc.Location = New System.Drawing.Point(6, 192)
    Me.gbxEnterFuncDoc.Name = "gbxEnterFuncDoc"
    Me.gbxEnterFuncDoc.Size = New System.Drawing.Size(768, 334)
    Me.gbxEnterFuncDoc.TabIndex = 12
    Me.gbxEnterFuncDoc.TabStop = False
    Me.gbxEnterFuncDoc.Text = "(2) Enter Structure Chart (Outline) Documentation Information:"
    Me.gbxEnterFuncDoc.Visible = False
    '
    'lblStatus
    '
    Me.lblStatus.AutoSize = True
    Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStatus.Location = New System.Drawing.Point(443, 156)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(167, 13)
    Me.lblStatus.TabIndex = 19
    Me.lblStatus.Text = "Function Document Writer Status:"
    '
    'lstStatus
    '
    Me.lstStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstStatus.FormattingEnabled = True
    Me.lstStatus.HorizontalScrollbar = True
    Me.lstStatus.Location = New System.Drawing.Point(446, 173)
    Me.lstStatus.Name = "lstStatus"
    Me.lstStatus.ScrollAlwaysVisible = True
    Me.lstStatus.Size = New System.Drawing.Size(296, 56)
    Me.lstStatus.TabIndex = 20
    '
    'lblEnterStudProgBefore
    '
    Me.lblEnterStudProgBefore.AutoSize = True
    Me.lblEnterStudProgBefore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEnterStudProgBefore.Location = New System.Drawing.Point(54, 154)
    Me.lblEnterStudProgBefore.Name = "lblEnterStudProgBefore"
    Me.lblEnterStudProgBefore.Size = New System.Drawing.Size(742, 72)
    Me.lblEnterStudProgBefore.TabIndex = 11
    Me.lblEnterStudProgBefore.Text = "ENTER AND SAVE STUDENT PROGRAM DOCUMENTATION INFORMATION " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BEFORE ENTERING STRUCT" & _
        "URE CHART (OUTLINE) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DOCUMENTATION INFORMATION"
    Me.lblEnterStudProgBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'gbxStudentandProgramInfo
    '
    Me.gbxStudentandProgramInfo.Controls.Add(Me.lblDocumentDateMem)
    Me.gbxStudentandProgramInfo.Controls.Add(Me.lblProgramNameMem)
    Me.gbxStudentandProgramInfo.Controls.Add(Me.lblStudentNameMem)
    Me.gbxStudentandProgramInfo.Location = New System.Drawing.Point(588, 21)
    Me.gbxStudentandProgramInfo.Name = "gbxStudentandProgramInfo"
    Me.gbxStudentandProgramInfo.Size = New System.Drawing.Size(256, 119)
    Me.gbxStudentandProgramInfo.TabIndex = 7
    Me.gbxStudentandProgramInfo.TabStop = False
    Me.gbxStudentandProgramInfo.Text = "Student & Program Information In Memory:"
    '
    'lblDocumentDateMem
    '
    Me.lblDocumentDateMem.AutoSize = True
    Me.lblDocumentDateMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocumentDateMem.Location = New System.Drawing.Point(17, 89)
    Me.lblDocumentDateMem.Name = "lblDocumentDateMem"
    Me.lblDocumentDateMem.Size = New System.Drawing.Size(85, 13)
    Me.lblDocumentDateMem.TabIndex = 10
    Me.lblDocumentDateMem.Text = "Document Date:"
    '
    'lblProgramNameMem
    '
    Me.lblProgramNameMem.AutoSize = True
    Me.lblProgramNameMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProgramNameMem.Location = New System.Drawing.Point(17, 58)
    Me.lblProgramNameMem.Name = "lblProgramNameMem"
    Me.lblProgramNameMem.Size = New System.Drawing.Size(80, 13)
    Me.lblProgramNameMem.TabIndex = 9
    Me.lblProgramNameMem.Text = "Program Name:"
    '
    'lblStudentNameMem
    '
    Me.lblStudentNameMem.AutoSize = True
    Me.lblStudentNameMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStudentNameMem.Location = New System.Drawing.Point(17, 30)
    Me.lblStudentNameMem.Name = "lblStudentNameMem"
    Me.lblStudentNameMem.Size = New System.Drawing.Size(78, 13)
    Me.lblStudentNameMem.TabIndex = 8
    Me.lblStudentNameMem.Text = "Student Name:"
    '
    'lblFileName
    '
    Me.lblFileName.AutoSize = True
    Me.lblFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFileName.Location = New System.Drawing.Point(585, 154)
    Me.lblFileName.Name = "lblFileName"
    Me.lblFileName.Size = New System.Drawing.Size(67, 13)
    Me.lblFileName.TabIndex = 58
    Me.lblFileName.Text = "File Name:"
    '
    'frmStructDocChartWriter
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(904, 534)
    Me.Controls.Add(Me.lblEnterStudProgBefore)
    Me.Controls.Add(Me.lblFileName)
    Me.Controls.Add(Me.gbxStudentandProgramInfo)
    Me.Controls.Add(Me.gbxStudentProgInfo)
    Me.Controls.Add(Me.gbxEnterFuncDoc)
    Me.Controls.Add(Me.ShapeContainer1)
    Me.Name = "frmStructDocChartWriter"
    Me.Text = "Structure Chart (Outline) Writer"
    Me.gbxStudentProgInfo.ResumeLayout(False)
    Me.gbxStudentProgInfo.PerformLayout()
    Me.gbxEnterFuncDoc.ResumeLayout(False)
    Me.gbxEnterFuncDoc.PerformLayout()
    Me.gbxStudentandProgramInfo.ResumeLayout(False)
    Me.gbxStudentandProgramInfo.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnSaveStudentDocInfo As System.Windows.Forms.Button
  Friend WithEvents lblProgramName As System.Windows.Forms.Label
  Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblDocDate As System.Windows.Forms.Label
  Friend WithEvents lblStudentName As System.Windows.Forms.Label
  Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
  Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
  Friend WithEvents lblMainFunction As System.Windows.Forms.Label
  Friend WithEvents txtInputNumSubFunc As System.Windows.Forms.TextBox
  Friend WithEvents lblNumSubFunctions As System.Windows.Forms.Label
  Friend WithEvents lblStructChartOutline As System.Windows.Forms.Label
  Friend WithEvents lstStrucDoc As System.Windows.Forms.ListBox
  Friend WithEvents btnCreateStructureChartDoc As System.Windows.Forms.Button
  Friend WithEvents btnAppend As System.Windows.Forms.Button
  Friend WithEvents btnSaveAndClose As System.Windows.Forms.Button
  Friend WithEvents btnClear As System.Windows.Forms.Button
  Friend WithEvents cboFuncName As System.Windows.Forms.ComboBox
  Friend WithEvents gbxStudentProgInfo As System.Windows.Forms.GroupBox
  Friend WithEvents gbxEnterFuncDoc As System.Windows.Forms.GroupBox
  Friend WithEvents lblStatus As System.Windows.Forms.Label
  Friend WithEvents lstStatus As System.Windows.Forms.ListBox
  Friend WithEvents lblEnterStudProgBefore As System.Windows.Forms.Label
  Friend WithEvents gbxStudentandProgramInfo As System.Windows.Forms.GroupBox
  Friend WithEvents lblDocumentDateMem As System.Windows.Forms.Label
  Friend WithEvents lblProgramNameMem As System.Windows.Forms.Label
  Friend WithEvents lblStudentNameMem As System.Windows.Forms.Label
  Friend WithEvents cboInputProgramName As System.Windows.Forms.ComboBox
  Friend WithEvents cboInputStudentName As System.Windows.Forms.ComboBox
  Friend WithEvents lblFileName As System.Windows.Forms.Label
End Class
