using Godot;
using System;

public partial class MyCharacter : CharacterBody2D
{
	private AnimatedSprite2D _animatedSprite;

	public override void _Ready()
	{
		_animatedSprite = GetNode<AnimatedSprite2D>("AnimatedCharacter");
	}

	// public override void _PhysicsProcess(double delta)
	// {
	// 	float steps = 4;
	// 	if (Input.IsKeyPressed(Key.W))
	// 	{
	// 		this.Position += new Vector2(0, -steps);
	// 		_animatedSprite.Play("up");

	// 	}
	// 	if (Input.IsKeyPressed(Key.S))
	// 	{
	// 		this.Position += new Vector2(0, steps);
	// 		_animatedSprite.Play("down");

	// 	}
	// 	if (Input.IsKeyPressed(Key.A))
	// 	{
	// 		this.Position += new Vector2(-steps, 0);
	// 		_animatedSprite.Play("backward");

	// 	}
	// 	if (Input.IsKeyPressed(Key.D))
	// 	{
	// 		this.Position += new Vector2(steps, 0);
	// 		_animatedSprite.Play("forward");
	// 	}
	// }
	private float speed = 500f;

	public override void _PhysicsProcess(double delta)
	{
		// Richting van beweging instellen
		Vector2 direction = new Vector2(
			Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left"),
			Input.GetActionStrength("ui_down") - Input.GetActionStrength("ui_up")
		);

		// Diagonale beweging stoppen
		if (Input.IsActionPressed("ui_left"))
		{
			_animatedSprite.Play("left");
			direction.Y = 0;
		}
		else if (Input.IsActionPressed("ui_right"))
		{
			_animatedSprite.Play("right");
			direction.Y = 0;
		}
		else if (Input.IsActionPressed("ui_up"))
		{
			_animatedSprite.Play("up");
			direction.X = 0;
		}
		else if (Input.IsActionPressed("ui_down"))
		{
			_animatedSprite.Play("down");
			direction.X = 0;
		}
		else
		{
			direction = Vector2.Zero;
		}

		// Normaliseer de richting en pas snelheid toe
		direction = direction.Normalized();
		Velocity = direction * speed;

		MoveAndSlide();
	}
}
