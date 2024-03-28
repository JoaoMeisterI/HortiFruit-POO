using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verdureira;
using Verdureira.FuncoesUteis;

namespace Verdureira.Menus;

abstract class Menu
{
    public virtual void MostrarMenu(HortiFruit hf)
    {
        Console.WriteLine("Menu Principal");
    }
    public static string RetornaOpcao()
    {
        try
        {
            string opcao;
            Console.WriteLine("Qual opção você deseja realizar ? \n");
            Console.WriteLine("1 - Adicionar Fruta / Verdura");
            Console.WriteLine("2 - Remover Fruta / Verdura");
            Console.WriteLine("3 - Listar Todas as Frutas / Verduras Disponíveis");
            Console.WriteLine("4 - Sair do Programa HortiFruit\n");
            Console.WriteLine("Resposta: ");
            opcao = Console.ReadLine();
            //
            //
            return opcao;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return "";
        }
    }
    public static void MostraBemVindo(string titulo)
    {
        int quantidadeTitulo = titulo.Length;
        string quantidadeAsterisco = new string('*', quantidadeTitulo);
        Console.WriteLine(quantidadeAsterisco);
        Console.WriteLine(titulo);
        Console.WriteLine(quantidadeAsterisco + "\n");
    }
    public static void MenuAdicionaItem(HortiFruit hf,string num)
    {
        try
        {
            DateTime hoje = DateTime.Now;
            Console.WriteLine("Responda as seguinte informações: ");
            Console.WriteLine("Nome: ");
            string nomeAlimento = Console.ReadLine();
            double precoPago = Uteis.ValidaNum("Valor Pago: ");
            double valorVenda = Uteis.ValidaNum("Valor de Venda: ");
            DateTime dataValidade = Uteis.ValidaDataValidade(hoje, "Data de Validade (Formato da data 01/01/2001): ");
            int quantidadeComprada = Uteis.ValidaNumInt("Quantidade Comprada: ");
            if (num == "1")
            {
                Alimento a = new Fruta(nomeAlimento, precoPago, dataValidade, quantidadeComprada, valorVenda);
                hf.AdicionarAlimento(a);
            }
            if (num == "2")
            {
                Alimento a = new Verdura(nomeAlimento, precoPago, dataValidade, quantidadeComprada, valorVenda);
                hf.AdicionarAlimento(a);
            }
        }
        catch
        {
            Console.WriteLine("Valores Digitados estão incorretos");
        }
    }
}
