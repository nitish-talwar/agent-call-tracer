using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.HealthChecks
{
    public static class CachedHealthCheckExtensions
    {
        public static ValueTask<IHealthCheckResult> RunAsync(this CachedHealthCheck check, IServiceProvider serviceProvider)
        {
            Guard.ArgumentNotNull(nameof(check), check);

            return check.RunAsync(serviceProvider, CancellationToken.None);
        }
    }
}
