using Godot;
using System;


public partial class AnimatedCharacter : AnimatedSprite2D
{
	// Called when the node enters the scene tree for the first time.
	private AnimatedSprite2D _animatedSprite;

	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float steps = 2;
		if (Input.IsKeyPressed(Key.W))

		{
			this.Position += new Vector2(0, -steps);
			//_animatedSprite.Play("Forward");
		}
		if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, steps);
			//_animatedSprite.Play("Forward");

		}
		if (Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-steps, 0);
		}
		if (Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(steps, 0);
			//this._animatedSprite.Play("Forward");

		}
		else
		{
			//_animatedSprite.Play("Idle");
		}
	}
}//
