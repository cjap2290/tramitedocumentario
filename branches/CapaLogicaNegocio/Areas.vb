Imports CapaAccesoDatos
' Generated by MyGeneration Version # (1.3.0.3)

Public Class Areas 
    Inherits _Areas
    Dim sEC_Area As String
    Public Function EC_obtArea(ByVal sEIdArea As String) As String
        If E_obtArea(sEIdArea) Then
            Return Me.Area
        Else
            Return False
        End If
    End Function
End Class
