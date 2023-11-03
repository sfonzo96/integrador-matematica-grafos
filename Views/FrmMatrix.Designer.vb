<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatrix
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


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DGridMatrix = New DataGridView()
        CType(DGridMatrix, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGridMatrix
        ' 
        DGridMatrix.AllowUserToAddRows = False
        DGridMatrix.AllowUserToDeleteRows = False
        DGridMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGridMatrix.Dock = DockStyle.Fill
        DGridMatrix.Location = New Point(0, 0)
        DGridMatrix.Name = "DGridMatrix"
        DGridMatrix.ReadOnly = True
        DGridMatrix.RowTemplate.Height = 25
        DGridMatrix.Size = New Size(366, 245)
        DGridMatrix.TabIndex = 0
        ' 
        ' FrmMatrix
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(366, 245)
        Controls.Add(DGridMatrix)
        Name = "FrmMatrix"
        Text = "FrmMatrix"
        CType(DGridMatrix, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    'added
    Private Sub DGridMatrix_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso e.RowIndex < DGridMatrix.RowCount AndAlso e.ColumnIndex < DGridMatrix.ColumnCount Then
            ' Establece el alto y ancho de la celda para que sea cuadrada
            Dim cellSize As Integer = Math.Min(e.CellBounds.Width, e.CellBounds.Height)
            Dim cellBounds As New Rectangle(e.CellBounds.X, e.CellBounds.Y, cellSize, cellSize)

            ' Pinta el fondo de la celda
            e.Paint(e.CellBounds, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border)

            ' Puedes personalizar la apariencia de la celda aquí
            ' Por ejemplo, pinta un círculo en la celda
            Using brush As New SolidBrush(Color.Blue)
                e.Graphics.FillEllipse(brush, cellBounds)
            End Using

            ' Evita que se pinte el contenido predeterminado de la celda
            e.Handled = True
        End If
    End Sub
    'added

    Friend WithEvents DGridMatrix As DataGridView
End Class
