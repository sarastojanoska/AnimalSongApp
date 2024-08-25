using AnimalAppRldatix.Data;
using AnimalAppRldatix.Extensions;
using AnimalAppRldatix.Polymorphism;
using System.Text;

namespace AnimalAppRldatix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("The animal song implemented with data approach");
            var animalList = new List<Animal>
            {
                new Animal { Name = "Dog", Sound = "Woof" },
                new Animal { Name = "Cat", Sound = "Meow" },
                new Animal { Name = "Cow", Sound = "Moo" },
                new Animal { Name = "Pig", Sound = "Oink" },
            };

            foreach (var animal in animalList)
            {
                PrintAnimalSong(animal.Name,animal.Sound);
            }
            Console.WriteLine("The animal song implemented with polymorphism approach");
            var animalPolymorphismList = new List<AnimalPolymorphism>
            {
                new Dog(),
                new Cat(),
                new Cow(),
                new Pig(),
            };
            foreach (var ani in animalPolymorphismList)
            {
                PrintAnimalSong(ani.Name, ani.Sound);
            }
            Console.WriteLine("Let's print out the animal song for 10 animals");
            animalList.Add(new Animal { Name = "Duck", Sound = "Quack" });
            animalList.Add(new Animal { Name = "Horse", Sound = "Neigh" });
            animalList.Add(new Animal { Name = "Sheep", Sound = "Baa" });
            animalList.Add(new Animal { Name = "Snake", Sound = "Hiss" });
            animalList.Add(new Animal { Name = "Elephant", Sound = "Trumpet" });
            animalList.Add(new Animal { Name = "Lion", Sound = "Roar" });
            foreach (var animal in animalList)
            {
                PrintAnimalSong(animal.Name, animal.Sound);
            }
            Console.WriteLine("Would you like to add your own animals? Answer y/n");
            var add = Console.ReadLine();
            while (add == "y")
            {
                Console.WriteLine("Please enter animal");
                string? myanimal = Console.ReadLine();
                Console.WriteLine("Please enter sound");
                string? mysound = Console.ReadLine();

                PrintAnimalSong(myanimal, mysound);
                Console.WriteLine("Would you like to add your own animals? Answer y/n");
                add = Console.ReadLine();
            }

            Console.WriteLine("Choose language: en/mk");
            string lang = Console.ReadLine();
            foreach (var ani in animalList)
            {
                string aniName = ani.Name;
                string aniSound = ani.Sound;
                if (lang == "mk")
                {
                    aniName = aniName.AnimalNameToMacedonian();
                    aniSound = aniSound.AnimalSoundToMacedonian();
                }
                var song = lang.TranslateSong(aniName, aniSound);
                Console.WriteLine(song);
            }
        }
        
        static void PrintAnimalSong(string name, string sound)
        {
            Console.WriteLine("Old MacDonald had a farm, E I E I O");
            Console.WriteLine($"And on his farm he had a {name}, E I E I O");
            Console.WriteLine($"With a {sound} {sound} here and a {sound} {sound} there");
            Console.WriteLine($"Here a {sound}, there a {sound}, everywhere a {sound} {sound}");
            Console.WriteLine("Old MacDonald had a farm, E I E I O");
        }

    }
}
