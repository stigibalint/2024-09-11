using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        try
        {
            if (args.Length % 2 == 0)
            {
                Console.Error.WriteLine("Hiba: Páros számú argumentumok.");
                Environment.Exit(1);
            }

            int middleNumberIndex = args.Length / 2;
            int middleNumber = int.Parse(args[middleNumberIndex]);
            int leftNeighbor = int.Parse(args[middleNumberIndex - 1]);
            int rightNeighbor = int.Parse(args[middleNumberIndex + 1]);

            if (leftNeighbor == 0 || rightNeighbor == 0)
            {
                Console.Error.WriteLine("Hiba: Nullával való osztás.");
                Environment.Exit(1);
            }

            int largerNeighbor = Math.Max(leftNeighbor, rightNeighbor);
            int smallerNeighbor = Math.Min(leftNeighbor, rightNeighbor);
            int quotient = largerNeighbor / smallerNeighbor;

            double result = Math.Pow(middleNumber, quotient);
            Console.WriteLine($"\nEredmény: {result}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Hiba! Rossz értéket próbáltál beírni!");
            Environment.Exit(1);
        }
    */

      
    //2F
    
    string[] words = File.ReadAllLines("szavak.txt");
    int count = 0;

    foreach (string word in words)
    {
        int syllableCount = CountSyllables(word);
        if (syllableCount > 4)
        {
            count++;
        }
    }

    Console.WriteLine($"A fájlban {count} olyan szó található, amely több mint négy szótagból áll.");
}

static int CountSyllables(string word)
{
    int syllableCount = 0;
    string vowels = "AEIOU";

    foreach (char c in word)
    {
        if (vowels.Contains(c))
        {
            syllableCount++;
        }
    }

    return syllableCount > 0 ? syllableCount : 1;
    



    /*
    Random rnd = new Random(33);
    int[,] arr1 = new int[6, 6];

    Console.WriteLine("Matrix :");
    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            arr1[i, j] = rnd.Next(55, 156);
            Console.Write(arr1[i, j] + "\t");
        }
        Console.WriteLine();
    }

    double edgeSum = 0;
    int edgeCount = 0;


    for (int j = 0; j < 6; j++)
    {
        edgeSum += arr1[0, j] + arr1[5, j];
        edgeCount += 2;
    }


    for (int i = 1; i < 5; i++)
    {
        edgeSum += arr1[i, 0] + arr1[i, 5];
        edgeCount += 2;
    }

    double edgeAverage = edgeSum / edgeCount;
    Console.WriteLine("Átlag: " + edgeAverage);
    */



    /*
    string inputFilePath = "kep.txt";
    string outputFilePath = "kekitett.txt";


    string[] lines = File.ReadAllLines(inputFilePath);
    string[] modifiedLines = new string[lines.Length];

    for (int i = 0; i < lines.Length; i++)
    {

        string[] rgb = lines[i].Split(';');
        int r = int.Parse(rgb[0]);
        int g = int.Parse(rgb[1]);
        int b = int.Parse(rgb[2]);


        if (b < 100)
        {
            b = Math.Min(b + 20, 255); 
        }


        modifiedLines[i] = $"{r};{g};{b}";
    }


    File.WriteAllLines(outputFilePath, modifiedLines);

    Console.WriteLine("#Kész!");
    */
}

}