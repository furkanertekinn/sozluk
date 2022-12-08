using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable sozlukvertabani = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz değeri giriniz : ");
                Console.Write("ENG : ");
                string eng = Console.ReadLine();

                bool kontrol = sozlukvertabani.ContainsKey(sozlukvertabani);

                if (kontrol)
                {
                    Console.WriteLine("Eklemek istediğinzi değer {0} sözlük içerisinde bulunmaktadır. {1} değerin türkçe karşılığıdır. ", eng, sozlukvertabani[eng].ToString());
                }

                else
                {
                    Console.WriteLine("{0} ingilizce değerinin türkçe karşılığınız yazınız ",eng);
                    string tr= Console.ReadLine();
                    sozlukvertabani.Add(eng, tr);
                    Console.WriteLine("Değer ekleme işlemi başarılı");
                }
                Console.WriteLine("Yeni değer eklemek istiyor musunuz ? (E/H)");

            } while (Console.ReadLine().ToUpper()!= "H");

            foreach (var item in sozlukvertabani.Keys)
            {
                Console.WriteLine("ENG : {0} <=> TR : {1}",item, sozlukvertabani[item]);
            }
            Console.ReadLine();
        }
    }
}
