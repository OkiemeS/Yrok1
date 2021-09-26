using System;
using System.Collections.Generic;
using System.Text;

namespace Yrok1
{
    class Animal
    {
        public string Name { get; set; }  // свойство
        public virtual void Golos()  // метод
        {
            Console.WriteLine(" Клич животного");
        }
    }
    class Cat : Animal 
    {
        public override void Golos()
        {
            Console.WriteLine(" мяу мяу мяу");
        }

    }
    class Dog : Animal
    {
        public override void Golos()
        {
            Console.WriteLine(" Гав гав гав");
        }
    }
    class Rat : Animal
    {
        public override void Golos()
        {
            Console.WriteLine(" писк писк писк");
        }
    }
    class Boozer : Animal
    {
        public override void Golos()
        {
            Console.WriteLine(" Э пс... е шо ?");
        }
    }
}
