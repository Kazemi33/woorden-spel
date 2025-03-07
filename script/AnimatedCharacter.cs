// using Godot;
// using System;


// public partial class AnimatedCharacter : AnimatedSprite2D
// {
// 	// Called when the node enters the scene tree for the first time.
// 	private AnimatedSprite2D _animatedSprite;

// 	public override void _Ready()
// 	{
// 		_animatedSprite = GetNode<AnimatedSprite2D>("AnimatedCharacter");
// 	}

// 	// Called every frame. 'delta' is the elapsed time since the previous frame.
// 	public override void _Process(double delta)
// 	{
// 		CharacterMovement();

// 	}

// 	// character movement 
// 	public void CharacterMovement()
// 	{
// 		float steps = 5;
// 		if (Input.IsKeyPressed(Key.W))
// 		{
// 			this.Position += new Vector2(0, -steps);
// 			this.Play("up");

// 		}
// 		if (Input.IsKeyPressed(Key.S))
// 		{
// 			this.Position += new Vector2(0, steps);
// 			this.Play("down");

// 		}
// 		if (Input.IsKeyPressed(Key.A))
// 		{
// 			this.Position += new Vector2(-steps, 0);
// 			this.Play("backward");

// 		}
// 		if (Input.IsKeyPressed(Key.D))
// 		{
// 			this.Position += new Vector2(steps, 0);
// 			this.Play("forward");

// 		}


// 	}
// }//
