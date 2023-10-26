Imports System.Drawing.Text

Public Class FrmMain
    Public Shared Property SelectedDrawing As String = "Vertex"

    Private Sub BtnClearGraph_Click(sender As Object, e As EventArgs) Handles BtnClearGraph.Click
        ResetMainForm()
        ResetAnalisis()
    End Sub

    Private Sub BtnDrawEdge_Click(sender As Object, e As EventArgs) Handles BtnDrawEdge.Click
        SelectedDrawing = "Edge"
    End Sub

    Private Sub BtnDrawVertex_Click(sender As Object, e As EventArgs) Handles BtnDrawVertex.Click
        SelectedDrawing = "Vertex"
    End Sub

    Private Sub PanelDraw_Paint(sender As Object, e As PaintEventArgs) Handles PanelDraw.Paint
        Dim frmGraph As New FrmGraph With {
            .TopLevel = False,
            .Dock = DockStyle.Fill
        }
        PanelDraw.Controls.Add(frmGraph)
        frmGraph.Show()
    End Sub

    Private Sub BtnAnalyzeGraph_Click(sender As Object, e As EventArgs) Handles BtnAnalyzeGraph.Click
        ResetAnalisis()
        TxtEdgesQuantity.Text = Edge.MaxId
        TxtVertexQuantity.Text = Vertex.MaxId
        TxtTotalDegree.Text = VertexService.GetTotalDegree()
        LoadVertexList()
    End Sub

    Private Sub ListVertex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombListSelectVertex.SelectedIndexChanged
        Dim vertexId As Integer = CombListSelectVertex.SelectedItem.ToString()
        TxtVertexDegree.Text = VertexService.Vertexes.FirstOrDefault(Function(v) v.VertexId = vertexId)?.Degree
    End Sub

    Private Sub LoadVertexList()
        For Each vertex In VertexService.Vertexes
            CombListSelectVertex.Items.Add(vertex.VertexId)
        Next
    End Sub
    Private Sub ResetMainForm()
        PanelDraw.Refresh()
        VertexService.Vertexes.Clear()
        EdgeService.Edges.Clear()
        Vertex.MaxId = 0
        Edge.MaxId = 0
    End Sub
    Private Sub ResetAnalisis()
        TxtEdgesQuantity.Clear()
        TxtVertexQuantity.Clear()
        TxtTotalDegree.Clear()
        TxtVertexDegree.Clear()
        CombListSelectVertex.Items.Clear()
    End Sub

    Private Sub BtnMatrixAdjacency_Click(sender As Object, e As EventArgs) Handles BtnMatrixAdjacency.Click
        Dim frmMatrix As New FrmMatrix()
        Dim adjacencyMatrix As Integer(,) = MatrixService.GetAdjacencyMatrix
        Dim numberOfColumns As Integer = adjacencyMatrix.GetLength(1)
        Dim numberOfRows As Integer = adjacencyMatrix.GetLength(0)

        frmMatrix.DGridMatrix.ColumnCount = numberOfColumns
        frmMatrix.DGridMatrix.RowCount = numberOfRows

        For rowIndex As Integer = 0 To numberOfRows - 1
            For columnIndex As Integer = 0 To numberOfColumns - 1
                frmMatrix.DGridMatrix(columnIndex, rowIndex).Value = adjacencyMatrix(rowIndex, columnIndex).ToString()
            Next
        Next

        frmMatrix.ShowDialog()
    End Sub

    Private Sub BtnMatrixIncidence_Click(sender As Object, e As EventArgs) Handles BtnMatrixIncidence.Click
        Dim frmMatrix As New FrmMatrix()
        Dim incidenceMatrix As Integer(,) = MatrixService.GetIncidenceMatrix
        Dim numberOfColumns As Integer = incidenceMatrix.GetLength(1)
        Dim numberOfRows As Integer = incidenceMatrix.GetLength(0)

        frmMatrix.DGridMatrix.ColumnCount = numberOfColumns
        frmMatrix.DGridMatrix.RowCount = numberOfRows

        For rowIndex As Integer = 0 To numberOfRows - 1
            For columnIndex As Integer = 0 To numberOfColumns - 1
                frmMatrix.DGridMatrix(columnIndex, rowIndex).Value = incidenceMatrix(rowIndex, columnIndex).ToString()
            Next
        Next

        frmMatrix.ShowDialog()
    End Sub
End Class