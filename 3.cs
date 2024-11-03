
Console.WriteLine("enter the number : ");
uint n = Convert.ToUInt32(Console.ReadLine());
uint a1 = 1;
uint a2 = 1;
bool isfibo = false;
while (n > a2)
{
    uint sum = a1 + a2;
    if(sum == n)
    {
        isfibo = true;
    }
    a1 = a2;
    a2 = sum;
}
if (isfibo)
{
    Console.WriteLine("This number is fibonachi number");
}
else
{
    Console.WriteLine("This number is not fibonachi number");
}