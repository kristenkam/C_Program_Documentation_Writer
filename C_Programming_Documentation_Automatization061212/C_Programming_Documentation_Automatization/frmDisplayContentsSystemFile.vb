Public Class frmDisplayContentsSystemFile

  'Project name:        C-Programming Documentation Automation
  'Program:             This program automates the function and structure chart 
  '                     documenting process for an physically-challenged C-programmer.

  'Developer:           Kristen Kam
  'Support Contact:     kam.kristen@gmail.com
  'Date Created:        May 21, 2012
  'Date Last Modified:  June 12, 2012
  '****Display System Text File Contents Window*******

  Private Sub frmDisplayContentsSystemFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    RefreshDisplayContents()
  End Sub

  Public Shadows Sub RefreshDisplayContents()

    Dim systemfilename As String = frmMainWindow.strSystemFileName
    Dim sr As IO.StreamReader = IO.File.OpenText(systemfilename)
    Dim strFileContents As String

    Me.Text = "Contents of the " & systemfilename
    lblFileNameDisplayed.Text = "Displaying contents of the file named: " & systemfilename

    strFileContents = sr.ReadToEnd
    txtSystemFileContents.Clear()
    txtSystemFileContents.Text = strFileContents
    sr.Close()
  End Sub

  Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
    RefreshDisplayContents()
  End Sub

  Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub
End Class