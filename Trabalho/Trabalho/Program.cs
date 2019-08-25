using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Trabalho
{
    class Program
    {
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


        public static void MenuConsulta()
        {
            char opcao;
            int cod = 0;

            do
            {


                Console.Clear();
                Console.WriteLine("MENU CONSULTA");

                Console.WriteLine("Informe qual opção voce deseja:\n" +
                    "a)Cadastrar nova consulta.\n" +
                    "b)Excluir uma consulta.\n" +
                    "c)Pesquisar consulta.\n" +
                    "d)Para sair do menu.\n");

                opcao = char.Parse(Console.ReadLine().ToLower());

                string nomepc, nomemed;

                switch (opcao)
                {
                    case 'a':

                        FileStream arq = new FileStream("CadastroConsulta.txt", FileMode.OpenOrCreate);
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


                        Console.WriteLine("CADASTRO CONSULTA");
                        Console.Clear();
                        int cpc = 0, cmed = 0, aux_p = 0, aux_m = 0;

                        do
                        {
                            aux_p = 0; aux_m = 0;
                            Console.Clear();
                            Console.WriteLine("\n Digite o Nome do Paciente: ");
                            nomepc = Console.ReadLine().ToLower();
                            Console.WriteLine("\n Digite o Nome do Medico: ");
                            nomemed = Console.ReadLine().ToLower();

                            FileStream arqpc = new FileStream("CadastroPaciente.txt", FileMode.OpenOrCreate);
                            StreamReader lerpc = new StreamReader(arqpc);

                            FileStream arqmed = new FileStream("CadastroMedico.txt", FileMode.OpenOrCreate);
                            StreamReader lermed = new StreamReader(arqmed);

                            string lpc, lmed;
                            string[] codpc, codmed;
                            string[] npc, nmed;

                            do
                            {
                                lpc = lerpc.ReadLine();

                                if (lpc != null)
                                {
                                    codpc = lpc.Split(';');
                                    npc = codpc[1].Split(',');

                                    if (nomepc.Equals(npc[0]))
                                    {
                                        cpc = int.Parse(codpc[0]);
                                        aux_p = 1;
                                    }
                                }

                            } while (lpc != null);

                            do
                            {
                                lmed = lermed.ReadLine();

                                if (lmed != null)
                                {
                                    codmed = lmed.Split(';');
                                    nmed = codmed[1].Split(',');

                                    if (nomemed.Equals(nmed[0]))
                                    {
                                        cmed = int.Parse(codmed[0]);
                                        aux_m = 1;
                                    }
                                }

                            } while (lmed != null);

                            if (aux_m != 1 && aux_p != 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\n Paciente e Medico não encontrados!!");
                                Console.ReadKey();
                                aux_m = 0;
                                aux_p = 0;
                            }
                            else if (aux_p != 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\n Paciente não encontrado!!");
                                Console.ReadKey();
                                aux_p = 0;
                            }
                            else if (aux_m != 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\n Medico não encontrado!!");
                                Console.ReadKey();
                                aux_m = 0;
                            }

                            lerpc.Close();
                            lermed.Close();

                        } while (aux_p != 1 || aux_m != 1);

                        FileStream arq2 = new FileStream("CadastroConsulta.txt", FileMode.Append);
                        StreamWriter escreve = new StreamWriter(arq2);

                        string dt, hr;


                        Console.WriteLine("\nDigite a data da consulta:");
                        dt = Console.ReadLine().ToLower();

                        Console.WriteLine("\nDigite um horario para consulta:");
                        hr = Console.ReadLine().ToLower();

                        // criar logica para vê se tem mais 2 consultas para o medico
                        // criar logica para consultar com 30 min de intervalo pro mesmo medico
                        // depois disso tudo, ai sim deve cadastrar a consulta

                        escreve.WriteLine(cod + ";" + cpc + "," + cmed + "," + dt + "," + hr + ",");

                        escreve.Close();

                        break;

                }

            } while (opcao != 'd');
        }

        
    }
}
