using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РЦ270323
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Создою персонажа Даниил с классом Человек
			Human human = new Human();
			Character Daniel = new Character("Daniel" ,human);

			// Вывожу характеристики на экран
			Console.WriteLine(Daniel);

			// Радуюсь
			Console.ReadKey(true);
		}
	}
}
