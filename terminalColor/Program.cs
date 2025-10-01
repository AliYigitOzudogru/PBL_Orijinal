using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;

        int width = 120;
        int height = 40;
        int blockWidth = 40;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x < blockWidth)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
                else if (x < 2 * blockWidth)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.SetCursorPosition(10, 10);
        Console.BackgroundColor = ConsoleColor.Red;     // arka plan kırmızı kalmalı
        Console.ForegroundColor = ConsoleColor.White;   // yazı beyaz olacak
        Console.Write("R");
        Console.SetCursorPosition(0, 120);

        Console.ResetColor();
    }
}
