double value = 0;

for (int i = 2; i < 110; i++)
{
    value += i / (i + 1.0);
}
Console.WriteLine(value);
