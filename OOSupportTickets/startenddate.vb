Public Class startenddate

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim dates As ArrayList = New ArrayList
        dates.Add(dtpStart.Value)
        dates.Add(dtpEnd.Value)
        Me.Tag = CType(dates, ArrayList)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class