Imports System.Security.Cryptography
Imports System.Text

Module AesEncryption

    'Set the key and initialization vector for AES encryption
    Private key As Byte() = Encoding.UTF8.GetBytes("ThisIsASecretKey123")
    Private iv As Byte() = Encoding.UTF8.GetBytes("InitializationVe")

    'Encrypt a string using AES encryption
    Public Function EncryptString(ByVal plainText As String) As String
        Dim aesAlg As Aes = Aes.Create()
        aesAlg.Key = key
        aesAlg.IV = iv

        Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)

        Dim msEncrypt As New IO.MemoryStream()
        Dim csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
        Dim swEncrypt As New IO.StreamWriter(csEncrypt)
        swEncrypt.Write(plainText)
        swEncrypt.Close()

        Dim encryptedBytes As Byte() = msEncrypt.ToArray()
        Dim encryptedString As String = Convert.ToBase64String(encryptedBytes)

        Return encryptedString
    End Function

    'Decrypt a string using AES encryption
    Public Function DecryptString(ByVal encryptedString As String) As String
        Dim aesAlg As Aes = Aes.Create()
        aesAlg.Key = key
        aesAlg.IV = iv

        Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)

        Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedString)
        Dim msDecrypt As New IO.MemoryStream(encryptedBytes)
        Dim csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
        Dim srDecrypt As New IO.StreamReader(csDecrypt)
        Dim decryptedString As String = srDecrypt.ReadToEnd()

        Return decryptedString
    End Function

End Module
