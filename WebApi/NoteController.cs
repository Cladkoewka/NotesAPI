using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace WebApi;

[ApiController]
[Route("Note")]
public class NoteController(INoteService noteService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateAsync(string text)
    {
        await noteService.CreateAsync(text);
        return NoContent();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetNoteAsync([FromRoute] int id)
    {
        var result = await noteService.GetByIdAsync(id);
        return Ok(result);
    }
    
    [HttpPut("{id:int}")]
    public async Task<ActionResult> UpdateNoteAsync([FromRoute] int id, string newText)
    {
        await noteService.UpdateAsync(id, newText);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteNoteAsync([FromRoute] int id)
    {
        await noteService.DeleteAsync(id);
        return NoContent();
    }
}