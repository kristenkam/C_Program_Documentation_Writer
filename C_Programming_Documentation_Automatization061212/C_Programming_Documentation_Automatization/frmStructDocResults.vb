Public Class frmStructDocResults
  'Project name:        C-Programming Documentation Automation
  'Program:             This program automates the function and structure chart 
  '                     documenting process for an physically-challenged C-programmer.

  'Developer:           Kristen Kam
  'Support Contact:     kam.kristen@gmail.com
  'Date Created:        May 21, 2012
  'Date Last Modified:  June 12, 2012
  '****Structure Chart (Outline) Document Writer Results Window*******

  Private Sub frmStructDocResults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'This sub routine displays the contents of the function document that was just written.
    lblStructureChartDoc.Text = "Contents of Function Document Named:  " & frmStructDocChartWriter.structurechartdocpath.Substring(0, frmStructDocChartWriter.structurechartdocpath.IndexOf("."))

    Dim tr As IO.TextReader = New IO.StreamReader(frmStructDocChartWriter.structurechartdocpath)
    Dim s As String = tr.ReadToEnd

    txtStructDocResults.Text = s
  End Sub

  Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub
End Class