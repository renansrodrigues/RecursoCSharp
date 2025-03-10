// See https://aka.ms/new-console-template for more information
using RecursoCSharp;
using RecursoCSharp.Colections;



#region Dicionario
//Dictionary.Executa();
//Dictionary.ObterValorPorIdChave(1);
#endregion

#region Tupla
var teste = Tupla.ValidaNomeTamanhoNomeUsuario("Teste");
Console.WriteLine($"{teste.valido} - { teste.Nome}");

#endregion