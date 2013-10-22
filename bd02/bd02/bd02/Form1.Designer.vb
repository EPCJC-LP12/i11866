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
        Me.Bd02DataSet = New bd02.bd02DataSet()
        Me.CriticasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CriticasTableAdapter = New bd02.bd02DataSetTableAdapters.criticasTableAdapter()
        CType(Me.Bd02DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CriticasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.CriticasBindingSource
        Me.ListBox1.DisplayMember = "id_restautante"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "critica"
        '
        'Bd02DataSet
        '
        Me.Bd02DataSet.DataSetName = "bd02DataSet"
        Me.Bd02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CriticasBindingSource
        '
        Me.CriticasBindingSource.DataMember = "criticas"
        Me.CriticasBindingSource.DataSource = Me.Bd02DataSet
        '
        'CriticasTableAdapter
        '
        Me.CriticasTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 416)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Criticas"
        CType(Me.Bd02DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CriticasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Bd02DataSet As bd02.bd02DataSet
    Friend WithEvents CriticasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CriticasTableAdapter As bd02.bd02DataSetTableAdapters.criticasTableAdapter

End Class
