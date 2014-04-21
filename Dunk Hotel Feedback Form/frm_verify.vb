Public Class frm_login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Check to see if the entered password is correct.
        If txt_password.Text = "admin" Then
            'Clear the password box.
            txt_password.Clear()
            'Hide the login form and show the admin panel.
            Me.Hide()
            frm_adminpanel.Show()

        Else
            'If the entered password is incorrect, return an error.
            MessageBox.Show("Incorrect Password!", "Error")
            'Clear the password box.
            txt_password.Clear()
        End If
    End Sub
End Class