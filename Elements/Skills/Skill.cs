namespace AtrapaABarbie;

public class Skil
{
    public int Time { get; set; }
    private int _time;
    public SkillType Type { get; set; }
    public string Description { get; set; } = string.Empty;
    public virtual void Execute(Game game) { }
}
