using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Client:Baza
    {
        public string Login { get; set; }
        public string Parol { get; set; }
        public string City { get; set; }

        public List<Advertising> MyAdvertisings { get; set; }
      

        public Client(string login,string parol,string city):base()
        {
            MyAdvertisings = base.ReadFile();
            Login = login;
            Parol = parol;
            City = city;
        }

        public void Search()
        {

            foreach (var i in MyAdvertisings.Where(p => p.Flat.Location.City==this.City))
            {
                Console.WriteLine(i.ToString());
            }
        }
        public void Search_By_Price()
        {
            Console.WriteLine(" Выберите валюту поиска:\n 1 - гривна\n 2 - доллар\n 3 - цена за 1кв.м");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine(" Введите  от : ");
            int from = int.Parse(Console.ReadLine());

            Console.WriteLine(" Введите  до : ");
            int to = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    foreach (var i in MyAdvertisings.Where(p => p.Flat.Price.Grn >= from && p.Flat.Price.Grn <= to))
                    {
                        Console.WriteLine(i.ToString());
                    }

                    break;

                case 2:
                    foreach (var i in MyAdvertisings.Where(p => p.Flat.Price.Usd >= from && p.Flat.Price.Usd <= to))
                    {
                        Console.WriteLine(i.ToString());
                    }

                    break;

                case 3:
                    foreach (var i in MyAdvertisings.Where(p => p.Flat.Price.Per_kB_metr >= from && p.Flat.Price.Per_kB_metr <= to))
                    {
                        Console.WriteLine(i.ToString());
                    }

                    break;

            }
        }
        public void Search_by_floor()
        {
            Console.WriteLine(" Введите предпочитаемый этаж ");
            int floor = int.Parse(Console.ReadLine());

            foreach (var i in MyAdvertisings.Where(p => p.Flat.Information.Floor == floor))
            {
                Console.WriteLine(i.ToString());
            }
        }
        public void Search_by_square()
        {
            Console.WriteLine(" Введите диапазон предпочитаемой площади: ");
            Console.WriteLine(" Введите  от : ");
            double from = double.Parse(Console.ReadLine());

            Console.WriteLine(" Введите  до : ");
            double to = double.Parse(Console.ReadLine());

            foreach (var i in MyAdvertisings.Where(p => p.Flat.Information.Square >= from && p.Flat.Information.Square <= to))
            {
                Console.WriteLine(i.ToString());
            }
        }
        public void Search_by_rooms()
        {
            Console.WriteLine(" Введите предпочитаемое колтчество комнат: ");
            int room = int.Parse(Console.ReadLine());

            foreach (var i in MyAdvertisings.Where(p => p.Flat.Information.RoomCount == room))
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void Search_by_city()
        {
            Console.WriteLine(" Введите предпочитаемый город: ");
            string city2 = Console.ReadLine();

            foreach (var i in MyAdvertisings.Where(p => p.Flat.Location.City == city2))
            {
                Console.WriteLine(i.ToString());
            }

        }

        public void Sortby_aA_price()
        {
            foreach (var i in MyAdvertisings.OrderBy(p => p.Flat.Price.Usd))
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void Sortby_Aa_price()
        {
            foreach (var i in MyAdvertisings.OrderByDescending(p => p.Flat.Price.Usd))
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void Sortby_aA_rooms()
        {
            foreach (var i in MyAdvertisings.OrderBy(p => p.Flat.Information.RoomCount))
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void Sortby_Aa_rooms()
        {
            foreach (var i in MyAdvertisings.OrderByDescending(p => p.Flat.Information.RoomCount))
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
