Imports System.Text
Public Class help

    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim source As String = CStr(Me.Tag)
        Dim sb As New StringBuilder
        If source = "sup" Then
            sb.Append("To add a new tech to your team").AppendLine()
            sb.Append("First be sure to deselct the current list of techs").AppendLine()
            sb.Append("next fill out all element of the form on the left hand side of the screen").AppendLine()
            sb.Append("finally click the 'Add New Tech' button").AppendLine()
            sb.Append("you should now see you newly added tech").AppendLine().AppendLine()
            sb.Append("To edit a current, select the tech from the list on the right side of the screen").AppendLine()
            sb.Append("you should see the tech info show up in the form to the left, simply make your changes here and click 'Edit Selected Tech'").AppendLine()
            sb.Append("Once you have a tech selected, you have the ability to 'View Assignments' to see pending assignments").AppendLine()
            sb.Append("'View Completed Work' to see what work the tech has completed over a range of time").AppendLine()
            sb.Append("'Delete Selected Tech' to remove them from your staff").AppendLine()
            sb.Append("and 'Email' tech to draft an email to them regarding their assignments").AppendLine()
            sb.Append("You can email the tech's full pending or completed work after clicking on either of the view buttons").AppendLine().AppendLine()
            sb.Append("in the lower right hand corner of the screen you will have to ability to bring up the Help Desk Window to assign tickets to tech").AppendLine()
            sb.Append("and the Tech Control Panel to work any tickets assigned to you")
        ElseIf source = "tech" Then
            sb.Append("To work tickets that have been assigned to you.").AppendLine()
            sb.Append("first select the ticket from the list of tickets assigned to you").AppendLine()
            sb.Append("you can either click on the 'email report' button to draft an email to the individual to get additional info").AppendLine()
            sb.Append("or you can click the resolve ticket to save your ticket as completed").AppendLine()
            sb.Append("please note that your resolution must be at least 255 characters since we are looking for a detailed description of your resolution")
        ElseIf source = "desk" Then
            sb.Append("To add a new ticket to be worked by a tech, use the form in the top left corner").AppendLine()
            sb.Append("you must fill all available fields before clicking the 'Add Ticket' button (note that severity might neede to be modified)").AppendLine()
            sb.Append("Once you click that button you should see this information in the list below.").AppendLine().AppendLine()
            sb.Append("To assign a ticket to an agent, select the ticket from the list").AppendLine()
            sb.Append("next select a Tech from the dropdown in the lower right").AppendLine()
            sb.Append("lastly click the 'Assign Ticket' button to assign that ticket to a tech").AppendLine()
            sb.Append("This will open an email to that tech letting them know there is new work for him/her").AppendLine()
            sb.Append("don't forget to click send before moving on.").AppendLine()
            sb.Append("you should see the ticket no longer appears in the list")
        End If
        lblHelp.Text = sb.ToString
    End Sub
End Class