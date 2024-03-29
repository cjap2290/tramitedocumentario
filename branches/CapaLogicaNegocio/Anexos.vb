Imports CapaAccesoDatos
Imports MyGeneration.dOOdads
' Generated by MyGeneration Version # (1.3.0.3)

Public Class Anexos 
    Inherits _Anexos

    Private EC_IdDocInterno As Integer
    Private EC_NombreAnexo As String
    Private EC_RutaAnexo As String
    Private EC_Activo As String
    Private EC_IdUserR As String
    Private EC_FechaR As String

    Private lsAnexosActivos As DataTable
    Public Property dtListaAnexoActivos() As DataTable
        Get
            Return lsAnexosActivos
        End Get
        Set(ByVal value As DataTable)
            lsAnexosActivos = value
        End Set
    End Property

    Public Property pFechaR() As String
        Get
            Return EC_FechaR
        End Get
        Set(ByVal value As String)
            EC_FechaR = value
        End Set
    End Property
    Public Property pIdUserR() As String
        Get
            Return EC_IdUserR
        End Get
        Set(ByVal value As String)
            EC_IdUserR = value
        End Set
    End Property
    Public Property pActivo() As String
        Get
            Return EC_Activo
        End Get
        Set(ByVal value As String)
            EC_Activo = value
        End Set
    End Property
    Public Property pIdDocInterno() As Integer
        Get
            Return EC_IdDocInterno
        End Get
        Set(ByVal value As Integer)
            EC_IdDocInterno = value
        End Set
    End Property
    Public Property pNombreAnexo() As String
        Get
            Return EC_NombreAnexo
        End Get
        Set(ByVal value As String)
            EC_NombreAnexo = value
        End Set
    End Property
    Public Property pRutaAnexo() As String
        Get
            Return EC_RutaAnexo
        End Get
        Set(ByVal value As String)
            EC_RutaAnexo = value
        End Set
    End Property

    Public Sub InsertaAnexo(ByVal NvoAnexo As Anexos)
        AddNew()
        With NvoAnexo
            Me.IdDocInterno = .pIdDocInterno
            Me.NombreAnexo = .pNombreAnexo
            Me.RutaAnexo = .pRutaAnexo
            Me.Activo = .pActivo
            Me.IdUserR = .pIdUserR
            Me.FechaR = .pFechaR
        End With
        Me.Save()
    End Sub
    Public Function obtenerAnexosActivo(ByVal sIdDocInterno As String) As Boolean
        If Where.IdDocInterno.Value IsNot Nothing And Where.Activo.Value IsNot Nothing Then
            Me.Where.WhereClauseReset()
        End If
        Where.IdDocInterno.Value = sIdDocInterno
        Where.IdDocInterno.Operator = WhereParameter.Operand.Equal
        Where.Activo.Value = "1"
        Where.Activo.Operator = WhereParameter.Operand.Equal
        If Query.Load Then
            dtListaAnexoActivos = Me.DataTable
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub DesactivarAnexo(ByVal sIDAnexo As Integer)
        Dim tx As TransactionMgr
        tx = TransactionMgr.ThreadTransactionMgr()
        Try
            tx.BeginTransaction()
            If LoadByPrimaryKey(sIDAnexo) Then
                Activo = "0"
                Save()
            End If
            tx.CommitTransaction()
        Catch ex As Exception
            tx.RollbackTransaction()
            TransactionMgr.ThreadTransactionMgrReset()
        End Try
    End Sub
End Class
