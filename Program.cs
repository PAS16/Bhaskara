Console.Clear();
double a, b, c, calculo, x1, x2;

Console.WriteLine("-- Equação de Segundo Grau --");
Console.WriteLine();
Console.Write("(A):... ");
a = Convert.ToDouble (Console.ReadLine());
Console.Write("(B):... ");
b = Convert.ToDouble (Console.ReadLine());
Console.Write("(C):... ");
c = Convert.ToDouble (Console.ReadLine());


if (a == 0)

{
    Console.WriteLine("Não é equação de segundo grau");
}
else 
{
    calculo = b * b - 4 * a * c;

    if (calculo < 0)
    {
        Console.WriteLine($"Como delta = {calculo:N2}, a equação não possui raizes reais! ");
    }
    else
    {
        x1 = (-b + Math.Sqrt(calculo)) / (2 * a);
        x2 = (-b - Math.Sqrt(calculo)) / (2 * a);

        Console.WriteLine($"x1 = {x1:N2} e x2 + {x2:N2}");
    }
}