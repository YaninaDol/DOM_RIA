using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DOM_RIA
{
    class Baza
    {
        public List<Advertising> read;
       

        public Baza()
        {
            read = new List<Advertising>();
            
        }

        public List<Advertising> ReadFile()
        {
            
            if (File.Exists("Dom Ria.txt"))
            { string Baza = File.ReadAllText("Dom Ria.txt");
                string[] res = Baza.Split(";");

                for (int i = 0; i < res.Length-1 ; i++)
                {
                    Advertising adver = new Advertising();
                    string[] str = res[i].Split(':', '\n');

                    adver.ID = Convert.ToInt32(str[1]);
                    adver.Title = str[3];
                    adver.Flat.Location.City = str[5];
                    adver.Flat.Location.Region = str[7];
                    adver.Flat.Location.Street = str[9];
                    adver.Flat.Location.Number = str[11];
                    adver.Flat.Price.Grn = Convert.ToInt32(str[13]);
                    adver.Flat.Price.Usd = Convert.ToInt32(str[15]);
                    adver.Flat.Price.Per_kB_metr = Convert.ToDouble(str[17]);
                    adver.Flat.Information.RoomCount = Convert.ToInt32(str[19]);
                    adver.Flat.Information.Floor = Convert.ToInt32(str[21]);
                    adver.Flat.Information.Square = Convert.ToDouble(str[23]);
                    adver.Flat.Information.Furnished = str[25];
                    adver.Text = str[27];
                    adver.Rieltor.Surname = str[29];
                    adver.Rieltor.Name = str[31];
                    adver.Rieltor.Fathername = str[33];
                    adver.Rieltor.Phone_number = str[35];
                    adver.Rieltor.Reiting = (float)Convert.ToDouble(str[37]);

                    read.Add(adver);

                }

                return read;
            }
            else
            {
                return read;
            }
        }

        public void Baza_Show()
        {
           foreach(var item in read)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
