using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdureira
{
    public class Alimento
    {
        public Alimento(string nomeAlimento, double preco, DateTime dataValidade,int quantidade)
        {
            NomeAlimento = nomeAlimento;
            DataValidade = dataValidade;
            Preco = preco;
            Tipo = "";
            Data = DateTime.Now;
            Quantidade = quantidade;   
        }
        public string NomeAlimento {get; set; }
        public double Preco {get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataValidade {get; set;}
        public int Quantidade { get; set; }
        public void infoAlimento()
        {
            Console.WriteLine($"\nTipo:{Tipo}\nNome:{NomeAlimento}\nPreço:{Preco}\nData Cadastro: {Data}\nData Validade: {DataValidade}\n");
        }
    }
}
