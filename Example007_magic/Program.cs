Console.Clear();
//Console.SetCursorPosition(10,4);
//System.Console.WriteLine("+");

int xa = 1, xb = 1,
    ya = 1, yb = 40,
    za = 40, zb = 1;

Console.SetCursorPosition(xa, xb);
System.Console.Write("+");

Console.SetCursorPosition(ya, yb);
System.Console.Write("+");

Console.SetCursorPosition(za,zb);
System.Console.Write("+");


int x = xa;
int y = xb;

int count = 0;

while (count < 100000)
{
    int random = new Random().Next(0,3);
    
    if(random == 0)
    {
        x = (x + xa) / 2;
        y = (y + xb) / 2;
    }

    if (random == 1)
    {
        x = (x + ya) / 2;
        y = (y + yb) / 2;  
    }
    if (random == 2)
    {
        x = (x + za) / 2;
        y = (y + zb) / 2;
    }

    Console.SetCursorPosition(x,y);
    System.Console.WriteLine("+");
    count++;

}