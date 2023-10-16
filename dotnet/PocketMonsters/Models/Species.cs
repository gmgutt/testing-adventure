namespace PocketMonsters.Models
{
    public class Species
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int BaseHp { get; set; }
        public int BaseAttack { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseSpecialDefense { get; set; }
        public int BaseSpeed { get; set; }
    }
}