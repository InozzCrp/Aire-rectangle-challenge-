double AireRectangle(double L, double l) //Renvoie l'aire d'un rectangle de longueur L et de largeur l
{
    return L * l; //Aire du rectangke
}

Console.WriteLine("Saisissez votre  longueur");
double L = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Saisissez votre  largeur");
double l = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"L'aire du rectangle est : {AireRectangle(L, l)}");    