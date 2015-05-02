Imports System.Data.SqlClient
Imports System.Data
Public Class SQLBot
    Public Property connection As New SqlConnection("server=HERMAN-W8\sqlexpress;database=support;Trusted_Connection=Yes")

    Public Function returnDataTable(sqlQuery As String) As DataTable
        Dim dataAdapter As SqlDataAdapter
        Dim datatable As New DataTable
        dataAdapter = New SqlDataAdapter(sqlQuery, connection)
        dataAdapter.Fill(datatable)

        Return datatable

    End Function
End Class
