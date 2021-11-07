using System;

namespace UndoRedoStack.Messaging
{
    [Serializable]
    public abstract class UndoRedoException : Exception
    {
        public UndoRedoException(string message) : base(message) { }
//        public UndoRedoException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class CantUndoException : UndoRedoException
    {
        public CantUndoException(string message) : base(message) { }
    }

    public class CantRedoException : UndoRedoException
    {
        public CantRedoException(string message) : base(message) { }
    }
}
