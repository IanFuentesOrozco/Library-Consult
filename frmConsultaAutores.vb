'Imports
Imports System.Data
Imports MySqlConnector

Public Class frmConsultaAutores

    Private WithEvents bnAutores As BindingNavigator

    'declaraciones para el BindingNavigator
    Private ReadOnly bsAutores As New BindingSource()
    Private dtAutores As New DataTable()
    Private cargando As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CrearBindingNavigator()
        'in this case was BindingNavigator, but you can use any name you want
    End Sub

    Private Sub CrearBindingNavigator()

        bnAutores = New BindingNavigator(True)

        'Properties of the BindingNavigator
        With bnAutores
            .Name = "bnAutores"
            .Dock = DockStyle.None
            .Anchor = AnchorStyles.Top Or
                      AnchorStyles.Left Or
                      AnchorStyles.Right
            .GripStyle = ToolStripGripStyle.Hidden
            .AutoSize = False
            .Location = New System.Drawing.Point(15, 65)
            .Size = New System.Drawing.Size(Me.ClientSize.Width - 30, 27)
        End With

        'Bn Autores AddNewItem configuration
        If bnAutores.AddNewItem IsNot Nothing Then
            bnAutores.Items.Remove(bnAutores.AddNewItem)
            bnAutores.AddNewItem = Nothing
        End If

        'Bn Autores DeleteItem configuration
        If bnAutores.DeleteItem IsNot Nothing Then
            bnAutores.Items.Remove(bnAutores.DeleteItem)
            bnAutores.DeleteItem = Nothing
        End If

        'Add the BindingNavigator to the form
        Me.Controls.Add(bnAutores)
        bnAutores.BringToFront()
    End Sub

    ' Carga en el ComboBox las nacionalidades existentes en la tabla autor.
    Private Sub CargarNacionalidades()

        Dim dtNacionalidades As New DataTable()

        Using cn As MySqlConnection = ObtenerConexion()

            Dim sql As String =
                "SELECT DISTINCT nacionalidad " &
                "FROM autor " &
                "ORDER BY nacionalidad;"

            Using da As New MySqlDataAdapter(sql, cn)
                da.Fill(dtNacionalidades)
            End Using

        End Using

        Dim filaTodas As DataRow = dtNacionalidades.NewRow()
        filaTodas("nacionalidad") = "(Todas las nacionalidades)"
        dtNacionalidades.Rows.InsertAt(filaTodas, 0)

        cboNacionalidad.DataSource = dtNacionalidades
        cboNacionalidad.DisplayMember = "nacionalidad"
        cboNacionalidad.ValueMember = "nacionalidad"
        cboNacionalidad.SelectedIndex = 0

    End Sub


    ' Consulta los autores y enlaza los resultados con la cuadrícula y el navegador.
    Private Sub CargarAutores()

        dtAutores = New DataTable()

        Using cn As MySqlConnection = ObtenerConexion()

            Dim sql As String =
                "SELECT id_autor, nombres, apellidos, nacionalidad " &
                "FROM autor " &
                "ORDER BY apellidos, nombres;"

            Using da As New MySqlDataAdapter(sql, cn)
                da.Fill(dtAutores)
            End Using

        End Using

        bsAutores.DataSource = dtAutores
        dgvAutores.DataSource = bsAutores
        bnAutores.BindingSource = bsAutores

    End Sub


    ' Configura los encabezados y oculta el identificador interno del autor.
    Private Sub ConfigurarColumnasAutores()

        If dgvAutores.Columns.Count = 0 Then Return

        dgvAutores.Columns("id_autor").Visible = False
        dgvAutores.Columns("nombres").HeaderText = "Nombres"
        dgvAutores.Columns("apellidos").HeaderText = "Apellidos"
        dgvAutores.Columns("nacionalidad").HeaderText = "Nacionalidad"

    End Sub

    ' Enlaza los TextBox con la información del autor seleccionado.
    Private Sub EnlazarControlesAutores()

        txtNombres.DataBindings.Clear()
        txtApellidos.DataBindings.Clear()
        txtNacionalidad.DataBindings.Clear()

        txtNombres.DataBindings.Add("Text", bsAutores, "nombres", True,
                                        DataSourceUpdateMode.Never)

        txtApellidos.DataBindings.Add("Text", bsAutores, "apellidos", True,
                                        DataSourceUpdateMode.Never)

        txtNacionalidad.DataBindings.Add("Text", bsAutores, "nacionalidad", True,
                                        DataSourceUpdateMode.Never)
    End Sub

    ' Filtra los autores utilizando la nacionalidad seleccionada.
    Private Sub AplicarFiltroAutores()

        If cargando Then Exit Sub

        Dim nacionalidad As String = Convert.ToString(cboNacionalidad.SelectedValue)

        If cboNacionalidad.SelectedIndex > 0 AndAlso
           nacionalidad <> "" Then

            nacionalidad = nacionalidad.Replace("'", "''")
            bsAutores.Filter = $"nacionalidad = '{nacionalidad}'"

        Else
            bsAutores.Filter = ""
        End If

        ActualizarContadorAutores()

    End Sub

    ' Muestra la cantidad de autores visibles y la cantidad total.
    Private Sub ActualizarContadorAutores()

        lblAutores.Text = $"{bsAutores.Count} de {dtAutores.Rows.Count} autor(es) en la vista"

    End Sub


    ' Aplica el filtro cuando cambia la nacionalidad seleccionada.
    Private Sub cboNacionalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNacionalidad.SelectedIndexChanged

        AplicarFiltroAutores()

    End Sub

    ' Carga y enlaza los datos cuando se abre el formulario.
    Private Sub frmConsultaAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            cargando = True

            CargarNacionalidades()
            CargarAutores()
            ConfigurarColumnasAutores()
            EnlazarControlesAutores()

            cargando = False
            ActualizarContadorAutores()

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

End Class