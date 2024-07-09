using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] dim = Console.ReadLine().Split(" ");
        int wierszy = int.Parse(dim[0]);
        int kolumny = int.Parse(dim[1]);

        char[,] plansza = new char[wierszy, kolumny];

        for (int i = 0; i < wierszy; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < kolumny; j++)
            {
                plansza[i, j] = row[j];
            }
        }

        for (int i = 0; i < wierszy; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                if (plansza[i, j] != '*')
                {
                    int liczMin = LiczSasMin(plansza, i, j, wierszy, kolumny);
                    plansza[i, j] = liczMin > 0 ? liczMin.ToString()[0] : '.';
                }
            }
        }

        for (int i = 0; i < wierszy; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                Console.Write(plansza[i, j]);
            }
            Console.WriteLine();
        }
    }

    static int LiczSasMin(char[,] plansza, int wier, int kol, int wierszy, int kolumny)
    {
        int licz = 0;

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                int nowyWier = wier + i;
                int nowaKol = kol + j;

                if (nowyWier >= 0 && nowyWier < wierszy && nowaKol >= 0 && nowaKol < kolumny && plansza[nowyWier, nowaKol] == '*')
                {
                    licz++;
                }
            }
        }

        return licz;
    }
}
