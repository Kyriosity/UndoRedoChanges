
using System.Windows.Input;

namespace WpfUndoRedo.ViewModels.Commands.Base
{
    public class UxAction
    {
        public string Content { get; init; } = "-not set-";
        public bool NotApplicable { get; set; }
        public bool Disabled { get; set; }
        public ICommand Command { get; init; }
    }
}
