using System;
using System.Collections.Generic;
using System.Threading;
using Verdureira.FuncoesUteis;

namespace Verdureira.Menus;
    internal class MenuOpcao1 : Menu
    {
        public override void MostrarMenu(HortiFruit hf)
        {
            string titulo = "OPÇÃO 1 - ADICIONAR ALIMENTOS - ";
            MostraBemVindo(titulo);
            Thread.Sleep(1000);
            List<string> opcoes = new List<string> { "1", "2","3"};
            string tipoAlimento = "";
            while (tipoAlimento != "3")
            {
                Console.WriteLine("Qual tipo Alimento você quer adicionar ?");
                Console.WriteLine("1 - FRUTA  ");
                Console.WriteLine("2 - VERDURA ");
                Console.WriteLine("3 - VOLTAR ");
                Console.WriteLine("Resposta: \n");
                tipoAlimento = Console.ReadLine();
                if (!opcoes.Contains(tipoAlimento))
                {
                    Console.WriteLine($"A opção {tipoAlimento} não existe dentro das opções");
                }
                else if(tipoAlimento == "3")
                {
                    Console.WriteLine("Voltando para o menu principal");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    try
                    {
                        switch (tipoAlimento)
                        {
                            case "1":
                                MenuAdicionaItem(hf, "1");
                                break;
                            case "2":
                                MenuAdicionaItem(hf, "2");
                                break;
                            default:
                                Console.WriteLine("Não foi possível adicionar o Alimento");
                                break;
                        }
                        Thread.Sleep(2000);
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Valor digitado não é numérico");
                    }
                }
        }
            
        }
    }

