using Godot;
using System;

public partial class LevelManager : Node
{
	[Export]
	private Vector2 spawnPosition;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var player = GetNode<CharacterBody2D>("Character");
		player.Position = spawnPosition;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
