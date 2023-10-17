using Microsoft.EntityFrameworkCore;
using PocketMonsters.Controllers;
using PocketMonsters.Models;

namespace PocketMonsters.Tests;

public class UnitTest1
{
    private readonly PocketMonstersController _controller;
    private readonly PocketMonstersContext _context;

    public UnitTest1()
    {
        DbContextOptionsBuilder<PocketMonstersContext> opt = new();
        opt.UseInMemoryDatabase("PocketMonsters");

        _context = new PocketMonstersContext(opt.Options);
        _controller = new PocketMonstersController(_context);
    }

    [Fact]
    public async void TestStufs()
    {
        Species species = new()
        {
            Name = "Bulbasaur"
        };
        _controller.CreateSpecies(species);

        var dbResult = await _context.Species.Where(s => s.Name == "Bulbasaur").FirstOrDefaultAsync();

        Assert.Equal("Bulbasaur", dbResult.Name);
    }
}