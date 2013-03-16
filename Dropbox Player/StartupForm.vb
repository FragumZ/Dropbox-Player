Public Class StartupForm

    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.First = True Then
            My.Settings.Upgrade()
            My.Settings.First = False
            My.Settings.Save()
        End If
        If My.Settings.UserSecret = "" Then
            Button3.Visible = True
        Else
            Button1.Visible = True
            Button2.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.UserToken = ""
        My.Settings.UserSecret = ""
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.UserToken = ""
        My.Settings.UserSecret = ""
        LoginForm.Show()
        Me.Close()
    End Sub

End Class