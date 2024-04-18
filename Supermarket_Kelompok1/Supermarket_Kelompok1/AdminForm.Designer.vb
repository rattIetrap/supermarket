<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.cmbUserRole = New System.Windows.Forms.ComboBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvUserReport = New System.Windows.Forms.DataGridView()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvUserReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCreateUser)
        Me.Panel1.Controls.Add(Me.txtFullName)
        Me.Panel1.Controls.Add(Me.cmbUserRole)
        Me.Panel1.Controls.Add(Me.txtNewPassword)
        Me.Panel1.Controls.Add(Me.txtNewUsername)
        Me.Panel1.Location = New System.Drawing.Point(31, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 185)
        Me.Panel1.TabIndex = 0
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(119, 137)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateUser.TabIndex = 4
        Me.btnCreateUser.Text = "Button1"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(174, 70)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(120, 20)
        Me.txtFullName.TabIndex = 3
        '
        'cmbUserRole
        '
        Me.cmbUserRole.FormattingEnabled = True
        Me.cmbUserRole.Location = New System.Drawing.Point(173, 95)
        Me.cmbUserRole.Name = "cmbUserRole"
        Me.cmbUserRole.Size = New System.Drawing.Size(121, 21)
        Me.cmbUserRole.TabIndex = 2
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(173, 44)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtNewPassword.TabIndex = 1
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Location = New System.Drawing.Point(173, 18)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(122, 20)
        Me.txtNewUsername.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvUserReport)
        Me.Panel2.Location = New System.Drawing.Point(405, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 185)
        Me.Panel2.TabIndex = 1
        '
        'dgvUserReport
        '
        Me.dgvUserReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserReport.Location = New System.Drawing.Point(35, 18)
        Me.dgvUserReport.Name = "dgvUserReport"
        Me.dgvUserReport.Size = New System.Drawing.Size(240, 150)
        Me.dgvUserReport.TabIndex = 0
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(531, 239)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(75, 23)
        Me.btnViewReport.TabIndex = 5
        Me.btnViewReport.Text = "Button1"
        Me.btnViewReport.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(691, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Button1"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnViewReport)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvUserReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cmbUserRole As ComboBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvUserReport As DataGridView
    Friend WithEvents btnViewReport As Button
    Friend WithEvents btnLogout As Button
End Class
