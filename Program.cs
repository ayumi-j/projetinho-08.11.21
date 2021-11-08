using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetinho1
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            Cadastro c =new Cadastro();
            Menu m = new Menu();

            op = Console.ReadLine();

            do
            {
                op = m.menu();
                switch (op)
                {
                    case "1":
                        c.cadpet();
                        c.visucadpet();
                        break;
                    case "2":
                        c.cadpessoa();
                        c.visucadpessoa();
                        break;
                    case "3":
                        c.visucadpet();
                        break;
                    case "4":
                        c.visucadpessoa();
                        break;
                    case "S":
                        Console.WriteLine("Encerrando o programa");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (op != "S");
        }
    }
}

