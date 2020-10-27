using Pipeline;

namespace Driver.Audio.UnitTests.WorkSet
{
    public class EmptyWorkflow : IWorkSet
    {
        public string Name { get; set; }

        public EmptyWorkflow()
        {
            Name = nameof(EmptyWorkflow);
        }

        public IWork Next()
        {
            return null;
        }
    }
}
