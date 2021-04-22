Public Class menu_do_jogo
    Public n, matrizdoschamps(22, 19) As Integer 'n é a posição que ocupa o champ no documento de etxto, que é igual ao número da coluna na matriz das perguntas
    Public vetor(19) As String 'vetor que vai ler o documento de texto com os champions (base de dados)
    Private Sub Button_gerarchampion_Click(sender As Object, e As EventArgs) Handles Button_gerarchampion.Click
        'quero aproveitar para dizer/referir que o design deste formulário está mais "simples", com definições pré-definidas para os botões e radiobuttons, porque com o fundo em tons azul-claro / cinzento fica muito bem assim e, sendo este o menu "principal", o que tem de chamar a atenção são as imagens dos champions e as dos poros sim e não (pessoalmente é este o meu design favorito)
        'base de dados em documento de texto para selecionar um champion aleatório
        Dim ficheiro As String
        n = 0
        'localização do ficheiro
        'Colocando só o nome este será guardado na pasta /bin/debug que está na pasta do projeto
        ficheiro = "Champions.txt"

        If My.Computer.FileSystem.FileExists(ficheiro) = True Then
            'se o ficheiro existir é aberto em modo de leitura
            Dim sr As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(ficheiro)


            'enquando não chegar ao final do ficheiro s linhas são carregadas
            Do While sr.EndOfStream = False
                vetor(n) = sr.ReadLine 'vai lendo cada uma das linhas do ficheiro
                n = n + 1
            Loop
            sr.Close() 'fecha o ficheiro
        Else
            MessageBox.Show("O ficheiro não existe")
        End If

        Randomize() 'Ativa o processo de seleção aleatória
        n = Int(Rnd() * 20) 'seleciona aleatoriamente um número entre 0 e 19 = 20 números = 20 champions (ao colocar + 1, elimina-se a possibilidade de n = 0, e era por isso que "Alistar" nunca era selecionado

        TextBox_championgerado.Text = vetor(n)
    End Sub


    Private Sub ComboBox_perguntas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_perguntas.SelectedIndexChanged
        'interligação da combobox com a matriz das perguntas e o vetor com o champion selecionado aleatoriamente, isto sim é magia :)
        If Me.ComboBox_perguntas.SelectedIndex = 0 Then 'n é a posição, a começar em 0, do champion no documento de texto, que corresponde ao número da coluna
            'pergunta "é careca?"
            For c = 0 To 19
                If matrizdoschamps(0, c) <> matrizdoschamps(0, n) And matrizdoschamps(0, n) = 0 Then 'não é careca 'percorrendo a linha toda de índice 0, se um valor for diferente daquele em que o índice da coluna corresponde ao do champion selecionado aleatoriamente, desaparecer a imagem
                    PictureBox_blitzcrank.Visible = False 'eliminar os carecas
                    PictureBox_brand.Visible = False
                    PictureBox_braum.Visible = False
                    PictureBox_tahmkench.Visible = False
                    RadioButton_não.Checked = True
                Else
                    If matrizdoschamps(0, c) <> matrizdoschamps(0, n) And matrizdoschamps(0, n) = 1 Then 'sim é careca
                        PictureBox_alistar.Visible = False 'eliminar os que não são carecas
                        PictureBox_annie.Visible = False
                        PictureBox_bard.Visible = False
                        PictureBox_janna.Visible = False
                        PictureBox_karma.Visible = False
                        PictureBox_leona.Visible = False
                        PictureBox_lulu.Visible = False
                        PictureBox_morgana.Visible = False
                        PictureBox_nami.Visible = False
                        PictureBox_rakan.Visible = False
                        PictureBox_sona.Visible = False
                        PictureBox_soraka.Visible = False
                        PictureBox_taric.Visible = False
                        PictureBox_thresh.Visible = False
                        PictureBox_zilean.Visible = False
                        PictureBox_zyra.Visible = False
                        RadioButton_sim.Checked = True
                    End If
                End If

            Next
        Else
            If Me.ComboBox_perguntas.SelectedIndex = 1 Then 'pergunta "É de Bandle City, terra dos yordles?"
                For c = 0 To 19
                    If matrizdoschamps(1, c) <> matrizdoschamps(1, n) And matrizdoschamps(1, n) = 0 Then 'não é de Bandle City
                        'eliminar os que são de Bandle City
                        PictureBox_lulu.Visible = False
                        RadioButton_não.Checked = True
                    Else
                        If matrizdoschamps(1, c) <> matrizdoschamps(1, n) And matrizdoschamps(1, n) = 1 Then 'é de Bandle City
                            'eliminar os que não são de Bandle City (todos menos a Lulu)
                            PictureBox_alistar.Visible = False
                            PictureBox_annie.Visible = False
                            PictureBox_leona.Visible = False
                            PictureBox_braum.Visible = False
                            PictureBox_blitzcrank.Visible = False
                            PictureBox_brand.Visible = False
                            PictureBox_bard.Visible = False
                            PictureBox_janna.Visible = False
                            PictureBox_karma.Visible = False
                            PictureBox_morgana.Visible = False
                            PictureBox_nami.Visible = False
                            PictureBox_rakan.Visible = False
                            PictureBox_sona.Visible = False
                            PictureBox_soraka.Visible = False
                            PictureBox_tahmkench.Visible = False
                            PictureBox_taric.Visible = False
                            PictureBox_thresh.Visible = False
                            PictureBox_zilean.Visible = False
                            PictureBox_zyra.Visible = False
                            RadioButton_sim.Checked = True
                        End If
                    End If
                Next
            Else
                If Me.ComboBox_perguntas.SelectedIndex = 2 Then 'pergunta "É de Demacia?"
                    For c = 0 To 19
                        If matrizdoschamps(2, c) <> matrizdoschamps(2, n) And matrizdoschamps(2, n) = 0 Then 'não é de Demacia
                            'eliminar os que são de Demacia
                            PictureBox_sona.Visible = False
                            RadioButton_não.Checked = True
                        Else
                            If matrizdoschamps(2, c) <> matrizdoschamps(2, n) And matrizdoschamps(2, n) = 1 Then 'é de Demacia
                                'eliminar os que não são de Demacia
                                PictureBox_alistar.Visible = False
                                PictureBox_annie.Visible = False
                                PictureBox_bard.Visible = False           'NOTA: a soma do nº de pictureboxes tornadas invisíveis nos dois ifs terá de dar sempre 20
                                PictureBox_blitzcrank.Visible = False
                                PictureBox_brand.Visible = False
                                PictureBox_braum.Visible = False
                                PictureBox_janna.Visible = False
                                PictureBox_karma.Visible = False
                                PictureBox_leona.Visible = False
                                PictureBox_lulu.Visible = False
                                PictureBox_morgana.Visible = False
                                PictureBox_nami.Visible = False
                                PictureBox_rakan.Visible = False
                                PictureBox_soraka.Visible = False
                                PictureBox_tahmkench.Visible = False
                                PictureBox_taric.Visible = False
                                PictureBox_thresh.Visible = False
                                PictureBox_zilean.Visible = False
                                PictureBox_zyra.Visible = False
                                RadioButton_sim.Checked = True
                            End If
                        End If
                    Next
                Else 'escrever o "Else" para mudar para a pergunta seguinte sempre depois de um "Next"
                    If Me.ComboBox_perguntas.SelectedIndex = 3 Then 'pergunta "É de Freljord?"
                        For c = 0 To 19
                            If matrizdoschamps(3, c) <> matrizdoschamps(3, n) And matrizdoschamps(3, n) = 0 Then 'não é de Freljord
                                'eliminar os que são de Freljord
                                PictureBox_braum.Visible = False
                                RadioButton_não.Checked = True
                            Else
                                If matrizdoschamps(3, c) <> matrizdoschamps(3, n) And matrizdoschamps(3, n) = 1 Then 'é de Freljord
                                    'eliminar os que não são de Freljord
                                    PictureBox_alistar.Visible = False
                                    PictureBox_annie.Visible = False
                                    PictureBox_bard.Visible = False
                                    PictureBox_blitzcrank.Visible = False
                                    PictureBox_brand.Visible = False
                                    PictureBox_janna.Visible = False
                                    PictureBox_karma.Visible = False
                                    PictureBox_leona.Visible = False
                                    PictureBox_lulu.Visible = False
                                    PictureBox_morgana.Visible = False
                                    PictureBox_nami.Visible = False
                                    PictureBox_rakan.Visible = False
                                    PictureBox_sona.Visible = False
                                    PictureBox_soraka.Visible = False
                                    PictureBox_taric.Visible = False
                                    PictureBox_thresh.Visible = False
                                    PictureBox_zilean.Visible = False
                                    PictureBox_zyra.Visible = False
                                    RadioButton_sim.Checked = True
                                End If

                            End If
                        Next
                    Else
                        If Me.ComboBox_perguntas.SelectedIndex = 4 Then 'pergunta "É de Ionia?"
                            For c = 0 To 19
                                If matrizdoschamps(4, c) <> matrizdoschamps(4, n) And matrizdoschamps(4, n) = 0 Then 'não ser de Ionia
                                    'eliminar os que são de Ionia
                                    PictureBox_karma.Visible = False
                                    PictureBox_rakan.Visible = False
                                    PictureBox_soraka.Visible = False
                                    RadioButton_não.Checked = True
                                Else
                                    If matrizdoschamps(4, c) <> matrizdoschamps(4, n) And matrizdoschamps(4, n) = 1 Then 'ser de Ionia
                                        'eliminar os que não são de Ionia
                                        PictureBox_alistar.Visible = False
                                        PictureBox_annie.Visible = False
                                        PictureBox_bard.Visible = False
                                        PictureBox_blitzcrank.Visible = False
                                        PictureBox_brand.Visible = False
                                        PictureBox_janna.Visible = False
                                        PictureBox_leona.Visible = False
                                        PictureBox_lulu.Visible = False
                                        PictureBox_morgana.Visible = False
                                        PictureBox_nami.Visible = False
                                        PictureBox_sona.Visible = False
                                        PictureBox_taric.Visible = False
                                        PictureBox_thresh.Visible = False
                                        PictureBox_zilean.Visible = False
                                        PictureBox_zyra.Visible = False
                                        PictureBox_braum.Visible = False
                                        PictureBox_tahmkench.Visible = False
                                        RadioButton_sim.Checked = True
                                    End If
                                End If
                            Next
                        Else
                            If Me.ComboBox_perguntas.SelectedIndex = 5 Then 'pergunta "É de Noxus?"
                                For c = 0 To 19
                                    If matrizdoschamps(5, c) <> matrizdoschamps(5, n) And matrizdoschamps(5, n) = 0 Then 'não é de Noxus
                                        'eliminar os que pertencem a Noxus (Annie)
                                        PictureBox_annie.Visible = False
                                        RadioButton_não.Checked = True
                                    Else
                                        If matrizdoschamps(5, c) <> matrizdoschamps(5, n) And matrizdoschamps(5, n) = 1 Then 'é de Noxus
                                            'eliminar os que não fazem parte de Noxus
                                            PictureBox_karma.Visible = False
                                            PictureBox_rakan.Visible = False
                                            PictureBox_soraka.Visible = False
                                            PictureBox_alistar.Visible = False
                                            PictureBox_bard.Visible = False
                                            PictureBox_blitzcrank.Visible = False
                                            PictureBox_brand.Visible = False
                                            PictureBox_janna.Visible = False
                                            PictureBox_leona.Visible = False
                                            PictureBox_lulu.Visible = False
                                            PictureBox_morgana.Visible = False
                                            PictureBox_nami.Visible = False
                                            PictureBox_sona.Visible = False
                                            PictureBox_taric.Visible = False
                                            PictureBox_thresh.Visible = False
                                            PictureBox_zilean.Visible = False
                                            PictureBox_zyra.Visible = False
                                            PictureBox_braum.Visible = False
                                            PictureBox_tahmkench.Visible = False
                                            RadioButton_sim.Checked = True
                                        End If
                                    End If
                                Next
                            Else
                                If Me.ComboBox_perguntas.SelectedIndex = 6 Then 'pergunta "É de Zaun?"
                                    For c = 0 To 19
                                        If matrizdoschamps(6, c) <> matrizdoschamps(6, n) And matrizdoschamps(6, n) = 0 Then 'não é de Zaun
                                            'eliminar pertencentes a Zaun
                                            PictureBox_blitzcrank.Visible = False
                                            PictureBox_janna.Visible = False
                                            RadioButton_não.Checked = True
                                        Else
                                            If matrizdoschamps(6, c) <> matrizdoschamps(6, n) And matrizdoschamps(6, n) = 1 Then 'é de Zaun
                                                'eliminar os que não são de Zaun
                                                PictureBox_karma.Visible = False
                                                PictureBox_rakan.Visible = False
                                                PictureBox_soraka.Visible = False
                                                PictureBox_alistar.Visible = False
                                                PictureBox_annie.Visible = False
                                                PictureBox_bard.Visible = False
                                                PictureBox_brand.Visible = False
                                                PictureBox_leona.Visible = False
                                                PictureBox_lulu.Visible = False
                                                PictureBox_morgana.Visible = False
                                                PictureBox_nami.Visible = False
                                                PictureBox_sona.Visible = False
                                                PictureBox_taric.Visible = False
                                                PictureBox_thresh.Visible = False
                                                PictureBox_zilean.Visible = False
                                                PictureBox_zyra.Visible = False
                                                PictureBox_braum.Visible = False
                                                PictureBox_tahmkench.Visible = False
                                                RadioButton_sim.Checked = True
                                            End If
                                        End If
                                    Next
                                Else
                                    If Me.ComboBox_perguntas.SelectedIndex = 7 Then 'pergunta "É das Ilhas das Sombras?"
                                        For c = 0 To 19
                                            If matrizdoschamps(7, c) <> matrizdoschamps(7, n) And matrizdoschamps(7, n) = 0 Then 'não é das Ilhas das Sombras
                                                'eliminar os que pertencem às Ilhas das Sombras
                                                PictureBox_thresh.Visible = False
                                                RadioButton_não.Checked = True
                                            Else
                                                If matrizdoschamps(7, c) <> matrizdoschamps(7, n) And matrizdoschamps(7, n) = 1 Then 'é das Ilhas das Sombras
                                                    'eliminar os que não são das Ilhas das Sombras
                                                    PictureBox_karma.Visible = False
                                                    PictureBox_rakan.Visible = False
                                                    PictureBox_soraka.Visible = False
                                                    PictureBox_alistar.Visible = False
                                                    PictureBox_annie.Visible = False
                                                    PictureBox_bard.Visible = False
                                                    PictureBox_blitzcrank.Visible = False
                                                    PictureBox_brand.Visible = False
                                                    PictureBox_janna.Visible = False
                                                    PictureBox_leona.Visible = False
                                                    PictureBox_lulu.Visible = False
                                                    PictureBox_morgana.Visible = False
                                                    PictureBox_nami.Visible = False
                                                    PictureBox_sona.Visible = False
                                                    PictureBox_taric.Visible = False
                                                    PictureBox_zilean.Visible = False
                                                    PictureBox_zyra.Visible = False
                                                    PictureBox_braum.Visible = False
                                                    PictureBox_tahmkench.Visible = False
                                                    RadioButton_sim.Checked = True
                                                End If
                                            End If
                                        Next
                                    Else
                                        If Me.ComboBox_perguntas.SelectedIndex = 8 Then 'pergunta "É do Monte Targon?"
                                            For c = 0 To 19
                                                If matrizdoschamps(8, c) <> matrizdoschamps(8, n) And matrizdoschamps(8, n) = 0 Then 'o champion não é do Monte Targon
                                                    'eliminar os que são do Monte Targon
                                                    PictureBox_leona.Visible = False
                                                    PictureBox_taric.Visible = False
                                                    RadioButton_não.Checked = True
                                                Else
                                                    If matrizdoschamps(8, c) <> matrizdoschamps(8, n) And matrizdoschamps(8, n) = 1 Then 'é do Monte Targon
                                                        'eliminar os que não são do Monte Targon (todos exceto Leona e Taric)
                                                        PictureBox_karma.Visible = False
                                                        PictureBox_rakan.Visible = False
                                                        PictureBox_soraka.Visible = False
                                                        PictureBox_alistar.Visible = False
                                                        PictureBox_annie.Visible = False
                                                        PictureBox_bard.Visible = False
                                                        PictureBox_blitzcrank.Visible = False
                                                        PictureBox_brand.Visible = False
                                                        PictureBox_janna.Visible = False
                                                        PictureBox_lulu.Visible = False
                                                        PictureBox_morgana.Visible = False
                                                        PictureBox_nami.Visible = False
                                                        PictureBox_sona.Visible = False
                                                        PictureBox_thresh.Visible = False
                                                        PictureBox_zilean.Visible = False
                                                        PictureBox_zyra.Visible = False
                                                        PictureBox_braum.Visible = False
                                                        PictureBox_tahmkench.Visible = False
                                                        RadioButton_sim.Checked = True
                                                    End If
                                                End If
                                            Next
                                        Else
                                            If Me.ComboBox_perguntas.SelectedIndex = 9 Then 'pergunta "'E do sexo feminino?"
                                                For c = 0 To 19
                                                    If matrizdoschamps(9, c) <> matrizdoschamps(9, n) And matrizdoschamps(9, n) = 0 Then 'não é do sexo feminino, é homem
                                                        'eliminar todos do sexo feminino, mulheres
                                                        PictureBox_karma.Visible = False
                                                        PictureBox_soraka.Visible = False
                                                        PictureBox_annie.Visible = False
                                                        PictureBox_janna.Visible = False
                                                        PictureBox_leona.Visible = False
                                                        PictureBox_lulu.Visible = False
                                                        PictureBox_morgana.Visible = False
                                                        PictureBox_nami.Visible = False
                                                        PictureBox_sona.Visible = False
                                                        PictureBox_zyra.Visible = False
                                                        RadioButton_não.Checked = True
                                                    Else
                                                        If matrizdoschamps(9, c) <> matrizdoschamps(9, n) And matrizdoschamps(9, n) = 1 Then 'é mulher
                                                            'eliminar os homens
                                                            PictureBox_rakan.Visible = False
                                                            PictureBox_alistar.Visible = False
                                                            PictureBox_bard.Visible = False
                                                            PictureBox_blitzcrank.Visible = False
                                                            PictureBox_brand.Visible = False
                                                            PictureBox_taric.Visible = False
                                                            PictureBox_thresh.Visible = False
                                                            PictureBox_zilean.Visible = False
                                                            PictureBox_braum.Visible = False
                                                            PictureBox_tahmkench.Visible = False
                                                            RadioButton_sim.Checked = True
                                                        End If
                                                    End If
                                                Next
                                            Else
                                                If Me.ComboBox_perguntas.SelectedIndex = 10 Then 'pergunta "É humano?"
                                                    For c = 0 To 19
                                                        If matrizdoschamps(10, c) <> matrizdoschamps(10, n) And matrizdoschamps(10, n) = 0 Then 'não é humano
                                                            'eliminar os humanos
                                                            PictureBox_karma.Visible = False '
                                                            PictureBox_soraka.Visible = False '
                                                            PictureBox_annie.Visible = False '
                                                            PictureBox_janna.Visible = False '
                                                            PictureBox_leona.Visible = False '
                                                            PictureBox_sona.Visible = False '
                                                            PictureBox_zyra.Visible = False '
                                                            PictureBox_rakan.Visible = False '
                                                            PictureBox_brand.Visible = False '
                                                            PictureBox_taric.Visible = False '
                                                            PictureBox_zilean.Visible = False '
                                                            PictureBox_braum.Visible = False '
                                                            PictureBox_morgana.Visible = False '
                                                            PictureBox_lulu.Visible = False '
                                                            RadioButton_não.Checked = True
                                                        Else
                                                            If matrizdoschamps(10, c) <> matrizdoschamps(10, n) And matrizdoschamps(10, n) = 1 Then 'é humano
                                                                'eliminar os que não são humanos
                                                                PictureBox_alistar.Visible = False '
                                                                PictureBox_bard.Visible = False '
                                                                PictureBox_blitzcrank.Visible = False '
                                                                PictureBox_thresh.Visible = False '
                                                                PictureBox_tahmkench.Visible = False '
                                                                PictureBox_nami.Visible = False '
                                                                RadioButton_sim.Checked = True
                                                            End If

                                                        End If
                                                    Next
                                                Else
                                                    If Me.ComboBox_perguntas.SelectedIndex = 11 Then 'pergunta "Champion healer?"
                                                        For c = 0 To 19
                                                            If matrizdoschamps(11, c) <> matrizdoschamps(11, n) And matrizdoschamps(11, n) = 0 Then 'ele não é healer
                                                                'eliminar os healers
                                                                PictureBox_alistar.Visible = False
                                                                PictureBox_bard.Visible = False
                                                                PictureBox_janna.Visible = False
                                                                PictureBox_karma.Visible = False
                                                                PictureBox_morgana.Visible = False
                                                                PictureBox_nami.Visible = False
                                                                PictureBox_rakan.Visible = False
                                                                PictureBox_sona.Visible = False
                                                                PictureBox_soraka.Visible = False
                                                                PictureBox_taric.Visible = False
                                                                RadioButton_não.Checked = True
                                                            Else
                                                                If matrizdoschamps(11, c) <> matrizdoschamps(11, n) And matrizdoschamps(11, n) = 1 Then 'é healer
                                                                    'eliminar os que NÃO SÃO healers
                                                                    PictureBox_annie.Visible = False
                                                                    PictureBox_braum.Visible = False
                                                                    PictureBox_blitzcrank.Visible = False
                                                                    PictureBox_brand.Visible = False
                                                                    PictureBox_leona.Visible = False
                                                                    PictureBox_lulu.Visible = False
                                                                    PictureBox_tahmkench.Visible = False
                                                                    PictureBox_thresh.Visible = False
                                                                    PictureBox_zilean.Visible = False
                                                                    PictureBox_zyra.Visible = False
                                                                    RadioButton_sim.Checked = True
                                                                End If
                                                            End If
                                                        Next
                                                    Else
                                                        If Me.ComboBox_perguntas.SelectedIndex = 12 Then 'pergunta "Champion tipo mago?"
                                                            For c = 0 To 19
                                                                If matrizdoschamps(12, c) <> matrizdoschamps(12, n) And matrizdoschamps(12, n) = 0 Then 'não é mago
                                                                    'eliminar os magos
                                                                    PictureBox_annie.Visible = False
                                                                    PictureBox_brand.Visible = False
                                                                    PictureBox_morgana.Visible = False
                                                                    PictureBox_zilean.Visible = False
                                                                    PictureBox_zyra.Visible = False
                                                                    RadioButton_não.Checked = True
                                                                Else
                                                                    If matrizdoschamps(12, c) <> matrizdoschamps(12, n) And matrizdoschamps(12, n) = 1 Then 'é um champion mago o selecionado aleatoriamente
                                                                        'eliminar os que NÃO SÃO magos
                                                                        PictureBox_alistar.Visible = False
                                                                        PictureBox_braum.Visible = False
                                                                        PictureBox_blitzcrank.Visible = False
                                                                        PictureBox_bard.Visible = False
                                                                        PictureBox_janna.Visible = False
                                                                        PictureBox_karma.Visible = False
                                                                        PictureBox_leona.Visible = False
                                                                        PictureBox_lulu.Visible = False
                                                                        PictureBox_nami.Visible = False
                                                                        PictureBox_rakan.Visible = False
                                                                        PictureBox_sona.Visible = False
                                                                        PictureBox_soraka.Visible = False
                                                                        PictureBox_tahmkench.Visible = False
                                                                        PictureBox_taric.Visible = False
                                                                        PictureBox_thresh.Visible = False
                                                                        RadioButton_sim.Checked = True
                                                                    End If
                                                                End If
                                                            Next
                                                        Else
                                                            If Me.ComboBox_perguntas.SelectedIndex = 13 Then 'pergunta "é um champion tipo tank?"
                                                                For c = 0 To 19
                                                                    If matrizdoschamps(13, c) <> matrizdoschamps(13, n) And matrizdoschamps(13, n) = 0 Then 'não é tank
                                                                        'eliminar todos os tanks
                                                                        PictureBox_alistar.Visible = False
                                                                        PictureBox_blitzcrank.Visible = False
                                                                        PictureBox_braum.Visible = False
                                                                        PictureBox_leona.Visible = False
                                                                        PictureBox_tahmkench.Visible = False
                                                                        PictureBox_taric.Visible = False
                                                                        PictureBox_thresh.Visible = False
                                                                        RadioButton_não.Checked = True
                                                                    Else
                                                                        If matrizdoschamps(13, c) <> matrizdoschamps(13, n) And matrizdoschamps(13, n) = 1 Then 'é tank
                                                                            'eliminar todos que NÃO SÃO tanks
                                                                            PictureBox_annie.Visible = False
                                                                            PictureBox_brand.Visible = False
                                                                            PictureBox_bard.Visible = False
                                                                            PictureBox_janna.Visible = False
                                                                            PictureBox_karma.Visible = False
                                                                            PictureBox_lulu.Visible = False
                                                                            PictureBox_morgana.Visible = False
                                                                            PictureBox_nami.Visible = False
                                                                            PictureBox_rakan.Visible = False
                                                                            PictureBox_sona.Visible = False
                                                                            PictureBox_soraka.Visible = False
                                                                            PictureBox_zilean.Visible = False
                                                                            PictureBox_zyra.Visible = False
                                                                            RadioButton_sim.Checked = True
                                                                        End If
                                                                    End If
                                                                Next
                                                            Else
                                                                If Me.ComboBox_perguntas.SelectedIndex = 14 Then 'pergunta "É um champion independente/sem região específica?"
                                                                    For c = 0 To 19
                                                                        If matrizdoschamps(14, c) <> matrizdoschamps(14, n) And matrizdoschamps(14, n) = 0 Then 'não é champion independente
                                                                            'desaparecer com champions independentes
                                                                            PictureBox_alistar.Visible = False
                                                                            PictureBox_brand.Visible = False
                                                                            PictureBox_bard.Visible = False
                                                                            PictureBox_morgana.Visible = False
                                                                            PictureBox_nami.Visible = False
                                                                            PictureBox_tahmkench.Visible = False
                                                                            PictureBox_zilean.Visible = False
                                                                            PictureBox_zyra.Visible = False
                                                                            RadioButton_não.Checked = True
                                                                        Else
                                                                            If matrizdoschamps(14, c) <> matrizdoschamps(14, n) And matrizdoschamps(14, n) = 1 Then 'é independente
                                                                                'desaparecer os que NÃO SÃO independentes (todos menos os de cima, faz sempre assim)
                                                                                PictureBox_annie.Visible = False
                                                                                PictureBox_braum.Visible = False
                                                                                PictureBox_blitzcrank.Visible = False
                                                                                PictureBox_janna.Visible = False
                                                                                PictureBox_karma.Visible = False
                                                                                PictureBox_leona.Visible = False
                                                                                PictureBox_lulu.Visible = False
                                                                                PictureBox_rakan.Visible = False
                                                                                PictureBox_sona.Visible = False
                                                                                PictureBox_soraka.Visible = False
                                                                                PictureBox_taric.Visible = False
                                                                                PictureBox_thresh.Visible = False
                                                                                RadioButton_sim.Checked = True
                                                                            End If
                                                                        End If
                                                                    Next
                                                                Else
                                                                    If Me.ComboBox_perguntas.SelectedIndex = 15 Then 'pergunta "É um champion ligado à água?"
                                                                        For c = 0 To 19
                                                                            If matrizdoschamps(15, c) <> matrizdoschamps(15, n) And matrizdoschamps(15, n) = 0 Then 'não é ligado à água
                                                                                'desaparecer os ligados à água, Nami e Tahm Kench
                                                                                PictureBox_nami.Visible = False
                                                                                PictureBox_tahmkench.Visible = False
                                                                                RadioButton_não.Checked = True
                                                                            Else
                                                                                If matrizdoschamps(15, c) <> matrizdoschamps(15, n) And matrizdoschamps(15, n) = 1 Then 'champion selecionado aleatoriamente é ligado à água
                                                                                    'fazer desaparecer com os que NÃO SÃO ligados à água (todos menos os dois de cima)
                                                                                    PictureBox_alistar.Visible = False
                                                                                    PictureBox_annie.Visible = False
                                                                                    PictureBox_braum.Visible = False
                                                                                    PictureBox_blitzcrank.Visible = False
                                                                                    PictureBox_brand.Visible = False
                                                                                    PictureBox_bard.Visible = False
                                                                                    PictureBox_janna.Visible = False
                                                                                    PictureBox_karma.Visible = False
                                                                                    PictureBox_leona.Visible = False
                                                                                    PictureBox_lulu.Visible = False
                                                                                    PictureBox_morgana.Visible = False
                                                                                    PictureBox_rakan.Visible = False
                                                                                    PictureBox_sona.Visible = False
                                                                                    PictureBox_soraka.Visible = False
                                                                                    PictureBox_taric.Visible = False
                                                                                    PictureBox_thresh.Visible = False
                                                                                    PictureBox_zilean.Visible = False
                                                                                    PictureBox_zyra.Visible = False
                                                                                    RadioButton_sim.Checked = True
                                                                                End If
                                                                            End If
                                                                        Next
                                                                    Else
                                                                        If Me.ComboBox_perguntas.SelectedIndex = 16 Then 'pergunta "É um champion ligado ao fogo'"
                                                                            For c = 0 To 19
                                                                                If matrizdoschamps(16, c) <> matrizdoschamps(16, n) And matrizdoschamps(16, n) = 0 Then 'não está ligado ao fogo
                                                                                    'desaparecer com os ligados ao fogo
                                                                                    PictureBox_annie.Visible = False
                                                                                    PictureBox_brand.Visible = False
                                                                                    RadioButton_não.Checked = True
                                                                                Else
                                                                                    If matrizdoschamps(16, c) <> matrizdoschamps(16, n) And matrizdoschamps(16, n) = 1 Then 'é ligado ao fogo
                                                                                        'desaparecer os NÃO ligados ao fogo, todos menos os dois de cima
                                                                                        PictureBox_alistar.Visible = False
                                                                                        PictureBox_braum.Visible = False
                                                                                        PictureBox_blitzcrank.Visible = False
                                                                                        PictureBox_bard.Visible = False
                                                                                        PictureBox_janna.Visible = False
                                                                                        PictureBox_karma.Visible = False
                                                                                        PictureBox_leona.Visible = False
                                                                                        PictureBox_lulu.Visible = False
                                                                                        PictureBox_morgana.Visible = False
                                                                                        PictureBox_nami.Visible = False
                                                                                        PictureBox_rakan.Visible = False
                                                                                        PictureBox_sona.Visible = False
                                                                                        PictureBox_soraka.Visible = False
                                                                                        PictureBox_tahmkench.Visible = False
                                                                                        PictureBox_taric.Visible = False
                                                                                        PictureBox_thresh.Visible = False
                                                                                        PictureBox_zilean.Visible = False
                                                                                        PictureBox_zyra.Visible = False
                                                                                        RadioButton_sim.Checked = True
                                                                                    End If

                                                                                End If
                                                                            Next
                                                                        Else
                                                                            If Me.ComboBox_perguntas.SelectedIndex = 17 Then 'pergunta "Possui stun?"
                                                                                For c = 0 To 19
                                                                                    If matrizdoschamps(17, c) <> matrizdoschamps(17, n) And matrizdoschamps(17, n) = 0 Then 'não possui stun
                                                                                        'desaparecer com os que têm stun
                                                                                        PictureBox_alistar.Visible = False
                                                                                        PictureBox_annie.Visible = False
                                                                                        PictureBox_braum.Visible = False
                                                                                        PictureBox_blitzcrank.Visible = False
                                                                                        PictureBox_brand.Visible = False
                                                                                        PictureBox_bard.Visible = False
                                                                                        PictureBox_karma.Visible = False
                                                                                        PictureBox_leona.Visible = False
                                                                                        PictureBox_morgana.Visible = False
                                                                                        PictureBox_nami.Visible = False
                                                                                        PictureBox_sona.Visible = False
                                                                                        PictureBox_soraka.Visible = False
                                                                                        PictureBox_tahmkench.Visible = False
                                                                                        PictureBox_taric.Visible = False
                                                                                        PictureBox_thresh.Visible = False
                                                                                        PictureBox_zilean.Visible = False
                                                                                        PictureBox_zyra.Visible = False
                                                                                        RadioButton_não.Checked = True
                                                                                    Else
                                                                                        If matrizdoschamps(17, c) <> matrizdoschamps(17, n) And matrizdoschamps(17, n) = 1 Then 'champion tem stun
                                                                                            'desaparecer com os que não têm stun
                                                                                            PictureBox_janna.Visible = False
                                                                                            PictureBox_lulu.Visible = False
                                                                                            PictureBox_rakan.Visible = False
                                                                                            RadioButton_sim.Checked = True
                                                                                        End If

                                                                                    End If
                                                                                Next
                                                                            Else
                                                                                If Me.ComboBox_perguntas.SelectedIndex = 18 Then 'pergunta "Tem cabelo branco?"
                                                                                    For c = 0 To 19
                                                                                        If matrizdoschamps(18, c) <> matrizdoschamps(18, n) And matrizdoschamps(18, n) = 0 Then 'não tem cabelo branco
                                                                                            'desaparecer com os que têm cabelo branco
                                                                                            PictureBox_bard.Visible = False
                                                                                            PictureBox_janna.Visible = False
                                                                                            PictureBox_rakan.Visible = False
                                                                                            PictureBox_soraka.Visible = False
                                                                                            RadioButton_não.Checked = True
                                                                                        Else
                                                                                            If matrizdoschamps(18, c) <> matrizdoschamps(18, n) And matrizdoschamps(18, n) = 1 Then 'tem cabelo branco
                                                                                                'desaparecer com os que NÃO TÊM cabelo branco
                                                                                                PictureBox_alistar.Visible = False
                                                                                                PictureBox_annie.Visible = False
                                                                                                PictureBox_braum.Visible = False
                                                                                                PictureBox_blitzcrank.Visible = False
                                                                                                PictureBox_brand.Visible = False
                                                                                                PictureBox_karma.Visible = False
                                                                                                PictureBox_leona.Visible = False
                                                                                                PictureBox_lulu.Visible = False
                                                                                                PictureBox_morgana.Visible = False
                                                                                                PictureBox_nami.Visible = False
                                                                                                PictureBox_sona.Visible = False
                                                                                                PictureBox_tahmkench.Visible = False
                                                                                                PictureBox_taric.Visible = False
                                                                                                PictureBox_thresh.Visible = False
                                                                                                PictureBox_zilean.Visible = False
                                                                                                PictureBox_zyra.Visible = False
                                                                                                RadioButton_sim.Checked = True
                                                                                            End If
                                                                                        End If
                                                                                    Next
                                                                                Else
                                                                                    If Me.ComboBox_perguntas.SelectedIndex = 19 Then 'pergunta "Tem cabelo preto?"
                                                                                        For c = 0 To 19
                                                                                            If matrizdoschamps(19, c) <> matrizdoschamps(19, n) And matrizdoschamps(19, n) = 0 Then 'não tem cabelo preto
                                                                                                'desaparecer com os que têm cabelo preto
                                                                                                PictureBox_karma.Visible = False
                                                                                                PictureBox_morgana.Visible = False
                                                                                                PictureBox_taric.Visible = False
                                                                                                RadioButton_não.Checked = True
                                                                                            Else
                                                                                                If matrizdoschamps(19, c) <> matrizdoschamps(19, n) And matrizdoschamps(19, n) = 1 Then 'tem cabelo preto
                                                                                                    'eliminar os que NÃO TÊM cabelo preto
                                                                                                    PictureBox_alistar.Visible = False
                                                                                                    PictureBox_annie.Visible = False
                                                                                                    PictureBox_braum.Visible = False
                                                                                                    PictureBox_blitzcrank.Visible = False
                                                                                                    PictureBox_brand.Visible = False
                                                                                                    PictureBox_bard.Visible = False
                                                                                                    PictureBox_janna.Visible = False
                                                                                                    PictureBox_leona.Visible = False
                                                                                                    PictureBox_lulu.Visible = False
                                                                                                    PictureBox_nami.Visible = False
                                                                                                    PictureBox_rakan.Visible = False
                                                                                                    PictureBox_sona.Visible = False
                                                                                                    PictureBox_soraka.Visible = False
                                                                                                    PictureBox_tahmkench.Visible = False
                                                                                                    PictureBox_thresh.Visible = False
                                                                                                    PictureBox_zilean.Visible = False
                                                                                                    PictureBox_zyra.Visible = False
                                                                                                    RadioButton_sim.Checked = True
                                                                                                End If
                                                                                            End If
                                                                                        Next
                                                                                    Else
                                                                                        If Me.ComboBox_perguntas.SelectedIndex = 20 Then 'pergunta "Tem habilidade de shield?"
                                                                                            For c = 0 To 19
                                                                                                If matrizdoschamps(20, c) <> matrizdoschamps(20, n) And matrizdoschamps(20, n) = 0 Then 'não tem habilidade de shield
                                                                                                    'eliminar os que têm shield
                                                                                                    PictureBox_alistar.Visible = False
                                                                                                    PictureBox_annie.Visible = False
                                                                                                    PictureBox_braum.Visible = False
                                                                                                    PictureBox_blitzcrank.Visible = False
                                                                                                    PictureBox_janna.Visible = False
                                                                                                    PictureBox_karma.Visible = False
                                                                                                    PictureBox_leona.Visible = False
                                                                                                    PictureBox_lulu.Visible = False
                                                                                                    PictureBox_morgana.Visible = False
                                                                                                    PictureBox_rakan.Visible = False
                                                                                                    PictureBox_sona.Visible = False
                                                                                                    PictureBox_tahmkench.Visible = False
                                                                                                    PictureBox_taric.Visible = False
                                                                                                    PictureBox_thresh.Visible = False
                                                                                                    RadioButton_não.Checked = True
                                                                                                Else
                                                                                                    If matrizdoschamps(20, c) <> matrizdoschamps(20, n) And matrizdoschamps(20, n) = 1 Then 'tem shield
                                                                                                        'desaparecer com os que NÃO TÊM shield
                                                                                                        PictureBox_brand.Visible = False
                                                                                                        PictureBox_bard.Visible = False
                                                                                                        PictureBox_nami.Visible = False
                                                                                                        PictureBox_soraka.Visible = False
                                                                                                        PictureBox_zilean.Visible = False
                                                                                                        PictureBox_zyra.Visible = False
                                                                                                        RadioButton_sim.Checked = True
                                                                                                    End If
                                                                                                End If
                                                                                            Next
                                                                                        Else
                                                                                            If Me.ComboBox_perguntas.SelectedIndex = 21 Then 'pergunta "Tem pele branca?"
                                                                                                For c = 0 To 19
                                                                                                    If matrizdoschamps(21, c) <> matrizdoschamps(21, n) And matrizdoschamps(21, n) = 0 Then 'não tem pele branca
                                                                                                        'desaparecer os que têm pele branca
                                                                                                        PictureBox_janna.Visible = False
                                                                                                        PictureBox_morgana.Visible = False
                                                                                                        PictureBox_rakan.Visible = False
                                                                                                        PictureBox_sona.Visible = False
                                                                                                        PictureBox_taric.Visible = False
                                                                                                        PictureBox_zilean.Visible = False
                                                                                                        RadioButton_não.Checked = True
                                                                                                    Else
                                                                                                        If matrizdoschamps(21, c) <> matrizdoschamps(21, n) And matrizdoschamps(21, n) = 1 Then 'tem pele branca
                                                                                                            'desaparecer com os sem pele branca
                                                                                                            PictureBox_alistar.Visible = False
                                                                                                            PictureBox_annie.Visible = False
                                                                                                            PictureBox_braum.Visible = False
                                                                                                            PictureBox_blitzcrank.Visible = False
                                                                                                            PictureBox_brand.Visible = False
                                                                                                            PictureBox_bard.Visible = False
                                                                                                            PictureBox_karma.Visible = False
                                                                                                            PictureBox_leona.Visible = False
                                                                                                            PictureBox_lulu.Visible = False
                                                                                                            PictureBox_nami.Visible = False
                                                                                                            PictureBox_soraka.Visible = False
                                                                                                            PictureBox_tahmkench.Visible = False
                                                                                                            PictureBox_thresh.Visible = False
                                                                                                            PictureBox_zyra.Visible = False
                                                                                                            RadioButton_sim.Checked = True
                                                                                                        End If

                                                                                                    End If
                                                                                                Next
                                                                                            Else
                                                                                                If Me.ComboBox_perguntas.SelectedIndex = 22 Then 'pergunta "Tem 1 ou + chifres na cabeça?"
                                                                                                    For c = 0 To 19
                                                                                                        If matrizdoschamps(22, c) <> matrizdoschamps(22, n) And matrizdoschamps(22, n) = 0 Then 'não tem chifres
                                                                                                            'desaparecer com os que têm chifres
                                                                                                            PictureBox_alistar.Visible = False
                                                                                                            PictureBox_soraka.Visible = False
                                                                                                            RadioButton_não.Checked = True
                                                                                                        Else
                                                                                                            If matrizdoschamps(22, c) <> matrizdoschamps(22, n) And matrizdoschamps(22, n) = 1 Then 'tem chifres
                                                                                                                'desaparecer com os que NÃO TÊM chifres                                                                                                        
                                                                                                                PictureBox_annie.Visible = False
                                                                                                                PictureBox_braum.Visible = False
                                                                                                                PictureBox_blitzcrank.Visible = False
                                                                                                                PictureBox_brand.Visible = False
                                                                                                                PictureBox_bard.Visible = False
                                                                                                                PictureBox_janna.Visible = False
                                                                                                                PictureBox_karma.Visible = False
                                                                                                                PictureBox_leona.Visible = False
                                                                                                                PictureBox_lulu.Visible = False
                                                                                                                PictureBox_morgana.Visible = False
                                                                                                                PictureBox_nami.Visible = False
                                                                                                                PictureBox_rakan.Visible = False
                                                                                                                PictureBox_sona.Visible = False
                                                                                                                PictureBox_tahmkench.Visible = False
                                                                                                                PictureBox_taric.Visible = False
                                                                                                                PictureBox_thresh.Visible = False
                                                                                                                PictureBox_zilean.Visible = False
                                                                                                                PictureBox_zyra.Visible = False
                                                                                                                RadioButton_sim.Checked = True
                                                                                                            End If
                                                                                                        End If
                                                                                                    Next
                                                                                                End If
                                                                                            End If

                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If

                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub Button_verificar_Click(sender As Object, e As EventArgs) Handles Button_verificar.Click
        'confirmação se a última imagem ativada corresponde realmente ao champion selecionado aleatoriamente
        If TextBox_confirmação.Text = "É Alistar?" And vetor(n) = "Alistar" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Alistar?" And vetor(n) <> "Alistar" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Annie?" And vetor(n) = "Annie" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Annie?" And vetor(n) <> "Annie" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Bard?" And vetor(n) = "Bard" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Bard?" And vetor(n) <> "Bard" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Blitzcrank?" And vetor(n) = "Blitzcrank" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Blitzcrank?" And vetor(n) <> "Blitzcrank" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Brand?" And vetor(n) = "Brand" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Brand?" And vetor(n) <> "Brand" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Braum?" And vetor(n) = "Braum" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Braum?" And vetor(n) <> "Braum" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Janna?" And vetor(n) = "Janna" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Janna?" And vetor(n) <> "Janna" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Karma?" And vetor(n) = "Karma" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Karma?" And vetor(n) <> "Karma" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Leona?" And vetor(n) = "Leona" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Leona?" And vetor(n) <> "Leona" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Lulu?" And vetor(n) = "Lulu" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Lulu?" And vetor(n) <> "Lulu" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Morgana?" And vetor(n) = "Morgana" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Morgana?" And vetor(n) <> "Morgana" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Nami?" And vetor(n) = "Nami" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Nami?" And vetor(n) <> "Nami" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Rakan?" And vetor(n) = "Rakan" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Rakan?" And vetor(n) <> "Rakan" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Sona?" And vetor(n) = "Sona" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Sona?" And vetor(n) <> "Sona" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Soraka?" And vetor(n) = "Soraka" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Soraka?" And vetor(n) <> "Soraka" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Tahm Kench?" And vetor(n) = "Tahm Kench" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Tahm Kench?" And vetor(n) <> "Tahm Kench" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Taric?" And vetor(n) = "Taric" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Taric?" And vetor(n) <> "Taric" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Thresh?" And vetor(n) = "Thresh" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Thresh?" And vetor(n) <> "Thresh" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Zilean?" And vetor(n) = "Zilean" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Zilean?" And vetor(n) <> "Zilean" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If

        If TextBox_confirmação.Text = "É Zyra?" And vetor(n) = "Zyra" Then
            TextBox_confirmação.Text = "Sim"
        Else
            If TextBox_confirmação.Text = "É Zyra?" And vetor(n) <> "Zyra" Then
                TextBox_confirmação.Text = "Não"
            End If
        End If
    End Sub

    Private Sub Button_fechar_Click(sender As Object, e As EventArgs) Handles Button_fechar.Click
        'fecho do formulário e aplicação em si
        Me.Close()
    End Sub

    Private Sub PictureBox_perguntas_Click(sender As Object, e As EventArgs) Handles PictureBox_perguntas.Click
        '------>para quem quiser jogar outra vez e não ter de fechar e voltar a abrir o aplicativo <--------
        Dim menudojogo As New menu_do_jogo
        menudojogo.Show()
        Me.Close()
    End Sub

    Private Sub Menu_do_jogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Show()
        'declaração da matriz com as perguntas relativas aos champions, fonte de como fazer: http://ptcomputador.com/P/visual-basics-programming/95269.html
        matrizdoschamps(0, 0) = 0
        matrizdoschamps(0, 1) = 0
        matrizdoschamps(0, 2) = 0
        matrizdoschamps(0, 3) = 1
        matrizdoschamps(0, 4) = 1
        matrizdoschamps(0, 5) = 1
        matrizdoschamps(0, 6) = 0
        matrizdoschamps(0, 7) = 0
        matrizdoschamps(0, 8) = 0
        matrizdoschamps(0, 9) = 0
        matrizdoschamps(0, 10) = 0
        matrizdoschamps(0, 11) = 0
        matrizdoschamps(0, 12) = 0
        matrizdoschamps(0, 13) = 0
        matrizdoschamps(0, 14) = 0
        matrizdoschamps(0, 15) = 1
        matrizdoschamps(0, 16) = 0
        matrizdoschamps(0, 17) = 0
        matrizdoschamps(0, 18) = 0
        matrizdoschamps(0, 19) = 0
        matrizdoschamps(1, 0) = 0
        matrizdoschamps(1, 1) = 0
        matrizdoschamps(1, 2) = 0
        matrizdoschamps(1, 3) = 0
        matrizdoschamps(1, 4) = 0
        matrizdoschamps(1, 5) = 0
        matrizdoschamps(1, 6) = 0
        matrizdoschamps(1, 7) = 0
        matrizdoschamps(1, 8) = 0
        matrizdoschamps(1, 9) = 1
        matrizdoschamps(1, 10) = 0
        matrizdoschamps(1, 11) = 0
        matrizdoschamps(1, 12) = 0
        matrizdoschamps(1, 13) = 0
        matrizdoschamps(1, 14) = 0
        matrizdoschamps(1, 15) = 0
        matrizdoschamps(1, 16) = 0
        matrizdoschamps(1, 17) = 0
        matrizdoschamps(1, 18) = 0
        matrizdoschamps(1, 19) = 0
        matrizdoschamps(2, 0) = 0
        matrizdoschamps(2, 1) = 0
        matrizdoschamps(2, 2) = 0
        matrizdoschamps(2, 3) = 0
        matrizdoschamps(2, 4) = 0
        matrizdoschamps(2, 5) = 0
        matrizdoschamps(2, 6) = 0
        matrizdoschamps(2, 7) = 0
        matrizdoschamps(2, 8) = 0
        matrizdoschamps(2, 9) = 0
        matrizdoschamps(2, 10) = 0
        matrizdoschamps(2, 11) = 0
        matrizdoschamps(2, 12) = 0
        matrizdoschamps(2, 13) = 1
        matrizdoschamps(2, 14) = 0
        matrizdoschamps(2, 15) = 0
        matrizdoschamps(2, 16) = 0
        matrizdoschamps(2, 17) = 0
        matrizdoschamps(2, 18) = 0
        matrizdoschamps(2, 19) = 0
        matrizdoschamps(3, 0) = 0
        matrizdoschamps(3, 1) = 0
        matrizdoschamps(3, 2) = 0
        matrizdoschamps(3, 3) = 0
        matrizdoschamps(3, 4) = 0
        matrizdoschamps(3, 5) = 1
        matrizdoschamps(3, 6) = 0
        matrizdoschamps(3, 7) = 0
        matrizdoschamps(3, 8) = 0
        matrizdoschamps(3, 9) = 0
        matrizdoschamps(3, 10) = 0
        matrizdoschamps(3, 11) = 0
        matrizdoschamps(3, 12) = 0
        matrizdoschamps(3, 13) = 0
        matrizdoschamps(3, 14) = 0
        matrizdoschamps(3, 15) = 0
        matrizdoschamps(3, 16) = 0
        matrizdoschamps(3, 17) = 0
        matrizdoschamps(3, 18) = 0
        matrizdoschamps(3, 19) = 0
        matrizdoschamps(4, 0) = 0
        matrizdoschamps(4, 1) = 0
        matrizdoschamps(4, 2) = 0
        matrizdoschamps(4, 3) = 0
        matrizdoschamps(4, 4) = 0
        matrizdoschamps(4, 5) = 0
        matrizdoschamps(4, 6) = 0
        matrizdoschamps(4, 7) = 1
        matrizdoschamps(4, 8) = 0
        matrizdoschamps(4, 9) = 0
        matrizdoschamps(4, 10) = 0
        matrizdoschamps(4, 11) = 0
        matrizdoschamps(4, 12) = 1
        matrizdoschamps(4, 13) = 0
        matrizdoschamps(4, 14) = 1
        matrizdoschamps(4, 15) = 0
        matrizdoschamps(4, 16) = 0
        matrizdoschamps(4, 17) = 0
        matrizdoschamps(4, 18) = 0
        matrizdoschamps(4, 19) = 0
        matrizdoschamps(5, 0) = 0
        matrizdoschamps(5, 1) = 1
        matrizdoschamps(5, 2) = 0
        matrizdoschamps(5, 3) = 0
        matrizdoschamps(5, 4) = 0
        matrizdoschamps(5, 5) = 0
        matrizdoschamps(5, 6) = 0
        matrizdoschamps(5, 7) = 0
        matrizdoschamps(5, 8) = 0
        matrizdoschamps(5, 9) = 0
        matrizdoschamps(5, 10) = 0
        matrizdoschamps(5, 11) = 0
        matrizdoschamps(5, 12) = 0
        matrizdoschamps(5, 13) = 0
        matrizdoschamps(5, 14) = 0
        matrizdoschamps(5, 15) = 0
        matrizdoschamps(5, 16) = 0
        matrizdoschamps(5, 17) = 0
        matrizdoschamps(5, 18) = 0
        matrizdoschamps(5, 19) = 0
        matrizdoschamps(6, 0) = 0
        matrizdoschamps(6, 1) = 0
        matrizdoschamps(6, 2) = 0
        matrizdoschamps(6, 3) = 1
        matrizdoschamps(6, 4) = 0
        matrizdoschamps(6, 5) = 0
        matrizdoschamps(6, 6) = 1
        matrizdoschamps(6, 7) = 0
        matrizdoschamps(6, 8) = 0
        matrizdoschamps(6, 9) = 0
        matrizdoschamps(6, 10) = 0
        matrizdoschamps(6, 11) = 0
        matrizdoschamps(6, 12) = 0
        matrizdoschamps(6, 13) = 0
        matrizdoschamps(6, 14) = 0
        matrizdoschamps(6, 15) = 0
        matrizdoschamps(6, 16) = 0
        matrizdoschamps(6, 17) = 0
        matrizdoschamps(6, 18) = 0
        matrizdoschamps(6, 19) = 0
        matrizdoschamps(7, 0) = 0
        matrizdoschamps(7, 1) = 0
        matrizdoschamps(7, 2) = 0
        matrizdoschamps(7, 3) = 0
        matrizdoschamps(7, 4) = 0
        matrizdoschamps(7, 5) = 0
        matrizdoschamps(7, 6) = 0
        matrizdoschamps(7, 7) = 0
        matrizdoschamps(7, 8) = 0
        matrizdoschamps(7, 9) = 0
        matrizdoschamps(7, 10) = 0
        matrizdoschamps(7, 11) = 0
        matrizdoschamps(7, 12) = 0
        matrizdoschamps(7, 13) = 0
        matrizdoschamps(7, 14) = 0
        matrizdoschamps(7, 15) = 0
        matrizdoschamps(7, 16) = 0
        matrizdoschamps(7, 17) = 1
        matrizdoschamps(7, 18) = 0
        matrizdoschamps(7, 19) = 0
        matrizdoschamps(8, 0) = 0
        matrizdoschamps(8, 1) = 0
        matrizdoschamps(8, 2) = 0
        matrizdoschamps(8, 3) = 0
        matrizdoschamps(8, 4) = 0
        matrizdoschamps(8, 5) = 0
        matrizdoschamps(8, 6) = 0
        matrizdoschamps(8, 7) = 0
        matrizdoschamps(8, 8) = 1
        matrizdoschamps(8, 9) = 0
        matrizdoschamps(8, 10) = 0
        matrizdoschamps(8, 11) = 0
        matrizdoschamps(8, 12) = 0
        matrizdoschamps(8, 13) = 0
        matrizdoschamps(8, 14) = 0
        matrizdoschamps(8, 15) = 0
        matrizdoschamps(8, 16) = 1
        matrizdoschamps(8, 17) = 0
        matrizdoschamps(8, 18) = 0
        matrizdoschamps(8, 19) = 0
        matrizdoschamps(9, 0) = 0
        matrizdoschamps(9, 1) = 1
        matrizdoschamps(9, 2) = 0
        matrizdoschamps(9, 3) = 0
        matrizdoschamps(9, 4) = 0
        matrizdoschamps(9, 5) = 0
        matrizdoschamps(9, 6) = 1
        matrizdoschamps(9, 7) = 1
        matrizdoschamps(9, 8) = 1
        matrizdoschamps(9, 9) = 1
        matrizdoschamps(9, 10) = 1
        matrizdoschamps(9, 11) = 1
        matrizdoschamps(9, 12) = 0
        matrizdoschamps(9, 13) = 1
        matrizdoschamps(9, 14) = 1
        matrizdoschamps(9, 15) = 0
        matrizdoschamps(9, 16) = 0
        matrizdoschamps(9, 17) = 0
        matrizdoschamps(9, 18) = 0
        matrizdoschamps(9, 19) = 1
        matrizdoschamps(10, 0) = 0
        matrizdoschamps(10, 1) = 1
        matrizdoschamps(10, 2) = 0
        matrizdoschamps(10, 3) = 0
        matrizdoschamps(10, 4) = 1
        matrizdoschamps(10, 5) = 1
        matrizdoschamps(10, 6) = 1
        matrizdoschamps(10, 7) = 1
        matrizdoschamps(10, 8) = 1
        matrizdoschamps(10, 9) = 1
        matrizdoschamps(10, 10) = 1
        matrizdoschamps(10, 11) = 0
        matrizdoschamps(10, 12) = 1
        matrizdoschamps(10, 13) = 1
        matrizdoschamps(10, 14) = 1
        matrizdoschamps(10, 15) = 0
        matrizdoschamps(10, 16) = 1
        matrizdoschamps(10, 17) = 0
        matrizdoschamps(10, 18) = 1
        matrizdoschamps(10, 19) = 1
        matrizdoschamps(11, 0) = 1
        matrizdoschamps(11, 1) = 0
        matrizdoschamps(11, 2) = 1
        matrizdoschamps(11, 3) = 0
        matrizdoschamps(11, 4) = 0
        matrizdoschamps(11, 5) = 0
        matrizdoschamps(11, 6) = 1
        matrizdoschamps(11, 7) = 1
        matrizdoschamps(11, 8) = 0
        matrizdoschamps(11, 9) = 0
        matrizdoschamps(11, 10) = 1
        matrizdoschamps(11, 11) = 1
        matrizdoschamps(11, 12) = 1
        matrizdoschamps(11, 13) = 1
        matrizdoschamps(11, 14) = 1
        matrizdoschamps(11, 15) = 0
        matrizdoschamps(11, 16) = 1
        matrizdoschamps(11, 17) = 0
        matrizdoschamps(11, 18) = 0
        matrizdoschamps(11, 19) = 0
        matrizdoschamps(12, 0) = 0
        matrizdoschamps(12, 1) = 1
        matrizdoschamps(12, 2) = 0
        matrizdoschamps(12, 3) = 0
        matrizdoschamps(12, 4) = 1
        matrizdoschamps(12, 5) = 0
        matrizdoschamps(12, 6) = 0
        matrizdoschamps(12, 7) = 0
        matrizdoschamps(12, 8) = 0
        matrizdoschamps(12, 9) = 0
        matrizdoschamps(12, 10) = 1
        matrizdoschamps(12, 11) = 0
        matrizdoschamps(12, 12) = 0
        matrizdoschamps(12, 13) = 0
        matrizdoschamps(12, 14) = 0
        matrizdoschamps(12, 15) = 0
        matrizdoschamps(12, 16) = 0
        matrizdoschamps(12, 17) = 0
        matrizdoschamps(12, 18) = 1
        matrizdoschamps(12, 19) = 1
        matrizdoschamps(13, 0) = 1
        matrizdoschamps(13, 1) = 0
        matrizdoschamps(13, 2) = 0
        matrizdoschamps(13, 3) = 1
        matrizdoschamps(13, 4) = 0
        matrizdoschamps(13, 5) = 1
        matrizdoschamps(13, 6) = 0
        matrizdoschamps(13, 7) = 0
        matrizdoschamps(13, 8) = 1
        matrizdoschamps(13, 9) = 0
        matrizdoschamps(13, 10) = 0
        matrizdoschamps(13, 11) = 0
        matrizdoschamps(13, 12) = 0
        matrizdoschamps(13, 13) = 0
        matrizdoschamps(13, 14) = 0
        matrizdoschamps(13, 15) = 1
        matrizdoschamps(13, 16) = 1
        matrizdoschamps(13, 17) = 1
        matrizdoschamps(13, 18) = 0
        matrizdoschamps(13, 19) = 0
        matrizdoschamps(14, 0) = 0
        matrizdoschamps(14, 1) = 0
        matrizdoschamps(14, 2) = 1
        matrizdoschamps(14, 3) = 0
        matrizdoschamps(14, 4) = 1
        matrizdoschamps(14, 5) = 0
        matrizdoschamps(14, 6) = 0
        matrizdoschamps(14, 7) = 0
        matrizdoschamps(14, 8) = 0
        matrizdoschamps(14, 9) = 0
        matrizdoschamps(14, 10) = 1
        matrizdoschamps(14, 11) = 1
        matrizdoschamps(14, 12) = 0
        matrizdoschamps(14, 13) = 0
        matrizdoschamps(14, 14) = 0
        matrizdoschamps(14, 15) = 1
        matrizdoschamps(14, 16) = 0
        matrizdoschamps(14, 17) = 0
        matrizdoschamps(14, 18) = 1
        matrizdoschamps(14, 19) = 1
        matrizdoschamps(15, 0) = 0
        matrizdoschamps(15, 1) = 0
        matrizdoschamps(15, 2) = 0
        matrizdoschamps(15, 3) = 0
        matrizdoschamps(15, 4) = 0
        matrizdoschamps(15, 5) = 0
        matrizdoschamps(15, 6) = 0
        matrizdoschamps(15, 7) = 0
        matrizdoschamps(15, 8) = 0
        matrizdoschamps(15, 9) = 0
        matrizdoschamps(15, 10) = 0
        matrizdoschamps(15, 11) = 1
        matrizdoschamps(15, 12) = 0
        matrizdoschamps(15, 13) = 0
        matrizdoschamps(15, 14) = 0
        matrizdoschamps(15, 15) = 1
        matrizdoschamps(15, 16) = 0
        matrizdoschamps(15, 17) = 0
        matrizdoschamps(15, 18) = 0
        matrizdoschamps(15, 19) = 0
        matrizdoschamps(16, 0) = 0
        matrizdoschamps(16, 1) = 1
        matrizdoschamps(16, 2) = 0
        matrizdoschamps(16, 3) = 0
        matrizdoschamps(16, 4) = 1
        matrizdoschamps(16, 5) = 0
        matrizdoschamps(16, 6) = 0
        matrizdoschamps(16, 7) = 0
        matrizdoschamps(16, 8) = 0
        matrizdoschamps(16, 9) = 0
        matrizdoschamps(16, 10) = 0
        matrizdoschamps(16, 11) = 0
        matrizdoschamps(16, 12) = 0
        matrizdoschamps(16, 13) = 0
        matrizdoschamps(16, 14) = 0
        matrizdoschamps(16, 15) = 0
        matrizdoschamps(16, 16) = 0
        matrizdoschamps(16, 17) = 0
        matrizdoschamps(16, 18) = 0
        matrizdoschamps(16, 19) = 0
        matrizdoschamps(17, 0) = 1
        matrizdoschamps(17, 1) = 1
        matrizdoschamps(17, 2) = 1
        matrizdoschamps(17, 3) = 1
        matrizdoschamps(17, 4) = 1
        matrizdoschamps(17, 5) = 1
        matrizdoschamps(17, 6) = 0
        matrizdoschamps(17, 7) = 1
        matrizdoschamps(17, 8) = 1
        matrizdoschamps(17, 9) = 0
        matrizdoschamps(17, 10) = 1
        matrizdoschamps(17, 11) = 1
        matrizdoschamps(17, 12) = 0
        matrizdoschamps(17, 13) = 1
        matrizdoschamps(17, 14) = 1
        matrizdoschamps(17, 15) = 1
        matrizdoschamps(17, 16) = 1
        matrizdoschamps(17, 17) = 1
        matrizdoschamps(17, 18) = 1
        matrizdoschamps(17, 19) = 1
        matrizdoschamps(18, 0) = 0
        matrizdoschamps(18, 1) = 0
        matrizdoschamps(18, 2) = 1
        matrizdoschamps(18, 3) = 0
        matrizdoschamps(18, 4) = 0
        matrizdoschamps(18, 5) = 0
        matrizdoschamps(18, 6) = 1
        matrizdoschamps(18, 7) = 0
        matrizdoschamps(18, 8) = 0
        matrizdoschamps(18, 9) = 0
        matrizdoschamps(18, 10) = 0
        matrizdoschamps(18, 11) = 0
        matrizdoschamps(18, 12) = 1
        matrizdoschamps(18, 13) = 0
        matrizdoschamps(18, 14) = 1
        matrizdoschamps(18, 15) = 0
        matrizdoschamps(18, 16) = 0
        matrizdoschamps(18, 17) = 0
        matrizdoschamps(18, 18) = 0
        matrizdoschamps(18, 19) = 0
        matrizdoschamps(19, 0) = 0
        matrizdoschamps(19, 1) = 0
        matrizdoschamps(19, 2) = 0
        matrizdoschamps(19, 3) = 0
        matrizdoschamps(19, 4) = 0
        matrizdoschamps(19, 5) = 0
        matrizdoschamps(19, 6) = 0
        matrizdoschamps(19, 7) = 1
        matrizdoschamps(19, 8) = 0
        matrizdoschamps(19, 9) = 0
        matrizdoschamps(19, 10) = 1
        matrizdoschamps(19, 11) = 0
        matrizdoschamps(19, 12) = 0
        matrizdoschamps(19, 13) = 0
        matrizdoschamps(19, 14) = 0
        matrizdoschamps(19, 15) = 0
        matrizdoschamps(19, 16) = 1
        matrizdoschamps(19, 17) = 0
        matrizdoschamps(19, 18) = 0
        matrizdoschamps(19, 19) = 0
        matrizdoschamps(20, 0) = 1
        matrizdoschamps(20, 1) = 1
        matrizdoschamps(20, 2) = 0
        matrizdoschamps(20, 3) = 1
        matrizdoschamps(20, 4) = 0
        matrizdoschamps(20, 5) = 1
        matrizdoschamps(20, 6) = 1
        matrizdoschamps(20, 7) = 1
        matrizdoschamps(20, 8) = 1
        matrizdoschamps(20, 9) = 1
        matrizdoschamps(20, 10) = 1
        matrizdoschamps(20, 11) = 0
        matrizdoschamps(20, 12) = 1
        matrizdoschamps(20, 13) = 1
        matrizdoschamps(20, 14) = 0
        matrizdoschamps(20, 15) = 1
        matrizdoschamps(20, 16) = 1
        matrizdoschamps(20, 17) = 1
        matrizdoschamps(20, 18) = 0
        matrizdoschamps(20, 19) = 0
        matrizdoschamps(21, 0) = 0
        matrizdoschamps(21, 1) = 0
        matrizdoschamps(21, 2) = 0
        matrizdoschamps(21, 3) = 0
        matrizdoschamps(21, 4) = 0
        matrizdoschamps(21, 5) = 0
        matrizdoschamps(21, 6) = 1
        matrizdoschamps(21, 7) = 0
        matrizdoschamps(21, 8) = 0
        matrizdoschamps(21, 9) = 0
        matrizdoschamps(21, 10) = 1
        matrizdoschamps(21, 11) = 0
        matrizdoschamps(21, 12) = 1
        matrizdoschamps(21, 13) = 1
        matrizdoschamps(21, 14) = 0
        matrizdoschamps(21, 15) = 0
        matrizdoschamps(21, 16) = 1
        matrizdoschamps(21, 17) = 0
        matrizdoschamps(21, 18) = 1
        matrizdoschamps(21, 19) = 0
        matrizdoschamps(22, 0) = 1
        matrizdoschamps(22, 1) = 0
        matrizdoschamps(22, 2) = 0
        matrizdoschamps(22, 3) = 0
        matrizdoschamps(22, 4) = 0
        matrizdoschamps(22, 5) = 0
        matrizdoschamps(22, 6) = 0
        matrizdoschamps(22, 7) = 0
        matrizdoschamps(22, 8) = 0
        matrizdoschamps(22, 9) = 0
        matrizdoschamps(22, 10) = 0
        matrizdoschamps(22, 11) = 0
        matrizdoschamps(22, 12) = 0
        matrizdoschamps(22, 13) = 0
        matrizdoschamps(22, 14) = 1
        matrizdoschamps(22, 15) = 0
        matrizdoschamps(22, 16) = 0
        matrizdoschamps(22, 17) = 0
        matrizdoschamps(22, 18) = 0
        matrizdoschamps(22, 19) = 0

        'parte dos tooltips, para aparecer os nomes dos champions ao passar o rato por cima da imagem
        Dim toolTipnomesdoschamps As New ToolTip()
        'obriga o texto da ToolTip a ser exibido mesmo que o form não esteja ativo
        toolTipnomesdoschamps.ShowAlways = True
        ' Define o texto da ToolTip para cada PictureBox relativa a cada champion
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_alistar, "Alistar, o Minotauro")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_annie, "Annie, a Criança Sombria")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_bard, "Bard, o Protetor Andarilho")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_blitzcrank, "Blitzcrank, o Grande Golem a Vapor")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_brand, "Brand, a Vingança Flamejante")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_braum, "Braum, o Coração de Freljord")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_janna, "Janna, a Fúria da Tormenta")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_karma, "Karma, a Iluminada")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_leona, "Leona, a Alvorada Radiante")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_lulu, "Lulu, a Fada Feiticeira")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_morgana, "Morgana, o Anjo Caído")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_nami, "Nami, a Conjuradora das Marés")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_rakan, "Rakan, o Charmoso")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_sona, "Sona, a Mestra das Cordas")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_soraka, "Soraka, a Filha das Estrelas")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_tahmkench, "Tahm Kench, o Rei do Rio")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_taric, "Taric, o Escudo de Valoran")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_thresh, "Thresh, o Guardião das Correntes")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_zilean, "Zilean, o Guardião do Tempo")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_zyra, "Zyra, a Ascensão dos Espinhos")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_alistar_pb, "Alistar, o Minotauro")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_annie_pb, "Annie, a Criança Sombria")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_bard_pb, "Bard, o Protetor Andarilho")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_blitzcrank_pb, "Blitzcrank, o Grande Golem a Vapor")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_brand_pb, "Brand, a Vingança Flamejante")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_braum_pb, "Braum, o Coração de Freljord")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_janna_pb, "Janna,a Fúria da Tormenta")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_karma_pb, "Karma, a Iluminada")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_leona_pb, "Leona, a Alvorada Radiante")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_lulu_pb, "Lulu, a Fada Feiticeira")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_morgana_pb, "Morgana, o Anjo Caído")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_nami_pb, "Nami, a Conjuradora das Marés")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_rakan_pb, "Rakan, o Charmoso")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_sona_pb, "Sona, a Mestra das Cordas")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_soraka_pb, "Soraka, a Filha das Estrelas")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_tahmkench_pb, "Tahm Kench, o Rei do Rio")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_taric_pb, "Taric, o Escudo de Valoran")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_thresh_pb, "Thresh, o Guardião das Correntes")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_zilean_pb, "Zilean, o Guardião do Tempo")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_zyra_pb, "Zyra, a Ascensão dos Espinhos")
        toolTipnomesdoschamps.SetToolTip(Me.PictureBox_perguntas, "RECOMEÇAR")
    End Sub
End Class