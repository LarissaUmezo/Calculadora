Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Try
            If Soma.Checked = True Then
                Resultado.Text = Double.Parse(Valor1.Text) + Double.Parse(Valor2.Text)
            End If
            If Multiplicacao.Checked = True Then
                Resultado.Text = Double.Parse(Valor1.Text) * Double.Parse(Valor2.Text)
            End If
            If Divisao.Checked = True Then
                Resultado.Text = Double.Parse(Valor1.Text) / Double.Parse(Valor2.Text)
            End If
            If Subtracao.Checked = True Then
                Resultado.Text = Double.Parse(Valor1.Text) - Double.Parse(Valor2.Text)
            End If

        Catch
            MessageBox.Show("Apenas números!!!")
        End Try
    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub
End Class
