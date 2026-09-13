Public Class frmConsultaLibros

    'probando el punto 6 (BindingNavigator)
    Private WithEvents bnLibros As BindingNavigator
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblBuscar.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpFiltros.Enter

    End Sub

    Private Sub tlpDetalle_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
