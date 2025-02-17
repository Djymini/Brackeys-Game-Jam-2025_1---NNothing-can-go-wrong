using Godot;
using System;

public partial class CharacterManager : CharacterBody2D
{
	[Export]
	private float speed = 300.0f;
	
	[Export]
	private float jumpVelocity = -400.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}

		
		Vector2 direction = new Vector2(1,0);
		velocity.X = CharacterMove(direction);
		

		Velocity = velocity;
		MoveAndSlide();
	}

	private void CharacterJump(float velocityY) {
		if (IsOnFloor())
		{
			velocityY = jumpVelocity;
		}
	}

	private float CharacterMove(Vector2 direction) {
		if (direction != Vector2.Zero)
		{
			return direction.X * speed;
		}
		else
		{
			// Si aucune direction n'est donnée, on applique un ralentissement horizontal vers 0
			return Mathf.MoveToward(Velocity.X, 0, speed);
		}
	}
}
