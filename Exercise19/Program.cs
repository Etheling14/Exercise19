int number = 2, divisible = 0;
Console.Write("How many prime numbers do you want to print? ");
int finalNumber = int.Parse(Console.ReadLine());
while (number <= finalNumber)
{
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
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
    }
    divisible = 0;
    number++;

}
Console.ReadKey();