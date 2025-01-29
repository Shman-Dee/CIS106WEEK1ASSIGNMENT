namespace CIS106WEEK1ASSIGNMENT.Models
{
    public class Tire
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Size { get; set; }

        public Tire(string brand, int size)
        {
            Brand = brand;
            Size = size;
        }
    }

}