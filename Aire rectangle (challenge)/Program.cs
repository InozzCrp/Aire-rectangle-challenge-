double AireRectangle(double L, double l)
{
    return L * l;
}

double AireHexagone(double a) //Renvoie l'aire d'un hexagone de longueur a
{
    return (3*Math.Sqrt(3)/2)*Math.Pow(a, 2); //Aire du rectangle
}



Console.WriteLine("Saisissez votre  longueur");
double L = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Saisissez votre  largeur");
double l = Convert.ToDouble(Console.ReadLine());


double a;
Console.WriteLine("Saisissez la longuer des côtés de l'hexagone");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"L'aire de l'hexagone est : {AireHexagone(a)}");    