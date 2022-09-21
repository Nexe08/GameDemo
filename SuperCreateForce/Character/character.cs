using Godot;
using System;
using static Godot.GD;

public class character : KinematicBody2D
{
    [Export]
    private float gravity = 900.0f;
    [Export]
    private float movementSpeed = 400;

    private Vector2 velocity = Vector2.Zero;
    private Vector2 UP = Vector2.Up;


    public override void _PhysicsProcess(float delta)
    {
        PlayerMovement(delta);
        velocity.y += gravity * delta;
        velocity = MoveAndSlide(velocity, UP);
    }

    private void PlayerMovement(float delta)
    {
        int HDirection = (int) (Input.GetActionStrength("Right") - Input.GetActionStrength("Left"));
        velocity.x = movementSpeed * HDirection;
    }
}
