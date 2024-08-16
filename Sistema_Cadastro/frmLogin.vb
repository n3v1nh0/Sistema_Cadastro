Public Class frmLogin

    Dim nomeTela As String

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nomeTela = "Tela de Login"
        MsgBox("Abriu o Formulário", MsgBoxStyle.Information, nomeTela)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Clicou no Botão", MsgBoxStyle.Information, "Tela de Login")
    End Sub
End Class