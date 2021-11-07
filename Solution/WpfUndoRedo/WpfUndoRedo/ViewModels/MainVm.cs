
using WpfUndoRedo.ViewModels.Commands;

namespace WpfUndoRedo.ViewModels
{
    public class MainVm : BaseVm
    {
        public CommandsVm Commands { get; } = new CommandsVm();
    }
}
