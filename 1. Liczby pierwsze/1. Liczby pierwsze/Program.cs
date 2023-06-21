class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj ile liczb pierwszych wypisać:");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        int number = 2;

        while (count < n)
        {
            if (CzyPierwsza(number))
            {
                Console.WriteLine(number);
                count++;
            }

            number++;
        }

        Console.ReadLine();
    }

    static bool CzyPierwsza(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}