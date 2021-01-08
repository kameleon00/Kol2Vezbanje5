using System;
using System.Collections;
using System.Collections.Generic;

namespace Kol2Vezbanje5
{
    class Program
    {
        static void Main(string[] args)
        {
            //KREIRANJE ISTANCI KLASE STUDENT
            Student s1 = new Student("Marko" ,"Djokic", 75);
            Student s2 = new Student("Marko ","Mitrovic", 95);
            Student s3 = new Student("Stefan"," Majkic", 75);
            Student s4 = new Student("Filip"," Rajcetic", 35);
            Student s5 = new Student("Irina ","Lakovic", 65);

            Queue<Student> studenti = new Queue<Student>();
            // Dodavanje elemenata u red
            studenti.Enqueue(s1);
            studenti.Enqueue(s2);
            studenti.Enqueue(s3);
            studenti.Enqueue(s4);
            studenti.Enqueue(s5);
            
            //ispis nakon dodavanja
            Console.WriteLine("Ispis reda nakon dodavanja studenata:");
            Console.WriteLine("-------------------------------------------");
            foreach (var stud in studenti)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("============================================");
            Console.WriteLine();
            
            // Uklanjanje elementa iz reda
            studenti.Dequeue();
            
            //ispis nakon dodavanja
            Console.WriteLine("Ispis reda nakon brisanja studenta:");
            Console.WriteLine("-------------------------------------------");
            foreach (var stud in studenti)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("============================================");
            Console.WriteLine();
        }
    }
}