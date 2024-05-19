using Godot;

namespace UsingGodotForUi.scripts;

public partial class signal_bus : Node {
    [Signal]
    public delegate void StarButtonPressedEventHandler(string buttonName);
}