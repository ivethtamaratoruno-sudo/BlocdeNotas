<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlocNotas))
        mnuPrincipal = New MenuStrip()
        mnuSalir = New ToolStripMenuItem()
        mnuNuevo = New ToolStripMenuItem()
        mnuAbrir = New ToolStripMenuItem()
        mnuGuardarDocumento = New ToolStripMenuItem()
        mnuGuardarComo = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        mnuDeshacer = New ToolStripMenuItem()
        mnuRehacer = New ToolStripMenuItem()
        mnuCortar = New ToolStripMenuItem()
        mnuCopiar = New ToolStripMenuItem()
        mnuPegar = New ToolStripMenuItem()
        mnuSeleccionarTodo = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        mnuFuente = New ToolStripMenuItem()
        mnuColorTexto = New ToolStripMenuItem()
        mnuAjusteLinea = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        mnuZoomMas = New ToolStripMenuItem()
        mnuZoomMenos = New ToolStripMenuItem()
        mnuZoomRestablecer = New ToolStripMenuItem()
        mnuHerramientas = New ToolStripMenuItem()
        mnuBuscar = New ToolStripMenuItem()
        mnuContarPalabras = New ToolStripMenuItem()
        mnuContarCaracteres = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        mnuAcercaDe = New ToolStripMenuItem()
        AngelicaMorenoToolStripMenuItem = New ToolStripMenuItem()
        IvethToruñoToolStripMenuItem = New ToolStripMenuItem()
        tsPrincipal = New ToolStrip()
        tsbNuevo = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        tsbAbrir = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        tsbGuardarDocumento = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        tsbCortar = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        tsbCopiar = New ToolStripButton()
        ToolStripSeparator5 = New ToolStripSeparator()
        tsbPegar = New ToolStripButton()
        ToolStripSeparator6 = New ToolStripSeparator()
        tsbNegrita = New ToolStripButton()
        ToolStripSeparator7 = New ToolStripSeparator()
        tsbCursiva = New ToolStripButton()
        ToolStripSeparator8 = New ToolStripSeparator()
        tsbSubrayado = New ToolStripButton()
        ToolStripSeparator9 = New ToolStripSeparator()
        tscbFuente = New ToolStripComboBox()
        tscbTamano = New ToolStripComboBox()
        rtbDocumento = New RichTextBox()
        cmsTexto = New ContextMenuStrip(components)
        cmsCortar = New ToolStripMenuItem()
        cmsCopiar = New ToolStripMenuItem()
        cmsPegar = New ToolStripMenuItem()
        cmsSeleccionarTodo = New ToolStripMenuItem()
        cmsFuente = New ToolStripMenuItem()
        stsInferior = New StatusStrip()
        stsEstado = New ToolStripStatusLabel()
        stsPosicion = New ToolStripStatusLabel()
        stsCaracteres = New ToolStripStatusLabel()
        stsFechaHora = New ToolStripStatusLabel()
        stsZoom = New ToolStripStatusLabel()
        dlgAbrir = New OpenFileDialog()
        dlgGuardar = New SaveFileDialog()
        dlgFuente = New FontDialog()
        dlgColor = New ColorDialog()
        tmrReloj = New Timer(components)
        RichTextBox1 = New RichTextBox()
        txtBuscar = New TextBox()
        btnBuscar = New Button()
        Label1 = New Label()
        mnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        cmsTexto.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.Items.AddRange(New ToolStripItem() {mnuSalir, EdiciónToolStripMenuItem, FormatoToolStripMenuItem, VerToolStripMenuItem, mnuHerramientas, AyudaToolStripMenuItem})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(800, 24)
        mnuPrincipal.TabIndex = 0
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' mnuSalir
        ' 
        mnuSalir.DropDownItems.AddRange(New ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardarDocumento, mnuGuardarComo, SalirToolStripMenuItem})
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuSalir.Size = New Size(63, 20)
        mnuSalir.Text = "Archivo "
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(156, 22)
        mnuNuevo.Text = "Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
        mnuAbrir.Size = New Size(156, 22)
        mnuAbrir.Text = "Abrir"
        ' 
        ' mnuGuardarDocumento
        ' 
        mnuGuardarDocumento.Name = "mnuGuardarDocumento"
        mnuGuardarDocumento.ShortcutKeys = Keys.Control Or Keys.S
        mnuGuardarDocumento.Size = New Size(156, 22)
        mnuGuardarDocumento.Text = "Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New Size(156, 22)
        mnuGuardarComo.Text = "Guardar como"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SalirToolStripMenuItem.Size = New Size(156, 22)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDeshacer, mnuRehacer, mnuCortar, mnuCopiar, mnuPegar, mnuSeleccionarTodo})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(58, 20)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' mnuDeshacer
        ' 
        mnuDeshacer.Name = "mnuDeshacer"
        mnuDeshacer.ShortcutKeys = Keys.Control Or Keys.Z
        mnuDeshacer.Size = New Size(204, 22)
        mnuDeshacer.Text = "Deshacer"
        ' 
        ' mnuRehacer
        ' 
        mnuRehacer.Name = "mnuRehacer"
        mnuRehacer.ShortcutKeys = Keys.Control Or Keys.Y
        mnuRehacer.Size = New Size(204, 22)
        mnuRehacer.Text = "Rehacer"
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Name = "mnuCortar"
        mnuCortar.ShortcutKeys = Keys.Control Or Keys.X
        mnuCortar.Size = New Size(204, 22)
        mnuCortar.Text = "Cortar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.ShortcutKeys = Keys.Control Or Keys.C
        mnuCopiar.Size = New Size(204, 22)
        mnuCopiar.Text = "Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Name = "mnuPegar"
        mnuPegar.ShortcutKeys = Keys.Control Or Keys.V
        mnuPegar.Size = New Size(204, 22)
        mnuPegar.Text = "Pegar"
        ' 
        ' mnuSeleccionarTodo
        ' 
        mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        mnuSeleccionarTodo.ShortcutKeys = Keys.Control Or Keys.A
        mnuSeleccionarTodo.Size = New Size(204, 22)
        mnuSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuColorTexto, mnuAjusteLinea})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(64, 20)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(151, 22)
        mnuFuente.Text = "Fuente..."
        ' 
        ' mnuColorTexto
        ' 
        mnuColorTexto.Name = "mnuColorTexto"
        mnuColorTexto.Size = New Size(151, 22)
        mnuColorTexto.Text = "Color de texto"
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.CheckOnClick = True
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New Size(151, 22)
        mnuAjusteLinea.Text = "Ajuste de línea"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuZoomMas, mnuZoomMenos, mnuZoomRestablecer})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(35, 20)
        VerToolStripMenuItem.Text = "Ver"
        ' 
        ' mnuZoomMas
        ' 
        mnuZoomMas.Name = "mnuZoomMas"
        mnuZoomMas.Size = New Size(167, 22)
        mnuZoomMas.Text = "Zoom +"
        ' 
        ' mnuZoomMenos
        ' 
        mnuZoomMenos.Name = "mnuZoomMenos"
        mnuZoomMenos.Size = New Size(167, 22)
        mnuZoomMenos.Text = "Zoom -"
        ' 
        ' mnuZoomRestablecer
        ' 
        mnuZoomRestablecer.Name = "mnuZoomRestablecer"
        mnuZoomRestablecer.Size = New Size(167, 22)
        mnuZoomRestablecer.Text = "Restablecer zoom"
        ' 
        ' mnuHerramientas
        ' 
        mnuHerramientas.DropDownItems.AddRange(New ToolStripItem() {mnuBuscar, mnuContarPalabras, mnuContarCaracteres})
        mnuHerramientas.Name = "mnuHerramientas"
        mnuHerramientas.Size = New Size(90, 20)
        mnuHerramientas.Text = "Herramientas"
        ' 
        ' mnuBuscar
        ' 
        mnuBuscar.AutoToolTip = True
        mnuBuscar.Name = "mnuBuscar"
        mnuBuscar.Size = New Size(166, 22)
        mnuBuscar.Text = "Buscar"
        ' 
        ' mnuContarPalabras
        ' 
        mnuContarPalabras.Name = "mnuContarPalabras"
        mnuContarPalabras.Size = New Size(166, 22)
        mnuContarPalabras.Text = "Contar palabras "
        ' 
        ' mnuContarCaracteres
        ' 
        mnuContarCaracteres.Name = "mnuContarCaracteres"
        mnuContarCaracteres.Size = New Size(166, 22)
        mnuContarCaracteres.Text = "Contar caracteres"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAcercaDe, AngelicaMorenoToolStripMenuItem, IvethToruñoToolStripMenuItem})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' mnuAcercaDe
        ' 
        mnuAcercaDe.Name = "mnuAcercaDe"
        mnuAcercaDe.Size = New Size(165, 22)
        mnuAcercaDe.Text = "Acerca de"
        ' 
        ' AngelicaMorenoToolStripMenuItem
        ' 
        AngelicaMorenoToolStripMenuItem.Name = "AngelicaMorenoToolStripMenuItem"
        AngelicaMorenoToolStripMenuItem.Size = New Size(165, 22)
        AngelicaMorenoToolStripMenuItem.Text = "Angelica Moreno"
        ' 
        ' IvethToruñoToolStripMenuItem
        ' 
        IvethToruñoToolStripMenuItem.Name = "IvethToruñoToolStripMenuItem"
        IvethToruñoToolStripMenuItem.Size = New Size(165, 22)
        IvethToruñoToolStripMenuItem.Text = "Iveth Toruño"
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.Items.AddRange(New ToolStripItem() {tsbNuevo, ToolStripSeparator1, tsbAbrir, ToolStripSeparator2, tsbGuardarDocumento, ToolStripSeparator3, tsbCortar, ToolStripSeparator4, tsbCopiar, ToolStripSeparator5, tsbPegar, ToolStripSeparator6, tsbNegrita, ToolStripSeparator7, tsbCursiva, ToolStripSeparator8, tsbSubrayado, ToolStripSeparator9, tscbFuente, tscbTamano})
        tsPrincipal.Location = New Point(0, 24)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(800, 25)
        tsPrincipal.TabIndex = 1
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(23, 22)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.Image = CType(resources.GetObject("tsbAbrir.Image"), Image)
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(23, 22)
        tsbAbrir.Text = "Abrir"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' tsbGuardarDocumento
        ' 
        tsbGuardarDocumento.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardarDocumento.Image = CType(resources.GetObject("tsbGuardarDocumento.Image"), Image)
        tsbGuardarDocumento.ImageTransparentColor = Color.Magenta
        tsbGuardarDocumento.Name = "tsbGuardarDocumento"
        tsbGuardarDocumento.Size = New Size(23, 22)
        tsbGuardarDocumento.Text = "Guardar"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' tsbCortar
        ' 
        tsbCortar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCortar.Image = CType(resources.GetObject("tsbCortar.Image"), Image)
        tsbCortar.ImageTransparentColor = Color.Magenta
        tsbCortar.Name = "tsbCortar"
        tsbCortar.Size = New Size(23, 22)
        tsbCortar.Text = "Cortar"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 25)
        ' 
        ' tsbCopiar
        ' 
        tsbCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCopiar.Image = CType(resources.GetObject("tsbCopiar.Image"), Image)
        tsbCopiar.ImageTransparentColor = Color.Magenta
        tsbCopiar.Name = "tsbCopiar"
        tsbCopiar.Size = New Size(23, 22)
        tsbCopiar.Text = "Copiar"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(6, 25)
        ' 
        ' tsbPegar
        ' 
        tsbPegar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbPegar.Image = CType(resources.GetObject("tsbPegar.Image"), Image)
        tsbPegar.ImageTransparentColor = Color.Magenta
        tsbPegar.Name = "tsbPegar"
        tsbPegar.Size = New Size(23, 22)
        tsbPegar.Text = "Pegar"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(6, 25)
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNegrita.Image = CType(resources.GetObject("tsbNegrita.Image"), Image)
        tsbNegrita.ImageTransparentColor = Color.Magenta
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(23, 22)
        tsbNegrita.Text = "N"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(6, 25)
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCursiva.Image = CType(resources.GetObject("tsbCursiva.Image"), Image)
        tsbCursiva.ImageTransparentColor = Color.Magenta
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(23, 22)
        tsbCursiva.Text = "K"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(6, 25)
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSubrayado.Image = CType(resources.GetObject("tsbSubrayado.Image"), Image)
        tsbSubrayado.ImageTransparentColor = Color.Magenta
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New Size(23, 22)
        tsbSubrayado.Text = "S"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(6, 25)
        ' 
        ' tscbFuente
        ' 
        tscbFuente.AutoSize = False
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New Size(121, 23)
        tscbFuente.Text = "Fuente"
        ' 
        ' tscbTamano
        ' 
        tscbTamano.AutoSize = False
        tscbTamano.Name = "tscbTamano"
        tscbTamano.Size = New Size(121, 23)
        tscbTamano.Text = "Tamaño"
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbDocumento.Location = New Point(0, 49)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(800, 401)
        rtbDocumento.TabIndex = 2
        rtbDocumento.Text = ""
        ' 
        ' cmsTexto
        ' 
        cmsTexto.Items.AddRange(New ToolStripItem() {cmsCortar, cmsCopiar, cmsPegar, cmsSeleccionarTodo, cmsFuente})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(163, 114)
        ' 
        ' cmsCortar
        ' 
        cmsCortar.Name = "cmsCortar"
        cmsCortar.Size = New Size(162, 22)
        cmsCortar.Text = "Cortar"
        ' 
        ' cmsCopiar
        ' 
        cmsCopiar.Name = "cmsCopiar"
        cmsCopiar.Size = New Size(162, 22)
        cmsCopiar.Text = "Copiar"
        ' 
        ' cmsPegar
        ' 
        cmsPegar.Name = "cmsPegar"
        cmsPegar.Size = New Size(162, 22)
        cmsPegar.Text = "Pegar"
        ' 
        ' cmsSeleccionarTodo
        ' 
        cmsSeleccionarTodo.Name = "cmsSeleccionarTodo"
        cmsSeleccionarTodo.Size = New Size(162, 22)
        cmsSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' cmsFuente
        ' 
        cmsFuente.Name = "cmsFuente"
        cmsFuente.Size = New Size(162, 22)
        cmsFuente.Text = "Fuente..."
        ' 
        ' stsInferior
        ' 
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsFechaHora, stsZoom})
        stsInferior.Location = New Point(0, 428)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(800, 22)
        stsInferior.TabIndex = 4
        stsInferior.Text = "StatusStrip1"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(32, 17)
        stsEstado.Text = "Listo"
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(114, 17)
        stsPosicion.Text = "Linea: 1  Columna: 1"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(74, 17)
        stsCaracteres.Text = "Caracteres: 0"
        ' 
        ' stsFechaHora
        ' 
        stsFechaHora.Name = "stsFechaHora"
        stsFechaHora.Size = New Size(69, 17)
        stsFechaHora.Text = "Fecha/Hora"
        ' 
        ' stsZoom
        ' 
        stsZoom.Name = "stsZoom"
        stsZoom.Size = New Size(73, 17)
        stsZoom.Text = "Zoom: 100%"
        ' 
        ' dlgAbrir
        ' 
        dlgAbrir.FileName = "OpenFileDialog1"
        dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        ' 
        ' dlgGuardar
        ' 
        dlgGuardar.DefaultExt = "txt"
        dlgGuardar.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        ' 
        ' dlgFuente
        ' 
        dlgFuente.ShowColor = True
        ' 
        ' dlgColor
        ' 
        dlgColor.FullOpen = True
        ' 
        ' tmrReloj
        ' 
        tmrReloj.Enabled = True
        tmrReloj.Interval = 1000
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBox1.Location = New Point(0, 392)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(800, 33)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtBuscar.Location = New Point(108, 399)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(251, 23)
        txtBuscar.TabIndex = 7
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnBuscar.Location = New Point(365, 399)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(81, 26)
        btnBuscar.TabIndex = 8
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(31, 405)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 9
        Label1.Text = "Buscar texto"
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(RichTextBox1)
        Controls.Add(stsInferior)
        Controls.Add(rtbDocumento)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        MainMenuStrip = mnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET"
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        cmsTexto.ResumeLayout(False)
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsPrincipal As ToolStrip
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents dlgAbrir As OpenFileDialog
    Friend WithEvents dlgGuardar As SaveFileDialog
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents dlgFuente As FontDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents tmrReloj As Timer
    Friend WithEvents mnuAbrir As ToolStripMenuItem
    Friend WithEvents mnuGuardarDocumento As ToolStripMenuItem
    Friend WithEvents mnuGuardarComo As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDeshacer As ToolStripMenuItem
    Friend WithEvents mnuRehacer As ToolStripMenuItem
    Friend WithEvents mnuCortar As ToolStripMenuItem
    Friend WithEvents mnuCopiar As ToolStripMenuItem
    Friend WithEvents mnuPegar As ToolStripMenuItem
    Friend WithEvents mnuSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents mnuFuente As ToolStripMenuItem
    Friend WithEvents mnuColorTexto As ToolStripMenuItem
    Friend WithEvents mnuAjusteLinea As ToolStripMenuItem
    Friend WithEvents mnuZoomMas As ToolStripMenuItem
    Friend WithEvents mnuZoomMenos As ToolStripMenuItem
    Friend WithEvents mnuZoomRestablecer As ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As ToolStripMenuItem
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsFechaHora As ToolStripStatusLabel
    Friend WithEvents stsZoom As ToolStripStatusLabel
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbAbrir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbGuardarDocumento As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbCortar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbCopiar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbPegar As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbNegrita As ToolStripButton
    Friend WithEvents tsbCursiva As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbSubrayado As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tscbFuente As ToolStripComboBox
    Friend WithEvents tscbTamano As ToolStripComboBox
    Friend WithEvents cmsCortar As ToolStripMenuItem
    Friend WithEvents cmsCopiar As ToolStripMenuItem
    Friend WithEvents cmsPegar As ToolStripMenuItem
    Friend WithEvents cmsSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents cmsFuente As ToolStripMenuItem
    Friend WithEvents mnuHerramientas As ToolStripMenuItem
    Friend WithEvents AngelicaMorenoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IvethToruñoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuBuscar As ToolStripMenuItem
    Friend WithEvents mnuContarPalabras As ToolStripMenuItem
    Friend WithEvents mnuContarCaracteres As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label

End Class
