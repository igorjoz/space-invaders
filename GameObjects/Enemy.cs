using SpaceInvaders.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace SpaceInvaders.GameObjects
{
    public class Enemy : GameObject
    {
        private float direction = 1.0f;

        public Enemy(Vector2D position) : base(position, Constants.ENEMY_SIZE, Color.Red)
        {

        }

        public override void Update()
        {
        }

        public void Update(float enemyDirection)
        {
            Move(new Vector2D(Constants.ENEMY_SPEED * direction, 0));
        }

        public void SwitchDirection()
        {
            direction *= - 1.0f;
            Move(new Vector2D(0, Constants.ENEMY_DROP_DISTANCE));
        }
    }
}
