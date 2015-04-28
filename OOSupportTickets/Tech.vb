
Public Class Tech
    'These properties define what elements a tech object can have
    'each of these corresponds with a column in the support.tech database
    Public Property TechID As Integer
    Public Property firstname As String
    Public Property lastname As String
    Public Property email As String
    'this is an enumeration to ensure that roles will not be entered incorrectly
    'it corresponds with an int value in the datatable. 
    Public Property role As Skillset

    'class constructor  taking in the required info to create a tech 
    Public Sub New(FirstName As String, lastName As String, email As String, role As Integer)
        Me.firstname = FirstName
        Me.lastname = lastName
        Me.email = email
        Me.role = CType(role, Skillset)
    End Sub

    'this fucntion allows for the emailing of a tech, this will be used to
    'provide new tickets for a tech when it is assigned
    Public Sub emailTicket(subject As String, body As String)
        subject = subject.Replace(" ", "%20")
        body = body.Replace(" ", "%20")
        Process.Start(String.Format("mailto:{0}?subject={1}&body={2}", Me.email, subject, body))
        'Process.Start("mailto:r.f.masen@gmail.com?subject:help&body:helping")
    End Sub

    'defines the possible skillsets that can be applied to a role
    Public Enum Skillset
        pcSupport
        macSupport
        serverSupport
        networkSupport
        deskTech
        manager
    End Enum

    'defines how a tech will be printed during a tostring conversion
    Public Overloads Function tostring() As String
        'this will hold our Skillset formatted properly
        Dim skill As String
        If Me.role = 0 Then
            skill = "PC Support"
        ElseIf Me.role = 1 Then
            skill = "Mac Support"
        ElseIf Me.role = 2 Then
            skill = "Server Support"
        ElseIf Me.role = 3 Then
            skill = "Network Support"
        ElseIf Me.role = 4 Then
            skill = "Help Desk"
        ElseIf Me.role = 5 Then
            skill = "Manager"
        Else
            skill = "No skill assigned"
        End If
        Return String.Format("{0} {1}, {2}", firstname, lastname, skill)
    End Function
End Class
