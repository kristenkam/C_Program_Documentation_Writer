<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainWindow
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
    Me.lblDocumentCreateHeading = New System.Windows.Forms.Label()
    Me.btnCreateFuncDoc = New System.Windows.Forms.Button()
    Me.btnCreateStrctureChart = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
    Me.linHorizontal = New Microsoft.VisualBasic.PowerPacks.LineShape()
    Me.btnCreateBltInFuncOrVarName = New System.Windows.Forms.Label()
    Me.btnAddUserName = New System.Windows.Forms.Button()
    Me.txtInputUserName = New System.Windows.Forms.TextBox()
    Me.lblCreateUserName = New System.Windows.Forms.Label()
    Me.btnCreateProgramName = New System.Windows.Forms.Button()
    Me.txtCreateProgramName = New System.Windows.Forms.TextBox()
    Me.lblCreateProgramName = New System.Windows.Forms.Label()
    Me.btnAddFunction = New System.Windows.Forms.Button()
    Me.txtInputUserDefFunc = New System.Windows.Forms.TextBox()
    Me.lblCreateProgramFunctions = New System.Windows.Forms.Label()
    Me.btnAddVariable = New System.Windows.Forms.Button()
    Me.txtInputVariableName = New System.Windows.Forms.TextBox()
    Me.lblCreateVariableName = New System.Windows.Forms.Label()
    Me.btnAddFuncVarType = New System.Windows.Forms.Button()
    Me.txtInputFuncVarType = New System.Windows.Forms.TextBox()
    Me.btnDisplayUserList = New System.Windows.Forms.Button()
    Me.btnDisplayProgramNameList = New System.Windows.Forms.Button()
    Me.btnDisplayFuncNameList = New System.Windows.Forms.Button()
    Me.btnDisplayFuncVarTypeList = New System.Windows.Forms.Button()
    Me.btnDisplayVariableNameList = New System.Windows.Forms.Button()
    Me.lblHeadingUpdateSysLists = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'lblDocumentCreateHeading
    '
    Me.lblDocumentCreateHeading.AutoSize = True
    Me.lblDocumentCreateHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocumentCreateHeading.Location = New System.Drawing.Point(66, 289)
    Me.lblDocumentCreateHeading.Name = "lblDocumentCreateHeading"
    Me.lblDocumentCreateHeading.Size = New System.Drawing.Size(515, 24)
    Me.lblDocumentCreateHeading.TabIndex = 20
    Me.lblDocumentCreateHeading.Text = "CHOOSE THE DOCUMENTATION TYPE TO CREATE"
    Me.lblDocumentCreateHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'btnCreateFuncDoc
    '
    Me.btnCreateFuncDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCreateFuncDoc.Location = New System.Drawing.Point(26, 332)
    Me.btnCreateFuncDoc.Name = "btnCreateFuncDoc"
    Me.btnCreateFuncDoc.Size = New System.Drawing.Size(136, 73)
    Me.btnCreateFuncDoc.TabIndex = 21
    Me.btnCreateFuncDoc.Text = "Create a Function Document"
    Me.btnCreateFuncDoc.UseVisualStyleBackColor = True
    '
    'btnCreateStrctureChart
    '
    Me.btnCreateStrctureChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCreateStrctureChart.Location = New System.Drawing.Point(182, 332)
    Me.btnCreateStrctureChart.Name = "btnCreateStrctureChart"
    Me.btnCreateStrctureChart.Size = New System.Drawing.Size(153, 73)
    Me.btnCreateStrctureChart.TabIndex = 22
    Me.btnCreateStrctureChart.Text = "Create a Structure Chart"
    Me.btnCreateStrctureChart.UseVisualStyleBackColor = True
    '
    'btnClose
    '
    Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnClose.Location = New System.Drawing.Point(356, 332)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(252, 73)
    Me.btnClose.TabIndex = 23
    Me.btnClose.Text = "&Close Application"
    Me.btnClose.UseVisualStyleBackColor = True
    '
    'ShapeContainer1
    '
    Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
    Me.ShapeContainer1.Name = "ShapeContainer1"
    Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.linHorizontal})
    Me.ShapeContainer1.Size = New System.Drawing.Size(635, 433)
    Me.ShapeContainer1.TabIndex = 4
    Me.ShapeContainer1.TabStop = False
    '
    'linHorizontal
    '
    Me.linHorizontal.Name = "linHorizontal"
    Me.linHorizontal.X1 = 9
    Me.linHorizontal.X2 = 619
    Me.linHorizontal.Y1 = 276
    Me.linHorizontal.Y2 = 275
    '
    'btnCreateBltInFuncOrVarName
    '
    Me.btnCreateBltInFuncOrVarName.AutoSize = True
    Me.btnCreateBltInFuncOrVarName.Location = New System.Drawing.Point(14, 180)
    Me.btnCreateBltInFuncOrVarName.Name = "btnCreateBltInFuncOrVarName"
    Me.btnCreateBltInFuncOrVarName.Size = New System.Drawing.Size(165, 13)
    Me.btnCreateBltInFuncOrVarName.TabIndex = 12
    Me.btnCreateBltInFuncOrVarName.Text = "Create Function or Variable Type:"
    '
    'btnAddUserName
    '
    Me.btnAddUserName.Location = New System.Drawing.Point(341, 47)
    Me.btnAddUserName.Name = "btnAddUserName"
    Me.btnAddUserName.Size = New System.Drawing.Size(150, 38)
    Me.btnAddUserName.TabIndex = 2
    Me.btnAddUserName.Text = "Add User Name to List"
    Me.btnAddUserName.UseVisualStyleBackColor = True
    '
    'txtInputUserName
    '
    Me.txtInputUserName.Location = New System.Drawing.Point(203, 47)
    Me.txtInputUserName.Name = "txtInputUserName"
    Me.txtInputUserName.Size = New System.Drawing.Size(132, 20)
    Me.txtInputUserName.TabIndex = 1
    '
    'lblCreateUserName
    '
    Me.lblCreateUserName.AutoSize = True
    Me.lblCreateUserName.Location = New System.Drawing.Point(14, 50)
    Me.lblCreateUserName.Name = "lblCreateUserName"
    Me.lblCreateUserName.Size = New System.Drawing.Size(97, 13)
    Me.lblCreateUserName.TabIndex = 0
    Me.lblCreateUserName.Text = "Create User Name:"
    '
    'btnCreateProgramName
    '
    Me.btnCreateProgramName.Location = New System.Drawing.Point(341, 90)
    Me.btnCreateProgramName.Name = "btnCreateProgramName"
    Me.btnCreateProgramName.Size = New System.Drawing.Size(150, 38)
    Me.btnCreateProgramName.TabIndex = 6
    Me.btnCreateProgramName.Text = "Add Program Name to List"
    Me.btnCreateProgramName.UseVisualStyleBackColor = True
    '
    'txtCreateProgramName
    '
    Me.txtCreateProgramName.Location = New System.Drawing.Point(203, 90)
    Me.txtCreateProgramName.Name = "txtCreateProgramName"
    Me.txtCreateProgramName.Size = New System.Drawing.Size(132, 20)
    Me.txtCreateProgramName.TabIndex = 5
    '
    'lblCreateProgramName
    '
    Me.lblCreateProgramName.AutoSize = True
    Me.lblCreateProgramName.Location = New System.Drawing.Point(14, 93)
    Me.lblCreateProgramName.Name = "lblCreateProgramName"
    Me.lblCreateProgramName.Size = New System.Drawing.Size(114, 13)
    Me.lblCreateProgramName.TabIndex = 4
    Me.lblCreateProgramName.Text = "Create Program Name:"
    '
    'btnAddFunction
    '
    Me.btnAddFunction.Location = New System.Drawing.Point(341, 133)
    Me.btnAddFunction.Name = "btnAddFunction"
    Me.btnAddFunction.Size = New System.Drawing.Size(150, 38)
    Me.btnAddFunction.TabIndex = 10
    Me.btnAddFunction.Text = "Add Function Name to List"
    Me.btnAddFunction.UseVisualStyleBackColor = True
    '
    'txtInputUserDefFunc
    '
    Me.txtInputUserDefFunc.Location = New System.Drawing.Point(203, 133)
    Me.txtInputUserDefFunc.Name = "txtInputUserDefFunc"
    Me.txtInputUserDefFunc.Size = New System.Drawing.Size(132, 20)
    Me.txtInputUserDefFunc.TabIndex = 9
    '
    'lblCreateProgramFunctions
    '
    Me.lblCreateProgramFunctions.AutoSize = True
    Me.lblCreateProgramFunctions.Location = New System.Drawing.Point(14, 136)
    Me.lblCreateProgramFunctions.Name = "lblCreateProgramFunctions"
    Me.lblCreateProgramFunctions.Size = New System.Drawing.Size(116, 13)
    Me.lblCreateProgramFunctions.TabIndex = 8
    Me.lblCreateProgramFunctions.Text = "Create Function Name:"
    '
    'btnAddVariable
    '
    Me.btnAddVariable.Location = New System.Drawing.Point(341, 221)
    Me.btnAddVariable.Name = "btnAddVariable"
    Me.btnAddVariable.Size = New System.Drawing.Size(150, 38)
    Me.btnAddVariable.TabIndex = 18
    Me.btnAddVariable.Text = "Add Variable Name to List"
    Me.btnAddVariable.UseVisualStyleBackColor = True
    '
    'txtInputVariableName
    '
    Me.txtInputVariableName.Location = New System.Drawing.Point(203, 221)
    Me.txtInputVariableName.Name = "txtInputVariableName"
    Me.txtInputVariableName.Size = New System.Drawing.Size(132, 20)
    Me.txtInputVariableName.TabIndex = 17
    '
    'lblCreateVariableName
    '
    Me.lblCreateVariableName.AutoSize = True
    Me.lblCreateVariableName.Location = New System.Drawing.Point(14, 224)
    Me.lblCreateVariableName.Name = "lblCreateVariableName"
    Me.lblCreateVariableName.Size = New System.Drawing.Size(138, 13)
    Me.lblCreateVariableName.TabIndex = 16
    Me.lblCreateVariableName.Text = "Create New Variable Name:"
    '
    'btnAddFuncVarType
    '
    Me.btnAddFuncVarType.Location = New System.Drawing.Point(341, 177)
    Me.btnAddFuncVarType.Name = "btnAddFuncVarType"
    Me.btnAddFuncVarType.Size = New System.Drawing.Size(150, 38)
    Me.btnAddFuncVarType.TabIndex = 14
    Me.btnAddFuncVarType.Text = "Add Function/Variable " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type to List"
    Me.btnAddFuncVarType.UseVisualStyleBackColor = True
    '
    'txtInputFuncVarType
    '
    Me.txtInputFuncVarType.Location = New System.Drawing.Point(203, 177)
    Me.txtInputFuncVarType.Name = "txtInputFuncVarType"
    Me.txtInputFuncVarType.Size = New System.Drawing.Size(132, 20)
    Me.txtInputFuncVarType.TabIndex = 13
    '
    'btnDisplayUserList
    '
    Me.btnDisplayUserList.Location = New System.Drawing.Point(497, 45)
    Me.btnDisplayUserList.Name = "btnDisplayUserList"
    Me.btnDisplayUserList.Size = New System.Drawing.Size(120, 38)
    Me.btnDisplayUserList.TabIndex = 3
    Me.btnDisplayUserList.Text = "Display User List"
    Me.btnDisplayUserList.UseVisualStyleBackColor = True
    '
    'btnDisplayProgramNameList
    '
    Me.btnDisplayProgramNameList.Location = New System.Drawing.Point(497, 90)
    Me.btnDisplayProgramNameList.Name = "btnDisplayProgramNameList"
    Me.btnDisplayProgramNameList.Size = New System.Drawing.Size(120, 38)
    Me.btnDisplayProgramNameList.TabIndex = 7
    Me.btnDisplayProgramNameList.Text = "Display Program Name List"
    Me.btnDisplayProgramNameList.UseVisualStyleBackColor = True
    '
    'btnDisplayFuncNameList
    '
    Me.btnDisplayFuncNameList.Location = New System.Drawing.Point(497, 134)
    Me.btnDisplayFuncNameList.Name = "btnDisplayFuncNameList"
    Me.btnDisplayFuncNameList.Size = New System.Drawing.Size(120, 38)
    Me.btnDisplayFuncNameList.TabIndex = 11
    Me.btnDisplayFuncNameList.Text = "Display Function Name List"
    Me.btnDisplayFuncNameList.UseVisualStyleBackColor = True
    '
    'btnDisplayFuncVarTypeList
    '
    Me.btnDisplayFuncVarTypeList.Location = New System.Drawing.Point(497, 177)
    Me.btnDisplayFuncVarTypeList.Name = "btnDisplayFuncVarTypeList"
    Me.btnDisplayFuncVarTypeList.Size = New System.Drawing.Size(120, 38)
    Me.btnDisplayFuncVarTypeList.TabIndex = 15
    Me.btnDisplayFuncVarTypeList.Text = "Display Function/ Variable Type List"
    Me.btnDisplayFuncVarTypeList.UseVisualStyleBackColor = True
    '
    'btnDisplayVariableNameList
    '
    Me.btnDisplayVariableNameList.Location = New System.Drawing.Point(497, 221)
    Me.btnDisplayVariableNameList.Name = "btnDisplayVariableNameList"
    Me.btnDisplayVariableNameList.Size = New System.Drawing.Size(120, 38)
    Me.btnDisplayVariableNameList.TabIndex = 19
    Me.btnDisplayVariableNameList.Text = "Display Variable Name List"
    Me.btnDisplayVariableNameList.UseVisualStyleBackColor = True
    '
    'lblHeadingUpdateSysLists
    '
    Me.lblHeadingUpdateSysLists.AutoSize = True
    Me.lblHeadingUpdateSysLists.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHeadingUpdateSysLists.Location = New System.Drawing.Point(178, 9)
    Me.lblHeadingUpdateSysLists.Name = "lblHeadingUpdateSysLists"
    Me.lblHeadingUpdateSysLists.Size = New System.Drawing.Size(242, 24)
    Me.lblHeadingUpdateSysLists.TabIndex = 24
    Me.lblHeadingUpdateSysLists.Text = "UPDATE SYSTEM LISTS"
    Me.lblHeadingUpdateSysLists.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'frmMainWindow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(635, 433)
    Me.Controls.Add(Me.lblHeadingUpdateSysLists)
    Me.Controls.Add(Me.btnDisplayVariableNameList)
    Me.Controls.Add(Me.btnDisplayFuncVarTypeList)
    Me.Controls.Add(Me.btnDisplayFuncNameList)
    Me.Controls.Add(Me.btnDisplayProgramNameList)
    Me.Controls.Add(Me.btnDisplayUserList)
    Me.Controls.Add(Me.txtInputFuncVarType)
    Me.Controls.Add(Me.btnAddFuncVarType)
    Me.Controls.Add(Me.btnAddVariable)
    Me.Controls.Add(Me.txtInputVariableName)
    Me.Controls.Add(Me.lblCreateVariableName)
    Me.Controls.Add(Me.btnAddFunction)
    Me.Controls.Add(Me.txtInputUserDefFunc)
    Me.Controls.Add(Me.lblCreateProgramFunctions)
    Me.Controls.Add(Me.btnCreateProgramName)
    Me.Controls.Add(Me.txtCreateProgramName)
    Me.Controls.Add(Me.lblCreateProgramName)
    Me.Controls.Add(Me.btnAddUserName)
    Me.Controls.Add(Me.txtInputUserName)
    Me.Controls.Add(Me.lblCreateUserName)
    Me.Controls.Add(Me.btnCreateBltInFuncOrVarName)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.btnCreateStrctureChart)
    Me.Controls.Add(Me.btnCreateFuncDoc)
    Me.Controls.Add(Me.lblDocumentCreateHeading)
    Me.Controls.Add(Me.ShapeContainer1)
    Me.Name = "frmMainWindow"
    Me.Text = "C-Programming Documentation Writer"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblDocumentCreateHeading As System.Windows.Forms.Label
  Friend WithEvents btnCreateFuncDoc As System.Windows.Forms.Button
  Friend WithEvents btnCreateStrctureChart As System.Windows.Forms.Button
  Friend WithEvents btnClose As System.Windows.Forms.Button
  Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
  Friend WithEvents linHorizontal As Microsoft.VisualBasic.PowerPacks.LineShape
  Friend WithEvents btnCreateBltInFuncOrVarName As System.Windows.Forms.Label
  Friend WithEvents btnAddUserName As System.Windows.Forms.Button
  Friend WithEvents txtInputUserName As System.Windows.Forms.TextBox
  Friend WithEvents lblCreateUserName As System.Windows.Forms.Label
  Friend WithEvents btnCreateProgramName As System.Windows.Forms.Button
  Friend WithEvents txtCreateProgramName As System.Windows.Forms.TextBox
  Friend WithEvents lblCreateProgramName As System.Windows.Forms.Label
  Friend WithEvents btnAddFunction As System.Windows.Forms.Button
  Friend WithEvents txtInputUserDefFunc As System.Windows.Forms.TextBox
  Friend WithEvents lblCreateProgramFunctions As System.Windows.Forms.Label
  Friend WithEvents btnAddVariable As System.Windows.Forms.Button
  Friend WithEvents txtInputVariableName As System.Windows.Forms.TextBox
  Friend WithEvents lblCreateVariableName As System.Windows.Forms.Label
  Friend WithEvents btnAddFuncVarType As System.Windows.Forms.Button
  Friend WithEvents txtInputFuncVarType As System.Windows.Forms.TextBox
  Friend WithEvents btnDisplayUserList As System.Windows.Forms.Button
  Friend WithEvents btnDisplayProgramNameList As System.Windows.Forms.Button
  Friend WithEvents btnDisplayFuncNameList As System.Windows.Forms.Button
  Friend WithEvents btnDisplayFuncVarTypeList As System.Windows.Forms.Button
  Friend WithEvents btnDisplayVariableNameList As System.Windows.Forms.Button
  Friend WithEvents lblHeadingUpdateSysLists As System.Windows.Forms.Label

End Class
