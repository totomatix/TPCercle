using TPCercle;

// récupération des données nécessaires
Console.Write("Donnez l'abscisse du centre : ");
double Abs = double.Parse(Console.ReadLine());
Console.Write("Donnez l'ordonnée du centre : ");
double Ord = double.Parse(Console.ReadLine());
Console.Write("Donnez le rayon : ");
double Rayon = double.Parse(Console.ReadLine());

// création du centre du cercle
Point Centre = new Point(Abs, Ord);

// création du cercle
Cercle Cercle1 = new Cercle(Centre, Rayon);

// affichage des informations du cercle
Cercle1.Afficher();
Console.WriteLine("Le périmètre est égale à : " + Math.Round(Cercle1.GetPerimetre(),2));
Console.WriteLine("La surface est égale à : " + Math.Round(Cercle1.GetSurface(),2));

// récupération des données nécessaires du nouveau point
Console.Write("Donnez l'abscisse du centre : ");
Abs = double.Parse(Console.ReadLine());
Console.Write("Donnez l'ordonnée du centre : ");
Ord = double.Parse(Console.ReadLine());

// création du nouveau point
Point NouvPoint = new Point(Abs, Ord);

// affichage du nouveau point
NouvPoint.Afficher();

// on indique si le nouveau point appartient au cercle
if (Cercle1.Appartient(NouvPoint))
{
    Console.WriteLine("Le point appartient au cercle.");
}
else
{
    Console.WriteLine("Le point n'appartient pas au cercle.");
}