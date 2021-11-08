using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetinho1
{
    class Cadastro
    {
        string NomePet;
        string Especie;
        string Raca;
        int IdadePet;
        int IdPet;
        string NomePes;
        int cpf;
        int telefone;
        string endereco;


        public void cadpet()
        {
            Console.WriteLine("---novos membros pet---");
            Console.WriteLine("Digite o nome do Pet");
            NomePet = Console.ReadLine();
            Console.WriteLine("Digite a espécie do Pet");
            Especie = Console.ReadLine();
            Console.WriteLine("Digite a raça do Pet");
            Raca = Console.ReadLine();
            Console.WriteLine("Digite a idade do Pet");
            IdadePet = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o id do Pet");
            IdPet = int.Parse(Console.ReadLine());
        }
        
            public void visucadpet()
        {
            Console.WriteLine("nome do Pet: {0}", NomePet);
            Console.WriteLine("espécie do Pet: {0}", Especie);
            Console.WriteLine("raça do Pet: {0}", Raca);
            Console.WriteLine("idade do Pet: {0}", IdadePet);
            Console.WriteLine("id do Pet: {0}", IdPet);
        }

        public void cadpessoa()
        {
            Console.WriteLine("----- novos membros -----");
            Console.WriteLine("Digite o nome");
            NomePes = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o telefone");
            telefone = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o endereço");
            endereco = Console.ReadLine();
        }

        public void visucadpessoa()
        {
            Console.WriteLine("----- novo membro -----");
            Console.WriteLine("nome: {0}", NomePes);
            Console.WriteLine("CPF: {0}", cpf);
            Console.WriteLine("telefone: {0}", telefone);
            Console.WriteLine("endereço: {0}", endereco);
        }
    }
}
