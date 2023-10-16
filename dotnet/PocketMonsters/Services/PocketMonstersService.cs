using PocketMonsters.Models;

namespace PocketMonsters.Services
{
    public class PocketMonstersService
    {
        private readonly PocketMonstersContext _context;

        public PocketMonstersService(PocketMonstersContext context)
        {
            _context = context;
        }
    }
}