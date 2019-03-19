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
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Soma = New System.Windows.Forms.RadioButton()
        Me.Valor1 = New System.Windows.Forms.TextBox()
        Me.Valor2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Multiplicacao = New System.Windows.Forms.RadioButton()
        Me.Divisao = New System.Windows.Forms.RadioButton()
        Me.Subtracao = New System.Windows.Forms.RadioButton()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(147, 28)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcular.TabIndex = 0
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor 1"
        '
        'Soma
        '
        Me.Soma.AutoSize = True
        Me.Soma.Location = New System.Drawing.Point(3, 24)
        Me.Soma.Name = "Soma"
        Me.Soma.Size = New System.Drawing.Size(52, 17)
        Me.Soma.TabIndex = 2
        Me.Soma.TabStop = True
        Me.Soma.Text = "Soma"
        Me.Soma.UseVisualStyleBackColor = True
        '
        'Valor1
        '
        Me.Valor1.Location = New System.Drawing.Point(2, 30)
        Me.Valor1.Name = "Valor1"
        Me.Valor1.Size = New System.Drawing.Size(65, 20)
        Me.Valor1.TabIndex = 3
        '
        'Valor2
        '
        Me.Valor2.Location = New System.Drawing.Point(73, 30)
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Size = New System.Drawing.Size(63, 20)
        Me.Valor2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor 2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Multiplicacao)
        Me.GroupBox1.Controls.Add(Me.Divisao)
        Me.GroupBox1.Controls.Add(Me.Subtracao)
        Me.GroupBox1.Controls.Add(Me.Soma)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 116)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operações"
        '
        'Multiplicacao
        '
        Me.Multiplicacao.AutoSize = True
        Me.Multiplicacao.Location = New System.Drawing.Point(3, 47)
        Me.Multiplicacao.Name = "Multiplicacao"
        Me.Multiplicacao.Size = New System.Drawing.Size(87, 17)
        Me.Multiplicacao.TabIndex = 5
        Me.Multiplicacao.TabStop = True
        Me.Multiplicacao.Text = "Multiplicação"
        Me.Multiplicacao.UseVisualStyleBackColor = True
        '
        'Divisao
        '
        Me.Divisao.AutoSize = True
        Me.Divisao.Location = New System.Drawing.Point(3, 70)
        Me.Divisao.Name = "Divisao"
        Me.Divisao.Size = New System.Drawing.Size(60, 17)
        Me.Divisao.TabIndex = 4
        Me.Divisao.TabStop = True
        Me.Divisao.Text = "Divisão"
        Me.Divisao.UseVisualStyleBackColor = True
        '
        'Subtracao
        '
        Me.Subtracao.AutoSize = True
        Me.Subtracao.Location = New System.Drawing.Point(3, 93)
        Me.Subtracao.Name = "Subtracao"
        Me.Subtracao.Size = New System.Drawing.Size(74, 17)
        Me.Subtracao.TabIndex = 3
        Me.Subtracao.TabStop = True
        Me.Subtracao.Text = "Subtração"
        Me.Subtracao.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(147, 158)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 7
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resultado"
        '
        'Resultado
        '
        Me.Resultado.Location = New System.Drawing.Point(12, 216)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(210, 20)
        Me.Resultado.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 254)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Valor2)
        Me.Controls.Add(Me.Valor1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Soma As RadioButton
    Friend WithEvents Valor1 As TextBox
    Friend WithEvents Valor2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Multiplicacao As RadioButton
    Friend WithEvents Divisao As RadioButton
    Friend WithEvents Subtracao As RadioButton
    Friend WithEvents BtnSair As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Resultado As TextBox
End Class
