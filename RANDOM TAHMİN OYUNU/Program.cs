using System;

namespace RANDOM_TAHMİN_OYUNU
{
    class Program
    {
        static void Main(string[] args)
        { 
            Random r = new Random();
            int rs = r.Next(0, 500);
            int a = 0;
            

            Console.WriteLine("0-500 arası bir sayı tuttum bakalım kaç hamlede bileceksin");
           
            while (true)
            {
                Console.WriteLine("TAHMİNİN NEDİR");
                int gs = Convert.ToInt32(Console.ReadLine());
                if (gs == rs) break;
                else if (gs < rs) Console.WriteLine("DAHA BÜYÜK SAYI GİRMELİSİN"); 
                else if (gs > rs) Console.WriteLine("DAHA KÜÇÜK SAYI GİRMELİSİN");
                a++;






            }
            Console.WriteLine("TEBRİKLER HARİKASIN");
            Console.WriteLine("{0} HAMLEDE TAHMİNDE BİLDİN ",a);
            
            Console.ReadKey();



            /*

             int[] dz = new int[10];
             Random r = new Random();
             int a = 0;

             while(a<10)
             {
                 int tut = r.Next(10, 100);
                 Console.Write(tut+"");
                 if(tut%2==1)
                 {
                     dz[a] = tut;
                     a++;
                 }
                 Console.WriteLine();
                 for(int i =0;i<dz.Length;i++)
                     Console.WriteLine(dz[i] + "");
             }
            //Kullanıcının girmiş olduğu sayının dizide olup olmadığını bulan, varsa kaç adet bulunduğunu ekranda gösteren dizi örneği:
/*
            int[] dizi = { 10, 20, 30, 40, 50, 10, 20, 52, 80, 90 };
            int adet = 0;
            Console.WriteLine("Sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < dizi.Length; i++)
            {
                if (n == dizi[i])
                {
                    adet++;
                }
            }
                if (adet == 0)
                {
                    Console.WriteLine("Sayı dizi içinde bulunamadı...");
                }
                else
                {
                    Console.WriteLine("Bu sayı dizide {0} adet var", adet);
                }
                Console.ReadLine();*/


         






        }
        }
    }


        
    
