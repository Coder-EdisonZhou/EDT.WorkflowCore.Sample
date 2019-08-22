using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace EDC.WorkflowCore.Sample.ConsolePortal.Steps
{
    public class GoodbyeWorld : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Goodbye World!");
            return ExecutionResult.Next();
        }
    }
}
