double AireRectangle(double L, double l)
{
    return L * l;
}

Console.WriteLine("Saisissez votre  longueur");
double L = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Saisissez votre  largeur");
double l = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"L'aire du rectangle est : {AireRectangle(L, l)}");    