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
        Panel1 = New Panel()
        lblStudentAttendanceSystem = New Label()
        btnClose = New Button()
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
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkViolet
        Panel1.Controls.Add(lblStudentAttendanceSystem)
        Panel1.Controls.Add(btnClose)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 80)
        Panel1.TabIndex = 0
        ' 
        ' lblStudentAttendanceSystem
        ' 
        lblStudentAttendanceSystem.AutoSize = True
        lblStudentAttendanceSystem.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentAttendanceSystem.Location = New Point(147, 20)
        lblStudentAttendanceSystem.Name = "lblStudentAttendanceSystem"
        lblStudentAttendanceSystem.Size = New Size(446, 37)
        lblStudentAttendanceSystem.TabIndex = 1
        lblStudentAttendanceSystem.Text = "STUDENTS ATTENDANCE SYSTEM"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Crimson
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(708, 27)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(49, 30)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkViolet
        Panel2.Controls.Add(btnExport)
        Panel2.Controls.Add(txtReportTime)
        Panel2.Controls.Add(txtStudentID)
        Panel2.Controls.Add(txtCourseCode)
        Panel2.Controls.Add(lblReportTime)
        Panel2.Controls.Add(lblStudentID)
        Panel2.Controls.Add(lblCourseCode)
        Panel2.Controls.Add(dtpDate)
        Panel2.Location = New Point(38, 114)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(719, 235)
        Panel2.TabIndex = 1
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.DarkViolet
        btnExport.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.Location = New Point(590, 107)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(90, 36)
        btnExport.TabIndex = 6
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' txtReportTime
        ' 
        txtReportTime.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReportTime.Location = New Point(335, 166)
        txtReportTime.Name = "txtReportTime"
        txtReportTime.Size = New Size(200, 29)
        txtReportTime.TabIndex = 6
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStudentID.Location = New Point(335, 122)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(201, 29)
        txtStudentID.TabIndex = 5
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCourseCode.Location = New Point(336, 78)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(200, 29)
        txtCourseCode.TabIndex = 4
        ' 
        ' lblReportTime
        ' 
        lblReportTime.AutoSize = True
        lblReportTime.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReportTime.Location = New Point(154, 169)
        lblReportTime.Name = "lblReportTime"
        lblReportTime.Size = New Size(107, 21)
        lblReportTime.TabIndex = 3
        lblReportTime.Text = "Report Time:"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentID.Location = New Point(170, 122)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(91, 21)
        lblStudentID.TabIndex = 2
        lblStudentID.Text = "StudentID:"
        ' 
        ' lblCourseCode
        ' 
        lblCourseCode.AutoSize = True
        lblCourseCode.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCourseCode.Location = New Point(152, 81)
        lblCourseCode.Name = "lblCourseCode"
        lblCourseCode.Size = New Size(109, 21)
        lblCourseCode.TabIndex = 1
        lblCourseCode.Text = "Course Code:"
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(203, 17)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(271, 29)
        dtpDate.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.DarkViolet
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 426)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(802, 165)
        DataGridView1.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.DarkViolet
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(38, 366)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 36)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.DarkViolet
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(169, 366)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 36)
        btnEdit.TabIndex = 4
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.DarkViolet
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(472, 366)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 36)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DarkViolet
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(334, 366)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 36)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteAll
        ' 
        btnDeleteAll.BackColor = Color.DarkViolet
        btnDeleteAll.FlatStyle = FlatStyle.Popup
        btnDeleteAll.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteAll.Location = New Point(616, 366)
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
        ClientSize = New Size(802, 591)
        Controls.Add(btnDeleteAll)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnEdit)
        Controls.Add(btnSave)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents btnExport As Button
End Class
