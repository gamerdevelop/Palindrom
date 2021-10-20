using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayisalDeger;
            ConsoleKeyInfo tus = new ConsoleKeyInfo();
            baslangic1:
            Console.Write("Bir sayı yada kelime giriniz : ");
            baslangic2:
            string girdi = Console.ReadLine();
            int falseDeger = 0;
            int trueDeger = 0;
            int kontrol = girdi.Length;

            for (int i = girdi.Length - 1; i >= 0; i--)
            {               
                bool deneme = int.TryParse(Convert.ToString(girdi[i]), out sayisalDeger);
                if (deneme == false)
                {
                    falseDeger += 1;                  
                }
                else
                {
                    trueDeger += 1; 
                }     
            }
                if (falseDeger != kontrol)
                {
                    if (trueDeger != kontrol)
                    {
                    Console.WriteLine("Lütfen sadece sayı yada kelime giriniz!");
                    goto baslangic2;
                    }
                }
            bool sayisalMi = int.TryParse(girdi, out sayisalDeger);          
            string terscevir="";
            if (sayisalMi == true)
            {
                for (int i = girdi.Length - 1; i >= 0; i--)
                {
                    terscevir += girdi[i];
                }
                if (girdi == terscevir)
                {
                    Console.WriteLine("==> " + girdi + "  sayısı palindromdur!");
                    Console.WriteLine("D=Devam ESC=Çıkış");
                    tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else if (tus.Key == ConsoleKey.D)
                    {
                        goto baslangic1;
                    }
                    else 
                    {
                        do
                        {
                            Console.WriteLine("D=Devam ESC=Çıkış");
                            tus = Console.ReadKey(true);
                        }
                        while (tus.Key != ConsoleKey.Escape && tus.Key != ConsoleKey.D);
                        if(tus.Key == ConsoleKey.D)
                        {
                            goto baslangic1;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("==> " + girdi + "  sayısı palindrom değildir!");
                    Console.WriteLine("D=Devam ESC=Çıkış");
                    tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else if (tus.Key == ConsoleKey.D)
                    {
                        goto baslangic1;
                    }
                    else 
                    {
                        do
                        {
                            Console.WriteLine("D=Devam ESC=Çıkış");
                            tus = Console.ReadKey(true);
                        }
                        while (tus.Key != ConsoleKey.Escape && tus.Key != ConsoleKey.D);
                        if (tus.Key == ConsoleKey.D)
                        {
                            goto baslangic1;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
            else
            {
                for (int i = girdi.Length - 1; i >= 0; i--)
                {
                    terscevir += girdi[i];
                }
                if (girdi == terscevir)
                { 
                    Console.WriteLine("==> " + girdi + "  kelimesi palindromdur!");
                    Console.WriteLine("D=Devam ESC=Çıkış");
                    tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else if (tus.Key == ConsoleKey.D)
                    {
                        goto baslangic1;
                    }
                    else 
                    {
                        do
                        {
                            Console.WriteLine("D=Devam ESC=Çıkış");
                            tus = Console.ReadKey(true);
                        }
                        while (tus.Key != ConsoleKey.Escape && tus.Key != ConsoleKey.D);
                        if (tus.Key == ConsoleKey.D)
                        {
                            goto baslangic1;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("==> " + girdi + "  kelimesi palindrom değildir!");
                    Console.WriteLine("D=Devam ESC=Çıkış");
                    tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else if (tus.Key == ConsoleKey.D)
                    {
                        goto baslangic1;
                    }
                    else 
                    {
                        do
                        {
                            Console.WriteLine("D=Devam ESC=Çıkış");
                            tus = Console.ReadKey(true);
                        }
                        while (tus.Key != ConsoleKey.Escape && tus.Key != ConsoleKey.D);
                        if (tus.Key == ConsoleKey.D)
                        {
                            goto baslangic1;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                
            }

            
        }
        
    }
}

