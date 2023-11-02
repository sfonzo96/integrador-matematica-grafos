Public Class Vertex
    Public Shared Property MaxId As Integer = 0
    Public Property VertexId As Integer
    Public Property Position As Point
    Public Property Radius As Integer
    Public Property Degree As Integer = 0
    Public Sub New(position As Point, radius As Decimal)
        MaxId += 1
        VertexId = MaxId
        Me.Position = position
        Me.Radius = radius
    End Sub
End Class