Imports System.Security.Cryptography

Module Crypto2
    Private TDES2 As New TripleDESCryptoServiceProvider

    Sub InitCrypto2()
        Dim strKey As String
	strKey = "" 
        'Removed from main branch on dasspass-vb-deprecated- repo for security reasons. 
        'Please use DassPass-Portable, written in Python. 

        TDES2.Key = TruncateHash2(strKey, TDES2.KeySize \ 8)
        TDES2.IV = TruncateHash2("", TDES2.BlockSize \ 8)
    End Sub

    Private Function TruncateHash2(ByVal strKey As String, ByVal intLength As Integer) As Byte()
        Dim Sha As New SHA512CryptoServiceProvider

        Dim byteKey() As Byte = Text.Encoding.Unicode.GetBytes(strKey)
        Dim byteHash() As Byte = Sha.ComputeHash(byteKey)

        ReDim Preserve byteHash(intLength - 1)
        Return byteHash
    End Function

    Public Function Encrypt2(ByVal PlainString As String) As String
        Dim bytePlainString() As Byte = Text.Encoding.Unicode.GetBytes(PlainString)

        Dim memStream As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(memStream, TDES2.CreateEncryptor(), CryptoStreamMode.Write)

        encStream.Write(bytePlainString, 0, bytePlainString.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(memStream.ToArray)
    End Function

    Public Function Decrypt2(ByVal EncryptedString As String) As String
        Dim byteEncryptedString() As Byte = Convert.FromBase64String(EncryptedString)

        Dim memStream As New System.IO.MemoryStream
        Dim decStream As New CryptoStream(memStream, TDES2.CreateDecryptor(), CryptoStreamMode.Write)

        decStream.Write(byteEncryptedString, 0, byteEncryptedString.Length)
        decStream.FlushFinalBlock()

        Return Text.Encoding.Unicode.GetString(memStream.ToArray)
    End Function
End Module
