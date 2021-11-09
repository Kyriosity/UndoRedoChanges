using NUnit.Framework;
using FluentAssertions;
using UndoRedoStack.Definitions;
using UndoRedoStack.Implementations;

namespace ReversibleValueTests
{
    public class ReferencedReversibleTests
    {
        const string Init = "initial";
        const string Modi = "modified";
        const string Nonsense = "lorem ipsum";
        const string Incantation = "Abracadabra";

        [Test]
        public void Strings() {
            IReversible<string> reversible = new Reversible<string>(Init);
            reversible.Value = Modi;
            reversible.Undo();
            reversible.Value.Should().Be(Init);
            reversible.Value = Incantation;
            reversible.Redo();
            reversible.Value.Should().Be(Modi);
        }

        [Test]
        public void Objects() {
            var id = 0;
            IReversible<TestSubject> reversible = new Reversible<TestSubject>(
                new TestSubject { Id = ++id, Name = Init });
            reversible.Value = new TestSubject { Id = ++id, Name = Modi };
            reversible.Value = new TestSubject { Id = ++id, Name = Nonsense };

            var spell = new TestSubject { Id = ++id, Name = Incantation };
            reversible.Value = spell;

            do {
                reversible.Undo();
                reversible.Value.Name.Should().NotBe(spell.Name);
                reversible.Value.Id.Should().NotBe(spell.Id);
            } while (reversible.HasUndo);
        }

        private class TestSubject
        {
            public string Name { get; init; }
            public int Id { get; init; }
        }
    }
}
