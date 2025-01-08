using Raylib_cs;
Raylib.InitWindow(800, 600, "vinter");
Raylib.SetTargetFPS(60);
while (Raylib.WindowShouldClose() == false)
{
    Raylib.BeginDrawing();

Raylib.ClearBackground(Color.DarkPurple);
Raylib.DrawCircle(400,200,200,Color.DarkBlue);
Raylib.DrawRectangle(350,250,100,25,Color.Black);

Raylib.DrawCircle(370,100,20,Color.SkyBlue);
Raylib.DrawCircle(430,100,20,Color.SkyBlue);

    Raylib.EndDrawing();
}