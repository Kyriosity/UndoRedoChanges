using NUnit.Framework;
using FluentAssertions;
using UndoRedoStack.Definitions;
using UndoRedoStack.Implementations;

namespace UndoRedoTests
{
    public class BaseReversibleTests
    {
        [Test]
        public void Availability() {
            IReversible<int> reversible = new Reversible<int>(100);
            reversible.HasUndo.Should().BeFalse();
            reversible.HasRedo.Should().BeFalse();

            reversible.Value = 220;
            reversible.HasUndo.Should().BeTrue();
            reversible.HasRedo.Should().BeFalse();

            reversible.Undo();
            reversible.HasUndo.Should().BeFalse();
            reversible.HasRedo.Should().BeTrue();
        }

        [Test]
        public void ValueBasics() {
            IReversible<short> reversible = new Reversible<short>(-5);

            reversible.Value = 3;
            reversible.Value.Should().Be(3);

            reversible.Undo();
            reversible.Value.Should().Be(-5);

            reversible.Redo();
            reversible.Value.Should().Be(3);
        }

        [Test]
        public void MultiStep() {
            throw new System.NotImplementedException();
        }
    }
}