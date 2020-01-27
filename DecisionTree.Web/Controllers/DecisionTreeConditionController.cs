using DecisionTree.Core.Entitites;
using KnowledgeBase.Core.Infrastructure.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DecisionTree.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecisionTreeConditionController : ControllerBase
    {
        private readonly IDecisionTreeConditionService _service;

        public DecisionTreeConditionController(IDecisionTreeConditionService service)
        {
            _service = service;
        }

        [HttpGet]
        public DecisionTreeCondition Get()
        {
            return _service.Get();
        }
    }
}
