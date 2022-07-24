<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label_Atividade = New System.Windows.Forms.Label()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.GroupBox_Urgente = New System.Windows.Forms.GroupBox()
        Me.RadioButton_UrgenteNao = New System.Windows.Forms.RadioButton()
        Me.RadioButton_UrgenteSim = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Importante = New System.Windows.Forms.GroupBox()
        Me.RadioButton_ImportanteNao = New System.Windows.Forms.RadioButton()
        Me.RadioButtonImportanteSim = New System.Windows.Forms.RadioButton()
        Me.TextBox_Atividade = New System.Windows.Forms.TextBox()
        Me.GroupBox_ImportanteUrgente = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox_ImportanteNaoUrgente = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox_NaoImportanteUrgente = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox_NaoImportanteNaoUrgente = New System.Windows.Forms.GroupBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.TextBox_RemoverAtividade = New System.Windows.Forms.TextBox()
        Me.Label_RemoverAtividade = New System.Windows.Forms.Label()
        Me.Button_RemoverAtividade = New System.Windows.Forms.Button()
        Me.Button_Filtar = New System.Windows.Forms.Button()
        Me.GroupBox_Completada = New System.Windows.Forms.GroupBox()
        Me.RadioButtonCompletadaNao = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCompletadaSim = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Urgente.SuspendLayout()
        Me.GroupBox_Importante.SuspendLayout()
        Me.GroupBox_ImportanteUrgente.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_ImportanteNaoUrgente.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_NaoImportanteUrgente.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_NaoImportanteNaoUrgente.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Completada.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Atividade
        '
        Me.Label_Atividade.AutoSize = True
        Me.Label_Atividade.Location = New System.Drawing.Point(82, 9)
        Me.Label_Atividade.Name = "Label_Atividade"
        Me.Label_Atividade.Size = New System.Drawing.Size(39, 13)
        Me.Label_Atividade.TabIndex = 0
        Me.Label_Atividade.Text = "Label1"
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Location = New System.Drawing.Point(85, 54)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(155, 20)
        Me.Button_Adicionar.TabIndex = 1
        Me.Button_Adicionar.Text = "Button1"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'GroupBox_Urgente
        '
        Me.GroupBox_Urgente.Controls.Add(Me.RadioButton_UrgenteNao)
        Me.GroupBox_Urgente.Controls.Add(Me.RadioButton_UrgenteSim)
        Me.GroupBox_Urgente.Location = New System.Drawing.Point(85, 86)
        Me.GroupBox_Urgente.Name = "GroupBox_Urgente"
        Me.GroupBox_Urgente.Size = New System.Drawing.Size(104, 70)
        Me.GroupBox_Urgente.TabIndex = 2
        Me.GroupBox_Urgente.TabStop = False
        Me.GroupBox_Urgente.Text = "GroupBox1"
        '
        'RadioButton_UrgenteNao
        '
        Me.RadioButton_UrgenteNao.AutoSize = True
        Me.RadioButton_UrgenteNao.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_UrgenteNao.Name = "RadioButton_UrgenteNao"
        Me.RadioButton_UrgenteNao.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_UrgenteNao.TabIndex = 1
        Me.RadioButton_UrgenteNao.TabStop = True
        Me.RadioButton_UrgenteNao.Text = "RadioButton2"
        Me.RadioButton_UrgenteNao.UseVisualStyleBackColor = True
        '
        'RadioButton_UrgenteSim
        '
        Me.RadioButton_UrgenteSim.AutoSize = True
        Me.RadioButton_UrgenteSim.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_UrgenteSim.Name = "RadioButton_UrgenteSim"
        Me.RadioButton_UrgenteSim.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_UrgenteSim.TabIndex = 0
        Me.RadioButton_UrgenteSim.TabStop = True
        Me.RadioButton_UrgenteSim.Text = "RadioButton1"
        Me.RadioButton_UrgenteSim.UseVisualStyleBackColor = True
        '
        'GroupBox_Importante
        '
        Me.GroupBox_Importante.Controls.Add(Me.RadioButton_ImportanteNao)
        Me.GroupBox_Importante.Controls.Add(Me.RadioButtonImportanteSim)
        Me.GroupBox_Importante.Location = New System.Drawing.Point(195, 86)
        Me.GroupBox_Importante.Name = "GroupBox_Importante"
        Me.GroupBox_Importante.Size = New System.Drawing.Size(98, 70)
        Me.GroupBox_Importante.TabIndex = 3
        Me.GroupBox_Importante.TabStop = False
        Me.GroupBox_Importante.Text = "GroupBox2"
        '
        'RadioButton_ImportanteNao
        '
        Me.RadioButton_ImportanteNao.AutoSize = True
        Me.RadioButton_ImportanteNao.Location = New System.Drawing.Point(8, 42)
        Me.RadioButton_ImportanteNao.Name = "RadioButton_ImportanteNao"
        Me.RadioButton_ImportanteNao.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_ImportanteNao.TabIndex = 1
        Me.RadioButton_ImportanteNao.TabStop = True
        Me.RadioButton_ImportanteNao.Text = "RadioButton4"
        Me.RadioButton_ImportanteNao.UseVisualStyleBackColor = True
        '
        'RadioButtonImportanteSim
        '
        Me.RadioButtonImportanteSim.AutoSize = True
        Me.RadioButtonImportanteSim.Location = New System.Drawing.Point(8, 19)
        Me.RadioButtonImportanteSim.Name = "RadioButtonImportanteSim"
        Me.RadioButtonImportanteSim.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonImportanteSim.TabIndex = 0
        Me.RadioButtonImportanteSim.TabStop = True
        Me.RadioButtonImportanteSim.Text = "RadioButton3"
        Me.RadioButtonImportanteSim.UseVisualStyleBackColor = True
        '
        'TextBox_Atividade
        '
        Me.TextBox_Atividade.Location = New System.Drawing.Point(85, 28)
        Me.TextBox_Atividade.Name = "TextBox_Atividade"
        Me.TextBox_Atividade.Size = New System.Drawing.Size(318, 20)
        Me.TextBox_Atividade.TabIndex = 4
        '
        'GroupBox_ImportanteUrgente
        '
        Me.GroupBox_ImportanteUrgente.Controls.Add(Me.DataGridView1)
        Me.GroupBox_ImportanteUrgente.Location = New System.Drawing.Point(45, 162)
        Me.GroupBox_ImportanteUrgente.Name = "GroupBox_ImportanteUrgente"
        Me.GroupBox_ImportanteUrgente.Size = New System.Drawing.Size(438, 170)
        Me.GroupBox_ImportanteUrgente.TabIndex = 3
        Me.GroupBox_ImportanteUrgente.TabStop = False
        Me.GroupBox_ImportanteUrgente.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(426, 145)
        Me.DataGridView1.TabIndex = 2
        '
        'GroupBox_ImportanteNaoUrgente
        '
        Me.GroupBox_ImportanteNaoUrgente.Controls.Add(Me.DataGridView2)
        Me.GroupBox_ImportanteNaoUrgente.Location = New System.Drawing.Point(489, 162)
        Me.GroupBox_ImportanteNaoUrgente.Name = "GroupBox_ImportanteNaoUrgente"
        Me.GroupBox_ImportanteNaoUrgente.Size = New System.Drawing.Size(438, 170)
        Me.GroupBox_ImportanteNaoUrgente.TabIndex = 4
        Me.GroupBox_ImportanteNaoUrgente.TabStop = False
        Me.GroupBox_ImportanteNaoUrgente.Text = "GroupBox2"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(426, 145)
        Me.DataGridView2.TabIndex = 1
        '
        'GroupBox_NaoImportanteUrgente
        '
        Me.GroupBox_NaoImportanteUrgente.Controls.Add(Me.DataGridView3)
        Me.GroupBox_NaoImportanteUrgente.Location = New System.Drawing.Point(45, 338)
        Me.GroupBox_NaoImportanteUrgente.Name = "GroupBox_NaoImportanteUrgente"
        Me.GroupBox_NaoImportanteUrgente.Size = New System.Drawing.Size(438, 170)
        Me.GroupBox_NaoImportanteUrgente.TabIndex = 4
        Me.GroupBox_NaoImportanteUrgente.TabStop = False
        Me.GroupBox_NaoImportanteUrgente.Text = "GroupBox3"
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(426, 145)
        Me.DataGridView3.TabIndex = 1
        '
        'GroupBox_NaoImportanteNaoUrgente
        '
        Me.GroupBox_NaoImportanteNaoUrgente.Controls.Add(Me.DataGridView4)
        Me.GroupBox_NaoImportanteNaoUrgente.Location = New System.Drawing.Point(489, 341)
        Me.GroupBox_NaoImportanteNaoUrgente.Name = "GroupBox_NaoImportanteNaoUrgente"
        Me.GroupBox_NaoImportanteNaoUrgente.Size = New System.Drawing.Size(438, 167)
        Me.GroupBox_NaoImportanteNaoUrgente.TabIndex = 4
        Me.GroupBox_NaoImportanteNaoUrgente.TabStop = False
        Me.GroupBox_NaoImportanteNaoUrgente.Text = "GroupBox4"
        '
        'DataGridView4
        '
        Me.DataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(426, 142)
        Me.DataGridView4.TabIndex = 0
        '
        'TextBox_RemoverAtividade
        '
        Me.TextBox_RemoverAtividade.Location = New System.Drawing.Point(422, 25)
        Me.TextBox_RemoverAtividade.Name = "TextBox_RemoverAtividade"
        Me.TextBox_RemoverAtividade.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_RemoverAtividade.TabIndex = 6
        '
        'Label_RemoverAtividade
        '
        Me.Label_RemoverAtividade.AutoSize = True
        Me.Label_RemoverAtividade.Location = New System.Drawing.Point(419, 9)
        Me.Label_RemoverAtividade.Name = "Label_RemoverAtividade"
        Me.Label_RemoverAtividade.Size = New System.Drawing.Size(39, 13)
        Me.Label_RemoverAtividade.TabIndex = 5
        Me.Label_RemoverAtividade.Text = "Label1"
        '
        'Button_RemoverAtividade
        '
        Me.Button_RemoverAtividade.Location = New System.Drawing.Point(422, 51)
        Me.Button_RemoverAtividade.Name = "Button_RemoverAtividade"
        Me.Button_RemoverAtividade.Size = New System.Drawing.Size(75, 20)
        Me.Button_RemoverAtividade.TabIndex = 7
        Me.Button_RemoverAtividade.Text = "Button1"
        Me.Button_RemoverAtividade.UseVisualStyleBackColor = True
        '
        'Button_Filtar
        '
        Me.Button_Filtar.Location = New System.Drawing.Point(248, 54)
        Me.Button_Filtar.Name = "Button_Filtar"
        Me.Button_Filtar.Size = New System.Drawing.Size(155, 20)
        Me.Button_Filtar.TabIndex = 8
        Me.Button_Filtar.Text = "Button1"
        Me.Button_Filtar.UseVisualStyleBackColor = True
        '
        'GroupBox_Completada
        '
        Me.GroupBox_Completada.Controls.Add(Me.RadioButtonCompletadaNao)
        Me.GroupBox_Completada.Controls.Add(Me.RadioButtonCompletadaSim)
        Me.GroupBox_Completada.Location = New System.Drawing.Point(299, 86)
        Me.GroupBox_Completada.Name = "GroupBox_Completada"
        Me.GroupBox_Completada.Size = New System.Drawing.Size(104, 70)
        Me.GroupBox_Completada.TabIndex = 3
        Me.GroupBox_Completada.TabStop = False
        Me.GroupBox_Completada.Text = "GroupBox3"
        '
        'RadioButtonCompletadaNao
        '
        Me.RadioButtonCompletadaNao.AutoSize = True
        Me.RadioButtonCompletadaNao.Location = New System.Drawing.Point(6, 42)
        Me.RadioButtonCompletadaNao.Name = "RadioButtonCompletadaNao"
        Me.RadioButtonCompletadaNao.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonCompletadaNao.TabIndex = 1
        Me.RadioButtonCompletadaNao.TabStop = True
        Me.RadioButtonCompletadaNao.Text = "RadioButton2"
        Me.RadioButtonCompletadaNao.UseVisualStyleBackColor = True
        '
        'RadioButtonCompletadaSim
        '
        Me.RadioButtonCompletadaSim.AutoSize = True
        Me.RadioButtonCompletadaSim.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonCompletadaSim.Name = "RadioButtonCompletadaSim"
        Me.RadioButtonCompletadaSim.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonCompletadaSim.TabIndex = 0
        Me.RadioButtonCompletadaSim.TabStop = True
        Me.RadioButtonCompletadaSim.Text = "RadioButton1"
        Me.RadioButtonCompletadaSim.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 519)
        Me.Controls.Add(Me.GroupBox_Completada)
        Me.Controls.Add(Me.Button_Filtar)
        Me.Controls.Add(Me.GroupBox_ImportanteUrgente)
        Me.Controls.Add(Me.Button_RemoverAtividade)
        Me.Controls.Add(Me.TextBox_RemoverAtividade)
        Me.Controls.Add(Me.Label_RemoverAtividade)
        Me.Controls.Add(Me.GroupBox_NaoImportanteNaoUrgente)
        Me.Controls.Add(Me.GroupBox_NaoImportanteUrgente)
        Me.Controls.Add(Me.GroupBox_ImportanteNaoUrgente)
        Me.Controls.Add(Me.TextBox_Atividade)
        Me.Controls.Add(Me.GroupBox_Importante)
        Me.Controls.Add(Me.GroupBox_Urgente)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.Label_Atividade)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox_Urgente.ResumeLayout(False)
        Me.GroupBox_Urgente.PerformLayout()
        Me.GroupBox_Importante.ResumeLayout(False)
        Me.GroupBox_Importante.PerformLayout()
        Me.GroupBox_ImportanteUrgente.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_ImportanteNaoUrgente.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_NaoImportanteUrgente.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_NaoImportanteNaoUrgente.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Completada.ResumeLayout(False)
        Me.GroupBox_Completada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Atividade As Label
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents GroupBox_Urgente As GroupBox
    Friend WithEvents RadioButton_UrgenteNao As RadioButton
    Friend WithEvents RadioButton_UrgenteSim As RadioButton
    Friend WithEvents GroupBox_Importante As GroupBox
    Friend WithEvents RadioButton_ImportanteNao As RadioButton
    Friend WithEvents RadioButtonImportanteSim As RadioButton
    Friend WithEvents TextBox_Atividade As TextBox
    Friend WithEvents GroupBox_ImportanteUrgente As GroupBox
    Friend WithEvents GroupBox_ImportanteNaoUrgente As GroupBox
    Friend WithEvents GroupBox_NaoImportanteUrgente As GroupBox
    Friend WithEvents GroupBox_NaoImportanteNaoUrgente As GroupBox
    Friend WithEvents TextBox_RemoverAtividade As TextBox
    Friend WithEvents Label_RemoverAtividade As Label
    Friend WithEvents Button_RemoverAtividade As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button_Filtar As Button
    Friend WithEvents GroupBox_Completada As GroupBox
    Friend WithEvents RadioButtonCompletadaNao As RadioButton
    Friend WithEvents RadioButtonCompletadaSim As RadioButton
End Class
