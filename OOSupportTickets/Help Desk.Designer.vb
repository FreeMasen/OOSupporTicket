<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpDesk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReporter = New System.Windows.Forms.TextBox()
        Me.txtIssue = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstPendingTickets = New System.Windows.Forms.ListBox()
        Me.numSeverity = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.cboTechs = New System.Windows.Forms.ComboBox()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        CType(Me.numSeverity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Severity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Issue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Reporter"
        '
        'txtReporter
        '
        Me.txtReporter.Location = New System.Drawing.Point(101, 7)
        Me.txtReporter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReporter.Name = "txtReporter"
        Me.txtReporter.Size = New System.Drawing.Size(303, 22)
        Me.txtReporter.TabIndex = 3
        '
        'txtIssue
        '
        Me.txtIssue.Location = New System.Drawing.Point(426, 31)
        Me.txtIssue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIssue.Multiline = True
        Me.txtIssue.Name = "txtIssue"
        Me.txtIssue.Size = New System.Drawing.Size(578, 114)
        Me.txtIssue.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(287, 112)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 35)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Ticket"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstPendingTickets
        '
        Me.lstPendingTickets.FormattingEnabled = True
        Me.lstPendingTickets.ItemHeight = 16
        Me.lstPendingTickets.Location = New System.Drawing.Point(11, 183)
        Me.lstPendingTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstPendingTickets.Name = "lstPendingTickets"
        Me.lstPendingTickets.Size = New System.Drawing.Size(993, 276)
        Me.lstPendingTickets.TabIndex = 7
        '
        'numSeverity
        '
        Me.numSeverity.Location = New System.Drawing.Point(101, 112)
        Me.numSeverity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numSeverity.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numSeverity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSeverity.Name = "numSeverity"
        Me.numSeverity.Size = New System.Drawing.Size(107, 22)
        Me.numSeverity.TabIndex = 8
        Me.numSeverity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pending Tickets"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(422, 131)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(0, 17)
        Me.lblWarning.TabIndex = 10
        '
        'cboTechs
        '
        Me.cboTechs.FormattingEnabled = True
        Me.cboTechs.Location = New System.Drawing.Point(120, 467)
        Me.cboTechs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTechs.Name = "cboTechs"
        Me.cboTechs.Size = New System.Drawing.Size(378, 24)
        Me.cboTechs.TabIndex = 11
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(503, 463)
        Me.btnAssign.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(116, 35)
        Me.btnAssign.TabIndex = 12
        Me.btnAssign.Text = "Assign Ticket"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Assign ticket to:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(101, 45)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(303, 22)
        Me.txtEmail.TabIndex = 15
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.ForeColor = System.Drawing.Color.Blue
        Me.lblHelp.Location = New System.Drawing.Point(951, 481)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(47, 17)
        Me.lblHelp.TabIndex = 16
        Me.lblHelp.Text = "HELP!"
        '
        'HelpDesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 511)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.cboTechs)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numSeverity)
        Me.Controls.Add(Me.lstPendingTickets)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtIssue)
        Me.Controls.Add(Me.txtReporter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "HelpDesk"
        Me.Text = "Help Desk"
        CType(Me.numSeverity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReporter As System.Windows.Forms.TextBox
    Friend WithEvents txtIssue As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstPendingTickets As System.Windows.Forms.ListBox
    Friend WithEvents numSeverity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents cboTechs As System.Windows.Forms.ComboBox
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblHelp As System.Windows.Forms.Label

End Class
