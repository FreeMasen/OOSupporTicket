Public Class Ticket
    'properties that correspond with the colums in 
    'the support.tickts table
    Public Property ID As Integer
    Public Property Issue As String
    Public Property Reporter As String
    Public Property repEmail As String
    Public Property dateReported As Date
    Public Property severity As Integer
    Public Property resolved As Boolean
    Public Property assignment As String
    Public Property dateResolved As Date
    Public Property resolution As String

    'constructor that corresponds all non-nullable cells from the database
    'to create a new ticket.
    Public Sub New(issue As String, reporter As String, repEmail As String, reported As Date, _
                            severity As Integer, resolved As Boolean)
        Me.Issue = issue
        Me.Reporter = reporter
        Me.repEmail = repEmail
        Me.dateReported = reported
        Me.severity = severity
        Me.resolved = resolved
    End Sub

    'tostring override that checks for an assignment or not
    Public Overrides Function ToString() As String
        If Me.assignment <> "" Then
            Return String.Format("Reporter: {0}  | Issue: {1} | Severity: {2} | Date Reported: {3} | Assigned To: {4}", _
                                 Me.Reporter, Me.Issue, Me.severity.ToString, CType(Me.dateReported, Date).ToShortDateString, Me.assignment)
        Else
            Return String.Format("Reporter: {0}  | Issue: {1} | Severity: {2} | Date Reported: {3}", _
                                 Me.Reporter, Me.Issue, Me.severity.ToString, Me.dateReported)
        End If
    End Function

    Public Function toStringShort() As String
        Return String.Format("Ticket ID: {0} | Severity : {1} | Date Reported: {2}", Me.ID, Me.severity, Me.dateReported)
    End Function

    Public Sub emailReporter(subject As String, Optional body As String = "")
        subject = subject.Replace(" ", "%20")
        body = body.Replace(" ", "%20")
        If Me.resolved = True Then
            Process.Start(String.Format("mailto:{0}?subject={1}&body={2}", Me.repEmail, subject, body))
        ElseIf Me.resolved = False Then
            Process.Start(String.Format("mailto:{0}?subject={1}", Me.repEmail, subject))
        End If
    End Sub

End Class
