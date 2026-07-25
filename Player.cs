using Godot;

namespace dodgethecreeps;

public partial class Player : Area2D
{
    [Export]
    public int Speed { get; set; } = 400;

    public Vector2 ScreenSize;

    public override void _Ready()
    {
        ScreenSize = GetViewportRect().Size;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}