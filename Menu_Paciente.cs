public static void MenuPaciente()
        {
            char opcao;
            int cod = 0;

            do
            {


                Console.Clear();
                Console.WriteLine("MENU PACIENTE");

                Console.WriteLine("Informe qual opção voce deseja:\n" +
                    "a)Fazer cadastro.\n" +
                    "b)Para sair do menu.\n");

                opcao = char.Parse(Console.ReadLine().ToLower());


                switch (opcao)
                {
                    case 'a':


                        FileStream arq = new FileStream("CadastroPaciente.txt", FileMode.OpenOrCreate);
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
                        Console.WriteLine("CADASTRO PACIENTE");

                        FileStream arq1 = new FileStream("CadastroPaciente.txt", FileMode.Append);
                        StreamWriter escreve = new StreamWriter(arq1);
                        string nome, endereco, tel, data_nasc;



                        Console.WriteLine("\nInforme o nome:");
                        nome = Console.ReadLine().ToLower();

                        Console.WriteLine("\nInforme o endereço:");
                        endereco = Console.ReadLine().ToLower();

                        Console.WriteLine("\nInforme o telefone:");
                        tel = Console.ReadLine().ToLower();

                        Console.WriteLine("\nInforme a data de nascimento:");
                        data_nasc = Console.ReadLine().ToLower();

                        escreve.WriteLine(cod + ";" + nome + "," + endereco + "," + tel + "," + data_nasc + ",");

                        escreve.Close();


                        break;

                }

            } while (opcao != 'b');

        }
