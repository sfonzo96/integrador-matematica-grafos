Public Class FrmMain
    Public Shared Vertexes As List(Of Vertex)
    Public Shared Edges As List(Of Edge)
    Public Shared SelectedDrawing As String = "Vertex"


    Private Sub BtnClearGraph_Click(sender As Object, e As EventArgs) Handles BtnClearGraph.Click
        'PanelDraw.Invalidate()
        PanelDraw.Controls.Clear()
    End Sub

    Private Sub BtnDrawEdge_Click(sender As Object, e As EventArgs) Handles BtnDrawEdge.Click
        SelectedDrawing = "Edge"
    End Sub

    Private Sub BtnDrawVertex_Click(sender As Object, e As EventArgs) Handles BtnDrawVertex.Click
        SelectedDrawing = "Vertex"
    End Sub

    Private Sub PanelDraw_Paint(sender As Object, e As PaintEventArgs) Handles PanelDraw.Paint
        Dim frmGraph As New FrmGraph()

        frmGraph.TopLevel = False
        frmGraph.Dock = DockStyle.Fill
        PanelDraw.Controls.Add(frmGraph)
        frmGraph.Show()
    End Sub

    Private Sub BtnAnalyzeGraph_Click(sender As Object, e As EventArgs) Handles BtnAnalyzeGraph.Click
        TxtVertexQuantity.Text = FrmGraph.VertexCount.ToString()
        TxtEdgesQuantity.Text = (FrmGraph.EdgeCount / 2).ToString()
    End Sub
End Class
