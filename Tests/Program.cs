using System.Linq.Expressions;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbLigne = 0;
            int tempQuantite = 0;
            int chiffreActuel = 0;
            int comptePositionLigne = 1;
            List<int> ligne = new List<int>() {1};
            List<int> suivant = new List<int>() {};

            Console.Write("Combien de ligne voulez vous ? : ");
            int.TryParse(Console.ReadLine(), out nbLigne);


            for (int i = 0; i < nbLigne; i++)
            {
                foreach (int v in ligne)
                {
                    Console.Write(v);
                }
                Console.WriteLine();

                chiffreActuel = ligne[0];

                foreach (int c in ligne)
                {
                    if (chiffreActuel == c)
                    {

                        tempQuantite++;
                        chiffreActuel = c;
                        if (comptePositionLigne == ligne.Count())
                        {
                            suivant.Add(tempQuantite); suivant.Add(chiffreActuel);
                            tempQuantite = 0;
                        }
                       comptePositionLigne++;

                    }
                    else
                    {
                        suivant.Add(tempQuantite); suivant.Add(chiffreActuel);
                        tempQuantite = 1;
                        chiffreActuel = c;
                        if (comptePositionLigne == ligne.Count())
                        {
                            suivant.Add(tempQuantite); suivant.Add(c);
                            tempQuantite = 0;
                        }
                        comptePositionLigne++;
                    }

                }
                ligne.Clear();
                ligne.AddRange(suivant);
                suivant.Clear();
                chiffreActuel = 0;
                comptePositionLigne= 1;
            }

        }
    }
}