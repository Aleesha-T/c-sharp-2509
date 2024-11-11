// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json;
namespace SerializationExample
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
    public class Program
    {
        static void Main()
        {
            ////3. Serialization and Deserialization

            Person person = new Person("Aleesha", 21);
            string filePath = "person.json";
           
            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText(filePath, jsonString);
            // Serialize to JSON and save to file
            Console.WriteLine("Object serialized to JSON file.");
            
            string readJson = File.ReadAllText(filePath);
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(readJson);
            // Deserialize from JSON file
            Console.WriteLine("After deserializing:");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            Console.ReadLine();
        }
    }
}
