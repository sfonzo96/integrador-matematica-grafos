Imports System.Windows.Forms.VisualStyles

Public Class MatrixService
    Public Shared Function GetAdjacencyMatrix() As Integer(,)
        Dim vertexQuantity As Integer = VertexService.Vertexes.Count
        Dim adjacencyMatrix(vertexQuantity - 1, vertexQuantity - 1) As Integer

        For rowIndex As Integer = 0 To VertexService.Vertexes.Count - 1
            For columnIndex As Integer = 0 To VertexService.Vertexes.Count - 1

                If EdgeService.Edges.FirstOrDefault(Function(edge) VertexesAreAdjacent(rowIndex, columnIndex, edge.VertexTuple)) IsNot Nothing Then
                    adjacencyMatrix(rowIndex, columnIndex) = 1
                Else
                    adjacencyMatrix(rowIndex, columnIndex) = 0
                End If

            Next
        Next
        Return adjacencyMatrix
    End Function

    Private Shared Function VertexesAreAdjacent(rowIndex As Integer, columnIndex As Integer, vertexTuple As Tuple(Of Vertex, Vertex)) As Boolean
        If (vertexTuple.Item1 Is VertexService.Vertexes(rowIndex) AndAlso
            vertexTuple.Item2 Is VertexService.Vertexes(columnIndex)) OrElse
            (vertexTuple.Item2 Is VertexService.Vertexes(rowIndex) AndAlso
            vertexTuple.Item1 Is VertexService.Vertexes(columnIndex)) Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function GetIncidenceMatrix() As Integer(,)
        Dim vertexQuantity As Integer = VertexService.Vertexes.Count
        Dim edgesQuantity As Integer = EdgeService.Edges.Count
        Dim incidenceMatrix(vertexQuantity - 1, edgesQuantity - 1) As Integer
        For rowIndex As Integer = 0 To VertexService.Vertexes.Count - 1
            For columnIndex As Integer = 0 To EdgeService.Edges.Count - 1

                If EdgeIncidesVertex(rowIndex, EdgeService.Edges(columnIndex).VertexTuple) Then
                    incidenceMatrix(rowIndex, columnIndex) = 1
                Else
                    incidenceMatrix(rowIndex, columnIndex) = 0
                End If
            Next
        Next
        Return incidenceMatrix
    End Function

    Private Shared Function EdgeIncidesVertex(rowIndex As Integer, vertexTuple As Tuple(Of Vertex, Vertex)) As Boolean
        If vertexTuple.Item1 Is VertexService.Vertexes(rowIndex) OrElse vertexTuple.Item2 Is VertexService.Vertexes(rowIndex) Then
            Return True
        End If
        Return False
    End Function
End Class
