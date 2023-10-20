Public Class FrmGraph
    Private Shared Radius As Decimal = 15
    Private Shared FirstPoint As Point = Nothing
    Private Shared SecondPoint As Point = Nothing
    Private Shared DrawingLine As Boolean = False
    Private Sub FrmGraph_Click(sender As Object, e As MouseEventArgs) Handles MyBase.Click
        Dim graphics As Graphics
        graphics = CreateGraphics()

        If FrmMain.SelectedDrawing = "Vertex" Then
            Using pen As New Pen(Color.Black)
                Dim clientCursorPosition As Point = PointToClient(Cursor.Position)
                graphics.DrawEllipse(pen, clientCursorPosition.X - Radius / 2, clientCursorPosition.Y - Radius / 2, Radius, Radius)
            End Using
        End If

        If FrmMain.SelectedDrawing = "Edge" Then
            If FirstPoint = Nothing Then
                FirstPoint = PointToClient(Cursor.Position)
                DrawingLine = True
            ElseIf SecondPoint = Nothing Then
                SecondPoint = PointToClient(Cursor.Position)
                DrawingLine = False
            End If

            If DrawingLine = False Then
                Using pen As New Pen(Color.Red)
                    graphics.DrawLine(pen, FirstPoint, SecondPoint)
                End Using

                FirstPoint = Nothing
                SecondPoint = Nothing
            End If
        End If
    End Sub
End Class