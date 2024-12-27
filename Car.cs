using System.Runtime.CompilerServices;

namespace SolarQubeTest
{
    public class Car : CarBase
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }

        public string GetName() 
            { return Name; }
    }
}
