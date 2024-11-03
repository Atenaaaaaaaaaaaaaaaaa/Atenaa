
Console.WriteLine("enter the first number :");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("enter the second number :");
uint m = Convert.ToUInt32(Console.ReadLine());
for (uint j = n; j < m; j++)
{
    if (j < 2)
    {
        Console.WriteLine(j + " notprime");
    }
    else
    {
        uint k = 0;
        for (uint i = 2; i < j; i++)
        {
            if (j % i == 0)
            {
                k++;
            }
        }
        if (k > 0)
        {
            Console.WriteLine(j + " notprime");
        }
        else
        {
            Console.WriteLine(j + " prime");
        }
    }
}