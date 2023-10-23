Public Class Edge
    Public Property VertexTuple As Tuple(Of Integer, Integer)

    Public Sub New(originVertex As Integer, endVertex As Integer)
        VertexTuple = New Tuple(Of Integer, Integer)(originVertex, endVertex)
    End Sub
End Class
