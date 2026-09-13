<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Label1 = New Label()
        btnLibros = New Button()
        btnAutores = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 15)
        Label1.TabIndex = 0
        Label1.Text = "Sistema de consultas de biblioteca"
        ' 
        ' btnLibros
        ' 
        btnLibros.Location = New Point(60, 51)
        btnLibros.Name = "btnLibros"
        btnLibros.Size = New Size(78, 38)
        btnLibros.TabIndex = 1
        btnLibros.Text = "Consulta de libros"
        btnLibros.UseVisualStyleBackColor = True
        ' 
        ' btnAutores
        ' 
        btnAutores.Location = New Point(169, 51)
        btnAutores.Name = "btnAutores"
        btnAutores.Size = New Size(79, 38)
        btnAutores.TabIndex = 2
        btnAutores.Text = "Consulta de autores"
        btnAutores.UseVisualStyleBackColor = True
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(306, 94)
        Controls.Add(btnAutores)
        Controls.Add(btnLibros)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menú principal — Biblioteca"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnLibros As Button
    Friend WithEvents btnAutores As Button
End Class
