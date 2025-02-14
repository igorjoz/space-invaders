using Raylib_cs;
using SpaceInvaders.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Managers
{
    public class InputManager
    {
        public static void HandleInput(Player player, List<Bullet> bullets)
        {
            if (Raylib.IsKeyDown(KeyboardKey.Right))
            {
                player.MoveRight();
            }
            if (Raylib.IsKeyDown(KeyboardKey.Left))
            {
                player.MoveLeft();
            }

            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                bullets.Add(player.Shoot());
            }

            /*if (Raylib.IsKeyDown(KeyboardKey.Space) && player.CanShootFullauto())
            {
                bullets.Add(player.Shoot());
            }*/
        }
    }
}
