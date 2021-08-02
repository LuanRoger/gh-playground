using System;
using ApiSample.Serializer.Object;


namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Me", 18);

            BinarySerializer<Person> bs = new(person);
            bs.Serializer();

            Console.WriteLine($"{typeof(Person).Name} serialized.");
        }
    }
}
