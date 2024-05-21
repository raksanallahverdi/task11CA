using System;
namespace Task15
{
	public class Student
	{
		private Grade[] grades;
        public Grade[] Grades { get=>grades;}
		public Student()
		{
            grades = new Grade[0];
        }

		public void Add(Grade grade)
		{
			Array.Resize(ref grades, grades.Length + 1);
			grades[grades.Length - 1] = grade;

		}

		public void GetAll()
		{
			foreach(var grade in grades)
			{
				grade.GetDetails();
			}
		}
    }
}

