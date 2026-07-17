Random random = new Random();
int n=random.Next(0,100);

Console.WriteLine("Guess a Number:");
int guess = int.Parse(Console.ReadLine());
int cnt = 1;
while (guess != n)
{
    if (guess > n)
    {
        Console.WriteLine("Guess is Too High!");
    }
    else
    {
        Console.WriteLine("Guess is Too Low!");
    }
    guess=int.Parse(Console.ReadLine());    
    cnt++;
}
Console.WriteLine("Congrats!!");
Console.WriteLine("Yours Guess is Correct!!");
Console.WriteLine("You Take " + cnt + " Attempts.");