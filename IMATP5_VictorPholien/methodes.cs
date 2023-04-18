using System;
using System.Collections.Generic;
using System.Text;

namespace AppMatrice
{
    public struct methodes
    {

        public void Etape1_GenererMatrice(int taille, int verif, out int[,] Matrice)
        {
     
            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    Matrice = new int[i, j];
                    Matrice[i, j] = Matrice[i, j] + 1;
                }
                Console.Clear();
                Console.WriteLine("Matrice :");
 
                for (i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Matrice = new int[i, j];
                        Console.Write(matrice[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                for (i = 0; i < taille; i++)
                {
                    for (int j = 0; j < taille; j++)
                    {
                        matrice[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }


                public void Etape2(int puissance, int coefficient, out string phrase)
                {
                    int i;
                    int j;
                    int n = puissance;
                    coefficient = MatriceSortie[i, j];
                    for (int i = 0; i < puissance; i++)
                    {
                        phrase = phrase + coefficient;
                    }

                }
            }
        }
    }
}
