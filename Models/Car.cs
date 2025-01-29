namespace CIS106WEEK1ASSIGNMENT.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, int year, string color)
        {
            Make = make;
            Year = year;
            Color = color;
        }

    }
}