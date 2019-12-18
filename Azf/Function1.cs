using System;
using Azf.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Unity;

namespace Azf
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            var userid =  DIContainer.Container.Resolve<IUserService>().GetUserId();

            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
