Imports System.Data.SqlClient

Public Class TicketsToWork
    'defines to source for all of the tables we will be referencing
    Dim Connection As New SqlConnection("server=HERMAN-W8\sqlexpress;database=support;Trusted_Connection=Yes")

    'this block also sets up a data adapter and data table to be used
    'by other parts of the program that need to reference/modify the tickets table
    Dim dataAdapter As New SqlDataAdapter
    Dim dataTable As New DataTable
    Dim techTable As New DataTable
    'a second dataadapter to grab the current tech
    Dim techadapter As New SqlDataAdapter

    'this will store the current tech that is logged in
    Dim currentTech As Tech

    'holds an arraylist of the tickets assigned to the currenttech
    Dim tickets As New ArrayList 'collectionbase object?

    'this holds the currently selected ticket a ticket object
    Dim selectedTicket As Ticket

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calls the updatelists function
        updateLists()
    End Sub

    Private Sub updateLists()
        'first clear all collections
        tickets.Clear()
        lstTickets.Items.Clear()
        dataTable.Clear()
        techTable.Clear()

        'set the data adapter with that will reference the
        'a techID fed by the statement that opens this program
        techadapter = New SqlDataAdapter(String.Format("SELECT * FROM techs WHERE TechID = {0}", 1), Connection)

        'fill the tech information to a datatable
        techadapter.Fill(techTable)

        If techTable.Rows.Count > 0 Then
            'if the table is not empty, add the first row's information as 
            'to the current tech object
            currentTech = New Tech(CStr(techTable.Rows(0).Item(1)), CStr(techTable.Rows(0).Item(2)), CStr(techTable.Rows(0).Item(3)), techTable.Rows(0).Item(4))
            currentTech.TechID = CInt((techTable.Rows(0).Item(0)))
        End If


        If IsNothing(currentTech) = False Then
            'if the current tech is populated
            'build a sql query pulling the unresolved
            'tickets for the currentagent ordered by the severity
            dataAdapter = New SqlDataAdapter(String.Format("SELECT * FROM Tickets WHERE assignment = {0} and resolved = 0 ORDER BY severity DESC", CInt(currentTech.TechID)), Connection)

            'hold this infromation in the table
            dataAdapter.Fill(dataTable)
        End If

        For Each row As DataRow In dataTable.Rows
            'hold a temp ticket
            Dim newTicket As Ticket

            'consturct a new ticket
            newTicket = New Ticket(CStr(row.Item(1)), CStr(row.Item(2)), CStr(row.Item(3)), CDate(row.Item(4)), CInt(row.Item(5)), CBool(row.Item(6)))
            newTicket.ID = CInt(row.Item(0))

            'add this ticket to the arraylist
            tickets.Add(newTicket)
        Next

        If tickets.Count > 0 Then
            'if the tickets is not empty loop over the arraylist
            For Each newTicket In tickets
                'add a string version of the ticket to the listbox
                lstTickets.Items.Add(newTicket.tostringshort())
            Next

        End If
        'update the lable to show who is logged in
        lblTickets.Text = String.Format("Tickets assigned to {0} {1}", currentTech.firstname, currentTech.lastname)
    End Sub

    Private Sub btnResolveTicket_Click(sender As Object, e As EventArgs) Handles btnResolveTicket.Click
        'if something is selected
        If lstTickets.SelectedIndex <> -1 Then
            'and a resolution has been added
            If txtResolution.Text.Length > 0 Then

                'update the selected ticket with the data in the resolution txtbox
                selectedTicket.resolution = txtResolution.Text

                'update the date to now
                selectedTicket.dateResolved = Now

                'update the resolved bool to true
                selectedTicket.resolved = True

                'build a parameterized query to update the selected ticket
                Dim command As String = String.Format("UPDATE tickets SET resolution = @resolution, dateResolved = @dateresolved, resolved = 1 WHERE TicketID = @ID")
                Dim updateResolution As New SqlCommand(command, Connection)
                updateResolution.Parameters.AddWithValue("@resolution", selectedTicket.resolution)
                updateResolution.Parameters.AddWithValue("@dateresolved", selectedTicket.dateResolved)
                updateResolution.Parameters.AddWithValue("@ID", selectedTicket.ID)
                Try
                    'submit the ticket data to the table
                    Connection.Open()
                    updateResolution.ExecuteNonQuery()
                    Connection.Close()

                    'open an email to the reporter telling them there issue has been resolved
                    selectedTicket.emailReporter("Your ticket has been resolved", String.Format("Your ticket submitted on {0} was completed by {1} {2} originally reported as {3} your resolution was: {4}. If you are still experienceing issue please contact the help desk", _
                                                                                                selectedTicket.dateReported.ToShortDateString, currentTech.firstname, currentTech.lastname, selectedTicket.Issue, selectedTicket.resolution))
                Catch ex As SqlException
                    'report any sql errors to a msgbox
                    MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
                End Try
                'update the lists to refelct the resolution
                updateLists()
            End If
        End If
    End Sub

    Private Sub lstTickets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTickets.SelectedIndexChanged
        'if something is selected
        If lstTickets.SelectedIndex > -1 Then

            'update the selected ticket with the selection from the list box
            selectedTicket = tickets(lstTickets.SelectedIndex)

            'display the values of the ticket in the txtboxes
            txtReporter.Text = selectedTicket.Reporter
            txtIssue.Text = selectedTicket.Issue
        End If
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        If lstTickets.SelectedIndex <> -1 Then
            'if a selection is made, create an email for the agent to ask more questions. 
            selectedTicket.emailReporter("Question about your currently open support ticket")
        End If
    End Sub
End Class
