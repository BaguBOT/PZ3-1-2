using System;

namespace PR3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tom = new Student();      
            Student alex = new Student();
            Student dima = new Student();
            Student liza = new Student();

            string personName = tom.name;
            int semestr = tom.semestr;
            string subject = tom.subject;
            string attestatsi = tom.attestatsi;
            string[] sub = { "Математика", "Русский язык", "Физика" };   
            Console.WriteLine($"Студент: {personName}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
          
            tom.name = "Tom";
            tom.semestr = 3 ;
            tom.subject = sub[0];
            tom.attestatsi = "Аттестован";
            tom.Print();
       
            alex.name = "Alex";
            alex.semestr = 2;
            alex.subject = sub[1];
            alex.attestatsi = "Аттестован";
            alex.Print();
          ;
            dima.name = "Dima";
            dima.semestr = 1;
            dima.subject = sub[2];
            dima.attestatsi = "НЕ Аттестован";
            dima.Print();
           
            liza.name = "liza";
            liza.semestr = 5;
            liza.subject = sub[0];
            liza.attestatsi = "НЕ Аттестован";
            liza.Print();

        }
       
        class Student
        {
            public string name = "Null" ;
          
            public int semestr   ;
            public string subject;
            public string attestatsi;
            public void Print()
            {

                if (attestatsi == "НЕ Аттестован") Console.WriteLine($"Студент: {name}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
            }
        }
        
      


    }
}
