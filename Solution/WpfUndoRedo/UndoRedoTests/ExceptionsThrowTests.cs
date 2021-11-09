using System;
using NUnit.Framework;
using FluentAssertions;
using UndoRedoStack.Definitions;
using UndoRedoStack.Implementations;
using UndoRedoStack.Messaging;

namespace ReversibleValueTests
{
    public class ExceptionsThrowTests
    {
        [Test]
        public void OnArguments() {
            IReversible<short> reversible = new Reversible<short>(0);
            reversible.Value = 1;
            reversible.Value = 2;
            reversible.Value = -100;
            reversible.Invoking(x => x.Undo(0)).Should().Throw<ArgumentException>();
            reversible.Invoking(x => x.Undo(-1)).Should().Throw<ArgumentException>();

            reversible.Undo();
            reversible.Undo();
            reversible.Invoking(x => x.Redo(0)).Should().Throw<ArgumentException>();
            reversible.Invoking(x => x.Redo(-11)).Should().Throw<ArgumentException>();
        }

        [Test]
        public void OnInitialValue() {
            IReversible<short> reversible = new Reversible<short>(0);
            reversible.Invoking(x => x.Undo()).Should().Throw<CantUndoException>()
                .Where(e => !string.IsNullOrWhiteSpace(e.Message));

            reversible.Invoking(x => x.Redo()).Should().Throw<CantRedoException>()
                .Where(e => !string.IsNullOrWhiteSpace(e.Message));
        }

        [Test]
        public void OnDrivenValue() {
            throw new NotImplementedException();
        }


        [Test]
        public void OnOverStep() {
            throw new NotImplementedException();
        }

        [Test]
        public void OnOriginalGet() {
            throw new NotImplementedException();
        }

                [Test]
        public void OnOriginalSet() {
            throw new NotImplementedException();
        }

    }
}
