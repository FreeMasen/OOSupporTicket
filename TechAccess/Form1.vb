Imports System.Data.SqlClient

Public Class Form1
    'defines to source for all of the tables we will be referencing
    Dim Connection As New SqlConnection("server=HERMAN-W8\sqlexpress;database=support;Trusted_Connection=Yes")

    'this block also sets up a data adapter and data table to be used
    'by other parts of the program that need to reference/modify the tickets table
    Dim dataAdapter As New SqlDataAdapter
    Dim dataTable As New DataTable
    Dim techtalbe As New DataTable

    Dim techadapter As New SqlDataAdapter

    Dim currentTech As Tech
    Dim tickets As New ArrayList


    Private Sub btnResolveTicket_Click(sender As Object, e As EventArgs) Handles btnResolveTicket.Click
        If lstTickets.SelectedIndex <> -1 Then

        End If
    End Sub

    Private Sub updateLists()
        If tickets.Count > 0 Then
            For Each newTicket In tickets
                lstTickets.Items.Add(newTicket.ToString)
            Next
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        techadapter = New SqlDataAdapter(String.Format("SELECT * FROM techs WHERE TechID = {0}", 1), Connection)
        techadapter.Fill(techtalbe)
        If techtalbe.Rows.Count > 0 Then
            currentTech = New Tech(CStr(techtalbe.Rows(0).Item(1)), CStr(techtalbe.Rows(0).Item(2)), CStr(techtalbe.Rows(0).Item(3)), techtalbe.Rows(0).Item(4))
            currentTech.TechID = CInt((techtalbe.Rows(0).Item(0)))
        End If
        If IsNothing(currentTech) = False Then
            dataAdapter = New SqlDataAdapter(String.Format("SELECT * FROM Tickets WHERE assignment = {0}", CInt(currentTech.TechID)), Connection)
            dataAdapter.Fill(dataTable)
        End If
        For Each row As DataRow In dataTable.Rows
            Dim newTicket As Ticket
            newTicket = New Ticket(CStr(row.Item(1)), CStr(row.Item(2)), CStr(row.Item(3)), CDate(row.Item(4)), CInt(row.Item(5)), CBool(row.Item(6)))
            tickets.Add(newTicket)
        Next
        updateLists()
    End Sub
End Class
