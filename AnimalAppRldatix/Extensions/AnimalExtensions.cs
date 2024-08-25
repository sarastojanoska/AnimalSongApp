using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAppRldatix.Extensions
{
    public static class AnimalExtensions
    {
        public static string TranslateSong(this string lang, string animalName, string animalSound)
        {
            var translatedSong = "";
            if (lang == "en")
            {
                translatedSong = $@"Old MacDonald had a farm, E I E I O" +
                    "And on his farm, he had a {{animal}} E I E I O.\n" +
                    "With a {{sound}} {{sound}} here and a {{sound}} {{sound}} there\n" +
                    "Here a {{sound}}, there a {{sound}}, everywhere a {{sound}} {{sound}}\n" +
                    "Old MacDonald had a farm, E I E I O\n";

            }
            else if (lang == "mk")
            {
                translatedSong = $@"Стар Макдоналд имаше фарма, Е И Е И О" +
                    "И на неговата фарма, имаше {{animal}} Е И Е И О\n" +
                    "Со {{sound}} {{sound}} тука и {{sound}} {{sound}} таму,\n" +
                    "Тука {{sound}}, таму {{sound}}, насекаде {{sound}} {{sound}}\n" +
                    "Стар Макдоналд имаше фарма, Е И Е И О\n";
            }
            translatedSong = translatedSong.Replace("{{animal}}", animalName).Replace("{{sound}}", animalSound);
            return translatedSong;
        }
        public static string AnimalNameToMacedonian(this string name)
        {
            return name switch
            {
                "Cow" => "Крава",
                "Duck" => "Патка",
                "Pig" => "Свиња",
                "Horse" => "Коњ",
                "Sheep" => "Овца",
                "Cat" => "Мачка",
                "Dog" => "Куче",
                "Snake" => "Змија",
                "Elephant" => "Слон",
                "Lion" => "Лав",
                _ => name
            };
        }
        public static string AnimalSoundToMacedonian(this string sound)
        {
            return sound switch
            {
                "Moo" => "Мууу",
                "Quack" => "Квак",
                "Oink" => "Фрчи",
                "Neigh" => "Ирк",
                "Baa" => "Бее",
                "Meow" => "Мјау",
                "Woof" => "Вау",
                "Hiss" => "Шушка",
                "Trumpet" => "Труби",
                "Roar" => "Рика",
                _ => sound
            };
        }
    }
}
