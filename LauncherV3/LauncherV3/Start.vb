Imports System.Net
Imports System.Text
Imports System.Xml.Linq
Imports System.IO
Imports System.Windows.Forms
Imports System.Threading.Tasks
Imports System.IO.Compression
Imports System.Threading.Tasks.Parallel
Imports System.Environment
Module Start
    Public baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
    Public DL_Link As String
    Public version As String = "1.1"
    Public remoteversion2 As String


    Sub Main()
        Application.EnableVisualStyles()
        ''Console.Title = "Debug 'Console"
        'Console.WriteLine("Starting launcher form!")
        RepzIW4.ShowDialog()
        'RepzIW4.ShowDialog()
        ''Console.ReadKey()
    End Sub



    Function GetMessageOfDay(ByRef Link1 As String, ByRef Link2 As String, ByRef OfflineMSG As String) As String
        Try
            Dim First As String = New System.Net.WebClient().DownloadString(Link1)
            'Console.WriteLine("Downloading Message of Day from: " + Link1)
            Return First
        Catch ex As Exception
            'Console.WriteLine("Error: Couldn't download Message Of Day from: " + Link1)
            Try
                Dim Second As String = New System.Net.WebClient().DownloadString(Link2)
                'Console.WriteLine("Downloading Message of Day from: " + Link2)
                Return Second
            Catch ex2 As Exception
                'Console.WriteLine("Error: Couldn't download Message Of Day from: " + Link2)
                'Console.WriteLine("Setting offline Message of Day: " + OfflineMSG)
                Return OfflineMSG
            End Try
        End Try
    End Function

    Function CheckAvailability(ByRef Site) As Boolean
        'Console.WriteLine("Downloading string from special site to check if " + Site + "is up.")
        Dim SiteIF As String
        Try
            SiteIF = New WebClient().DownloadString(("http://downforeveryoneorjustme.com/" + Site))
        Catch ex As Exception
            'Console.WriteLine(Site + " has unknown status (?)")
            Return False
        End Try

        Try
            If SiteIF.Contains("It's just you.") Then
                'Console.WriteLine(Site + " is up")
                Return True
            ElseIf SiteIF.Contains("It's not just you!") Then
                'Console.WriteLine(Site + " is down")
                Return False
            Else
                'Console.WriteLine(Site + " has unknown status (?)")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub DisplayHtml(ByVal html As String, ByRef Browser As WebBrowser)

        Browser.Navigate("about:blank")

        If Browser.Document IsNot Nothing Then

            Browser.Document.Write(String.Empty)

        End If

        Browser.DocumentText = html

    End Sub

    Function CheckForUpdatesForStatus() As Boolean 'True = up-to-date || False = outdated
        Dim RemoteVersion As String
        Try
            RemoteVersion = New System.Net.WebClient().DownloadString("http://repziw4.de/updates/version.txt")
        Catch ex As Exception
            Return True
        End Try

        Dim LocalVersion As String
        If File.Exists("version") Then
            Using sr As New StreamReader("version")
                LocalVersion = sr.ReadToEnd()
            End Using
        Else
            LocalVersion = "1.0"

        End If

        Dim ver1 As Double = Val(LocalVersion)
        Dim ver2 As Double = Val(RemoteVersion)

        If ver2 > ver1 Then
            'Console.WriteLine("Client is outdated.")
            Return False
        Else
            'Console.WriteLine("Client is up-to-date.")
            Return True
        End If

    End Function

    Function CheckForUpdates() As Boolean
        'Console.WriteLine("Checking for updates...")
        Dim str3 As String
        Dim str As String = "http://repziw4.de/updates/"


        If File.Exists("version") Then
            Using sr As New StreamReader("version")
                str3 = sr.ReadToEnd()
            End Using
        Else
            str3 = "1.0"
        End If


        'Console.WriteLine("Local version: " + str3)
        Dim ver1 As Double = Val(str3)
        Dim document As XDocument = XDocument.Load(("http://repziw4.de/updates/Updates.xml"))
        Dim element As XElement

        For Each element In document.Descendants("update")
            Dim s As String = element.Element("version").Value
            'Console.WriteLine("Remote version: " + s)
            Dim zipFileName As String = element.Element("file").Value
            Dim ver2 As Double = Val(s)
            Dim path As String = (baseDirectory & zipFileName)

            If (ver2 > ver1) Then
                'Tutaj mam zrobic pobieranie pliku zip do folderu tymczasowego, potem go wypakowac TUTAJ, podmienic wszystkie pliki i usunac plik tymczasowy( meh :/ )
                'Console.WriteLine("Found an update, because remote version(" + ver2.ToString + ")is newer than local version(" + ver1.ToString + ")")
                DL_Link = ("http://repziw4.de/updates/" + zipFileName)
                'Console.WriteLine("Downloading real version file with remote version entry: " + ver2.ToString)
                DeleteFile("version")
                File.Create("version").Dispose()
                Dim swr As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("version", True)
                swr.WriteLine(s)
                swr.Close()
                'RepzIw4.Label1.ForeColor = Color.Green
                RepzIW4.Label1.ForeColor = Color.Green
                'RepzIw4.Label1.Text = "Client is up-to-date"
                RepzIW4.Label1.Text = "Client is up-to-date"
                Return True
            Else
                Return False
            End If



        Next

    End Function

    Function GetTempFile(Optional ByRef DoYouWantPath As Boolean = False) As String
        Dim tempPath = System.IO.Path.GetTempPath
        Dim tempFilename = System.IO.Path.GetTempFileName
        If DoYouWantPath = True Then
            'Console.WriteLine("Getting own temp directory: " + tempPath)
            Return tempPath
        Else
            'Console.WriteLine("Getting own temp file: " + tempFilename)
            Return tempFilename
        End If
    End Function

    Function LaunchProccess(ByRef Executable As String) As Boolean
        Try
            System.Diagnostics.Process.Start(Executable)
        Catch ex As Exception
            'Console.WriteLine("                   ")
            'Console.WriteLine("#######ERROR#######")
            'Console.WriteLine("                   ")
            'Console.WriteLine(ex)
            'Console.WriteLine("                   ")
            'Console.WriteLine("#######ERROR#######")
            'Console.WriteLine("                   ")
            MessageBox.Show("Couldn't find/launch " + Executable, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function CheckRequiredFiles() As Boolean
        'Console.WriteLine("Checking for required files.")
        If Not File.Exists("mss32.dll") And Not File.Exists("binkw32.dll") And Not File.Exists("main\iw_00.iwd") Then
            'Console.WriteLine("Couldn't find required files: mss32.dll, binkw32.dll and main/iw_00.iwd. Returning false.")
            MessageBox.Show("Some game library files could not be found. It could be you didn't put the updater files in your existing Modern Warfare 2 game folder. Also, you still need the game if you want to run RepzIW4.", "RepzIW4", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            'Console.WriteLine("Found required files. Returning true.")
            Return True
        End If

    End Function


    Function DeleteFile(ByRef FileToDelete As String) As Boolean
        Try
            System.IO.File.Delete(FileToDelete)
        Catch ex As Exception
            'Console.WriteLine("                   ")
            'Console.WriteLine("#######ERROR#######")
            'Console.WriteLine("                   ")
            'Console.WriteLine(ex)
            'Console.WriteLine("                   ")
            'Console.WriteLine("#######ERROR#######")
            'Console.WriteLine("                   ")
            MessageBox.Show(ex, "Couldn't delete" + FileToDelete + "file - RepzIW4", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        'Console.WriteLine("Deleting: " + FileToDelete)
        Return True
    End Function

    Async Function ExtractAllAsync(zipFilePath As String, extractPath As String, progress As LogInRadialProgressBar) As Task
        Try
            Dim extractCount, skipCount, errorCount As Integer
            Using archive As ZipArchive = ZipFile.OpenRead(zipFilePath)
                progress.Maximum = archive.Entries.Count
                Await Task.Run(Sub()
                                   Dim count As Integer = archive.Entries.Count
                                   For i As Integer = 0 To count - 1
                                       Try
                                           Dim entry As ZipArchiveEntry = archive.Entries(i)
                                           entry.ExtractToFile(Path.Combine(extractPath, entry.FullName))
                                           extractCount += 1
                                       Catch ioex As IOException
                                           If ioex.Message.EndsWith("already exists.") Then
                                               skipCount += 1
                                           Else
                                               errorCount += 1
                                           End If
                                       Catch ex As Exception
                                           errorCount += 1
                                       End Try
                                       Invoke(Sub() progress.Value += 1)
                                       'System.Threading.Thread.Sleep(100) 'might want delay to see progress animation better
                                   Next
                                   'System.Threading.Thread.Sleep(100)
                               End Sub)
            End Using
            '.Text = "Extracted update."
            RepzIW4.Status.Text = "Extracted update."
            MessageBox.Show(String.Format("Downloaded and extracted {0} files, skipping {1} because they exist, with {2} errors.", extractCount, skipCount, errorCount), "Updating complete.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LaunchGame()
            progress.Value = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error opening zip file.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Console.WriteLine("                   ")
            'Console.WriteLine("#######ERROR#######")
            'Console.WriteLine("                   ")
            'Console.WriteLine(ex)
            'Console.WriteLine("                   ")
            'Console.WriteLine("#######ERROR#######")
            'Console.WriteLine("                   ")
        End Try
    End Function

    Public Sub LaunchGame()
        'RepzIW4.Status.Text = ""
        RepzIW4.Status.Text = ""
        Try
            'DeleteFile(RepzIW4.TempFile1)
            DeleteFile(RepzIW4.TempFile1)
        Catch ex As Exception

        End Try
        LaunchProccess(baseDirectory + "\" + "iw4m.exe")
        Application.Exit()
    End Sub

    Function CheckForLauncherUpdates(ByRef updatelink As String) As Boolean
        Dim RemoteVersion As String
        Try
            RemoteVersion = New System.Net.WebClient().DownloadString(updatelink)
            remoteversion2 = RemoteVersion
        Catch ex As Exception
            Return False
        End Try

        'Dim CurrentVersion As String = Application.ProductVersion
        Dim CurrentVersion As String = "1.1"
        'Console.WriteLine("Launcher local version: " + CurrentVersion)
        'Console.WriteLine("Launcher remote version: " + RemoteVersion)
        Dim ver1 As Double = Val(CurrentVersion)
        Dim ver2 As Double = Val(RemoteVersion)

        If ver2 > ver1 Then
            'Console.WriteLine("Found an update for launcher, because remote version " + RemoteVersion + "is newer than local version: " + CurrentVersion)
            Return True
        End If

    End Function


    Function SaveUpdaterForLauncher(filename) As Boolean
        Try
            DeleteFile(filename)
            'Console.WriteLine("Trying to delete old updater file: " + filename)
            Dim filepath As String = Replace(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName, " ", "%20")
            'Console.WriteLine("Writing updater from resources to file: " + filename)
            System.IO.File.WriteAllBytes(filename, My.Resources.updt)
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = filename
            pHelp.Arguments = filepath
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            'Console.WriteLine("Starting updater...")
            Dim proc As Process = Process.Start(pHelp)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

End Module
