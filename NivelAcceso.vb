Imports CapaAccesoDatos
' Generated by MyGeneration Version # (1.3.0.3)

Public Class NivelAcceso 
    Inherits _NivelAcceso
    Dim sNomColDescripcion As String
    Dim sNomColId As String
    Public ReadOnly Property NombreColDesc()
        Get
            Return sNomColDescripcion
        End Get
    End Property
    Public ReadOnly Property NombreColId()
        Get
            Return sNomColId
        End Get
    End Property
    Public Function listarNivelAcceso() As DataTable
        Dim dtNivelAcceso As New DataTable
        dtNivelAcceso = Me.lstNivelAcceso
        If dtNivelAcceso IsNot Nothing Then
            sNomColDescripcion = ColumnNames.Descripcion
            sNomColId = ColumnNames.IdNivelAcceso
            Return dtNivelAcceso
        Else
            Return Nothing
        End If
    End Function
    

End Class
