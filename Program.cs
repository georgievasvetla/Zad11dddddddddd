namespace AnimalKing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("BaBay", 5);
            Console.WriteLine( dog.MakeNoise());
            Console.WriteLine(dog.MakeTrick());
            Animal cat = new Cat("Maymay", 1);
            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(cat.MakeTrick());
        }
    }
}