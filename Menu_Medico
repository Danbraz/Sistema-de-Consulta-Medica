public static void MenuMedico()
        {
            char opcao;
            int cod = 0;

            do
            {


                Console.Clear();
                Console.WriteLine("MENU MÉDICO");

                Console.WriteLine("Informe qual opção voce deseja:\n" +
                    "a)Fazer cadastro.\n" +
                    "b)Para sair do menu.\n");

                opcao = char.Parse(Console.ReadLine().ToLower());


                switch (opcao)
                {
                    case 'a':


                        FileStream arq = new FileStream("CadastroMedico.txt", FileMode.OpenOrCreate);
                        StreamReader ler = new StreamReader(arq);
                        string linha;
                        int maiorcod;
                        int maior = 0;
                        string[] vet;
                        int contt = 0;


                        do
                        {
                            linha = ler.ReadLine();

                            if (linha != null)
                            {
                                vet = linha.Split(';');
                                maiorcod = int.Parse(vet[0]);

                                if (contt == 0)
                                {
                                    maior = maiorcod;
                                    contt++;
                                }
                                else if (maior < maiorcod)
                                {
                                    maior = maiorcod;
                                }

                            }
                            else if (linha == null)
                            {
                                cod = 1;
                            }


                        } while (linha != null);

                        cod = maior;
                        cod++;
                        ler.Close();


                        Console.Clear();
                        Console.WriteLine("CADASTRO MÉDICO");

                        FileStream arq1 = new FileStream("CadastroMedico.txt", FileMode.Append);
                        StreamWriter escreve = new StreamWriter(arq1);
                        string nome, tel, especialidade;

                        Console.WriteLine("\nInforme o nome:");
                        nome = Console.ReadLine().ToLower();

                        Console.WriteLine("\nInforme o telefone:");
                        tel = Console.ReadLine().ToLower();

                        Console.WriteLine("\nInforme a especialidade:");
                        especialidade = Console.ReadLine().ToLower();

                        escreve.WriteLine(cod + ";" + nome + "," + tel + "," + especialidade + ",");

                        escreve.Close();

                        break;

                }

            } while (opcao != 'b');
        }
