double k1= Input("k1= ");
double b1= Input("b1= ");
double k2= Input("k2= ");
double b2= Input("b2= ");

if (k1==k2)
{
    Console.WriteLine("Линии парралельные");
    return;
}

double x = (b1-b2)/(k1-k2);
double y = k1*x+b1;

Console.WriteLine($"пересекаються в координатах (x={x},y={y})");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}