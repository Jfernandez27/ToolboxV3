Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module functions
    Public Function fSecurity(vPc As String, vId As Integer)
        Dim vOpt As Integer = Nothing
        Dim vCar As Integer = Nothing
        If vId <> 0 Then
            vOpt = 2
        Else
            vOpt = 1
        End If
        Dim vClass As New cls_security
        Dim vData As String = vClass.fAuth(vOpt, vId, vPc)
        If vData <> "0" Then
            For i = 1 To vData.Length
                vCar = Mid(vData, i, 1)
                Select Case i
                    Case 1
                        If vCar = 1 Then frm_Home.ParámetrosToolStripMenuItem.Enabled = True
                    Case 2
                        If vCar = 1 Then frm_Home.SeguridadToolStripMenuItem.Enabled = True
                    Case 3
                        If vCar = 1 Then frm_Home.UsuariosToolStripMenuItem.Enabled = True
                    Case 4
                        If vCar = 1 Then frm_Home.DatosToolStripMenuItem.Enabled = True
                    Case 5
                        If vCar = 1 Then frm_Home.Sistema5ToolStripMenuItem.Enabled = True
                    Case 6
                        If vCar = 1 Then frm_Home.Sistema6ToolStripMenuItem.Enabled = True
                    Case 7
                        If vCar = 1 Then frm_Home.Sistema7ToolStripMenuItem.Enabled = True
                    Case 8
                        If vCar = 1 Then frm_Home.Sistema8ToolStripMenuItem.Enabled = True
                    Case 9
                        If vCar = 1 Then frm_Home.Sistema9ToolStripMenuItem.Enabled = True
                    Case 10
                        If vCar = 1 Then
                            'Sistema
                            frm_Home.ParámetrosToolStripMenuItem.Enabled = True
                            frm_Home.SeguridadToolStripMenuItem.Enabled = True
                            frm_Home.UsuariosToolStripMenuItem.Enabled = True
                            frm_Home.DatosToolStripMenuItem.Enabled = True
                            frm_Home.Sistema5ToolStripMenuItem.Enabled = True
                            frm_Home.Sistema6ToolStripMenuItem.Enabled = True
                            frm_Home.Sistema7ToolStripMenuItem.Enabled = True
                            frm_Home.Sistema8ToolStripMenuItem.Enabled = True
                            frm_Home.Sistema9ToolStripMenuItem.Enabled = True

                            'Ventas
                            frm_Home.PedidosWebToolStripMenuItem.Enabled = True
                            frm_Home.PedidosProcesadosToolStripMenuItem1.Enabled = True
                            frm_Home.Ventas3ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas4ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas5ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas6ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas7ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas8ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas9ToolStripMenuItem.Enabled = True

                            'Botones
                            frm_Home.SistemaToolStripMenuItem.Enabled = True
                            frm_Home.InventarioToolStripMenuItem.Enabled = True
                            frm_Home.VentasToolStripMenuItem.Enabled = True
                            frm_Home.EnviosToolStripMenuItem.Enabled = True
                            frm_Home.CobranzasToolStripMenuItem.Enabled = True
                            frm_Home.GerencialToolStripMenuItem.Enabled = True
                            Return Nothing
                            Exit Function
                        End If
                    Case 11
                        If vCar = 1 Then frm_Home.PedidosWebToolStripMenuItem.Enabled = True
                    Case 12
                        If vCar = 1 Then frm_Home.PedidosProcesadosToolStripMenuItem1.Enabled = True
                    Case 13
                        If vCar = 1 Then frm_Home.Ventas3ToolStripMenuItem.Enabled = True
                    Case 14
                        If vCar = 1 Then frm_Home.Ventas4ToolStripMenuItem.Enabled = True
                    Case 15
                        If vCar = 1 Then frm_Home.Ventas5ToolStripMenuItem.Enabled = True
                    Case 16
                        If vCar = 1 Then frm_Home.Ventas6ToolStripMenuItem.Enabled = True
                    Case 17
                        If vCar = 1 Then frm_Home.Ventas7ToolStripMenuItem.Enabled = True
                    Case 18
                        If vCar = 1 Then frm_Home.Ventas8ToolStripMenuItem.Enabled = True
                    Case 19
                        If vCar = 1 Then frm_Home.Ventas9ToolStripMenuItem.Enabled = True
                    Case 20
                        If vCar = 1 Then
                            frm_Home.Ventas3ToolStripMenuItem.Enabled = True
                            frm_Home.PedidosProcesadosToolStripMenuItem1.Enabled = True
                            frm_Home.Ventas3ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas4ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas5ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas6ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas7ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas8ToolStripMenuItem.Enabled = True
                            frm_Home.Ventas9ToolStripMenuItem.Enabled = True
                        End If
                    Case 21
                    Case 22
                    Case 23
                    Case 24
                    Case 25
                    Case 26
                    Case 27
                    Case 28
                    Case 29
                    Case 30
                    Case 31
                    Case 32
                    Case 33
                    Case 34
                    Case 35
                    Case 36
                    Case 37
                    Case 38
                    Case 39
                    Case 40
                    Case 41
                    Case 42
                    Case 43
                    Case 44
                    Case 45
                    Case 46
                    Case 47
                    Case 48
                    Case 49
                    Case 50
                    Case 51
                    Case 52
                    Case 53
                    Case 54
                    Case 55
                    Case 56
                    Case 57
                    Case 58
                    Case 59
                    Case 60
                    Case 61
                    Case 62
                    Case 63
                    Case 64
                    Case 65
                    Case 66
                    Case 67
                    Case 68
                    Case 69
                    Case 70
                    Case 71
                        If vCar = 1 Then frm_Home.SistemaToolStripMenuItem.Enabled = True
                    Case 72
                        If vCar = 1 Then frm_Home.InventarioToolStripMenuItem.Enabled = True
                    Case 73
                        If vCar = 1 Then frm_Home.VentasToolStripMenuItem.Enabled = True
                    Case 74
                    Case 75
                    Case 76
                    Case 77
                End Select
            Next
        End If
        Return Nothing
    End Function
End Module
