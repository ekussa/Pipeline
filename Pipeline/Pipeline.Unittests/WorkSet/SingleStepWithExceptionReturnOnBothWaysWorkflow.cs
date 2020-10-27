using Driver.Audio.UnitTests.Work;
using Pipeline.WorkSet;

namespace Driver.Audio.UnitTests.WorkSet
{
    public class SingleStepWithExceptionReturnOnBothWaysWorkflow : SingleStepWorkflow
    {
        public SingleStepWithExceptionReturnOnBothWaysWorkflow()
        : base(new ReturnExceptionOnBothWaysWork())
        {
            Name = nameof(SingleStepWithExceptionReturnOnBothWaysWorkflow);
        }
    }
}
