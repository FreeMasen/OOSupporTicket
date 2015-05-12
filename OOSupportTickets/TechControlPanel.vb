Imports System.Data.SqlClient

Public Class TicketsToWork
    'declares an sqlbot to grab information form the database
    Dim sqlBot As New SQLBot
    'this block also sets up a data adapter and data table to be used
    'by other parts of the program that need to reference/modify the tickets table
    Dim dataTable As New DataTable
    Dim techTable As New DataTable

    'this will store the current tech that is logged in
    Dim currentTech As Tech

    'holds an arraylist of the tickets assigned to the currenttech
    Dim tickets1 As New ArrayList 'collectionbase object?

    'this holds the currently selected ticket a ticket object
    Dim selectedTicket As Ticket

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'define the current tech based on the tag passed by another form
        currentTech = CType(Me.Tag, Tech)
        'calls the updatelists function
        updateLists()
    End Sub

    Private Sub updateLists()
        'first clear all collections
        tickets1.Clear()
        lstTickets.Items.Clear()
        dataTable.Clear()
        techTable.Clear()
        lblErros.Text = ""


        If IsNothing(currentTech) = False Then
            '    'if the current tech is populated
            '    'build a sql query pulling the unresolved
            '    'tickets for the currentagent ordered by the severity
            dataTable = sqlBot.returnDataTable(String.Format("SELECT * FROM Tickets WHERE assignment = {0} and resolved = 0 ORDER BY severity DESC", CInt(currentTech.TechID)))
        End If
        For Each row As DataRow In dataTable.Rows
            'hold a temp ticket
            Dim newTicket As Ticket

            'consturct a new ticket
            newTicket = New Ticket(CStr(row.Item(1)), CStr(row.Item(2)), CStr(row.Item(3)), CDate(row.Item(4)), CInt(row.Item(5)), CBool(row.Item(6)), CInt(row.Item(0)))

            'add this ticket to the arraylist
            tickets1.Add(newTicket)
        Next

        If tickets1.Count > 0 Then
            'if the tickets is not empty loop over the arraylist
            For Each newTicket As Ticket In tickets1
                'add a string version of the ticket to the listbox
                lstTickets.Items.Add(newTicket.toStringShort())
            Next

        End If
        'update the lable to show who is logged in
        lblTickets.Text = String.Format("Tickets assigned to {0} {1}", currentTech.firstname, currentTech.lastname)
    End Sub

    Private Sub btnResolveTicket_Click(sender As Object, e As EventArgs) Handles btnResolveTicket.Click
        'if something is selected
        If lstTickets.SelectedIndex <> -1 Then
            'and a resolution has been added
            If txtResolution.Text.Length > 255 Then

                'update the selected ticket with the data in the resolution txtbox
                selectedTicket.resolution = txtResolution.Text

                'update the date to now
                selectedTicket.dateResolved = Now

                'update the resolved bool to true
                selectedTicket.resolved = True

                'build a parameterized query to update the selected ticket
                Dim command As String = String.Format("UPDATE tickets SET resolution = @resolution, dateResolved = @dateresolved, resolved = 1 WHERE TicketID = @ID")
                Dim updateResolution As New SqlCommand(command, sqlBot.connection)
                updateResolution.Parameters.AddWithValue("@resolution", selectedTicket.resolution)
                updateResolution.Parameters.AddWithValue("@dateresolved", selectedTicket.dateResolved)
                updateResolution.Parameters.AddWithValue("@ID", selectedTicket.ID)
                Try
                    'submit the ticket data to the table
                    sqlBot.connection.Open()
                    updateResolution.ExecuteNonQuery()
                    sqlBot.connection.Close()

                    'open an email to the reporter telling them there issue has been resolved
                    selectedTicket.emailReporter("Your ticket has been resolved", String.Format("Your ticket submitted on {0} was completed by {1} {2} originally reported as {3} your resolution was: {4}. If you are still experienceing issue please contact the help desk", _
                                                                                                selectedTicket.dateReported.ToShortDateString, currentTech.firstname, currentTech.lastname, selectedTicket.Issue, selectedTicket.resolution))
                Catch ex As SqlException
                    'report any sql errors to a msgbox
                    MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
                End Try
                'update the lists to refelct the resolution
                updateLists()
            Else
                lblErros.Text = "Your resolution cannot be less than 255 characters."
            End If
        Else
            lblErros.Text = "Please Select a ticket."
        End If
    End Sub

    Private Sub lstTickets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTickets.SelectedIndexChanged
        'if something is selected
        If lstTickets.SelectedIndex > -1 Then

            'update the selected ticket with the selection from the list box
            selectedTicket = CType(tickets1(lstTickets.SelectedIndex), Ticket)

            'display the values of the ticket in the txtboxes
            txtReporter.Text = selectedTicket.reporter
            txtIssue.Text = selectedTicket.issue
        End If
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        If lstTickets.SelectedIndex <> -1 Then
            'if a selection is made, create an email for the agent to ask more questions. 
            selectedTicket.emailReporter("Question about your currently open support ticket")
        Else
            lblErros.Text = "Please select a ticket"
        End If
    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        help.Tag = "tech"
        help.Show()

    End Sub
End Class
