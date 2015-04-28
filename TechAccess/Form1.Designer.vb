<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstTickets = New System.Windows.Forms.ListBox()
        Me.btnResolveTicket = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tickets you have been assigned"
        '
        'lstTickets
        '
        Me.lstTickets.FormattingEnabled = True
        Me.lstTickets.ItemHeight = 20
        Me.lstTickets.Location = New System.Drawing.Point(12, 42)
        Me.lstTickets.Name = "lstTickets"
        Me.lstTickets.Size = New System.Drawing.Size(212, 244)
        Me.lstTickets.TabIndex = 1
        '
        'btnResolveTicket
        '
        Me.btnResolveTicket.Location = New System.Drawing.Point(599, 672)
        Me.btnResolveTicket.Name = "btnResolveTicket"
        Me.btnResolveTicket.Size = New System.Drawing.Size(167, 63)
        Me.btnResolveTicket.TabIndex = 2
        Me.btnResolveTicket.Text = "Resolve Ticket"
        Me.btnResolveTicket.UseVisualStyleBackColor = True
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(12, 672)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(167, 63)
        Me.btnEmail.TabIndex = 3
        Me.btnEmail.Text = "Email Reporter"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 310)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 747)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnResolveTicket)
        Me.Controls.Add(Me.lstTickets)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstTickets As System.Windows.Forms.ListBox
    Friend WithEvents btnResolveTicket As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
