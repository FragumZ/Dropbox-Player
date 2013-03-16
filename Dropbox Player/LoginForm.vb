Imports DropNet
Imports DropNet.Models

Public Class LoginForm

    Dim APIKey As String = "18qbxw0y4yja84y"
    Dim APISecret As String = "x6zq2q34rw6418x"

    Dim Client As New DropNetClient(APIKey, APISecret)
    Dim ErrorDetails As String = ""

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.UserSecret = "" Then
            Label1.Text = "Requesting Authentication..."
            My.Settings.UserToken = ""
            My.Settings.UserSecret = ""
            BackgroundWorker1.RunWorkerAsync()
        Else
            Label1.Text = "Launching Application..."
            PlayerForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        My.Settings.Save()
        Try
            Client.GetToken()
        Catch ex As Exception
            ErrorDetails = ex.Message.ToString
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If ErrorDetails = "" Then
            Process.Start(Client.BuildAuthorizeUrl())
            Label1.Text = "Opening Browser..."
            BackgroundWorker2.RunWorkerAsync()
        Else
            MsgBox(ErrorDetails)
            StartupForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Threading.Thread.Sleep(1000)
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Label1.Text = "Waiting For User To Accept..."
        BackgroundWorker3.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Do While My.Settings.UserSecret = ""
            Try
                Threading.Thread.Sleep(1000)
                Dim AccessToken As UserLogin = Client.GetAccessToken
                My.Settings.UserToken = AccessToken.Token
                My.Settings.UserSecret = AccessToken.Secret
            Catch ex As Exception
            End Try
        Loop
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        Label1.Text = "Saving And Launching..."
        BackgroundWorker4.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        My.Settings.Save()
    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted
        PlayerForm.Show()
        Me.Close()
    End Sub
End Class