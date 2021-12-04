

var r = new Random();
int favNumber = 333;
Console.WriteLine("Try to guess my favorite number");
int userInput = int.Parse(Console.ReadLine());

if (userInput < favNumber)
{
    Console.WriteLine("Number is too low!");
}
else if (userInput > favNumber)
{
    Console.WriteLine("Number is too high!");
}
else if (userInput == favNumber)
{
    Console.WriteLine("Perfect, way to go!");
}
else
{
    Console.WriteLine("Nevermind!");
}