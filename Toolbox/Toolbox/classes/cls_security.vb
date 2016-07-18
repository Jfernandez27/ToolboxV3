Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Public Class cls_security
    Private pOption As String
    Private pPCName As String
    Private pIDUser As Integer
    Private pAuth As Boolean
    Public Property ppOption() As String
        Get
            Return pOption
        End Get
        Set(ByVal value As String)
            If String.IsNullOrEmpty(value) Then
                Throw New ArgumentException("Error en la Opción (MySQL)")
            Else
                pOption = value
            End If
        End Set
    End Property
    Public Property ppPCName() As String
        Get
            Return pPCName
        End Get
        Set(ByVal value As String)
            If String.IsNullOrEmpty(value) Then
                Throw New ArgumentException("Error en el Nombre de la PC (MySQL)")
            Else
                pPCName = value
            End If
        End Set
    End Property
    Public Property ppIDUser() As Integer
        Get
            Return pIDUser
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                Throw New ArgumentException("Error en el Id del Usuario (MySQL)")
            Else
                pIDUser = value
            End If
        End Set
    End Property

    Public Property ppAuth() As String
        Get
            Return pAuth
        End Get
        Set(ByVal value As String)
            If String.IsNullOrEmpty(value) Then
                Throw New ArgumentException("Error en la Seguridad (MySQL)")
            Else
                pAuth = value
            End If
        End Set
    End Property
    Public Function fAuth(ByVal vOpt As String, vIdUs As Integer, vPC As String) As String
        Using vCn As New MySqlConnection
            vCn.ConnectionString = vStrCnnToolbox

            Using vCm As New MySqlCommand
                vCm.Connection = vCn
                vCm.CommandType = CommandType.Text
                vCm.CommandText = "CALL pas_security(" & vOpt.ToString & "," & vIdUs.ToString & ",'" & vPC & "')"
                vCn.Open()
                fAuth = vCm.ExecuteScalar
                If String.IsNullOrEmpty(fAuth) Then fAuth = "0"
            End Using
        End Using
    End Function
End Class
