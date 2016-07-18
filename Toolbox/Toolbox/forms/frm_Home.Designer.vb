<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Home
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Home))
        Me.mnu_buttons = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobranzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_main = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MódulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sst_main = New System.Windows.Forms.StatusStrip()
        Me.tssl_PCName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tssl_UserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_espacer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssl_spacer2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnu_buttons.SuspendLayout()
        Me.mnu_main.SuspendLayout()
        Me.sst_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_buttons
        '
        Me.mnu_buttons.ImageScalingSize = New System.Drawing.Size(72, 72)
        Me.mnu_buttons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.EnviosToolStripMenuItem, Me.CobranzasToolStripMenuItem})
        Me.mnu_buttons.Location = New System.Drawing.Point(0, 25)
        Me.mnu_buttons.Name = "mnu_buttons"
        Me.mnu_buttons.Size = New System.Drawing.Size(1264, 80)
        Me.mnu_buttons.TabIndex = 1
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SistemaToolStripMenuItem.Image = CType(resources.GetObject("SistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(84, 76)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventarioToolStripMenuItem.Image = CType(resources.GetObject("InventarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(84, 76)
        Me.InventarioToolStripMenuItem.Tag = "Inventario"
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VentasToolStripMenuItem.Image = CType(resources.GetObject("VentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(84, 76)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'EnviosToolStripMenuItem
        '
        Me.EnviosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EnviosToolStripMenuItem.Image = CType(resources.GetObject("EnviosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnviosToolStripMenuItem.Name = "EnviosToolStripMenuItem"
        Me.EnviosToolStripMenuItem.Size = New System.Drawing.Size(84, 76)
        Me.EnviosToolStripMenuItem.Text = "Envios"
        '
        'CobranzasToolStripMenuItem
        '
        Me.CobranzasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CobranzasToolStripMenuItem.Image = CType(resources.GetObject("CobranzasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CobranzasToolStripMenuItem.Name = "CobranzasToolStripMenuItem"
        Me.CobranzasToolStripMenuItem.Size = New System.Drawing.Size(84, 76)
        Me.CobranzasToolStripMenuItem.Text = "Cobranzas"
        '
        'mnu_main
        '
        Me.mnu_main.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem1, Me.MódulosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.mnu_main.Location = New System.Drawing.Point(0, 0)
        Me.mnu_main.Name = "mnu_main"
        Me.mnu_main.Size = New System.Drawing.Size(1264, 25)
        Me.mnu_main.TabIndex = 2
        '
        'SistemaToolStripMenuItem1
        '
        Me.SistemaToolStripMenuItem1.Name = "SistemaToolStripMenuItem1"
        Me.SistemaToolStripMenuItem1.Size = New System.Drawing.Size(67, 21)
        Me.SistemaToolStripMenuItem1.Text = "Sistema"
        '
        'MódulosToolStripMenuItem
        '
        Me.MódulosToolStripMenuItem.Name = "MódulosToolStripMenuItem"
        Me.MódulosToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.MódulosToolStripMenuItem.Text = "Módulos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'sst_main
        '
        Me.sst_main.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sst_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssl_espacer, Me.tssl_UserName, Me.tssl_PCName, Me.tssl_time, Me.tssl_spacer2})
        Me.sst_main.Location = New System.Drawing.Point(0, 669)
        Me.sst_main.Name = "sst_main"
        Me.sst_main.Size = New System.Drawing.Size(1264, 22)
        Me.sst_main.TabIndex = 3
        '
        'tssl_PCName
        '
        Me.tssl_PCName.BackColor = System.Drawing.Color.Transparent
        Me.tssl_PCName.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.tssl_PCName.Name = "tssl_PCName"
        Me.tssl_PCName.Size = New System.Drawing.Size(64, 18)
        Me.tssl_PCName.Text = "PC Name"
        '
        'tssl_time
        '
        Me.tssl_time.BackColor = System.Drawing.Color.Transparent
        Me.tssl_time.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.tssl_time.Name = "tssl_time"
        Me.tssl_time.Size = New System.Drawing.Size(37, 18)
        Me.tssl_time.Text = "Time"
        '
        'Timer1
        '
        '
        'tssl_UserName
        '
        Me.tssl_UserName.BackColor = System.Drawing.Color.Transparent
        Me.tssl_UserName.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.tssl_UserName.Name = "tssl_UserName"
        Me.tssl_UserName.Size = New System.Drawing.Size(75, 18)
        Me.tssl_UserName.Text = "User Name"
        '
        'tssl_espacer
        '
        Me.tssl_espacer.BackColor = System.Drawing.Color.Transparent
        Me.tssl_espacer.Name = "tssl_espacer"
        Me.tssl_espacer.Size = New System.Drawing.Size(1012, 17)
        Me.tssl_espacer.Spring = True
        '
        'tssl_spacer2
        '
        Me.tssl_spacer2.BackColor = System.Drawing.Color.Transparent
        Me.tssl_spacer2.Name = "tssl_spacer2"
        Me.tssl_spacer2.Size = New System.Drawing.Size(0, 17)
        '
        'frm_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 691)
        Me.Controls.Add(Me.sst_main)
        Me.Controls.Add(Me.mnu_buttons)
        Me.Controls.Add(Me.mnu_main)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnu_buttons
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "B.E.G. Toolbox"
        Me.mnu_buttons.ResumeLayout(False)
        Me.mnu_buttons.PerformLayout()
        Me.mnu_main.ResumeLayout(False)
        Me.mnu_main.PerformLayout()
        Me.sst_main.ResumeLayout(False)
        Me.sst_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_buttons As MenuStrip
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CobranzasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_main As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MódulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sst_main As StatusStrip
    Friend WithEvents tssl_time As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tssl_PCName As ToolStripStatusLabel
    Friend WithEvents tssl_UserName As ToolStripStatusLabel
    Friend WithEvents tssl_espacer As ToolStripStatusLabel
    Friend WithEvents tssl_spacer2 As ToolStripStatusLabel
End Class
