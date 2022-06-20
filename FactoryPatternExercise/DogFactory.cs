using System;
namespace FactoryPatternExercise
{
	static class DogFactory 
	{
		public static IDog GetDog(string dogType)
		{
			switch (dogType)
			{
                case ("great dane"):

					return new GreatDane();

				case ("golden retriever"):

					return new GoldenRetriever();

				case ("greyHound"):

					return new GreyHound();

				case ("komondor"):

					return new Komondor();

				case ("brussel griffon"):

					return new BrusselGriffon();

				default:

					return new GreatDane();

            }
		}
	}
}

