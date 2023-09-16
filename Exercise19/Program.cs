int number = 2, divisible = 0;
int s = 0, i = 1;
Console.Write("How many prime numbers do you want to print? ");
int finalNumber = int.Parse(Console.ReadLine());
while (number <= finalNumber)
{
    for (int ix = 1; ix <= number; ix++)
    {
        if (number % ix == 0)
        {
            divisible++;
        }
        if (divisible > 2)
        {
            break;
        }
    }
    if (divisible == 2)
    {
        Console.Write(" {0,14:N0} is prime", number);
        s = s + number;
        i = i + 1;
    }
    divisible = 0;
    number++;
}

Console.WriteLine("\nThe sum is......: ${0,10:N2}", s);
Console.WriteLine("the average is..: ${0,10:N2} ", s / number);
Console.ReadKey();