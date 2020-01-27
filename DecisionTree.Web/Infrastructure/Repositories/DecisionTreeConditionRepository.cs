using DecisionTree.Core.Entitites;
using KnowledgeBase.Core.Infrastructure.Repositories;

namespace DecisionTree.Web.Infrastructure.Repositories
{
    public class DecisionTreeConditionRepository : IDecisionTreeConditionRepository
    {
        public DecisionTreeCondition Get()
        {
            var condition4 = new DecisionTreeCondition("Is it a good doughnut?");
            var condition4Yes = new DecisionTreeCondition("What are you waiting for? Grab it now.");
            var condition4No = new DecisionTreeCondition("Wait 'til you find a sinful, unforgettable doughnut.");
            condition4.AddSubConditions(condition4Yes, condition4No);

            var condition3 = new DecisionTreeCondition("Are you sure?");
            var condition3Yes = new DecisionTreeCondition("Get it.");
            var condition3No = new DecisionTreeCondition("Do jumping jacks first.");
            condition3.AddSubConditions(condition3Yes, condition3No);

            var condition2 = new DecisionTreeCondition("Do I deserve it?");
            condition2.AddSubConditions(condition3, condition4);

            var condition1 = new DecisionTreeCondition("DO I WANT A DOUGHNUT?");
            var condition1No  = new DecisionTreeCondition("Maybe you want an apple?");
            condition1.AddSubConditions(condition2, condition1No);

            return condition1;
        }
    }
}
