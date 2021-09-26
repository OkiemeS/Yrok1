using System;

namespace Yrok1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[4];
            Cat cat1 = new Cat();
            cat1.Name = "Барсик";
            Dog dog1 = new Dog();
            dog1.Name = "Мухтар";
            Rat rat1 = new Rat();
            rat1.Name = "Саймон";
            Boozer boozer1 = new Boozer();
            boozer1.Name = "Дядя Гриша";

            animals[0] = cat1;
            animals[1] = dog1;
            animals[2] = rat1;
            animals[3] = boozer1;

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(" Животное " + animals[i] + " говорит : ");
                animals[i].Golos();
            }

        }
    }
}
