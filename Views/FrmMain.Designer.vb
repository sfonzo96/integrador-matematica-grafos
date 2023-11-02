<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnClearGraph = New Button()
        BtnDrawVertex = New Button()
        BtnDrawEdge = New Button()
        PanelDraw = New Panel()
        Panel1 = New Panel()
        BtnAnalyzeGraph = New Button()
        PanelData = New Panel()
        BtnMatrixIncidence = New Button()
        BtnMatrixAdjacency = New Button()
        LblSelectVertex = New Label()
        CombListSelectVertex = New ComboBox()
        TxtVertexDegree = New TextBox()
        LblVertexDegree = New Label()
        TxtEdgesQuantity = New TextBox()
        TxtTotalDegree = New TextBox()
        TxtVertexQuantity = New TextBox()
        LblTotalDegree = New Label()
        LblEdgesQuantity = New Label()
        LblVertexQuantity = New Label()
        Panel1.SuspendLayout()
        PanelData.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnClearGraph
        ' 
        BtnClearGraph.Location = New Point(222, 6)
        BtnClearGraph.Name = "BtnClearGraph"
        BtnClearGraph.Size = New Size(99, 23)
        BtnClearGraph.TabIndex = 0
        BtnClearGraph.Text = "Limpiar grafo"
        BtnClearGraph.UseVisualStyleBackColor = True
        ' 
        ' BtnDrawVertex
        ' 
        BtnDrawVertex.Location = New Point(12, 6)
        BtnDrawVertex.Name = "BtnDrawVertex"
        BtnDrawVertex.Size = New Size(99, 23)
        BtnDrawVertex.TabIndex = 1
        BtnDrawVertex.Text = "Dibujar vértices"
        BtnDrawVertex.UseVisualStyleBackColor = True
        ' 
        ' BtnDrawEdge
        ' 
        BtnDrawEdge.Location = New Point(117, 6)
        BtnDrawEdge.Name = "BtnDrawEdge"
        BtnDrawEdge.Size = New Size(99, 23)
        BtnDrawEdge.TabIndex = 2
        BtnDrawEdge.Text = "Dibujar aristas"
        BtnDrawEdge.UseVisualStyleBackColor = True
        ' 
        ' PanelDraw
        ' 
        PanelDraw.BackColor = Color.White
        PanelDraw.Location = New Point(9, 44)
        PanelDraw.Name = "PanelDraw"
        PanelDraw.Size = New Size(516, 397)
        PanelDraw.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(BtnAnalyzeGraph)
        Panel1.Controls.Add(BtnDrawVertex)
        Panel1.Controls.Add(BtnDrawEdge)
        Panel1.Controls.Add(BtnClearGraph)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 35)
        Panel1.TabIndex = 4
        ' 
        ' BtnAnalyzeGraph
        ' 
        BtnAnalyzeGraph.Location = New Point(327, 6)
        BtnAnalyzeGraph.Name = "BtnAnalyzeGraph"
        BtnAnalyzeGraph.Size = New Size(99, 23)
        BtnAnalyzeGraph.TabIndex = 3
        BtnAnalyzeGraph.Text = "Analizar grafo"
        BtnAnalyzeGraph.UseVisualStyleBackColor = True
        ' 
        ' PanelData
        ' 
        PanelData.Controls.Add(BtnMatrixIncidence)
        PanelData.Controls.Add(BtnMatrixAdjacency)
        PanelData.Controls.Add(LblSelectVertex)
        PanelData.Controls.Add(CombListSelectVertex)
        PanelData.Controls.Add(TxtVertexDegree)
        PanelData.Controls.Add(LblVertexDegree)
        PanelData.Controls.Add(TxtEdgesQuantity)
        PanelData.Controls.Add(TxtTotalDegree)
        PanelData.Controls.Add(TxtVertexQuantity)
        PanelData.Controls.Add(LblTotalDegree)
        PanelData.Controls.Add(LblEdgesQuantity)
        PanelData.Controls.Add(LblVertexQuantity)
        PanelData.Dock = DockStyle.Right
        PanelData.Location = New Point(534, 35)
        PanelData.Name = "PanelData"
        PanelData.Size = New Size(266, 415)
        PanelData.TabIndex = 5
        ' 
        ' BtnMatrixIncidence
        ' 
        BtnMatrixIncidence.Location = New Point(157, 250)
        BtnMatrixIncidence.Name = "BtnMatrixIncidence"
        BtnMatrixIncidence.Size = New Size(75, 40)
        BtnMatrixIncidence.TabIndex = 11
        BtnMatrixIncidence.Text = "Matriz de incidencia"
        BtnMatrixIncidence.UseVisualStyleBackColor = True
        ' 
        ' BtnMatrixAdjacency
        ' 
        BtnMatrixAdjacency.Location = New Point(34, 250)
        BtnMatrixAdjacency.Name = "BtnMatrixAdjacency"
        BtnMatrixAdjacency.Size = New Size(75, 40)
        BtnMatrixAdjacency.TabIndex = 10
        BtnMatrixAdjacency.Text = "Matriz de adyacencia"
        BtnMatrixAdjacency.UseVisualStyleBackColor = True
        ' 
        ' LblSelectVertex
        ' 
        LblSelectVertex.AutoSize = True
        LblSelectVertex.Location = New Point(9, 153)
        LblSelectVertex.Name = "LblSelectVertex"
        LblSelectVertex.Size = New Size(84, 15)
        LblSelectVertex.TabIndex = 9
        LblSelectVertex.Text = "Vertice elegido"
        ' 
        ' CombListSelectVertex
        ' 
        CombListSelectVertex.FormattingEnabled = True
        CombListSelectVertex.Location = New Point(125, 150)
        CombListSelectVertex.Name = "CombListSelectVertex"
        CombListSelectVertex.Size = New Size(121, 23)
        CombListSelectVertex.TabIndex = 8
        ' 
        ' TxtVertexDegree
        ' 
        TxtVertexDegree.Enabled = False
        TxtVertexDegree.Location = New Point(125, 189)
        TxtVertexDegree.Name = "TxtVertexDegree"
        TxtVertexDegree.ReadOnly = True
        TxtVertexDegree.Size = New Size(126, 23)
        TxtVertexDegree.TabIndex = 7
        ' 
        ' LblVertexDegree
        ' 
        LblVertexDegree.AutoSize = True
        LblVertexDegree.Location = New Point(9, 192)
        LblVertexDegree.Name = "LblVertexDegree"
        LblVertexDegree.Size = New Size(39, 15)
        LblVertexDegree.TabIndex = 6
        LblVertexDegree.Text = "Grado"
        ' 
        ' TxtEdgesQuantity
        ' 
        TxtEdgesQuantity.Enabled = False
        TxtEdgesQuantity.Location = New Point(125, 69)
        TxtEdgesQuantity.Name = "TxtEdgesQuantity"
        TxtEdgesQuantity.ReadOnly = True
        TxtEdgesQuantity.Size = New Size(126, 23)
        TxtEdgesQuantity.TabIndex = 5
        ' 
        ' TxtTotalDegree
        ' 
        TxtTotalDegree.Enabled = False
        TxtTotalDegree.Location = New Point(125, 111)
        TxtTotalDegree.Name = "TxtTotalDegree"
        TxtTotalDegree.ReadOnly = True
        TxtTotalDegree.Size = New Size(126, 23)
        TxtTotalDegree.TabIndex = 4
        ' 
        ' TxtVertexQuantity
        ' 
        TxtVertexQuantity.Enabled = False
        TxtVertexQuantity.Location = New Point(125, 27)
        TxtVertexQuantity.Name = "TxtVertexQuantity"
        TxtVertexQuantity.ReadOnly = True
        TxtVertexQuantity.Size = New Size(126, 23)
        TxtVertexQuantity.TabIndex = 3
        ' 
        ' LblTotalDegree
        ' 
        LblTotalDegree.AutoSize = True
        LblTotalDegree.Location = New Point(9, 114)
        LblTotalDegree.Name = "LblTotalDegree"
        LblTotalDegree.Size = New Size(66, 15)
        LblTotalDegree.TabIndex = 2
        LblTotalDegree.Text = "Grado total"
        ' 
        ' LblEdgesQuantity
        ' 
        LblEdgesQuantity.AutoSize = True
        LblEdgesQuantity.Location = New Point(9, 72)
        LblEdgesQuantity.Name = "LblEdgesQuantity"
        LblEdgesQuantity.Size = New Size(103, 15)
        LblEdgesQuantity.TabIndex = 1
        LblEdgesQuantity.Text = "Número de aristas"
        ' 
        ' LblVertexQuantity
        ' 
        LblVertexQuantity.AutoSize = True
        LblVertexQuantity.Location = New Point(9, 30)
        LblVertexQuantity.Name = "LblVertexQuantity"
        LblVertexQuantity.Size = New Size(110, 15)
        LblVertexQuantity.TabIndex = 0
        LblVertexQuantity.Text = "Número de vértices"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(800, 450)
        Controls.Add(PanelData)
        Controls.Add(Panel1)
        Controls.Add(PanelDraw)
        Name = "FrmMain"
        Text = "FrmMain"
        Panel1.ResumeLayout(False)
        PanelData.ResumeLayout(False)
        PanelData.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnClearGraph As Button
    Friend WithEvents BtnDrawVertex As Button
    Friend WithEvents BtnDrawEdge As Button
    Friend WithEvents PanelDraw As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAnalyzeGraph As Button
    Friend WithEvents PanelData As Panel
    Friend WithEvents LblTotalDegree As Label
    Friend WithEvents LblEdgesQuantity As Label
    Friend WithEvents LblVertexQuantity As Label
    Friend WithEvents TxtEdgesQuantity As TextBox
    Friend WithEvents TxtTotalDegree As TextBox
    Friend WithEvents TxtVertexQuantity As TextBox
    Friend WithEvents TxtVertexDegree As TextBox
    Friend WithEvents LblVertexDegree As Label
    Friend WithEvents LblSelectVertex As Label
    Friend WithEvents CombListSelectVertex As ComboBox
    Friend WithEvents BtnMatrixIncidence As Button
    Friend WithEvents BtnMatrixAdjacency As Button
End Class
