public static void Main(string[] args)
        {
            char opcao;
            do
            {
                DateTime data = System.DateTime.Now;

                Console.Clear();
                Console.WriteLine(" ----- CLÍNICA VIVA BEM -----\n");
                Console.WriteLine(data + "\n");

                Console.WriteLine("Seja bem-vindo!\n");
                Console.WriteLine("Informe qual opção voce deseja:\n" +
                 "a)Cadastrar paciente.\n" +
                 "b)Cadastrar médico.\n" +
                 "c)Cadastrar Consulta.\n" +
                 "d)Para sair.\n");

                opcao = char.Parse(Console.ReadLine().ToLower());

                switch (opcao)
                {
                    case 'a':
                        MenuPaciente();
                        break;

                    case 'b':
                        MenuMedico();
                        break;

                    case 'c':
                        MenuConsulta();
                        break;
                }
            } while (opcao != 'd');



            Console.ReadKey();
        }
