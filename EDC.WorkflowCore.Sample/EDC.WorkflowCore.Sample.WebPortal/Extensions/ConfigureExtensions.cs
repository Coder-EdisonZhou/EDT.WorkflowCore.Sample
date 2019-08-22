using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using WorkflowCore.Interface;
using EDC.WorkflowCore.Sample.WebPortal.Models;
using EDC.WorkflowCore.Sample.WebPortal.Workflows;

namespace EDC.WorkflowCore.Sample.WebPortal.Extensions
{
    public static class ConfigureExtensions
    {
        public static IApplicationBuilder UseXdpWorkflow(this IApplicationBuilder app)
        {
            var host = app.ApplicationServices.GetService<IWorkflowHost>();
            host.RegisterWorkflow<XdpWorkflow>();
            host.RegisterWorkflow<XdpDataWorkflow, XdpData>();
            host.Start();

            var appLifetime = app.ApplicationServices.GetService<IApplicationLifetime>();
            appLifetime.ApplicationStopping.Register(() =>
            {
                host.Stop();
            });

            return app;
        }
    }
}
