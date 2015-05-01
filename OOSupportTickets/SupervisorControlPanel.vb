Imports System.Data.SqlClient
Public Class SupControlPanel
    'our SQL Server connection string
    Dim Connection As New SqlConnection("server=HERMAN-W8\sqlexpress;database=support;Trusted_Connection=Yes")

    'data adapter and table for the techs
    Dim techDataAdapter As New SqlDataAdapter
    Dim techTable As New DataTable

    'data adapter and table for the tickets
    Dim ticketAdapter As New SqlDataAdapter
    Dim ticketTable As New DataTable

    'data adapter and table for the techs
    Dim techs As New ArrayList
    Dim tickets As New ArrayList

    'holding the currently selected tech
    Dim selectedTech As Tech

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        'when the user clicks anywhere on the form that is not a lstbox selection
        'this will set the listbox selection to nothing. This will help reduce the number
        'accidental duplicate additions to the tech's table since it will trigger the 
        'listbox lost focus event
        lstTechs.SelectedIndex = -1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setupRolesComboBox()
        updateLists()
    End Sub


    'populate the combo box with the jobs in the order they appear in the enum defined it techs
    'this will ensure that the index of thsi combo box is the same as the index of the enum
    Private Sub setupRolesComboBox()
        Dim roles As String() = {"PC Support", "Mac Support", "Server Support", "Network Support", "Help Desk", "Manager"}
        cboTechRole.Items.AddRange(roles)
        'The default style allows user to enter new values into the list. This style only lets user pick from given choices.
        cboTechRole.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub updateLists()
        'first clear all of the data
        techs.Clear()
        lstTechs.SelectedIndex = -1
        lstTechs.Items.Clear()
        techTable.Clear()
        Try
            'pull the tech data from the database and store them in a table 
            techDataAdapter = New SqlDataAdapter("SELECT * FROM techs ORDER BY role DESC", Connection)
            techDataAdapter.Fill(techTable)
        Catch ex As SqlException
            'display the error if this fails
            MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
        End Try

        'check if the table is empty
        If techTable.Rows.Count > 0 Then
            For Each row As DataRow In techTable.Rows
                'add the agent to the AL of Techs
                Dim agent As Tech
                agent = New Tech(CStr(row.Item(1)), CStr(row.Item(2)), CStr(row.Item(3)), CInt(row.Item(4)), CInt(row.Item(0)))
                techs.Add(agent)
            Next
        End If

        'update the listbox
        If techs.Count > 0 Then
            For Each Tech As Tech In techs
                lstTechs.Items.Add(Tech.tostring)
            Next
        End If
    End Sub

    'this sub is to package information that will be passed to assignments window
    'the last two dates are optional, this is because the start and end date are only
    'needed for the completed version not the pending version
    Private Sub viewAssignemnts(source As String, tech As Integer, agent As String, Optional startDate As Date = Nothing, Optional endDate As Date = Nothing)
        If lstTechs.SelectedIndex > -1 Then
            'creates an arraylist to hold the data
            Dim passedInfo As ArrayList = New ArrayList
            'add each of the elements to the arraylist
            passedInfo.Add(source)
            passedInfo.Add(tech.ToString)
            passedInfo.Add(agent.ToString)
            passedInfo.Add(startDate.ToShortDateString)
            passedInfo.Add(endDate.ToShortDateString)
            'store that information in the Tag of the Assigments form
            Assignments.Tag = CType(passedInfo, ArrayList)
            Assignments.Show()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'call the viewAssignments sub with the pending parameters
        viewAssignemnts("Pending", selectedTech.TechID, selectedTech.tostring)
    End Sub

    Private Sub lstTechs_LostFocus(sender As Object, e As EventArgs) Handles lstTechs.LostFocus
        captureselectedtech()
    End Sub

    'if the selection of the list box has changed, update the selected tech
    Private Sub lstTechs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTechs.SelectedIndexChanged
        captureselectedtech()
    End Sub

    'this method reads the selection form the listbox, even if it is nothing
    'and sets the textboxes to reflect the current selection.
    Private Sub captureselectedtech()
        If lstTechs.SelectedIndex > -1 Then
            selectedTech = CType(techs(lstTechs.SelectedIndex), Tech)
            txtFName.Text = selectedTech.firstname
            txtLName.Text = selectedTech.lastname
            txtTechEmail.Text = selectedTech.email
            cboTechRole.SelectedIndex = CInt(selectedTech.role)
        Else
            txtFName.text = ""
            txtLName.text = ""
            txtTechEmail.Text = ""
            cboTechRole.SelectedIndex = -1
        End If

    End Sub


    Private Sub btnViewCompleted_Click(sender As Object, e As EventArgs) Handles btnViewCompleted.Click
        'check that a tech is selected
        If lstTechs.SelectedIndex > -1 Then
            'show the startenddate form.
            startenddate.ShowDialog()
            'the properties provided by the form's tag will be an arraylist of two dates
            'these will be set to the start and end date variables
            Dim startDate As Date = CDate(CType(startenddate.Tag, ArrayList).Item(0))
            Dim endDate As Date = CDate(CType(startenddate.Tag, ArrayList).Item(1))

            'the tech info and start/end date variables are passed to the view assigments method
            'this will bring up the assignments window and show the completed work
            viewAssignemnts("Completed", selectedTech.TechID, selectedTech.tostring, startDate, endDate)
        End If
    End Sub

    Private Sub btnEditTech_Click(sender As Object, e As EventArgs) Handles btnEditTech.Click
        'if a selection is made
        If lstTechs.SelectedIndex > -1 Then
            'if the form is filled out properlly
            If txtFName.Text.Length > 0 And txtLName.Text.Length > 0 And txtTechEmail.Text.Length > 0 And txtTechEmail.Text.Contains("@") And cboTechRole.SelectedIndex > 0 Then
                'update the selected tech object with the new info
                selectedTech.firstname = txtFName.Text
                selectedTech.lastname = txtLName.Text
                selectedTech.email = txtTechEmail.Text
                selectedTech.role = CType(cboTechRole.SelectedIndex, Tech.Skillset)

                'build an update query with the information in the selectetech object
                Dim editString As String = "UPDATE techs SET FirstName = @fname, LastName = @lname, email = @email, role = @role WHERE TechID = @techID"
                Dim editCommand As New SqlCommand(editString, Connection)
                editCommand.Parameters.AddWithValue("@techID", selectedTech.TechID)
                editCommand.Parameters.AddWithValue("@fname", selectedTech.firstname)
                editCommand.Parameters.AddWithValue("@lname", selectedTech.lastname)
                editCommand.Parameters.AddWithValue("@email", selectedTech.email)
                editCommand.Parameters.AddWithValue("@role", CInt(selectedTech.role))

                Try
                    'send our query to the database
                    Connection.Open()
                    editCommand.ExecuteNonQuery()
                    Connection.Close()
                    'update the lists
                    updateLists()
                Catch ex As SqlException
                    MsgBox(String.Format("Error {0} {1}", ex.Number.ToString, ex.Message))
                End Try
            Else
                MsgBox("Please ensure all data is entered and formatted correctly")
            End If
        End If
    End Sub

    Private Sub btnEmailTech_Click(sender As Object, e As EventArgs) Handles btnEmailTech.Click
        'this will allow the user to email to selected tech regarding their pending/completed tickets
        If lstTechs.SelectedIndex > -1 Then
            selectedTech.emailTicket("Question about an assigned ticket")
        End If
    End Sub

    Private Sub btnAddTech_Click(sender As Object, e As EventArgs) Handles btnAddTech.Click
        'first check that a selection is not made
        If lstTechs.SelectedIndex = -1 Then
            'next check if the form is filled out properlly
            If txtFName.Text.Length > 0 And txtLName.Text.Length > 0 And txtTechEmail.Text.Length > 0 And txtTechEmail.Text.Contains("@") And cboTechRole.SelectedIndex > 0 Then
                'hold a new tech with the form info
                Dim newTech As Tech
                newTech = New Tech(txtFName.Text, txtLName.Text, txtTechEmail.Text, cboTechRole.SelectedIndex)

                'build a new query to insert this into the table
                Dim newTechQuery As String = "INSERT INTO techs (FirstName, LastName, email, role) VALUES (@fname, @lname, @email, @role)"
                Dim newTechCmd As New SqlCommand(newTechQuery, Connection)

                newTechCmd.Parameters.AddWithValue("@fname", newTech.firstname)
                newTechCmd.Parameters.AddWithValue("@lname", newTech.lastname)
                newTechCmd.Parameters.AddWithValue("@email", newTech.email)
                newTechCmd.Parameters.AddWithValue("@role", CInt(newTech.role))

                Try
                    'send that info to the database and update the lists
                    Connection.Open()
                    newTechCmd.ExecuteNonQuery()
                    Connection.Close()
                    updateLists()
                Catch ex As SqlException
                    MsgBox(String.Format("Error: {0} {1}", ex.Number.ToString, ex.Message))
                End Try


            End If
        Else
            'To avoid accidentlly submitting an already existing set of data to the database as a new row
            'I have made it a requirement that the new tech information must be added to the form manually
            MsgBox("You must de-select your current item to add a new tech to this list")
        End If

    End Sub

    Private Sub btnHelpDesk_Click(sender As Object, e As EventArgs) Handles btnHelpDesk.Click
        HelpDesk.Tag = CType(Me.Tag, Tech)
        HelpDesk.Show()
    End Sub

    Private Sub btnTechAccess_Click(sender As Object, e As EventArgs) Handles btnTechAccess.Click
        TicketsToWork.Tag = CType(Me.Tag, Tech)
        TicketsToWork.Show()
    End Sub
End Class