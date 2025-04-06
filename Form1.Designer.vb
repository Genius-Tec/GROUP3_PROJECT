<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label3 = New Label()
        btnClose = New Button()
        Panel2 = New Panel()
        cbxShow = New CheckBox()
        llbCreateAccount = New LinkLabel()
        pbxImage = New PictureBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnLogin = New Button()
        lblPassword = New Label()
        lblUsername = New Label()
        Panel2.SuspendLayout()
        CType(pbxImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientInactiveCaption
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(255, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 37)
        Label3.TabIndex = 1
        Label3.Text = "Administrator"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Crimson
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(449, 244)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(73, 33)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnClose)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(cbxShow)
        Panel2.Controls.Add(llbCreateAccount)
        Panel2.Controls.Add(pbxImage)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(lblPassword)
        Panel2.Controls.Add(lblUsername)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(730, 445)
        Panel2.TabIndex = 1
        ' 
        ' cbxShow
        ' 
        cbxShow.AutoSize = True
        cbxShow.BackColor = SystemColors.ActiveCaption
        cbxShow.Location = New Point(388, 209)
        cbxShow.Name = "cbxShow"
        cbxShow.Size = New Size(15, 14)
        cbxShow.TabIndex = 7
        cbxShow.UseVisualStyleBackColor = False
        ' 
        ' llbCreateAccount
        ' 
        llbCreateAccount.AutoSize = True
        llbCreateAccount.BackColor = SystemColors.GradientInactiveCaption
        llbCreateAccount.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        llbCreateAccount.LinkColor = Color.Black
        llbCreateAccount.Location = New Point(255, 306)
        llbCreateAccount.Name = "llbCreateAccount"
        llbCreateAccount.Size = New Size(148, 25)
        llbCreateAccount.TabIndex = 6
        llbCreateAccount.TabStop = True
        llbCreateAccount.Text = "Create Account"
        ' 
        ' pbxImage
        ' 
        pbxImage.BackColor = SystemColors.GradientInactiveCaption
        pbxImage.BorderStyle = BorderStyle.FixedSingle
        pbxImage.Image = CType(resources.GetObject("pbxImage.Image"), Image)
        pbxImage.Location = New Point(463, 103)
        pbxImage.Name = "pbxImage"
        pbxImage.Size = New Size(130, 129)
        pbxImage.SizeMode = PictureBoxSizeMode.Zoom
        pbxImage.TabIndex = 5
        pbxImage.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(246, 203)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(171, 29)
        txtPassword.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(246, 144)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(171, 29)
        txtUsername.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.GradientInactiveCaption
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(343, 244)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(74, 33)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = SystemColors.GradientInactiveCaption
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(130, 206)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 21)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = SystemColors.GradientInactiveCaption
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(130, 152)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 21)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(730, 445)
        Controls.Add(Panel2)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOG IN"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(pbxImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents llbCreateAccount As LinkLabel
    Friend WithEvents pbxImage As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxShow As CheckBox

End Class
