using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursoCSharp
{
    /// <summary>
    /// Estrutura que permite armazenada varios tipos de dados.
    /// </summary>
    public static class Tupla
    {
    
    
      public static (bool valido, string Nome) ValidaNomeTamanhoNomeUsuario(string nome)
        {

            if (!string.IsNullOrEmpty(nome)) {

                return (false, nome);
            }


            if (nome.Length > 20)
            {

                return (false, nome);
            }



            return (true,$"O tamanho do nome é válido {nome}");


        }
    
    }
}
