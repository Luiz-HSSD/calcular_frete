Imports Calcular_Frete_VB.br.com.correios.ws

Public Class Frete
    Public Largura As Decimal = 0
    Public Comprimento As Decimal = 0
    Public Altura As Decimal = 0
    Public Peso As String = ""
    Public CEP As String = ""
    Public Resultado As cResultado

    Public Sub Calcular()
        Dim ws As CalcPrecoPrazoWS = New CalcPrecoPrazoWS()
        Resultado = ws.CalcPrecoPrazo("", "", "40010 , 40045 , 40215 , 40290 , 41106", "08563010", CEP, Peso, 1, Comprimento, Altura, Largura, 0, "N", 17, "S")


    End Sub
End Class
