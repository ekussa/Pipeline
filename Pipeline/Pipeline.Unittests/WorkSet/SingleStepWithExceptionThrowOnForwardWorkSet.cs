using Driver.Audio.UnitTests.Work;
using Pipeline.WorkSet;

namespace Driver.Audio.UnitTests.WorkSet
{
    public class SingleStepWithExceptionThrowOnForwardWorkSet : SingleStepWorkflow
    {
        public SingleStepWithExceptionThrowOnForwardWorkSet()
            : base(new ThrowsExceptionOnForwardWork())
        {
            Name = nameof(SingleStepWithExceptionThrowOnForwardWorkSet);
        }
    }
}
