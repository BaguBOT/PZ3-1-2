using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace PR3
{
    class Program
    {
        static void Main(string[] args)
        {
            StudenDifferentiated tom = new StudenDifferentiated();
            StudenDifferentiated alex = new StudenDifferentiated();
            StudenDifferentiated dima = new StudenDifferentiated();
            StudenDifferentiated liza = new StudenDifferentiated();

           string y = Console.ReadLine();
            if(y == "y")
            {
             bool bol = true; 
            }

            string personName = tom.name;
            int semestr = tom.semestr;
            string subject = tom.subject;
            string attestatsi = tom.attestatsi;
            string[] sub = { "Математика", "Русский язык", "Физика" };
            Console.WriteLine($"Студент: {personName}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
            List();

            void List()
            {
                tom.name = "Tom";
                tom.semestr = 3;
                tom.subject = sub[0];
                tom.attestatsi = "Аттестован";
                tom.otsenka = 5;
                tom.Print();
                tom.otse();

                alex.name = "Alex";
                alex.semestr = 2;
                alex.subject = sub[1];
                alex.attestatsi = "Аттестован";
                alex.otsenka = 4;
                alex.Print();
                alex.otse();

                dima.name = "Dima";
                dima.semestr = 1;
                dima.subject = sub[2];
                dima.attestatsi = "НЕ Аттестован";
                dima.otsenka = 2;
                dima.Print();
                dima.otse();
               
                
                liza.name = "liza";
                liza.semestr = 5;
                liza.subject = sub[0];
                liza.attestatsi = "НЕ Аттестован";
                liza.otsenka = 3;
                liza.Print();
                liza.otse();
            }


        }

        class attestatsii
        {
            public string name = "Null";
            public int semestr = 1 ;
            public string subject = "Null";
            public string attestatsi = "Null";
            public bool bol;
            public void Print()
            {
                if (bol == true)
                {
                    if (attestatsi == "НЕ Аттестован")
                    {
                        Console.WriteLine($"Студент: {name}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
                    }
                }
                else
                {
                    Console.WriteLine($"Студент: {name}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
                }
            }
            public void show()
            {
                // Console.WriteLine(name.show());


            }

        }
        class StudenDifferentiated : attestatsii
        {
            public int otsenka;
            public void otse()
            {
                Console.WriteLine($"Студент: {name} Оценка за курсовую: {otsenka}");
            }




        }
    }
}
