// See https://aka.ms/new-console-template for more information
using RecursoCSharp;
using RecursoCSharp.Colections;



#region Dicionario
//Dictionary.Executa();
//Dictionary.ObterValorPorIdChave(1);
#endregion

#region Tupla
//var teste = Tupla.ValidaNomeTamanhoNomeUsuario("Teste");
//Console.WriteLine($"{teste.valido} - { teste.Nome}");

#endregion

#region Asincrono
int tempoEspera = 5000;
Console.WriteLine($"Iniciou processamento.");
await Assincrono.Executa(tempoEspera);
Console.WriteLine($"Aguardou {(tempoEspera/1000)} segundos....");




#endregion