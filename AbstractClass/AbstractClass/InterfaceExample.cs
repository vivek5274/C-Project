using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassVsInterface
{

    
    interface IAnimal
    {
        void MakeSound();  
        void Eat();
    }

    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }

        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }

    
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void Eat()
        {
            Console.WriteLine("Cat is eating");
        }
    }

    public class Program
    {
        public static void Main()
        {
            IAnimal dog = new Dog();
            dog.MakeSound();  
            dog.Eat();        

            IAnimal cat = new Cat();
            cat.MakeSound();  
            cat.Eat();        
        }
    }

}
