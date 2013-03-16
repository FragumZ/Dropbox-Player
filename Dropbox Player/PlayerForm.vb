Imports DropNet
Imports DropNet.Models
Imports DropNet.Exceptions

Public Class PlayerForm

    Dim APIKey As String = "18qbxw0y4yja84y"
    Dim APISecret As String = "x6zq2q34rw6418x"

    Dim Client As New DropNetClient(APIKey, APISecret, My.Settings.UserToken, My.Settings.UserSecret)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.settings.volume = 80
        TextBox1.Text = My.Settings.Path
    End Sub

    Private Sub PlayWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PlayWorker.DoWork
        Try
            AxWindowsMediaPlayer1.URL = (Client.GetMedia(TextBox1.Text)).Url
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PlayWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles PlayWorker.RunWorkerCompleted
        Button1.Enabled = True
        TextBox1.ReadOnly = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        TextBox1.ReadOnly = True
        PlayWorker.RunWorkerAsync()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        My.Settings.Path = TextBox1.Text
    End Sub
End Class
