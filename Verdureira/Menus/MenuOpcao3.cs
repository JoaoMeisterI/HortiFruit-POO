using System;
using System.Threading;


namespace Verdureira.Menus;

internal class MenuOpcao3 : Menu
{
    public override void MostrarMenu(HortiFruit hf)
    {
        bool paraLaco = false;
        while (paraLaco == false)
        {
            string titulo = "OPÇÃO 3 - LISTAR ALIMENTOS - ";
            MostraBemVindo(titulo);
            Thread.Sleep(1000);
            List<string> opcoes = new List<string> { "0","1", "2", "3" };
            Console.Write("Deseja fazer qual tipo de listagem ?\n");
            Console.WriteLine("1 - LISTAR TODOS OS ALIMENTOS");
            Console.WriteLine("2 - LISTAR SOMENTE AS FRUTAS");
            Console.WriteLine("3 - LISTAR SOMENTE AS VERDURAS");
            Console.WriteLine("0 - VOLTAR AO MENU PRINCIPAL\n");
            string res = Console.ReadLine();
            if (hf.ListaAlimentos.Count == 0)
            {
                Console.WriteLine("A lista de alimentos está vazia");
            }
            else if (!opcoes.Contains(res))
            {
                Console.WriteLine("Valor digitado não se encontra nas opções dispostas, favor revise o valor digitado: ");
            }
            else if (res == "0")
            {
                Console.WriteLine("\n Retornando ao Menu Principal");
                Thread.Sleep(2000);
                Console.Clear();
                paraLaco = true;
            }
            else if (res == "1")
            {
                hf.ListarAlimentos("1",hf);
            }
            else if (res == "2")
            {
                hf.ListarAlimentos("Fruta", hf);
            }
            else if (res == "3")
            {
                hf.ListarAlimentos("Verdura", hf);
            }
        }
        
    }
}
