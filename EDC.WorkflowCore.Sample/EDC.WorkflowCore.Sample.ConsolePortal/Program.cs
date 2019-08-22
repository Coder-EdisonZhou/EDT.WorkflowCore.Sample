using Microsoft.Extensions.DependencyInjection;
using System;
using WorkflowCore.Interface;
using EDC.WorkflowCore.Sample.ConsolePortal.Workflows;

namespace EDC.WorkflowCore.Sample.ConsolePortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            var host = serviceProvider.GetService<IWorkflowHost>();
            host.RegisterWorkflow<HelloWorldWorkflow>();
            host.RegisterWorkflow<OutcomeWorkflow, MyData>();
            host.Start();

            // Demo1: Hello World
            //host.StartWorkflow("HelloWorld");

            // Demo2:Multiple Outcome
            //Console.WriteLine("Starting workflow...");
            //string workflowId = host.StartWorkflow("outcompe-sample").Result;

            // Demo3: Passing data between steps


            Console.ReadKey();
            host.Stop();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddLogging(); // WorkflowCore需要用到logging service
            services.AddWorkflow(x => x.UseMySQL(@"Server=192.168.16.150;Database=xdp_delivery_workflow;User=xdpdev;Password=xilifexdp;", true, true));

            var serviceProvider = services.BuildServiceProvider();

            //var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            //loggerFactory.AddDebug();
            return serviceProvider;
        }
    }
}
