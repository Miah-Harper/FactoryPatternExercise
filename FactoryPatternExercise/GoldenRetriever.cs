using System;
namespace FactoryPatternExercise
{
	public class GoldenRetriever : IDog, ILoveAllDogs
	{
		public GoldenRetriever()
		{
			Console.WriteLine("You're interested in a Golden Retriever!");
		}

        void IDog.Bark()
        {
			Console.WriteLine("Ruff Ruff!");
        }


	}
}

