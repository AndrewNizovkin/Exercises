int number = 0;
string binary = "";
if (number != 0)
{
    while (number > 0)
    {
        binary = number % 2 + binary;
        number = number / 2;
    }
}
else
{
    binary = "0";
}
Console.WriteLine(binary);

