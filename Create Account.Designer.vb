<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Account
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        lblCreateAccount = New Label()
        btnClose = New Button()
        Panel3 = New Panel()
        cbxShow = New CheckBox()
        btnCreate = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkViolet
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 391)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(664, 37)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkViolet
        Panel2.Controls.Add(lblCreateAccount)
        Panel2.Controls.Add(btnClose)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(664, 76)
        Panel2.TabIndex = 1
        ' 
        ' lblCreateAccount
        ' 
        lblCreateAccount.AutoSize = True
        lblCreateAccount.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCreateAccount.Location = New Point(201, 23)
        lblCreateAccount.Name = "lblCreateAccount"
        lblCreateAccount.Size = New Size(213, 37)
        lblCreateAccount.TabIndex = 1
        lblCreateAccount.Text = "Create Account"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Crimson
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(529, 23)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(44, 30)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkViolet
        Panel3.Controls.Add(cbxShow)
        Panel3.Controls.Add(btnCreate)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(txtUsername)
        Panel3.Controls.Add(lblPassword)
        Panel3.Controls.Add(lblUsername)
        Panel3.Location = New Point(89, 121)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(484, 228)
        Panel3.TabIndex = 2
        ' 
        ' cbxShow
        ' 
        cbxShow.AutoSize = True
        cbxShow.Location = New Point(301, 116)
        cbxShow.Name = "cbxShow"
        cbxShow.Size = New Size(15, 14)
        cbxShow.TabIndex = 5
        cbxShow.UseVisualStyleBackColor = True
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = Color.DarkOrchid
        btnCreate.FlatStyle = FlatStyle.Popup
        btnCreate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreate.Location = New Point(250, 167)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(75, 28)
        btnCreate.TabIndex = 4
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(147, 108)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(178, 29)
        txtPassword.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(147, 46)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(178, 29)
        txtUsername.TabIndex = 2
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(35, 110)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 21)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(35, 46)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 21)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' Create_Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 428)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Create_Account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create_Account"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblCreateAccount As Label
    Friend WithEvents cbxShow As CheckBox
End Class
