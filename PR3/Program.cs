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

            string personName = tom.name;
            int semestr = tom.semestr;
            string subject = tom.subject;
            string attestatsi = tom.attestatsi;
            string[] sub = { "Математика", "Русский язык", "Физика" };
           
           
                Console.WriteLine($"Студент: {personName}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");

            
            //--------------------------------------// 
            dima.name = "Dima";
            dima.semestr = 1;
            dima.subject = sub[3];
            dima.attestatsi = "НЕАттестован";
            dima.Print();

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

           
          
        }
       
        class Student
        {
            public string name = "Null" ;
          
            public int semestr   ;
            public string subject;
            public string attestatsi;
            public void Print()
            {
               
                    Console.WriteLine($"Студент: {name}  Симестр: {semestr} Придмет: {subject}  Аттетация: {attestatsi} ");
                
            }
        }
        
      


    }
}
