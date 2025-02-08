﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using SpaceInvaders.Utils;

namespace SpaceInvaders.GameObjects
{
    public class Player : GameObject
    {
        public Player() : base(new Utils.Vector2D(400, 550), Constants.PLAYER_SIZE, Raylib_cs.Color.Blue)
        {

        }

        public void MoveRight()
        {
            Move(new Vector2D(Constants.PLAYER_SPEED, 0));
        }

        public void MoveLeft()
        {
            Move(new Vector2D(-Constants.PLAYER_SPEED, 0));
        }

        public override void Update()
        {
            var clampedX = Math.Clamp(Position.X, 0 + Size.X / 2, Constants.WINDOW_WIDTH - Size.X / 2);
            SetPosition(new Vector2D(clampedX, Position.Y));
        }

        public Bullet Shoot()
        {
            return new Bullet(new Vector2D(Position.X, Position.Y - Size.Y / 2), true);
        }
    }
}
