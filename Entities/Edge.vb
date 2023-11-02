Imports System.Net

Public Class Edge
    Public Shared Property MaxId As Integer = 0
    Public Property VertexTuple As Tuple(Of Integer, Integer)

    Public Sub New(originVertex As Integer, endVertex As Integer)
        VertexTuple = New Tuple(Of Integer, Integer)(originVertex, endVertex)
        MaxId += 1
    End Sub
End Class
