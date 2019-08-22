using WorkflowCore.Interface;
using System;
using WorkflowCore.Models;
using EDC.WorkflowCore.Sample.ConsolePortal.Steps;

namespace EDC.WorkflowCore.Sample.ConsolePortal.Workflows
{
    public class PassingDataWorkflow : IWorkflow<MyDataClass>
    {
        public string Id => "PassingDataWorkflow";

        public int Version => 1;

        public void Build(IWorkflowBuilder<MyDataClass> builder)
        {
            builder
                .StartWith(context =>
                {
                    Console.WriteLine("Starting workflow...");
                    return ExecutionResult.Next();
                })
                .Then<AddNumbers>()
                    .Input(step => step.Input1, data => data.Value1)
                    .Input(step => step.Input2, data => data.Value2)
                    .Output(data => data.Value3, step => step.Output)
                .Then<CustomMessage>()
                    .Name("Print custom message")
                    .Input(step => step.Message, data => "The answer is " + data.Value3.ToString())
                .Then(context =>
                {
                    Console.WriteLine("Workflow comeplete");
                    return ExecutionResult.Next();
                });
        }
    }

    public class MyDataClass
    {
        public int Value1 { get; set; }

        public int Value2 { get; set; }

        public int Value3 { get; set; }
    }
}
