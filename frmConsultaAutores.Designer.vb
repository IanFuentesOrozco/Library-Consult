<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAutores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        grpFiltrosAutores = New GroupBox()
        cboNacionalidad = New ComboBox()
        lblNacionalidad = New Label()
        dgvAutores = New DataGridView()
        grpDetalleAutores = New GroupBox()
        tlpDetalleAutores = New TableLayoutPanel()
        txtNombres = New TextBox()
        txtApellidos = New TextBox()
        txtNacionalidad = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        stsAutores = New StatusStrip()
        lblAutores = New ToolStripStatusLabel()
        grpFiltrosAutores.SuspendLayout()
        CType(dgvAutores, ComponentModel.ISupportInitialize).BeginInit()
        grpDetalleAutores.SuspendLayout()
        tlpDetalleAutores.SuspendLayout()
        stsAutores.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpFiltrosAutores
        ' 
        grpFiltrosAutores.Controls.Add(cboNacionalidad)
        grpFiltrosAutores.Controls.Add(lblNacionalidad)
        grpFiltrosAutores.Dock = DockStyle.Top
        grpFiltrosAutores.Location = New Point(0, 0)
        grpFiltrosAutores.Name = "grpFiltrosAutores"
        grpFiltrosAutores.Size = New Size(800, 100)
        grpFiltrosAutores.TabIndex = 0
        grpFiltrosAutores.TabStop = False
        grpFiltrosAutores.Text = "Filtros de consulta"
        ' 
        ' cboNacionalidad
        ' 
        cboNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList
        cboNacionalidad.FormattingEnabled = True
        cboNacionalidad.Location = New Point(98, 16)
        cboNacionalidad.Name = "cboNacionalidad"
        cboNacionalidad.Size = New Size(121, 23)
        cboNacionalidad.TabIndex = 1
        ' 
        ' lblNacionalidad
        ' 
        lblNacionalidad.AutoSize = True
        lblNacionalidad.Location = New Point(12, 19)
        lblNacionalidad.Name = "lblNacionalidad"
        lblNacionalidad.Size = New Size(80, 15)
        lblNacionalidad.TabIndex = 0
        lblNacionalidad.Text = "Nacionalidad:"
        ' 
        ' dgvAutores
        ' 
        dgvAutores.AllowUserToAddRows = False
        dgvAutores.AllowUserToDeleteRows = False
        dgvAutores.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAutores.Location = New Point(12, 154)
        dgvAutores.MultiSelect = False
        dgvAutores.Name = "dgvAutores"
        dgvAutores.ReadOnly = True
        dgvAutores.RowHeadersVisible = False
        dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAutores.Size = New Size(776, 180)
        dgvAutores.TabIndex = 2
        ' 
        ' grpDetalleAutores
        ' 
        grpDetalleAutores.Controls.Add(tlpDetalleAutores)
        grpDetalleAutores.Controls.Add(stsAutores)
        grpDetalleAutores.Dock = DockStyle.Bottom
        grpDetalleAutores.Location = New Point(0, 340)
        grpDetalleAutores.Name = "grpDetalleAutores"
        grpDetalleAutores.Size = New Size(800, 110)
        grpDetalleAutores.TabIndex = 3
        grpDetalleAutores.TabStop = False
        grpDetalleAutores.Text = "Detalle del autor seleccionado"
        ' 
        ' tlpDetalleAutores
        ' 
        tlpDetalleAutores.ColumnCount = 3
        tlpDetalleAutores.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpDetalleAutores.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F))
        tlpDetalleAutores.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.34F))
        tlpDetalleAutores.Controls.Add(txtNombres, 0, 1)
        tlpDetalleAutores.Controls.Add(txtApellidos, 1, 1)
        tlpDetalleAutores.Controls.Add(txtNacionalidad, 2, 1)
        tlpDetalleAutores.Controls.Add(Label1, 0, 0)
        tlpDetalleAutores.Controls.Add(Label2, 1, 0)
        tlpDetalleAutores.Controls.Add(Label3, 2, 0)
        tlpDetalleAutores.Dock = DockStyle.Fill
        tlpDetalleAutores.Location = New Point(3, 19)
        tlpDetalleAutores.Name = "tlpDetalleAutores"
        tlpDetalleAutores.RowCount = 2
        tlpDetalleAutores.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tlpDetalleAutores.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tlpDetalleAutores.Size = New Size(794, 66)
        tlpDetalleAutores.TabIndex = 0
        ' 
        ' txtNombres
        ' 
        txtNombres.BorderStyle = BorderStyle.FixedSingle
        txtNombres.Dock = DockStyle.Fill
        txtNombres.Location = New Point(3, 36)
        txtNombres.Name = "txtNombres"
        txtNombres.ReadOnly = True
        txtNombres.Size = New Size(258, 23)
        txtNombres.TabIndex = 11
        txtNombres.TabStop = False
        ' 
        ' txtApellidos
        ' 
        txtApellidos.BorderStyle = BorderStyle.FixedSingle
        txtApellidos.Dock = DockStyle.Fill
        txtApellidos.Location = New Point(267, 36)
        txtApellidos.Name = "txtApellidos"
        txtApellidos.ReadOnly = True
        txtApellidos.Size = New Size(258, 23)
        txtApellidos.TabIndex = 10
        txtApellidos.TabStop = False
        ' 
        ' txtNacionalidad
        ' 
        txtNacionalidad.BorderStyle = BorderStyle.FixedSingle
        txtNacionalidad.Dock = DockStyle.Fill
        txtNacionalidad.Location = New Point(531, 36)
        txtNacionalidad.Name = "txtNacionalidad"
        txtNacionalidad.ReadOnly = True
        txtNacionalidad.Size = New Size(260, 23)
        txtNacionalidad.TabIndex = 5
        txtNacionalidad.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nombres"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(267, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 7
        Label2.Text = "Apellidos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(531, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 8
        Label3.Text = "Nacionalidad"
        ' 
        ' stsAutores
        ' 
        stsAutores.Items.AddRange(New ToolStripItem() {lblAutores})
        stsAutores.Location = New Point(3, 85)
        stsAutores.Name = "stsAutores"
        stsAutores.Size = New Size(794, 22)
        stsAutores.SizingGrip = False
        stsAutores.TabIndex = 1
        stsAutores.Text = "StatusStrip1"
        ' 
        ' lblAutores
        ' 
        lblAutores.Name = "lblAutores"
        lblAutores.Size = New Size(118, 17)
        lblAutores.Text = "0 autor(es) en la vista"
        ' 
        ' frmConsultaAutores
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grpDetalleAutores)
        Controls.Add(dgvAutores)
        Controls.Add(grpFiltrosAutores)
        Name = "frmConsultaAutores"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta de autores — Biblioteca"
        grpFiltrosAutores.ResumeLayout(False)
        grpFiltrosAutores.PerformLayout()
        CType(dgvAutores, ComponentModel.ISupportInitialize).EndInit()
        grpDetalleAutores.ResumeLayout(False)
        grpDetalleAutores.PerformLayout()
        tlpDetalleAutores.ResumeLayout(False)
        tlpDetalleAutores.PerformLayout()
        stsAutores.ResumeLayout(False)
        stsAutores.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpFiltrosAutores As GroupBox
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents cboNacionalidad As ComboBox
    Friend WithEvents dgvAutores As DataGridView
    Friend WithEvents grpDetalleAutores As GroupBox
    Friend WithEvents tlpDetalleAutores As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents stsAutores As StatusStrip
    Friend WithEvents lblAutores As ToolStripStatusLabel
End Class
