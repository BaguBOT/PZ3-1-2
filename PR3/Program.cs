using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
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
            string personName = tom.name;
            int semestr = tom.semestr;
            string subject = tom.subject;
            string attestatsi = tom.attestatsi;
            string[] sub = { "Математика", "Русский язык", "Физика" };
            Console.WriteLine($"Студент: {personName}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
            NOattis();
            Yesattis();
            void Yesattis()
            {
                tom.name = "Tom";
                tom.semestr = 3;
                tom.subject = sub[0];
                tom.attestatsi = "Аттестован";
                tom.otsenka = 5;
                tom.Zatet = true;
                tom.Print();
                tom.otse();

                alex.name = "Alex";
                alex.semestr = 2;
                alex.subject = sub[1];
                alex.attestatsi = "Аттестован";
                alex.otsenka = 4;
                alex.Zatet = true;
                alex.Print();
                alex.otse();
            }
            void NOattis()
            {
                dima.name = "Dima";
                dima.semestr = 5;
                dima.subject = sub[2];
                dima.attestatsi = "НЕ Аттестован";
                dima.otsenka = 2;
               dima.Zatet = false;
                dima.Print();
                dima.otse();

                liza.name = "liza";
                liza.semestr = 5;
                liza.subject = sub[0];
                liza.attestatsi = "НЕ Аттестован";
                liza.otsenka = 3;
                liza.Zatet = true;
                liza.Print();
                liza.otse();
            }
            //if (attestatsi == "НЕ Аттестован")
            //{
            //    liza.otse()
            //}

           

        }

        class attestatsii
        {
            public string name = "Null";
            public int semestr = 1 ;
            public string subject = "Null";
            public string attestatsi = "Null";
        
            public void Print()
            {
                    if(attestatsi == "НЕ Аттестован")
                        Console.WriteLine($"Студент: {name}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
                    
            }
        }
        class StudenDifferentiated : attestatsii
        {
            public bool Zatet;
            public int otsenka;
            public void otse()
            {
                if(Zatet == true){
                    Console.WriteLine($"Студент: {name} Зачет: {Zatet} Оценка за курсовую: {otsenka}");
                }
               
            }
        }
    }
}
