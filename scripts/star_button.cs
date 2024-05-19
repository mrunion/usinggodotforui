using Godot;

namespace UsingGodotForUi.scripts;

public partial class star_button : TextureButton {
    [Export] public Color ButtonBaseColor { get; set; } = Color.FromHtml("65bfd0");

    public override void _Ready() {
        SelfModulate = ButtonBaseColor;
    }
}