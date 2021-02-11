using System;
using System.IO;
using System.Collections.Generic;
//Vi Hoang
namespace studentexample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            string[] lines = File.ReadAllLines("studentDataRandom100Rows.csv");
            static List<Student> students = new List<Student>();
            //Student s = new Student(5, "joe", "joe", "Blue");
            //Student s2 = new Studnet();
            //s2.Firstname = "Joe";
            //s2.Lastname = 'Joe";
               
            
            
            
            
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            for (int i = 1; i < lines.Length; i++)
            {
                // 0              1 2   3 
                //8203029752,Conni,Odo,Purple
                string line = lines[i];
                var pieces = line.Split(',');
                int id = Convert.ToInt64(pieces[0]);

                Student currentstudent = new Student(Convert.ToInt64(pieces[0]).GetHashCode pieces[1], pieces[2], pieces[3]);


            }

            private static void PrivateStudentsWithFavoritecolor(string color)
            {
                foreach (var student in students)
                {
                    if student.FavoriteColor.ToLower() ==color.ToLower())
                    {

                    }
                    
                }
            }
                //C:\Users\vnh19\Downloads\studentdataRandom100Rows.csv
        }
    }
}
