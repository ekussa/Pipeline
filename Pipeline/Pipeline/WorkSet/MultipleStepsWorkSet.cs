using System.Collections.Generic;
using System.Linq;

namespace Pipeline.WorkSet
{
    public abstract class MultipleStepsWorkSet : IWorkSet
    {
        private int _nextStepIndex;
        private readonly List<IWork> _orderedSteps;

        public string Name { get; set; }

        protected MultipleStepsWorkSet(IEnumerable<IWork> orderedSteps)
        {
            _orderedSteps = orderedSteps.ToList();
        }

        public IWork Next()
        {
            if (_nextStepIndex >= _orderedSteps.Count)
                return null;
            return _orderedSteps[_nextStepIndex++];
        }
    }
}
