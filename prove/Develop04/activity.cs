public abstract class Activity
{
    public string Name { get; set; }

    public string Description { get; set; }

    public int Duration { get; set; }
    public abstract void RunActivity(); 
}