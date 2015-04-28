Imports System.Windows.Forms

Public Class ResolutionWindow


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtResolution.Text = "" Then
            lblWarning.Text = "Please enter a resolution"
            Return
        End If


    End Sub
End Class