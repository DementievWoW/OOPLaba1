Console.WriteLine("Введите p");
int i, sum, p, count;
p = Convert.ToInt16(Console.ReadLine());
sum = 0;
count = 0;
for (i = 1; i <= p; i++)
{
    count++;
    sum += i;
    if ( sum>p)
    {
        break;
    }
    
    Console.WriteLine(sum);
}

Console.WriteLine(count);