<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatrix
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DGridMatrix = New DataGridView()
        CType(DGridMatrix, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGridMatrix
        ' 
        DGridMatrix.AllowUserToAddRows = False
        DGridMatrix.AllowUserToDeleteRows = False
        DGridMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGridMatrix.Dock = DockStyle.Fill
        DGridMatrix.Location = New Point(0, 0)
        DGridMatrix.Name = "DGridMatrix"
        DGridMatrix.ReadOnly = True
        DGridMatrix.RowTemplate.Height = 25
        DGridMatrix.Size = New Size(366, 245)
        DGridMatrix.TabIndex = 0
        ' 
        ' FrmMatrix
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(366, 245)
        Controls.Add(DGridMatrix)
        Name = "FrmMatrix"
        Text = "FrmMatrix"
        CType(DGridMatrix, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGridMatrix As DataGridView
End Class
