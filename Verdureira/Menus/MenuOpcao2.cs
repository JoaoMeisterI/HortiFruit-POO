using System;
using System.Collections.Generic;
using System.Threading;


namespace Verdureira.Menus;

internal class MenuOpcao2 : Menu
{
    public override void MostrarMenu(HortiFruit hf)
    {
        bool paraLaco = false;
        while (paraLaco == false)
        {
            string titulo = "OPÇÃO 2 - REMOVER ALIMENTOS - ";
            MostraBemVindo(titulo);
            Thread.Sleep(1000);
            List<int> opcoes = hf.CriaListaNumeros();
            Console.WriteLine("Segue os alimentos disponíveis em estoque\n");
            hf.ListarAlimentos("1", hf);
            Console.WriteLine("Digite qual Alimento você quer excluir pelo índice numérico\n");
            Console.WriteLine("Para voltar ao menu principal digite - 0");
            Console.WriteLine("Resposta: \n");
            try
            {
                int resIndice;
                if (!int.TryParse(Console.ReadLine(), out resIndice))
                {
                    Console.WriteLine("Valor digitado não é numérico");
                    return;
                }
                else if(resIndice == 0) 
                {
                    Console.WriteLine("Retornando ao Menu Principal");
                    Thread.Sleep(2000);
                    Console.Clear();
                    paraLaco = true;
                }
                else if (!opcoes.Contains(resIndice))
                {
                    Console.WriteLine("Não existe esse índice na lista, favor revise sua resposta !");
                }
                else
                {
                    Alimento alimento = hf.ListaAlimentos[resIndice - 1];
                    hf.RemoveAlimento(alimento);
                    Console.WriteLine($"{alimento.NomeAlimento} removido com sucesso!");
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
        
    }
}
