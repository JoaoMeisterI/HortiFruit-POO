using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdureira;

public class HortiFruit
{
    public List<Alimento> ListaAlimentos = new List<Alimento>();
    
    public void AdicionarAlimento(Alimento alimento)
    {
        try
        {
            ListaAlimentos.Add(alimento);
            Console.WriteLine($"{alimento.NomeAlimento} adicionado com sucesso");
            Thread.Sleep(2000);
            Console.Clear();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro/Função: AdicionarAlimento()/Classe: HortiFruit: \n{ex}");
        }
    }
    public void RemoveAlimento(Alimento alimento)
    {
        try
        {
            ListaAlimentos.Remove(alimento);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro/Função: RemoveAlimento()/Classe: HortiFruit: \n{ex}");
        }
    }
    public void ListarAlimentos(string tipo, HortiFruit hf)
    {
        try
        {
            int cont = 1;
            if (tipo == "1")
            {
                
                foreach(var alimento in ListaAlimentos) 
                {
                    Console.WriteLine($"Indice - {cont}");
                    alimento.infoAlimento();
                    cont += 1;
                }
            }
            else
            {
                List<Alimento> listaSelecionados = hf.ListaAlimentos.Where(x => x.Tipo == tipo).ToList();
                foreach (var alimento in listaSelecionados)
                {
                    Console.WriteLine($"Indice - {cont}\n");
                    alimento.infoAlimento();
                    cont += 1;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro/Função: RemoveAlimento()/Classe: HortiFruit: \n{ex}");
        }
    }

    public List<int> CriaListaNumeros()
    {
        List<int> listaIndice = new List<int>();
        int tamanhoListaMoedas = ListaAlimentos.Count();
        for (int i = 0; i <= tamanhoListaMoedas; i++)
        {
            listaIndice.Add(i);
        }
        return listaIndice;
    }
}
