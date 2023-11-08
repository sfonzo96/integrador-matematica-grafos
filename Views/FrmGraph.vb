Public Class FrmGraph
    Private Property DrawingService As DrawingService
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DrawingService = New DrawingService(Me)
    End Sub
    Private Sub FrmGraph_Click(sender As Object, e As MouseEventArgs) Handles MyBase.Click
        Try
            If FrmMain.SelectedDrawing = "Vertex" Then
                DrawingService.DrawVertex()
            End If

            If FrmMain.SelectedDrawing = "Edge" Then
                DrawingService.DrawEdge()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error, intentalo nuevamente.")
        End Try
    End Sub
End Class