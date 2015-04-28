Imports System.Data.SqlClient
Imports System.Data
Public Class SQLBot
    Dim connectionString As String = "server=HERMANW7\SQLEXPRESS;database=movies;user id=sa;password=password"
    Dim bindingSource As New BindingSource
    Dim objdataAdapter As SqlDataAdapter

    Dim objDataTable As DataTable

    Public Sub getData(sqlQuery As String)
        objdataAdapter = New SqlDataAdapter(sqlQuery, connectionString)
        Dim objCommandBuilder As New SqlCommandBuilder(objdataAdapter)

        objDataTable = New DataTable()

        objdataAdapter.Fill(objDataTable)
        bindingSource.DataSource = objDataTable

    End Sub

    Public Sub enterPendingTicket(entry As Ticket)

    End Sub
End Class
