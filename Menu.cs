﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetinho1
{
    class Menu
    {

        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar pet");
            Console.WriteLine("2 - Cadastrar membro ");
            Console.WriteLine("3 - visualizar pet");
            Console.WriteLine("4 - visualizar membro");
            Console.WriteLine("S - Sair");
            Console.WriteLine("Escolha uma opcao:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }
    }
}