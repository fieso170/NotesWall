using NotesWall.Notes;

namespace NotesWall.Tests;

public class NoteRulesTests
{
    [Fact]
    public void ValidNoteIsAccepted()
    {
        var result = NoteRules.IsValid("Merci pour ton aide sur le projet!");

        Assert.True(result);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void InvalidNoteIsRejected(string? content)
    {
        var result = NoteRules.IsValid(content);

        Assert.False(result);
    }

    [Fact]
    public void Une_note_trop_longue_est_refusee()
    {
        var content = new string('a', NoteRules.MaxLength + 1);

        var result = NoteRules.IsValid(content);

        Assert.False(result);
    }
}