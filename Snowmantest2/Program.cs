


int width = 120;
int height = 40;
int blockWidth = 40;
int round = 1;
int sonkonum_x=0;
double valeocity, angle, wind;
int g = -1;
bool isgamefinished = false;

Console.Clear();
Console.CursorVisible = false;


if (height >= Console.BufferHeight)
{
    height = Console.BufferHeight - 4; // sınırlandır
}
for (int x = 0; x <= width; x++)
{
    if(x==39){
        Console.SetCursorPosition(x, 0);
        Console.Write("B");
        Console.SetCursorPosition(x, height);
        Console.Write("B");
    }else if(x==79){
        Console.SetCursorPosition(x, 0);
        Console.Write("R");
        Console.SetCursorPosition(x, height);
        Console.Write("NR");
    }else{
        Console.SetCursorPosition(x, 0);
        Console.Write("-");
        Console.SetCursorPosition(x, height);
        Console.Write("-");
    }
    
    
    
    //Console.SetCursorPosition(x, 0);
    //Console.Write("-");
    //Console.SetCursorPosition(x, height);
    //Console.Write("-");
}

//for (int x = 0; x < blockWidth; x++)
//{
//    Console.SetCursorPosition(x, 0);
//    Console.Write("-");
//    Console.SetCursorPosition(x, width);
//    Console.Write("-");
//    sonkonum_x=x;
//}







while (!isgamefinished)
{
    Console.WriteLine("");
    isgamefinished = true;

}