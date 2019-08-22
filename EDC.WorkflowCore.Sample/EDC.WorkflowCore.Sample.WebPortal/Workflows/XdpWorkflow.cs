using WorkflowCore.Interface;
using EDC.WorkflowCore.Sample.WebPortal.Steps;

namespace EDC.WorkflowCore.Sample.WebPortal.Workflows
{
    public class XdpWorkflow : IWorkflow
    {
        public string Id => "XdpWorkflow";

        public int Version => 1;

        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .StartWith<HelloWorld>()
                .Then<GoodbyeWorld>();
        }
    }
}
