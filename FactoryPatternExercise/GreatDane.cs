using System;
namespace FactoryPatternExercise
{
	public class GreatDane : IDog, ILoveAllDogs
	{
		public GreatDane()
		{
			Console.WriteLine("You're interested in a Great Dane!");
		}

        public void Bark()
        {
			Console.WriteLine("WOOF!");
        }

		public void IHaveADog()
		{
			Console.WriteLine("I have a Great Dane!");

		}


		public void IDontHaveADog()

		{
			Console.Write("I don't have a dog but I am wanting to adopt a Great Dane!");

		}

	}
}

