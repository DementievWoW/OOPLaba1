
double member = 1;
double s = 0;
int n = 0;
var rnd= new Random();
double x= rnd.NextDouble()*1.9-1;
while (member>=0.0001)
{
    n++;
    member= (Math.Cos(n * x)) / (n * n);
    s +=member ;
    Console.WriteLine(member);
}
Console.WriteLine(s);