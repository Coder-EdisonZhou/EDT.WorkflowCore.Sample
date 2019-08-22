using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using EDC.WorkflowCore.Sample.WebPortal.Models;

namespace EDC.WorkflowCore.Sample.WebPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IWorkflowController _workflowService;

        public ValuesController(IWorkflowController workflowService)
        {
            _workflowService = workflowService;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            await _workflowService.StartWorkflow("XdpWorkflow");
            return new string[] { "XdpWorkflow v1" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            await _workflowService.StartWorkflow("XdpDataWorkflow", new XdpData() { Id = id });
            return "XdpDataWorkflow v1";
        }
    }
}
