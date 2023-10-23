
Public Class DrawingService
    Private Property VertexRadius As Decimal = 15
    Public Property EdgeFirstVertex As Vertex = Nothing
    Public Property EdgeSecondVertex As Vertex = Nothing
    Private Property DrawingLine As Boolean = False
    Private Property FormGraph As Form
    Public Sub New(form As Form)
        FormGraph = form
    End Sub
    Public Sub DrawVertex()
        Using graphics As Graphics = FormGraph.CreateGraphics()
            Using pen As New Pen(Color.Black)
                Dim clientCursorPosition As Point = FormGraph.PointToClient(Cursor.Position)
                clientCursorPosition.X -= VertexRadius / 2
                clientCursorPosition.Y -= VertexRadius / 2
                graphics.DrawEllipse(pen, clientCursorPosition.X, clientCursorPosition.Y, VertexRadius, VertexRadius)
                VertexService.Vertexes.Add(New Vertex(clientCursorPosition, VertexRadius))
            End Using
        End Using
    End Sub
    Public Sub DrawEdge()
        Using graphics As Graphics = FormGraph.CreateGraphics()
            Dim edgeService As New EdgeService

            If EdgeFirstVertex Is Nothing Then
                Dim firstClick As Point = FormGraph.PointToClient(Cursor.Position)

                EdgeFirstVertex = GetClickedVertex(firstClick)
                If EdgeFirstVertex Is Nothing Then
                    MessageBox.Show("Tenés que clickear un vértice!")
                    ResetDrawing()
                    Return
                End If
                DrawingLine = True
                Return
            ElseIf EdgeSecondVertex Is Nothing Then
                Dim secondClick As Point = FormGraph.PointToClient(Cursor.Position)

                EdgeSecondVertex = GetClickedVertex(secondClick)
                If EdgeSecondVertex Is Nothing Then
                    MessageBox.Show("Tenés que clickear un vértice!")
                    ResetDrawing()
                    Return
                End If
                DrawingLine = False

                Using pen As New Pen(Color.Red)
                    graphics.DrawLine(pen, EdgeFirstVertex.Position + New Point(VertexRadius / 2, VertexRadius / 2), EdgeSecondVertex.Position + New Point(VertexRadius / 2, VertexRadius / 2))
                    EdgeService.Edges.Add(New Edge(EdgeFirstVertex, EdgeSecondVertex))
                    EdgeFirstVertex.Degree += 1
                    EdgeSecondVertex.Degree += 1
                End Using

                ResetDrawing()
            End If
        End Using
    End Sub
    Public Function GetClickedVertex(edgePoint As Point) As Vertex
        For Each vertex In VertexService.Vertexes
            Dim distance As Decimal = Math.Sqrt(((edgePoint.X - VertexRadius / 2) - vertex.Position.X) ^ 2 + ((edgePoint.Y - VertexRadius / 2) - vertex.Position.Y) ^ 2)
            If distance < VertexRadius Then
                Return vertex
            End If
        Next
        Return Nothing
    End Function

    Public Sub ResetDrawing()
        EdgeFirstVertex = Nothing
        EdgeSecondVertex = Nothing
        DrawingLine = False
    End Sub
End Class
