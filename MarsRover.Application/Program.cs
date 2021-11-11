using System;
using MarsRover.Application.Library;

namespace MarsRover.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plato x Konum Sınırını Giriniz: ");
            int xkonum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plato y Konum Sınırını Giriniz: ");
            int ykonum = Convert.ToInt32(Console.ReadLine());
            Plato plato = new Plato(xkonum, ykonum);


            Console.WriteLine("Kaç Gezici Var ?");
            int roverSay = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < roverSay; i++)
            {
                Console.WriteLine("X Konumunu Giriniz :");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Y Konumunu Giriniz :");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yönünü Giriniz (N,E,W,S) :");
                char position = Convert.ToChar(Convert.ToString(Console.ReadLine()).ToUpper());
                plato.RoverAdd(x, y, position);
            }

            int RoverSay = plato.RoverSay();

            for (int i = 0; i < RoverSay; i++)

            {

                bool durum = true;
                string gezicikonum = "";

                while (durum)
                {
                    Console.WriteLine("Gezici Hareketlerine Devam Etmek İstiyor musunuz ? (E/H)");
                    string devam = Console.ReadLine();
                    bool cevap = devam == "E" ? true : false;
                    if (cevap)
                    {
                        Console.WriteLine("Hareketlerden Move(M)-Right(R)-Left(L) Birini Seçebilirsiniz.");
                        char hareket = Convert.ToChar(Console.ReadLine());
                        gezicikonum = plato.hareket(i, hareket);
                        Console.WriteLine(gezicikonum);

                    }
                    else
                    {
                        Console.WriteLine("Gezicinin mevcut konumu " + gezicikonum);
                        Console.WriteLine("Bir gezicinin işlemleri tamamlandı.");
                        durum = false;
                        break;
                    }
                }


            }

            Console.WriteLine("Başka bir gezici kalmadı işlem bitti.");

            Console.ReadLine();

        }
    }
}
