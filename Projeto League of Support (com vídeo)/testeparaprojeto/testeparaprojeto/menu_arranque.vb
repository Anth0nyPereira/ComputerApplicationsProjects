Public Class menu_arranque
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'apesar do formulário se chamar menu arranque, em cima aparece form1, mas nem sequer mexi porque o vídeo está funcional depois de ter tido problemas e perdido 2 tardes (vá, 1 e meia) por causa disto, também acabei por não alterar o nome do plugin do VLC pela mesma razão, ainda neste momento não sei porquê que o outro projeto quis "embirrar" com a colocação do vídeo
        AxVLCPlugin21.playlist.add("https://www.youtube.com/watch?v=O4PDzBnBMU4")
        AxVLCPlugin21.playlist.play()
    End Sub

    Private Sub PictureBox_avançar_Click(sender As Object, e As EventArgs) Handles PictureBox_avançar.Click
        Dim menu_inicial As New menu_inicial
        menu_inicial.Show()
        Me.Close()
    End Sub
End Class
