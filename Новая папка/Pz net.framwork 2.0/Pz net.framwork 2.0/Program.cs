using System;
using System.Collections.Generic;
using System.Text;
using static Pz_net.framwork_2._0.Program.attestatsii;

namespace Pz_net.framwork_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudenDifferentiated tom = new StudenDifferentiated("tom",3, "Аттестован",5,true);
            StudenDifferentiated alex = new StudenDifferentiated("Alex",2, "Аттестован",4,true);
            StudenDifferentiated dima = new StudenDifferentiated("Dima",5,"НЕ Аттестован", 3,true);
            StudenDifferentiated liza = new StudenDifferentiated("liza",5,"НЕ Аттестован",4, false);
          //  string[] sub = new string[3] { "Математика","Русский язык","ОБЖ"};
          //   tom = sub;
                tom.Zatet = true;
                alex.Zatet = true; 
               /////////////////////////////////////////////////
                dima.Otsenka = 2;
                dima.Zatet = false;
                ////////////////////////////////////////////
                liza.Otsenka = 3;
                liza.Zatet = true;
            
            tom.Show();
            liza.Show();
            dima.Show();
            alex.Show();

            tom.otse();
            liza.otse();
            dima.otse();
            alex.otse();
        }

       
        public class attestatsii
        {
            public attestatsii(string name, int semestr, string attestatsi)
            {
                Name = name;
                Semestr = semestr;
                Attestatsi = attestatsi;
            }
           
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
                set
                {
                    if (value < 1)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    else
                    {
                        if (value > 8)
                        {
                            Console.WriteLine("Ошибка");
                        }
                        _semestr = value;
                    }
                }
            }
            
            //public string[] Subject;
            private string _attestatsi = "Null";
            public string Attestatsi
            {
                get { return _attestatsi; }
                set { _attestatsi = value; }
            }
           
            public virtual string Show()
            {
                if (Attestatsi == "НЕ Аттестован")
                {
                    Console.WriteLine($" Имя: {_name} симестор: {_semestr} атестация: {_attestatsi} ");
                    return _name + " " + _semestr + " " + _attestatsi + " "; }
                return _name;
            }

            public attestatsii()
            {

            }
            public class StudenDifferentiated : attestatsii
            {
                private bool _zatet;
                public bool Zatet
                {
                    get { return _zatet; }
                    set { _zatet = value; }
                }

                private int _otsenka;

                public int Otsenka
                {
                    get { return _otsenka; }
                    set { _otsenka = value; }
                }

                public StudenDifferentiated(string name, int semestr, string attestatsi, int otsenka, bool zatet)
                {
                  
                    Semestr = semestr;
                    Attestatsi = attestatsi;
                    Name =name;
                     Otsenka = otsenka;
                    Zatet = zatet;
                }
                public virtual string otse()
                {
                    if (Zatet == true)
                    {        
                        Console.WriteLine($" Имя: {Name} симестор: {Otsenka} атестация: {Zatet} ");
                       
                        return Name + " " + Otsenka + " " + Zatet;
                        
                    }
                    return Name;
                }
            }
        }
    }
}
