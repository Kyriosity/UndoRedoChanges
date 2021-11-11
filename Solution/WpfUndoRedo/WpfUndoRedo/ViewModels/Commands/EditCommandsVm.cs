using System.Windows.Input;
using WpfUndoRedo.ViewModels.Commands.Base;

namespace WpfUndoRedo.ViewModels.Commands
{
    public class EditCommandsVm : BaseVm
    {
        public string UndoContent => "Undo";
        public bool CanUndo { get; set; } = true;

        public ICommand _undo;
        public ICommand Undo => _undo ?? new RelayCommand(ShowMessage, _ => CanUndo);

        public void ShowMessage(object _) {
            CanUndo = false;
        }
    }
}
