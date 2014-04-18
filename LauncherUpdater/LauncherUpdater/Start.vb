Imports System.Text
Module Start
    Public LocationOne As String
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        For i As Integer = 0 To CommandLineArgs.Count - 1
            If CommandLineArgs.Count = 1 Then
                Dim strSomething As String
                strSomething = Replace(CommandLineArgs(i), "%20", " ")
                If Not strSomething = " " Or Nothing Then
                    LocationOne = strSomething
                    Debug.Print(strSomething)
                    Form1.ShowDialog()
                Else
                    'FuckYou.ShowDialog()
                End If
                'FuckYou.ShowDialog()
            End If
            'FuckYou.ShowDialog()
        Next
        FuckYou.ShowDialog()
    End Sub

    Function DeleteFile(ByRef FileToDelete As String) As Boolean
        Try
            System.IO.File.Delete(FileToDelete)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
        Return True
    End Function

    Function LaunchProccess(ByRef Executable As String) As Boolean
        Try
            System.Diagnostics.Process.Start(Executable)
        Catch ex As Exception
            MessageBox.Show("Couldn't find/launch " + Executable, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function


End Module
