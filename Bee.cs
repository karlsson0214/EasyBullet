using EasyMonoGame;
using Microsoft.Xna.Framework.Input;

namespace EasyBullet
{
    internal class Bee : Actor
    {
        private int timeToShoot = 0;
        public override void Act()
        {
            timeToShoot -= 1;

            this.TurnTowards(Mouse.GetState().X, Mouse.GetState().Y);
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                if (timeToShoot <= 0)
                {
                    Shoot();
                    timeToShoot = 20;
                }
                
            }
        }
        private void Shoot()
        {
            Bullet bullet = new Bullet();
            World.Add(bullet, "red-draught", this.X, this.Y);
            bullet.Rotation = this.Rotation;
            bullet.Move(50);
        }
    }
}
