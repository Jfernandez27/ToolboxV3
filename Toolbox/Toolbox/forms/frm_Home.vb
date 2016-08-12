Public Class frm_Home
    Private Sub frm_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        tssl_UserName.Text = "USUARIO: " & Environment.UserName.ToUpper
        tssl_PCName.Text = "EQUIPO: " & cpPCName.ToUpper '& "Tamaño " & Me.Size.ToString
        fSecurity(1, cpPCName, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tssl_time.Text = Format(Date.Now(), "g")
    End Sub

    Private Sub tssl_UserName_Click(sender As Object, e As EventArgs) Handles tssl_UserName.Click
        'Código para ver/modificar información del usuario
        MsgBox("Hola")
    End Sub
    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub tsmi_sys3_Click(sender As Object, e As EventArgs) Handles tsmi_sys3.Click
        Dim vForm As New frm_security
        vForm.MdiParent = Me
        vForm.Show()
        vForm.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class
