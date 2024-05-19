using Godot;

namespace UsingGodotForUi.scripts;

public partial class ui : Control {
    private LineEdit _lineEdit;
    private Label _label;
    
    public override void _Ready() {
        _lineEdit = GetNode<LineEdit>("VBoxContainer/LineEdit");
        _label = GetNode<Label>("VBoxContainer/Label");

        var signalBus = GetNode<signal_bus>("/root/SignalBus");
        signalBus.StarButtonPressed += _on_star_button_pressed;
    }
    
    private void _on_Button_pressed() {
        _label.Text = "You Typed: " + _lineEdit.Text;
    }
    
    private void _on_star_button_pressed(string buttonName) {
        _label.Text = "You clicked the Star Button named: " + buttonName;
    }
}