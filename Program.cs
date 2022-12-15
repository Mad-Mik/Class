using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class
            Person tom = new Person("Mike", 32);

            string personName = tom.name;
            int personAge = tom.age;
            Console.WriteLine($"Name: {personName} Age: {personAge}");

            tom.name = "Tom";
            tom.age = 37;

            tom.Print();
        }

        class Person
        {
            public string name = "Undefined";
            public int age;

            public Person(string n, int a)
            {
                name = n;
                age = a;
            }

            public void Print()
            {
                Console.WriteLine($"Name: {name} Age: {age}");
            }
        }
    }
}
