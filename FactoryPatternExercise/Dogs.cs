using System;
namespace FactoryPatternExercise
{
	public class Dogs
	{
		private object dog;

		public Dogs()
		{
		}

		public string Breed { get; set; }
		public int Weight { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public bool IsDogPureBred{ get; set; }
		

		/*public  static void IHaveADog()

		{
		

			Console.WriteLine($"I have a {GetType().Name}!");

		}


		public static void IDontHaveADog()

		{

			Console.WriteLine($"I don't have a dog but I am wanting to adopt a {GetType().Name}!");
		}

        internal static ILoveAllDogs GetDog(object userIput)
        {
            throw new NotImplementedException();
        */
    }

}