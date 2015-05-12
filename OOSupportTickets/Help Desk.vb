Imports System.Data.SqlClient

Public Class HelpDesk
    Dim sqlbot As New SQLBot
    'this block also sets up a data adapter and data table to be used
    'by other parts of the program that need to reference/modify the tickets table
    Dim dataAdapter As New SqlDataAdapter
    Dim dataTable As New DataTable

    'same as above but for the techs table
    Dim agentDataAdapter As New SqlDataAdapter
    Dim AgentTable As New DataTable

    'prepares an arraylist to hold the agents from the techs table
    Dim agents As ArrayList = New ArrayList 'should this be a collectionbase object instead of an AL?
    Dim Tickets As ArrayList = New ArrayList

    'this method will ensure that the information in the listbox will be
    'congruent with the tickets table from the database
    Public Sub updatelists()
        'first we clear both the listbox and the datatable
        lstPendingTickets.Items.Clear()
        dataTable.Clear()
        Tickets.Clear()

        Try
            'try to selected all of the tickets that are not marked as 
            'resolved and not assigned and order them by severity
            'fill the datatable
            dataTable = sqlbot.returnDataTable("SELECT * FROM Tickets WHERE resolved = 0 and assignment is null ORDER BY Severity DESC")

        Catch ex As SqlException
            'catch and sqlExceptions and write them to a messagebox for debugging
            'this includes the error number and the message for easier fixes
            MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
        End Try

        'first check if the datatable is not empty
        If dataTable.Rows.Count > 0 Then
            'for each row in the datatable
            For Each row As DataRow In dataTable.Rows
                'create a ticket object
                Dim ticket As Ticket
                'use the constructor to pull the informatino from the datatable
                'and add it to the new ticket
                ticket = New Ticket(CStr(row.Item(1)), CStr(row.Item(2)), CStr(row.Item(3)), CDate(row.Item(4)), CInt(row.Item(5)), CBool(row.Item(6)), CInt(row.Item(0)))
                'add to the arraylist
                Tickets.Add(ticket)
                'populate the listbox
            Next
        End If
        For Each Ticket As Ticket In Tickets
            lstPendingTickets.Items.Add(Ticket.ToString)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'define a ticket
        Dim ticket As Ticket
        'use the constructor to build that ticket with the informaiton from the 
        'form text boxes
        ticket = New Ticket(txtIssue.Text, txtReporter.Text, txtEmail.Text, Now, CInt(numSeverity.Value), False)

        'build a query to insert the ticket data to the table, the first set of 
        'parens defines the colums and the second set of parens defines the parameters
        Dim sqlInsertTicket As String = "INSERT INTO tickets(issue, reporter, repEmail, dateReported, severity, resolved) values(@issue, @reporter, @repEmail, @dateReported, @severity, @resolved)"

        'define the query as a SQLcommand object
        Dim addTicketCommand As New SqlCommand(sqlInsertTicket, sqlbot.connection)
        'set the parameters to the ticket values
        addTicketCommand.Parameters.AddWithValue("@issue", ticket.Issue)
        addTicketCommand.Parameters.AddWithValue("@reporter", ticket.Reporter)
        addTicketCommand.Parameters.AddWithValue("@repEmail", ticket.repEmail)
        addTicketCommand.Parameters.AddWithValue("@dateReported", ticket.dateReported)
        addTicketCommand.Parameters.AddWithValue("@severity", ticket.severity)
        addTicketCommand.Parameters.AddWithValue("@resolved", ticket.resolved)

        Try
            'attempt to send the info to the table
            sqlbot.connection.Open()
            addTicketCommand.ExecuteNonQuery()
            sqlbot.connection.Close()
        Catch ex As SqlException
            'if there is an issue show a msgbox with a description of the issue
            MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
        End Try
        'update the listbox
        updatelists()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''defind our query from the techs table to get all entries
        'agentDataAdapter = New SqlDataAdapter("SELECT * FROM techs", Connection)
        ''fill the SQL data into the agentTable
        'agentDataAdapter.Fill(AgentTable)

        AgentTable = sqlbot.returnDataTable("SELECT * FROM techs")
        'for each row in the table
        For Each row As DataRow In AgentTable.Rows
            'create a tech
            Dim agent As Tech
            'construct this tech with the info from the table
            agent = New Tech(CStr(row.Item(1)), CStr(row.Item(2)), CStr(row.Item(3)), CInt(row.Item(4)), CInt(row.Item(0)))
            'add the new tech to teh arraylist
            agents.Add(agent)
        Next
        For Each Tech As Tech In agents
            'populate the dropdown with the techs
            cboTechs.Items.Add(Tech.tostring)
        Next
        'update the list box
        updatelists()
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        'check that a ticket is selected
        If lstPendingTickets.SelectedIndex <> -1 Then

            'check if a tech is selected
            If cboTechs.SelectedIndex > -1 Then

                'create a tech object
                Dim technician As Tech

                'prepare an integer
                Dim supportTicket As Ticket

                'save the ID of the ticket that appears at the same index as the user has
                'selected in the list box. Because the listbox and datatable are updated anytime
                'a change is made these indexes will be the same
                supportTicket = CType(Tickets(lstPendingTickets.SelectedIndex), Ticket)

                'set the tech to the tech that appears at the same index as the user selected
                'from the dropdown
                technician = CType(agents(cboTechs.SelectedIndex), Tech)

                'build an SQL statement to update the assignemnt of the ticket in the table
                Dim SQLStatement As String = "UPDATE Tickets SET assignment = @agent WHERE TicketID = @ID"

                'convert the SQL string to a SQL command
                Dim updateAssignementCMD As New SqlCommand(SQLStatement, sqlbot.connection)

                'set the parameters to be the selections made by the user
                updateAssignementCMD.Parameters.AddWithValue("@agent", technician.TechID)
                updateAssignementCMD.Parameters.AddWithValue("@ID", CInt(supportTicket.ID))

                Try
                    'attempt to write the change to the table
                    sqlbot.connection.Open()
                    updateAssignementCMD.ExecuteNonQuery()
                    sqlbot.connection.Close()
                    technician.emailTicket("New Ticket Assignment", String.Format("New ticket for you to work:{0}", supportTicket.ToString))
                Catch ex As SqlException
                    'provide error information if this fails
                    MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
                End Try
            End If
        End If
        'update the listbox and datatable
        updatelists()
    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        help.Tag = "desk"
        help.Show()
    End Sub
End Class
