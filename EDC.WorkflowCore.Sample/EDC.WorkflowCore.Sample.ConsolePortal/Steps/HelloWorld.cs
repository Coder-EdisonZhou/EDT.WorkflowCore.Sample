using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace EDC.WorkflowCore.Sample.ConsolePortal.Steps
{
    public class HelloWorld : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Hello World!");
            return ExecutionResult.Next();
        }
    }
}
