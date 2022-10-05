
Random rnd = new Random();
int cpuRandom;
bool loopAtive = true;

while (loopAtive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a gues. Enter a number 1-3:");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations!");
        // loopAtive = false;
        break;
    } else
    {
        Console.WriteLine("No, try again!");
    }    
}

Console.WriteLine("You win!");