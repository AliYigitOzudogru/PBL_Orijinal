    
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

class Program
{
    static void Main()
    {
        double valeocity, angle, wind;
        int g = -1;
        int raund = 1;
        bool isgamefinished = false;
        int areaWidth = 40;
        int areaHeight = 40;
        for (int i = 0; i < areaWidth; i++)
        {
            Console.WriteLine(".");
            Console.WriteLine();
            Console.SetCursorPosition(i + 1, 0);
            if (i == 39)
            {
                Console.WriteLine("B");
            }
       }
        

        

    }


}