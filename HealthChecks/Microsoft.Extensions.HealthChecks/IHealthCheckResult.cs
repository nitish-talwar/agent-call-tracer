using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.HealthChecks
{
    public interface IHealthCheckResult
    {
        CheckStatus CheckStatus { get; }
        string Description { get; }
        IReadOnlyDictionary<string, object> Data { get; }
    }
}
