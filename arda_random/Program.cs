using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        int duvarBoyu1;
        int duvarBoyu2;
        int width = 120;
        int height = 40;
        int blockWidth = 40;
        bool isgamefinished= false;
        int round = 1;
        int duvarKonumux1;
        int duvarKonumy1;
        int duvarKonumux2;
        int duvarKonumy2;
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

        Console.SetCursorPosition(0, 0);
        Console.BackgroundColor = ConsoleColor.Red;     // arka plan kırmızı kalmalı
        Console.ForegroundColor = ConsoleColor.White;   // yazı beyaz olacak
        Console.Write("R");

        while(!isgamefinished){
            Random rnd = new Random();
            int duvarBoyu1 = rnd.Next(3,7);
            int duvarBoyu2 = rnd.Next(3,7);

            int duvarKonumux1 = rnd.Next(40,81);// 1. Duvarın konumunun rastgele x pozisyonunu random bir şekilde oluşturuyor
            int duvarKonumy1 = rnd.Next(0,121);//  1. Duvarın konumunun rastgele y pozisyonunu random bir şekilde oluşturuyor

            int duvarKonumux2 = rnd.Next(40,81);// 2. Duvarın konumunun rastgele x pozisyonunu random bir şekilde oluşturuyor
            int duvarKonumy2 = rnd.Next(0,121);//  2. Duvarın konumunun rastgele y pozisyonunu random bir şekilde oluşturuyor

            for (int i = 0; i < duvarboyu1; i++)
            {

                Console.SetCursorPosition(duvarkonumx1, duvarkonumy1 + i);
                Console.Write("#");
            }

            for (int a = 0; a < duvarboyu2; a++)
            {


                Console.SetCursorPosition(duvarkonumx2, duvarkonumy2 + a);
                Console.Write("#");
            }


            if(round%3==0){


            }
            
        }

        Console.SetCursorPosition(0, 120);

        Console.ResetColor();
    }
}

