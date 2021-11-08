using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UndoRedoStack.Definitions;
using UndoRedoStack.Messaging;

namespace UndoRedoStack.Implementations
{
    public class Reversible<T> : IReversible<T>
    {
        public Reversible(T value) {
            _stack.Add(value);
        }

        private readonly List<T> _stack = new();
        private int _index;

        public bool HasUndo => 1 + _index > 0;
        public bool HasRedo => 1 + _index < _stack.Count;
        public int Limit { get; init; }

        public T Value { get => GetCurrent(); set => Add(value); }

        public void Undo(int steps = 1) {
            _index = GuardSteps(steps, _index - steps);
        }

        public void Redo(int steps = 1) {
            _index = GuardSteps(steps, _index + steps);
        }

        protected virtual T GetCurrent() {
            return _stack[_index];
        }

        protected virtual void Add(T value) {
            _stack.Add(value);
            _index++;
        }

        private int GuardSteps(int steps, int newIndex, [CallerMemberName] string caller = "<unknown>") {
            if (0 <= steps)
                throw new ArgumentException($"{caller}: {nameof(steps)} must be positive value ({steps} supplied)");

            if (0 > newIndex)
                throw new CantUndoException($"{nameof(steps)}: {steps}");

            if (_stack.Count <= newIndex)
                throw new CantRedoException($"{nameof(steps)}: {steps}");

            return newIndex;
        }
    }
}
