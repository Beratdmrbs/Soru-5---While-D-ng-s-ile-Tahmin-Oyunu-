using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int correctNumber = rand.Next(1, 101);
        int userGuess = 0;

        Console.WriteLine("Tahmin oyununa hoş geldiniz!");
        Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin.");

        while (userGuess != correctNumber)
        {
            Console.Write("Tahmininizi girin: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < correctNumber)
            {
                Console.WriteLine("Daha büyük bir sayı tahmin edin.");
            }
            else if (userGuess > correctNumber)
            {
                Console.WriteLine("Daha küçük bir sayı tahmin edin.");
            }
        }

        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
    }
}
