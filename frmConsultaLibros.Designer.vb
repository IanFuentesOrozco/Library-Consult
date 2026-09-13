<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaLibros
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
        Label1 = New Label()
        cboCategoria = New ComboBox()
        lblBuscar = New Label()
        txtBuscar = New TextBox()
        dgvLibros = New DataGridView()
        grpFiltros = New GroupBox()
        grpDetalle = New GroupBox()
        tlpDetalle = New TableLayoutPanel()
        txtAnio = New TextBox()
        txtAutor = New TextBox()
        txtEjemplares = New TextBox()
        txtCategoria = New TextBox()
        txtPrecio = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        txtTitulo = New TextBox()
        stsEstado = New StatusStrip()
        lblRegistros = New ToolStripStatusLabel()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        grpFiltros.SuspendLayout()
        grpDetalle.SuspendLayout()
        tlpDetalle.SuspendLayout()
        stsEstado.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 20)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 0
        Label1.Text = "Categoría:"
        ' 
        ' cboCategoria
        ' 
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New Point(99, 18)
        cboCategoria.Margin = New Padding(2)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New Size(129, 23)
        cboCategoria.TabIndex = 1
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(243, 20)
        lblBuscar.Margin = New Padding(2, 0, 2, 0)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(97, 15)
        lblBuscar.TabIndex = 2
        lblBuscar.Text = "Buscar por título:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBuscar.Location = New Point(356, 19)
        txtBuscar.Margin = New Padding(2)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Escriba parte del título"
        txtBuscar.Size = New Size(329, 23)
        txtBuscar.TabIndex = 3
        ' 
        ' dgvLibros
        ' 
        dgvLibros.AllowUserToAddRows = False
        dgvLibros.AllowUserToDeleteRows = False
        dgvLibros.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(12, 107)
        dgvLibros.MultiSelect = False
        dgvLibros.Name = "dgvLibros"
        dgvLibros.ReadOnly = True
        dgvLibros.RowHeadersVisible = False
        dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLibros.Size = New Size(969, 232)
        dgvLibros.TabIndex = 4
        ' 
        ' grpFiltros
        ' 
        grpFiltros.Controls.Add(txtBuscar)
        grpFiltros.Controls.Add(Label1)
        grpFiltros.Controls.Add(lblBuscar)
        grpFiltros.Controls.Add(cboCategoria)
        grpFiltros.Location = New Point(12, 12)
        grpFiltros.Name = "grpFiltros"
        grpFiltros.Size = New Size(927, 47)
        grpFiltros.TabIndex = 5
        grpFiltros.TabStop = False
        grpFiltros.Text = "Filtros de consulta"
        ' 
        ' grpDetalle
        ' 
        grpDetalle.Controls.Add(tlpDetalle)
        grpDetalle.Controls.Add(stsEstado)
        grpDetalle.Dock = DockStyle.Bottom
        grpDetalle.Location = New Point(0, 372)
        grpDetalle.Name = "grpDetalle"
        grpDetalle.Size = New Size(993, 195)
        grpDetalle.TabIndex = 6
        grpDetalle.TabStop = False
        grpDetalle.Text = "Detalle del registro seleccionado"
        ' 
        ' tlpDetalle
        ' 
        tlpDetalle.ColumnCount = 3
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpDetalle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.34F))
        tlpDetalle.Controls.Add(txtAnio, 0, 3)
        tlpDetalle.Controls.Add(txtAutor, 1, 1)
        tlpDetalle.Controls.Add(txtEjemplares, 1, 3)
        tlpDetalle.Controls.Add(txtCategoria, 2, 1)
        tlpDetalle.Controls.Add(txtPrecio, 2, 3)
        tlpDetalle.Controls.Add(Label3, 0, 2)
        tlpDetalle.Controls.Add(Label4, 1, 0)
        tlpDetalle.Controls.Add(Label5, 1, 2)
        tlpDetalle.Controls.Add(Label6, 2, 0)
        tlpDetalle.Controls.Add(Label7, 2, 2)
        tlpDetalle.Controls.Add(Label2, 0, 0)
        tlpDetalle.Controls.Add(txtTitulo, 0, 1)
        tlpDetalle.Dock = DockStyle.Fill
        tlpDetalle.Location = New Point(3, 19)
        tlpDetalle.Name = "tlpDetalle"
        tlpDetalle.RowCount = 4
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        tlpDetalle.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        tlpDetalle.Size = New Size(987, 151)
        tlpDetalle.TabIndex = 0
        ' 
        ' txtAnio
        ' 
        txtAnio.BorderStyle = BorderStyle.FixedSingle
        txtAnio.Dock = DockStyle.Fill
        txtAnio.Location = New Point(3, 114)
        txtAnio.Name = "txtAnio"
        txtAnio.ReadOnly = True
        txtAnio.Size = New Size(322, 23)
        txtAnio.TabIndex = 2
        txtAnio.TabStop = False
        ' 
        ' txtAutor
        ' 
        txtAutor.BorderStyle = BorderStyle.FixedSingle
        txtAutor.Dock = DockStyle.Fill
        txtAutor.Location = New Point(331, 40)
        txtAutor.Name = "txtAutor"
        txtAutor.ReadOnly = True
        txtAutor.Size = New Size(322, 23)
        txtAutor.TabIndex = 3
        txtAutor.TabStop = False
        ' 
        ' txtEjemplares
        ' 
        txtEjemplares.BorderStyle = BorderStyle.FixedSingle
        txtEjemplares.Dock = DockStyle.Fill
        txtEjemplares.Location = New Point(331, 114)
        txtEjemplares.Name = "txtEjemplares"
        txtEjemplares.ReadOnly = True
        txtEjemplares.Size = New Size(322, 23)
        txtEjemplares.TabIndex = 4
        txtEjemplares.TabStop = False
        ' 
        ' txtCategoria
        ' 
        txtCategoria.BorderStyle = BorderStyle.FixedSingle
        txtCategoria.Dock = DockStyle.Fill
        txtCategoria.Location = New Point(659, 40)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.ReadOnly = True
        txtCategoria.Size = New Size(325, 23)
        txtCategoria.TabIndex = 5
        txtCategoria.TabStop = False
        ' 
        ' txtPrecio
        ' 
        txtPrecio.BorderStyle = BorderStyle.FixedSingle
        txtPrecio.Dock = DockStyle.Fill
        txtPrecio.Location = New Point(659, 114)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.ReadOnly = True
        txtPrecio.Size = New Size(325, 23)
        txtPrecio.TabIndex = 6
        txtPrecio.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 15)
        Label3.TabIndex = 7
        Label3.Text = "Año"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(331, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 15)
        Label4.TabIndex = 8
        Label4.Text = "Autor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(331, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 9
        Label5.Text = "Ejemplares"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(659, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 15)
        Label6.TabIndex = 10
        Label6.Text = "Categoría"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(659, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 15)
        Label7.TabIndex = 11
        Label7.Text = "Precio"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 12
        Label2.Text = "Título"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.BorderStyle = BorderStyle.FixedSingle
        txtTitulo.Dock = DockStyle.Fill
        txtTitulo.Location = New Point(3, 40)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.ReadOnly = True
        txtTitulo.Size = New Size(322, 23)
        txtTitulo.TabIndex = 13
        txtTitulo.TabStop = False
        ' 
        ' stsEstado
        ' 
        stsEstado.Items.AddRange(New ToolStripItem() {lblRegistros})
        stsEstado.Location = New Point(3, 170)
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(987, 22)
        stsEstado.TabIndex = 1
        stsEstado.Text = "StatusStrip1"
        ' 
        ' lblRegistros
        ' 
        lblRegistros.Name = "lblRegistros"
        lblRegistros.Size = New Size(108, 17)
        lblRegistros.Text = "0 libro(s) en la vista"
        ' 
        ' frmConsultaLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(993, 567)
        Controls.Add(grpDetalle)
        Controls.Add(dgvLibros)
        Controls.Add(grpFiltros)
        Margin = New Padding(2)
        Name = "frmConsultaLibros"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta de libros — Biblioteca"
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        grpFiltros.ResumeLayout(False)
        grpFiltros.PerformLayout()
        grpDetalle.ResumeLayout(False)
        grpDetalle.PerformLayout()
        tlpDetalle.ResumeLayout(False)
        tlpDetalle.PerformLayout()
        stsEstado.ResumeLayout(False)
        stsEstado.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents grpFiltros As GroupBox
    Friend WithEvents grpDetalle As GroupBox
    Friend WithEvents tlpDetalle As TableLayoutPanel
    Friend WithEvents Título As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtEjemplares As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents stsEstado As StatusStrip
    Friend WithEvents lblRegistros As ToolStripStatusLabel

End Class
