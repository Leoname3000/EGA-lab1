using System;
using EGA_lab1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------======= LANDSCAPE =======------\n");
        BinaryString.CreateLandscape(32);

        Console.WriteLine("\n------======= MONTE-CARLO METHOD =======------\n");
        Console.WriteLine("Enter N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        List<BinaryString> S = new List<BinaryString>();
        BinaryString maxS = new BinaryString();
        double max = -1;

        for (int i = 0; i < N; i++)
        {
            bool maxChanged = false;
            string reportString = $"Step {i + 1, BinaryString.CTR_FORMAT_WIDTH}: ";

            S.Add(new BinaryString());
            reportString += $"S[i] = {S[i].StrVal}, mu = {S[i].Mu(), BinaryString.MU_FORMAT_WIDTH}, ";

            if (max < S[i].Mu())
            {
                max = S[i].Mu();
                maxS = S[i];

                if (i != 0)
                    maxChanged = true;
            }

            reportString += $"maxS = {maxS.StrVal}, max = {max, BinaryString.MU_FORMAT_WIDTH}";

            if (maxChanged && i != 0)
                reportString += " <- CHANGE";

            Console.WriteLine(reportString);
        }
        Console.WriteLine($"\n> Final result: {maxS.StrVal}, mu = {max, BinaryString.MU_FORMAT_WIDTH}.");
    }
}