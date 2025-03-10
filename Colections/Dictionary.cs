using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursoCSharp.Colections
{

    /// <summary>
    /// Estrutura chave valor Exemplo       
    /// </summary>
    public static class Dictionary
    {
        //Declaraçao
        public static Dictionary<int, string> itens = new Dictionary<int, string>()
        {
            [1] = "a",
            [2] = "b",
            [3] = "c",
        };
        
        public static void Executa()
        {
            //Adicionar 
            itens.Add(10, "d");

            //Como percorrer
            foreach (KeyValuePair<int,string> pair in itens)
            {
               Console.WriteLine($"CHAVE: { pair.Key},VALOR:{pair.Value}");
            }
        }
        public static void ObterValorPorIdChave(int chave)
        {
            if(itens.TryGetValue(chave,out string valor))
            {                
                   Console.WriteLine($"O valor encontrado é : {valor}");

            }
            else
            {
                Console.WriteLine($"Nenhum valor encontrado para a Chave : {chave}");
            }

        }

        


     
    }
}
