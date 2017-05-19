using System;
using FirstGameDevProject.Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FirstGameDevProject
{
	public class Projectile2
	{
		// Image representing the Projectile
		public Animation projectileAnimation;

		// Position of the Projectile relative to the upper left side of the screen
		public Vector2 Position;

		// State of the Projectile
		public bool Active;

		// The amount of damage the projectile can inflict to an enemy
		public int Damage;

		public int weapon;

		// Represents the viewable boundary of the game
		Viewport viewport;

		// Get the width of the projectile ship
		public int Width
		{
			get { return projectileAnimation.FrameWidth; }
		}

		// Get the height of the projectile ship
		public int Height
		{
			get { return projectileAnimation.FrameHeight; }
		}

		// Determines how fast the projectile moves
		float projectileMoveSpeed;


		public void Initialize (Viewport viewport, Animation animation, Vector2 position)
		{
			projectileAnimation = animation;
			Position = position;
			this.viewport = viewport;

			Active = true;


				Damage = 10;
				projectileMoveSpeed = 5f;
		}

		public void Update ()
		{
			// Projectiles always move to the right
			Position.X += projectileMoveSpeed;

			// Deactivate the bullet if it goes out of screen
			if (Position.X + projectileAnimation.FrameWidth / 2 > viewport.Width)
				Active = false;
		}

		public void Draw (SpriteBatch spriteBatch)
		{
			projectileAnimation.Draw(spriteBatch);
		}

	}
}
