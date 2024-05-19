using Godot;

namespace UsingGodotForUi.scripts;

public partial class star_button : TextureButton {
    [Export] public Color ButtonBaseColor { get; set; } = Color.FromHtml("65bfd0");

    public override void _Ready() {
        SelfModulate = ButtonBaseColor;
    }
    
    private void _on_Button_pressed() {
        var signalBus = GetNode<signal_bus>("/root/SignalBus");
        signalBus.EmitSignal(signal_bus.SignalName.StarButtonPressed, Name);
    }
}