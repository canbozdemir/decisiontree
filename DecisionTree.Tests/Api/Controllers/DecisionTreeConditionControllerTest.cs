using DecisionTree.Core.Entitites;
using DecisionTree.Web.Controllers;
using FluentAssertions;
using KnowledgeBase.Core.Infrastructure.Queries;
using Moq;
using Xunit;

namespace DecisionTree.Tests.Api.Controllers
{
    public class DecisionTreeConditionTest
    {
        public class Get
        {
            [Fact]
            public void ShouldReturnDecisionTreeCondition()
            {
                Mock<IDecisionTreeConditionService> service = new Mock<IDecisionTreeConditionService>();
                DecisionTreeConditionController controller = new DecisionTreeConditionController(service.Object);

                service.Setup(x => x.Get()).Returns(DecisionTreeCondition);

                var response = controller.Get();

                response.Should().Be(DecisionTreeCondition);
            }
        }

        private static DecisionTreeCondition DecisionTreeCondition = new DecisionTreeCondition("text 1");
    }
}
