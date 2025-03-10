using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursoCSharp
{

    /// <summary>
    /// Permite que a execução de uma operação seja executada separadamente da theat principal até que a operação seja concluida.
    /// 
    /// </summary>
    public static class Assincrono
    {
    
        public static async Task Executa(int tempoDeEspera)
        {
            await Task.Delay(tempoDeEspera);
        }
    
    
    
    }
}
