<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupControlPanel
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
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtTechEmail = New System.Windows.Forms.TextBox()
        Me.cboTechRole = New System.Windows.Forms.ComboBox()
        Me.btnAddTech = New System.Windows.Forms.Button()
        Me.btnEditTech = New System.Windows.Forms.Button()
        Me.btnEmailTech = New System.Windows.Forms.Button()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnViewCompleted = New System.Windows.Forms.Button()
        Me.lstTechs = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnTechAccess = New System.Windows.Forms.Button()
        Me.btnHelpDesk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(5, 42)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(86, 20)
        Me.lblFName.TabIndex = 0
        Me.lblFName.Text = "First Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(5, 192)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Role"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(119, 42)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(270, 26)
        Me.txtFName.TabIndex = 3
        '
        'txtTechEmail
        '
        Me.txtTechEmail.Location = New System.Drawing.Point(119, 192)
        Me.txtTechEmail.Name = "txtTechEmail"
        Me.txtTechEmail.Size = New System.Drawing.Size(270, 26)
        Me.txtTechEmail.TabIndex = 4
        '
        'cboTechRole
        '
        Me.cboTechRole.FormattingEnabled = True
        Me.cboTechRole.Location = New System.Drawing.Point(119, 256)
        Me.cboTechRole.Name = "cboTechRole"
        Me.cboTechRole.Size = New System.Drawing.Size(270, 28)
        Me.cboTechRole.TabIndex = 5
        '
        'btnAddTech
        '
        Me.btnAddTech.Location = New System.Drawing.Point(17, 307)
        Me.btnAddTech.Name = "btnAddTech"
        Me.btnAddTech.Size = New System.Drawing.Size(149, 68)
        Me.btnAddTech.TabIndex = 6
        Me.btnAddTech.Text = "add new tech"
        Me.btnAddTech.UseVisualStyleBackColor = True
        '
        'btnEditTech
        '
        Me.btnEditTech.Location = New System.Drawing.Point(240, 305)
        Me.btnEditTech.Name = "btnEditTech"
        Me.btnEditTech.Size = New System.Drawing.Size(149, 68)
        Me.btnEditTech.TabIndex = 7
        Me.btnEditTech.Text = "edit selected tech"
        Me.btnEditTech.UseVisualStyleBackColor = True
        '
        'btnEmailTech
        '
        Me.btnEmailTech.Location = New System.Drawing.Point(873, 471)
        Me.btnEmailTech.Name = "btnEmailTech"
        Me.btnEmailTech.Size = New System.Drawing.Size(149, 68)
        Me.btnEmailTech.TabIndex = 9
        Me.btnEmailTech.Text = "email"
        Me.btnEmailTech.UseVisualStyleBackColor = True
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(119, 103)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(270, 26)
        Me.txtLName.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Last Name"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(408, 471)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(149, 68)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "View Assignments"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnViewCompleted
        '
        Me.btnViewCompleted.Location = New System.Drawing.Point(563, 471)
        Me.btnViewCompleted.Name = "btnViewCompleted"
        Me.btnViewCompleted.Size = New System.Drawing.Size(149, 68)
        Me.btnViewCompleted.TabIndex = 13
        Me.btnViewCompleted.Text = "View completed work"
        Me.btnViewCompleted.UseVisualStyleBackColor = True
        '
        'lstTechs
        '
        Me.lstTechs.FormattingEnabled = True
        Me.lstTechs.ItemHeight = 20
        Me.lstTechs.Location = New System.Drawing.Point(408, 41)
        Me.lstTechs.Name = "lstTechs"
        Me.lstTechs.Size = New System.Drawing.Size(614, 424)
        Me.lstTechs.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(718, 471)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(149, 68)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete selected tech"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnTechAccess
        '
        Me.btnTechAccess.Location = New System.Drawing.Point(164, 490)
        Me.btnTechAccess.Name = "btnTechAccess"
        Me.btnTechAccess.Size = New System.Drawing.Size(149, 68)
        Me.btnTechAccess.TabIndex = 16
        Me.btnTechAccess.Text = "Open Tech Access"
        Me.btnTechAccess.UseVisualStyleBackColor = True
        '
        'btnHelpDesk
        '
        Me.btnHelpDesk.Location = New System.Drawing.Point(9, 490)
        Me.btnHelpDesk.Name = "btnHelpDesk"
        Me.btnHelpDesk.Size = New System.Drawing.Size(149, 68)
        Me.btnHelpDesk.TabIndex = 17
        Me.btnHelpDesk.Text = "Open Help Desk"
        Me.btnHelpDesk.UseVisualStyleBackColor = True
        '
        'SupControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 570)
        Me.Controls.Add(Me.btnHelpDesk)
        Me.Controls.Add(Me.btnTechAccess)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstTechs)
        Me.Controls.Add(Me.btnViewCompleted)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEmailTech)
        Me.Controls.Add(Me.btnEditTech)
        Me.Controls.Add(Me.btnAddTech)
        Me.Controls.Add(Me.cboTechRole)
        Me.Controls.Add(Me.txtTechEmail)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFName)
        Me.Name = "SupControlPanel"
        Me.Text = "Supervisor Access"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtTechEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboTechRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddTech As System.Windows.Forms.Button
    Friend WithEvents btnEditTech As System.Windows.Forms.Button
    Friend WithEvents btnEmailTech As System.Windows.Forms.Button
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnViewCompleted As System.Windows.Forms.Button
    Friend WithEvents lstTechs As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnTechAccess As System.Windows.Forms.Button
    Friend WithEvents btnHelpDesk As System.Windows.Forms.Button

End Class
