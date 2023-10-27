
Console.WriteLine("What is your name: ");
string name = Console.ReadLine();

var currentDate = DateTime.Now;

Console.WriteLine("Your name is " + name + " and the current date is: " + currentDate);

Random random = new Random();
for (int i = 0; i < 10; i++)
    Console.WriteLine(random.Next(1, 100));
