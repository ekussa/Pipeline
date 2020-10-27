
namespace Pipeline
{
    public interface IWorkSet
    {
        string Name { get; set; }
        IWork Next();
    }
}
