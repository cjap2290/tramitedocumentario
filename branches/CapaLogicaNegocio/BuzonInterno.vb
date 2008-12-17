Imports CapaAccesoDatos
Imports MyGeneration.dOOdads
' Generated by MyGeneration Version # (1.3.0.3)
Public Class BuzonInterno
    Inherits _BuzonInterno

    Private EC_IdAdignaDocInterno As Integer
    Private EC_FechaLlegada As String
    Private EC_FechaLeido As String
    Private EC_FechaLimite As String
    Private EC_IdCondicionEnvio As String
    Private EC_IdEstBuzonInterno As String
    Private EC_Observaciones As String
    Private EC_IdUserR As String
    Private EC_FechaR As String
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
    Public Property pObservaciones() As String
        Get
            Return EC_Observaciones
        End Get
        Set(ByVal value As String)
            EC_Observaciones = value
        End Set
    End Property
    Public Property pIdEstBuzoninterno() As String
        Get
            Return EC_IdEstBuzonInterno
        End Get
        Set(ByVal value As String)
            EC_IdEstBuzonInterno = value
        End Set
    End Property
    Public Property pIdCondicionEnvio() As String
        Get
            Return EC_IdCondicionEnvio
        End Get
        Set(ByVal value As String)
            EC_IdCondicionEnvio = value
        End Set
    End Property
    Public Property pFechaLimite() As String
        Get
            Return EC_FechaLimite
        End Get
        Set(ByVal value As String)
            EC_FechaLimite = value
        End Set
    End Property
    Public Property pFechaLeido() As String
        Get
            Return EC_FechaLeido
        End Get
        Set(ByVal value As String)
            EC_FechaLeido = value
        End Set
    End Property
    Public Property pFechaLlegada() As String
        Get
            Return EC_FechaLlegada
        End Get
        Set(ByVal value As String)
            EC_FechaLlegada = value
        End Set
    End Property
    Public Property pIdAsignaDocInterno() As Integer
        Get
            Return EC_IdAdignaDocInterno
        End Get
        Set(ByVal value As Integer)
            EC_IdAdignaDocInterno = value
        End Set
    End Property
    Public Sub insertarBuzon(ByVal NuevoBuzonInterno As BuzonInterno)
        Dim tx As TransactionMgr
        tx = TransactionMgr.ThreadTransactionMgr
        Try
            tx.BeginTransaction()
            AddNew()
            With NuevoBuzonInterno
                IdAsigDocInterno = .pIdAsignaDocInterno
                FechaLlegada = CType(.pFechaLeido, Date)
                FechaLeido = ctype(.pFechaLeido,Date)
                IdCondicionEnvio = .pIdCondicionEnvio
                IdEstBuzonInterno = .pIdEstBuzoninterno
                Observaciones = .pObservaciones
                IdUserR = .IdUserR
                FechaR = .FechaR
            End With
            Save()
            tx.CommitTransaction()
        Catch ex As Exception
            tx.RollbackTransaction()
            TransactionMgr.ThreadTransactionMgrReset()
            Throw ex
        End Try
    End Sub
End Class