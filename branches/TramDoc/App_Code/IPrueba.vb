Imports Microsoft.VisualBasic

Public Class Prueba
    Implements IFrmBuscador
    Private IdPersonaImp As String
    Public ReadOnly Property IdPersona() As String Implements IFrmBuscador.IdPersona
        Get
            Return IdPersonaImp
        End Get
    End Property
    Public Sub pasavarIdPers(ByVal value As String)
        IdPersonaImp = value
    End Sub


End Class
