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
            string personName = tom.Name;
            int semestr = tom.Semestr;
            string subject = tom.Subject[4]; 
            
            string attestatsi = tom.Attestatsi;
            //{ "Математика", "Русский язык", "Физика","ОБЖ"} ;
            Console.WriteLine($"Студент: {personName}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
            NOattis();
            YESattis();
            void YESattis()
            {
                tom.Name = "Tom";
                tom.Semestr = 3;
                tom.Subject = sub[0];
                tom.Attestatsi = "Аттестован";
                tom.Otsenka = 5;
                tom.Zatet = true;
                tom.Print();
                tom.otse();
                ////////////////////////////////////////////////
                alex.Name = "Alex";
                alex.Semestr = 2;
                alex.Subject = sub[1];
                alex.Attestatsi = "Аттестован";
                alex.Otsenka = 4;
                alex.Zatet = true;
                alex.Print();
                alex.otse();
            }
            void NOattis()
            {
                dima.Name = "Dima";
                dima.Semestr =5;
                dima.Subject = sub[2];
                dima.Attestatsi = "НЕ Аттестован";
                dima.Otsenka = 2;
                dima.Zatet = false;
                dima.Print();
                dima.otse();
                ////////////////////////////////////////////
                liza.Name = "liza";
                liza.Semestr = 5;
                liza.Subject = sub[0];
                liza.Attestatsi = "НЕ Аттестован";
                liza.Otsenka = 3;
                liza.Zatet = true;
                liza.Print();
                liza.otse();
            }
        }
        class attestatsii
        {
            private string _name = "Null";
            public string Name
            {
                get { return _name; }
                set { _name = value; }  
            }
            private int _semestr = 1;
            public int Semestr
            {
                get { return _semestr; }
                set {
                   
                    _semestr = value; }
            }
            private string[] _subject;
            public string[] Subject
            {
                get { return _subject; }    
                set { _subject = value; }
            }
            private string _attestatsi = "Null";
            public string Attestatsi
            {
                get { return _attestatsi; }
                set { _attestatsi = value; }
            }
            public void Print()
            {
                if (Attestatsi == "НЕ Аттестован")
                 Console.WriteLine($"Студент: {Name}  Симестр: {Semestr} Придмет: {Subject}  Аттетация: {Attestatsi} ");
           
            }
        }
        class StudenDifferentiated : attestatsii
        {

            public bool Zatet;

            private int _otsenka;
            public int Otsenka
            {
                get { return _otsenka; }
                set { _otsenka = value; }
            }
            public void otse()
            {
                if (Zatet == true)
                {
                    Console.WriteLine($"Студент: {Name} Зачет: {Zatet} Оценка за курсовую: {Otsenka}");
                }
            }
        }
    }
}
