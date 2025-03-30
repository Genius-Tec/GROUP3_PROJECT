Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=GENIUSWORLD\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True;Trust Server Certificate=True"
    Dim selectedRecordId As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = $"Data Source=GENIUSWORLD\SQLEXPRESS;Initial Catalog=Attendance;Integrated Security=True;Trust Server Certificate=True"
        LoadData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateInputs() Then
            SaveData()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ValidateInputs() Then
            UpdateData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedRecordId = 0 Then
            MessageBox.Show("Please select a record to delete.")
            Return
        End If

        Try
            Using con As SqlConnection = New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "DELETE FROM Dataset WHERE ID = @id"
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", selectedRecordId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data deleted successfully.")
            ClearForm()
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete all records and reset the database?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Try
                Using con As SqlConnection = New SqlConnection(connectionString)
                    con.Open()
                    Dim query As String = "DELETE FROM Dataset; DBCC CHECKIDENT ('Dataset', RESEED, 0);"
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("All data deleted and database reset successfully.")
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error resetting database: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedRecordId = Convert.ToInt32(row.Cells("ID").Value)
            txtCourseCode.Text = row.Cells("CourseID").Value.ToString()
            txtStudentID.Text = row.Cells("StudentID").Value.ToString()
            txtReportTime.Text = row.Cells("Report").Value.ToString()
            dtpDate.Value = Convert.ToDateTime(row.Cells("DateOfAttendance").Value)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub LoadData()
        Try
            Using con As SqlConnection = New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT * FROM Dataset"
                Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, con)
                Dim table As DataTable = New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveData()
        Try
            Using con As SqlConnection = New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "INSERT INTO Dataset (CourseID, StudentID, Report, DateOfAttendance) VALUES (@courseCode, @studentId, @reportTime, @dateOfAttendance)"
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@courseCode", txtCourseCode.Text)
                    cmd.Parameters.AddWithValue("@studentID", txtStudentID.Text)
                    cmd.Parameters.AddWithValue("@reportTime", txtReportTime.Text)
                    cmd.Parameters.AddWithValue("@dateOfAttendance", dtpDate.Value)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data saved successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateData()
        Try
            Using con As SqlConnection = New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "UPDATE Dataset SET CourseID = @courseCode, StudentID = @studentId, Report = @reportTime, DateOfAttendance = @dateOfAttendance WHERE ID = @id"
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@courseCode", txtCourseCode.Text)
                    cmd.Parameters.AddWithValue("@studentID", txtStudentID.Text)
                    cmd.Parameters.AddWithValue("@reportTime", txtReportTime.Text)
                    cmd.Parameters.AddWithValue("@dateOfAttendance", dtpDate.Value)
                    cmd.Parameters.AddWithValue("@id", selectedRecordId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data updated successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrEmpty(txtCourseCode.Text) Or String.IsNullOrEmpty(txtStudentID.Text) Or String.IsNullOrEmpty(txtReportTime.Text) Then
            MessageBox.Show("Please enter all fields.")
            Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        txtCourseCode.Clear()
        txtStudentID.Clear()
        txtReportTime.Clear()
        dtpDate.Value = DateTime.Now
        selectedRecordId = 0
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportDataToCSV()
    End Sub

    Private Sub ExportDataToCSV()
        Try
            Using con As SqlConnection = New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT * FROM Dataset"
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim csvFilePath As String = "C:\Users\USER\Documents\AttendanceData.csv"
                        Using writer As StreamWriter = New StreamWriter(csvFilePath)
                            ' Write the header
                            For i As Integer = 0 To reader.FieldCount - 1
                                writer.Write(reader.GetName(i))
                                If i < reader.FieldCount - 1 Then
                                    writer.Write(",")
                                End If
                            Next
                            writer.WriteLine()

                            ' Write the data
                            While reader.Read()
                                For i As Integer = 0 To reader.FieldCount - 1
                                    writer.Write(reader(i).ToString())
                                    If i < reader.FieldCount - 1 Then
                                        writer.Write(",")
                                    End If
                                Next
                                writer.WriteLine()
                            End While
                        End Using
                        MessageBox.Show("Data exported successfully to " & csvFilePath)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error exporting data: " & ex.Message)
        End Try
    End Sub
End Class
