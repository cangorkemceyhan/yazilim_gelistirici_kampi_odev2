using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim_gelistirici_kampi_odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veriTipleri();
            //singleLineİf();
            //sartBloklari();
            //switchCase();
            //sayiAraliginiBulma();
            //tekBoyutDizi();
            //cokBoyutDizi();
            //forDongu();
            //whileDongu();
            //doWhileDongu();
            //forEachDongu();
            //stringMetotlari();



            /*
            Add();
            var result = Add2();
            int number1 = 20;
            int number2 = 100;
            var toplam2 = Add3(ref number1,ref number2);
            Console.WriteLine(toplam2);
            Console.WriteLine(number1);
            Console.WriteLine(carp(3, 6));
            Console.WriteLine(carp(3,6,9));
            Console.WriteLine(Add4(1,2,3,4,5,6));
            */



            /*
            if (asalSayi(5))
            {
                Console.WriteLine("Asal");
            }
            else
            {
                Console.WriteLine("Asal degil");
            }
            */



            Console.ReadKey();
        }
        private static void veriTipleri()
        {
            Console.WriteLine("Hello World!");
            double number1 = 10.4;
            decimal number2 = 10;
            char character = 'A';
            bool karar=false;
            byte number3 = 255;
            short number4 = 255;
            short number5 = 32767;
            int number6 = 2147483647;
            long number7 = 9223372036854775807;
            var number8 = 10;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine(number7);
            Console.WriteLine(number8);
            Console.WriteLine((int)character);
            Console.WriteLine((int)Days.Wednesday);
        }
        private static void singleLineİf()
        {
            var number = 11;
            Console.WriteLine(number == 10 ? "Sayi 10" : "Sayi 10 degil");
        }
        private static void sartBloklari()
        {
            var number = 11;
            if(number==10)
            {
                Console.WriteLine("Sayi 10");
            }else if (number == 20)
            {
                Console.WriteLine("Sayi 20");
            }
            else
            {
                Console.WriteLine("Sayi 10 veya 20 degil");
            }
        }
        private static void switchCase()
        {
            var number = 20;
            switch (number)
            {
                case 10: Console.WriteLine("Sayi 10");break;
                case 20: Console.WriteLine("Sayi 20");break;
                default: Console.WriteLine("Sayi 10 veya 20 degil");break;
            }
        }
        private static void sayiAraliginiBulma()
        {
            var number = 25;
            if (number > 0 && number <= 100)
            {
                Console.WriteLine("Sayi 0-100 araliginda");
            }else if(number>100 && number <= 200)
            {
                Console.WriteLine("Sayi 100-200 araliginda");
            }else if(number>200 || number < 0)
            {
                Console.WriteLine("Sayi 0'dan kucuk veya 200'den buyuk");
            }
        }
        static void Add()
        {
            Console.WriteLine("Eklendi!");
        }
        static int Add2(int number1=20,int number2 = 30)
        {
            var toplam=number1+ number2;
            return toplam;
        }
        static int Add3(ref int number1,ref int number2)
        {
            number1 = 30;
            return number1+ number2;
        }
        static int carp(int number1,int number2)
        {
            return number1*number2;
        }
        static int carp(int number1,int number2,int number3)
        {
            return number1*number2*number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
        private static void tekBoyutDizi()
        {
            string[] students2 = { "Can", "Busra", "Gorkem" };
            //students2[3] = "Ceyhan";
            foreach(var student in students2) 
            {
                Console.WriteLine(student);
            }
        }
        private static void cokBoyutDizi()
        {
            string[,] bolgeler = new string[5, 3]
            {
            {"İstanbul","Kocaeli","Bursa" },
            {"Ankara","Kırıkkale","Çankırı" },
            {"Antalya","Adana","Mersin" },
            {"İzmir","Muğla","Manisa" },
            {"Mardin","Şırnak","Diyarbakır" }
            };
            for(int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j=0; j<=bolgeler.GetUpperBound(1);j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }
                Console.WriteLine("**************");
            }
        }
        private static void forDongu()
        {
            for(int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Program bitti");
        }
        private static void whileDongu()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
        private static void doWhileDongu()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }
        private static void forEachDongu()
        {
            string[] ogrenciler = new string[3] { "Can", "Gorkem", "Ceyhan" };
            foreach(var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }
        }
        private static bool asalSayi(int number)
        {
            bool sonuc = true;
            for(int i = 2; i < number - 1; i++)
            {
                if(number%i==0)
                {
                    sonuc=false;
                    i = number;
                }
            }
            return sonuc;
        }
        private static void stringMetotlari()
        {
            /*
            string sehir1 = "Ankara";
            //Console.WriteLine(sehir1[0]);
            foreach(var item in sehir1)
            {
                Console.WriteLine(item);
            }
            string sehir2 = "İstanbul";
            Console.WriteLine(String.Format("{0},{1}",sehir1,sehir2));
            */


            string metin = "My name is Can Gorkem Ceyhan";
            var sonuc = metin.Length;
            var sonuc1 = metin.Clone();
            bool sonuc2=metin.EndsWith("n");
            bool sonuc3=metin.StartsWith("m");
            var sonuc4 = metin.IndexOf("name");
            var sonuc5 = metin.Insert(0, "Hi, ");
            var sonuc6 = metin.Substring(3, 4);
            var sonuc7 = metin.ToLower();
            var sonuc8=metin.ToUpper();
            var sonuc9 = metin.Replace(" ", "-");
            //var sonuc10 = metin.Remove(2, 4);
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.WriteLine(sonuc4);
            Console.WriteLine(sonuc5);
            Console.WriteLine(sonuc6);
            Console.WriteLine(sonuc7);
            Console.WriteLine(sonuc8);
            Console.WriteLine(sonuc9);
        }
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}
