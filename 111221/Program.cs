namespace _111221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Les variables pour l'affichage des lignes
            int nbLigne = 0;
            List<int> ligne = new List<int>() { };
            // les variables pour recommencer
            bool restart = false;
            string reponse = "";

            // premier lancement et restart
            do
            {
                ligne.Clear();
                ligne.Add(1);  //Pour qu'on démarre bien à 1 la première fois ainsi qu'au restart

                // La question du nombre de ligne souhaitée par l'utilisateur
                Console.Write("Combien de ligne voulez vous ? : ");
                int.TryParse(Console.ReadLine(), out nbLigne);

                Console.WriteLine(); // j'aime bien rajouter un espace :p

                // afficher le résultat suivant le nombre de ligne souhaitée
                for (int i = 0; i < nbLigne; i++)
                {
                    // affichage de la ligne actuelle
                    foreach (int l in ligne)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine();

                    // l'appel de la méthode pour préparer la prochaine ligne
                    if (nbLigne > 1)
                    {
                        MaClasse.LigneSuivante(ligne);
                    }
                }

                // est-ce que l'utilisateur veut recommencer ?
                Console.Write(Environment.NewLine + "Voulez vous recommencez ? : ");
                reponse = Console.ReadLine();
                restart = MaClasse.Recommence(reponse);


            } while (restart == true); // si c'est true on recommence
        }
    }
}