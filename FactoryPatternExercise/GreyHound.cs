using System;
namespace FactoryPatternExercise
{
	public class GreyHound : IDog, ILoveAllDogs
	{
		public GreyHound()
		{
			Console.WriteLine("You're interested in a Grey Hound!");
		}

        public void Bark()
        {
			Console.WriteLine("wooooof!");
        }

        public void IHaveADog()

		{

			Console.WriteLine("I have a GreyHound!");


		}


		//public void IDontHaveADog()

		//{
		//	Console.WriteLine("I don't have a dog but I am wanting to adopt a GreyHound!");
		//}

       // public void Bark()
        //{
		//Console.WriteLine("I'm a nervous pup so I don't bark too much!");
    }
}


