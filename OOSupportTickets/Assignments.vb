Imports System.Data.SqlClient
Imports System.Text
Public Class Assignments
    Dim objConnection As New SqlConnection("server=HERMAN-W8\sqlexpress;database=support;Trusted_Connection=Yes")
    Dim objDataAdapter As New SqlDataAdapter
    Dim TableOfTickets As New DataTable

    Private Sub Assignments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim source As ArrayList = CType(Me.Tag, ArrayList)
        Dim techID As Integer = CInt(source(1))
        Dim statement As New StringBuilder
        Dim output As String
        If source(0) Is "Pending" Then
            objDataAdapter = New SqlDataAdapter(String.Format("SELECT * FROM Tickets WHERE assignment = {0} and resolved = 0 ORDER BY severity DESC", techID.ToString), objConnection)

        ElseIf source(0) Is "Completed" Then
            statement.Append(String.Format("Showing tickets from {0} to {1}", CDate(source(3)).ToShortDateString, CDate(source(4)).ToShortDateString)).AppendLine()
            objDataAdapter = New SqlDataAdapter(String.Format("SELECT * FROM Tickets WHERE assignment = {0} and resolved = 1 ORDER BY severity DESC", techID.ToString), objConnection)
        End If
        objDataAdapter.Fill(TableOfTickets)
        If TableOfTickets.Rows.Count = 0 Then
            output = "Agent has no assignments"
        Else
            For Each row As DataRow In TableOfTickets.Rows
                statement.Append(String.Format("Ticket ID: {0}", row.Item(0))).AppendLine()
                statement.Append(String.Format("Issue: {0} Reporter: {1} Date Submitted: {2} Severity: {3}", row.Item(1), row.Item(2), _
                                               CDate(row.Item(4)).ToShortDateString, row.Item(5))).AppendLine()
                statement.Append(String.Format("Date Resolved: {0} Resolution {1}", row.Item(8), row.Item(9))).AppendLine()

            Next
            output = statement.ToString
        End If
        Me.Text = String.Format("{0} work for {1}", source(0), source(2))
        txtAssignments.Text = output
    End Sub

End Class