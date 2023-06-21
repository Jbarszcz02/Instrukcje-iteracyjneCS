using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int height = int.Parse(Console.ReadLine());

        narysuj(height);

        Console.ReadLine();
    }

    static void narysuj(int height)
    {
        int width = height * 2 - 1;

        for (int row = 0; row < height; row++)
        {
            int starsCount = row * 2 + 1;
            int spacesCount = (width - starsCount) / 2;

            for (int i = 0; i < spacesCount; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < starsCount; i++)
            {
                Console.Write("+");
            }

            Console.WriteLine();
        }
    }
}