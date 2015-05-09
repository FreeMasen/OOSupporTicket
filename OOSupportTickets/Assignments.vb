Imports System.Data.SqlClient
Imports System.Text
Public Class Assignments
    'this object will perform our database interaction
    Dim sqlbot As New SQLBot
    'this will hold our tickets
    Dim TableOfTickets As New DataTable
    'this will hold the tech that was selected in the last window
    Dim currentTech As Tech
    'this will hold the string built by our database query
    Dim statement As New StringBuilder



    Private Sub Assignments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'first pull in the tag as an arraylist
        Dim source As ArrayList = CType(Me.Tag, ArrayList)
        'hold a temp table of tech info
        Dim techtable As New DataTable
        'set the tech into to the table
        techtable = sqlbot.returnDataTable(String.Format("SELECT * from Techs where TechID = {0}", source(1)))

        'set the tech
        currentTech = New Tech(CStr(techtable.Rows(0).Item(1)), CStr(techtable.Rows(0).Item(2)), CStr(techtable.Rows(0).Item(3)), CInt(techtable.Rows(0).Item(4)), CInt(techtable.Rows(0).Item(0)))
        'string variable
        Dim output As String
        'check if the user clicked pending or completed tickets
        If source(0) Is "Pending" Then
            'fill the table with tickets
            TableOfTickets = sqlbot.returnDataTable(String.Format("SELECT * FROM Tickets WHERE assignment = {0} and resolved = 0 ORDER BY severity DESC", currentTech.TechID.ToString))
        ElseIf source(0) Is "Completed" Then
            'fill the table with tickets
            TableOfTickets = sqlbot.returnDataTable(String.Format("SELECT * FROM Tickets WHERE assignment = {0} and resolved = 1 ORDER BY severity DESC", currentTech.TechID.ToString))
            'add the first line of the txtbox
            statement.Append(String.Format("Showing tickets from {0} to {1}", CDate(source(3)).ToShortDateString, CDate(source(4)).ToShortDateString)).AppendLine()
        End If
        If TableOfTickets.Rows.Count = 0 Then
            'check if the table is empty, if not show a genaric message
            output = "Agent has no assignments"
        Else
            'if not for each of the rows in the table
            For Each row As DataRow In TableOfTickets.Rows
                'add that information to the textbox in the specified order
                statement.Append(String.Format("Ticket ID: {0}", row.Item(0))).AppendLine()
                statement.Append(String.Format("Issue: {0} Reporter: {1} Date Submitted: {2} Severity: {3}", row.Item(1), row.Item(2), _
                                               CDate(row.Item(4)).ToShortDateString, row.Item(5))).AppendLine()
                statement.Append(String.Format("Date Resolved: {0} Resolution {1}", row.Item(8), row.Item(9))).AppendLine()

            Next
            'set the output variable to the stringbuilder results
            output = statement.ToString
        End If
        'set the label to the reflect the current tech info
        Me.Text = String.Format("{0} work for {1}", source(0), source(2))
        'pdate the txtbox
        txtAssignments.Text = output
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        'if the user clicks the email button, fill in the email with the subject and all of the assignments reflected in the box. 
        currentTech.emailTicket("Your assigmments", statement.ToString)
    End Sub
End Class