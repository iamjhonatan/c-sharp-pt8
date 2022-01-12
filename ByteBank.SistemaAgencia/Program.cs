using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        private static void Main(string[] args)
        {
            var lista = new ListaDeContaCorrente();
            
            var contaDoJhojho = new ContaCorrente(1111, 1222);

            var contas = new ContaCorrente[]
            {
                contaDoJhojho,
                new ContaCorrente(874, 1239),
                new ContaCorrente(874, 12310)
            };

            lista.AdicionarVarios(contas);
            
            for (var i = 0; i < lista.Tamanho; i++)
            {
                var itemAtual = lista[i];
                Console.WriteLine($"item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
            
            
            // Array de inteiros com 5 posições

            var idades = new List<int>();

            idades.AdicionarVarios(1, 5, 14, 25, 9);
            
            idades.Sort();

            for (var i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
            
            // === Ordenação de Strings ===

            var nomes = new List<string>()
            {
                "Gui",
                "Jho",
                "Teste",
                "Ana"
            };
            
            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            
            
            // Ordenação de Contas Corrente
            
            var contas2 = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950)
            };

            contas2.Sort();

            foreach (var conta in contas2)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }
            
            
            

            Console.ReadLine();
            // ** Ctrl + k + c = comenta várias linhas
        }
    }
}
