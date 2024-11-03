
Console.WriteLine("enter the first number :");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("enter the second number :");
uint m = Convert.ToUInt32(Console.ReadLine());
for (uint i = n; i < m; i++)
{
    if (i < 10)
    {
        Console.WriteLine(i + " is not mirror number");
    }
    else
    {
        uint p = i;
        uint r_num = 0;
        while (p > 0)
        {
            uint digit = p % 10;
            r_num = r_num * 10 + digit;
            p = p / 10;
        }
        if (i == r_num)
        {
            Console.WriteLine(i + " is mirror number");
        }
        else
        {
            Console.WriteLine(i + " is not mirror number");
        }
    }
}