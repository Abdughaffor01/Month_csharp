public class Figther
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Demage { get; set; }
    int bron, level;
    public Figther(string name, int health, int demage, int bron, int level)
    {
        Name = name;
        Health = health;
        Demage = demage;
        this.bron = bron;
        this.level = level;
    }
    public string InfoFigther() => $"Боец-{Name} : Здоровье-{Health} : Урон-{Demage} : Броня-{bron} : Уровен-{level}";
    public string ShowHealth() => $"{Name} : Здоровье - {Health}";
    public void TakeDamage(int demage)
    {
        Health -= demage - bron;
        bron--;
    }
}