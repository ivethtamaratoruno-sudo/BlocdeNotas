Imports System.IO
Imports System.Drawing

Public Class frmBlocNotas

    Private rutaActual As String = String.Empty
    Private documentoModificado As Boolean = False



    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs)
        documentoModificado = True
        ActualizarBarraEstado()
    End Sub

    Private Sub frmBlocNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial del RichTextBox
        rtbDocumento.Font = New Font("Consolas", 11)
        rtbDocumento.WordWrap = True
        mnuAjusteDeLinea.Checked = True

        ' Llenar combos del ToolStrip
        tscbFuente.Items.AddRange(New String() {"Segoe UI", "Consolas", "Arial", "Times New Roman"})
        tscbFuente.SelectedIndex = 1
        tscbTamano.Items.AddRange(New String() {"8", "10", "11", "12", "14", "18", "24"})
        tscbTamano.SelectedIndex = 2

        ActualizarBarraEstado()
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
        ' Maximizar la ventana al iniciar
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub mnuPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuPrincipal.ItemClicked

    End Sub

    Private Sub rtbDocumento_SelectionChanged_1(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub mnuGuardar_Click(sender As Object, e As EventArgs) Handles mnuGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub mnuGuardarComo_Click(sender As Object, e As EventArgs) Handles mnuGuardarComo.Click
        GuardarDocumento(True)
    End Sub

    Private Sub mnuSalir_Click(
    sender As Object,
    e As EventArgs
) Handles mnuSalir.Click

        If rtbDocumento.Modified Then

            Dim respuesta As DialogResult =
            MessageBox.Show(
                "El documento ha sido modificado. ¿Desea guardar los cambios?",
                "Bloc de Notas",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            )

            If respuesta = DialogResult.Yes Then

                GuardarDocumento(False)

                If rtbDocumento.Modified Then
                    Exit Sub
                End If

            ElseIf respuesta = DialogResult.Cancel Then

                Exit Sub

            End If

        End If

        Me.Close()

    End Sub

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

    Private Sub mnuAjusteDeLinea_Click(sender As Object, e As EventArgs) Handles mnuAjusteDeLinea.Click
        rtbDocumento.WordWrap = mnuAjusteDeLinea.Checked
    End Sub

    Private Sub mnuZoomMas_Click(sender As Object, e As EventArgs) Handles mnuZoomMas.Click
        If rtbDocumento.ZoomFactor < 4.0F Then rtbDocumento.ZoomFactor += 0.1F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuZoomMenos_Click(sender As Object, e As EventArgs) Handles mnuZoomMenos.Click
        If rtbDocumento.ZoomFactor > 0.3F Then rtbDocumento.ZoomFactor -= 0.1F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuZoomRestablecer_Click(sender As Object, e As EventArgs) Handles mnuZoomRestablecer.Click
        rtbDocumento.ZoomFactor = 1.0F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click
        MessageBox.Show("Bloc de Notas VB.NET" & vbCrLf & "Ejemplo académico - MenuStrip/ToolStrip/StatusStrip",
                         "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        GuardarDocumento(False)
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

    Private Sub tscbFuente_Click(sender As Object, e As EventArgs) Handles tscbFuente.Click
        Dim tamano As Single = rtbDocumento.SelectionFont.Size
        rtbDocumento.SelectionFont = New Font(tscbFuente.Text, tamano, rtbDocumento.SelectionFont.Style)
    End Sub

    Private Sub tscbTamano_Click(sender As Object, e As EventArgs) Handles tscbTamano.Click
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

    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        stsFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")
    End Sub
    Private Sub ActualizarBarraEstado()

        Dim linea As Integer =
        rtbDocumento.GetLineFromCharIndex(
            rtbDocumento.SelectionStart
        ) + 1

        Dim inicioLinea As Integer =
        rtbDocumento.GetFirstCharIndexOfCurrentLine()

        Dim columna As Integer =
        rtbDocumento.SelectionStart -
        inicioLinea + 1

        Dim texto As String =
        rtbDocumento.Text.Trim()

        Dim cantidadPalabras As Integer = 0

        If Not String.IsNullOrWhiteSpace(texto) Then

            Dim palabras() As String =
            texto.Split(
                New Char() {" "c, ChrW(10), ChrW(13), ChrW(9)},
                StringSplitOptions.RemoveEmptyEntries
            )

            cantidadPalabras = palabras.Length

        End If

        stsPosicion.Text =
        $"Línea: {linea}   Columna: {columna}"

        stsCaracteres.Text =
        $"Caracteres: {rtbDocumento.TextLength}   Palabras: {cantidadPalabras}"

        stsZoom.Text =
        $"Zoom: {CInt(rtbDocumento.ZoomFactor * 100)}%"

        stsEstado.Text =
        If(documentoModificado,
           "Modificado",
           "Listo")

    End Sub

    Private Sub NuevoDocumento()
        If documentoModificado Then
            Dim r = MessageBox.Show("¿Desea guardar los cambios antes de continuar?",
                                     "Bloc de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If r = DialogResult.Cancel Then Exit Sub
            If r = DialogResult.Yes Then GuardarDocumento(False)
        End If
        rtbDocumento.Clear()
        rutaActual = String.Empty
        documentoModificado = False
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
        ActualizarBarraEstado()
    End Sub

    Private Sub AbrirDocumento()

        If documentoModificado Then

            Dim respuesta As DialogResult =
                MessageBox.Show(
                    "El documento ha sido modificado. ¿Desea guardar los cambios?",
                    "Bloc de Notas",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                )

            If respuesta = DialogResult.Cancel Then
                Exit Sub
            End If

            If respuesta = DialogResult.Yes Then

                GuardarDocumento(False)

                If documentoModificado Then
                    Exit Sub
                End If

            End If

        End If

        If dlgAbrir.ShowDialog() = DialogResult.OK Then

            Try

                rtbDocumento.LoadFile(
                    dlgAbrir.FileName,
                    RichTextBoxStreamType.PlainText
                )

                rutaActual = dlgAbrir.FileName
                documentoModificado = False

                Me.Text =
                    $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"

                ActualizarBarraEstado()

            Catch ex As Exception

                MessageBox.Show(
                    "No se pudo abrir el archivo." & vbCrLf &
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If
    End Sub

    Private Sub GuardarDocumento(
    forzarDialogo As Boolean
)

        Try

            If String.IsNullOrEmpty(rutaActual) OrElse
           forzarDialogo Then

                If dlgGuardar.ShowDialog() = DialogResult.OK Then

                    rutaActual = dlgGuardar.FileName

                Else

                    Exit Sub

                End If

            End If

            rtbDocumento.SaveFile(
            rutaActual,
            RichTextBoxStreamType.PlainText
        )

            documentoModificado = False

            Me.Text =
            $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"

            stsEstado.Text =
            "Guardado correctamente"

            ActualizarBarraEstado()

        Catch ex As Exception

            MessageBox.Show(
            "No se pudo guardar el archivo." & vbCrLf &
            ex.Message,
            "Error al guardar",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Sub mnuHerramientas_Click(sender As Object, e As EventArgs) Handles mnuHerramientas.Click

    End Sub

    Private Sub rtbDocumento_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuContarCaracteres.Click

    End Sub
    Private Sub mnuBuscar_Click(
    sender As Object,
    e As EventArgs
) Handles mnuBuscar.Click

        txtBuscar.Focus()

    End Sub

    'boton buscar con funcion click
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

        If String.IsNullOrWhiteSpace(txtBuscar.Text) Then

            MessageBox.Show(
                "Escriba una palabra o frase para buscar.",
                "Buscar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Exit Sub

        End If

        Dim texto = rtbDocumento.Text
        Dim palabra = txtBuscar.Text

        Dim posicion =
            texto.IndexOf(
                palabra,
                StringComparison.CurrentCultureIgnoreCase
            )

        If posicion >= 0 Then

            rtbDocumento.Select(
                posicion,
                palabra.Length
            )

            rtbDocumento.Focus()

        Else

            MessageBox.Show(
                "No se encontró el texto buscado.",
                "Buscar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        End If

    End Sub
    Private Sub mnuContarCaracteres_Click(
    sender As Object,
    e As EventArgs
) Handles mnuContarCaracteres.Click

        Dim cantidad As Integer =
            rtbDocumento.TextLength

        MessageBox.Show(
            "Cantidad de caracteres: " & cantidad,
            "Contar caracteres",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub
    Private Sub mnuContarPalabras_Click(
    sender As Object,
    e As EventArgs
) Handles mnuContarPalabras.Click

        Dim texto As String =
            rtbDocumento.Text.Trim()

        If String.IsNullOrWhiteSpace(texto) Then

            MessageBox.Show(
                "Cantidad de palabras: 0",
                "Contar palabras",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Exit Sub

        End If

        Dim palabras() As String =
            texto.Split(
                New Char() {" "c, ChrW(10), ChrW(13), ChrW(9)},
                StringSplitOptions.RemoveEmptyEntries
            )

        MessageBox.Show(
            "Cantidad de palabras: " & palabras.Length,
            "Contar palabras",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub
End Class


