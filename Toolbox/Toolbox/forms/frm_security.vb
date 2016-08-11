Public Class frm_security
    Private Sub frm_security_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = frm_Home.Width - 100
        Height = frm_Home.Height - 120
        WindowState = FormWindowState.Maximized


    End Sub

    Private Sub chkb_Rep10_Click(sender As Object, e As EventArgs)
        If chkb_Rep10.Checked = True Then
            chkb_Rep1.Checked = True
            chkb_Rep2.Checked = True
            chkb_Rep3.Checked = True
            chkb_Rep4.Checked = True
            chkb_Rep5.Checked = True
            chkb_Rep6.Checked = True
            chkb_Rep7.Checked = True
            chkb_Rep8.Checked = True
            chkb_Rep9.Checked = True
        Else
            chkb_Rep1.Checked = False
            chkb_Rep2.Checked = False
            chkb_Rep3.Checked = False
            chkb_Rep4.Checked = False
            chkb_Rep5.Checked = False
            chkb_Rep6.Checked = False
            chkb_Rep7.Checked = False
            chkb_Rep8.Checked = False
            chkb_Rep9.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Close()
    End Sub
End Class