using System.Threading;
using Verdureira.Menus;
using Verdureira;
using Verdureira.FuncoesUteis;
//
//
Console.OutputEncoding = System.Text.Encoding.UTF8;
//
Menu.MostraBemVindo("Seja bem vindo ao sistema de Horti Fruit");
//
Thread.Sleep(2000);
//
HortiFruit hf = new HortiFruit();
bool rodarSistema = true;
//
while (rodarSistema == true)
{
    //
    string opcao = Menu.RetornaOpcao();
    //
    switch (opcao)
    {
        case "1":
            Menu menu1 = new MenuOpcao1();
            menu1.MostrarMenu(hf);
            break;
        case "2":
            Menu menu2 = new MenuOpcao2();
            menu2.MostrarMenu(hf);
            break;
        case "3":
            Menu menu3 = new MenuOpcao3();
            menu3.MostrarMenu(hf);
            break;
        case "4":
            Console.WriteLine("$$ Encerrando Programa Horti Fruit $$");
            rodarSistema = false;
            break;
        default:
            Console.WriteLine("Opção inválida, revise sua resposta!! \n");
            break;
    }
}
