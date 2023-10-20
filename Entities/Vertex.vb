Public Class Vertex
    Public Shared MaxId As Integer = 1
    Public Property VertexId As Integer
    Public Property Position As Point
    Public Property Radius As Integer
    Public Property Degree As Integer = 0

    Public Sub New(positionX As Integer, positionY As Integer, radius As Decimal)
        VertexId = MaxId
        Vertex.MaxId = MaxId + 1
        Position = New Point(positionX, positionY)
        Me.Radius = radius
    End Sub

    Public Function IsInRange(positionX As Point, positionY As Point) As Boolean

        Return True
    End Function
End Class
