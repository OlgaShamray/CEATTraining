internal class Program
{
    public class Person
    {
        public string? Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"\n   -> {Name}, {(Gender ? 'w' : 'm')}, {Age}";
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("--- Olha Shamray HOMEWORK 2 ---");
        Console.WriteLine("--- Create a program that uses string type, number type, boolean, and collection of any of those types. Transform your collection in any way and output the result to the screen ---");

        List<Person> persons = new List<Person>
        {
            new Person {Name = "Anna", Gender = true, Age = 38},
            new Person {Name = "Ivan", Gender = false, Age = 42},
            new Person {Name = "Julia", Gender = true, Age = 3},
            new Person {Name = "Andrew", Gender = false, Age = 17},
            new Person {Name = "Natalia", Gender = true, Age = 9},
            new Person {Name = "George", Gender = false, Age = 87},
            new Person {Name = "Irina", Gender = true, Age = 60},
        };

        Console.WriteLine("\nList of all persons:" +
                            string.Join("", persons));

        Console.WriteLine("\nChildren: {0} persons {1}",
                            persons.Where(person => person.Age <= 18).Count(),
                            string.Join("", persons.Where(person => person.Age <= 18)));

        Console.WriteLine("\nAdults: {0} persons {1}",
                            persons.Where(person => person.Age > 18 && person.Age < 60).Count(),
                            string.Join("", persons.Where(person => person.Age > 18 && person.Age < 60)));

        Console.WriteLine("\nElderly: {0} persons {1}",
                            persons.Where(person => person.Age >= 60).Count(),
                            string.Join("", persons.Where(person => person.Age >= 60)));

        Console.WriteLine("\nWomen: " + (persons.Where(person => person.Gender == true).Count()) + " persons");

        Console.WriteLine("Men: " + (persons.Where(person => person.Gender != true).Count()) + " persons");

    }
}