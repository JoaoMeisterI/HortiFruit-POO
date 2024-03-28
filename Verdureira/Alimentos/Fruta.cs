using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdureira;

internal class Fruta : Alimento
{
    public double ValorVenda { get; set; }
    public Fruta(string nomeAlimento, double preco, DateTime dataValidade, int quantidade, double valorVenda) : base(nomeAlimento, preco, dataValidade, quantidade)
    {
        Tipo = "Fruta";
        Data = base.Data;
        ValorVenda = valorVenda;
    }
}