using DataAccess;

namespace BusinessLogic;

internal class NoteService(INoteRepository noteRepository) : INoteService
{
    public async Task CreateAsync(string text, CancellationToken cancellationToken = default)
    {
        var note = new Note
        {
            Text = text
        };

        await noteRepository.CreateAsync(note);
    }

    public async Task<string> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var note = await noteRepository.GetByIdAsync(id, cancellationToken);
        if (note is null)
            throw new Exception("Note not Found");

        return note.Text;
    }

    public async Task UpdateAsync(int id, string newText, CancellationToken cancellationToken = default)
    {
        var note = await noteRepository.GetByIdAsync(id, cancellationToken);
        if (note is null)
            throw new Exception("Note not Found");

        note.Text = newText;
        await noteRepository.UpdateAsync(note, cancellationToken);
    }

    public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var note = await noteRepository.GetByIdAsync(id, cancellationToken);
        if (note is null)
            throw new Exception("Note not Found");

        await noteRepository.DeleteAsync(note, cancellationToken);
    }
}