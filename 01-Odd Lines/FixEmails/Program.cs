using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt",
                "Ivan\r\n" +
                "ivanivan@abv.bg\r\n" +
                "Petar Ivanov\r\n" +
                "petartudjarov@abv.bg\r\n" +
                "Mike Tyson\r\n" +
                "myke@gmail.us\r\n" +
                "stop\r\n");
            int index = 0;
            List<Person> list = new List<Person>();
            while (true)
            {
                string[] inputLine = File.ReadAllLines("input.txt");
                if (inputLine[index] == "stop")
                {
                    break;
                }
                   Person person = new Person();    
                person.Name = inputLine[index];

                index++;
                string email = inputLine[index];

                person.Email = email;
                list.Add(person);
                index++;
            }
            var filteredList = list
                .Where(a => a.Email.EndsWith("bg"))
               .OrderBy(a => a.Name).ToList();

            foreach (var p in filteredList)
            {
                File.AppendAllText("output.txt",
                    $"{p.Name} -> {p.Email}\r\n");
            }
        }
    }
}
