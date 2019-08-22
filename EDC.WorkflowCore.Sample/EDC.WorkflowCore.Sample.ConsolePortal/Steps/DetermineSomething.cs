using System;
using System.Collections.Generic;
using System.Text;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace EDC.WorkflowCore.Sample.ConsolePortal.Steps
{
    public class DetermineSomething : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            return ExecutionResult.Outcome(2);
        }
    }
}
