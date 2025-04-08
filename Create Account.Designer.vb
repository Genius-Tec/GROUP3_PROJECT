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
        PictureBox1 = New PictureBox()
        cbxShow = New CheckBox()
        btnCreate = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCreateAccount
        ' 
        lblCreateAccount.AutoSize = True
        lblCreateAccount.BackColor = SystemColors.GradientInactiveCaption
        lblCreateAccount.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCreateAccount.Location = New Point(324, 50)
        lblCreateAccount.Name = "lblCreateAccount"
        lblCreateAccount.Size = New Size(340, 37)
        lblCreateAccount.TabIndex = 1
        lblCreateAccount.Text = "Please Create an Account"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Crimson
        btnBack.BackgroundImageLayout = ImageLayout.None
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(792, 312)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(80, 30)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = SystemColors.GradientInactiveCaption
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(btnBack)
        Panel3.Controls.Add(lblCreateAccount)
        Panel3.Controls.Add(cbxShow)
        Panel3.Controls.Add(btnCreate)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(txtUsername)
        Panel3.Controls.Add(lblPassword)
        Panel3.Controls.Add(lblUsername)
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1002, 543)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(128, 156)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(306, 302)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' cbxShow
        ' 
        cbxShow.AutoSize = True
        cbxShow.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        cbxShow.Location = New Point(847, 251)
        cbxShow.Name = "cbxShow"
        cbxShow.Size = New Size(15, 14)
        cbxShow.TabIndex = 5
        cbxShow.UseVisualStyleBackColor = True
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = SystemColors.HotTrack
        btnCreate.BackgroundImageLayout = ImageLayout.None
        btnCreate.FlatStyle = FlatStyle.Popup
        btnCreate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreate.Location = New Point(628, 312)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(75, 28)
        btnCreate.TabIndex = 4
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        txtPassword.Location = New Point(628, 242)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(244, 31)
        txtPassword.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        txtUsername.Location = New Point(628, 175)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(244, 31)
        txtUsername.TabIndex = 2
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = SystemColors.GradientInactiveCaption
        lblPassword.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        lblPassword.Location = New Point(494, 245)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(121, 25)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = SystemColors.GradientInactiveCaption
        lblUsername.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        lblUsername.Location = New Point(489, 175)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(125, 25)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' Create_Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1002, 543)
        Controls.Add(Panel3)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Create_Account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create_Account"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
