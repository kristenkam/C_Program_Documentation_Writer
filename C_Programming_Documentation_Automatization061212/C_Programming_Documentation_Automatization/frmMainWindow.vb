Public Class frmMainWindow
  'Project name:        C-Programming Documentation Automation
  'Program:             This program automates the function and structure chart 
  '                     documenting process for a physically-challenged C-programmer.

  'Developer:           Kristen Kam
  'Support Contact:     kam.kristen@gmail.com
  'Date Created:        May 21, 2012
  'Date Last Modified:  June 12, 2012

  Friend strStudentName As String
  Friend strDocumentDate As String
  Friend strProgramName As String
  Friend strSystemFileName As String

  Private Sub btnAddUserName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUserName.Click
    'This sub procedure adds a user name to the file listing user names "names_users.txt".
    AppendSystemFile(txtInputUserName, "names_users.txt")
  End Sub

  Private Sub btnCreateProgramName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateProgramName.Click
    'This sub procedure adds a program name to the file listing program names "names_homework.txt".
    AppendSystemFile(txtCreateProgramName, "names_homework.txt")
  End Sub

  Private Sub btnAddFunction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFunction.Click
    'This sub procedure adds a function name to the file listing function  
    'names "names_userdefinedfunctions.txt".
    AppendSystemFile(txtInputUserDefFunc, "names_userdefinedfunctions.txt")
  End Sub

  Private Sub btnAddFuncVarType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFuncVarType.Click
    'This sub procedure adds a function or variable type name to the file listing
    'function or variable types "names_type.txt"
    AppendSystemFile(txtInputFuncVarType, "names_type.txt")
  End Sub

  Private Sub btnAddVariable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddVariable.Click
    'This sub procedure adds a variable name to the file listing variable names "names_variable.txt)
    AppendSystemFile(txtInputVariableName, "names_variable.txt")
  End Sub

  Private Sub btnCreateFuncDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFuncDoc.Click
    'This subprocedure shows the function documentation window as a modal dialog box.
    frmFuncDocWriter.ShowDialog()
  End Sub

  Private Sub btnCreateStrctureChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateStrctureChart.Click
    'This sub procedure shows the structure chart(outline) documentation window as a modal dialog box.
    frmStructDocChartWriter.ShowDialog()
  End Sub

  Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    'This sub procedure closes the entire application if the "close" button has been clicked.
    Me.Close()
  End Sub

  Private Sub btnDisplayUserList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayUserList.Click
    'This sub procudure executes the "DisplaySystemFile" sub procedure upon a button click.
    DisplaySystemFile("names_users.txt")
  End Sub

  Private Sub btnDisplayProgramNameList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayProgramNameList.Click
    'This sub procudure executes the "DisplaySystemFile" sub procedure upon a button click.
    DisplaySystemFile("names_homework.txt")
  End Sub

  Private Sub btnDisplayFuncNameList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayFuncNameList.Click
    'This sub procudure executes the "DisplaySystemFile" sub procedure upon a button click.
    DisplaySystemFile("names_userdefinedfunctions.txt")
  End Sub

  Private Sub btnDisplayFuncVarTypeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayFuncVarTypeList.Click
    'This sub procudure executes the "DisplaySystemFile" sub procedure upon a button click.
    DisplaySystemFile("names_type.txt")
  End Sub

  Private Sub btnDisplayVariableNameList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayVariableNameList.Click
    'This sub procudure executes the "DisplaySystemFile" sub procedure upon a button click.
    DisplaySystemFile("names_variable.txt")
  End Sub
  '******************************************************THE FOLLOWING ARE DEVELOPER-WRITTEN SUB ROUTINES*************************************************************
  Sub DisplaySystemFile(ByRef filename As String)
    'This sub procedure displays a system file.
    strSystemFileName = filename
    If frmDisplayContentsSystemFile.Created = True Then
      frmDisplayContentsSystemFile.RefreshDisplayContents()
      frmDisplayContentsSystemFile.BringToFront()
    Else
      frmDisplayContentsSystemFile.Show()
      frmDisplayContentsSystemFile.BringToFront()
    End If

  End Sub

  Sub AppendSystemFile(ByVal txt As TextBox, ByVal filename As String)
    'This sub procedure appends strings contained in a text box to a system file (e.g., variable
    'names list, function names list, user names list).

    Dim sw As IO.StreamWriter = IO.File.AppendText(filename)
    Dim strInputString As String = CStr(txt.Text)
    sw.WriteLine(txt.Text)
    sw.Close()

    MsgBox("You have added " & Chr(34) & strInputString & Chr(34) & " to the following file: " & filename)

    txt.Clear()
    txt.Focus()
  End Sub

  Public Sub PopulateComboBox(ByVal combobox As ComboBox, ByVal filepath As String)
    'This sub routine populates a combo box with a list of string values found in a text file

    'The following eight lines of code clears and (re-)populates a combo box.
    Dim reader As IO.StreamReader = IO.File.OpenText(filepath)
    combobox.Items.Clear()
    While Not reader.EndOfStream
      Dim line As String = reader.ReadLine
      combobox.Items.Add(line)
    End While
    reader.Close()
    combobox.SelectedIndex = -1
  End Sub

  Public Sub ConvertComboBoxSelectionToString(ByVal combobox As ComboBox, ByRef stringOutput As String)
    'This sub routine converts a selected item in a combo box into a string value and places it
    'into a string variable.

    Dim builder As New System.Text.StringBuilder()
    builder.Append(combobox.SelectedItem)
    Dim strCboBoxSelectedItem As String = builder.ToString
    stringOutput = strCboBoxSelectedItem

  End Sub


End Class
