using System;
namespace EGA_lab1
{
    public class BinaryString
    {
        public const int MU_FORMAT_WIDTH = 9;
        public const int CTR_FORMAT_WIDTH = 2;

        const int MOD_B = 2;
        const int L = 15;

        public string StrVal;

        public BinaryString(int rawInt)
        {
            string binaryString = "";
            int remainder;

            while (rawInt > 0)
            {
                remainder = rawInt % MOD_B;
                binaryString = $"{remainder}" + binaryString;
                rawInt /= MOD_B;
            }
            for (int i = 0; binaryString.Length < L; i++)
            {
                binaryString = "0" + binaryString;
            }
            StrVal = binaryString;
        }

        public BinaryString()
        {
            StrVal = Generate();
        }

        private string Generate()
        {
            Random random = new Random();

            string binaryString = "";
            for (int i = 0; i < L; i++)
            {
                binaryString = $"{random.Next(0, 10) % MOD_B}" + binaryString;
            }
            return binaryString;
        }

        public int IntVal()
        {
            int result = 0;

            for (int i = 0; i < L; i++)
            {
                result += Convert.ToInt32($"{StrVal[i]}") * Convert.ToInt32(Math.Pow(MOD_B, L - (i + 1)));
            }
            return result;
        }
        
        public double Mu()
        {
            return Math.Pow(Convert.ToDouble(IntVal()) - Math.Pow(2, L - 1), 2);

        }

        public static void CreateLandscape(int length, int start = 0, int step = 1)
        {
            for (int i = start; i < start + length; i += step)
            {
                BinaryString landscapeString = new BinaryString(i);
                Console.WriteLine($"{i,CTR_FORMAT_WIDTH} = {landscapeString.StrVal}, mu = {landscapeString.Mu(), MU_FORMAT_WIDTH}");
            }
        }
    }
}

