using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DOM_RIA
{
    class Meneger:Baza
    {
        public List<Advertising> Site_Dim_ria { get; set; }

        public Meneger():base()
        {
            Site_Dim_ria = base.ReadFile();
           
        }

        public void Add()
        {
            Advertising advertising = new Advertising();

            if(Site_Dim_ria.Count>0)
            {
                advertising.ID = Site_Dim_ria[Site_Dim_ria.Count - 1].ID + 1;
            }
            else
            {
                advertising.ID = 0;
            }

            Console.WriteLine(" Введите заголовок обьявления : ");
            advertising.Title = System.Console.ReadLine();

            Console.WriteLine(" Введите местораположение обьекта\n Город: ");
            advertising.Flat.Location.City = System.Console.ReadLine();
            Console.WriteLine(" Область : ");
            advertising.Flat.Location.Region = System.Console.ReadLine();
            Console.WriteLine(" Улица : ");
            advertising.Flat.Location.Street = System.Console.ReadLine();
            Console.WriteLine(" Номер дома/квартиры : ");
            advertising.Flat.Location.Number = System.Console.ReadLine();

            Console.WriteLine(" Количество комнат: ");
            advertising.Flat.Information.RoomCount = int.Parse(System.Console.ReadLine());
            Console.WriteLine(" Этаж: ");
            advertising.Flat.Information.Floor = int.Parse(System.Console.ReadLine());
            Console.WriteLine(" Общая площадь: ");
            advertising.Flat.Information.Square = double.Parse(System.Console.ReadLine());
            Console.WriteLine(" Наличие мебели: ");
            advertising.Flat.Information.Furnished = System.Console.ReadLine();

            Console.WriteLine(" Введите цену в долларах: ");
            advertising.Flat.Price.Usd = int.Parse(System.Console.ReadLine());
            advertising.Flat.Price.Grn = advertising.Flat.Price.Usd * (int)29.90;
            advertising.Flat.Price.Per_kB_metr = advertising.Flat.Price.Usd / advertising.Flat.Information.Square;

            Console.WriteLine(" Введите текст обьявления: ");
            advertising.Text = System.Console.ReadLine();

            Console.WriteLine(" Введите информацию о риелторе:\nФамилия: ");
            advertising.Rieltor.Surname = System.Console.ReadLine();
            Console.WriteLine(" Имя ");
            advertising.Rieltor.Name = System.Console.ReadLine();
            Console.WriteLine(" Отчество ");
            advertising.Rieltor.Fathername = System.Console.ReadLine();
            Console.WriteLine(" Контактный номер: ");
            advertising.Rieltor.Phone_number = System.Console.ReadLine();
            Console.WriteLine(" Рейтинг: ");
            advertising.Rieltor.Reiting = float.Parse(System.Console.ReadLine());


            Site_Dim_ria.Add(advertising);
            Console.Clear();

            Console.WriteLine(" Обьявление успешно добавлено! ");
            System.Console.ReadLine();
        }

        public void Delete()
        {
            Console.WriteLine(" Введите id обьявления, которое хотите удалить : ");

            int to_delete = int.Parse(System.Console.ReadLine());

            if(to_delete<=Site_Dim_ria.Count-1)
            {
                this.Archive(Site_Dim_ria[to_delete]);
                Site_Dim_ria.Remove(Site_Dim_ria[to_delete]);
                Console.Clear();
                Console.WriteLine(" Обьявление успешно удалено и перемещено в архив ");
                System.Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine(" Нет обьявления с таким номером! ");
            }
        }

        public void Archive(Advertising todelete)
        {
            string str = todelete.ToString();
            File.AppendAllText("Arhive.txt", str);
        }

        public void ShowArchive()
        {
            string arhive = File.ReadAllText("Arhive.txt");
            Console.WriteLine(arhive);
        }

        public void Save_file()
        {
            File.Delete("Dom Ria.txt");
            foreach(var item in Site_Dim_ria)
            {

                File.AppendAllText("Dom Ria.txt", item.ToString());
            }
        }
        
        ~Meneger()
        {
            Save_file();
        }
        
    }

   
}
