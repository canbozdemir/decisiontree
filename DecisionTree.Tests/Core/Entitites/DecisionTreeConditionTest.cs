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
                DecisionTreeCondition condition = new DecisionTreeCondition("text 2");

                condition.AddSubConditions(DecisionTreeConditionYes, DecisionTreeConditionNo);

                condition.Yes.Should().Be(DecisionTreeConditionYes);
                condition.No.Should().Be(DecisionTreeConditionNo);
            }
        }

        private static DecisionTreeCondition DecisionTreeConditionYes = new DecisionTreeCondition("text 2");
        private static DecisionTreeCondition DecisionTreeConditionNo = new DecisionTreeCondition("text 3");
    }
}
