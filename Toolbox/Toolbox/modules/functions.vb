Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module functions
    Public Function fSecurity(vOpt As Integer, vPCName As String, vIdUser As Integer)
        Dim vCar As Integer = Nothing
        Dim vClass As New cls_security
        Dim vData As String = vClass.fAuth(vOpt, vIdUser, vPCName)
        If vData <> "0" Then
            For i = 1 To vData.Length
                vCar = Mid(vData, i, 1)
                Select Case i
                    Case 1 'Modulo de Ventas
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas, False)
                        End If
                    Case 2 'Modulo de Envíos
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios, True)
                        Else
                            fEnable(frm_Home.tsmi_envios, False)
                        End If
                    Case 3 'Modulo de Cobranzas
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros, False)
                        End If
                    Case 4 'Modulo de Inventario
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario, False)
                        End If
                    Case 5 'Modulo de Administración
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin, True)
                        Else
                            fEnable(frm_Home.tsmi_admin, False)
                        End If
                    Case 6 'Modulo de Información Gerencial
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia, False)
                        End If
                    Case 7 'Sin Asignar
                    Case 8 'Sin Asignar
                    Case 9 'Modulo de Sistema
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys, True)
                        Else
                            fEnable(frm_Home.tsmi_sys, False)
                        End If
                    Case 10 'Todos los Modulos
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas, True)
                            fEnable(frm_Home.tsmi_envios, True)
                            fEnable(frm_Home.tsmi_cobros, True)
                            fEnable(frm_Home.tsmi_inventario, True)
                            fEnable(frm_Home.tsmi_admin, True)
                            fEnable(frm_Home.tsmi_gerencia, True)
                            fEnable(frm_Home.tsmi_sys, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas, False)
                            fEnable(frm_Home.tsmi_envios, False)
                            fEnable(frm_Home.tsmi_cobros, False)
                            fEnable(frm_Home.tsmi_inventario, False)
                            fEnable(frm_Home.tsmi_admin, False)
                            fEnable(frm_Home.tsmi_gerencia, False)
                            fEnable(frm_Home.tsmi_sys, False)
                        End If
                    Case 11 'Boton Sincronizador
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_bsync, True)
                        Else
                            fEnable(frm_Home.tsmi_bsync, False)
                        End If
                    Case 12 'Boton Inventario
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_binv, True)
                        Else
                            fEnable(frm_Home.tsmi_binv, False)
                        End If
                    Case 13 'Boton Pedidos
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_bpedido, True)
                        Else
                            fEnable(frm_Home.tsmi_bpedido, False)
                        End If
                    Case 14 'Boton Envíos
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_benv, True)
                        Else
                            fEnable(frm_Home.tsmi_benv, False)
                        End If
                    Case 15 'Boton Cobranzas
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_bcob, True)
                        Else
                            fEnable(frm_Home.tsmi_bcob, False)
                        End If
                    Case 16 'Boton Gerencia
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_bger, True)
                        Else
                            fEnable(frm_Home.tsmi_bger, False)
                        End If
                    Case 17 'Sin Asignar
                    Case 18 'Sin Asignar
                    Case 19 'Sin Asignar
                    Case 20 'Todos los Botones
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_bsync, True)
                            fEnable(frm_Home.tsmi_binv, True)
                            fEnable(frm_Home.tsmi_bpedido, True)
                            fEnable(frm_Home.tsmi_benv, True)
                            fEnable(frm_Home.tsmi_bcob, True)
                            fEnable(frm_Home.tsmi_bger, True)
                        Else
                            fEnable(frm_Home.tsmi_bsync, False)
                            fEnable(frm_Home.tsmi_binv, False)
                            fEnable(frm_Home.tsmi_bpedido, False)
                            fEnable(frm_Home.tsmi_benv, False)
                            fEnable(frm_Home.tsmi_bcob, False)
                            fEnable(frm_Home.tsmi_bger, False)
                        End If
                    'Opciones del Modulo de Sistemas
                    Case 21
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys1, True)
                        Else
                            fEnable(frm_Home.tsmi_sys1, False)
                        End If
                    Case 22
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys2, True)
                        Else
                            fEnable(frm_Home.tsmi_sys2, False)
                        End If
                    Case 23
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys3, True)
                        Else
                            fEnable(frm_Home.tsmi_sys3, False)
                        End If
                    Case 24
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys4, True)
                        Else
                            fEnable(frm_Home.tsmi_sys4, False)
                        End If
                    Case 25
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys5, True)
                        Else
                            fEnable(frm_Home.tsmi_sys5, False)
                        End If
                    Case 26
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys6, True)
                        Else
                            fEnable(frm_Home.tsmi_sys6, False)
                        End If
                    Case 27
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys7, True)
                        Else
                            fEnable(frm_Home.tsmi_sys7, False)
                        End If
                    Case 28
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys8, True)
                        Else
                            fEnable(frm_Home.tsmi_sys8, False)
                        End If
                    Case 29
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys9, True)
                        Else
                            fEnable(frm_Home.tsmi_sys9, False)
                        End If
                    Case 30
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_sys1, True)
                            fEnable(frm_Home.tsmi_sys2, True)
                            fEnable(frm_Home.tsmi_sys3, True)
                            fEnable(frm_Home.tsmi_sys4, True)
                            fEnable(frm_Home.tsmi_sys5, True)
                            fEnable(frm_Home.tsmi_sys6, True)
                            fEnable(frm_Home.tsmi_sys7, True)
                            fEnable(frm_Home.tsmi_sys8, True)
                            fEnable(frm_Home.tsmi_sys9, True)
                        Else
                            fEnable(frm_Home.tsmi_sys1, False)
                            fEnable(frm_Home.tsmi_sys2, False)
                            fEnable(frm_Home.tsmi_sys3, False)
                            fEnable(frm_Home.tsmi_sys4, False)
                            fEnable(frm_Home.tsmi_sys5, False)
                            fEnable(frm_Home.tsmi_sys6, False)
                            fEnable(frm_Home.tsmi_sys7, False)
                            fEnable(frm_Home.tsmi_sys8, False)
                            fEnable(frm_Home.tsmi_sys9, False)
                        End If
                    'Opciones del Modulo de Ventas
                    Case 31
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas1, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas1, False)
                        End If
                    Case 32
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas2, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas2, False)
                        End If
                    Case 33
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas3, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas3, False)
                        End If
                    Case 34
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas4, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas4, False)
                        End If
                    Case 35
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas5, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas5, False)
                        End If
                    Case 36
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas6, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas6, False)
                        End If
                    Case 37
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas7, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas7, False)
                        End If
                    Case 38
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas8, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas8, False)
                        End If
                    Case 39
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas9, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas9, False)
                        End If
                    Case 40
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_ventas1, True)
                            fEnable(frm_Home.tsmi_ventas2, True)
                            fEnable(frm_Home.tsmi_ventas3, True)
                            fEnable(frm_Home.tsmi_ventas4, True)
                            fEnable(frm_Home.tsmi_ventas5, True)
                            fEnable(frm_Home.tsmi_ventas6, True)
                            fEnable(frm_Home.tsmi_ventas7, True)
                            fEnable(frm_Home.tsmi_ventas8, True)
                            fEnable(frm_Home.tsmi_ventas9, True)
                        Else
                            fEnable(frm_Home.tsmi_ventas1, False)
                            fEnable(frm_Home.tsmi_ventas2, False)
                            fEnable(frm_Home.tsmi_ventas3, False)
                            fEnable(frm_Home.tsmi_ventas4, False)
                            fEnable(frm_Home.tsmi_ventas5, False)
                            fEnable(frm_Home.tsmi_ventas6, False)
                            fEnable(frm_Home.tsmi_ventas7, False)
                            fEnable(frm_Home.tsmi_ventas8, False)
                            fEnable(frm_Home.tsmi_ventas9, False)
                        End If
                        'Opciones del Modulo de Inventario
                    Case 41
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario1, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario1, False)
                        End If
                    Case 42
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario2, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario2, False)
                        End If
                    Case 43
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario3, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario3, False)
                        End If
                    Case 44
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario4, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario4, False)
                        End If
                    Case 45
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario5, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario5, False)
                        End If
                    Case 46
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario6, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario6, False)
                        End If
                    Case 47
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario7, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario7, False)
                        End If
                    Case 48
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario8, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario8, False)
                        End If
                    Case 49
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario9, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario9, False)
                        End If
                    Case 50
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_inventario1, True)
                            fEnable(frm_Home.tsmi_inventario2, True)
                            fEnable(frm_Home.tsmi_inventario3, True)
                            fEnable(frm_Home.tsmi_inventario4, True)
                            fEnable(frm_Home.tsmi_inventario5, True)
                            fEnable(frm_Home.tsmi_inventario6, True)
                            fEnable(frm_Home.tsmi_inventario7, True)
                            fEnable(frm_Home.tsmi_inventario8, True)
                            fEnable(frm_Home.tsmi_inventario9, True)
                        Else
                            fEnable(frm_Home.tsmi_inventario1, False)
                            fEnable(frm_Home.tsmi_inventario2, False)
                            fEnable(frm_Home.tsmi_inventario3, False)
                            fEnable(frm_Home.tsmi_inventario4, False)
                            fEnable(frm_Home.tsmi_inventario5, False)
                            fEnable(frm_Home.tsmi_inventario6, False)
                            fEnable(frm_Home.tsmi_inventario7, False)
                            fEnable(frm_Home.tsmi_inventario8, False)
                            fEnable(frm_Home.tsmi_inventario9, False)
                        End If
                        'Opciones del Modulo de Envios
                    Case 51
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios1, True)
                        Else
                            fEnable(frm_Home.tsmi_envios1, False)
                        End If
                    Case 52
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios2, True)
                        Else
                            fEnable(frm_Home.tsmi_envios2, False)
                        End If
                    Case 53
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios3, True)
                        Else
                            fEnable(frm_Home.tsmi_envios3, False)
                        End If
                    Case 54
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios4, True)
                        Else
                            fEnable(frm_Home.tsmi_envios4, False)
                        End If
                    Case 55
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios5, True)
                        Else
                            fEnable(frm_Home.tsmi_envios5, False)
                        End If
                    Case 56
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios6, True)
                        Else
                            fEnable(frm_Home.tsmi_envios6, False)
                        End If
                    Case 57
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios7, True)
                        Else
                            fEnable(frm_Home.tsmi_envios7, False)
                        End If
                    Case 58
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios8, True)
                        Else
                            fEnable(frm_Home.tsmi_envios8, False)
                        End If
                    Case 59
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios9, True)
                        Else
                            fEnable(frm_Home.tsmi_envios9, False)
                        End If
                    Case 60
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_envios1, True)
                            fEnable(frm_Home.tsmi_envios2, True)
                            fEnable(frm_Home.tsmi_envios3, True)
                            fEnable(frm_Home.tsmi_envios4, True)
                            fEnable(frm_Home.tsmi_envios5, True)
                            fEnable(frm_Home.tsmi_envios6, True)
                            fEnable(frm_Home.tsmi_envios7, True)
                            fEnable(frm_Home.tsmi_envios8, True)
                            fEnable(frm_Home.tsmi_envios9, True)
                        Else
                            fEnable(frm_Home.tsmi_envios1, False)
                            fEnable(frm_Home.tsmi_envios2, False)
                            fEnable(frm_Home.tsmi_envios3, False)
                            fEnable(frm_Home.tsmi_envios4, False)
                            fEnable(frm_Home.tsmi_envios5, False)
                            fEnable(frm_Home.tsmi_envios6, False)
                            fEnable(frm_Home.tsmi_envios7, False)
                            fEnable(frm_Home.tsmi_envios8, False)
                            fEnable(frm_Home.tsmi_envios9, False)
                        End If
                        'Opciones del Modulo de Cobranza
                    Case 61
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros1, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros1, False)
                        End If
                    Case 62
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros2, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros2, False)
                        End If
                    Case 63
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros3, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros3, False)
                        End If
                    Case 64
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros4, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros4, False)
                        End If
                    Case 65
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros5, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros5, False)
                        End If
                    Case 66
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros6, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros6, False)
                        End If
                    Case 67
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros7, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros7, False)
                        End If
                    Case 68
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros8, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros8, False)
                        End If
                    Case 69
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros9, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros9, False)
                        End If
                    Case 70
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_cobros1, True)
                            fEnable(frm_Home.tsmi_cobros2, True)
                            fEnable(frm_Home.tsmi_cobros3, True)
                            fEnable(frm_Home.tsmi_cobros4, True)
                            fEnable(frm_Home.tsmi_cobros5, True)
                            fEnable(frm_Home.tsmi_cobros6, True)
                            fEnable(frm_Home.tsmi_cobros7, True)
                            fEnable(frm_Home.tsmi_cobros8, True)
                            fEnable(frm_Home.tsmi_cobros9, True)
                        Else
                            fEnable(frm_Home.tsmi_cobros1, False)
                            fEnable(frm_Home.tsmi_cobros2, False)
                            fEnable(frm_Home.tsmi_cobros3, False)
                            fEnable(frm_Home.tsmi_cobros4, False)
                            fEnable(frm_Home.tsmi_cobros5, False)
                            fEnable(frm_Home.tsmi_cobros6, False)
                            fEnable(frm_Home.tsmi_cobros7, False)
                            fEnable(frm_Home.tsmi_cobros8, False)
                            fEnable(frm_Home.tsmi_cobros9, False)
                        End If
                        'Opciones del Modulo de Adminisatración
                    Case 71
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin1, True)
                        Else
                            fEnable(frm_Home.tsmi_admin1, False)
                        End If
                    Case 72
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin2, True)
                        Else
                            fEnable(frm_Home.tsmi_admin2, False)
                        End If
                    Case 73
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin3, True)
                        Else
                            fEnable(frm_Home.tsmi_admin3, False)
                        End If
                    Case 74
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin4, True)
                        Else
                            fEnable(frm_Home.tsmi_admin4, False)
                        End If
                    Case 75
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin5, True)
                        Else
                            fEnable(frm_Home.tsmi_admin5, False)
                        End If
                    Case 76
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin6, True)
                        Else
                            fEnable(frm_Home.tsmi_admin6, False)
                        End If
                    Case 77
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin7, True)
                        Else
                            fEnable(frm_Home.tsmi_admin7, False)
                        End If
                    Case 78
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin8, True)
                        Else
                            fEnable(frm_Home.tsmi_admin8, False)
                        End If
                    Case 79
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin9, True)
                        Else
                            fEnable(frm_Home.tsmi_admin9, False)
                        End If
                    Case 80
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_admin1, True)
                            fEnable(frm_Home.tsmi_admin2, True)
                            fEnable(frm_Home.tsmi_admin3, True)
                            fEnable(frm_Home.tsmi_admin4, True)
                            fEnable(frm_Home.tsmi_admin5, True)
                            fEnable(frm_Home.tsmi_admin6, True)
                            fEnable(frm_Home.tsmi_admin7, True)
                            fEnable(frm_Home.tsmi_admin8, True)
                            fEnable(frm_Home.tsmi_admin9, True)
                        Else
                            fEnable(frm_Home.tsmi_admin1, False)
                            fEnable(frm_Home.tsmi_admin2, False)
                            fEnable(frm_Home.tsmi_admin3, False)
                            fEnable(frm_Home.tsmi_admin4, False)
                            fEnable(frm_Home.tsmi_admin5, False)
                            fEnable(frm_Home.tsmi_admin6, False)
                            fEnable(frm_Home.tsmi_admin7, False)
                            fEnable(frm_Home.tsmi_admin8, False)
                            fEnable(frm_Home.tsmi_admin9, False)
                        End If
                        'Opciones del Modulo de Gerencia
                    Case 81
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia1, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia1, False)
                        End If
                    Case 82
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia2, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia2, False)
                        End If
                    Case 83
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia3, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia3, False)
                        End If
                    Case 84
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia4, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia4, False)
                        End If
                    Case 85
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia5, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia5, False)
                        End If
                    Case 86
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia6, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia6, False)
                        End If
                    Case 87
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia7, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia7, False)
                        End If
                    Case 88
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia8, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia8, False)
                        End If
                    Case 89
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia9, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia9, False)
                        End If
                    Case 90
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_gerencia1, True)
                            fEnable(frm_Home.tsmi_gerencia2, True)
                            fEnable(frm_Home.tsmi_gerencia3, True)
                            fEnable(frm_Home.tsmi_gerencia4, True)
                            fEnable(frm_Home.tsmi_gerencia5, True)
                            fEnable(frm_Home.tsmi_gerencia6, True)
                            fEnable(frm_Home.tsmi_gerencia7, True)
                            fEnable(frm_Home.tsmi_gerencia8, True)
                            fEnable(frm_Home.tsmi_gerencia9, True)
                        Else
                            fEnable(frm_Home.tsmi_gerencia1, False)
                            fEnable(frm_Home.tsmi_gerencia2, False)
                            fEnable(frm_Home.tsmi_gerencia3, False)
                            fEnable(frm_Home.tsmi_gerencia4, False)
                            fEnable(frm_Home.tsmi_gerencia5, False)
                            fEnable(frm_Home.tsmi_gerencia6, False)
                            fEnable(frm_Home.tsmi_gerencia7, False)
                            fEnable(frm_Home.tsmi_gerencia8, False)
                            fEnable(frm_Home.tsmi_gerencia9, False)
                        End If
                        'Opciones del Modulo de Report
                    Case 91
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report1, True)
                        Else
                            fEnable(frm_Home.tsmi_Report1, False)
                        End If
                    Case 92
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report2, True)
                        Else
                            fEnable(frm_Home.tsmi_Report2, False)
                        End If
                    Case 93
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report3, True)
                        Else
                            fEnable(frm_Home.tsmi_Report3, False)
                        End If
                    Case 94
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report4, True)
                        Else
                            fEnable(frm_Home.tsmi_Report4, False)
                        End If
                    Case 95
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report5, True)
                        Else
                            fEnable(frm_Home.tsmi_Report5, False)
                        End If
                    Case 96
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report6, True)
                        Else
                            fEnable(frm_Home.tsmi_Report6, False)
                        End If
                    Case 97
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report7, True)
                        Else
                            fEnable(frm_Home.tsmi_Report7, False)
                        End If
                    Case 98
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report8, True)
                        Else
                            fEnable(frm_Home.tsmi_Report8, False)
                        End If
                    Case 99
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report9, True)
                        Else
                            fEnable(frm_Home.tsmi_Report9, False)
                        End If
                    Case 100
                        If vCar = 1 Then
                            fEnable(frm_Home.tsmi_Report1, True)
                            fEnable(frm_Home.tsmi_Report2, True)
                            fEnable(frm_Home.tsmi_Report3, True)
                            fEnable(frm_Home.tsmi_Report4, True)
                            fEnable(frm_Home.tsmi_Report5, True)
                            fEnable(frm_Home.tsmi_Report6, True)
                            fEnable(frm_Home.tsmi_Report7, True)
                            fEnable(frm_Home.tsmi_Report8, True)
                            fEnable(frm_Home.tsmi_Report9, True)
                        Else
                            fEnable(frm_Home.tsmi_Report1, False)
                            fEnable(frm_Home.tsmi_Report2, False)
                            fEnable(frm_Home.tsmi_Report3, False)
                            fEnable(frm_Home.tsmi_Report4, False)
                            fEnable(frm_Home.tsmi_Report5, False)
                            fEnable(frm_Home.tsmi_Report6, False)
                            fEnable(frm_Home.tsmi_Report7, False)
                            fEnable(frm_Home.tsmi_Report8, False)
                            fEnable(frm_Home.tsmi_Report9, False)
                        End If
                End Select
            Next
        End If
        Return Nothing
    End Function
    Public Function fEnable(vObj As Object, vAction As Boolean)
        Dim vMnuIt As ToolStripMenuItem = vObj
        vMnuIt.Enabled = vAction
        If vMnuIt.Tag <> "Sin Asignar" Then
            vMnuIt.Visible = vAction
        End If
        Return Nothing
    End Function
    Public Function fCheck(vCtrlContainer As Object, Action As Boolean)
        Dim vCtrl As CheckBox = Nothing
        For Each Ctr As Control In vCtrlContainer.Controls
            If TypeOf Ctr Is CheckBox Then
                vCtrl = Ctr
                vCtrl.Checked = Action
                vCtrl = Nothing
            End If
        Next
        Return Nothing
    End Function
End Module
