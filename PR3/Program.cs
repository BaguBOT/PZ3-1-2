using System;

namespace PR3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tom = new Student();
            string StudentName = tom.name;
            int Semestr = tom.semestr;
            string subject = tom.subject;
            string attestatsi = tom.attestatsi;
            tom.name = "Tom";
            tom.semestr = 1;
            tom.subject = "Математика";
            tom.attestatsi = "Аттестован";
            tom.Print();

            Student alex = new Student();
            alex.name = "Alex";
            alex.semestr = 2;
            alex.subject = "Русский язык";
            alex.attestatsi = "Аттестован";
            alex.Print();

        }
       
        class Student
        {
            public string name  ;
            public int semestr;
            public string subject;
            public string attestatsi;
                       public void Print()
            {
                Console.WriteLine($"Студент: {name}  Симестр: {semestr} Придмет {subject}  Аттетация: {attestatsi} ");
            }
        }
        
      


    }
}
