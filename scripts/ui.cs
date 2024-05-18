using Godot;

namespace UsingGodotForUi.scripts;

public partial class ui : Control {
    private LineEdit _lineEdit;
    private Label _label;
    
    public override void _Ready() {
        _lineEdit = GetNode<LineEdit>("VBoxContainer/LineEdit");
        _label = GetNode<Label>("VBoxContainer/Label");
    }
    
    private void _on_Button_pressed() {
        _label.Text = "You Typed: " + _lineEdit.Text;
    }
}