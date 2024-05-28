namespace AbstractClass
{
    abstract class Animal
    {
        public abstract void MakeSound();

        // Concrete method
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Animal dog = new Dog();
            dog.MakeSound();  
            dog.Eat();        

            Animal cat = new Cat();
            cat.MakeSound();  
            cat.Eat();        
        }
    }

}
