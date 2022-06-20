using System;
namespace FactoryPatternExercise
{
	public class BrusselGriffon : IDog, ILoveAllDogs
	{
		public BrusselGriffon()
		{
			Console.WriteLine("You're interested in a Brussel Griffon!");
		}

		public void IHaveADog()

		{

			Console.WriteLine("I have a Brussel Griffon!");

		}

		

		public void IDontHaveADog()

		{
			Console.WriteLine("I don't have a dog but I am wanting to adopt a Brussel Griffon!");
		}

        public void Bark()
        {
			Console.WriteLine("bark bark!");
        }
    }
}

