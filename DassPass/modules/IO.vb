Imports System.IO

Module IO
    Private SReader As StreamReader
    Private SWriter As StreamWriter

    Private passDir As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DassPass"
    Const passFile As String = "\profile.dat"

    Sub InitIO()
        If Not Directory.Exists(passDir) Then
            Directory.CreateDirectory(passDir)
        End If
    End Sub

    Sub WriteToFile(ByVal arrWrite As ArrayList)
        SWriter = New StreamWriter(passDir + passFile)

        For Each aService As clsService In arrWrite
            Dim strPre As String
            strPre = Encrypt(aService.GetWebsite) & "¶" & Encrypt(aService.GetUser) & "¶" & Encrypt(aService.GetPass) & "¶" & Encrypt(aService.GetNotes)

            Dim strPost As String
            strPost = Encrypt2(strPre)

            SWriter.WriteLine(strPost)
        Next

        SWriter.Close()
    End Sub

    Function ReadFromFile() As ArrayList
        Dim retArray As New ArrayList

        If File.Exists(passDir & passFile) Then
            SReader = New StreamReader(passDir & passFile)

            Dim currentLine As String

            Do
                currentLine = SReader.ReadLine

                If currentLine <> Nothing Then
                    Dim strPre As String = Decrypt2(currentLine)

                    Dim strSplit() As String = Split(strPre, "¶")

                    retArray.Add(New clsService(Decrypt(strSplit(0)), Decrypt(strSplit(1)), Decrypt(strSplit(2)), Decrypt(strSplit(3))))
                End If
            Loop While currentLine <> Nothing

            SReader.Close()
        End If

        Return retArray
    End Function

    Sub ExportToText()
        If File.Exists(passDir & passFile) Then
            SReader = New StreamReader(passDir & passFile)

            Dim arrServices As New ArrayList

            Dim currentLine As String

            Do
                currentLine = SReader.ReadLine

                If currentLine <> Nothing Then
                    Dim strPre As String = Decrypt2(currentLine)

                    Dim strSplit() As String = Split(strPre, "¶")

                    arrServices.Add(New clsService(Decrypt(strSplit(0)), Decrypt(strSplit(1)), Decrypt(strSplit(2)), Decrypt(strSplit(3))))
                End If
            Loop While currentLine <> Nothing

            SReader.Close()

            SWriter = New StreamWriter(passDir & "\pwd.txt")

            For Each aService As clsService In arrServices
                SWriter.WriteLine(aService.GetWebsite)
                SWriter.WriteLine(aService.GetUser)
                SWriter.WriteLine(aService.GetPass)
                SWriter.WriteLine(aService.GetNotes)
                SWriter.WriteLine()
            Next

            SWriter.Close()
        End If
    End Sub
End Module
