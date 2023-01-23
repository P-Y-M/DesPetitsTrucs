using System.Data;

int hauteur = 0, espace = 1;

Console.WriteLine("De quelle hauteur voulez-vous votre sapin ?");
int.TryParse(Console.ReadLine(), out hauteur);

Console.Clear();

if (hauteur != 1) espace = ((hauteur * 2) - 1) / 2 ;

for (int i = 1; i <= hauteur; i++) //les branches du sapin
{
    Console.Write("  ");

    for (int espaceAvant = 0; espaceAvant <= espace-i; espaceAvant++) //nombre d'espace avant les étoiles
    {
        Console.Write(" ");
    }

    for (int etoile = 0; etoile <(i*2)-1; etoile = etoile +1) //nombre d'étoile : (hauteur*2)-1
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = 0; i < 3; i++) //le tronc
{
    Console.Write("  ");

    if (espace > 1)
    {
        for (int espaceAvant = 0; espaceAvant < espace-1; espaceAvant++) //nombre d'espace avant le tronc
        {
            Console.Write(" ");
        }
    }

    for (int tronc = 0; tronc < 3; tronc++) //le tronc
    {
        Console.Write("x");
    }
    Console.WriteLine();
}

Console.WriteLine("\nJoyeux Noël en retard !!!");