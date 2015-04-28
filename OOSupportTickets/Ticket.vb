Public Class Ticket

    Public Property Issue As String
    Public Property Reporter As String
    Public Property repEmail As String
    Public Property dateReported As Date
    Public Property severity As Integer
    Public Property assignment As String
    Public Property dateResolved As Date
    Public Property resolution As String
    Public Property ID As Integer
    Public Property resolved As Boolean

    Public Sub New(issue As String, reporter As String, repEmail As String, reported As Date, _
                            severity As Integer, resolved As Boolean)
        Me.Issue = issue
        Me.Reporter = reporter
        Me.repEmail = repEmail
        Me.dateReported = reported
        Me.severity = severity
        Me.resolved = resolved
    End Sub

    Public Overrides Function ToString() As String
        If Me.assignment <> "" Then
            Return String.Format("Reporter: {0}  | Issue: {1} | Severity: {2} | Date Reported: {3} | Assigned To: {4}", _
                                 Me.Reporter, Me.Issue, Me.severity.ToString, CType(Me.dateReported, Date).ToShortDateString, Me.assignment)
        Else
            Return String.Format("Reporter: {0}  | Issue: {1} | Severity: {2} | Date Reported: {3} | Assigned To: ", _
                                 Me.Reporter, Me.Issue, Me.severity.ToString, Me.dateReported)
        End If
    End Function

End Class

Public Structure Tech

End Structure