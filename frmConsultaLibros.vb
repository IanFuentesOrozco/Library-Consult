Imports System.Data
Imports MySqlConnector

Public Class frmConsultaLibros

    'probando el punto 6 (BindingNavigator)
    Private WithEvents bnLibros As BindingNavigator

    'declaraciones
    'Puente entre los datos y controles de la interfaz de usuario
    Private ReadOnly bsLibros As New BindingSource()

    'Tabla que guardara en memoria los libros consultados de la base de datos
    Private dtLibros As New DataTable()

    'Evitra que los filtros se ejecuten mientras carga el formulario.
    Private cargando As Boolean = True

    Public Sub New()
        InitializeComponent()
        CrearBindingNavigator()
    End Sub

    Private Sub CrearBindingNavigator()

        ' True agrega automáticamente:
        ' primero, anterior, posición, total, siguiente,
        ' último, agregar y eliminar.
        bnLibros = New BindingNavigator(True)

        With bnLibros
            .Name = "bnLibros"
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.Top Or
                  AnchorStyles.Left Or
                  AnchorStyles.Right
            .GripStyle = ToolStripGripStyle.Hidden
            .AutoSize = False
            .Location = New Point(15, 65)
            .Size = New Size(Me.ClientSize.Width - 30, 27)
        End With

        ' La asignación solo requiere navegación,
        ' por eso quitamos Agregar y Eliminar.
        If bnLibros.AddNewItem IsNot Nothing Then
            bnLibros.Items.Remove(bnLibros.AddNewItem)
            bnLibros.AddNewItem = Nothing
        End If

        If bnLibros.DeleteItem IsNot Nothing Then
            bnLibros.Items.Remove(bnLibros.DeleteItem)
            bnLibros.DeleteItem = Nothing
        End If

        Me.Controls.Add(bnLibros)
        bnLibros.BringToFront()

    End Sub

    'finish here (BindingNavigator)

    'cargar categorias
    Private Sub CargarCategorias()

        Dim dtCategorias As New DataTable()

        Using cn As MySqlConnection = ObtenerConexion()

            Dim sql As String =
                "SELECT id_categoria, nombre    " &
                "FROM categoria " &
                "ORDER BY nombre;"
            Using da As New MySqlDataAdapter(sql, cn)
                da.Fill(dtCategorias)

            End Using

        End Using

        ' Agrega la opción para mostrar todas las categorías.
        Dim filaTodas As DataRow = dtCategorias.NewRow()

        filaTodas("id_categoria") = 0
        filaTodas("nombre") = "(Todas las categorías)"

        dtCategorias.Rows.InsertAt(filaTodas, 0)

        ' Configura lo que muestra y lo que guarda el ComboBox.
        cboCategoria.DataSource = dtCategorias
        cboCategoria.DisplayMember = "nombre"
        cboCategoria.ValueMember = "id_categoria"
        cboCategoria.SelectedIndex = 0

    End Sub

    '  Carga los libros desde MariaDB y enlaza los datos con la cuadrícula y el navegador
    Private Sub CargarLibros()

        dtLibros = New DataTable()

        Using cn As MySqlConnection = ObtenerConexion()

            Dim sql As String =
                    "SELECT id_libro, titulo, autor, categoria, id_categoria, " &
                    "anio_publicacion, ejemplares, precio " &
                    "FROM vw_libros ORDER BY titulo;"

            Using da As New MySqlDataAdapter(sql, cn)
                da.Fill(dtLibros)
            End Using

        End Using

        bsLibros.DataSource = dtLibros
        dgvLibros.DataSource = bsLibros
        bnLibros.BindingSource = bsLibros

        ConfigurarColumnas()

    End Sub


    'Configura los nombres, la visibilidad y el formato de las columnas
    Private Sub ConfigurarColumnas()
        dgvLibros.Columns("id_libro").Visible = False
        dgvLibros.Columns("id_categoria").Visible = False

        dgvLibros.Columns("titulo").HeaderText = "Título"
        dgvLibros.Columns("autor").HeaderText = "Autor"
        dgvLibros.Columns("categoria").HeaderText = "Categoría"
        dgvLibros.Columns("anio_publicacion").HeaderText = "Año"
        dgvLibros.Columns("ejemplares").HeaderText = "Ejempl."
        dgvLibros.Columns("precio").HeaderText = "Precio"

        dgvLibros.Columns("precio").DefaultCellStyle.Format = "C2"

    End Sub

    'Enlasa cada TextBox con la info del libro seleccionado
    Private Sub EnlazarControles()

        txtTitulo.DataBindings.Add("Text", bsLibros, "titulo", True,
                                   DataSourceUpdateMode.Never)

        txtAutor.DataBindings.Add("Text", bsLibros, "autor", True,
                                   DataSourceUpdateMode.Never)

        txtCategoria.DataBindings.Add("Text", bsLibros, "categoria", True,
                                   DataSourceUpdateMode.Never)

        txtAnio.DataBindings.Add("Text", bsLibros, "anio_publicacion", True,
                                   DataSourceUpdateMode.Never)

        txtEjemplares.DataBindings.Add("Text", bsLibros, "ejemplares", True,
                                   DataSourceUpdateMode.Never)

        txtPrecio.DataBindings.Add("Text", bsLibros, "precio", True,
                                   DataSourceUpdateMode.Never, Nothing, "C2")
    End Sub




    ' Combina el filtro de categoría con el texto escrito para buscar títulos.
    Private Sub AplicarFiltro()

        If cargando Then Exit Sub

        Dim condiciones As New List(Of String)

        If cboCategoria.SelectedValue IsNot Nothing AndAlso
       Not IsDBNull(cboCategoria.SelectedValue) Then

            Dim idCategoria As Integer =
            Convert.ToInt32(cboCategoria.SelectedValue)

            If idCategoria > 0 Then
                condiciones.Add($"id_categoria = {idCategoria}")
            End If

        End If

        Dim texto As String = txtBuscar.Text.Trim()

        If texto <> "" Then
            texto = texto.Replace("'", "''")
            condiciones.Add($"titulo LIKE '%{texto}%'")
        End If

        bsLibros.Filter = String.Join(" AND ", condiciones)

        ActualizarContador()

    End Sub


    ' Muestra cuántos libros están visibles y cuántos fueron cargados.
    Private Sub ActualizarContador()

        lblRegistros.Text = $"{bsLibros.Count} de {dtLibros.Rows.Count} libro(s) en la vista"

    End Sub


    ' Aplica nuevamente el filtro cuando cambia la categoría seleccionada.
    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged

        AplicarFiltro()

    End Sub


    ' Aplica nuevamente el filtro mientras cambia el texto de búsqueda.
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        AplicarFiltro()

    End Sub


    ' Carga y conecta todos los datos cuando se abre el formulario.
    Private Sub frmConsultaLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            cargando = True

            CargarCategorias()
            CargarLibros()
            ConfigurarColumnas()
            EnlazarControles()

            cargando = False
            ActualizarContador()

        Catch ex As MySqlException

            MessageBox.Show(
            "No se pudo consultar MariaDB." & vbCrLf & ex.Message,
            "Error de base de datos",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        Catch ex As Exception

            MessageBox.Show(
            "Error inesperado." & vbCrLf & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub




    'load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblBuscar.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpFiltros.Enter

    End Sub

    Private Sub tlpDetalle_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
