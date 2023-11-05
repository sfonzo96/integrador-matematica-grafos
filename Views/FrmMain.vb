Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmMain
    Public Shared Property SelectedDrawing As String = "Vertex"

    Private Sub BtnClearGraph_Click(sender As Object, e As EventArgs) Handles BtnClearGraph.Click
        ResetMainForm()
        ResetAnalisis()
        SetBtnColor(BtnDrawVertex, "red")
        SetBtnColor(BtnDrawEdge, "blue")
    End Sub

    Private Sub BtnDrawEdge_Click(sender As Object, e As EventArgs) Handles BtnDrawEdge.Click
        SelectedDrawing = "Edge"
        SetBtnColor(BtnDrawVertex, "blue")
        SetBtnColor(BtnDrawEdge, "red")
    End Sub

    Private Sub BtnDrawVertex_Click(sender As Object, e As EventArgs) Handles BtnDrawVertex.Click
        SelectedDrawing = "Vertex"
        SetBtnColor(BtnDrawVertex, "red")
        SetBtnColor(BtnDrawEdge, "blue")
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
        SetBtnColor(BtnDrawVertex, "red")
        SetBtnColor(BtnDrawEdge, "blue")
    End Sub

    Private Sub ListVertex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombListSelectVertex.SelectedIndexChanged
        Dim vertexId As Integer = CombListSelectVertex.SelectedItem.ToString().Substring(1)
        TxtVertexDegree.Text = VertexService.Vertexes.FirstOrDefault(Function(v) v.VertexId = vertexId)?.Degree
    End Sub

    Private Sub BtnMatrixAdjacency_Click(sender As Object, e As EventArgs) Handles BtnMatrixAdjacency.Click
        Dim frmMatrix As New FrmMatrix With {
                .Text = "Matriz de adyacencia"
        }

        Dim adjacencyMatrix As Integer(,) = MatrixService.GetAdjacencyMatrix
        Dim numberOfColumns As Integer = adjacencyMatrix.GetLength(1)
        Dim numberOfRows As Integer = adjacencyMatrix.GetLength(0)

        frmMatrix.DGridMatrix.ColumnCount = numberOfColumns
        frmMatrix.DGridMatrix.RowCount = numberOfRows

        For rowIndex As Integer = 0 To numberOfRows - 1
            With frmMatrix.DGridMatrix.Rows(rowIndex)
                .HeaderCell.Value = $"v{rowIndex + 1}"
                .Height = 50
            End With

            For columnIndex As Integer = 0 To numberOfColumns - 1
                With frmMatrix.DGridMatrix.Columns(columnIndex)
                    .HeaderText = $"v{columnIndex + 1}"
                    .SortMode = False
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    .Resizable = DataGridViewTriState.False
                    .ReadOnly = True
                    .Width = 50
                End With

                frmMatrix.DGridMatrix(columnIndex, rowIndex).Value = adjacencyMatrix(rowIndex, columnIndex).ToString()
            Next
        Next

        With frmMatrix.DGridMatrix
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AllowDrop = False
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 50
            .RowHeadersWidth = 50
        End With

        Dim requiredWidth As Integer = frmMatrix.DGridMatrix.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + SystemInformation.VerticalScrollBarWidth + 50
        Dim requiredHeight As Integer = frmMatrix.DGridMatrix.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + SystemInformation.HorizontalScrollBarHeight + 50

        frmMatrix.ClientSize = New Size(requiredWidth, requiredHeight)
        frmMatrix.ShowDialog()

        SetBtnColor(BtnDrawVertex, "red")
        SetBtnColor(BtnDrawEdge, "blue")
    End Sub

    Private Sub BtnMatrixIncidence_Click(sender As Object, e As EventArgs) Handles BtnMatrixIncidence.Click
        Dim frmMatrix As New FrmMatrix With {
            .Text = "Matriz de incidencia"
        }

        Dim incidenceMatrix As Integer(,) = MatrixService.GetIncidenceMatrix
        Dim numberOfColumns As Integer = incidenceMatrix.GetLength(1)
        Dim numberOfRows As Integer = incidenceMatrix.GetLength(0)

        frmMatrix.DGridMatrix.ColumnCount = numberOfColumns
        frmMatrix.DGridMatrix.RowCount = numberOfRows

        For rowIndex As Integer = 0 To numberOfRows - 1
            With frmMatrix.DGridMatrix.Rows(rowIndex)
                .HeaderCell.Value = $"v{rowIndex + 1}"
                .Height = 50
            End With

            For columnIndex As Integer = 0 To numberOfColumns - 1
                With frmMatrix.DGridMatrix.Columns(columnIndex)
                    .HeaderText = $"e{columnIndex + 1}"
                    .SortMode = False
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    .Resizable = DataGridViewTriState.False
                    .ReadOnly = True
                    .Width = 50
                End With

                frmMatrix.DGridMatrix(columnIndex, rowIndex).Value = incidenceMatrix(rowIndex, columnIndex).ToString()
            Next
        Next

        With frmMatrix.DGridMatrix
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .AllowDrop = False
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 50
            .RowHeadersWidth = 50
        End With

        Dim requiredWidth As Integer = frmMatrix.DGridMatrix.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + SystemInformation.VerticalScrollBarWidth + 50
        Dim requiredHeight As Integer = frmMatrix.DGridMatrix.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + SystemInformation.HorizontalScrollBarHeight + 50

        frmMatrix.ClientSize = New Size(requiredWidth, requiredHeight)
        frmMatrix.ShowDialog()

        SetBtnColor(BtnDrawVertex, "red")
        SetBtnColor(BtnDrawEdge, "blue")
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnDrawVertex.BackColor = Color.Red
    End Sub

    Private Sub ResetBtnColor()
        BtnDrawVertex.BackColor = Color.RoyalBlue
        BtnDrawEdge.BackColor = Color.RoyalBlue
    End Sub

    Private Sub SetBtnColor(ByRef button As Control, btnColor As String)
        If btnColor = "blue" Then
            button.BackColor = Color.RoyalBlue
            Return
        End If

        button.BackColor = Color.Red
    End Sub

    Private Sub LoadVertexList()
        For Each vertex In VertexService.Vertexes
            CombListSelectVertex.Items.Add($"v{vertex.VertexId}")
        Next
        CombListSelectVertex.DropDownHeight = CombListSelectVertex.ItemHeight * (CombListSelectVertex.Items.Count + 1)
    End Sub

    Private Sub ResetMainForm()
        PanelDraw.Refresh()
        VertexService.Vertexes.Clear()
        EdgeService.Edges.Clear()
        Vertex.MaxId = 0
        Edge.MaxId = 0
        FrmMain.SelectedDrawing = "Vertex"
    End Sub

    Private Sub ResetAnalisis()
        TxtEdgesQuantity.Clear()
        TxtVertexQuantity.Clear()
        TxtTotalDegree.Clear()
        TxtVertexDegree.Clear()
        CombListSelectVertex.Items.Clear()
        CombListSelectVertex.ResetText()
        CombListSelectVertex.DropDownHeight = CombListSelectVertex.ItemHeight
    End Sub
End Class