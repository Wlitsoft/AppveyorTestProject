using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel()
            {
                Id = 1,
                Name = "tom",
                Age = 22
            };

            string result = JsonConvert.SerializeObject(p);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
