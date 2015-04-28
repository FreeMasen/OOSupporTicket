Public Class Tech
    Public Property TechID As Integer
    Public Property firstname As String
    Public Property lastname As String
    Public Property email As String

    Public Sub New(name As String, email As String, id As Integer)

    End Sub


    Public Overloads Function tostring() As String
        Return String.Format("{0} {1}, {2}", firstname, lastname, email)
    End Function
End Class
