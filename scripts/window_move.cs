using Godot;

namespace UsingGodotForUi.scripts;

public partial class window_move : TextureButton {
    private bool _isDragging;
    private Vector2 _dragPoint;

    private void _on_gui_input(InputEvent @event) {
        if (@event is InputEventMouseButton mouseEvent) {
            if (mouseEvent.ButtonIndex == MouseButton.Left) {
                _isDragging = !_isDragging;
                _dragPoint = GetGlobalMousePosition();
            }
        }

        if (@event is InputEventMouseMotion && _isDragging) {
            var position = DisplayServer.MouseGetPosition();
            GetWindow().Position = (Vector2I)(position - _dragPoint);
        }
    }
}