Imports Microsoft.VisualBasic
Imports CAPICOM

Public Class CEncriptador
    Const gKey As String = "SisLeonXIII"  'xa Produccion

    Public Function DecryptData(ByVal xTobeDecrypt As String, Optional ByVal xKey As String = "") As String
        'On Error GoTo ErrorHandler
        Dim obEncrypt As New EncryptedData
        Dim xKeyDefault As String
        Dim xDecryptMsg As String = ""

        Try
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
                MsgBox("No existe mensaje a ser Desencriptado", vbInformation, "Mensajes ")
            End If
            'DecryptData = xDecryptMsg
            obEncrypt = Nothing
            Return xDecryptMsg
        Catch ex As Exception
            If Err.Number > 0 Then
                MsgBox("Visual Basic error found:" & Err.Description)
            Else
                If Err.Number = -2146893819 Then
                    MsgBox("Error. The Clave para desencriptar no es correcta.", vbInformation, "Mensajes ")
                Else
                    MsgBox("CAPICOM error found : " & Err.Number, vbInformation, "Mensajes ")
                End If
            End If
        End Try

        'Exit Function
        'ErrorHandler:
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
        obEncrypt.Algorithm.Name = CAPICOM_ENCRYPTION_ALGORITHM.CAPICOM_ENCRYPTION_ALGORITHM_3DES

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
