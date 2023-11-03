
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
        Dim clientCursorPosition As Point = FormGraph.PointToClient(Cursor.Position)
        If IsOverAVertex(clientCursorPosition) Then
            MessageBox.Show("Los vértices deben estar más separados!")
            Return
        End If
        Using graphics As Graphics = FormGraph.CreateGraphics()
            Using brush As New SolidBrush(Color.Blue)
                clientCursorPosition.X -= VertexRadius / 2
                clientCursorPosition.Y -= VertexRadius / 2
                graphics.FillEllipse(brush, clientCursorPosition.X, clientCursorPosition.Y, VertexRadius, VertexRadius)
                VertexService.Vertexes.Add(New Vertex(clientCursorPosition, VertexRadius))
                Dim lastVertex As Vertex = VertexService.Vertexes.LastOrDefault
                graphics.DrawString($"{lastVertex.VertexId}", FrmMain.Font, Brushes.Black, lastVertex.Position.X - VertexRadius, lastVertex.Position.Y - VertexRadius)
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

                If IsALoop(EdgeFirstVertex.Position, EdgeSecondVertex.Position) Then
                    MessageBox.Show("Los bucles todavía no están habilitados :)")
                    ResetDrawing()
                    Return
                End If

                If AlreadyAnEdge(EdgeFirstVertex.Position, EdgeSecondVertex.Position, EdgeService.Edges) Then
                    MessageBox.Show("Solo se pueden dibujar grafos simples :)")
                    ResetDrawing()
                    Return
                End If

                Using pen As New Pen(Color.Blue)
                    graphics.DrawLine(pen, EdgeFirstVertex.Position + New Point(VertexRadius / 2, VertexRadius / 2), EdgeSecondVertex.Position + New Point(VertexRadius / 2, VertexRadius / 2))
                    EdgeService.Edges.Add(New Edge(EdgeFirstVertex, EdgeSecondVertex))
                    EdgeFirstVertex.Degree += 1
                    EdgeSecondVertex.Degree += 1

                    Dim middlePoint As PointF = New PointF((EdgeFirstVertex.Position.X + EdgeSecondVertex.Position.X - 30) / 2, (EdgeFirstVertex.Position.Y + EdgeSecondVertex.Position.Y - 30) / 2) ' el -30 es provisorio
                    Dim lastEdge As Edge = EdgeService.Edges.LastOrDefault
                    graphics.DrawString($"{lastEdge.EdgeId}", FrmMain.Font, Brushes.Black, middlePoint)
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
    Public Function IsOverAVertex(newVertexPoint As Point) As Boolean
        For Each vertex In VertexService.Vertexes
            Dim distance As Decimal = Math.Sqrt((newVertexPoint.X - VertexRadius / 2 - vertex.Position.X) ^ 2 + (newVertexPoint.Y - VertexRadius / 2 - vertex.Position.Y) ^ 2)
            If distance < 2 * VertexRadius Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ResetDrawing()
        EdgeFirstVertex = Nothing
        EdgeSecondVertex = Nothing
        DrawingLine = False
    End Sub

    Private Function IsALoop(firstPoint As Point, secondPoint As Point) As Boolean
        Return firstPoint = secondPoint
    End Function

    Private Function AlreadyAnEdge(firstPoint As Point, secondPoint As Point, edges As List(Of Edge)) As Boolean
        For Each edge In edges
            If (edge.VertexTuple.Item1.Position = firstPoint OrElse edge.VertexTuple.Item1.Position = secondPoint) AndAlso (edge.VertexTuple.Item2.Position = firstPoint OrElse edge.VertexTuple.Item2.Position = secondPoint) Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
