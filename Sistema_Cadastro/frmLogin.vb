Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Abriu o Formulário", MsgBoxStyle.Information, "Tela de Login")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Clicou no Botão", MsgBoxStyle.Information, "Tela de Login")
    End Sub
End Class