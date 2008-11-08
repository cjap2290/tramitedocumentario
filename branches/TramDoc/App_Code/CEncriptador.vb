Imports Microsoft.VisualBasic
Imports CAPICOM

Public Class CEncriptador
    Public Function DecryptData(ByVal xTobeDecrypt As String, Optional ByVal xKey As String = "") As String
        'On Error GoTo ErrorHandler
        Dim obEncrypt As New EncryptedData
        Dim xKeyDefault As String
        Dim xDecryptMsg As String = ""

        If Len(Trim(xKey)) = 0 Then
            xKeyDefault = gKey
        Else
            xKeyDefault = xKey
        End If

        If Len(xTobeDecrypt) > 0 Then
            obEncrypt.SetSecret(xKeyDefault)
            obEncrypt.Decrypt(xTobeDecrypt)
            xDecryptMsg = obEncrypt.Content
        Else
            MessageBox.Show("No existe mensaje a ser Desencriptado", "Apliación-Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        DecryptData = xDecryptMsg
        obEncrypt = Nothing
        'Exit Function
        'ErrorHandler:
        If Err.Number > 0 Then
            MessageBox.Show("Visual Basic error found:" & Err.Description)
        Else
            If Err.Number = -2146893819 Then
                MessageBox.Show("Error. The Clave para desencriptar no es correcta.", "Aplicación-Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("CAPICOM error found : " & Err.Number, "Aplicación-Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Function
    Function EncryptData(ByVal xTobeEncrypt As String, Optional ByVal xKey As String = "") As String
        Dim obEncrypt As New EncryptedData
        Dim xKeyDefault As String
        Dim xEncryptMsg As String

        If Len(Trim(xKey)) = 0 Then
            xKeyDefault = gKey
        Else
            xKeyDefault = xKey
        End If
        obEncrypt.Content = xTobeEncrypt
        obEncrypt.SetSecret(xKeyDefault)
        obEncrypt.Algorithm.Name = CAPICOM_ENCRYPTION_ALGORITHM_3DES

        xEncryptMsg = obEncrypt.Encrypt

        If Len(xEncryptMsg) < 1 Then
            MsgBox("No se puede realizar la Encriptación de Datos", vbInformation, "Mensajes ")
        End If
        EncryptData = xEncryptMsg

        obEncrypt = Nothing
        Exit Function
ErrorHandler:
        If Err.Number > 0 Then
            MsgBox("Visual Basic error found:" & Err.Description, vbInformation, "Aplicación-Mensaje")
        Else
            MsgBox("CAPICOM error found : " & Err.Number, vbInformation, "Aplicación-Mensaje")
        End If
        EncryptData = ""
    End Function
End Class
