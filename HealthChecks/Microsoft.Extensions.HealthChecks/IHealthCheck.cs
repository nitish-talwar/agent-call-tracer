using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.HealthChecks
{
    public interface IHealthCheck
    {
        ValueTask<IHealthCheckResult> CheckAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
