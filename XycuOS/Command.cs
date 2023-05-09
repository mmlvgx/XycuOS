namespace XycuOS;

public class Command
{
    public string Name;
    public string Description;

    public virtual void Run() { }

    public Command(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }
}
