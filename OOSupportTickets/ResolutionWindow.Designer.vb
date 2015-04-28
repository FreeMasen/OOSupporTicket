<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResolutionWindow
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
        Me.txtResolution = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ticket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "What resolved this issue?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date of Resolution"
        '
        'txtResolution
        '
        Me.txtResolution.Location = New System.Drawing.Point(56, 135)
        Me.txtResolution.Multiline = True
        Me.txtResolution.Name = "txtResolution"
        Me.txtResolution.Size = New System.Drawing.Size(313, 182)
        Me.txtResolution.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 361)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(313, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(213, 393)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 41)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(294, 393)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 41)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(52, 444)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(0, 20)
        Me.lblWarning.TabIndex = 9
        '
        'ResolutionWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 473)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtResolution)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ResolutionWindow"
        Me.Text = "ResolutionWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtResolution As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label
End Class
