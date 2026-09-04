Imports System.IO
Imports System.Drawing
Public Class frmBlocNotas
    Private rutaActual As String = String.Empty
    Private documentoModificado As Boolean = False

    ' 1. CARGA DEL FORMULARIO Y CONFIGURACIÓN INICIAL
    Private Sub frmBlocNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbDocumento.Font = New Font("Consolas", 11)
        rtbDocumento.WordWrap = True
        mnuAjusteLinea.Checked = True

        ' Llenar listas desplegables (Combos)
        tscbFuente.Items.AddRange(New String() {"Segoe UI", "Consolas", "Arial", "Times New Roman"})
        tscbFuente.SelectedIndex = 1
        tscbTamano.Items.AddRange(New String() {"8", "10", "11", "12", "14", "18", "24"})
        tscbTamano.SelectedIndex = 2

        ActualizarBarraEstado()
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
    End Sub

    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        documentoModificado = True
        ActualizarBarraEstado()
    End Sub

    Private Sub rtbDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        ActualizarBarraEstado()
    End Sub

    ' 2. MENÚ ARCHIVO (MENUSTRIP)
    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub mnuGuardar_Click(sender As Object, e As EventArgs) Handles mnuGuardarDocumento.Click
    End Sub

    Private Sub mnuGuardarComo_Click(sender As Object, e As EventArgs) Handles mnuGuardarComo.Click
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub

    ' 3. MENÚ EDICIÓN Y FORMATO
    Private Sub mnuDeshacer_Click(sender As Object, e As EventArgs) Handles mnuDeshacer.Click
        If rtbDocumento.CanUndo Then rtbDocumento.Undo()
    End Sub

    Private Sub mnuRehacer_Click(sender As Object, e As EventArgs) Handles mnuRehacer.Click
        If rtbDocumento.CanRedo Then rtbDocumento.Redo()
    End Sub

    Private Sub mnuCortar_Click(sender As Object, e As EventArgs) Handles mnuCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub mnuCopiar_Click(sender As Object, e As EventArgs) Handles mnuCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub mnuPegar_Click(sender As Object, e As EventArgs) Handles mnuPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub mnuSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles mnuSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub mnuFuente_Click(sender As Object, e As EventArgs) Handles mnuFuente.Click
        dlgFuente.Font = rtbDocumento.SelectionFont
        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If
    End Sub

    Private Sub mnuColorTexto_Click(sender As Object, e As EventArgs) Handles mnuColorTexto.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionColor = dlgColor.Color
        End If
    End Sub

    Private Sub mnuAjusteLinea_Click(sender As Object, e As EventArgs) Handles mnuAjusteLinea.Click
        rtbDocumento.WordWrap = mnuAjusteLinea.Checked
    End Sub

    ' 4. MENÚ VER Y AYUDA
    Private Sub mnuZoomMas_Click(sender As Object, e As EventArgs) Handles mnuZoomMas.Click
        If rtbDocumento.ZoomFactor < 4.0F Then
            rtbDocumento.ZoomFactor += 0.1F
            ActualizarBarraEstado()
        End If
    End Sub

    Private Sub mnuZoomMenos_Click(sender As Object, e As EventArgs) Handles mnuZoomMenos.Click
        If rtbDocumento.ZoomFactor > 0.3F Then
            rtbDocumento.ZoomFactor -= 0.1F
            ActualizarBarraEstado()
        End If
    End Sub

    Private Sub mnuZoomRestablecer_Click(sender As Object, e As EventArgs) Handles mnuZoomRestablecer.Click
        rtbDocumento.ZoomFactor = 1.0F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click
        MessageBox.Show("Bloc de Notas VB.NET" & vbCrLf & "Ejemplo académico - MenuStrip/ToolStrip/StatusStrip", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' 5. BOTONES DE ACCESO RÁPIDO (TOOLSTRIP)
    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardarDocumento.Click
    End Sub

    Private Sub tsbCortar_Click(sender As Object, e As EventArgs) Handles tsbCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub tsbCopiar_Click(sender As Object, e As EventArgs) Handles tsbCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub tsbPegar_Click(sender As Object, e As EventArgs) Handles tsbPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub tsbNegrita_Click(sender As Object, e As EventArgs) Handles tsbNegrita.Click
        AplicarEstiloFuente(FontStyle.Bold)
    End Sub

    Private Sub tsbCursiva_Click(sender As Object, e As EventArgs) Handles tsbCursiva.Click
        AplicarEstiloFuente(FontStyle.Italic)
    End Sub

    Private Sub tsbSubrayado_Click(sender As Object, e As EventArgs) Handles tsbSubrayado.Click
        AplicarEstiloFuente(FontStyle.Underline)
    End Sub

    Private Sub tscbFuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbFuente.SelectedIndexChanged
        Dim tamano As Single = rtbDocumento.SelectionFont.Size
        rtbDocumento.SelectionFont = New Font(tscbFuente.Text, tamano, rtbDocumento.SelectionFont.Style)
    End Sub

    Private Sub tscbTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTamano.SelectedIndexChanged
        Dim tam As Single = Convert.ToSingle(tscbTamano.Text)
        rtbDocumento.SelectionFont = New Font(rtbDocumento.SelectionFont.FontFamily, tam, rtbDocumento.SelectionFont.Style)
    End Sub

    Private Sub AplicarEstiloFuente(estilo As FontStyle)
        Dim fuenteActual As Font = rtbDocumento.SelectionFont
        If fuenteActual Is Nothing Then Exit Sub
        Dim nuevoEstilo As FontStyle
        If fuenteActual.Style.HasFlag(estilo) Then
            nuevoEstilo = fuenteActual.Style And Not estilo
        Else
            nuevoEstilo = fuenteActual.Style Or estilo
        End If
        rtbDocumento.SelectionFont = New Font(fuenteActual, nuevoEstilo)
    End Sub

    ' 6. MENÚ CONTEXTUAL / CLIC DERECHO (CONTEXTMENUSTRIP)
    Private Sub cmsTexto_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsTexto.Opening
        Dim haySeleccion As Boolean = rtbDocumento.SelectionLength > 0
        cmsCortar.Enabled = haySeleccion
        cmsCopiar.Enabled = haySeleccion
        cmsPegar.Enabled = Clipboard.ContainsText()
    End Sub

    Private Sub cmsCortar_Click(sender As Object, e As EventArgs) Handles cmsCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub cmsCopiar_Click(sender As Object, e As EventArgs) Handles cmsCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub cmsPegar_Click(sender As Object, e As EventArgs) Handles cmsPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub cmsSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles cmsSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub cmsFuente_Click(sender As Object, e As EventArgs) Handles cmsFuente.Click
        dlgFuente.Font = rtbDocumento.SelectionFont
        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If
    End Sub

    ' 7. RELOJ Y ACTUALIZACIÓN DE ESTADO (STATUSSTRIP)
    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        stsFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub ActualizarBarraEstado()
        Dim linea As Integer = rtbDocumento.GetLineFromCharIndex(rtbDocumento.SelectionStart) + 1
        Dim inicioLinea As Integer = rtbDocumento.GetFirstCharIndexOfCurrentLine()
        Dim columna As Integer = rtbDocumento.SelectionStart - inicioLinea + 1

        stsPosicion.Text = $"Línea: {linea} Columna: {columna}"
        stsCaracteres.Text = $"Caracteres: {rtbDocumento.TextLength}"
        stsZoom.Text = $"Zoom: {CInt(rtbDocumento.ZoomFactor * 100)}%"
        stsEstado.Text = If(documentoModificado, "Modificado", "Listo")
    End Sub

    ' 8. FUNCIONES INTERNAS (NUEVO, ABRIR, GUARDAR)
    Private Sub NuevoDocumento()
        If documentoModificado Then
            Dim r = MessageBox.Show("¿Desea guardar los cambios antes de continuar?", "Bloc de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If r = DialogResult.Cancel Then Exit Sub
        End If
        rtbDocumento.Clear()
        rutaActual = String.Empty
        documentoModificado = False
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
        ActualizarBarraEstado()
    End Sub

    Private Sub AbrirDocumento()
        If dlgAbrir.ShowDialog() = DialogResult.OK Then
            rtbDocumento.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.PlainText)
            rutaActual = dlgAbrir.FileName
            documentoModificado = False
            Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
            ActualizarBarraEstado()
        End If
    End Sub

    Private Sub dlgGuardar_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgGuardar.FileOk

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class


