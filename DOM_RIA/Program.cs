using System;

namespace DOM_RIA
{
    class Program
    {
        static void Main(string[] args)
        {

            //Meneger meneger = new Meneger();
            //meneger.Baza_Show();
            //Console.WriteLine("num--" + meneger.Site_Dim_ria.Count); 
            // meneger.Add();
            // Console.WriteLine(" num---"+ meneger.Site_Dim_ria.Count);
            // meneger.Baza_Show();
            // meneger.Save_file();


            Client client = new Client("Login", "Parol", "  Днепр");
          foreach(var item in client.MyAdvertisings)
            {
                Console.WriteLine(item.Flat.Location.City+ "\n");
            }


           // client.Baza_Show();
            client.Search();
        }
    }
}
