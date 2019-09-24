using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	
	class Student
	{
		public int age { get; set; }
		public string haircolor { get; set; }
		public string name { get; set; }
		public string sex { get; set; }

		public Student()
		{
			string a;
			int ai;
			do
			{
				Console.WriteLine("Введите возраст студента");
				a = Console.ReadLine();
			} while (!int.TryParse(a, out ai));
			age = ai;
			Console.WriteLine("Введите цвет волос студента");
			haircolor = Console.ReadLine();
			Console.WriteLine("Введите имя студента");
			name = Console.ReadLine();
			do
			{
				Console.WriteLine("Введите пол студента (М или Ж)");
				sex = Console.ReadLine().ToLower();
			} while (!(sex == "м" || sex == "ж"));
		}
		public void MashUp(Student x)
		{
			age += x.age;
			name = name.Substring(0, name.Length / 2) + x.name.Substring(x.name.Length / 2 + 1);
			haircolor = haircolor.Substring(0, haircolor.Length / 2) + x.haircolor.Substring(x.haircolor.Length / 2 + 1);
			if ((sex == "м" && x.sex == "ж") || (sex == "ж" && x.sex == "м"))
			{
				sex = "Нормал";

			}
			else if (sex == "м" && x.sex == "м")
			{
				sex = "Милос";
			}
			else if (sex == "ж" && x.sex == "ж")
			{
				sex = "Стрелочка";
			}

		}

		
	}
}
