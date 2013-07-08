Public Class frmStructDocSubFunctions
  'Project name:        C-Programming Documentation Automation
  'Program:             This program automates the function and structure chart 
  '                     documenting process for an physically-challenged C-programmer.

  'Developer:           Kristen Kam
  'Support Contact:     kam.kristen@gmail.com
  'Date Created:        May 21, 2012
  'Date Last Modified:  June 12, 2012
  '****Structure Chart (Outline) Document Writer sub-functions window*****

  Friend strInputSubFuncName As String
  Private Sub frmStructDocSubFunctions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'This sub routine executes upon the loading of the form.

    'Updates the label to communicate to user what sub-function needs to be created.
    lblSubFuncName.Text = "Enter Sub Function No." & CStr(frmStructDocChartWriter.intNum) & " Sub Function Name:"

    'Populates the list of sub-functions held within the combo box named "cboFuncName"
    frmMainWindow.PopulateComboBox(cboFuncName, "names_userdefinedfunctions.txt")
  End Sub

  Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click

    'Converts selected sub-function combo box item to a string
    frmMainWindow.ConvertComboBoxSelectionToString(cboFuncName, strInputSubFuncName)
    cboFuncName.SelectedIndex = -1
    Me.Close()
  End Sub
End Class