using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Menu
    {

       private Action action { get; set; }
        public Meneger meneger { get; set; }
        public Client client { get; set; }

        public Menu()
        {

            action = null;
          
        }

        public void Meneger_menu()
        {
            meneger = new Meneger();
            int f;
            do
            {
                Console.WriteLine(" Меню:\n1 - Добавление обьявления\n2 - Удалить обьявление\n3 - Просмотреть архив\n4 - Просмотреть все активные обьявления\n0 - Выход");
                f = int.Parse(System.Console.ReadLine());
                Console.Clear();
                if (f != 0)
                {
                    switch (f)
                    {
                        case 1:
                            action = meneger.Add;
                         
                            break;
                        case 2:
                            action = meneger.Delete;
                            break;
                        case 3:
                            action = meneger.ShowArchive;
                            break;
                        case 4:
                            action = meneger.Baza_Show;
                            break;
                    }
                    action?.Invoke();

                    System.Console.ReadLine();
                    Console.Clear();
                }

            } while (f != 0);
            meneger.Save_file();
    }
        public void Client_menu()
        {
            Console.WriteLine(" Введите ваш логин");
            string login = System.Console.ReadLine();
            Console.WriteLine(" Введите ваш пароль");
            string parol = System.Console.ReadLine();
            Console.WriteLine(" Введите ваш город");
            string city = System.Console.ReadLine();
            client = new Client(login,parol,city);
            Console.Clear();
            Console.WriteLine(" Доступные квартиры в вашем регионе: ");
            action = client.Search;
            System.Console.ReadLine();
             Console.Clear();
            int f;
            do
            {
                Console.WriteLine(" Меню:\n1 - Поиск по цене\n2 - Поиск по этажу\n3 - Поиск по площади\n4 - Поиск по городу \n5 - Поиск по кол-ву комнат\n6 - Сортировка цены по возрастанию\n7 - Сортировка цены по убыванию\n8 - Количество комнат по возрастанию\n9 - Количество комнат по убыванию\n0 - Выход");
                f = int.Parse(System.Console.ReadLine());
                Console.Clear();
                if (f != 0)
                {
                    switch (f)
                    {
                        case 1:
                            action = client.Search_By_Price;
                            break;
                        case 2:
                            action = client.Search_by_floor;
                            break;
                        case 3:
                            action = client.Search_by_square;
                            break;
                        case 4:
                            action = client.Search_by_city;
                            break;
                        case 5:
                            action = client.Search_by_rooms;
                            break;
                        case 6:
                            action = client.Sortby_aA_price;
                            break;
                        case 7:
                            action = client.Sortby_Aa_price;
                            break;
                        case 8:
                            action = client.Sortby_aA_rooms;
                            break;
                        case 9:
                            action = client.Sortby_Aa_rooms;
                            break;
                    }
                    action?.Invoke();

                    System.Console.ReadLine();
                    Console.Clear();
                }
            } while (f != 0);
         



        }

    }
}
