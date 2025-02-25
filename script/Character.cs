using Godot;
using System;

public partial class Character : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float steps = 10;
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
