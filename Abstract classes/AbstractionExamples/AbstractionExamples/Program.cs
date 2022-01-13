using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExamples
{
    public abstract class AbstractExampleClass
    {
        public string Name { get; }
        public string Description { get; set; }
        public abstract void PrintToConsole();
        public AbstractExampleClass(string name)
        {
            Name = name;
        }
        public AbstractExampleClass(string name, string description)
        {
            Description = description;
        }
    }

    public class AbstractExampleClass1:AbstractExampleClass
    {
        public AbstractExampleClass1(string message):base(message)
        {
            Description = this.GetType().Name;
        }
        public override void PrintToConsole()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractExampleClass1 example = new AbstractExampleClass1("name");

            example.PrintToConsole();
        }
    }
}
