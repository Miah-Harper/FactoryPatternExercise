using System;
namespace FactoryPatternExercise
{
	public class Komondor : IDog, ILoveAllDogs
	{
		public Komondor()
		{
			Console.WriteLine("You're interested in a Komondor!");
		}

		public void IHaveADog()
		{


			Console.WriteLine("I have a Komondor!");
		}

		public void IDontHaveADog()
		{
			Console.WriteLine("I don't have a dog but I am wanting to adopt a Komondor");

		}

        public void Bark()
        {
			Console.WriteLine("woof!");
        }
    }
}

