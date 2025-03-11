using Godot;
using System;
using System.IO.Ports;
using System.Threading;


public partial class SerialReader : Node2D
{
	// Called when the node enters the scene tree for the first time.
	static SerialPort serialPort;
	CharacterBody2D character;
	AnimatedSprite2D _animatedSprite2D;
	float speed = 100f;
	public override void _Ready()
	{
		character = GetNode<CharacterBody2D>("MyCharacter");
		_animatedSprite2D = GetNode<AnimatedSprite2D>("MyCharacter/AnimatedCharacter");
		serialPort = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
	}



	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Thread.Sleep(50);
		Vector2 direction = Vector2.Zero;
		if (!serialPort.IsOpen)
		{
			serialPort.Open();
		}

		else
		{
			try
			{
				string serialMessage = serialPort.ReadExisting().Trim();

				if (serialMessage == "RIGHT")
				{
					_animatedSprite2D.Play("right");
					direction = new Vector2(1, 0);
				}
				else if (serialMessage == "LEFT")
				{
					_animatedSprite2D.Play("left");
					direction = new Vector2(-1, 0);
				}
				else if (serialMessage == "UP")
				{
					_animatedSprite2D.Play("up");
					direction = new Vector2(0, -1);
				}
				else if (serialMessage == "DOWN")
				{
					_animatedSprite2D.Play("down");
					direction = new Vector2(0, 1);
				}
				else
				{
					direction = Vector2.Zero;
				}

				direction = direction.Normalized();
				character.Velocity = direction * speed;
				character.MoveAndSlide();
			}
			catch (UnauthorizedAccessException e)
			{
				GD.PrintErr($"Fout: Geen toegang tot {serialPort.PortName} - {e.Message}");
			}
			catch (Exception e)
			{
				GD.PrintErr($"Fout bij openen van {serialPort.PortName}: {e.Message}");
			}

		}
	}

	public override void _ExitTree()
	{
		if (serialPort != null && serialPort.IsOpen)
		{
			serialPort.Close();
			serialPort.Dispose();
		}
	}


}
