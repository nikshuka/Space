<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Grid1 = New System.Windows.Forms.DataGridView()
        Me.ПланетыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Солнечная_системаDataSet1 = New WindowsApplication1.Солнечная_системаDataSet1()
        Me.ПланетыTableAdapter = New WindowsApplication1.Солнечная_системаDataSet1TableAdapters.ПланетыTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ГравитационнаяПостояннаяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.РадиусDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.МассаПланетыDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПланетаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПланетыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Солнечная_системаDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 140)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "V1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "V2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "H"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Вычислить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ПланетыBindingSource
        Me.ComboBox1.DisplayMember = "Планета"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(207, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Выбор планеты"
        '
        'Grid1
        '
        Me.Grid1.AutoGenerateColumns = False
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ПланетаDataGridViewTextBoxColumn, Me.МассаПланетыDataGridViewTextBoxColumn, Me.РадиусDataGridViewTextBoxColumn, Me.ГравитационнаяПостояннаяDataGridViewTextBoxColumn})
        Me.Grid1.DataSource = Me.ПланетыBindingSource
        Me.Grid1.Location = New System.Drawing.Point(367, 22)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(544, 239)
        Me.Grid1.TabIndex = 9
        '
        'ПланетыBindingSource
        '
        Me.ПланетыBindingSource.DataMember = "Планеты"
        Me.ПланетыBindingSource.DataSource = Me.Солнечная_системаDataSet1
        '
        'Солнечная_системаDataSet1
        '
        Me.Солнечная_системаDataSet1.DataSetName = "Солнечная_системаDataSet1"
        Me.Солнечная_системаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПланетыTableAdapter
        '
        Me.ПланетыTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(367, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(544, 60)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Обновить"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ГравитационнаяПостояннаяDataGridViewTextBoxColumn
        '
        Me.ГравитационнаяПостояннаяDataGridViewTextBoxColumn.DataPropertyName = "Гравитационная постоянная"
        Me.ГравитационнаяПостояннаяDataGridViewTextBoxColumn.HeaderText = "Гравитационная постоянная"
        Me.ГравитационнаяПостояннаяDataGridViewTextBoxColumn.Name = "ГравитационнаяПостояннаяDataGridViewTextBoxColumn"
        '
        'РадиусDataGridViewTextBoxColumn
        '
        Me.РадиусDataGridViewTextBoxColumn.DataPropertyName = "Радиус"
        Me.РадиусDataGridViewTextBoxColumn.HeaderText = "Радиус"
        Me.РадиусDataGridViewTextBoxColumn.Name = "РадиусDataGridViewTextBoxColumn"
        '
        'МассаПланетыDataGridViewTextBoxColumn
        '
        Me.МассаПланетыDataGridViewTextBoxColumn.DataPropertyName = "Масса планеты"
        Me.МассаПланетыDataGridViewTextBoxColumn.HeaderText = "Масса планеты"
        Me.МассаПланетыDataGridViewTextBoxColumn.Name = "МассаПланетыDataGridViewTextBoxColumn"
        '
        'ПланетаDataGridViewTextBoxColumn
        '
        Me.ПланетаDataGridViewTextBoxColumn.DataPropertyName = "Планета"
        Me.ПланетаDataGridViewTextBoxColumn.HeaderText = "Планета"
        Me.ПланетаDataGridViewTextBoxColumn.Name = "ПланетаDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 516)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПланетыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Солнечная_системаDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents Солнечная_системаDataSet1 As WindowsApplication1.Солнечная_системаDataSet1
    Friend WithEvents ПланетыBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПланетыTableAdapter As WindowsApplication1.Солнечная_системаDataSet1TableAdapters.ПланетыTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПланетаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents МассаПланетыDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РадиусDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ГравитационнаяПостояннаяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
