double AireRectangle(double L, double l) //Renvoie l'aire d'un rectangle de longueur L et de largeur l
{
    return L * l; //Aire du rectangke
}

double AireHexagone(double a) //Renvoie l'aire d'un hexagone de longueur a
{
    return (3*Math.Sqrt(3)/2)*Math.Pow(a, 2); //Aire du rectangle
}

double AireCercle(double r) //Renvoie l'aire d'un cercle de rayon r
{
    return (Math.PI * Math.Pow(r, 2)); //Aire d'un cercle
}



/*Console.WriteLine("Saisissez votre  longueur");
double L = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Saisissez votre  largeur");
double l = Convert.ToDouble(Console.ReadLine());


double a;
Console.WriteLine("Saisissez la longuer des côtés de l'hexagone");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"L'aire de l'hexagone est : {AireHexagone(a)}");    
*/

double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(AireCercle(r));