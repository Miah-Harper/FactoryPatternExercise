using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            HasDog();
           
             
          
           

           // ILoveAllDogs haveDog = Dogs.GetDog(userInput);

            //haveDog.IHaveADog();

           // Console.ReadLine().ToLower();

          

            //ILoveAllDogs noDog = Dogs.GetDog(userInput);

            //noDog.IDontHaveADog();

            //Console.ReadLine().ToLower();
           
            

        }

        //private static ILoveAllDogs IHaveADog(string userInput)
       // {
            //Console.WriteLine($"I have a !");
        //}

        public static void HasDog()
        {

            Console.WriteLine("Do you have a dog?");

            var userInput = Console.ReadLine().ToLower();


            if (userInput == "yes")
            {
               BreedChoice();
                
            }
            else
            {
                HasDog();
            }
        }

        public static void BreedChoice()
        {
            Console.WriteLine("Do you have a Great Dane, Golden Retriever, GreyHound, Komondor, or Brussel Griffon?");

            var userDogChoice = Console.ReadLine().ToLower();

           

            if(userDogChoice == "no")
            {

                DogCreation();

            }

            else
            {
                IDog dogByName = DogFactory.GetDog(userDogChoice);

                dogByName.Bark();
            }
        }

        public static void DogCreation()
        {
            Console.WriteLine("What is your dogs breed?");
            var dogBreed = Console.ReadLine().ToLower();


            Console.WriteLine("How much does your dog weigh?");

            var dogWeight = Console.ReadLine().ToLower();

            Console.WriteLine("What is your dogs name?");
            var dogName = Console.ReadLine().ToLower();

            Console.WriteLine("How old is your dog?");
            var dogAge = Console.ReadLine().ToLower();

            Console.WriteLine("Is your dog purebred? Yes or no?");
            var dogPureBred = Console.ReadLine().ToLower();
            var pureBredResponse = (dogPureBred == "yes") ? true : false; //ternary

            Console.WriteLine($"Your dogs name is {dogName} and they're a {dogBreed}. {dogName} weighs {dogWeight} and is {dogAge} years old. I see it is {pureBredResponse} that {dogName} is a purebred!");
               
        }  
           
    }


}


