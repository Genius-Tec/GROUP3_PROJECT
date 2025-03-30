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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        lblStudentAttendanceSystem = New Label()
        btnBack = New Button()
        Panel2 = New Panel()
        btnExport = New Button()
        txtReportTime = New TextBox()
        txtStudentID = New TextBox()
        txtCourseCode = New TextBox()
        lblReportTime = New Label()
        lblStudentID = New Label()
        lblCourseCode = New Label()
        dtpDate = New DateTimePicker()
        DataGridView1 = New DataGridView()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnDeleteAll = New Button()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStudentAttendanceSystem
        ' 
        lblStudentAttendanceSystem.AutoSize = True
        lblStudentAttendanceSystem.BackColor = SystemColors.ActiveCaption
        lblStudentAttendanceSystem.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentAttendanceSystem.Location = New Point(178, 18)
        lblStudentAttendanceSystem.Name = "lblStudentAttendanceSystem"
        lblStudentAttendanceSystem.Size = New Size(446, 37)
        lblStudentAttendanceSystem.TabIndex = 1
        lblStudentAttendanceSystem.Text = "STUDENTS ATTENDANCE SYSTEM"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Crimson
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(693, 370)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(76, 29)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkViolet
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnDeleteAll)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(btnExport)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(lblStudentAttendanceSystem)
        Panel2.Controls.Add(txtReportTime)
        Panel2.Controls.Add(txtStudentID)
        Panel2.Controls.Add(txtCourseCode)
        Panel2.Controls.Add(lblReportTime)
        Panel2.Controls.Add(lblStudentID)
        Panel2.Controls.Add(lblCourseCode)
        Panel2.Controls.Add(dtpDate)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(802, 591)
        Panel2.TabIndex = 1
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = SystemColors.ActiveCaption
        btnExport.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.Location = New Point(588, 192)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(90, 36)
        btnExport.TabIndex = 6
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' txtReportTime
        ' 
        txtReportTime.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReportTime.Location = New Point(333, 257)
        txtReportTime.Name = "txtReportTime"
        txtReportTime.Size = New Size(200, 29)
        txtReportTime.TabIndex = 6
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStudentID.Location = New Point(333, 199)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(201, 29)
        txtStudentID.TabIndex = 5
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCourseCode.Location = New Point(334, 151)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(200, 29)
        txtCourseCode.TabIndex = 4
        ' 
        ' lblReportTime
        ' 
        lblReportTime.AutoSize = True
        lblReportTime.BackColor = SystemColors.ActiveCaption
        lblReportTime.FlatStyle = FlatStyle.System
        lblReportTime.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReportTime.Location = New Point(205, 260)
        lblReportTime.Name = "lblReportTime"
        lblReportTime.Size = New Size(107, 21)
        lblReportTime.TabIndex = 3
        lblReportTime.Text = "Report Time:"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.BackColor = SystemColors.ActiveCaption
        lblStudentID.FlatStyle = FlatStyle.System
        lblStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentID.Location = New Point(221, 207)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(91, 21)
        lblStudentID.TabIndex = 2
        lblStudentID.Text = "StudentID:"
        ' 
        ' lblCourseCode
        ' 
        lblCourseCode.AutoSize = True
        lblCourseCode.BackColor = SystemColors.ActiveCaption
        lblCourseCode.FlatStyle = FlatStyle.System
        lblCourseCode.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCourseCode.Location = New Point(203, 154)
        lblCourseCode.Name = "lblCourseCode"
        lblCourseCode.Size = New Size(109, 21)
        lblCourseCode.TabIndex = 1
        lblCourseCode.Text = "Course Code:"
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(276, 89)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(271, 29)
        dtpDate.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 426)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(802, 165)
        DataGridView1.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.ActiveCaption
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(162, 366)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 36)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ActiveCaption
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(257, 366)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 36)
        btnEdit.TabIndex = 4
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ActiveCaption
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(445, 366)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 36)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ActiveCaption
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(351, 366)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 36)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteAll
        ' 
        btnDeleteAll.BackColor = SystemColors.ActiveCaption
        btnDeleteAll.FlatStyle = FlatStyle.Popup
        btnDeleteAll.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteAll.Location = New Point(537, 366)
        btnDeleteAll.Name = "btnDeleteAll"
        btnDeleteAll.Size = New Size(141, 36)
        btnDeleteAll.TabIndex = 5
        btnDeleteAll.Text = "Delete All"
        btnDeleteAll.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(802, 591)
        Controls.Add(DataGridView1)
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
    Friend WithEvents txtReportTime As TextBox
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
End Class
