
using System;
namespace Task15
{


    public static class Program
    {
        public static void Main()
        {
            Student Raksana = new Student();
            Grade good = new Grade("English", Degree.A);
            Grade well = new Grade("Math", Degree.B);
            Raksana.Add(well);
            Raksana.Add(good);
            Raksana.GetAll();
            Console.ReadLine();




        }
    }

}

