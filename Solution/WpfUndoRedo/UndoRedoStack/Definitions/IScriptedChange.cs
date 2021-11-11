
namespace ReversibleValue.Definitions
{
    public interface IScriptedChange<T>
    {
        // KD: this comment will be deleted as a concept of change is ready
        void Apply();
        void Rollback();
    }
}
