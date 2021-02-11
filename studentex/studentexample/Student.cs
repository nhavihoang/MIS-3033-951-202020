using System;
using System.Collections.Generic;
using System.Text;

namespace studentexample
{
    public class Student
    {
        private string MadeUpthingForExample;

        public int ID { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FavoriteColor { get; set; }
        /// <summary>
        /// Default/empty constructor
        /// </summary>
        public Student()
        {
            ID = 0;
            Firstname = string.Empty;
            Lastname = string.Empty;
            FavoriteColor = string.Empty;
        }

        public Student(int64 id, string first, string last, string color)
        {
            ID = id;
            Firstname = first;
            Lastname = last;
            FavoriteColor = color;
        }
        //can also add :this() next to (int id) which references and doesnt have to add the first/last/color strings
        //this.ID = ID; 
        public Student(int id)  : this()
        {
            ID = id;
            //Firstname = string.Empty;
            //Lastname = string.Empty;
            //FavoriteColor = string.Empty;
        }

        public string CreateFullName()
        {
            return $"{Lastname}, {Firstname}"; 
        }

    }
}
