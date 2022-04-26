using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Advertising
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Flat Flat { get; set; }
        public string Text { get; set; }
        public Rieltor Rieltor { get; set; }

        public Advertising(string title, Flat flat, string text, Rieltor rieltor)
        {
            
            Title = title;
            Flat = flat;
            Text = text;
            Rieltor = rieltor;
        }

        public Advertising() : this( string.Empty, new Flat(), string.Empty, new Rieltor())
        {
        }

        public override string ToString()
        {
            return string.Format("ID: {18}\nЗаголовок : {0}\n Город: {1}\nРайон: {2}\nУлица: {3}\nНомер дома: {4}\nЦена в грн:{5}\nЦена в usd:{6}\nЦена за кв.м:{7}\nКоличество комнат: {8}\nЭтаж: {9}\nОбщая площадь: {10}\nНаличие мебели: {11}\nДоп.информация: {17}\nДанные риелтора - Фамилия: {12}\nИмя: {13}\nОтчество: {14}\nТелефон: {15}\nРейтинг: {16}\n ;"
            , this.Title, this.Flat.Location.City, this.Flat.Location.Region, this.Flat.Location.Street, this.Flat.Location.Number, this.Flat.Price.Grn, this.Flat.Price.Usd, this.Flat.Price.Per_kB_metr, this.Flat.Information.RoomCount, this.Flat.Information.Floor, this.Flat.Information.Square, this.Flat.Information.Furnished, this.Rieltor.Surname, this.Rieltor.Name, this.Rieltor.Fathername, this.Rieltor.Phone_number, this.Rieltor.Reiting, this.Text,this.ID);
        }
    }
}
