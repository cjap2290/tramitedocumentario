Imports Microsoft.VisualBasic
Imports CapaAccesoDatos

' Generated by MyGeneration Version # (1.3.0.3)

Public Class Usuarios 
    Inherits CapaAccesoDatos._Usuarios
    'Dim oUsuario 
    Public NombreColumna As String
    

    Public Function ListarDepartment() As DataTable
        Dim dcoll As New Collection
        'Dim rs As String
        Dim b As Integer
        Dim dt As DataTable
        'Me.Where.Tear()
        If Me.LoadAll Then
            NombreColumna = Usuarios.ColumnNames.IdPersona
            b = Me.cuentafilas

        End If
        dt = Me.retornaUser
        'dcoll.Add(dt, "Tabla")
        'dcoll.Add(rs, "NombreCol")
        Return dt
    End Function
End Class
