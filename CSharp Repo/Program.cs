using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_CSharp_Redo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter minimum bound : ");
			string minInput = Console.ReadLine();
			Console.Write("Enter maximum bound : ");
			string maxInput = Console.ReadLine();

			int min = Convert.ToInt32(minInput);
			int max = Convert.ToInt32(maxInput);

			Random rnd = new Random();
			int rndNum = rnd.Next(min, max);

			Console.WriteLine();
			Console.WriteLine("Guess a number thorugh {0} and {1}", min, max);

			int tries = 0;
			string guessInput = Console.ReadLine();
			int guessNum = Convert.ToInt32(guessInput);

			tries++;

			if (guessNum == rndNum)
			{
				Console.WriteLine("Correct! You took {0} tries!\n", tries);

				Console.WriteLine("Press any key to exit.");
				Console.ReadKey();
			}

			while (guessNum != rndNum)
			{
				if (guessNum < rndNum)
				{
					Console.WriteLine("Too Low!");
				}
				if (guessNum > rndNum)
				{
					Console.WriteLine("Too High!");
				}

				guessInput = Console.ReadLine();
				guessNum = Convert.ToInt32(guessInput);

				tries++;

				if (guessNum == rndNum)
				{
					Console.WriteLine("Correct! You took {0} tries!\n", tries);

					Console.WriteLine("Press any key to exit.");
					Console.ReadKey();
				}
			}
		}
	}
}
