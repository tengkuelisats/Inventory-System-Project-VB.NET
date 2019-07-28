Public Class LogIn

    Private Sub ButtonLogIn_Click(sender As Object, e As EventArgs) Handles ButtonLogIn.Click

        Dim inventory1 As New Inventory

        TextBoxPassword.PasswordChar = "*"

        If TextBoxUsername.Text = "admin" And TextBoxPassword.Text = "admin" Then
            Inventory.Show()
            Me.Hide()
        ElseIf TextBoxUsername.Text = "" Or TextBoxPassword.Text = "" Then
            MessageBox.Show("Please fill the username and password", "Login Invalid")
        Else
            MessageBox.Show("Invalid Username and Password", "Login Failed")
        End If

    End Sub

End Class
