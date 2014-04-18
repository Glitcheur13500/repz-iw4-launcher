Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Downloading update..."
        DeleteFile(LocationOne)
        'DOWNLOAD STARTS HERE

        Dim _WebClient As New System.Net.WebClient()
        AddHandler _WebClient.DownloadFileCompleted, AddressOf _DownloadFileCompleted
        AddHandler _WebClient.DownloadProgressChanged, AddressOf _DownloadProgressChanged
        _WebClient.DownloadFileAsync(New Uri("http://repziw4launcherbykch233.cba.pl/LauncherV3.exe"), LocationOne)

        'DOWNLOAD ENDS HERE
    End Sub

    ' Occurs when an asynchronous file download operation completes.
    Private Sub _DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        ' File download completed
        Label1.Text = "Download completed."
        ProgressBar1.Value = 100
        LaunchProccess(LocationOne)
        Application.Exit()
    End Sub

    ' Occurs when an asynchronous download operation successfully transfers some or all of the data.
    Private Sub _DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        ' Update progress bar
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

End Class
