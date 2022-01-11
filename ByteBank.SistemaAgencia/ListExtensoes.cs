using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        // método de extensão
        // this: indice que estamos extendendoo tipo 'List'
        public static void AdicionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {
            listaDeInteiros.AddRange(itens);
        }
    }
}