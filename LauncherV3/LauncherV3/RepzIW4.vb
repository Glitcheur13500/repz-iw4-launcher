Imports System.Net
Imports System.Text
Imports System.Xml
Imports System.IO
Imports System.Net.WebClient
Imports System.IO.Compression
Public Class RepzIW4
    Dim IsDownloading As Boolean = False
    Public TempFile1 As String = GetTempFile(False)
    Private Sub RepzIW4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextTimer.Start() 'Rozpoczecie timera ktory przesuwa tekst
        Status.Text = ""
        MSGLABEL.Text = GetMessageOfDay("http://repziw4.de/updates/msg.txt", "http://repziw4launcherbykch233.cba.pl/msg", "Couldn't download message of day, I'm sorry! ~kch233")
        If CheckAvailability("http://176.28.41.238/page/") = True Then
            'Console.WriteLine("Launching normal launcher with official page.")
            WebBrowser1.Navigate("http://176.28.41.238/page")
        Else
            'Console.WriteLine("Launching error launcher with custom page.")
            Start.DisplayHtml(My.Resources._error, WebBrowser1)
            LogInLogButton1.Visible() = False
            LogInCheckBox1.Visible() = False
            Label1.Visible() = False
            StartGameBTN.Visible = True
            ProgressBar.Visible = False
        End If
        If CheckForUpdatesForStatus() = True Then
            Label1.ForeColor = Color.Green
            Label1.Text = "Client is up-to-date"
        Else
            Label1.ForeColor = Color.Red
            Label1.Text = "Client is outdated"
        End If
        If CheckForLauncherUpdates("http://repziw4launcherbykch233.cba.pl/version") = True Then
            SaveUpdaterForLauncher("updater.exe")
            Application.Exit()

        End If
    End Sub

    Private Sub LogInCheckBox1_CheckedChanged(sender As Object) Handles LogInCheckBox1.CheckedChanged 'Pokazywanie procentow i update'y
        If IsDownloading = False Then
            If LogInCheckBox1.Checked = False Then
                ProgressBar.Visible = False
                ProgressBar.Size = New System.Drawing.Size(0, 0)
                ProgressBar.Location = New System.Drawing.Point(2000, 2000)
            Else
                ProgressBar.Visible = True
                ProgressBar.Size = New System.Drawing.Size(78, 78)
                ProgressBar.Location = New System.Drawing.Point(667, 342)
            End If
        End If
    End Sub

    Private Sub TextTimer_Tick(sender As Object, e As EventArgs) Handles TextTimer.Tick
        Dim gowno = MSG2BOX.Right '- MSGLABEL.Width
        If (MSGLABEL.Left < gowno) Then
            Dim label As Label = MSGLABEL
            label.Left = (label.Left + 1)
        Else
            MSGLABEL.Left = -(MSGLABEL.Width)
        End If

    End Sub

    Private Sub RepzIW4_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Console.WriteLine("Launcher form shown!")
    End Sub

    Private Sub RepzIW4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Console.WriteLine("Launcher form closed!")
        'Console.WriteLine("Waiting for 'Console to be closed.")
    End Sub

    Private Sub LogInLogButton1_Click(sender As Object, e As EventArgs) Handles LogInLogButton1.Click
        If LogInCheckBox1.Checked = True Then
            'Console.WriteLine("Checking for updates...")
            If CheckRequiredFiles() = True Then
                'Console.WriteLine("Found required files.")
                If CheckForUpdates() = True Then
                    IsDownloading = True
                    Status.Text = "Downloading update..."
                    'Console.WriteLine("Found an update! Downloading it...")
                    'Console.WriteLine("Downloading from: " + DL_Link)

                    'DOWNLOAD STARTS HERE

                    Dim _WebClient As New System.Net.WebClient()
                    AddHandler _WebClient.DownloadFileCompleted, AddressOf _DownloadFileCompleted
                    AddHandler _WebClient.DownloadProgressChanged, AddressOf _DownloadProgressChanged
                    'Console.WriteLine("Downloading to: " + TempFile1)
                    _WebClient.DownloadFileAsync(New Uri(DL_Link), TempFile1)

                    'DOWNLOAD ENDS HERE
                    LogInLogButton1.Enabled = False
                Else
                    'Console.WriteLine("Didn't found an update. Launching game instantly.")
                    LaunchGame()
                End If
            Else
                'Console.WriteLine("Didn't find required files, showing error.")
            End If
        Else
            If CheckRequiredFiles() = True Then
                'Console.WriteLine("Didn't found an update. Launching game instantly.")
                LaunchGame()
            End If

        End If
    End Sub

    ' Occurs when an asynchronous file download operation completes.
    Private Sub _DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        ' File download completed
        LogInLogButton1.Enabled = Enabled
        Status.Text = "Download completed."
        'Console.WriteLine("Download completed. Saved to: " + TempFile1)
        ProgressBar.Value = 0
        ExtractAllAsync(TempFile1, baseDirectory, ProgressBar)
        Status.Text = "Extracting update..."
    End Sub

    ' Occurs when an asynchronous download operation successfully transfers some or all of the data.
    Private Sub _DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        ' Update progress bar
        ProgressBar.Value = e.ProgressPercentage
    End Sub


    Private Sub StartGameBTN_Click(sender As Object, e As EventArgs) Handles StartGameBTN.Click
        LaunchGame()
    End Sub
End Class
