using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "vinter");
Raylib.SetTargetFPS(60);

Vector2 hat1= new(400,10);
Vector2 hat2= new(320,150);
Vector2 hat3= new(480,150);
Vector2[] snowflakes = new Vector2[200];
for(int i=0; i<snowflakes.Length; i++)
{
    Vector2 
}
while (Raylib.WindowShouldClose() == false)
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.DarkPurple);
    //head
    Raylib.DrawCircle(400, 350, 200, Color.DarkBlue);
    //beard
    Raylib.DrawRectangle(200,410,400,500,Color.Black);
     //nose
    Raylib.DrawEllipse(400, 400, 200,100,  Color.DarkBlue);
    //eye
    Raylib.DrawCircle(370, 250, 20, Color.SkyBlue);
    Raylib.DrawCircle(430, 250, 20, Color.SkyBlue);
    //mouth
    Raylib.DrawRing(new(400,400),80,100,165,5,100,Color.Black);
    //hat
    Raylib.DrawRectangle(300, 150, 200, 40, Color.White);
Raylib.DrawTriangle(hat1,hat2,hat3,Color.Red);
for (int i=0; i<snowflakes.Length;)
    Raylib.EndDrawing();
}