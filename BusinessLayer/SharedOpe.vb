Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports Microsoft.Practices.EnterpriseLibrary.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports CAPICOM
Imports System.Windows.Forms
Imports System.Configuration

Public Class SharedOpe

    Private DR As IDataReader = Nothing
    Private ds As New DataSet
    Private cmd As New SqlCommand
    Private Nulo As System.DBNull
    Private Shared DBF As Database
    Private Shared sLogin As String
    Private Shared sFecha As String
    Private Shared sHora As String
    Private Shared sFechaIng As String
    Private Shared sHoraIng As String

    Private Shared vgIdAgencia As String
    Private Shared vgIdArea As String
    Private Shared vgIdCargo As String
    Private Shared vgAgencia As String
    Private Shared vgArea As String
    Private Shared vgCargo As String
    Private Shared vgDirAgencia As String
    Private Shared vgAgAbrev As String
    Private Shared vgIdPersona As String

    Public Shared sSQL As String
    Private Shared vIniDia As Integer
    Private Shared vTolEnt As Integer
    Private Shared vTolSal As Integer
    Public Shared MatMes(11) As String
    Public Shared MatDias(6) As String

    '------------------------------------
    'VARIABLES CTRLACTUALIZA EJECUTABLES
    '------------------------------------
    Public Shared Actualiza As Boolean
    Public Shared Archivo As String
    Public Shared sNomPC As String

    '-------------------------------------------------'
    '---  Para Manejo de Claves Secretas (Testigo) ---'
    '-------------------------------------------------'
    Public Const gKey As String = "SisLeonXIII"  'xa Produccion

    Public Property TolEnt() As Integer
        Get
            Return vTolEnt
        End Get
        Set(ByVal value As Integer)
            vTolEnt = value
        End Set
    End Property

    Public Property TolSal() As Integer
        Get
            Return vTolSal
        End Get
        Set(ByVal value As Integer)
            vTolSal = value
        End Set
    End Property

    Public Property IniDia() As Integer
        Get
            Return vIniDia
        End Get
        Set(ByVal value As Integer)
            vIniDia = value
        End Set
    End Property

    Public Property DB() As Database
        Get
            Return DBF
        End Get
        Set(ByVal value As Database)
            DBF = value
        End Set
    End Property

    Public Property Login() As String
        Get
            Return sLogin
        End Get
        Set(ByVal value As String)
            sLogin = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return sFecha
        End Get
        Set(ByVal value As String)
            sFecha = value
        End Set
    End Property

    Public Property Hora() As String
        Get
            Return sHora
        End Get
        Set(ByVal value As String)
            sHora = value
        End Set
    End Property

    Public Property FechaIng() As String
        Get
            Return sFechaIng
        End Get
        Set(ByVal value As String)
            sFechaIng = value
        End Set
    End Property

    Public Property HoraIng() As String
        Get
            Return sHoraIng
        End Get
        Set(ByVal value As String)
            sHoraIng = value
        End Set
    End Property

    Public Property vIdAgencia() As String
        Get
            Return vgIdAgencia
        End Get
        Set(ByVal value As String)
            vgIdAgencia = value
        End Set
    End Property

    Public Property vIdArea() As String
        Get
            Return vgIdArea
        End Get
        Set(ByVal value As String)
            vgIdArea = value
        End Set
    End Property

    Public Property vIdCargo() As String
        Get
            Return vgIdCargo
        End Get
        Set(ByVal value As String)
            vgIdCargo = value
        End Set
    End Property

    Public Property vAgencia() As String
        Get
            Return vgAgencia
        End Get
        Set(ByVal value As String)
            vgAgencia = value
        End Set
    End Property

    Public Property vArea() As String
        Get
            Return vgArea
        End Get
        Set(ByVal value As String)
            vgArea = value
        End Set
    End Property

    Public Property vCargo() As String
        Get
            Return vgCargo
        End Get
        Set(ByVal value As String)
            vgCargo = value
        End Set
    End Property

    Public Property vDirAgencia() As String
        Get
            Return vgDirAgencia
        End Get
        Set(ByVal value As String)
            vgDirAgencia = value
        End Set
    End Property

    Public Property vAgAbrev() As String
        Get
            Return vgAgAbrev
        End Get
        Set(ByVal value As String)
            vgAgAbrev = value
        End Set
    End Property

    Public Property vIdPersona() As String
        Get
            Return vgIdPersona
        End Get
        Set(ByVal value As String)
            vgIdPersona = value
        End Set
    End Property

    Public Sub CreaDBF()
        DB = DatabaseFactory.CreateDatabase("BDProduccion")
    End Sub

    Public Shared Function LoadMeses() As String()
        MatMes(0) = "ENERO"
        MatMes(1) = "FEBRERO"
        MatMes(2) = "MARZO"
        MatMes(3) = "ABRIL"
        MatMes(4) = "MAYO"
        MatMes(5) = "JUNIO"
        MatMes(6) = "JULIO"
        MatMes(7) = "AGOSTO"
        MatMes(8) = "SEPTIEMBRE"
        MatMes(9) = "OCTUBRE"
        MatMes(10) = "NOVIEMBRE"
        MatMes(11) = "DICIEMBRE"
        Return MatMes
    End Function

    Public Shared Function LoadDias() As String()
        MatDias(0) = "Lunes"
        MatDias(1) = "Martes"
        MatDias(2) = "Miercoles"
        MatDias(3) = "Jueves"
        MatDias(4) = "Viernes"
        MatDias(5) = "Sabado"
        MatDias(6) = "Domingo"
        Return MatDias
    End Function

    Public Function CheckAgencia() As String
        Dim xIdAgencia As String = ""
        'DB = DatabaseFactory.CreateDatabase("BDProduccion")
        sSQL = "SELECT IdAgencia=LEFT(HOST_NAME(),2)"
        DR = DB.ExecuteReader(CommandType.Text, sSQL)

        While DR.Read
            xIdAgencia = DR.Item("IdAgencia")
        End While
        If String.IsNullOrEmpty(xIdAgencia) Then
            xIdAgencia = "00"
        End If
        DR.Close()
        DR = Nothing
        If xIdAgencia = "00" Then
            MessageBox.Show("No se puede Determinar Agencia a la que Pertenece su PC", "SIAF-Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckAgencia = -1
            Exit Function
        End If
        If vgIdAgencia <> xIdAgencia Then
            MessageBox.Show("Usuario se encuentra Asignado a una Agencia distinta a la que pertence la PC", "SIAF-Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckAgencia = -2
            Exit Function
        End If
        CheckAgencia = 1
    End Function

    Public Function GetHora() As String
        GetHora = Mid(CStr(My.Computer.Clock.LocalTime.TimeOfDay.ToString), 1, 8)
    End Function

    Public Function GetFecha() As String
        GetFecha = Mid(CStr(My.Computer.Clock.LocalTime.Date.ToString), 1, 10)
    End Function

    Public Function DecryptData(ByVal xTobeDecrypt As String, Optional ByVal xKey As String = "") As String
        On Error GoTo ErrorHandler
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
        Exit Function
ErrorHandler:
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

    Public Function GetUserLogin(ByVal Login As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetUserLogin", Login)
        GetUserLogin = DB.ExecuteReader(cmd)
    End Function

    Public Function GetPersonalxDNI(ByVal DNI As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetPersonalxDNI", DNI)
        GetPersonalxDNI = DB.ExecuteReader(cmd)
    End Function

    Public Function GetDatosUser(ByVal Usuario As String) As IDataReader
        DB = DatabaseFactory.CreateDatabase("BDProduccion")
        cmd = DB.GetStoredProcCommand("paGetDatosUser", Usuario)
        GetDatosUser = DB.ExecuteReader(cmd)
    End Function
    Public Function GetBloqueo(ByVal UserLog As String) As IDataReader
        sSQL = "Select Bloqueo from Usuarios where iduser='" & Trim(UserLog) & "'"
        GetBloqueo = DB.ExecuteReader(CommandType.Text, sSQL)
    End Function

    Public Sub BloqueoUsuario(ByVal UserLog As String, ByVal vTipo As String)
        If vTipo = "0" Then
            sSQL = "Update Usuarios set Bloqueo='0' where iduser='" & Trim(UserLog) & "'"
            DB.ExecuteNonQuery(CommandType.Text, sSQL)
        ElseIf vTipo = "1" Then
            sSQL = "Update Usuarios set Bloqueo=Bloqueo+1 where iduser='" & Trim(UserLog) & "'"
            DB.ExecuteNonQuery(CommandType.Text, sSQL)
        ElseIf vTipo = "2" Then
            sSQL = "Update Usuarios set Bloqueo=Bloqueo+1 where iduser='" & Trim(UserLog) & "'"
            DB.ExecuteNonQuery(CommandType.Text, sSQL)
        End If
    End Sub

    Public Function Buscador(ByVal xEnte As String, ByVal sTipo As String, ByVal sBusq As String, _
                            ByVal vExp As String, ByVal index As Integer) As IDataReader
        cmd = DB.GetStoredProcCommand("paBuscador", xEnte, sTipo, sBusq, Trim(vExp), index)
        Buscador = DB.ExecuteReader(cmd)
    End Function

    Public Function GetDatosTarjeta(ByVal vExp As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetDatosTarjeta", vExp)
        GetDatosTarjeta = DB.ExecuteReader(cmd)
    End Function

    Public Sub CtrlAcceso(ByVal Login As String, ByVal Fecha As String, ByVal Hora As String)
        cmd = DB.GetStoredProcCommand("paCtrlAcceso", Login, Fecha, Hora)
        DB.ExecuteNonQuery(cmd)
    End Sub

    Public Function GetCadConexion() As String
        GetCadConexion = ConfigurationManager.ConnectionStrings.Item("BDProduccion").ConnectionString
    End Function

    Public Function CargarTipoHorario() As DataSet
        cmd = DB.GetStoredProcCommand("paGetTipoHorario")
        CargarTipoHorario = DB.ExecuteDataSet(cmd)
    End Function

    Public Function CargarAgencias() As DataSet
        cmd = DB.GetStoredProcCommand("paGetAgencias")
        CargarAgencias = DB.ExecuteDataSet(cmd)
    End Function

    Public Sub UploadFotoPersonal(ByVal IdPersona As String, _
                                    ByVal Firma As Byte(), ByVal Foto As Byte(), _
                                    ByVal Transaction As SqlTransaction)
        cmd = DB.GetStoredProcCommand("paUploadFotoPersonal", IdPersona, _
                                    IIf(Firma Is Nothing, Nulo, Firma), _
                                    IIf(Foto Is Nothing, Nulo, Foto))
        DB.ExecuteNonQuery(cmd, Transaction)
    End Sub

    Public Function GetHorario(ByVal Horario As String, ByVal IdTipoHorario As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetHorario", Nulo, Horario, IdTipoHorario, Nulo)
        GetHorario = DB.ExecuteReader(cmd)
    End Function

    Public Sub InsertaHorario(ByVal HorDesc As String, ByVal TipoHor As String, _
                                ByVal Habilita As String, ByVal Login As String, _
                                ByVal Fecha As String, ByVal Hora As String, _
                                ByVal Transaction As SqlTransaction)

        cmd = DB.GetStoredProcCommand("paInsertaHorario", HorDesc, _
                TipoHor, Habilita, _
                Login, Fecha, Hora, Nulo)
        DB.ExecuteNonQuery(cmd, Transaction)
    End Sub

    Public Function ExisteEnHorAge(ByVal IdHorario As String) As Boolean
        ExisteEnHorAge = False
        cmd = DB.GetStoredProcCommand("paGetHorXAge", Nulo, IdHorario, Nulo, Nulo, Nulo, "1")
        DR = DB.ExecuteReader(cmd)
        While DR.Read
            ExisteEnHorAge = True
        End While
        DR.Close()
    End Function

    Public Sub ActualizaHorario(ByVal IdUser As String, ByVal Fecha As String, _
                            ByVal Hora As String, ByVal IdHorario As String, _
                            ByVal IdTipHor As String, ByVal HorDesc As String, _
                            ByVal EstHor As String, ByVal Trans As SqlTransaction)
        cmd = DB.GetStoredProcCommand("paActualizaHorario", IdHorario, HorDesc, _
                                        IdTipHor, EstHor, IdUser, Fecha, Hora)
        DB.ExecuteNonQuery(cmd, Trans)
    End Sub

    Public Function GetListHorario(ByVal vIdTipHor As String, ByVal Muestra As Boolean) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetHorario", Nulo, Nulo, _
                                IIf(vIdTipHor <> "", vIdTipHor, Nulo), _
                                IIf(Muestra = True, "1", Nulo))
        GetListHorario = DB.ExecuteReader(cmd)
    End Function

    Public Function CargarHorario(ByVal vIdAgencia As String, ByVal vIdTipHor As String, _
                                    ByVal Muestra As Boolean) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetHorXAge", Nulo, Nulo, _
                                        IIf(vIdAgencia <> "", vIdAgencia, Nulo), _
                                        Nulo, IIf(vIdTipHor <> "", vIdTipHor, Nulo), _
                                        IIf(Muestra = True, "1", Nulo))
        CargarHorario = DB.ExecuteReader(cmd)
    End Function

    Public Function GetDetHor(ByVal IdHorxAge As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetDetHor", Nulo, IdHorxAge, Nulo, Nulo, Nulo)
        GetDetHor = DB.ExecuteReader(cmd)
    End Function

    Public Function ExisteHorarioxAgencia(ByVal IdHorario As String, ByVal IdAgencia As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetHorXAge", Nulo, IdHorario, IIf(IdAgencia = "", Nulo, IdAgencia), Nulo, Nulo, Nulo)
        ExisteHorarioxAgencia = DB.ExecuteReader(cmd)
    End Function

    Public Function Asignado(ByVal IdHorXAge As String) As Boolean
        Asignado = False
        cmd = DB.GetStoredProcCommand("paGetAsigHorxEmp", Nulo, IdHorXAge, Nulo, Nulo, Nulo, "1")
        DR = DB.ExecuteReader(cmd)
        While DR.Read
            Asignado = True
        End While
        DR.Close()
    End Function

    Public Sub InsertaDetHor(ByVal IdDet As String, ByVal IdHorario As String, _
                            ByVal Trans As SqlTransaction, _
                            ByVal IdDia As String, ByVal Dia As String, _
                            ByVal HoraE As String, ByVal HoraS As String, _
                            ByVal Estado As String, ByVal IdUser As String, _
                            ByVal Fecha As String, ByVal Hora As String)
        cmd = DB.GetStoredProcCommand("paInsertaDetHor", IdDet, IdHorario, _
                                        IdDia, Dia, HoraE, HoraS, Estado, _
                                        IdUser, Fecha, Hora)
        DB.ExecuteNonQuery(cmd, Trans)
    End Sub

    Public Sub ActDetalles(ByVal IdHorXAge As String, ByVal Trans As SqlTransaction)
        cmd = DB.GetStoredProcCommand("paEliminaDetHor", Nulo, IdHorXAge, Nulo)
        DB.ExecuteNonQuery(cmd, Trans)

    End Sub

    Public Sub ActualizaHorarioxAgencia(ByVal IdUser As String, ByVal Fecha As String, _
                                        ByVal Hora As String, ByVal IdHorxAge As String, _
                                        ByVal IdHorario As String, ByVal IdAgencia As String, _
                                        ByVal EstHorAge As String, ByVal Trans As SqlTransaction)
        cmd = DB.GetStoredProcCommand("paActualizaHorXAge", IdHorxAge, IdHorario, _
                                        IdAgencia, EstHorAge, IdUser, Fecha, Hora)
        DB.ExecuteNonQuery(cmd, Trans)
    End Sub

    Public Function InsertaHorxAge(ByVal vIdHorario As String, ByVal vIdAgencia As String, _
                                    ByVal HabHorAge As String, ByVal vIdUser As String, _
                                    ByVal vFecha As String, ByVal vHora As String, _
                                    ByVal Trans As SqlTransaction) As String
        cmd = DB.GetStoredProcCommand("paInsertaHorXAge", vIdHorario, vIdAgencia, _
                                        HabHorAge, vIdUser, vFecha, vHora, Nulo)
        DB.ExecuteNonQuery(cmd, Trans)
        InsertaHorxAge = DB.GetParameterValue(cmd, "IDHORXAGE").ToString()
    End Function

    Public Function GetDatosPersonal(ByVal vIdPersona As String) As DataSet
        cmd = DB.GetStoredProcCommand("paGetDatosPersonal", vIdPersona)
        GetDatosPersonal = DB.ExecuteDataSet(cmd)
    End Function

    Public Function CargarHorxEmp(ByVal Muestra As Boolean, ByVal IdPersona As String) As IDataReader
        If Muestra = True Then
            cmd = DB.GetStoredProcCommand("paGetAsigHorxEmp", Nulo, Nulo, Nulo, Nulo, IdPersona, "1")
        Else
            cmd = DB.GetStoredProcCommand("paGetAsigHorxEmp", Nulo, Nulo, Nulo, Nulo, IdPersona, Nulo)
        End If
        CargarHorxEmp = DB.ExecuteReader(cmd)
    End Function

    Public Function InsertaAsigHorxEmp(ByVal vIdHorXAge As String, ByVal vIdPersona As String, _
                                ByVal FechaIni As String, ByVal FechaFin As String, _
                                ByVal Habilita As String, ByVal vIdUser As String, _
                                ByVal vFecha As String, ByVal vHora As String, _
                                ByVal Trans As SqlTransaction) As String
        cmd = DB.GetStoredProcCommand("paInsertaAsigHorxEmp", vIdHorXAge, vIdPersona, _
                                        FechaIni, FechaFin, Habilita, vIdUser, vFecha, vHora, Nulo)
        DB.ExecuteNonQuery(cmd, Trans)
        InsertaAsigHorxEmp = DB.GetParameterValue(cmd, "IDHOREMP").ToString()
    End Function

    Public Function ExisteDetAsigHorxEmp(ByVal IdHorXAge As String, ByVal IdPersona As String, _
                                        ByVal FechaIni As String, ByVal FechaFin As String, _
                                        ByVal IdHorEmp As String) As Boolean
        ExisteDetAsigHorxEmp = False
        cmd = DB.GetStoredProcCommand("paExisteDetAsigHorxEmp", IdHorXAge, IdPersona, FechaIni, FechaFin, IIf(IdHorEmp <> "", IdHorEmp, Nulo))
        ds = DB.ExecuteDataSet(cmd)
        If ds.Tables(0).Rows.Count > 0 Then
            ExisteDetAsigHorxEmp = True
        End If
    End Function

    Public Sub ActualizaAsigHorxEmp(ByVal IdUser As String, ByVal Fecha As String, _
                                        ByVal Hora As String, ByVal IdHorEmp As String, _
                                        ByVal FechaIni As String, ByVal FechaFin As String, _
                                        ByVal Estado As String, ByVal Trans As SqlTransaction)
        cmd = DB.GetStoredProcCommand("paActualizaAsigHorxEmp", IdHorEmp, FechaIni, FechaFin, Estado, IdUser, Fecha, Hora)
        DB.ExecuteNonQuery(cmd, Trans)
    End Sub

    Public Sub ActDetAsigHorxEmp(ByVal IdHorEmp As String, ByVal Trans As SqlTransaction)
        cmd = DB.GetStoredProcCommand("paEliminaDetAsigHorxEmp", Nulo, IdHorEmp, Nulo)
        DB.ExecuteNonQuery(cmd, Trans)
    End Sub

    Public Sub InsertaDetAsigHorxEmp(ByVal IdDet As String, ByVal IdHorEmp As String, _
                        ByVal Trans As SqlTransaction, _
                        ByVal IdDia As String, ByVal Dia As String, _
                        ByVal HoraE As String, ByVal HoraS As String, _
                        ByVal Estado As String, ByVal IdUser As String, _
                        ByVal Fecha As String, ByVal Hora As String)
        cmd = DB.GetStoredProcCommand("paInsertaDetAsigHorxEmp", IdDet, IdHorEmp, _
                                        IdDia, Dia, HoraE, HoraS, Estado, _
                                        IdUser, Fecha, Hora)
        DB.ExecuteNonQuery(cmd, Trans)
    End Sub

    Public Function GetDetAsigHor(ByVal IdHorxAge As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetDetHor", Nulo, IdHorxAge, Nulo, Nulo, Nulo)
        GetDetAsigHor = DB.ExecuteReader(cmd)
    End Function

    Public Function GetDetAsigHorxEmp(ByVal IdHorEmp As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paGetDetAsigHorxEmp", Nulo, IdHorEmp, Nulo, Nulo, Nulo)
        GetDetAsigHorxEmp = DB.ExecuteReader(cmd)
    End Function

    Public Function RepetirHorEmpxDia(ByVal HoraE As String, ByVal HoraS As String, _
                                        ByVal FechaIni As String, ByVal FechaFin As String, _
                                        ByVal IdDia As String, ByVal IdPersona As String, _
                                        ByVal IdHorEmp As String) As IDataReader
        cmd = DB.GetStoredProcCommand("paRepetirHorEmpxDia", HoraE, HoraS, _
                                        FechaIni, FechaFin, _
                                        IdDia, IdPersona, _
                                        IIf(IdHorEmp <> "", IdHorEmp, Nulo))
        RepetirHorEmpxDia = DB.ExecuteReader(cmd)
    End Function

    Public Function RegistrarMarcacion(ByVal Trans As SqlTransaction, ByVal IdPersona As String, _
                                        ByVal IdUser As String, ByVal Medio As String) As String
        RegistrarMarcacion = ""
        cmd = DB.GetStoredProcCommand("paRegistraMarcacion", IdPersona, _
                                        IdUser, Medio, Nulo)
        DB.ExecuteNonQuery(cmd, Trans)
        RegistrarMarcacion = DB.GetParameterValue(cmd, "RESULTADO")
    End Function

    Public Function GetTipoMarcacion() As DataSet
        cmd = DB.GetStoredProcCommand("paGetTipoMarcacion")
        GetTipoMarcacion = DB.ExecuteDataSet(cmd)
    End Function

    Public Function GetJerarquiaPer() As IDataReader
        cmd = DB.GetStoredProcCommand("paGetJerarquiaPer")
        GetJerarquiaPer = DB.ExecuteReader(cmd)
    End Function


End Class
