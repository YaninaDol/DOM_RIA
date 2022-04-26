using System;

namespace DOM_RIA
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();

            Console.WriteLine("1 - Вход менеджера\n2 - Вход клиента\nВаш выбор: ");

            int chose = int.Parse(System.Console.ReadLine());
            if(chose==1)
            {
                Console.Clear();
                menu.Meneger_menu();
            }
            if(chose==2)
            {
                Console.Clear();
                menu.Client_menu();
            }
          
           
        }
    }
}
