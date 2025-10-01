

Console.Clear();
Console.CursorVisible = false;
int width = 120;
int height = 40;
int blockWidth = 40;
int round = 1;
Random rnd = new Random();
// Konsol buffer sınırlarını kontrol et
/* if (Console.BufferHeight < height + 2 || Console.BufferWidth < width + 2)
 {
     Console.WriteLine("Lütfen konsol boyutunu en az 120x42 olarak ayarla.");
     return;
 }
 */
// Alan çizimi
if (height >= Console.BufferHeight)
    {
    height = Console.BufferHeight - 1; // sınırlandır
}
        for (int x = 0; x <= width; x++)
        {
            Console.SetCursorPosition(x, 0);
            Console.Write("-");
            Console.SetCursorPosition(x, height);
            Console.Write("-");
        }

        for (int y = 0; y <= height; y++)
        {
            Console.SetCursorPosition(0, y);
            Console.Write("|");
            Console.SetCursorPosition(width, y);
            Console.Write("|");
            Console.SetCursorPosition(blockWidth, y);
            Console.Write("|");
            Console.SetCursorPosition(2 * blockWidth, y);
            Console.Write("|");
        }

        // Sonsuz round döngüsü
        while (true)
        {
            if (round % 3 == 0)
            {
                Console.Clear();

                // Alanı yeniden çiz
                for (int x = 0; x <= width; x++)
                {
                    Console.SetCursorPosition(x, 0);
                    Console.Write("-");
                    Console.SetCursorPosition(x, height);
                    Console.Write("-");
                }

                for (int y = 0; y <= height; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write("|");
                    Console.SetCursorPosition(width, y);
                    Console.Write("|");
                    Console.SetCursorPosition(blockWidth, y);
                    Console.Write("|");
                    Console.SetCursorPosition(2 * blockWidth, y);
                    Console.Write("|");
                }

                // Kırmızı takım (sol alan)
                for (int i = 0; i < 3; i++)
                {
                    int rx = rnd.Next(1, blockWidth - 1);
                    int ry = rnd.Next(1, height - 1);
                    Console.SetCursorPosition(rx, ry);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("R");
                }

                // Mavi takım (sağ alan)
                for (int i = 0; i < 3; i++)
                {
                    int bx = rnd.Next(2 * blockWidth + 1, width - 1);
                    int by = rnd.Next(1, height - 1);
                    Console.SetCursorPosition(bx, by);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("B");
                }

                // Duvarlar (orta alan)
                for (int i = 0; i < 2; i++)
                {
                    int wx = rnd.Next(blockWidth + 1, 2 * blockWidth - 1);
                    int wy = rnd.Next(1, height - 1);
                    Console.SetCursorPosition(wx, wy);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("#");
                }

                Console.ResetColor();
                Console.SetCursorPosition(0, height + 1);
                Console.WriteLine($"Round {round} tamamlandı. 3 saniye sonra yeni round...");
            }

            round++;
            Thread.Sleep(3000); // 3 saniye bekle
        }
    

