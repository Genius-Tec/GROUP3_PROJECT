<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        lblStudentAttendanceSystem = New Label()
        btnBack = New Button()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        txtReportTime = New TextBox()
        Label1 = New Label()
        btnDelete = New Button()
        btnDeleteAll = New Button()
        btnSave = New Button()
        btnEdit = New Button()
        btnExport = New Button()
        btnClear = New Button()
        txtStudentID = New TextBox()
        txtCourseCode = New TextBox()
        lblReportTime = New Label()
        lblStudentID = New Label()
        lblCourseCode = New Label()
        dtpDate = New DateTimePicker()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStudentAttendanceSystem
        ' 
        lblStudentAttendanceSystem.AutoSize = True
        lblStudentAttendanceSystem.BackColor = SystemColors.GradientInactiveCaption
        lblStudentAttendanceSystem.FlatStyle = FlatStyle.System
        lblStudentAttendanceSystem.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentAttendanceSystem.Location = New Point(317, 19)
        lblStudentAttendanceSystem.Name = "lblStudentAttendanceSystem"
        lblStudentAttendanceSystem.Size = New Size(446, 37)
        lblStudentAttendanceSystem.TabIndex = 1
        lblStudentAttendanceSystem.Text = "STUDENTS ATTENDANCE SYSTEM"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Crimson
        btnBack.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnBack.Location = New Point(830, 357)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 42)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(txtReportTime)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnDeleteAll)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnExport)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(lblStudentAttendanceSystem)
        Panel2.Controls.Add(txtStudentID)
        Panel2.Controls.Add(txtCourseCode)
        Panel2.Controls.Add(lblReportTime)
        Panel2.Controls.Add(lblStudentID)
        Panel2.Controls.Add(lblCourseCode)
        Panel2.Controls.Add(dtpDate)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1137, 640)
        Panel2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(170, 417)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Size = New Size(814, 211)
        DataGridView1.TabIndex = 2
        ' 
        ' txtReportTime
        ' 
        txtReportTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReportTime.Location = New Point(493, 276)
        txtReportTime.Name = "txtReportTime"
        txtReportTime.Size = New Size(272, 35)
        txtReportTime.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientInactiveCaption
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        Label1.Location = New Point(308, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 25)
        Label1.TabIndex = 7
        Label1.Text = "Date:"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.GradientInactiveCaption
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnDelete.Location = New Point(583, 357)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(88, 42)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteAll
        ' 
        btnDeleteAll.BackColor = SystemColors.GradientInactiveCaption
        btnDeleteAll.FlatStyle = FlatStyle.Popup
        btnDeleteAll.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnDeleteAll.Location = New Point(693, 357)
        btnDeleteAll.Name = "btnDeleteAll"
        btnDeleteAll.Size = New Size(131, 42)
        btnDeleteAll.TabIndex = 5
        btnDeleteAll.Text = "Delete All"
        btnDeleteAll.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.GradientInactiveCaption
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnSave.Location = New Point(254, 357)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(88, 42)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.GradientInactiveCaption
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnEdit.Location = New Point(362, 357)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(88, 42)
        btnEdit.TabIndex = 4
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = SystemColors.GradientInactiveCaption
        btnExport.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        btnExport.Location = New Point(863, 214)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(97, 42)
        btnExport.TabIndex = 6
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.GradientInactiveCaption
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnClear.Location = New Point(472, 357)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(88, 42)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        txtStudentID.Location = New Point(493, 225)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(273, 31)
        txtStudentID.TabIndex = 5
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        txtCourseCode.Location = New Point(494, 177)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(272, 31)
        txtCourseCode.TabIndex = 4
        ' 
        ' lblReportTime
        ' 
        lblReportTime.AutoSize = True
        lblReportTime.BackColor = SystemColors.GradientInactiveCaption
        lblReportTime.FlatStyle = FlatStyle.System
        lblReportTime.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        lblReportTime.Location = New Point(308, 283)
        lblReportTime.Name = "lblReportTime"
        lblReportTime.Size = New Size(147, 25)
        lblReportTime.TabIndex = 3
        lblReportTime.Text = "Report Time:"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.BackColor = SystemColors.GradientInactiveCaption
        lblStudentID.FlatStyle = FlatStyle.System
        lblStudentID.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        lblStudentID.Location = New Point(308, 225)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(122, 25)
        lblStudentID.TabIndex = 2
        lblStudentID.Text = "StudentID:"
        ' 
        ' lblCourseCode
        ' 
        lblCourseCode.AutoSize = True
        lblCourseCode.BackColor = SystemColors.GradientInactiveCaption
        lblCourseCode.FlatStyle = FlatStyle.System
        lblCourseCode.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        lblCourseCode.Location = New Point(308, 177)
        lblCourseCode.Name = "lblCourseCode"
        lblCourseCode.Size = New Size(156, 25)
        lblCourseCode.TabIndex = 1
        lblCourseCode.Text = "Course Code:"
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(494, 132)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(271, 31)
        dtpDate.TabIndex = 0
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1137, 640)
        Controls.Add(Panel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Students Attendance System"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblReportTime As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblCourseCode As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents lblStudentAttendanceSystem As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReportTime As TextBox
End Class
