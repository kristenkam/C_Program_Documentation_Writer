Public Class frmCreateParamtr

  'Project name:        C-Programming Documentation Automation
  'Program:             This program automates the function and structure chart 
  '                     documenting process for an physically-challenged C-programmer.

  'Developer:           Kristen Kam
  'Support Contact:     kam.kristen@gmail.com
  'Date Created:        May 21, 2012
  'Date Last Modified:  June 12, 2012
  '****Function Document Writer Parameter Creater window*******

  Dim parameterinserted As Boolean = False
  Private Sub frmCreateParamtr_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Dim response As MsgBoxResult
    If parameterinserted = False Then
      response = MsgBox("You have not inserted a parameter (pre: or post:) into the function document writer. " & _
                        "Do you want to quit creating a parameter? ", MsgBoxStyle.YesNo, "No Pre: or Post: Created!")
      If response = MsgBoxResult.Yes Then
        frmFuncDocWriter.stopcreateparameter = True
        Exit Sub
      ElseIf response = MsgBoxResult.No Then
        e.Cancel = True
      End If


    End If
  End Sub

  Private Sub frmCreatePre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'This subroutine populates the combo boxes of the Create Parameter Window

    'Clears combobox and text box values upon load.
    'Me.cboParameterType.Items.Clear()
    Me.cboParameterName.Items.Clear()
    Me.txtArguementParameter.Clear()

    'Populates the select parameter name combo box with function and variable names.
    Dim strfilepathObjtNameList As String = "names_userdefinedfunctions.txt"
    Dim reader As IO.StreamReader = IO.File.OpenText(strfilepathObjtNameList)
    While Not reader.EndOfStream
      Dim line As String = reader.ReadLine
      Me.cboParameterName.Items.Add(line)
      cboParameterName.SelectedIndex = -1
    End While
    reader.Close()

    'Populates the select parameter name combo box with variable names.
    strfilepathObjtNameList = "names_variable.txt"
    reader = IO.File.OpenText(strfilepathObjtNameList)
    While Not reader.EndOfStream
      Dim line As String = reader.ReadLine
      Me.cboParameterName.Items.Add(line)
      cboParameterName.SelectedIndex = -1
    End While
    reader.Close()

    'Populates the select parameter type combo box.
    frmMainWindow.PopulateComboBox(cboParameterType, "names_type.txt")

  End Sub

  Private Sub btnCreateArgument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateArgument.Click
    'Creates an arguement for insertion into Pre:

    Dim builder As New System.Text.StringBuilder()

    'Following five lines of code converts selection of cboParameter Name Selection to a String and
    'appends the string to the text box text property.
    builder.Append(cboParameterName.SelectedItem)

    Dim strCboBoxSelectedItem As String = builder.ToString
    'MsgBox(strCboBoxSelectedItem)
    txtArguementParameter.Text = strCboBoxSelectedItem
    builder.Clear()

    'Following four lines of code converts selection of cboParameterType Selection to a String.
    'appends the string to the text box text property.
    builder.Append(cboParameterType.SelectedItem)
    strCboBoxSelectedItem = builder.ToString
    txtArguementParameter.Text &= Chr(32) & Chr(40) & strCboBoxSelectedItem & Chr(41)
    builder.Clear()

    cboParameterName.SelectedIndex = -1
    cboParameterType.SelectedIndex = -1
  End Sub

  Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
    txtArguementParameter.Clear()
  End Sub

  Private Sub btnInsertToPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertToPre.Click
    'Inserts argument(s) into Pre or Post

    'If Elseif Conditional Statement to determine whether to insert argument into Pre or Post.
    If frmFuncDocWriter.blnInsertPre = True And frmFuncDocWriter.blnInsertPost = False Then
      frmFuncDocWriter.strInsertFuncPre &= txtArguementParameter.Text & Chr(44)
    ElseIf frmFuncDocWriter.blnInsertPost = True And frmFuncDocWriter.blnInsertPre = False Then
      frmFuncDocWriter.strInsertFuncPost &= txtArguementParameter.Text & Chr(44)
    Else
      MsgBox("Error inserting argument into Pre: or Post:", MsgBoxStyle.Exclamation)
    End If
    parameterinserted = True
    Me.Close()
  End Sub
End Class