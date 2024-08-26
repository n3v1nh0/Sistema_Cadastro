Public Class frmLogin

    Dim nomeTela As String

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nomeTela = "Login"
        MsgBox("Abriu o Formulário", MsgBoxStyle.Information, nomeTela)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Clicou no Botão", MsgBoxStyle.Information, "Tela de Login")
        calcular()
    End Sub


    Sub calcular()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim total As Integer

        num1 = 5
        num2 = 4
        total = num1 + num2
        MsgBox(total)

    End Sub

End Class