Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module main
    'Constantes
    Public cpPCName As String = My.Computer.Name.ToString
    Public cpRuta As String = Application.StartupPath

    'Variables
    Public vpOption As String = Nothing

    'Cadenas de Conexión
    Public vStrCnnToolbox As String = My.Settings.MySQLCnnToolbox
    Public vStrCnnPedidos As String = My.Settings.MySQLCnnPedidos
    Public vStrCnnFuerzaV As String = My.Settings.MySQLCnnFuerza
    Public vStrCnnCorp As String = My.Settings.SQLCnnCorp
    Public vStrCnnSusp As String = My.Settings.SQLCnnSusp
End Module
