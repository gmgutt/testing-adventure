using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PocketMonsters.Models;

namespace PocketMonsters.Controllers;

[ApiController]
public class PocketMonstersController : ControllerBase
{
    private readonly PocketMonstersContext _context;

    public PocketMonstersController(PocketMonstersContext context)
    {
        _context = context;
    }

    [HttpGet("species/{id}")]
    public async Task<List<Species>> getSpecies(long id)
    {
        return await _context.Species.Where(s => s.Id == id).ToListAsync();
    }

    [HttpPost("species")]
    public async void createSpecies([FromBody] Species species)
    {
        await _context.AddAsync<Species>(species);

        await _context.SaveChangesAsync();
    }
}