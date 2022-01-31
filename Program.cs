using MonoStatePatternSample;

Console.WriteLine("Hello, Mono State Pattern :D");

var ceo = new CEO();
ceo.Name = "Nima Airyana";
ceo.Age = 28;
Console.WriteLine(ceo.ToString());

var ceo2 = new CEO();
Console.WriteLine(ceo2.ToString()); // mono state activated :D

namespace MonoStatePatternSample
{
    public class CEO
    {
        private static string name;
        private static int age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
    }
}
