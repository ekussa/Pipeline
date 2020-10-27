using System.Collections.Generic;
using Driver.Audio.UnitTests.Work;
using Driver.Audio.UnitTests.WorkSet;
using FluentAssertions;
using NUnit.Framework;
using Pipeline;

namespace Driver.Audio.UnitTests
{
    [TestFixture]
    public class DispatcherUnitTests
    {
        [Test]
        public void WhenHasNoLongerAnySteps_ShouldReturnNull()
        {
            //Arrange
            var dispatcher = new Dispatcher();
            dispatcher.Add(new EmptyWorkflow());

            //Act
            var result = dispatcher.Run(
                nameof(EmptyWorkflow),
                new Dictionary<string, string>());

            //Assert
            result.Should().BeNull();
        }

        [Test]
        public void WhenReturnExceptionSteppingForward_ShouldReturnException()
        {
            //Arrange
            var dispatcher = new Dispatcher();
            dispatcher.Add(new SingleStepWithExceptionReturnOnForwardWorkSet());

            //Act
            var result = dispatcher.Run(
                nameof(SingleStepWithExceptionReturnOnForwardWorkSet),
                new Dictionary<string, string>());

            //Assert
            result.Should().BeOfType(typeof(StepForwardException));
        }

        [Test]
        public void WhenReturnExceptionSteppingBothWays_ShouldReturnException()
        {
            //Arrange
            var dispatcher = new Dispatcher();
            dispatcher.Add(new SingleStepWithExceptionReturnOnBothWaysWorkflow());

            //Act
            var result = dispatcher.Run(
                nameof(SingleStepWithExceptionReturnOnBothWaysWorkflow),
                new Dictionary<string, string>());

            //Assert
            result.Should().BeOfType(typeof(StepBackwardException));
        }

        [Test]
        public void WhenThrowsExceptionSteppingForward_ShouldReturnException()
        {
            //Arrange
            var dispatcher = new Dispatcher();
            dispatcher.Add(new SingleStepWithExceptionThrowOnForwardWorkSet());

            //Act
            var result = dispatcher.Run(
                nameof(SingleStepWithExceptionThrowOnForwardWorkSet),
                new Dictionary<string, string>());

            //Assert
            result.Should().BeOfType(typeof(StepForwardException));
        }

        [Test]
        public void WhenThrowsExceptionSteppingBothWays_ShouldReturnException()
        {
            //Arrange
            var dispatcher = new Dispatcher();
            dispatcher.Add(new SingleStepWithExceptionThrowOnBothWaysWorkflow());

            //Act
            var result = dispatcher.Run(
                nameof(SingleStepWithExceptionThrowOnBothWaysWorkflow),
                new Dictionary<string, string>());

            //Assert
            result.Should().BeOfType(typeof(StepBackwardException));
        }
    }
}
