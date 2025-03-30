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
        Panel1 = New Panel()
        Label3 = New Label()
        Button2 = New Button()
        Panel2 = New Panel()
        cbxShow = New CheckBox()
        llbCreateAccount = New LinkLabel()
        pbxImage = New PictureBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnLogin = New Button()
        lblPassword = New Label()
        lblUsername = New Label()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pbxImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkViolet
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(730, 76)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(227, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 37)
        Label3.TabIndex = 1
        Label3.Text = "Administrator"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Crimson
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(625, 25)
        Button2.Name = "Button2"
        Button2.Size = New Size(51, 30)
        Button2.TabIndex = 0
        Button2.Text = "X"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkViolet
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(cbxShow)
        Panel2.Controls.Add(llbCreateAccount)
        Panel2.Controls.Add(pbxImage)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(lblPassword)
        Panel2.Controls.Add(lblUsername)
        Panel2.Location = New Point(45, 107)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(632, 261)
        Panel2.TabIndex = 1
        ' 
        ' cbxShow
        ' 
        cbxShow.AutoSize = True
        cbxShow.Location = New Point(324, 126)
        cbxShow.Name = "cbxShow"
        cbxShow.Size = New Size(15, 14)
        cbxShow.TabIndex = 7
        cbxShow.UseVisualStyleBackColor = True
        ' 
        ' llbCreateAccount
        ' 
        llbCreateAccount.AutoSize = True
        llbCreateAccount.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        llbCreateAccount.LinkColor = Color.Black
        llbCreateAccount.Location = New Point(191, 223)
        llbCreateAccount.Name = "llbCreateAccount"
        llbCreateAccount.Size = New Size(148, 25)
        llbCreateAccount.TabIndex = 6
        llbCreateAccount.TabStop = True
        llbCreateAccount.Text = "Create Account"
        ' 
        ' pbxImage
        ' 
        pbxImage.BorderStyle = BorderStyle.FixedSingle
        pbxImage.Image = My.Resources.Resources.WhatsApp_Image_2025_02_19_at_06_10_35_68d602c8
        pbxImage.Location = New Point(422, 61)
        pbxImage.Name = "pbxImage"
        pbxImage.Size = New Size(98, 80)
        pbxImage.SizeMode = PictureBoxSizeMode.Zoom
        pbxImage.TabIndex = 5
        pbxImage.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(182, 120)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(171, 29)
        txtPassword.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(182, 61)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(171, 29)
        txtUsername.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DarkOrchid
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(279, 161)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(74, 33)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(44, 120)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 21)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(44, 63)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 21)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkViolet
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 403)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(730, 42)
        Panel3.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(730, 445)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOG IN"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(pbxImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
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
