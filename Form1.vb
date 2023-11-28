Public Class Form1
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "James Daniel" And TxtPassword.Text = "Pharmaplus" Then
            MsgBox("You login is successfully")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or password")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        TxtUsername.Clear()
        TxtPassword.Clear()
        Form3.Show()
        Me.Close()
    End Sub
End Class
