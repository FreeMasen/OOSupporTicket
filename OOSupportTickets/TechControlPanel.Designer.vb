﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketsToWork
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
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.lstTickets = New System.Windows.Forms.ListBox()
        Me.btnResolveTicket = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.txtReporter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIssue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResolution = New System.Windows.Forms.TextBox()
        Me.lblErros = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Location = New System.Drawing.Point(11, 15)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(212, 17)
        Me.lblTickets.TabIndex = 0
        Me.lblTickets.Text = "Tickets you have been assigned"
        '
        'lstTickets
        '
        Me.lstTickets.FormattingEnabled = True
        Me.lstTickets.ItemHeight = 16
        Me.lstTickets.Location = New System.Drawing.Point(11, 34)
        Me.lstTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTickets.Name = "lstTickets"
        Me.lstTickets.Size = New System.Drawing.Size(671, 196)
        Me.lstTickets.TabIndex = 1
        '
        'btnResolveTicket
        '
        Me.btnResolveTicket.Location = New System.Drawing.Point(532, 538)
        Me.btnResolveTicket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResolveTicket.Name = "btnResolveTicket"
        Me.btnResolveTicket.Size = New System.Drawing.Size(148, 50)
        Me.btnResolveTicket.TabIndex = 2
        Me.btnResolveTicket.Text = "Resolve Ticket"
        Me.btnResolveTicket.UseVisualStyleBackColor = True
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(11, 538)
        Me.btnEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(148, 50)
        Me.btnEmail.TabIndex = 3
        Me.btnEmail.Text = "Email Reporter"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'txtReporter
        '
        Me.txtReporter.Location = New System.Drawing.Point(97, 262)
        Me.txtReporter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReporter.Name = "txtReporter"
        Me.txtReporter.Size = New System.Drawing.Size(584, 22)
        Me.txtReporter.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ticket Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Reporter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Issue"
        '
        'txtIssue
        '
        Me.txtIssue.Location = New System.Drawing.Point(97, 304)
        Me.txtIssue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIssue.Multiline = True
        Me.txtIssue.Name = "txtIssue"
        Me.txtIssue.Size = New System.Drawing.Size(584, 74)
        Me.txtIssue.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Resolution"
        '
        'txtResolution
        '
        Me.txtResolution.Location = New System.Drawing.Point(97, 391)
        Me.txtResolution.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtResolution.Multiline = True
        Me.txtResolution.Name = "txtResolution"
        Me.txtResolution.Size = New System.Drawing.Size(584, 74)
        Me.txtResolution.TabIndex = 10
        '
        'lblErros
        '
        Me.lblErros.AutoSize = True
        Me.lblErros.Location = New System.Drawing.Point(11, 500)
        Me.lblErros.Name = "lblErros"
        Me.lblErros.Size = New System.Drawing.Size(0, 17)
        Me.lblErros.TabIndex = 11
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.ForeColor = System.Drawing.Color.Blue
        Me.lblHelp.Location = New System.Drawing.Point(317, 572)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(50, 17)
        Me.lblHelp.TabIndex = 12
        Me.lblHelp.Text = "HELP!!"
        '
        'TicketsToWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 598)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblErros)
        Me.Controls.Add(Me.txtResolution)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIssue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReporter)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnResolveTicket)
        Me.Controls.Add(Me.lstTickets)
        Me.Controls.Add(Me.lblTickets)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TicketsToWork"
        Me.Text = "Tech Control Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTickets As System.Windows.Forms.Label
    Friend WithEvents lstTickets As System.Windows.Forms.ListBox
    Friend WithEvents btnResolveTicket As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents txtReporter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIssue As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtResolution As System.Windows.Forms.TextBox
    Friend WithEvents lblErros As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label

End Class
