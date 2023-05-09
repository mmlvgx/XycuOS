namespace XycuOS;

public class Command
{
    public string Name;

    public virtual void Run() { }

    public Command(string name)
    {
        this.Name = name;
    }
}
