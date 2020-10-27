using Driver.Audio.UnitTests.Work;
using Pipeline.WorkSet;

namespace Driver.Audio.UnitTests.WorkSet
{
    public class SingleStepWithExceptionThrowOnBothWaysWorkflow : SingleStepWorkflow
    {
        public SingleStepWithExceptionThrowOnBothWaysWorkflow()
        : base(new ThrowsExceptionOnBothWaysWork())
        {
            Name = nameof(SingleStepWithExceptionThrowOnBothWaysWorkflow);
        }
    }
}
