using System.Linq;
using WorkflowCore.Interface;
using EDC.WorkflowCore.Sample.WebPortal.Models;
using EDC.WorkflowCore.Sample.WebPortal.Steps;

namespace EDC.WorkflowCore.Sample.WebPortal.Workflows
{
    public class XdpDataWorkflow : IWorkflow<XdpData>
    {
        public string Id => "XdpDataWorkflow";

        public int Version => 1;

        public void Build(IWorkflowBuilder<XdpData> builder)
        {
            builder
                .StartWith<HelloWorld>()
                .If(data => data.Id < 3).Do(then => then
                        .StartWith<PrintMessage>()
                            .Input(step => step.Message, data => "Passed Id is less than 3")
                )
               .If(data => data.Id < 5).Do(then => then
                        .StartWith<PrintMessage>()
                            .Input(step => step.Message, data => "Passed Id is less than 5")
                )
                .Then<GoodbyeWorld>();
        }
    }
}
