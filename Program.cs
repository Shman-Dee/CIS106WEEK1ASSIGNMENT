using CIS106WEEK1ASSIGNMENT.Models;

Car myCar = new Car("Toyota", 2000, "Red");
Tire myTire = new Tire("Michelin", 18);

Console.WriteLine(myCar.Make);
Console.WriteLine(myCar.Year);
Console.WriteLine(myCar.Color);

Console.WriteLine(myTire.Brand);
Console.WriteLine(myTire.Size);

myCar.Color = "Blue";
myTire.Size = 20;

Console.WriteLine(myCar.Color);
Console.WriteLine(myTire.Size);

Console.WriteLine($"My car is a {myCar.Color} {myCar.Year} {myCar.Make} with {myTire.Size} inch {myTire.Brand} tires.");