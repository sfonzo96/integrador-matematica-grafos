Public Class VertexService
    Public Shared Property Vertexes As New List(Of Vertex)
    Public Shared Property AdjacencyMatrix As New List(Of Integer())
    Public Shared Property IncidenceMatrix As New List(Of Integer())
    Public Shared Function GetTotalDegree()
        Dim totalDegree As Integer = 0
        For Each vertex In Vertexes
            totalDegree += vertex.Degree
        Next
        Return totalDegree
    End Function

    Public Sub DefineAdjacencyMatrix()
        For rowIndex As Integer = 0 To Len(Vertexes)

            For columnIndex As Integer = 0 To Len(Vertexes)

                For Each edge In EdgeService.Edges
                    If edge.VertexTuple.Item1 Is Vertexes(rowIndex) AndAlso edge.VertexTuple.Item2 Is Vertexes(columnIndex) Then
                        AdjacencyMatrix(rowIndex)(columnIndex) = 1
                    Else
                        AdjacencyMatrix(rowIndex)(columnIndex) = 0
                    End If
                Next

            Next

        Next
    End Sub

    Public Sub DefineIncidenceMatrix()
        For rowIndex As Integer = 0 To Len(Vertexes)

            For columnIndex As Integer = 0 To Len(EdgeService.Edges)

                For Each edge In EdgeService.Edges
                    If edge.VertexTuple.Item1 Is Vertexes(rowIndex) AndAlso edge.VertexTuple.Item2 Is Vertexes(columnIndex) Then
                        AdjacencyMatrix(rowIndex)(columnIndex) = 1
                    Else
                        AdjacencyMatrix(rowIndex)(columnIndex) = 0
                    End If
                Next

            Next

        Next
    End Sub
End Class
