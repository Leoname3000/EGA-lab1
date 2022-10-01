//const int L = 15;
//const int LANDSCAPE_SIZE = 32;

//HashSet<int> Alphabet = new HashSet<int> { 0, 1 };
//int modB = Alphabet.Count;

//Console.WriteLine("Enter N: ");
//int N = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("You entered " + N);
////Console.WriteLine("Binary string for " + N + " is " + intToBinaryString(N));
////Console.WriteLine("Converted binary string back to " + binaryStringToInt(intToBinaryString(N)));
////string gen = generateBinaryString();
////Console.WriteLine("Generated random binary string: " + gen);
////Console.WriteLine("Generated string decimal value is " + binaryStringToInt(gen));
////Console.WriteLine("Mu for " + binaryStringToInt(gen) + " is " + mu(binaryStringToInt(gen)));
////Console.WriteLine("Mu for " + N + " is " + mu(N));

//List<string> S = new List<string>();
//double max = 0;
//string maxS = "";
//string reportString = "";

//Console.WriteLine("----- Landscape: -----");
//string landscapeString = "";
//for (int i = 0; i < LANDSCAPE_SIZE; i++)
//{
//    string extraSpaceChar = "";

//    if (i < 10)
//        extraSpaceChar = " ";

//    landscapeString = $"String{extraSpaceChar} {i}: {intToBinaryString(i)}, mu = {mu(i)}";
//    Console.WriteLine(landscapeString);
//}

//Console.WriteLine("----- Monte-Carlo Method: -----");
//for (int i = 0; i < N; i++)
//{
//    bool maxChanged = false;
//    reportString = "Step " + Convert.ToString(i) + ": ";

//    S.Add(generateBinaryString());

//    if (max < mu(binaryStringToInt(S[i])))
//    {
//        max = mu(binaryStringToInt(S[i]));
//        maxS = S[i];

//        if (i != 0)
//            maxChanged = true;
//    }

//    if (i < 10)
//        reportString += " ";

//    reportString += "S[i] = " + S[i] + ", mu = " + Convert.ToString(mu(binaryStringToInt(S[i]))) + ", maxS = " + Convert.ToString(maxS) + ", max = " + Convert.ToString(max);

//    if (maxChanged)
//        reportString += " <- CHANGE";

//    Console.WriteLine(reportString);
//}

////for (int i = 0; i < N; i++)
////    Console.WriteLine(S[i]);

//string generateBinaryString()
//{
//    Random random = new Random();

//    string binaryString = "";
//    for (int i = 0; i < L; i++)
//    {
//        binaryString = Convert.ToString(random.Next(0, 10) % modB) + binaryString;
//    }
//    return binaryString;
//}

//int binaryStringToInt(string binaryString)
//{
//    int result = 0;
//    for (int i = 0; i < L; i++)
//    {
//        result += Convert.ToInt32(Convert.ToString(binaryString[i])) * Convert.ToInt32(Math.Pow(modB, L - (i + 1)));
//    }
//    return result;
//}

//string intToBinaryString(int x)
//{
//    string binaryString = "";
//    int remainder;
//    while (x > 0)
//    {
//        remainder = x % modB;
//        binaryString = remainder.ToString() + binaryString;
//        x = x / modB;
//    }
//    for (int i = 0; binaryString.Length < L; i++)
//    {
//        binaryString = "0" + binaryString;
//    }

//    return binaryString;
//}

//double mu(int x)
//{
//    return Math.Pow(Convert.ToDouble(x) - Math.Pow(2, L - 1), 2);
//}