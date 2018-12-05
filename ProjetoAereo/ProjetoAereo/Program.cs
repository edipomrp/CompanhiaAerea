using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoAereo
{
    class Program
    {
        static void Main(string[] args) {
            Voo vooSelec = null;
            String nomeVoo = "";
            ArrayList passageiros = new ArrayList();
            Boolean exibiMenu = false;
            Endereco endereco = new Endereco("Rua teste", 132, "Industrial", "Contagem");
            Pessoa pessoa = new Pessoa(endereco, "Edipo", "111.111.111-11", "Mendes", "(31)1324-4658", 1, 02);
            passageiros.Add(pessoa);
            Voo voo = new Voo("BH", "Recife", "10:00", passageiros);
            Voo voo2 = new Voo("BH", "Rio", "09:00", passageiros);
            Voo voo3 = new Voo("BH", "São Paulo", "13:00", passageiros);
            Console.WriteLine("Selecione um voo: (1)BH/Recife, (2)BH/RIO, (3)BH/SP \n");
            int vooSelecionado = Convert.ToInt32(Console.ReadLine());
            if (vooSelecionado == 1)
                { nomeVoo = "\n BH/Recife \n";
                vooSelec = voo; }
            else if (vooSelecionado == 2)
                { nomeVoo = "\n BH/Rio \n";
                vooSelec = voo; }
            else if (vooSelecionado == 3)
                { nomeVoo = "\n BH/SP \n";
                vooSelec = voo; }
            do
            {
               
                Console.WriteLine("\n \n \n Voo "+ nomeVoo);
                menu();
                var opcao = Console.ReadKey();
                exibiMenu = opcao.Key == ConsoleKey.Escape ? false : true;
                if (opcao.Key == ConsoleKey.F1) {
                    foreach (Pessoa passageiro in vooSelec.passageiros) {
                        Console.Write(passageiro.ToString() +"\n");
                    }
                }
                if (opcao.Key == ConsoleKey.F2) {
                    Console.WriteLine("\nDigite o CPF do passageiro: ");
                    String cpfPassageiro = Console.ReadLine();
                    foreach (Pessoa passageiro in vooSelec.passageiros)
                    {
                        if (passageiro.cpf.Equals(cpfPassageiro))
                        {
                            Console.WriteLine(passageiro.ToString());
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Passageiro não encontrado");
                        }
                    }
                }
                if (opcao.Key == ConsoleKey.F3) {
                    cadastraPassageiro(vooSelec);
                }
                
                if(opcao.Key == ConsoleKey.F4) {
                    excluiPassageiro(vooSelec);
                }

                if(opcao.Key == ConsoleKey.F5) {
                    mostrarListaEspera(vooSelec);
                }
                

            } while (exibiMenu);

            Environment.Exit(0);
            
        }

        public static void menu() {
            Console.WriteLine("\n[F1] Lista de passageiros\n" +
                "[F2] Pesquisar\n" +
                "[F3] Cadastrar passageiros\n" +
                "[F4] Excluir passageiro da lista\n" +
                "[F5] Mostrar fila de espera\n" +
                "[ESC] SAIR\n\n\n");
        }

        public static void excluiPassageiro(Voo voo) {
            Console.WriteLine("Digite um número de 0 á " + (voo.passageiros.Count -1));
            int num = Convert.ToInt32(Console.ReadLine());
            voo.passageiros.RemoveAt(num);
            if (voo.filaEspera.Count > 0) {
                voo.passageiros.Add(voo.filaEspera.Dequeue());
            }
        }

        public static void mostrarListaEspera(Voo voo) {
            foreach(Pessoa passageiro in voo.filaEspera.ToArray()) {
                Console.WriteLine(passageiro.ToString());
            }
        }

        public static void cadastraPassageiro(Voo voo) {
            if(voo.filaEspera.Count == 5)
            {
                Console.WriteLine("Reserva não pode ser feita.");
                return;
            }
            Console.WriteLine("Digite a rua do passageiro: ");
            String rua = Console.ReadLine();
            Console.WriteLine("Digite o Bairro: ");
            String bairro = Console.ReadLine();
            Console.WriteLine("Digite a cidade: ");
            String cidade = Console.ReadLine();
            Console.WriteLine("Digite o numero da residência: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Endereco end = new Endereco(rua, num, bairro, cidade);
            Console.WriteLine("Digite o nome do passageiro: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Digite o Sobrenome do passageiro: ");
            String sobreNome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do passageiro: ");
            String cpf = Console.ReadLine();
            Console.WriteLine("Digite o telefone do passageiro: ");
            String tel = Console.ReadLine();
            Console.WriteLine("Digite o número de passagem do passageiro: ");
            int numPassagem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número da poltrona do passageiro: ");
            int numPoltrona = Convert.ToInt32(Console.ReadLine());
            Pessoa passageiro = new Pessoa(end, nome, cpf, sobreNome, tel, numPassagem, numPoltrona);
            if (voo.passageiros.Count < 5)
            {
                voo.passageiros.Add(passageiro);
            } else if (voo.filaEspera.Count < 5)
            {
                voo.filaEspera.Enqueue(passageiro);
            } else
            {
                Console.WriteLine("Reserva não pode ser feita.");
            }
        }
    }

 
}
