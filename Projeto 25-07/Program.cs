using System;

namespace Projeto_25_07
{
    class Program
    {
        public static string cabecalho_final()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine("Obrigado por utilizar o portal de produtos");
            Console.WriteLine("==========================================");
            Console.WriteLine("                        Por Gabriel Corrêa");
            Console.WriteLine("==========================================");
            return null;
        }
        public static string A()
        {
            Console.WriteLine("▀█████████▄     ▄████████   ▄▄▄▄███▄▄▄▄         ▄█    █▄   ▄█  ███▄▄▄▄   ████████▄   ▄██████▄     ▄████████ ");
            Console.WriteLine("  ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄      ███    ███ ███  ███▀▀▀██▄ ███   ▀███ ███    ███   ███    ███ ");
            Console.WriteLine("  ███    ███   ███    █▀  ███   ███   ███      ███    ███ ███▌ ███   ███ ███    ███ ███    ███   ███    █▀  ");
            Console.WriteLine(" ▄███▄▄▄██▀   ▄███▄▄▄     ███   ███   ███      ███    ███ ███▌ ███   ███ ███    ███ ███    ███   ███        ");
            Console.WriteLine("▀▀███▀▀▀██▄  ▀▀███▀▀▀     ███   ███   ███      ███    ███ ███▌ ███   ███ ███    ███ ███    ███ ▀███████████ ");
            Console.WriteLine("  ███    ██▄   ███    █▄  ███   ███   ███      ███    ███ ███  ███   ███ ███    ███ ███    ███          ███ ");
            Console.WriteLine("  ███    ███   ███    ███ ███   ███   ███      ███    ███ ███  ███   ███ ███   ▄███ ███    ███    ▄█    ███ ");
            Console.WriteLine("▄█████████▀    ██████████  ▀█   ███   █▀        ▀██████▀  █▀    ▀█   █▀  ████████▀   ▀██████▀   ▄████████▀  ");
            Console.WriteLine("                                                                                                            ");
            return null;
        }
        static void Main(string[] args)
        {

            A();

            string opc;
            Produtos prod = new Produtos();

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Escolha uma Opção: \n1 - Cadastro de produtos \n2 - Alterar produtos \n3 - Remover produtos \n4 - Listar produtos \n5 - Sair");
                Console.Write("Digite sua opção: ");
                opc = Console.ReadLine();

                switch (opc)
                { 
                    case "1":
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Digite um nome: ");
                        prod.Nome = Console.ReadLine();
                        Console.Write("Digite a marca do produto: ");
                        prod.Marca = Console.ReadLine();
                        Console.Write("Digite o preço desse produto: ");
                        prod.Preco = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        Manipulacao mn = new Manipulacao();
                        mn.CadastroProd(prod.Nome, prod.Marca, prod.Preco);

                        break;

                    case "2":

                        string opc2;
                        Console.WriteLine("");
                        Console.Write("O que você deseja alterar? \n1 - Alterar nome \n2 - Alterar preço \n3 - Alterar marca \nDigite sua opção: ");
                        opc2 = Console.ReadLine();

                        switch (opc2)
                        {
                            case "1":
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Digite o produto que deseja alterar: ");
                                prod.Nome = Console.ReadLine();                               
                                Console.Write("Digite a marca desse produto: ");
                                prod.Marca = Console.ReadLine();
                                Console.Write("Digite o novo nome desse produto: ");
                                prod.Novonome = Console.ReadLine();
                                Console.WriteLine("");

                                mn = new Manipulacao();
                                mn.AlterN(prod.Nome,prod.Novonome, prod.Marca);
                                break;

                            case "2":
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Digite o produto que deseja alterar: ");
                                prod.Nome = Console.ReadLine();
                                Console.Write("Digite a marca desse produto: ");
                                prod.Marca = Console.ReadLine();
                                Console.Write("Digite o preço desse produto: ");
                                prod.Preco = Double.Parse(Console.ReadLine());
                                Console.Write("Digite o novo preço desse produto: ");
                                prod.NovoPreco = Double.Parse(Console.ReadLine());
                                Console.WriteLine("");

                                mn = new Manipulacao();
                                mn.AlterP(prod.Nome, prod.Marca, prod.Preco,prod.NovoPreco);
                                break;

                            case "3":
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Digite o produto que deseja alterar: ");
                                prod.Nome = Console.ReadLine();
                                Console.Write("Digite a marca desse produto: ");
                                prod.Marca = Console.ReadLine();
                                Console.Write("Digite a nova marca desse produto: ");
                                prod.NovaMarca = Console.ReadLine();
                                Console.WriteLine("");

                                mn = new Manipulacao();
                                mn.AlterM(prod.Nome, prod.Marca, prod.NovaMarca);
                                break;

                            default:
                                Console.WriteLine("");
                                Console.WriteLine("Opção inválida!");
                                Console.WriteLine("");
                                break;
                        }
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("");
                        Console.Write("Digite um nome: ");
                        prod.Nome = Console.ReadLine();
                        Console.Write("Digite a marca: ");
                        prod.Marca = Console.ReadLine();
                        Console.WriteLine("");
                        
                        mn = new Manipulacao();
                        mn.Delete(prod.Nome,prod.Marca);
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Magenta;                    
                        mn = new Manipulacao();
                        Console.WriteLine("");
                        Console.WriteLine("======Lista de Items======");
                        mn.Select();
                        Console.WriteLine("");
                        break;

                    case "5":
                        Console.WriteLine("");
                        Console.WriteLine("Encerrando...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("");
                        break;
                }


            } while (opc != "5");

            cabecalho_final();
            Console.ReadKey();
            
        }

        }
    }

