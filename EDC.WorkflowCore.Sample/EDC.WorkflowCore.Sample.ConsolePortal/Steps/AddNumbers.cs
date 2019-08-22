using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace EDC.WorkflowCore.Sample.ConsolePortal.Steps
{
    public class AddNumbers : StepBody
    {
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public int Output { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Output = (Input1 + Input2);
            return ExecutionResult.Next();
        }
    }
}
