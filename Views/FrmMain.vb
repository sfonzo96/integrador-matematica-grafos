Public Class FrmMain

    Public Shared Property SelectedDrawing As String = "Vertex"

    Private Sub BtnClearGraph_Click(sender As Object, e As EventArgs) Handles BtnClearGraph.Click
        ResetMainForm()
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
        TxtEdgesQuantity.Clear()
        TxtVertexQuantity.Clear()
        TxtTotalDegree.Clear()
        TxtVertexDegree.Clear()
        CombListSelectVertex.Items.Clear()
    End Sub
End Class
