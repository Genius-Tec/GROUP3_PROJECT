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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create_Account))
        lblCreateAccount = New Label()
        btnBack = New Button()
        Panel3 = New Panel()
        cbxShow = New CheckBox()
        btnCreate = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCreateAccount
        ' 
        lblCreateAccount.AutoSize = True
        lblCreateAccount.BackColor = SystemColors.HotTrack
        lblCreateAccount.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCreateAccount.Location = New Point(218, 20)
        lblCreateAccount.Name = "lblCreateAccount"
        lblCreateAccount.Size = New Size(213, 37)
        lblCreateAccount.TabIndex = 1
        lblCreateAccount.Text = "Create Account"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Crimson
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(509, 242)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(80, 30)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkViolet
        Panel3.BackgroundImage = My.Resources.Resources.road_signs_7055475_960_720
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(btnBack)
        Panel3.Controls.Add(lblCreateAccount)
        Panel3.Controls.Add(cbxShow)
        Panel3.Controls.Add(btnCreate)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(txtUsername)
        Panel3.Controls.Add(lblPassword)
        Panel3.Controls.Add(lblUsername)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(664, 428)
        Panel3.TabIndex = 2
        ' 
        ' cbxShow
        ' 
        cbxShow.AutoSize = True
        cbxShow.Location = New Point(400, 201)
        cbxShow.Name = "cbxShow"
        cbxShow.Size = New Size(15, 14)
        cbxShow.TabIndex = 5
        cbxShow.UseVisualStyleBackColor = True
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = SystemColors.HotTrack
        btnCreate.FlatStyle = FlatStyle.Popup
        btnCreate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreate.Location = New Point(366, 242)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(75, 28)
        btnCreate.TabIndex = 4
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(253, 192)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(178, 29)
        txtPassword.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(253, 135)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(178, 29)
        txtUsername.TabIndex = 2
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = SystemColors.HotTrack
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(127, 200)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 21)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = SystemColors.HotTrack
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(122, 138)
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
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Create_Account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create_Account"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblCreateAccount As Label
    Friend WithEvents cbxShow As CheckBox
End Class
