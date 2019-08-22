using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace EDC.WorkflowCore.Sample.ConsolePortal.Steps
{
    public class ActiveWorld : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("I am activing in the World!");
            return ExecutionResult.Next();
        }
    }
}
