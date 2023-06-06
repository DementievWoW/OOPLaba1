//Определить наибольшее значение сомножителя n, для которого произведение р = 1
//· 4 · 7 ·...· n не превышает L = 30 000.'
int l = 1;
int count = 0;

for (int i = 1; i < int.MaxValue;i++)
{
    count++;
    l *= i;
    if (l > 30_000)
    {
        break;
    }
    
}
Console.WriteLine(count);