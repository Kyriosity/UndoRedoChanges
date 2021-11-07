
namespace WpfUndoRedo.ViewModels.Commands
{
    public class CommandsVm : BaseVm
    {
        public bool Applies { get; set; }

        public FileCommandsVm File { get; } = new FileCommandsVm();

        public EditCommandsVm Edit { get; set; } = new EditCommandsVm();

    }
}
