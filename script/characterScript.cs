using Godot;
using System;

public partial class NewScript : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// var transform = Transform2D;
		var character1 = GetNode<Godot.Sprite2D>("../Character");
		if (Input.IsKeyPressed(Key.W))
		{
			var result = character1.Transform.X;

			GD.Print("character 1 transform ", result);
			Console.WriteLine("character 1 transform ", result);
			Console.WriteLine("test ..");
		}
	}

}
