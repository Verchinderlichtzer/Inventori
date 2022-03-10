Imports System.Globalization, System.IO, MadMilkman.Ini

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            If Not Directory.Exists(Path) Then
                Directory.CreateDirectory(Path)
            End If
            If Not File.Exists(Path & "\Dev.ini") Then
                FileOpen(1, Path & "\Dev.ini", OpenMode.Output)
                PrintLine(1, "[konfigurasi]")
                PrintLine(1, "cookies=")
                PrintLine(1, "ppn=0")
                FileClose(1)
            End If
            If Not File.Exists(Path & "\Dev.accdb") Then
                Try
                    Computer.FileSystem.MoveFile(Application.Info.DirectoryPath & "\Dev.accdb", Path & "\Dev.accdb")
                Catch ex As Exception
                    MsgBox("...")
                End Try
            End If
            Koneksi()
            Dim us = New CultureInfo("en-US")
            CultureInfo.DefaultThreadCurrentCulture = us
            CultureInfo.DefaultThreadCurrentUICulture = us

            Dim Ini As New IniFile
            Ini.Load(Path & "\Dev.ini")
            PPNOtomatis = Ini.Sections("konfigurasi").Keys("ppn").Value
            QR("SELECT username FROM tbluser WHERE username = '" & Ini.Sections("konfigurasi").Keys("cookies").Value & "'")
            If DR.HasRows AndAlso DR(0) <> "Admin" Then
                UserAktif = DR(0)
                Application.MainForm = MainF
            Else
                Application.MainForm = Login
            End If
        End Sub
    End Class
End Namespace