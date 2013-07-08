Public Class frmStructDocChartWriter
  'Project name:        C-Programming Documentation Automation
  'Program:             This program automates the function and structure chart 
  '                     documenting process for an physically-challenged C-programmer.

  'Developer:           Kristen Kam
  'Support Contact:     kam.kristen@gmail.com
  'Date Created:        May 21, 2012
  'Date Last Modified:  June 12, 2012
  '****Structure Chart (Outline) Document writer window*****

  Public structurechartdocpath As String
  Friend intNum As Integer = 0
  Public documentSaved As Boolean = False

  Private Sub frmStructureChartWriter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'This sub routine prompts the user for the function document name, populates the student program 
    'input text boxes with the values, if available, of the global variables related to the student name, 
    'program name, and document date. 

    documentSaved = False

    'Updates label of project information (if saved)
    lblStudentNameMem.Text = "Student Name: " & frmMainWindow.strStudentName
    lblProgramNameMem.Text = "Program Name: " & frmMainWindow.strProgramName
    lblDocumentDateMem.Text = "Document Date: " & frmMainWindow.strDocumentDate

    frmMainWindow.PopulateComboBox(cboInputStudentName, "names_users.txt")
    frmMainWindow.PopulateComboBox(cboInputProgramName, "names_homework.txt")
    frmMainWindow.PopulateComboBox(cboFuncName, "names_userdefinedfunctions.txt")

  End Sub

  Private Sub frmStructDocChartWriter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    Dim response As MsgBoxResult

    If documentSaved = True Then
      response = MsgBox("Do you want to keep adding functions to " & structurechartdocpath & "?", MsgBoxStyle.YesNo, "Structure Chart (Outline) Documentation Writer Close Attempt!")
      If response = MsgBoxResult.Yes Then
        e.Cancel = True
      ElseIf response = MsgBoxResult.No Then
        Dim response2 As MsgBoxResult
        response2 = MsgBox("Do you want to view the structure chart (outline) document of " & structurechartdocpath & "?", MsgBoxStyle.YesNo, "Structure Chart (Outline) Documentation Writer Close Attempt!")
        If response2 = MsgBoxResult.Yes Then
          frmStructDocResults.ShowDialog()
          ClearStrucDocFields()
          lstStatus.Items.Clear()
          gbxEnterFuncDoc.Visible = False
          lblEnterStudProgBefore.Visible = True
          documentSaved = False
        Else
          ClearStrucDocFields()
          lstStatus.Items.Clear()
          gbxEnterFuncDoc.Visible = False
          lblEnterStudProgBefore.Visible = True
          documentSaved = False
        End If
      End If
    ElseIf documentSaved = False Then
      response = MsgBox("You have not saved any documentation to the text document yet! Do you want to abort the Structure Chart (Outline) Document Writer?", MsgBoxStyle.YesNo, "Structure Chart (Outline) Documentation Writer Close Attempt!")
      If response = MsgBoxResult.Yes Then
        ClearStrucDocFields()
        lstStatus.Items.Clear()
        gbxEnterFuncDoc.Visible = False
        lblEnterStudProgBefore.Visible = True
        If IO.File.Exists(structurechartdocpath) = True Then
          System.IO.File.Delete(structurechartdocpath)
        End If
        documentSaved = False
      ElseIf response = MsgBoxResult.No Then
        e.Cancel = True
      End If
    End If
  End Sub

  Private Sub btnSaveStudentDocInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveStudentDocInfo.Click
    'Executes the WriteFile() sub procedure if the file doesn't exist. Prompts user if s/he wants to overwrite
    'an existing file.

    Dim response As MsgBoxResult

    'Saves the user inputted student and program information to memory and creates the string 
    Dim builder As New System.Text.StringBuilder()
    builder.Append(cboInputStudentName.SelectedItem)
    frmMainWindow.strStudentName = builder.ToString
    builder.Clear()
    builder.Append(cboInputProgramName.SelectedItem)
    frmMainWindow.strProgramName = builder.ToString
    builder.Clear()
    frmMainWindow.strDocumentDate = FormatDateTime(CDate(dtpDocDate.Text), DateFormat.ShortDate)
    structurechartdocpath = frmMainWindow.strProgramName & "_stucturechartdoc.txt" 'Structure Chart document name & location

    If IO.File.Exists(structurechartdocpath) Then
      response = MsgBox("The file named " & structurechartdocpath & " exists. Do you want to overwrite the file?", _
             MsgBoxStyle.YesNo, "FILE EXISTS!")
      If response = MsgBoxResult.Yes Then
        WriteFile()
      ElseIf response = MsgBoxResult.No Then
        MsgBox("Select a new program name.", MsgBoxStyle.OkOnly, "New Program Name Needed!")
        cboInputProgramName.SelectedIndex = -1
        Exit Sub
      End If
    Else
      WriteFile()
    End If
  End Sub


  Private Sub btnCreateStructureChartDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateStructureChartDoc.Click
    'This sub routine creates the structure documentation for the user to view before saving.
    'Checks to see if all fields are filled before creating the function documentation.

    If cboFuncName.SelectedIndex < 0 Then
      MsgBox("Please enter a function name.")
    ElseIf txtInputNumSubFunc.TextLength = 0 Then
      MsgBox("Please enter the number of subfunctions to the main function.")
    Else
      'Declares variables to create lines of function documentation
      Dim intNumSubFunc As Integer = CInt(txtInputNumSubFunc.Text)
      Dim mainFuncSubFunc(intNumSubFunc - 1) As String
      Dim strFuncName As String = ""

      Dim builder As New System.Text.StringBuilder()

      'Converts selected main function name item to a string.
      frmMainWindow.ConvertComboBoxSelectionToString(cboFuncName, strFuncName)

      'Creates the structure documentation and displays each line in a list box. 
      For n As Integer = 0 To intNumSubFunc - 1
        intNum += 1
        frmStructDocSubFunctions.ShowDialog()
        mainFuncSubFunc(n) = frmStructDocSubFunctions.strInputSubFuncName
      Next
      lstStrucDoc.Items.Clear()
      lstStrucDoc.Items.Add(strFuncName & "()")

      For i As Integer = 0 To CInt(mainFuncSubFunc.Length) - 1
        lstStrucDoc.Items.Add(vbTab & mainFuncSubFunc(i) & "()")
      Next
      btnAppend.Visible = True
      cboFuncName.SelectedIndex = -1
    End If
  End Sub

  Private Sub btnAppend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppend.Click
    'This sub routine appends  the structure chart documentation displayed in the list box into the function
    'documentation text file.

    Dim sw As IO.StreamWriter
    sw = IO.File.AppendText(structurechartdocpath)
    For l As Integer = 0 To lstStrucDoc.Items.Count - 1
      sw.WriteLine(CStr(lstStrucDoc.Items(l)))
    Next
    sw.WriteLine(vbCrLf)
    sw.Close()

    MsgBox("Structure Outline (Chart) Documentation Saved to File")
    lstStatus.Items.Add("Added structure chart (outline) for the function named " & (CStr(lstStrucDoc.Items.Item(0))))
    lstStatus.Refresh()
    btnSaveAndClose.Visible = True
    btnAppend.Visible = False
    documentSaved = True
  End Sub

  Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
    ClearStrucDocFields()
  End Sub


  Private Sub btnSaveAndClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAndClose.Click
    Me.Close()
  End Sub

  '******************************************************THE FOLLOWING ARE DEVELOPER-WRITTEN SUB ROUTINES*************************************************************

  Private Sub WriteFile()
    'This sub procedure writes the information into the function document (text file) heading.

    'Creates the function document (text file) and adds the heading to text file.
    Dim sw As IO.StreamWriter
    sw = IO.File.CreateText(structurechartdocpath)
    sw.WriteLine("/*" & vbTab & "Name:    " & frmMainWindow.strStudentName)
    sw.WriteLine("  " & vbTab & "Date:    " & frmMainWindow.strDocumentDate)
    sw.WriteLine("  " & vbTab & "Program: " & frmMainWindow.strProgramName)
    sw.WriteLine("*/")
    sw.Close()

    'Window acknowledges creation of text file heading data.
    MsgBox("Name: " & frmMainWindow.strStudentName & vbCrLf & _
       "Date: " & frmMainWindow.strDocumentDate & vbCrLf & _
       "Program: " & frmMainWindow.strProgramName, MsgBoxStyle.OkOnly, "Document Heading Information")

    'Updates label controls with document and file information.
    lblStudentNameMem.Text = "Student Name: " & frmMainWindow.strStudentName
    lblProgramNameMem.Text = "Program Name: " & frmMainWindow.strProgramName
    lblDocumentDateMem.Text = "Document Date: " & frmMainWindow.strDocumentDate
    lblFileName.Text = "File name: " & structurechartdocpath

    'Resets control properties to indicate next step of structure chart documentation writing process.
    lblEnterStudProgBefore.Visible = False
    gbxEnterFuncDoc.Visible = True
    btnAppend.Visible = False
    btnSaveAndClose.Visible = False

    'Appends the heading to the structure chart documentation status box.
    lstStatus.Items.Add("Created structure chart document named " & structurechartdocpath & ".")
    lstStatus.Items.Add("Appended file with Document Heading Information")
  End Sub

  Sub ClearStrucDocFields()
    'This sub routine clears the contents of the input boxes so the user can restart entering the structure chart
    'documentation information.
    'Clears the values of all input combo and text boxes.
    cboFuncName.SelectedIndex = -1
    cboInputStudentName.SelectedIndex = -1
    cboInputProgramName.SelectedIndex = -1
    txtInputNumSubFunc.Clear()
    lstStrucDoc.Items.Clear()
    btnAppend.Visible = False
  End Sub

End Class