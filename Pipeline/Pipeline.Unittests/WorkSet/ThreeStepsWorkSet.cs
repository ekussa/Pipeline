using System.Collections.Generic;
using Driver.Audio.UnitTests.Work;
using Pipeline;
using Pipeline.Work;
using Pipeline.WorkSet;

namespace Driver.Audio.UnitTests.WorkSet
{
    public class ThreeStepsWorkSet : MultipleStepsWorkSet
    {
        public ThreeStepsWorkSet()
            : base(new List<IWork>
            {
                new DelayWork(),
                new EmptyWork(),
                new DelayWork(),
            })
        {
            Name = nameof(ThreeStepsWorkSet);
        }
    }
}
