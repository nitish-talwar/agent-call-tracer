using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgentCallTracker.Model
{
    public class AgentCallTrace
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid AgentTraceId { get; set; }
        public DateTime CallTraceBeginTime { get; set; }

        public DateTime CallTraceEndTime { get; set; }

        [MaxLength(64)]
        public string AgentId { get; set; }

        [MaxLength(64)]
        public string AcdId { get; set; }
        [MaxLength(64)]
        public string TelephonyEnterpriseId { get; set; }
    }
}
