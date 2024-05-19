using Godot;

namespace UsingGodotForUi.scripts;

public partial class window_close : TextureButton {
    private void _on_gui_input(InputEvent @event) {
        if (@event is InputEventMouseButton mouseEvent) {
            if (mouseEvent.ButtonIndex == MouseButton.Left) {
                GetTree().Quit();
            }
        }
    }
}