Public Class frmFuncDocResults

  'Project name:        C-Programming Documentation Automation
  'Program:             This program automates the function and structure chart 
  '                     documenting process for an physically-challenged C-programmer.

  'Developer:           Kristen Kam
  'Support Contact:     kam.kristen@gmail.com
  'Date Created:        May 21, 2012
  'Date Last Modified:  June 12, 2012
  '****Function Document Writer Results Window*******

  Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'This sub routine displays the contents of the function document that was just written.
    lblFunctionDocumentation.Text = "Contents of Function Document Named:  " & frmFuncDocWriter.funcdocpath.Substring(0, frmFuncDocWriter.funcdocpath.IndexOf("."))

    Dim tr As IO.TextReader = New IO.StreamReader(frmFuncDocWriter.funcdocpath)
    Dim s As String = tr.ReadToEnd

    txtFuncDocResults.Text = s

  End Sub

  Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub
End Class