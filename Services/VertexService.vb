Public Class VertexService
    Public Shared Property Vertexes As New List(Of Vertex)
    Public Shared Function GetDegreeSum()
        Dim totalDegree As Integer = 0
        For Each vertex In Vertexes
            totalDegree += vertex.Degree
        Next
        Return totalDegree
    End Function
End Class
