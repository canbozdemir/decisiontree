using DecisionTree.Core.Entitites;
using KnowledgeBase.Core.Infrastructure.Queries;
using KnowledgeBase.Core.Infrastructure.Repositories;

namespace DecisionTree.Web.Infrastructure.Services
{
    public class DecisionTreeConditionService : IDecisionTreeConditionService
    {
        private readonly IDecisionTreeConditionRepository _repository;

        public DecisionTreeConditionService(IDecisionTreeConditionRepository repository)
        {
            _repository = repository;
        }

        public DecisionTreeCondition Get()
        {
            return _repository.Get();
        }
    }
}
