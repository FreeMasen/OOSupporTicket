Imports System.Data.SqlClient

Public Class Form1
    Dim Connection As New SqlConnection("server=HERMAN-W8\sqlexpress;database=support;Trusted_Connection=Yes")
    Dim dataAdapter As New SqlDataAdapter
    Dim dataTable As New DataTable

    Dim agentDataAdapter As New SqlDataAdapter
    Dim AgentTable As New DataTable

    Dim agents As ArrayList = New ArrayList

    Public Sub updatelists()
        lstPendingTickets.Items.Clear()
        dataTable.Clear()
        Try
            dataAdapter = New SqlDataAdapter("SELECT * FROM Tickets WHERE resolved = 0 ORDER BY Severity DESC", Connection)
            dataAdapter.Fill(dataTable)
        Catch ex As SqlException
            MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
        End Try
        If dataTable.Rows.Count > 0 Then
            For Each row As DataRow In dataTable.Rows
                If CBool(row.Item(5)) = False Then
                    Dim ticket As Ticket
                    ticket = New Ticket(CStr(row.Item(1)), CStr(row.Item(2)), CDate(row.Item(3)), CInt(row.Item(4)), CBool(row.Item(5)))
                    If IsDBNull(row.Item(6)) = False Then
                        For Each Tech As Tech In agents
                            If CInt(row.Item(6)) = Tech.TechID Then
                                ticket.assignment = Tech.tostring
                            End If
                        Next
                    End If
                    lstPendingTickets.Items.Add(ticket.ToString)
                End If
            Next
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ticket As Ticket
        ticket = New Ticket(txtIssue.Text, txtReporter.Text, txtEmail.Text, Now, CInt(numSeverity.Value), False)
        Dim sqlInsertTicket As String = "insert into tickets(issue, reporter, repEmail, dateReported, severity, resolved) values(@issue, @reporter, @repEmail, @dateReported, @severity, @resolved)"
        Dim addTicketCommand As New SqlCommand(sqlInsertTicket, Connection)
        addTicketCommand.Parameters.AddWithValue("@issue", ticket.Issue)
        addTicketCommand.Parameters.AddWithValue("@reporter", ticket.Reporter)
        addTicketCommand.Parameters.AddWithValue("@repEmail", ticket.repEmail)
        addTicketCommand.Parameters.AddWithValue("@dateReported", ticket.dateReported)
        addTicketCommand.Parameters.AddWithValue("@severity", ticket.severity)
        addTicketCommand.Parameters.AddWithValue("@resolved", ticket.resolved)

        Try
            Connection.Open()
            addTicketCommand.ExecuteNonQuery()
            Connection.Close()
        Catch ex As SqlException
            MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
        End Try
        updatelists()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agentDataAdapter = New SqlDataAdapter("SELECT * FROM techs", Connection)
        agentDataAdapter.Fill(AgentTable)
        For Each row As DataRow In AgentTable.Rows
            Dim tech As New Tech
            tech.TechID = CInt(row.Item(0))
            tech.firstname = CStr(row.Item(1))
            tech.lastname = CStr(row.Item(2))
            tech.email = CStr(row.Item(3))
            agents.Add(tech)
        Next
        For Each Tech As Tech In agents
            cboTechs.Items.Add(Tech.tostring)
        Next
        updatelists()
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        If lstPendingTickets.SelectedIndex <> -1 Then
            If cboTechs.SelectedIndex > -1 Then
                Dim technician As New Tech
                Dim supportTicket As Integer
                supportTicket = CInt(dataTable.Rows(lstPendingTickets.SelectedIndex).Item(0))
                technician = CType(agents(cboTechs.SelectedIndex), Tech)
                Dim SQLStatement As String = "UPDATE Tickets SET assignment = @agent WHERE TicketID = @ID"
                Dim updateAssignementCMD As New SqlCommand(SQLStatement, Connection)
                updateAssignementCMD.Parameters.AddWithValue("@agent", technician.TechID)
                updateAssignementCMD.Parameters.AddWithValue("@ID", supportTicket)
                Try
                    Connection.Open()
                    updateAssignementCMD.ExecuteNonQuery()
                    Connection.Close()

                Catch ex As SqlException
                    MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
                End Try
            End If
        End If
        updatelists()
    End Sub
End Class
