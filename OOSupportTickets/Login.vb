Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Linq

Public Class Login

    Dim Connection As New SqlConnection("server=HERMAN-W8\sqlexpress;database=support;Trusted_Connection=Yes")
    Dim TechDataAdapter As New SqlDataAdapter
    Dim TableOfTechs As New DataTable
    Dim user As Tech


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPW.Text.Count > 0 And txtUser.Text.Count > 0 Then

            Dim username As String = txtUser.Text.ToLower
            Dim password As String = txtPW.Text
            Dim getusersql As String = "SELECT * FROM techs WHERE username = @username and password = @password"
            Dim getusercmd As SqlCommand

            getusercmd = New SqlCommand(getusersql, Connection)

            getusercmd.Parameters.AddWithValue("@username", username)
            getusercmd.Parameters.AddWithValue("@password", password)

            Try
                TechDataAdapter = New SqlDataAdapter(getusercmd)
                TechDataAdapter.Fill(TableOfTechs)
            Catch ex As SqlException
                MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
            End Try
            If TableOfTechs.Rows.Count > 0 Then
                Dim row As DataRow = TableOfTechs.Rows(0)
                user = New Tech(CStr(row.Item(1)), CStr(row.Item(2)), CStr(row.Item(3)), CInt(row.Item(4)), CInt(row.Item(0)))
                MsgBox(user.tostring())
            Else
                MsgBox("no user found")
            End If
        Else
            MsgBox("Please enter both a username and password")
        End If
        Select Case user.role
            Case Tech.Skillset.deskTech
                HelpDesk.Tag = CType(user, Tech)
                HelpDesk.Show()
            Case Tech.Skillset.manager
                SupControlPanel.Tag = CType(user, Tech)
                SupControlPanel.Show()
            Case Else
                TicketsToWork.Tag = CType(user, Tech)
                TicketsToWork.Show()
        End Select
    End Sub
End Class
