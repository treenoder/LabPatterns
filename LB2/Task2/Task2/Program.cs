using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("John", "Doe");
            PrintFullName(human);
            
            Dog dog = new Dog("Rex");
            IWithFullName dogAdapter = new DogFullNameAdapter(dog);
            PrintFullName(dogAdapter);
        }
        
        static void PrintFullName(IWithFullName withFullName)
        {
            Console.WriteLine(withFullName.FullName);
        }
    }
}