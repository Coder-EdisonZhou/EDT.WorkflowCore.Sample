using WorkflowCore.Interface;
using EDC.WorkflowCore.Sample.ConsolePortal.Steps;

namespace EDC.WorkflowCore.Sample.ConsolePortal.Workflows
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public string Id => "HelloWorld";

        public int Version => 1;

        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .StartWith<HelloWorld>()
                .Then<ActiveWorld>()
                .Then<GoodbyeWorld>();
        }
    }
}
