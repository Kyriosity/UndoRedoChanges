using NUnit.Framework;
using FluentAssertions;
using UndoRedoStack.Implementations;
using UndoRedoStack.Definitions;

namespace UndoRedoTests
{
    public class BaseReversibleTests
    {
        [Test]
        public void Availbility() {
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


    }
}