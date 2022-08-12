void FindSquares(int number)
{
    Console.Write($"{number} -> ");

    int count = 1;
    while (count < number)
    {
        Console.Write($"{count * count}, ");
        count++;  
    }
Console.WriteLine($"{number * number}.");
}

FindSquares(4);
FindSquares(7);