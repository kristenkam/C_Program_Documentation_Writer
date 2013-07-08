Public Class frmFuncDocWriter
  'Project name:        C-Programming Documentation Automation
  'Program:             This program automates the function and structure chart 
  '                     documenting process for an physically-challenged C-programmer.

  'Developer:           Kristen Kam
  'Support Contact:     kam.kristen@gmail.com
  'Date Created:        May 21, 2012
  'Date Last Modified:  June 12, 2012
  '****Function Document writer window*****

  Public funcdocpath As String
  Public strInsertFuncPre As String
  Public strInsertFuncPost As String
  Public blnInsertPre As Boolean = False
  Public blnInsertPost As Boolean = False
  Public documentSaved As Boolean = False
  Public stopcreateparameter As Boolean = False

  Private Sub frmFuncDocWriter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'This sub routine prompts the user for the function document name, populates the student program 
    'input text boxes with the values, if available, of the global variables related to the student name, 
    'program name, and document date. And the program also populates the values of the combo box.

    documentSaved = False

    'Updates label of project information (if saved)
    lblStudentNameMem.Text = "Student Name: " & frmMainWindow.strStudentName
    lblProgramNameMem.Text = "Program Name: " & frmMainWindow.strProgramName
    lblDocumentDateMem.Text = "Document Date: " & frmMainWindow.strDocumentDate

    'Executes the PopulateComboBox sub routine to populate the combo boxes named, "cboInputStudentName", "cboInputProgramName", and "cboFuncName"
    frmMainWindow.PopulateComboBox(cboInputStudentName, "names_users.txt")
    frmMainWindow.PopulateComboBox(cboInputProgramName, "names_homework.txt")
    frmMainWindow.PopulateComboBox(cboFuncName, "names_userdefinedfunctions.txt")

  End Sub

  Private Sub frmFuncDocWriter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    'This sub procedure prompts the user whether or not s/he wants to continue editing a file when 
    'a close event related to Function Document Writer window occurs.
    Dim response As MsgBoxResult

    If documentSaved = True Then
      response = MsgBox("Do you want to keep adding functions to " & funcdocpath & "?", MsgBoxStyle.YesNo, "Function Documentation Writer Close Attempt!")
      If response = MsgBoxResult.Yes Then
        e.Cancel = True
      ElseIf response = MsgBoxResult.No Then
        Dim response2 As MsgBoxResult
        response2 = MsgBox("Do you want to view the function document of " & funcdocpath & "?", MsgBoxStyle.YesNo, "Function Documentation Writer Close Attempt!")
        If response2 = MsgBoxResult.Yes Then
          frmFuncDocResults.ShowDialog()
          ClearFuncDocFields()
          lstStatus.Items.Clear()
          gbxEnterFuncDoc.Visible = False
          lblEnterStudProgBefore.Visible = True
          documentSaved = False
        Else
          ClearFuncDocFields()
          lstStatus.Items.Clear()
          gbxEnterFuncDoc.Visible = False
          lblEnterStudProgBefore.Visible = True
          documentSaved = False
        End If
      End If
    ElseIf documentSaved = False Then
      response = MsgBox("You have not saved any documentation to the text document yet! Do you want to abort the Function Document Writer?", MsgBoxStyle.YesNo, "Function Documentation Writer Close Attempt!")
      If response = MsgBoxResult.Yes Then
        ClearFuncDocFields()
        lstStatus.Items.Clear()
        gbxEnterFuncDoc.Visible = False
        lblEnterStudProgBefore.Visible = True
        If IO.File.Exists(funcdocpath) = True Then
          System.IO.File.Delete(funcdocpath)
        End If
        documentSaved = False
      ElseIf response = MsgBoxResult.No Then
        e.Cancel = True
      End If
    End If
  End Sub

  Private Sub btnSaveStudentDocInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveStudentDocInfo.Click
    'This function saves the student and program information into memory and writes the information into the 
    'function document (text file) heading.

    Dim response As MsgBoxResult

    'Following 9 lines of code saves the user inputted student and program information to memory
    Dim builder As New System.Text.StringBuilder()
    builder.Append(cboInputStudentName.SelectedItem)
    frmMainWindow.strStudentName = builder.ToString
    builder.Clear()
    builder.Append(cboInputProgramName.SelectedItem)
    frmMainWindow.strProgramName = builder.ToString
    builder.Clear()
    frmMainWindow.strDocumentDate = FormatDateTime(CDate(dtpDocDate.Text), DateFormat.ShortDate)
    funcdocpath = frmMainWindow.strProgramName & "_funcdoc.txt" 'Function document name & location

    If IO.File.Exists(funcdocpath) Then
      response = MsgBox("The file named " & funcdocpath & " exists. Do you want to overwrite the file?", _
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

  Private Sub btnCreateFuncDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFuncDoc.Click
    'This sub routine creates the function documentation for the user to view before saving.

    'Checks to see if all fields are filled before creating the function documentation.
    If cboFuncName.SelectedIndex < 0 Then
      MsgBox("Please choose a function name.")
    ElseIf txtInputFuncDesc.TextLength = 0 Then
      MsgBox("Please enter a function description.")
    ElseIf txtInputFuncPre.TextLength = 0 Then
      MsgBox("Please enter a function pre.")
    ElseIf txtInputFuncPost.TextLength = 0 Then
      MsgBox("Please enter a function post.")
    Else
      'Declares variables to create lines of function documentation
      Dim strFuncName As String
      Dim strFuncDesc As String
      Dim strFuncPre As String
      Dim strFuncPost As String

      Dim builder As New System.Text.StringBuilder()

      'Converts selected combobox item
      builder.Append(cboFuncName.SelectedItem)

      'Converts selected combo item to a string
      Dim strCboBoxSelectedItem As String = builder.ToString
      strFuncName = strCboBoxSelectedItem


      'Assigns text box input values to a string variable
      strFuncDesc = txtInputFuncDesc.Text
      strFuncPre = txtInputFuncPre.Text
      strFuncPost = txtInputFuncPost.Text

      'Creates lines of function description and displays it into the text box.
      lstFuncDoc.Items.Clear()
      lstFuncDoc.Items.Add("/* ===============================================")
      lstFuncDoc.Items.Add("  //Function:    " & strFuncName)
      lstFuncDoc.Items.Add("  //Description: " & strFuncDesc)
      lstFuncDoc.Items.Add("  //Pre:         " & strFuncPre)
      lstFuncDoc.Items.Add("  //Post:        " & strFuncPost)
      If txtInputReturn.Text.Length > 0 Then
        lstFuncDoc.Items.Add("  //Return:      " & txtInputReturn.Text)
      Else
        lstFuncDoc.Items.Add("  //Return:      Nothing")
      End If
      lstFuncDoc.Items.Add("*/")
      builder.Clear()
      btnAppend.Visible = True
    End If

  End Sub

  Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
    'This sub routine calls the ClearFunctionDocFields--which clears the document writer's fields--when a
    'button clear event occurs.
    ClearFuncDocFields()
  End Sub

  Private Sub btnAppend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppend.Click
    'This sub routine appends  the function documentation displayed in the list box into the function
    'documentation text file.

    Dim sw As IO.StreamWriter
    sw = IO.File.AppendText(funcdocpath)
    For l As Integer = 0 To lstFuncDoc.Items.Count - 1
      sw.WriteLine(CStr(lstFuncDoc.Items(l)))
    Next
    sw.WriteLine(vbCrLf)
    sw.Close()

    MsgBox("Function Documentation Saved to File")
    lstStatus.Items.Add("Added documenation for function named " & (CStr(lstFuncDoc.Items.Item(1)).Substring(17)))
    lstStatus.Refresh()
    btnSaveAndClose.Visible = True
    btnAppend.Visible = False
    documentSaved = True
  End Sub

  Private Sub btnSaveAndClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAndClose.Click
    'Closes the function documentation writer upon a button close click event.
    Me.Close()
  End Sub

  Private Sub btnCreatePre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePre.Click
    blnInsertPre = True
    'Sub routine features For Next loop to create the number of arguments specified by the user

    txtInputFuncPre.Clear()

    If txtInputNumPreParameters.TextLength = 0 Then
      MsgBox("You are specifying that there are no Pre parameters")
      txtInputFuncPre.Text = "0"
    ElseIf txtInputNumPreParameters.TextLength > 0 And CInt(txtInputNumPreParameters.Text) > 0 Then
      Dim intNumParameter As Integer = CInt(txtInputNumPreParameters.Text)
      For i As Integer = 0 To intNumParameter - 1
        frmCreateParamtr.ShowDialog()
        If stopcreateparameter = True Then
          txtInputNumPreParameters.Clear()
          Exit Sub
        End If
      Next
      txtInputFuncPre.Text = strInsertFuncPre.Substring(0, strInsertFuncPre.Length - 1)
    Else
      MsgBox("You are specifying that there are no Pre parameters")
      txtInputFuncPre.Text = "0"
    End If
    blnInsertPre = False
    strInsertFuncPre = ""
  End Sub

  Private Sub btnCreatePost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePost.Click
    blnInsertPost = True
    'Sub routine loop to create argument.
    txtInputFuncPost.Clear()

    If txtInputNumPostParameters.TextLength = 0 Then
      MsgBox("You are specifying that there are no Post parameters")
      txtInputFuncPost.Text = "0"
    ElseIf txtInputNumPostParameters.TextLength > 0 And CInt(txtInputNumPostParameters.Text) > 0 Then
      Dim intNumParameter As Integer = CInt(txtInputNumPostParameters.Text)
      For i As Integer = 0 To intNumParameter - 1
        frmCreateParamtr.ShowDialog()
        If stopcreateparameter = True Then
          txtInputNumPostParameters.Clear()
          Exit Sub
        End If
      Next
      txtInputFuncPost.Text = strInsertFuncPost.Substring(0, strInsertFuncPost.Length - 1)
    Else
      MsgBox("You are specifying that there are no Post parameters")
      txtInputFuncPost.Text = "0"
    End If
    blnInsertPost = False
    strInsertFuncPost = ""
  End Sub

  '******************************************************THE FOLLOWING ARE DEVELOPER-WRITTEN SUB ROUTINES*************************************************************
  Sub WriteFile()
    'This sub procedure writes the student and program information into the function document (text file)
    ' heading. 

    'Creates the function document (text file) and adds the heading to text file.
    Dim sw As IO.StreamWriter
    sw = IO.File.CreateText(funcdocpath)
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
    lblFileName.Text = "File name: " & funcdocpath

    'Resets control properties to indicate next step of function documentation writing process.
    lblEnterStudProgBefore.Visible = False
    gbxEnterFuncDoc.Visible = True
    btnAppend.Visible = False
    btnSaveAndClose.Visible = False

    'Appends the heading to the function documentation status box.
    lstStatus.Items.Add("Created function document named " & funcdocpath & ".")
    lstStatus.Items.Add("Appended file with Document Heading Information")
  End Sub

  Sub ClearFuncDocFields()
    'This sub routine clears the contents of the input boxes so the user can restart entering the function
    'documentation information.
    'Clears the values of all input combo and text boxes.

    cboFuncName.SelectedIndex = -1
    cboInputProgramName.SelectedIndex = -1
    cboInputStudentName.SelectedIndex = -1
    txtInputFuncDesc.Clear()
    txtInputFuncPre.Clear()
    txtInputFuncPost.Clear()
    lstFuncDoc.Items.Clear()
    txtInputReturn.Clear()
    txtInputNumPreParameters.Clear()
    txtInputNumPostParameters.Clear()
    btnAppend.Visible = False
  End Sub
End Class