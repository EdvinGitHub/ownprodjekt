// this game is a child game
// dont for get to use coments 
using Raylib_cs;

Raylib.InitWindow(1000,800,"Fuck you");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.GRAY);


    Raylib.DrawRectangle(100, 100, 100, 100, Color.RED);
    
    Raylib.EndDrawing();
}

Console.ReadLine();
