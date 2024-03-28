using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdureira;

internal class Verdura : Alimento
{
    public double ValorVenda { get; set; }
    public Verdura(string nomeAlimento,double preco, DateTime dataValidade,int quantidade, double valorVenda) : base(nomeAlimento,preco,dataValidade,quantidade)
    {
        Tipo = "Verdura";
        Data = base.Data;
        ValorVenda = valorVenda;
    }
}
