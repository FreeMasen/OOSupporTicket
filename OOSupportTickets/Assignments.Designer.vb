<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assignments
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
        Me.txtAssignments = New System.Windows.Forms.TextBox()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAssignments
        '
        Me.txtAssignments.Location = New System.Drawing.Point(0, 0)
        Me.txtAssignments.Multiline = True
        Me.txtAssignments.Name = "txtAssignments"
        Me.txtAssignments.ReadOnly = True
        Me.txtAssignments.Size = New System.Drawing.Size(1132, 687)
        Me.txtAssignments.TabIndex = 0
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(964, 693)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(168, 66)
        Me.btnEmail.TabIndex = 1
        Me.btnEmail.Text = "Email tech work list"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'Assignments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 796)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.txtAssignments)
        Me.Name = "Assignments"
        Me.Text = "Assignments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAssignments As System.Windows.Forms.TextBox
    Friend WithEvents btnEmail As System.Windows.Forms.Button
End Class
