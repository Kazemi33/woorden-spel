using Godot;
using System;

public partial class CharacterBody2d : CharacterBody2D
{

	public override void _PhysicsProcess(double delta)
	{
		float steps = 4;
		if (Input.IsKeyPressed(Key.W))
		{
			this.Position += new Vector2(0, -steps);

		}
		if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, steps);

		}
		if (Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-steps, 0);

		}
		if (Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(steps, 0);
		}
	}
}
