Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Create_Account
    Dim con As SqlConnection = New SqlConnection("Data Source=GENIUSWORLD\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;Trust Server Certificate=True")

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        If IsUsernameTaken(username) Then
            MessageBox.Show("Username already taken. Please choose a different username.")
            Return
        End If

        Try
            con.Open()
            Dim query As String = "INSERT INTO Sign (Username, Password) VALUES (@username, @password)"
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", HashPassword(password))
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Account created successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub cbxShow_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShow.CheckedChanged
        If cbxShow.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Function IsUsernameTaken(username As String) As Boolean
        Try
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM Sign WHERE Username = @username"
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", username)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return True
        Finally
            con.Close()
        End Try
    End Function

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function
End Class
