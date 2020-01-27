using DecisionTree.Core.Entitites;
using FluentAssertions;
using Xunit;

namespace DecisionTree.Tests.Core.Entitites
{
    public class DecisionTreeConditionTest
    {
        public class AddSubConditions
        {
            [Fact]
            public void ShouldAddSubConditions()
            {
                DecisionTreeCondition condition = new DecisionTreeCondition("text 1");

                condition.AddSubConditions(SubConditionYes, SubConditionNo);

                condition.Yes.Should().Be(SubConditionYes);
                condition.No.Should().Be(SubConditionNo);
            }
        }

        public class IsLastCondition
        {
            [Fact]
            public void ShouldReturnTrue_WhenThereAreNoSubConditions()
            {
                DecisionTreeCondition condition = new DecisionTreeCondition("text 1");

                condition.IsLastCondition.Should().BeTrue();
            }

            [Fact]
            public void ShouldReturnFalse_WhenThereAreSubConditions()
            {
                DecisionTreeCondition condition = new DecisionTreeCondition("text 1");

                condition.AddSubConditions(SubConditionYes, SubConditionNo);

                condition.IsLastCondition.Should().BeFalse();
            }
        }

        private static DecisionTreeCondition SubConditionYes = new DecisionTreeCondition("text 2");
        private static DecisionTreeCondition SubConditionNo = new DecisionTreeCondition("text 3");
    }
}
