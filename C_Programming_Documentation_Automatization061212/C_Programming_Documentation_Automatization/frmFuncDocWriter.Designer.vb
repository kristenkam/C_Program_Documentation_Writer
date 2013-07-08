<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncDocWriter
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
    Me.txtInputReturn = New System.Windows.Forms.TextBox()
    Me.lblReturn = New System.Windows.Forms.Label()
    Me.btnCreatePre = New System.Windows.Forms.Button()
    Me.txtInputNumPreParameters = New System.Windows.Forms.TextBox()
    Me.lblNumInputParameters = New System.Windows.Forms.Label()
    Me.btnSaveAndClose = New System.Windows.Forms.Button()
    Me.btnClear = New System.Windows.Forms.Button()
    Me.cboFuncName = New System.Windows.Forms.ComboBox()
    Me.btnCreateFuncDoc = New System.Windows.Forms.Button()
    Me.txtInputFuncPost = New System.Windows.Forms.TextBox()
    Me.txtInputFuncPre = New System.Windows.Forms.TextBox()
    Me.txtInputFuncDesc = New System.Windows.Forms.TextBox()
    Me.lblFuncPost = New System.Windows.Forms.Label()
    Me.lblFuncPre = New System.Windows.Forms.Label()
    Me.lblFuncDesc = New System.Windows.Forms.Label()
    Me.lblFuncName = New System.Windows.Forms.Label()
    Me.lblFuncDoc = New System.Windows.Forms.Label()
    Me.lstFuncDoc = New System.Windows.Forms.ListBox()
    Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
    Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
    Me.lblStudentName = New System.Windows.Forms.Label()
    Me.lblDocDate = New System.Windows.Forms.Label()
    Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
    Me.lblProgramName = New System.Windows.Forms.Label()
    Me.btnSaveStudentDocInfo = New System.Windows.Forms.Button()
    Me.btnAppend = New System.Windows.Forms.Button()
    Me.btnCreatePost = New System.Windows.Forms.Button()
    Me.txtInputNumPostParameters = New System.Windows.Forms.TextBox()
    Me.lblNumInputPostParameters = New System.Windows.Forms.Label()
    Me.lblEnterStudProgBefore = New System.Windows.Forms.Label()
    Me.gbxEnterFuncDoc = New System.Windows.Forms.GroupBox()
    Me.lblStatus = New System.Windows.Forms.Label()
    Me.lstStatus = New System.Windows.Forms.ListBox()
    Me.gbxStudentProgInfo = New System.Windows.Forms.GroupBox()
    Me.cboInputProgramName = New System.Windows.Forms.ComboBox()
    Me.cboInputStudentName = New System.Windows.Forms.ComboBox()
    Me.lblFileName = New System.Windows.Forms.Label()
    Me.lblProgramNameMem = New System.Windows.Forms.Label()
    Me.lblStudentNameMem = New System.Windows.Forms.Label()
    Me.gbxStudentandProgramInfo = New System.Windows.Forms.GroupBox()
    Me.lblDocumentDateMem = New System.Windows.Forms.Label()
    Me.gbxEnterFuncDoc.SuspendLayout()
    Me.gbxStudentProgInfo.SuspendLayout()
    Me.gbxStudentandProgramInfo.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtInputReturn
    '
    Me.txtInputReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInputReturn.Location = New System.Drawing.Point(149, 203)
    Me.txtInputReturn.Name = "txtInputReturn"
    Me.txtInputReturn.Size = New System.Drawing.Size(302, 20)
    Me.txtInputReturn.TabIndex = 29
    '
    'lblReturn
    '
    Me.lblReturn.AutoSize = True
    Me.lblReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblReturn.Location = New System.Drawing.Point(11, 206)
    Me.lblReturn.Name = "lblReturn"
    Me.lblReturn.Size = New System.Drawing.Size(90, 13)
    Me.lblReturn.TabIndex = 28
    Me.lblReturn.Text = "Return (Optional):"
    '
    'btnCreatePre
    '
    Me.btnCreatePre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCreatePre.Location = New System.Drawing.Point(348, 110)
    Me.btnCreatePre.Name = "btnCreatePre"
    Me.btnCreatePre.Size = New System.Drawing.Size(75, 23)
    Me.btnCreatePre.TabIndex = 22
    Me.btnCreatePre.Text = "Create Pre"
    Me.btnCreatePre.UseVisualStyleBackColor = True
    '
    'txtInputNumPreParameters
    '
    Me.txtInputNumPreParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInputNumPreParameters.Location = New System.Drawing.Point(291, 112)
    Me.txtInputNumPreParameters.Name = "txtInputNumPreParameters"
    Me.txtInputNumPreParameters.Size = New System.Drawing.Size(35, 20)
    Me.txtInputNumPreParameters.TabIndex = 21
    '
    'lblNumInputParameters
    '
    Me.lblNumInputParameters.AutoSize = True
    Me.lblNumInputParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumInputParameters.Location = New System.Drawing.Point(146, 115)
    Me.lblNumInputParameters.Name = "lblNumInputParameters"
    Me.lblNumInputParameters.Size = New System.Drawing.Size(139, 13)
    Me.lblNumInputParameters.TabIndex = 20
    Me.lblNumInputParameters.Text = "Number of Input Parameters"
    '
    'btnSaveAndClose
    '
    Me.btnSaveAndClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSaveAndClose.Location = New System.Drawing.Point(586, 234)
    Me.btnSaveAndClose.Name = "btnSaveAndClose"
    Me.btnSaveAndClose.Size = New System.Drawing.Size(177, 91)
    Me.btnSaveAndClose.TabIndex = 37
    Me.btnSaveAndClose.Text = "View Function Documentation  and Close Function Documentation Writer"
    Me.btnSaveAndClose.UseVisualStyleBackColor = True
    '
    'btnClear
    '
    Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnClear.Location = New System.Drawing.Point(403, 234)
    Me.btnClear.Name = "btnClear"
    Me.btnClear.Size = New System.Drawing.Size(177, 91)
    Me.btnClear.TabIndex = 36
    Me.btnClear.Text = "Clear Input Boxes and Create Additional Function Documentation"
    Me.btnClear.UseVisualStyleBackColor = True
    '
    'cboFuncName
    '
    Me.cboFuncName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboFuncName.FormattingEnabled = True
    Me.cboFuncName.Location = New System.Drawing.Point(149, 20)
    Me.cboFuncName.Name = "cboFuncName"
    Me.cboFuncName.Size = New System.Drawing.Size(302, 21)
    Me.cboFuncName.Sorted = True
    Me.cboFuncName.TabIndex = 15
    '
    'btnCreateFuncDoc
    '
    Me.btnCreateFuncDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCreateFuncDoc.Location = New System.Drawing.Point(48, 234)
    Me.btnCreateFuncDoc.Name = "btnCreateFuncDoc"
    Me.btnCreateFuncDoc.Size = New System.Drawing.Size(169, 91)
    Me.btnCreateFuncDoc.TabIndex = 34
    Me.btnCreateFuncDoc.Text = "Create Function Documentation"
    Me.btnCreateFuncDoc.UseVisualStyleBackColor = True
    '
    'txtInputFuncPost
    '
    Me.txtInputFuncPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInputFuncPost.Location = New System.Drawing.Point(149, 146)
    Me.txtInputFuncPost.Name = "txtInputFuncPost"
    Me.txtInputFuncPost.ReadOnly = True
    Me.txtInputFuncPost.Size = New System.Drawing.Size(302, 20)
    Me.txtInputFuncPost.TabIndex = 24
    '
    'txtInputFuncPre
    '
    Me.txtInputFuncPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInputFuncPre.Location = New System.Drawing.Point(149, 83)
    Me.txtInputFuncPre.Name = "txtInputFuncPre"
    Me.txtInputFuncPre.ReadOnly = True
    Me.txtInputFuncPre.Size = New System.Drawing.Size(302, 20)
    Me.txtInputFuncPre.TabIndex = 19
    '
    'txtInputFuncDesc
    '
    Me.txtInputFuncDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInputFuncDesc.Location = New System.Drawing.Point(149, 54)
    Me.txtInputFuncDesc.Name = "txtInputFuncDesc"
    Me.txtInputFuncDesc.Size = New System.Drawing.Size(302, 20)
    Me.txtInputFuncDesc.TabIndex = 17
    '
    'lblFuncPost
    '
    Me.lblFuncPost.AutoSize = True
    Me.lblFuncPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFuncPost.Location = New System.Drawing.Point(11, 149)
    Me.lblFuncPost.Name = "lblFuncPost"
    Me.lblFuncPost.Size = New System.Drawing.Size(75, 13)
    Me.lblFuncPost.TabIndex = 23
    Me.lblFuncPost.Text = "Function Post:"
    '
    'lblFuncPre
    '
    Me.lblFuncPre.AutoSize = True
    Me.lblFuncPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFuncPre.Location = New System.Drawing.Point(11, 90)
    Me.lblFuncPre.Name = "lblFuncPre"
    Me.lblFuncPre.Size = New System.Drawing.Size(70, 13)
    Me.lblFuncPre.TabIndex = 18
    Me.lblFuncPre.Text = "Function Pre:"
    '
    'lblFuncDesc
    '
    Me.lblFuncDesc.AutoSize = True
    Me.lblFuncDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFuncDesc.Location = New System.Drawing.Point(11, 57)
    Me.lblFuncDesc.Name = "lblFuncDesc"
    Me.lblFuncDesc.Size = New System.Drawing.Size(107, 13)
    Me.lblFuncDesc.TabIndex = 16
    Me.lblFuncDesc.Text = "Function Description:"
    '
    'lblFuncName
    '
    Me.lblFuncName.AutoSize = True
    Me.lblFuncName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFuncName.Location = New System.Drawing.Point(11, 28)
    Me.lblFuncName.Name = "lblFuncName"
    Me.lblFuncName.Size = New System.Drawing.Size(82, 13)
    Me.lblFuncName.TabIndex = 14
    Me.lblFuncName.Text = "Function Name:"
    '
    'lblFuncDoc
    '
    Me.lblFuncDoc.AutoSize = True
    Me.lblFuncDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFuncDoc.Location = New System.Drawing.Point(488, 20)
    Me.lblFuncDoc.Name = "lblFuncDoc"
    Me.lblFuncDoc.Size = New System.Drawing.Size(126, 13)
    Me.lblFuncDoc.TabIndex = 30
    Me.lblFuncDoc.Text = "Function Documentation:"
    '
    'lstFuncDoc
    '
    Me.lstFuncDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstFuncDoc.FormattingEnabled = True
    Me.lstFuncDoc.Location = New System.Drawing.Point(491, 42)
    Me.lstFuncDoc.Name = "lstFuncDoc"
    Me.lstFuncDoc.Size = New System.Drawing.Size(296, 95)
    Me.lstFuncDoc.TabIndex = 31
    '
    'ShapeContainer1
    '
    Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
    Me.ShapeContainer1.Name = "ShapeContainer1"
    Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
    Me.ShapeContainer1.Size = New System.Drawing.Size(904, 576)
    Me.ShapeContainer1.TabIndex = 37
    Me.ShapeContainer1.TabStop = False
    '
    'LineShape1
    '
    Me.LineShape1.Name = "LineShape1"
    Me.LineShape1.X1 = 7
    Me.LineShape1.X2 = 889
    Me.LineShape1.Y1 = 180
    Me.LineShape1.Y2 = 180
    '
    'lblStudentName
    '
    Me.lblStudentName.AutoSize = True
    Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStudentName.Location = New System.Drawing.Point(-1, 35)
    Me.lblStudentName.Name = "lblStudentName"
    Me.lblStudentName.Size = New System.Drawing.Size(75, 13)
    Me.lblStudentName.TabIndex = 1
    Me.lblStudentName.Text = "Student Name"
    '
    'lblDocDate
    '
    Me.lblDocDate.AutoSize = True
    Me.lblDocDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocDate.Location = New System.Drawing.Point(-1, 71)
    Me.lblDocDate.Name = "lblDocDate"
    Me.lblDocDate.Size = New System.Drawing.Size(85, 13)
    Me.lblDocDate.TabIndex = 3
    Me.lblDocDate.Text = "Document Date:"
    '
    'dtpDocDate
    '
    Me.dtpDocDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpDocDate.Location = New System.Drawing.Point(93, 67)
    Me.dtpDocDate.Name = "dtpDocDate"
    Me.dtpDocDate.Size = New System.Drawing.Size(224, 20)
    Me.dtpDocDate.TabIndex = 4
    '
    'lblProgramName
    '
    Me.lblProgramName.AutoSize = True
    Me.lblProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProgramName.Location = New System.Drawing.Point(-1, 109)
    Me.lblProgramName.Name = "lblProgramName"
    Me.lblProgramName.Size = New System.Drawing.Size(80, 13)
    Me.lblProgramName.TabIndex = 5
    Me.lblProgramName.Text = "Program Name:"
    '
    'btnSaveStudentDocInfo
    '
    Me.btnSaveStudentDocInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSaveStudentDocInfo.Location = New System.Drawing.Point(341, 31)
    Me.btnSaveStudentDocInfo.Name = "btnSaveStudentDocInfo"
    Me.btnSaveStudentDocInfo.Size = New System.Drawing.Size(208, 88)
    Me.btnSaveStudentDocInfo.TabIndex = 7
    Me.btnSaveStudentDocInfo.Text = "Save Student and Program Documentation Information"
    Me.btnSaveStudentDocInfo.UseVisualStyleBackColor = True
    '
    'btnAppend
    '
    Me.btnAppend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAppend.Location = New System.Drawing.Point(223, 234)
    Me.btnAppend.Name = "btnAppend"
    Me.btnAppend.Size = New System.Drawing.Size(177, 91)
    Me.btnAppend.TabIndex = 35
    Me.btnAppend.Text = "Save Function Documentation to Main Function Document (text file)"
    Me.btnAppend.UseVisualStyleBackColor = True
    '
    'btnCreatePost
    '
    Me.btnCreatePost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCreatePost.Location = New System.Drawing.Point(348, 172)
    Me.btnCreatePost.Name = "btnCreatePost"
    Me.btnCreatePost.Size = New System.Drawing.Size(75, 23)
    Me.btnCreatePost.TabIndex = 27
    Me.btnCreatePost.Text = "Create Post"
    Me.btnCreatePost.UseVisualStyleBackColor = True
    '
    'txtInputNumPostParameters
    '
    Me.txtInputNumPostParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInputNumPostParameters.Location = New System.Drawing.Point(291, 174)
    Me.txtInputNumPostParameters.Name = "txtInputNumPostParameters"
    Me.txtInputNumPostParameters.Size = New System.Drawing.Size(35, 20)
    Me.txtInputNumPostParameters.TabIndex = 26
    '
    'lblNumInputPostParameters
    '
    Me.lblNumInputPostParameters.AutoSize = True
    Me.lblNumInputPostParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumInputPostParameters.Location = New System.Drawing.Point(146, 177)
    Me.lblNumInputPostParameters.Name = "lblNumInputPostParameters"
    Me.lblNumInputPostParameters.Size = New System.Drawing.Size(139, 13)
    Me.lblNumInputPostParameters.TabIndex = 25
    Me.lblNumInputPostParameters.Text = "Number of Input Parameters"
    '
    'lblEnterStudProgBefore
    '
    Me.lblEnterStudProgBefore.AutoSize = True
    Me.lblEnterStudProgBefore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEnterStudProgBefore.Location = New System.Drawing.Point(64, 152)
    Me.lblEnterStudProgBefore.Name = "lblEnterStudProgBefore"
    Me.lblEnterStudProgBefore.Size = New System.Drawing.Size(742, 48)
    Me.lblEnterStudProgBefore.TabIndex = 12
    Me.lblEnterStudProgBefore.Text = "ENTER AND SAVE STUDENT PROGRAM DOCUMENTATION INFORMATION " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BEFORE ENTERING FUNCTI" & _
        "ON DOCUMENTATION INFORMATION"
    Me.lblEnterStudProgBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'gbxEnterFuncDoc
    '
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblStatus)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lstStatus)
    Me.gbxEnterFuncDoc.Controls.Add(Me.txtInputFuncPre)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnCreatePost)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lstFuncDoc)
    Me.gbxEnterFuncDoc.Controls.Add(Me.txtInputNumPostParameters)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblFuncDoc)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblNumInputPostParameters)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblFuncName)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnAppend)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblFuncDesc)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblFuncPre)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblFuncPost)
    Me.gbxEnterFuncDoc.Controls.Add(Me.txtInputFuncDesc)
    Me.gbxEnterFuncDoc.Controls.Add(Me.txtInputFuncPost)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnCreateFuncDoc)
    Me.gbxEnterFuncDoc.Controls.Add(Me.cboFuncName)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnClear)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnSaveAndClose)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblNumInputParameters)
    Me.gbxEnterFuncDoc.Controls.Add(Me.txtInputReturn)
    Me.gbxEnterFuncDoc.Controls.Add(Me.txtInputNumPreParameters)
    Me.gbxEnterFuncDoc.Controls.Add(Me.lblReturn)
    Me.gbxEnterFuncDoc.Controls.Add(Me.btnCreatePre)
    Me.gbxEnterFuncDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbxEnterFuncDoc.Location = New System.Drawing.Point(53, 213)
    Me.gbxEnterFuncDoc.Name = "gbxEnterFuncDoc"
    Me.gbxEnterFuncDoc.Size = New System.Drawing.Size(798, 335)
    Me.gbxEnterFuncDoc.TabIndex = 13
    Me.gbxEnterFuncDoc.TabStop = False
    Me.gbxEnterFuncDoc.Text = "(2) Enter Function Documentation Information"
    Me.gbxEnterFuncDoc.Visible = False
    '
    'lblStatus
    '
    Me.lblStatus.AutoSize = True
    Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStatus.Location = New System.Drawing.Point(488, 146)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(167, 13)
    Me.lblStatus.TabIndex = 32
    Me.lblStatus.Text = "Function Document Writer Status:"
    '
    'lstStatus
    '
    Me.lstStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstStatus.FormattingEnabled = True
    Me.lstStatus.HorizontalScrollbar = True
    Me.lstStatus.Location = New System.Drawing.Point(491, 163)
    Me.lstStatus.Name = "lstStatus"
    Me.lstStatus.ScrollAlwaysVisible = True
    Me.lstStatus.Size = New System.Drawing.Size(296, 56)
    Me.lstStatus.TabIndex = 33
    '
    'gbxStudentProgInfo
    '
    Me.gbxStudentProgInfo.Controls.Add(Me.cboInputProgramName)
    Me.gbxStudentProgInfo.Controls.Add(Me.cboInputStudentName)
    Me.gbxStudentProgInfo.Controls.Add(Me.btnSaveStudentDocInfo)
    Me.gbxStudentProgInfo.Controls.Add(Me.lblProgramName)
    Me.gbxStudentProgInfo.Controls.Add(Me.lblStudentName)
    Me.gbxStudentProgInfo.Controls.Add(Me.dtpDocDate)
    Me.gbxStudentProgInfo.Controls.Add(Me.lblDocDate)
    Me.gbxStudentProgInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbxStudentProgInfo.Location = New System.Drawing.Point(15, 12)
    Me.gbxStudentProgInfo.Name = "gbxStudentProgInfo"
    Me.gbxStudentProgInfo.Size = New System.Drawing.Size(573, 149)
    Me.gbxStudentProgInfo.TabIndex = 0
    Me.gbxStudentProgInfo.TabStop = False
    Me.gbxStudentProgInfo.Text = "(1) Enter Student and Program Information:"
    '
    'cboInputProgramName
    '
    Me.cboInputProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboInputProgramName.FormattingEnabled = True
    Me.cboInputProgramName.Location = New System.Drawing.Point(93, 106)
    Me.cboInputProgramName.Name = "cboInputProgramName"
    Me.cboInputProgramName.Size = New System.Drawing.Size(224, 21)
    Me.cboInputProgramName.Sorted = True
    Me.cboInputProgramName.TabIndex = 6
    '
    'cboInputStudentName
    '
    Me.cboInputStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboInputStudentName.FormattingEnabled = True
    Me.cboInputStudentName.Location = New System.Drawing.Point(93, 31)
    Me.cboInputStudentName.Name = "cboInputStudentName"
    Me.cboInputStudentName.Size = New System.Drawing.Size(224, 21)
    Me.cboInputStudentName.Sorted = True
    Me.cboInputStudentName.TabIndex = 2
    '
    'lblFileName
    '
    Me.lblFileName.AutoSize = True
    Me.lblFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFileName.Location = New System.Drawing.Point(620, 139)
    Me.lblFileName.Name = "lblFileName"
    Me.lblFileName.Size = New System.Drawing.Size(67, 13)
    Me.lblFileName.TabIndex = 49
    Me.lblFileName.Text = "File Name:"
    '
    'lblProgramNameMem
    '
    Me.lblProgramNameMem.AutoSize = True
    Me.lblProgramNameMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProgramNameMem.Location = New System.Drawing.Point(17, 58)
    Me.lblProgramNameMem.Name = "lblProgramNameMem"
    Me.lblProgramNameMem.Size = New System.Drawing.Size(80, 13)
    Me.lblProgramNameMem.TabIndex = 10
    Me.lblProgramNameMem.Text = "Program Name:"
    '
    'lblStudentNameMem
    '
    Me.lblStudentNameMem.AutoSize = True
    Me.lblStudentNameMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStudentNameMem.Location = New System.Drawing.Point(17, 30)
    Me.lblStudentNameMem.Name = "lblStudentNameMem"
    Me.lblStudentNameMem.Size = New System.Drawing.Size(78, 13)
    Me.lblStudentNameMem.TabIndex = 9
    Me.lblStudentNameMem.Text = "Student Name:"
    '
    'gbxStudentandProgramInfo
    '
    Me.gbxStudentandProgramInfo.Controls.Add(Me.lblDocumentDateMem)
    Me.gbxStudentandProgramInfo.Controls.Add(Me.lblProgramNameMem)
    Me.gbxStudentandProgramInfo.Controls.Add(Me.lblStudentNameMem)
    Me.gbxStudentandProgramInfo.Location = New System.Drawing.Point(623, 12)
    Me.gbxStudentandProgramInfo.Name = "gbxStudentandProgramInfo"
    Me.gbxStudentandProgramInfo.Size = New System.Drawing.Size(256, 119)
    Me.gbxStudentandProgramInfo.TabIndex = 8
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
    Me.lblDocumentDateMem.TabIndex = 11
    Me.lblDocumentDateMem.Text = "Document Date:"
    '
    'frmFuncDocWriter
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(904, 576)
    Me.Controls.Add(Me.lblEnterStudProgBefore)
    Me.Controls.Add(Me.lblFileName)
    Me.Controls.Add(Me.gbxStudentandProgramInfo)
    Me.Controls.Add(Me.gbxEnterFuncDoc)
    Me.Controls.Add(Me.gbxStudentProgInfo)
    Me.Controls.Add(Me.ShapeContainer1)
    Me.Name = "frmFuncDocWriter"
    Me.Text = "Function Documentation Writer"
    Me.gbxEnterFuncDoc.ResumeLayout(False)
    Me.gbxEnterFuncDoc.PerformLayout()
    Me.gbxStudentProgInfo.ResumeLayout(False)
    Me.gbxStudentProgInfo.PerformLayout()
    Me.gbxStudentandProgramInfo.ResumeLayout(False)
    Me.gbxStudentandProgramInfo.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtInputReturn As System.Windows.Forms.TextBox
  Friend WithEvents lblReturn As System.Windows.Forms.Label
  Friend WithEvents btnCreatePre As System.Windows.Forms.Button
  Friend WithEvents txtInputNumPreParameters As System.Windows.Forms.TextBox
  Friend WithEvents lblNumInputParameters As System.Windows.Forms.Label
  Friend WithEvents btnSaveAndClose As System.Windows.Forms.Button
  Friend WithEvents btnClear As System.Windows.Forms.Button
  Friend WithEvents cboFuncName As System.Windows.Forms.ComboBox
  Friend WithEvents btnCreateFuncDoc As System.Windows.Forms.Button
  Friend WithEvents txtInputFuncPost As System.Windows.Forms.TextBox
  Friend WithEvents txtInputFuncPre As System.Windows.Forms.TextBox
  Friend WithEvents txtInputFuncDesc As System.Windows.Forms.TextBox
  Friend WithEvents lblFuncPost As System.Windows.Forms.Label
  Friend WithEvents lblFuncPre As System.Windows.Forms.Label
  Friend WithEvents lblFuncDesc As System.Windows.Forms.Label
  Friend WithEvents lblFuncName As System.Windows.Forms.Label
  Friend WithEvents lblFuncDoc As System.Windows.Forms.Label
  Friend WithEvents lstFuncDoc As System.Windows.Forms.ListBox
  Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
  Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
  Friend WithEvents lblStudentName As System.Windows.Forms.Label
  Friend WithEvents lblDocDate As System.Windows.Forms.Label
  Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblProgramName As System.Windows.Forms.Label
  Friend WithEvents btnSaveStudentDocInfo As System.Windows.Forms.Button
  Friend WithEvents btnAppend As System.Windows.Forms.Button
  Friend WithEvents btnCreatePost As System.Windows.Forms.Button
  Friend WithEvents txtInputNumPostParameters As System.Windows.Forms.TextBox
  Friend WithEvents lblNumInputPostParameters As System.Windows.Forms.Label
  Friend WithEvents lblEnterStudProgBefore As System.Windows.Forms.Label
  Friend WithEvents gbxEnterFuncDoc As System.Windows.Forms.GroupBox
  Friend WithEvents lblStatus As System.Windows.Forms.Label
  Friend WithEvents lstStatus As System.Windows.Forms.ListBox
  Friend WithEvents gbxStudentProgInfo As System.Windows.Forms.GroupBox
  Friend WithEvents lblFileName As System.Windows.Forms.Label
  Friend WithEvents cboInputStudentName As System.Windows.Forms.ComboBox
  Friend WithEvents cboInputProgramName As System.Windows.Forms.ComboBox
  Friend WithEvents lblProgramNameMem As System.Windows.Forms.Label
  Friend WithEvents lblStudentNameMem As System.Windows.Forms.Label
  Friend WithEvents gbxStudentandProgramInfo As System.Windows.Forms.GroupBox
  Friend WithEvents lblDocumentDateMem As System.Windows.Forms.Label
End Class
