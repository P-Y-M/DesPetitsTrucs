using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111221
{
    public class MaClasse
    {
        public static List<int> LigneSuivante(List<int> ligneActuelle) // la méthode pour préparer la ligne suivante
        {
            // les variables
            int tempQuantite = 0;
            int chiffreActuel = 0;
            int comptePositionLigne = 1;
            List<int> suivant = new List<int>() { };

            // affectation du premier chiffre de la ligne pour démarrer la boucle conformément
            chiffreActuel = ligneActuelle[0];

            // la boucle pour 
            foreach (int c in ligneActuelle)
            {
                // si on retrouve le même chiffre on incrémente la quantité trouvée pour celui-ci
                if (chiffreActuel == c)
                {

                    tempQuantite++;
                    chiffreActuel = c;


                }
                // si on a plus le même chiffre on affiche combien de fois le chiffre précédent a été trouvé et on stock le nouveau chiffre pour la suite
                else
                {
                    suivant.Add(tempQuantite); suivant.Add(chiffreActuel);
                    tempQuantite = 1;
                    chiffreActuel = c;

                }

                // le contrôle pour voir si on est arrivé à la fin et afficher la dernière valeur
                if (comptePositionLigne == ligneActuelle.Count())
                {
                    suivant.Add(tempQuantite); suivant.Add(chiffreActuel);
                    tempQuantite = 0;
                }

                // augmentation de cette variable pour le contrôle de fin ligne atteinte
                comptePositionLigne++;
            }

            // Attribution de la ligne suivante à la ligne en cours
            ligneActuelle.Clear();
            ligneActuelle.AddRange(suivant);
            return ligneActuelle;
        }

        public static bool Recommence(string answer) // la méthode pour savoir si le joueur veut recommencer
        {
            // la variable
            bool again = false;

            // on traite la réponse reçue
            if (answer == "oui" || answer == "o" || answer == "yes" || answer == "y" || answer == "Oui" || answer == "O")
            {
                again = true;
                Console.Clear();
            }
            else
            {
                again = false;
                Console.Clear();
                Console.WriteLine(Environment.NewLine + "Ok, bye ! :D");
            }
            return again; // on recommence si c'est true et on stop si c'est false
        }
    }
}
