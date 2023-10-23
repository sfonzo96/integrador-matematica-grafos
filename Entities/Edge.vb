Public Class Edge
    Public Shared Property MaxId As Integer = 0
    Public Property VertexTuple As Tuple(Of Vertex, Vertex)

    Public Sub New(originVertex As Vertex, endVertex As Vertex)
        VertexTuple = New Tuple(Of Vertex, Vertex)(originVertex, endVertex)
        MaxId += 1
    End Sub
End Class
