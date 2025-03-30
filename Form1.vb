Imports System.IO
Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Dim con As SqlConnection = New SqlConnection("Data Source=GENIUSWORLD\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;Trust Server Certificate=True")
    Public Shared LoggedInUser As String

    Private Sub llbCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbCreateAccount.LinkClicked
        Hide()
        Create_Account.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        Try
            con.Open()
            Dim query As String = "SELECT Password FROM Sign WHERE Username = @username"
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", username)
                Dim storedPassword As String = Convert.ToString(cmd.ExecuteScalar())

                If VerifyPassword(password, storedPassword) Then
                    MessageBox.Show("Login successful.")
                    LoggedInUser = username
                    Me.Hide()
                    Form2.Show()
                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub pbxImage_Click(sender As Object, e As EventArgs) Handles pbxImage.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pbxImage.Image = Image.FromFile(openFileDialog.FileName)
            SaveImageToDatabase(openFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveImageToDatabase(imagePath As String)
        Try
            con.Open()
            Dim query As String = "INSERT INTO UserImages (Username, ImageData) VALUES (@username, @imageData)"
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                Dim imageData As Byte() = File.ReadAllBytes(imagePath)
                cmd.Parameters.AddWithValue("@imageData", imageData)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Image saved successfully.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cbxShow_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShow.CheckedChanged
        If cbxShow.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

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

    Private Function VerifyPassword(inputPassword As String, storedPassword As String) As Boolean
        Dim hashedInputPassword As String = HashPassword(inputPassword)
        Return hashedInputPassword = storedPassword
    End Function
End Class
