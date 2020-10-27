using Driver.Audio.UnitTests.Work;
using Pipeline.WorkSet;

namespace Driver.Audio.UnitTests.WorkSet
{
    public class SingleStepWithExceptionReturnOnForwardWorkSet : SingleStepWorkflow
    {
        public SingleStepWithExceptionReturnOnForwardWorkSet()
            : base(new ReturnExceptionOnForwardWork())
        {
            Name = nameof(SingleStepWithExceptionReturnOnForwardWorkSet);
        }
    }
}
