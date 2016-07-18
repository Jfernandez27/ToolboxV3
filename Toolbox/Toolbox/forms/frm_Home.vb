Public Class frm_Home
    Private Sub frm_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        tssl_UserName.Text = "USUARIO: " & Environment.UserName.ToUpper
        tssl_PCName.Text = "EQUIPO: " & cpPCName.ToUpper
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tssl_time.Text = Format(Date.Now(), "G")
    End Sub
End Class
