using System;

namespace IMATP5_VictorPholien
{
    class Program
    {
        static void Main(string[] args)
        {
            methodes MesOutils = new methodes();
            bool continuer = true;
            int taille;
            while (continuer)
            {
                MesOutils.Etape1_GenererMatrice(taille, out int[,] Matrice);
                Console.WriteLine("Quelle taille voulez vous ?");

            }
            Console.WriteLine("Voulez-vous continuer ? (O/N)");//Boucle de reprise
            string continuerStr = Console.ReadLine();
            continuer = (continuerStr.ToUpper() == "O");


        }
    }
}



