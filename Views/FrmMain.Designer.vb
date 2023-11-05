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
        PanelDraw = New Panel()
        BtnAnalyzeGraph = New Button()
        BtnClearGraph = New Button()
        Panel1 = New Panel()
        BtnDrawVertex = New Button()
        BtnDrawEdge = New Button()
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
        ' PanelDraw
        ' 
        PanelDraw.BackColor = Color.White
        PanelDraw.Location = New Point(9, 56)
        PanelDraw.Name = "PanelDraw"
        PanelDraw.Size = New Size(540, 397)
        PanelDraw.TabIndex = 3
        ' 
        ' BtnAnalyzeGraph
        ' 
        BtnAnalyzeGraph.BackColor = Color.RoyalBlue
        BtnAnalyzeGraph.FlatAppearance.BorderSize = 0
        BtnAnalyzeGraph.FlatStyle = FlatStyle.Flat
        BtnAnalyzeGraph.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAnalyzeGraph.ForeColor = SystemColors.ControlLightLight
        BtnAnalyzeGraph.Location = New Point(281, 9)
        BtnAnalyzeGraph.Name = "BtnAnalyzeGraph"
        BtnAnalyzeGraph.Size = New Size(131, 39)
        BtnAnalyzeGraph.TabIndex = 2
        BtnAnalyzeGraph.Text = "ANALIZAR GRAFO"
        BtnAnalyzeGraph.UseVisualStyleBackColor = False
        ' 
        ' BtnClearGraph
        ' 
        BtnClearGraph.BackColor = Color.RoyalBlue
        BtnClearGraph.FlatAppearance.BorderSize = 0
        BtnClearGraph.FlatStyle = FlatStyle.Flat
        BtnClearGraph.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClearGraph.ForeColor = SystemColors.ControlLightLight
        BtnClearGraph.Location = New Point(418, 9)
        BtnClearGraph.Name = "BtnClearGraph"
        BtnClearGraph.Size = New Size(131, 39)
        BtnClearGraph.TabIndex = 3
        BtnClearGraph.Text = "LIMPIAR GRAFO"
        BtnClearGraph.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(21))
        Panel1.Controls.Add(BtnClearGraph)
        Panel1.Controls.Add(BtnDrawVertex)
        Panel1.Controls.Add(BtnAnalyzeGraph)
        Panel1.Controls.Add(BtnDrawEdge)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(830, 50)
        Panel1.TabIndex = 4
        ' 
        ' BtnDrawVertex
        ' 
        BtnDrawVertex.BackColor = Color.RoyalBlue
        BtnDrawVertex.FlatAppearance.BorderSize = 0
        BtnDrawVertex.FlatStyle = FlatStyle.Flat
        BtnDrawVertex.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDrawVertex.ForeColor = SystemColors.ControlLightLight
        BtnDrawVertex.Location = New Point(7, 9)
        BtnDrawVertex.Name = "BtnDrawVertex"
        BtnDrawVertex.Size = New Size(131, 39)
        BtnDrawVertex.TabIndex = 0
        BtnDrawVertex.Text = "DIBUJAR VÉRTICES"
        BtnDrawVertex.UseVisualStyleBackColor = False
        ' 
        ' BtnDrawEdge
        ' 
        BtnDrawEdge.BackColor = Color.RoyalBlue
        BtnDrawEdge.FlatAppearance.BorderSize = 0
        BtnDrawEdge.FlatStyle = FlatStyle.Flat
        BtnDrawEdge.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDrawEdge.ForeColor = SystemColors.ControlLightLight
        BtnDrawEdge.Location = New Point(144, 9)
        BtnDrawEdge.Name = "BtnDrawEdge"
        BtnDrawEdge.Size = New Size(131, 39)
        BtnDrawEdge.TabIndex = 1
        BtnDrawEdge.Text = "DIBUJAR ARISTAS"
        BtnDrawEdge.UseVisualStyleBackColor = False
        ' 
        ' PanelData
        ' 
        PanelData.BackColor = Color.Transparent
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
        PanelData.ForeColor = SystemColors.ControlLightLight
        PanelData.Location = New Point(564, 50)
        PanelData.Name = "PanelData"
        PanelData.Size = New Size(266, 413)
        PanelData.TabIndex = 5
        ' 
        ' BtnMatrixIncidence
        ' 
        BtnMatrixIncidence.BackColor = Color.RoyalBlue
        BtnMatrixIncidence.FlatAppearance.BorderSize = 0
        BtnMatrixIncidence.FlatStyle = FlatStyle.Flat
        BtnMatrixIncidence.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMatrixIncidence.ForeColor = SystemColors.ControlLightLight
        BtnMatrixIncidence.Location = New Point(34, 327)
        BtnMatrixIncidence.Name = "BtnMatrixIncidence"
        BtnMatrixIncidence.Size = New Size(198, 49)
        BtnMatrixIncidence.TabIndex = 12
        BtnMatrixIncidence.Text = "MATRIZ DE INCIDENCIA"
        BtnMatrixIncidence.UseVisualStyleBackColor = False
        ' 
        ' BtnMatrixAdjacency
        ' 
        BtnMatrixAdjacency.BackColor = Color.RoyalBlue
        BtnMatrixAdjacency.FlatAppearance.BorderSize = 0
        BtnMatrixAdjacency.FlatStyle = FlatStyle.Flat
        BtnMatrixAdjacency.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMatrixAdjacency.ForeColor = SystemColors.ControlLightLight
        BtnMatrixAdjacency.Location = New Point(34, 245)
        BtnMatrixAdjacency.Name = "BtnMatrixAdjacency"
        BtnMatrixAdjacency.Size = New Size(198, 49)
        BtnMatrixAdjacency.TabIndex = 4
        BtnMatrixAdjacency.Text = "MATRIZ DE ADYACENCIA"
        BtnMatrixAdjacency.UseVisualStyleBackColor = False
        ' 
        ' LblSelectVertex
        ' 
        LblSelectVertex.AutoSize = True
        LblSelectVertex.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblSelectVertex.ForeColor = SystemColors.ControlLightLight
        LblSelectVertex.Location = New Point(4, 152)
        LblSelectVertex.Name = "LblSelectVertex"
        LblSelectVertex.Size = New Size(92, 16)
        LblSelectVertex.TabIndex = 9
        LblSelectVertex.Text = "Vértice elegido"
        ' 
        ' CombListSelectVertex
        ' 
        CombListSelectVertex.FormattingEnabled = True
        CombListSelectVertex.Location = New Point(125, 150)
        CombListSelectVertex.Name = "CombListSelectVertex"
        CombListSelectVertex.Size = New Size(126, 23)
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
        LblVertexDegree.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblVertexDegree.ForeColor = SystemColors.ControlLightLight
        LblVertexDegree.Location = New Point(4, 191)
        LblVertexDegree.Name = "LblVertexDegree"
        LblVertexDegree.Size = New Size(42, 16)
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
        LblTotalDegree.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblTotalDegree.ForeColor = SystemColors.ControlLightLight
        LblTotalDegree.Location = New Point(4, 113)
        LblTotalDegree.Name = "LblTotalDegree"
        LblTotalDegree.Size = New Size(71, 16)
        LblTotalDegree.TabIndex = 2
        LblTotalDegree.Text = "Grado total"
        ' 
        ' LblEdgesQuantity
        ' 
        LblEdgesQuantity.AutoSize = True
        LblEdgesQuantity.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblEdgesQuantity.ForeColor = SystemColors.ControlLightLight
        LblEdgesQuantity.Location = New Point(4, 71)
        LblEdgesQuantity.Name = "LblEdgesQuantity"
        LblEdgesQuantity.Size = New Size(115, 16)
        LblEdgesQuantity.TabIndex = 1
        LblEdgesQuantity.Text = "Número de aristas"
        ' 
        ' LblVertexQuantity
        ' 
        LblVertexQuantity.AutoSize = True
        LblVertexQuantity.Font = New Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblVertexQuantity.ForeColor = SystemColors.ControlLightLight
        LblVertexQuantity.Location = New Point(4, 30)
        LblVertexQuantity.Name = "LblVertexQuantity"
        LblVertexQuantity.Size = New Size(121, 16)
        LblVertexQuantity.TabIndex = 0
        LblVertexQuantity.Text = "Número de vértices"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(21), CByte(21), CByte(21))
        ClientSize = New Size(830, 463)
        Controls.Add(PanelData)
        Controls.Add(Panel1)
        Controls.Add(PanelDraw)
        MaximizeBox = False
        Name = "FrmMain"
        Text = "APP Grafos"
        Panel1.ResumeLayout(False)
        PanelData.ResumeLayout(False)
        PanelData.PerformLayout()
        ResumeLayout(False)
    End Sub
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnClearGraph As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
End Class
