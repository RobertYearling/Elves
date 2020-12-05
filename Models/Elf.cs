namespace Elves.Models
{
    public class Elf
    {
        public string Name; // Fields
        public int Age;
        public double Heigth;
        public string Residence;

        public Elf(string name, int age, double heigth, string residence ) // Delcaring a Constructor
        {
            Name = name;
            Age = age;
            Heigth = heigth;
            Residence = residence;
        }
    }
}