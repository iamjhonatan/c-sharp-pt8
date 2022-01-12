using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        // método de extensão
        // this: indice que estamos extendendo tipo 'List'
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            lista.AddRange(itens);
        }
    }
}