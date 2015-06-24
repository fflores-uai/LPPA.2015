Imports System.IO



Public Class FSW

    Private WithEvents elFSW As IO.FileSystemWatcher

    Public Event ArchivoCreado(ByVal FullPath As String)
    Public Event ArchivoEliminado(ByVal FilePath As String)
    Public Event ArchivoCambiado(ByVal FullPath As String)
    Public Event ArchivoRenombrado(ByVal OldFileName As String, ByVal newFileName As String)
    Public Event ErrorMonitoreo(ByVal ErrMsg As String)





    Public Sub New()

        elFSW = New IO.FileSystemWatcher()
        'Watch all changes
        elFSW.NotifyFilter = IO.NotifyFilters.Attributes Or _
                                           IO.NotifyFilters.CreationTime Or _
                                           IO.NotifyFilters.DirectoryName Or _
                                           IO.NotifyFilters.FileName Or _
                                           IO.NotifyFilters.LastWrite Or _
                                           IO.NotifyFilters.Security Or _
                                           IO.NotifyFilters.Size


        elFSW.Filter = filtro


    End Sub

    Public Property directorio As String
        Get
            directorio = elFSW.Path
        End Get
        Set(ByVal Value As String)
            If Right(Value, 1) <> "\" Then Value = Value & "\"
            If IO.Directory.Exists(Value) Then
                elFSW.Path = Value
            End If
        End Set
    End Property

    Public Property incluirSubcarpetas As Boolean
        Get
            incluirSubcarpetas = elFSW.IncludeSubdirectories
        End Get
        Set(ByVal Value As Boolean)
            elFSW.IncludeSubdirectories = Value
        End Set
    End Property

    Public Property filtro As String
        Get
            filtro = elFSW.Filter
        End Get
        Set(ByVal Value As String)
            elFSW.Filter = Value
        End Set
    End Property




    Public Function Iniciar() As Boolean
        Dim res As Boolean = False
        Try
            elFSW.EnableRaisingEvents = True
            res = True
        Catch ex As Exception
            RaiseEvent ErrorMonitoreo(ex.Message)
        End Try
        Return res
    End Function

    Public Function Detener() As Boolean
        Dim res As Boolean = False
        Try
            elFSW.EnableRaisingEvents = False
            res = True
        Catch ex As Exception
            RaiseEvent ErrorMonitoreo(ex.Message)
        End Try
        Return res
    End Function


    Private Sub FSW_ArchivoCreado(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles elFSW.Created
        RaiseEvent ArchivoCreado(e.FullPath)
    End Sub

    Private Sub FSW_ArchivoCambiado(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles elFSW.Changed
        RaiseEvent ArchivoCambiado(e.FullPath)
    End Sub

    Private Sub FSW_ArchivoEliminado(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles elFSW.Deleted
        RaiseEvent ArchivoEliminado(e.FullPath)
    End Sub

    Private Sub FSW_ArchivoRenombrado(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles elFSW.Renamed
        RaiseEvent ArchivoRenombrado(e.OldFullPath, e.FullPath)
    End Sub

    Private Sub FSW_ErrorMonitoreo(ByVal sender As Object, ByVal e As System.IO.ErrorEventArgs) Handles elFSW.Error
        RaiseEvent ErrorMonitoreo(e.GetException.Message)
    End Sub
End Class
