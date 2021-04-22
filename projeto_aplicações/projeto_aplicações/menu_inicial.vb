

Public Class menu_inicial
    Private Sub PictureBox_support_Click(sender As Object, e As EventArgs) Handles PictureBox_support.Click
        'abertura do outro formulário e fecho do atual
        Dim menu_do_jogo As New menu_do_jogo
        menu_do_jogo.Show()
        Me.Close()
    End Sub

    Private Sub Menu_inicial_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'cursor ser a imagem do poro 
        Dim x As Integer = (e.X - 17) 'ajuste da imagem
        Dim y As Integer = (e.Y - 17) 'ajuste da imagem
        Me.PictureBox_poro.Location = New Point((x), (y))
    End Sub
End Class
