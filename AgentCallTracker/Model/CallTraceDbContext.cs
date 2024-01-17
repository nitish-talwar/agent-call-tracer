using AgentCallTracker.Model;
using Microsoft.EntityFrameworkCore;

namespace AgentCallTracker.API.Model
{
    public interface ICallTraceDbContext
    {
        DbSet<AgentCallTrace> AgentCallTrace { get; set; }
    }
    public class CallTraceDbContext : DbContext, ICallTraceDbContext
    {
        public CallTraceDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<AgentCallTrace> AgentCallTrace { get; set; }
    }
}
