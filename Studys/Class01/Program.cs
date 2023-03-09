internal class Program
{
    private static void Main(string[] args)
    {

        Person[] persons = new Person[3]
        {
            new Customers
            { Name="engin"},
            new Student
            { bolum="mat101"},
            new Person
            {Id=12}
        };
        foreach (var person in persons)
        {
            Console.WriteLine(person.Id + person.Name );
        }
        Console.ReadKey();
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    class Customers: Person
    {
        public string city { get; set; }
    }
    class Student : Person
    {
        public string bolum { get; set; }
    }
}