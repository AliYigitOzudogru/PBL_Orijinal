using System;

class Program
{
    static void Main()
    {
        int blockWidth = 40;   // her bloğun genişliği
        int blockHeight = 40;  // toplam yüksekliğimiz

        for (int row = 0; row < blockHeight; row++)
        {
            // 1. blok (mavi)
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(new string(' ', blockWidth));

            // 2. blok (siyah)
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(new string(' ', blockWidth));

            // 3. blok (kırmızı)
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(new string(' ', blockWidth));

            // satır sonu
            Console.WriteLine();
        }

        Console.ResetColor();
    }
}
