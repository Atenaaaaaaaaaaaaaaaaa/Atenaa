
char key;
string text = "";
do
{
    key = Console.ReadKey(true).KeyChar;
    if (char.IsLetter(key) && key != '\r')
    {
        Console.Write(key);
        text += key; 
    }
}
while (key != '\r'); 
Console.WriteLine();
Console.WriteLine(text);