
namespace UndoRedoStack.Definitions
{
    public interface IUndoRedo
    {
        void Undo(int steps = 1);
        void Redo(int steps = 1);
    }

    public interface IUndoable
    {
        bool HasUndo { get; }
        bool HasRedo { get; }
    }

    public interface IReversible<T> : IUndoRedo, IUndoable
    {
        int Limit { get; }
        T Value { get; set; }
    }

    public interface IKeepingOrigin<T>
    {
        T GetOrigin();
        void SetAsOrigin(int index);
    }
}
