using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using SpaceInvaders.Managers;
using SpaceInvaders.Utils;

namespace SpaceInvaders
{
    public static class Game
    {
        public static void Main()
        {
            Raylib.InitWindow(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT, "Space Invaders");
            Raylib.SetTargetFPS(144);

            GameManager.Initialize();

            while (!Raylib.WindowShouldClose())
            {
                GameManager.Update();
                GameManager.Draw();
            }

            Raylib.CloseWindow();
        }
    }
}
