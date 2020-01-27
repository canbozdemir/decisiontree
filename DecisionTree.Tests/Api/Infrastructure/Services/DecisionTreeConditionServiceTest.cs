using DecisionTree.Core.Entitites;
using DecisionTree.Web.Infrastructure.Services;
using FluentAssertions;
using KnowledgeBase.Core.Infrastructure.Queries;
using KnowledgeBase.Core.Infrastructure.Repositories;
using Moq;
using Xunit;

namespace DecisionTree.Tests.Api.Infrastructure.Services
{
    public class DecisionTreeConditionServiceTest
    {
        public class Get
        {
            [Fact]
            public void ShouldReturnDecisionTreeCondition_WhenThereIsACondition()
            {
                Mock<IDecisionTreeConditionRepository> repository = new Mock<IDecisionTreeConditionRepository>();
                IDecisionTreeConditionService service = new DecisionTreeConditionService(repository.Object);

                repository.Setup(x => x.Get()).Returns(DecisionTreeCondition);

                var response = service.Get();

                response.Should().Be(DecisionTreeCondition);
            }

            [Fact]
            public void ShouldReturnNull_WhenThereIsNoCondition()
            {
                Mock<IDecisionTreeConditionRepository> repository = new Mock<IDecisionTreeConditionRepository>();
                IDecisionTreeConditionService service = new DecisionTreeConditionService(repository.Object);

                repository.Setup(x => x.Get()).Returns((DecisionTreeCondition)null);

                var response = service.Get();

                response.Should().BeNull();
            }
        }

        private static DecisionTreeCondition DecisionTreeCondition = new DecisionTreeCondition("text 1");
    }
}
