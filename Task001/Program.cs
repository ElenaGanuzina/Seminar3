
int FindQuarter(int x, int y)
{
    if (x > 0 && y > 0) 
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    
    return 0;
}
Console.WriteLine(FindQuarter(4, 9));
Console.WriteLine(FindQuarter(-4, -9));
Console.WriteLine(FindQuarter(4, -9));
Console.WriteLine(FindQuarter(-4, 9));
Console.WriteLine(FindQuarter(4, 0));