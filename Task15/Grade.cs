using System;
namespace Task15
{
	public class Grade
	{
		public string Subject { get; set; }
		public Degree Degree { get; set; }
		
		public Grade(string subject, Degree degree)
		{
			Subject = subject;
			Degree = degree;
		}
		public void GetDetails()
		{
			Console.WriteLine($"{Subject} {Degree}");
		}

		
	}
}

