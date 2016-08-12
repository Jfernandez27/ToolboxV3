Public Class frm_security
    Private Sub frm_security_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = frm_Home.Width - 100
        Height = frm_Home.Height - 120
        'WindowState = FormWindowState.Maximized
        TabControl1.Left = (Width - TabControl1.Width) / 2
        Panel_User.Left = TabControl1.Left
        Panel_Buttons.Left = (Width - Panel_Buttons.Width) / 2
        chkb_all.Left = (TabControl1.Width + TabControl1.Left) - chkb_all.Width
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Close()
    End Sub
    Private Sub chkb_all_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_all.CheckedChanged
        If chkb_all.Checked = True Then
            fCheck(gb_modules, True)
            fCheck(gb_buttons, True)
            fCheck(gb_reports, True)
            fCheck(gb_system, True)
            fCheck(gb_ven, True)
            fCheck(gb_env, True)
            fCheck(gb_cob, True)
            fCheck(gb_inv, True)
            fCheck(gb_adm, True)
            fCheck(gb_ger, True)
            fCheck(gb_01, True)
            fCheck(gb_02, True)
        Else
            fCheck(gb_modules, False)
            fCheck(gb_buttons, False)
            fCheck(gb_reports, False)
            fCheck(gb_system, False)
            fCheck(gb_ven, False)
            fCheck(gb_env, False)
            fCheck(gb_cob, False)
            fCheck(gb_inv, False)
            fCheck(gb_adm, False)
            fCheck(gb_ger, False)
            fCheck(gb_01, False)
            fCheck(gb_02, False)
        End If
    End Sub

    Private Sub chkb_Mod10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Mod10.CheckedChanged
        If chkb_Mod10.Checked = True Then
            fCheck(gb_modules, True)
        Else
            fCheck(gb_modules, False)
        End If
    End Sub

    Private Sub chkb_Bot10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Bot10.CheckedChanged
        If chkb_Bot10.Checked = True Then
            fCheck(gb_buttons, True)
        Else
            fCheck(gb_buttons, False)
        End If
    End Sub

    Private Sub chkb_Rep10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Rep10.CheckedChanged
        If chkb_Rep10.Checked = True Then
            fCheck(gb_reports, True)
        Else
            fCheck(gb_reports, False)
        End If
    End Sub

    Private Sub chkb_Sys10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Sys10.CheckedChanged
        If chkb_Sys10.Checked = True Then
            fCheck(gb_system, True)
        Else
            fCheck(gb_system, False)
        End If
    End Sub

    Private Sub chkb_Ven10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Ven10.CheckedChanged
        If chkb_Ven10.Checked = True Then
            fCheck(gb_ven, True)
        Else
            fCheck(gb_ven, False)
        End If
    End Sub

    Private Sub chkb_Env10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Env10.CheckedChanged
        If chkb_Env10.Checked = True Then
            fCheck(gb_env, True)
        Else
            fCheck(gb_env, False)
        End If
    End Sub

    Private Sub chkb_Cob10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Cob10.CheckedChanged
        If chkb_Cob10.Checked = True Then
            fCheck(gb_cob, True)
        Else
            fCheck(gb_cob, False)
        End If
    End Sub

    Private Sub chkb_Inv10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Inv10.CheckedChanged
        If chkb_Inv10.Checked = True Then
            fCheck(gb_inv, True)
        Else
            fCheck(gb_inv, False)
        End If
    End Sub

    Private Sub chkb_Adm10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Adm10.CheckedChanged
        If chkb_Adm10.Checked = True Then
            fCheck(gb_adm, True)
        Else
            fCheck(gb_adm, False)
        End If
    End Sub

    Private Sub chkb_Ger10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Ger10.CheckedChanged
        If chkb_Ger10.Checked = True Then
            fCheck(gb_ger, True)
        Else
            fCheck(gb_ger, False)
        End If
    End Sub

    Private Sub chkb_SA10_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_SA10.CheckedChanged
        If chkb_SA10.Checked = True Then
            fCheck(gb_01, True)
        Else
            fCheck(gb_01, False)
        End If
    End Sub

    Private Sub chkb_SA20_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_SA20.CheckedChanged
        If chkb_SA20.Checked = True Then
            fCheck(gb_02, True)
        Else
            fCheck(gb_02, False)
        End If
    End Sub

    Private Sub chkb_Mod1_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_Mod1.CheckedChanged
        If chkb_Mod1.Checked = True Then
            gb_ven.Enabled = True
        Else
            gb_ven.Enabled = False
        End If
    End Sub

    Private Sub frm_security_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Width = 880
        Height = 530
        TabControl1.Left = (Width - TabControl1.Width) / 2
        Panel_User.Left = TabControl1.Left
        Panel_Buttons.Left = (Width - Panel_Buttons.Width) / 2
        chkb_all.Left = (TabControl1.Width + TabControl1.Left) - chkb_all.Width
    End Sub
End Class