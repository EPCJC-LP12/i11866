<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BDFormula1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDFormula1DataSet = New Formula1.BDFormula1DataSet()
        Me.BDFormula1DataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BDFormula1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDFormula1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDFormula1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.BDFormula1DataSetBindingSource1
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(170, 121)
        Me.ListBox1.TabIndex = 0
        '
        'BDFormula1DataSetBindingSource
        '
        Me.BDFormula1DataSetBindingSource.DataSource = Me.BDFormula1DataSet
        Me.BDFormula1DataSetBindingSource.Position = 0
        '
        'BDFormula1DataSet
        '
        Me.BDFormula1DataSet.DataSetName = "BDFormula1DataSet"
        Me.BDFormula1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BDFormula1DataSetBindingSource1
        '
        Me.BDFormula1DataSetBindingSource1.DataSource = Me.BDFormula1DataSet
        Me.BDFormula1DataSetBindingSource1.Position = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 346)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Fórmula 1"
        CType(Me.BDFormula1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDFormula1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDFormula1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BDFormula1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDFormula1DataSet As Formula1.BDFormula1DataSet
    Friend WithEvents BDFormula1DataSetBindingSource1 As System.Windows.Forms.BindingSource

End Class
