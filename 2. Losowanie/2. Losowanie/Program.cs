﻿using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int iloscLiczbParzystych = 10;
        int licznikLosowan = 0;

        Console.Write("Wersja 1: ");
        for (int i = 0; i < iloscLiczbParzystych; i++)
        {
            int wylosowanaLiczba;
            do
            {
                wylosowanaLiczba = random.Next(-8, 9);
                licznikLosowan++;
            } while (wylosowanaLiczba % 2 != 0);

            Console.Write(wylosowanaLiczba);

            if (i < iloscLiczbParzystych - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba wykonanych losowań: " + licznikLosowan);
    }
}



# Druga
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int iloscLiczbParzystych = 10; 
        int licznikLosowan = 0;

        Console.Write("Wersja 2: ");
        for (int i = 0; i < iloscLiczbParzystych; i++)
        {
            int wylosowanaLiczba = random.Next(-4, 5) * 2;
            licznikLosowan++;

            Console.Write(wylosowanaLiczba);

            if (i < iloscLiczbParzystych - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba wykonanych losowań: " + licznikLosowan);
    }
}