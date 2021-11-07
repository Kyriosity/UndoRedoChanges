using WpfUndoRedo.ViewModels.Commands.Base;

namespace WpfUndoRedo.ViewModels.Commands
{
    public class FileCommandsVm : BaseVm
    {
        public UxAction Exit { get; } = new UxAction {
            Content = "Exit",
            Command = new RelayCommand(_ => System.Windows.Application.Current.Shutdown() )
        };
    }
}
