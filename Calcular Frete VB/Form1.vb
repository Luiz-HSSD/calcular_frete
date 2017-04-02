Public Class Form1
    Public Frete As frete = New frete


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Or
           TextBox2.Text <> "" Or
           TextBox3.Text <> "" Or
           TextBox4.Text <> "" Or
           TextBox5.Text <> "" Then
            Frete.Largura = System.Convert.ToDecimal(TextBox1.Text)
            Frete.Comprimento = System.Convert.ToDecimal(TextBox2.Text)
            Frete.Altura = System.Convert.ToDecimal(TextBox3.Text)
            Frete.Peso = TextBox4.Text
            Frete.CEP = TextBox5.Text
            Frete.calcular()
            MessageBox.Show("SEDEX Varejo" + Chr(13) + "Preço: " + Frete.Resultado.Servicos.ElementAt(0).Valor + Chr(13) + "Prazo em dias: " + Frete.Resultado.Servicos.ElementAt(0).PrazoEntrega + Chr(13) + Frete.Resultado.Servicos.ElementAt(0).MsgErro + Chr(13) + "SEDEX A Cobrar Varejo" + Chr(13) + "Preço: " + Frete.Resultado.Servicos.ElementAt(1).Valor + Chr(13) + "Prazo em dias: " + Frete.Resultado.Servicos.ElementAt(1).PrazoEntrega + Chr(13) + Frete.Resultado.Servicos.ElementAt(1).MsgErro + Chr(13) + "SEDEX 10 Varejo" + Chr(13) + "Preço: " + Frete.Resultado.Servicos.ElementAt(2).Valor + Chr(13) + "Prazo em dias: " + Frete.Resultado.Servicos.ElementAt(2).PrazoEntrega + Chr(13) + Frete.Resultado.Servicos.ElementAt(2).MsgErro + Chr(13) + "SEDEX Hoje Varejo" + Chr(13) + "Preço: " + Frete.Resultado.Servicos.ElementAt(3).Valor + Chr(13) + "Prazo em dias: " + Frete.Resultado.Servicos.ElementAt(3).PrazoEntrega + Chr(13) + Frete.Resultado.Servicos.ElementAt(3).MsgErro + Chr(13) + "PAC Varejo" + Chr(13) + "Preço: " + Frete.Resultado.Servicos.ElementAt(4).Valor + Chr(13) + "Prazo em dias: " + Frete.Resultado.Servicos.ElementAt(4).PrazoEntrega + Chr(13) + Frete.Resultado.Servicos.ElementAt(4).MsgErro)



        End If
    End Sub
End Class
