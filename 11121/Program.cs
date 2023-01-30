using System.Xml;

namespace _11121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbLigne = 0, nextChar = 1, repetition = 0, avant = 1, ligneSuivante = 0;
            string ligne = "11233";
            string suivant = "";
            char comparaison = 'a';
            Console.Write("Combien de ligne voulez vous ? : ");
            int.TryParse(Console.ReadLine(), out nbLigne);

            Console.WriteLine("longueur de ma ligne : " + ligne.Length);

            for (int i = 0; i < nbLigne; i++)
            {
                comparaison = ligne[0];


                foreach (char c in ligne)
                {
                    
                    Console.Write(c);
                    if (c == comparaison)
                    {
                        repetition++;
                    }
                    else
                    {
                        suivant += repetition+c;
                        repetition = 1;
                        
                    }
                    
                    
                }
                Console.WriteLine(suivant);
            }






            /* for (int i = 0; i < nbLigne; i++) //nombre de ligne qu'on va afficher
             {
                 avant = ligne[0];
                 for (int j = 0; j < ligne.Length; j++) // écriture de la ligne en cours et comparaison pour la ligne suivante
                 {

                     Console.Write(ligne[j]);
                     if (ligne[j] == avant) 
                     {
                         repetition++;
                     }
                     else
                     {
                         ligneSuivante = ligneSuivante + repetition;
                         repetition = 1;
                         avant = ligne[j];
                     }





                 }

                 Console.WriteLine($"\n{ligneSuivante}"); // test

                 Console.WriteLine(); // le retour à la ligne pour écrire la suivante

             */
            /*while (ligne[i] == (ligne[i+nextChar] && ))
            {
                Console.WriteLine("coucou");
                nextChar++;
            }*/





            /*foreach(char c in ligne)
            {
                if ()
                {
                    Console.WriteLine("oui");
                }
            }*/

        }
    }
}