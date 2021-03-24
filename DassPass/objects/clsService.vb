Public Class clsService
    Public Sub New(ByVal strWebsite As String, ByVal strUser As String, ByVal strPass As String, ByVal strNotes As String)
        SetWebsite(strWebsite)
        SetUser(strUser)
        SetPass(strPass)
        SetNotes(strNotes)
    End Sub


    Private Website As String
    Public Sub SetWebsite(ByVal strWebsite As String)
        Website = strWebsite
    End Sub
    Public Function GetWebsite() As String
        Return Website
    End Function


    Private User As String
    Public Sub SetUser(ByVal strUser As String)
        User = strUser
    End Sub
    Public Function GetUser() As String
        Return User
    End Function


    Private Pass As String
    Public Sub SetPass(ByVal strPass As String)
        Pass = strPass
    End Sub
    Public Function GetPass() As String
        Return Pass
    End Function


    Private Notes As String
    Public Sub SetNotes(ByVal strNotes As String)
        Notes = strNotes
    End Sub
    Public Function GetNotes() As String
        Return Notes
    End Function
End Class
