using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Verdureira.FuncoesUteis
{
    internal class Uteis
    {
        public static double ValidaNum(string frase)
        {
            bool paraLaco = true;
            while (paraLaco != false) 
            {
                Console.WriteLine(frase);
                string num = Console.ReadLine();
                try
                {
                    double numeroConvertido = double.Parse(num);
                    paraLaco = false;
                    return numeroConvertido;
                   
                }
                catch
                {
                    Console.WriteLine("Valor digitado não é numérico, digite novamente");
                    Console.Clear();
                   
                }
            }
            return 0;
        }
        public static int ValidaNumInt(string frase)
        {
            bool paraLaco = true;
            while (paraLaco != false)
            {
                Console.WriteLine(frase);
                string num = Console.ReadLine();
                try
                {
                    int numeroConvertido = int.Parse(num);
                    paraLaco = false;
                    return numeroConvertido;

                }
                catch
                {
                    Console.WriteLine("Valor digitado não é numérico, digite novamente");
                    Console.Clear();

                }
            }
            return 0;
        }
        public static DateTime ValidaDate(string frase,string data)
        {
            DateTime valida = DateTime.MinValue;
            bool paraLaco = true;
            while (paraLaco != false)
            {
                try
                {
                    DateTime dataconvertida = DateTime.Parse(data);
                    paraLaco = false;
                    return dataconvertida;

                }
                catch
                {
                    Console.WriteLine("Valor digitado não está no formato dia/mes/ano");
                    Console.WriteLine(frase);
                    data = Console.ReadLine();
                    Console.Clear();

                }
            }
            return valida;
        }
        public static DateTime ValidaDataValidade(DateTime dtc, string frase)
        {
            DateTime valida = DateTime.MinValue;
            bool paraLaco = true;
            while (paraLaco != false)
            {
                Console.WriteLine(frase);
                string dataValidade = Console.ReadLine();
                DateTime dtv = ValidaDate("Digite a data novamente: ",dataValidade);
                if (dtv < dtc)
                {
                    Console.WriteLine("Data de validade não pode ser menor que a de cadastro");
                }
                else
                {
                    paraLaco = false;
                    return dtv;
                }
            }
            return valida;
            
        }

    }
}
