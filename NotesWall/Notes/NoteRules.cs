namespace NotesWall.Notes;

public static class NoteRules
{
    public const int MaxLength = 280;

    public static bool IsValid(string? content)
    {
        if (string.IsNullOrWhiteSpace(content))
            return false;

        return content.Trim().Length <= MaxLength;
    }
}